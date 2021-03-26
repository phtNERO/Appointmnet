Public Class Form1
    Private Const V As String = ""
    Private Const V1 As String = "Full Name"
    Private Const V2 As String = "Full Name"
    Private Const V3 As String = ""
    Private Const V4 As String = "Name of Pet"
    Private Const V5 As String = "Name of Pet"
    Private Const V6 As String = ""
    Private Const V7 As String = "Type of Pet"
    Private Const V8 As String = "Type of Pet"
    Private Const V9 As String = ""
    Private Const V10 As String = "Date of birth"
    Private Const V11 As String = "Date of birth"
    Private Const V12 As String = ""
    Private Const V13 As String = "Date of Appointment"
    Private Const V14 As String = "Date of Appointment"
    Private Const V15 As String = ""
    Private Const V16 As String = "Phone Number"
    Private Const V17 As String = "Phone Number"
    Private Const V18 As String = ""
    Private Const V19 As String = "Comments"
    Private Const V20 As String = "Comments"




    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Appointment.Click

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", "Shutting Down", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If FullName.Items.Count = 0 Then

            Dim item1 As ListViewItem
            item1 = FullName.Items.Add(txtFullname.Text)
            item1.SubItems.Add(txtPetName.Text)
            item1.SubItems.Add(txtPettype.Text)
            item1.SubItems.Add(txtDOB.Text)
            item1.SubItems.Add(txtAppointment.Text)
            item1.SubItems.Add(txtPhone.Text)
            item1.SubItems.Add(txtRemarks.Text)
            item1 = Nothing

        Else
            With FullName
                Dim addItem As ListViewItem
                addItem = .FindItemWithText(txtFullname.Text, True, 0, True)
                If Not addItem Is Nothing Then
                    Dim result As DialogResult = MessageBox.Show("The details " & txtFullname.Text & "Already exists ", "Duplicate record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                Else
                    Dim item1 As ListViewItem
                    item1 = FullName.Items.Add(txtFullname.Text)
                    item1.SubItems.Add(txtPetName.Text)
                    item1.SubItems.Add(txtPettype.Text)
                    item1.SubItems.Add(txtDOB.Text)
                    item1.SubItems.Add(txtAppointment.Text)
                    item1.SubItems.Add(txtPhone.Text)
                    item1.SubItems.Add(txtRemarks.Text)

                    item1 = Nothing


                End If


            End With
        End If
        txtFullname.Text = ""
        txtPetName.Text = ""
        txtPettype.Text = ""
        txtDOB.Text = ""
        txtAppointment.Text = ""
        txtPhone.Text = ""
        txtRemarks.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FullName.SelectedItems(0).Remove()






    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(PostTextBox.Text, PostTextBox.Font, Brushes.Blue, 100, 100)

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        If PostTextBox.Text = "" Then
            MsgBox("Please input text")
        Else
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub SaveAsFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsFileToolStripMenuItem.Click
        Dim iSave As New SaveFileDialog
        iSave.Filter = "txt files (*.txt) | *.txt"
        iSave.FilterIndex = 2
        iSave.RestoreDirectory = False

        If iSave.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(iSave.FileName, PostTextBox.Text)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PostTextBox.AppendText(" " + vbNewLine)
        PostTextBox.AppendText(vbTab & Full_Name.Text + " : " + txtFullname.Text + vbNewLine)
        PostTextBox.AppendText(" " + vbNewLine)
        PostTextBox.AppendText(vbTab & PetName.Text + " : " + txtPetName.Text + vbNewLine)
        PostTextBox.AppendText(" " + vbNewLine)
        PostTextBox.AppendText(vbTab & Pettype.Text + " : " + txtPettype.Text + vbNewLine)
        PostTextBox.AppendText(" " + vbNewLine)
        PostTextBox.AppendText(vbTab & DOB.Text + " : " + txtDOB.Text + vbNewLine)
        PostTextBox.AppendText(" " + vbNewLine)
        PostTextBox.AppendText(vbTab & Appointment.Text + " : " + txtAppointment.Text + vbNewLine)
        PostTextBox.AppendText(" " + vbNewLine)
        PostTextBox.AppendText(vbTab & PhoneNumber.Text + " : " + txtPhone.Text + vbNewLine)
        PostTextBox.AppendText(" " + vbNewLine)
        PostTextBox.AppendText(vbTab & Comments.Text + " : " + txtRemarks.Text + vbNewLine)
        PostTextBox.AppendText(" " + vbNewLine)
        PostTextBox.AppendText("=========================================" + vbNewLine)
        PostTextBox.AppendText(vbTab & Today & vbTab & TimeOfDay + vbNewLine)
        PostTextBox.AppendText("=========================================" + vbNewLine)
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            PostTextBox.Font = FontDialog1.Font

        End If
    End Sub

    Private Sub ColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColourToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            PostTextBox.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Full_Name.Click

    End Sub

    Private Sub Full_Name_MouseHover(sender As Object, e As EventArgs) Handles Full_Name.MouseHover
        Full_Name.Font = New Font("Microsoft Sans Serif", 10.2, FontStyle.Bold)
        Full_Name.Text = V1

    End Sub

    Private Sub Full_Name_MouseLeave(sender As Object, e As EventArgs) Handles Full_Name.MouseLeave
        Full_Name.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        Full_Name.Text = V2
    End Sub



    Private Sub PostTextBox_MouseHover(sender As Object, e As EventArgs) Handles PostTextBox.MouseHover
        Me.PostTextBox.BackColor = Color.Green


    End Sub



    Private Sub PrintPreviewDialog1_MouseLeave(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.MouseLeave
        Me.PostTextBox.BackColor = Color.White
    End Sub



    Private Sub PetName_MouseHover(sender As Object, e As EventArgs) Handles PetName.MouseHover
        PetName.Font = New Font("Microsoft Sans Serif", 10.2, FontStyle.Bold)
        PetName.Text = V4

    End Sub
    Private Sub PetName_MouseLeave(sender As Object, e As EventArgs) Handles PetName.MouseLeave
        PetName.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        PetName.Text = V5
    End Sub
    Private Sub Pettype_MouseHover(sender As Object, e As EventArgs) Handles Pettype.MouseHover
        Pettype.Font = New Font("Microsoft Sans Serif", 10.2, FontStyle.Bold)
        Pettype.Text = V7

    End Sub
    Private Sub Pettype_MouseLeave(sender As Object, e As EventArgs) Handles Pettype.MouseLeave
        Pettype.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        Pettype.Text = V8
    End Sub
    Private Sub DOB_MouseHover(sender As Object, e As EventArgs) Handles DOB.MouseHover
        DOB.Font = New Font("Microsoft Sans Serif", 10.2, FontStyle.Bold)
        DOB.Text = V10

    End Sub
    Private Sub DOB_MouseLeave(sender As Object, e As EventArgs) Handles DOB.MouseLeave
        DOB.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        DOB.Text = V11
    End Sub
    Private Sub Appointment_MouseHover(sender As Object, e As EventArgs) Handles Appointment.MouseHover
        Appointment.Font = New Font("Microsoft Sans Serif", 10.2, FontStyle.Bold)
        Appointment.Text = V13
    End Sub
    Private Sub Appointment_MouseLeave(sender As Object, e As EventArgs) Handles Appointment.MouseLeave
        Appointment.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        Appointment.Text = V14
    End Sub
    Private Sub PhoneNumber_MouseHover(sender As Object, e As EventArgs) Handles PhoneNumber.MouseHover
        PhoneNumber.Font = New Font("Microsoft Sans Serif", 10.2, FontStyle.Bold)
        PhoneNumber.Text = V16
    End Sub
    Private Sub PhoneNumber_MouseLeave(sender As Object, e As EventArgs) Handles PhoneNumber.MouseLeave
        PhoneNumber.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        PhoneNumber.Text = V17
    End Sub
    Private Sub Comments_MouseHover(sender As Object, e As EventArgs) Handles Comments.MouseHover
        Comments.Font = New Font("Microsoft Sans Serif", 10.2, FontStyle.Bold)
        Comments.Text = V19
    End Sub
    Private Sub Comments_MouseLeave(sender As Object, e As EventArgs) Handles Comments.MouseLeave
        Comments.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        Comments.Text = V20
    End Sub
End Class
