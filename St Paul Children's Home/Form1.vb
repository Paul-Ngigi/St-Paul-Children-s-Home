Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles childBtn.Click
        Dim ChildForm As Form2 = New Form2
        ChildForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles staffBtn.Click
        Dim StaffForm As Form3 = New Form3
        StaffForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cExit1.ExitSystem()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'St_Paul_LoginDataSet.Authentication' table. You can move, or remove it, as needed.
        Me.AuthenticationTableAdapter.Fill(Me.St_Paul_LoginDataSet.Authentication)
        'TODO: This line of code loads data into the 'St_Paul_LoginDataSet.Authentication' table. You can move, or remove it, as needed.
        Me.AuthenticationTableAdapter.Fill(Me.St_Paul_LoginDataSet.Authentication)
        'TODO: This line of code loads data into the 'St_Paul_LoginDataSet.Authentication' table. You can move, or remove it, as needed.
        Me.AuthenticationTableAdapter.Fill(Me.St_Paul_LoginDataSet.Authentication)
        childBtn.Enabled = False
        staffBtn.Enabled = False
    End Sub

    Private Sub AuthenticationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AuthenticationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.St_Paul_LoginDataSet)

    End Sub

    Private Sub AuthenticationBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AuthenticationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.St_Paul_LoginDataSet)

    End Sub

    Private Sub AuthenticationBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs) Handles AuthenticationBindingNavigatorSaveItem.Click
        Me.Validate
        Me.AuthenticationBindingSource.EndEdit
        Me.TableAdapterManager.UpdateAll(Me.St_Paul_LoginDataSet)

    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim log = Me.AuthenticationTableAdapter.userdetails(Me.usernameTxt.Text, Me.passwordTxt.Text)

        If log Is Nothing Then
            usernameTxt.Clear()
            passwordTxt.Clear()
            MessageBox.Show("Invalid details entered", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            usernameTxt.Focus()
        Else

            childBtn.Enabled = True
            staffBtn.Enabled = True
        End If
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        usernameTxt.Clear()
        passwordTxt.Clear()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit", "St Paul Children's Home Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
