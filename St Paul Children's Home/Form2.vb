Public Class Form2
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        cExit1.ExitSystem()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit", "St Paul Children's Home Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs)
        Me.ChildrenBindingSource.AddNew()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Me.ChildrenBindingSource.RemoveCurrent()
    End Sub

    Private Sub nxtBtn_Click(sender As Object, e As EventArgs) Handles nxtBtn.Click
        Me.ChildrenBindingSource.MoveNext()
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        Me.ChildrenBindingSource.MovePrevious()
    End Sub

    Private Sub saveBtn_Click_1(sender As Object, e As EventArgs) Handles saveBtn.Click

    End Sub
End Class