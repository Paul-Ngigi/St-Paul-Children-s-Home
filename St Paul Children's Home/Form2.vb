Public Class Form2

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        ChildrenBindingSource.AddNew()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        ChildrenBindingSource.RemoveCurrent()
    End Sub

    Private Sub nxtBtn_Click(sender As Object, e As EventArgs) Handles nxtBtn.Click
        ChildrenBindingSource.MoveNext()
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        ChildrenBindingSource.MovePrevious()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
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

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.ChildrenTableAdapter.FillBy(Me._St_Paul_Children_s_HomeDataSet.Children)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class