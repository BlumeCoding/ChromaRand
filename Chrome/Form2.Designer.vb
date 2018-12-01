<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(995, 460)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 3
        '
        'Timer2
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Get Decryption Key"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(241, 206)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 24)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Send Pin"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer3
        '
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(339, 206)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(316, 24)
        Me.TextBox1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(2, 266)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 178)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(170, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 156)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "47"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(410, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 139)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = ":"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(317, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 156)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "59"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(450, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 156)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "59"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(277, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 139)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = ":"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(-6, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(699, 45)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "YOUR PERSONAL FILES HAVE BEEN ENCRYPTED"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(2, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(671, 142)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = resources.GetString("GroupBox2.Text")
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(339, 236)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox2.Size = New System.Drawing.Size(316, 24)
        Me.TextBox2.TabIndex = 37
        Me.TextBox2.Text = "1NwWVZa71C9QGsksK5mG3v3t11Ek8dR6eu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(226, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 18)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Bitcoin Adress:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 247)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(188, 29)
        Me.Button3.TabIndex = 39
        Me.Button3.Text = "View"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(707, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All Your files have been encrypted"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer3 As Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
