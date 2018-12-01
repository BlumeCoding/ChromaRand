Imports System.IO

Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim verzeichnis As String
        Dim dateiliste() As String
        Dim i As Integer
        verzeichnis = Directory.GetCurrentDirectory()
        verzeichnis2 = "C:/Users/" + Environment.UserName


        dateiliste = Directory.GetFiles(verzeichnis, "*.udaadhuidhd78932739082370djhlds") 'einfach hier *.XXX entsprechende Endung eingeben
        dateiliste = Directory.GetFiles(verzeichnis2, "*.udaadhuidhd78932739082370djhlds") 'einfach hier *.XXX entsprechende Endung eingeben

        For i = 0 To dateiliste.Count - 1
            ListBox1.Items.Add(dateiliste(i))
        Next
    End Sub
End Class