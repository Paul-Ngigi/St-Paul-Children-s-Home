Public Class Form3
    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._St_Paul_Children_s_HomeDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_St_Paul_Children_s_HomeDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me._St_Paul_Children_s_HomeDataSet.Staff)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        StaffBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StaffBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StaffBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        StaffBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit", "St Paul Children's Home Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub headshtBtn_Click(sender As Object, e As EventArgs) Handles headshtBtn.Click
        Dim headShot As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        With OpenFileDialog1
            .Filter = "jpg, jpeg Image|*.jpg, jpeg|PNG Image|*.png|BMP Image|*.bmp|" & "All Files (*.*)|*.*"
            .Title = "Choose the image ....."
            .FilterIndex = 1
            .Multiselect = False
            .ValidateNames = True
            .InitialDirectory = "MyPictures"
            .RestoreDirectory = True

            If (.ShowDialog = DialogResult.OK) Then
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Else
                Return
            End If
        End With
    End Sub
End Class