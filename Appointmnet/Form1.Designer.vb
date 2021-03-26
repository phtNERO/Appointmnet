<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PetName = New System.Windows.Forms.Label()
        Me.FullName = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PostTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtPetName = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtAppointment = New System.Windows.Forms.DateTimePicker()
        Me.txtDOB = New System.Windows.Forms.DateTimePicker()
        Me.Comments = New System.Windows.Forms.Label()
        Me.PhoneNumber = New System.Windows.Forms.Label()
        Me.txtPettype = New System.Windows.Forms.TextBox()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.Appointment = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.Label()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pettype = New System.Windows.Forms.Label()
        Me.Full_Name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveAsFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PetName
        '
        Me.PetName.AutoSize = True
        Me.PetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PetName.Location = New System.Drawing.Point(34, 156)
        Me.PetName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PetName.Name = "PetName"
        Me.PetName.Size = New System.Drawing.Size(76, 13)
        Me.PetName.TabIndex = 43
        Me.PetName.Text = "Name of pet"
        '
        'FullName
        '
        Me.FullName.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.FullName.GridLines = True
        Me.FullName.HideSelection = False
        Me.FullName.Location = New System.Drawing.Point(4, 3)
        Me.FullName.Margin = New System.Windows.Forms.Padding(2)
        Me.FullName.Name = "FullName"
        Me.FullName.Size = New System.Drawing.Size(654, 370)
        Me.FullName.TabIndex = 0
        Me.FullName.UseCompatibleStateImageBehavior = False
        Me.FullName.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Full Name"
        Me.ColumnHeader1.Width = 79
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name of pet"
        Me.ColumnHeader2.Width = 104
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Type of pet"
        Me.ColumnHeader3.Width = 92
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date of Birth"
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Appointment Date"
        Me.ColumnHeader5.Width = 125
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Phone Number"
        Me.ColumnHeader6.Width = 108
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Comments"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PostTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(602, 375)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Appointment"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PostTextBox
        '
        Me.PostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PostTextBox.Location = New System.Drawing.Point(92, 20)
        Me.PostTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PostTextBox.Multiline = True
        Me.PostTextBox.Name = "PostTextBox"
        Me.PostTextBox.Size = New System.Drawing.Size(424, 321)
        Me.PostTextBox.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(154, 496)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 19)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Post"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(721, 505)
        Me.ExitBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(56, 19)
        Me.ExitBtn.TabIndex = 42
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(622, 505)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 19)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Remove"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(529, 505)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 19)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'FontDialog1
        '
        Me.FontDialog1.ShowColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Users\krzys\Desktop\Help.pdf"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.FullName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(662, 375)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Records"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtPetName
        '
        Me.txtPetName.Location = New System.Drawing.Point(154, 149)
        Me.txtPetName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPetName.Name = "txtPetName"
        Me.txtPetName.Size = New System.Drawing.Size(176, 20)
        Me.txtPetName.TabIndex = 44
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(346, 81)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(670, 401)
        Me.TabControl1.TabIndex = 39
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(154, 337)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(176, 145)
        Me.txtRemarks.TabIndex = 38
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(154, 304)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(176, 20)
        Me.txtPhone.TabIndex = 37
        '
        'txtAppointment
        '
        Me.txtAppointment.Location = New System.Drawing.Point(154, 260)
        Me.txtAppointment.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAppointment.Name = "txtAppointment"
        Me.txtAppointment.Size = New System.Drawing.Size(176, 20)
        Me.txtAppointment.TabIndex = 36
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(154, 219)
        Me.txtDOB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(176, 20)
        Me.txtDOB.TabIndex = 35
        '
        'Comments
        '
        Me.Comments.AutoSize = True
        Me.Comments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comments.Location = New System.Drawing.Point(34, 340)
        Me.Comments.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Comments.Name = "Comments"
        Me.Comments.Size = New System.Drawing.Size(64, 13)
        Me.Comments.TabIndex = 34
        Me.Comments.Text = "Comments"
        '
        'PhoneNumber
        '
        Me.PhoneNumber.AutoSize = True
        Me.PhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumber.Location = New System.Drawing.Point(34, 311)
        Me.PhoneNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Size = New System.Drawing.Size(90, 13)
        Me.PhoneNumber.TabIndex = 33
        Me.PhoneNumber.Text = "Phone Number"
        '
        'txtPettype
        '
        Me.txtPettype.Location = New System.Drawing.Point(154, 182)
        Me.txtPettype.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPettype.Name = "txtPettype"
        Me.txtPettype.Size = New System.Drawing.Size(176, 20)
        Me.txtPettype.TabIndex = 31
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(154, 119)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(176, 20)
        Me.txtFullname.TabIndex = 30
        '
        'Appointment
        '
        Me.Appointment.AutoSize = True
        Me.Appointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appointment.Location = New System.Drawing.Point(34, 266)
        Me.Appointment.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Appointment.Name = "Appointment"
        Me.Appointment.Size = New System.Drawing.Size(108, 13)
        Me.Appointment.TabIndex = 29
        Me.Appointment.Text = "Appointment Date"
        '
        'DOB
        '
        Me.DOB.AutoSize = True
        Me.DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB.Location = New System.Drawing.Point(34, 226)
        Me.DOB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(78, 13)
        Me.DOB.TabIndex = 28
        Me.DOB.Text = "Date of birth"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ColourToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'ColourToolStripMenuItem
        '
        Me.ColourToolStripMenuItem.Name = "ColourToolStripMenuItem"
        Me.ColourToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ColourToolStripMenuItem.Text = "Colour"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Pettype
        '
        Me.Pettype.AutoSize = True
        Me.Pettype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pettype.Location = New System.Drawing.Point(34, 189)
        Me.Pettype.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Pettype.Name = "Pettype"
        Me.Pettype.Size = New System.Drawing.Size(72, 13)
        Me.Pettype.TabIndex = 26
        Me.Pettype.Text = "Type of pet"
        '
        'Full_Name
        '
        Me.Full_Name.AutoSize = True
        Me.Full_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Full_Name.Location = New System.Drawing.Point(34, 126)
        Me.Full_Name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Full_Name.Name = "Full_Name"
        Me.Full_Name.Size = New System.Drawing.Size(63, 13)
        Me.Full_Name.TabIndex = 25
        Me.Full_Name.Text = "Full Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 29)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Appointment Booking Form"
        '
        'SaveAsFileToolStripMenuItem
        '
        Me.SaveAsFileToolStripMenuItem.Name = "SaveAsFileToolStripMenuItem"
        Me.SaveAsFileToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.SaveAsFileToolStripMenuItem.Text = "Save as file"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.PrintToolStripMenuItem, Me.SaveAsFileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1027, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1027, 607)
        Me.Controls.Add(Me.PetName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtPetName)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtAppointment)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.Comments)
        Me.Controls.Add(Me.PhoneNumber)
        Me.Controls.Add(Me.txtPettype)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.Appointment)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.Pettype)
        Me.Controls.Add(Me.Full_Name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PetName As Label
    Friend WithEvents FullName As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PostTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtPetName As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents txtAppointment As DateTimePicker
    Friend WithEvents txtDOB As DateTimePicker
    Friend WithEvents Comments As Label
    Friend WithEvents PhoneNumber As Label
    Friend WithEvents txtPettype As TextBox
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents Appointment As Label
    Friend WithEvents DOB As Label
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pettype As Label
    Friend WithEvents Full_Name As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveAsFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
