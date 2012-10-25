Option Explicit On
Option Strict On

Imports DocsVision.Platform.ObjectManager

Public Class MainForm

    Private m_oConnectionStrings As New List(Of ConS)
    Private TestCardID As Guid = New Guid("{303BABDF-8C57-4148-B84B-CD8EC20F96F3}")

    Private Structure ConS
        Dim ConString As String
        Dim Name As String
    End Structure

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        SaveParams()
        PrintResult(vbNullString)
        SwitchControls()
        If PrepareTest() = False Then SwitchControls() : Exit Sub
        pbProgress.Visible = True
        pbProgress.Value = 0
        pbProgress.Maximum = 310
        DoTest()
        SwitchControls()
        pbProgress.Visible = False
    End Sub

    Private Function PrepareTest() As Boolean

        ' Create test card in database

        Dim bResult As Boolean = False  ' result flag

        ' Get first connection string (HTTP+SOAP)
        Dim sConnection As String = GetConnectionString(m_oConnectionStrings(0).Constring, My.Settings.ServerName, My.Settings.VirtualFolder, My.Settings.Port)
        Dim US As UserSession
        Dim SM As SessionManager

        Try
            ' Create DocsVision session
            SM = SessionManager.CreateInstance
            If CheckBox1.Checked Then
                SM.Connect(sConnection, My.Settings.Base, My.Settings.Login, My.Settings.Password)
            Else
                SM.Connect(sConnection, My.Settings.Base)
            End If
            US = SM.CreateSession

            ' Try to get card. OK if exist.
            Try
                Dim oCard = US.CardManager.GetCardData(TestCardID)
                If oCard IsNot Nothing Then bResult = True
            Catch ex As Exception

            End Try

            If Not bResult Then
                US.CardManager.CreateCardData(New Guid("{425DD1AC-8DF1-49F0-9A06-FA61381C4FEC}"), TestCardID)
                bResult = True
            End If

        Catch ex As Exception
            MsgBox("Error with creating test card." + vbCrLf + ex.Message)
            bResult = False
        Finally
            If US IsNot Nothing Then SM.CloseSession(US.Id)
        End Try

        Return bResult
    End Function

    Private Sub DoTest()

        Dim iResults As New List(Of Integer)

        For Each sConnectionPattern In m_oConnectionStrings
            My.Application.DoEvents()
            Dim sResult As String = ""
            Dim sConnection As String = GetConnectionString(sConnectionPattern.Constring, My.Settings.ServerName, My.Settings.VirtualFolder, My.Settings.Port)
            sResult += "Protocol [" + sConnectionPattern.Name + "]" + vbCrLf + "--->"


            Dim iResult As Integer = 0
            Try
                Dim SM As SessionManager = SessionManager.CreateInstance
                If CheckBox1.Checked Then
                    SM.Connect(sConnection, My.Settings.Base, My.Settings.Login, My.Settings.Password)
                Else
                    SM.Connect(sConnection, My.Settings.Base)
                End If

                Dim US As UserSession = SM.CreateSession



                Dim oCard As CardData

                Dim iTempResults As New List(Of Integer)
                For k = 1 To 5
                    Dim oFirstTime As DateTime = DateTime.Now
                    For i = 1 To 10
                        oCard = US.CardManager.GetCardData(TestCardID)
                        US.CardManager.PurgeCache()
                        pbProgress.Value += 1
                    Next
                    iTempResults.Add((DateTime.Now - oFirstTime).Milliseconds)
                    System.Threading.Thread.Sleep(5000)
                    pbProgress.Refresh()
                Next

                iResult = CInt(iTempResults.Average)


                sResult += iResult.ToString + " мс"
                SM.CloseSession(US.Id)

            Catch ex As Exception
                If cbShowErrors.Checked = False Then sResult += "[ERROR]" Else sResult += "[ERROR] " + ex.ToString
            End Try

            iResults.Add(iResult)

            PrintResult(sResult)



        Next

        Dim iMaxValue As Integer = iResults.Max


    End Sub

    Private Sub PrintResult(ByVal Message As String)
        If Message = vbNullString Then txtResult.Text = vbNullString : Exit Sub
        txtResult.Text += Message + vbCrLf
    End Sub

    Private Sub SwitchControls()
        For Each c As Control In Me.Controls
            c.Enabled = Not c.Enabled
        Next
    End Sub

    Private Function GetConnectionString(ByVal Pattern As String, ByVal Server As String, ByVal VirtualFolder As String, ByVal Port As String) As String
        If InStr(Pattern, "http") > 0 Then
            If Port <> vbNullString Then
                Server = Server + ":" + Port
            End If
        End If

        If InStr(Pattern, "{1}") > 0 Then
            Return String.Format(Pattern, Server, VirtualFolder)
        Else
            Return String.Format(Pattern, Server)
        End If
    End Function

    Private Sub Initialize()
        Dim oC As ConS

        With m_oConnectionStrings
            oC.Name = "HTTP+SOAP"
            oC.Constring = "http://{0}/{1}/StorageServer/StorageServerService.asmx"
            .Add(oC)

            oC.Name = "HTTP+Binary"
            oC.Constring = "http://{0}/{1}/StorageServer/StorageServerService.rem"
            .Add(oC)

            oC.Name = "Named pipe"
            oC.Constring = "\\{0}\Pipe\DocsVision45\StorageServer"
            .Add(oC)

            oC.Name = "WCF HTTP+SOAP"
            oC.Constring = "http://{0}/{1}/StorageServer/StorageServerService.svc"
            .Add(oC)

            oC.Name = "WCF TCP"
            oC.Constring = "net.tcp://{0}:8085/DocsVision/StorageServer/StorageServerService.svc"
            .Add(oC)

            oC.Name = "WCF Named pipe"
            oC.Constring = "net.pipe://{0}/DocsVision45/StorageServer/StorageServerService.svc"
            .Add(oC)
        End With
    End Sub

    Private Sub ReadParams()
        With My.Settings
            txtLogin.Text = .Login
            txtPassword.Text = .Password
            txtServerName.Text = .ServerName
            txtVirtualFolder.Text = .VirtualFolder
            txtPort.Text = .Port
            txtBaseName.Text = .Base
        End With
    End Sub

    Private Sub SaveParams()
        With My.Settings
            .Login = txtLogin.Text
            .Password = txtPassword.Text
            .ServerName = txtServerName.Text
            .VirtualFolder = txtVirtualFolder.Text
            .Port = txtPort.Text
            .Base = txtBaseName.Text
        End With
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        txtLogin.Enabled = CheckBox1.Checked
        txtPassword.Enabled = CheckBox1.Checked

    End Sub


    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Initialize()
        ReadParams()
    End Sub
End Class
