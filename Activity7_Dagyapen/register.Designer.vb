<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        LinkLabel1 = New LinkLabel()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 0
        Label1.Text = "FIRST NAME"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 54)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(166, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(223, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 0
        Label2.Text = "BIRTH DATE"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(194, 54)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(166, 23)
        TextBox2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(376, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 15)
        Label3.TabIndex = 0
        Label3.Text = "MIDDLE NAME"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(376, 36)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 0
        Label4.Text = "LAST NAME"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(194, 54)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(166, 23)
        TextBox3.TabIndex = 1
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(376, 54)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(166, 23)
        TextBox4.TabIndex = 1
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(171, 150)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(222, 23)
        DateTimePicker1.TabIndex = 2
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(171, 218)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(209, 15)
        LinkLabel1.TabIndex = 3
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Already Have An Account? Log InHere"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(223, 192)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(LinkLabel1)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
End Class
