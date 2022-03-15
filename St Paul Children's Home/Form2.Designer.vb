<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.nxtBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.headshtBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChildrenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._St_Paul_Children_s_HomeDataSet = New St_Paul_Children_s_Home._St_Paul_Children_s_HomeDataSet()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ChildrenTableAdapter = New St_Paul_Children_s_Home._St_Paul_Children_s_HomeDataSetTableAdapters.ChildrenTableAdapter()
        Me.TableAdapterManager = New St_Paul_Children_s_Home._St_Paul_Children_s_HomeDataSetTableAdapters.TableAdapterManager()
        Me.SchoolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JoinedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ChildrenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._St_Paul_Children_s_HomeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.headshtBtn)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1002, 371)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.saveBtn)
        Me.Panel4.Controls.Add(Me.closeBtn)
        Me.Panel4.Controls.Add(Me.previousBtn)
        Me.Panel4.Controls.Add(Me.nxtBtn)
        Me.Panel4.Controls.Add(Me.deleteBtn)
        Me.Panel4.Location = New System.Drawing.Point(57, 258)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(897, 81)
        Me.Panel4.TabIndex = 47
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.saveBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.saveBtn.Location = New System.Drawing.Point(20, 13)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(143, 48)
        Me.saveBtn.TabIndex = 52
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.closeBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.closeBtn.Location = New System.Drawing.Point(712, 13)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(143, 48)
        Me.closeBtn.TabIndex = 51
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = False
        '
        'previousBtn
        '
        Me.previousBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.previousBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previousBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.previousBtn.Location = New System.Drawing.Point(544, 13)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(143, 48)
        Me.previousBtn.TabIndex = 50
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = False
        '
        'nxtBtn
        '
        Me.nxtBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.nxtBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nxtBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nxtBtn.Location = New System.Drawing.Point(366, 13)
        Me.nxtBtn.Name = "nxtBtn"
        Me.nxtBtn.Size = New System.Drawing.Size(143, 48)
        Me.nxtBtn.TabIndex = 49
        Me.nxtBtn.Text = "Next"
        Me.nxtBtn.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.deleteBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.deleteBtn.Location = New System.Drawing.Point(197, 13)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(143, 48)
        Me.deleteBtn.TabIndex = 48
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'headshtBtn
        '
        Me.headshtBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.headshtBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headshtBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.headshtBtn.Location = New System.Drawing.Point(824, 188)
        Me.headshtBtn.Name = "headshtBtn"
        Me.headshtBtn.Size = New System.Drawing.Size(157, 48)
        Me.headshtBtn.TabIndex = 46
        Me.headshtBtn.Text = "Upload Photo"
        Me.headshtBtn.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.DateTimePicker2)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(425, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(376, 223)
        Me.Panel3.TabIndex = 1
        '
        'ChildrenBindingSource
        '
        Me.ChildrenBindingSource.DataMember = "Children"
        Me.ChildrenBindingSource.DataSource = Me._St_Paul_Children_s_HomeDataSet
        '
        '_St_Paul_Children_s_HomeDataSet
        '
        Me._St_Paul_Children_s_HomeDataSet.DataSetName = "_St_Paul_Children_s_HomeDataSet"
        Me._St_Paul_Children_s_HomeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ChildrenBindingSource, "Headshot", True))
        Me.PictureBox1.Location = New System.Drawing.Point(824, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 169)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(23, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(376, 223)
        Me.Panel2.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.DataGridView1)
        Me.Panel5.Location = New System.Drawing.Point(13, 400)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1002, 295)
        Me.Panel5.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1027, 25)
        Me.FillByToolStrip.TabIndex = 2
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'ChildrenTableAdapter
        '
        Me.ChildrenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChildrenTableAdapter = Me.ChildrenTableAdapter
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = St_Paul_Children_s_Home._St_Paul_Children_s_HomeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SchoolDataGridViewTextBoxColumn
        '
        Me.SchoolDataGridViewTextBoxColumn.DataPropertyName = "School"
        Me.SchoolDataGridViewTextBoxColumn.HeaderText = "School"
        Me.SchoolDataGridViewTextBoxColumn.Name = "SchoolDataGridViewTextBoxColumn"
        '
        'RoomDataGridViewTextBoxColumn
        '
        Me.RoomDataGridViewTextBoxColumn.DataPropertyName = "Room"
        Me.RoomDataGridViewTextBoxColumn.HeaderText = "Room"
        Me.RoomDataGridViewTextBoxColumn.Name = "RoomDataGridViewTextBoxColumn"
        '
        'JoinedDataGridViewTextBoxColumn
        '
        Me.JoinedDataGridViewTextBoxColumn.DataPropertyName = "Joined"
        Me.JoinedDataGridViewTextBoxColumn.HeaderText = "Joined"
        Me.JoinedDataGridViewTextBoxColumn.Name = "JoinedDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "Dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "Dob"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.JoinedDataGridViewTextBoxColumn, Me.RoomDataGridViewTextBoxColumn, Me.SchoolDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ChildrenBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(129, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(737, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "School"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildrenBindingSource, "School", True))
        Me.TextBox2.Location = New System.Drawing.Point(120, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(221, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Room"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildrenBindingSource, "Room", True))
        Me.TextBox3.Location = New System.Drawing.Point(120, 20)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(221, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Joined"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildrenBindingSource, "Joined", True))
        Me.DateTimePicker2.Location = New System.Drawing.Point(120, 120)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(221, 20)
        Me.DateTimePicker2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildrenBindingSource, "Name", True))
        Me.TextBox1.Location = New System.Drawing.Point(124, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(221, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DOB"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildrenBindingSource, "Dob", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(124, 116)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(221, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gender"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildrenBindingSource, "Gender", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Male", "Female", "Unspecified"})
        Me.ComboBox1.Location = New System.Drawing.Point(124, 163)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(221, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildrenBindingSource, "ID", True))
        Me.TextBox4.Location = New System.Drawing.Point(124, 20)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(221, 20)
        Me.TextBox4.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Id"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 695)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Children"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ChildrenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._St_Paul_Children_s_HomeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents headshtBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents closeBtn As Button
    Friend WithEvents previousBtn As Button
    Friend WithEvents nxtBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents _St_Paul_Children_s_HomeDataSet As _St_Paul_Children_s_HomeDataSet
    Friend WithEvents ChildrenBindingSource As BindingSource
    Friend WithEvents ChildrenTableAdapter As _St_Paul_Children_s_HomeDataSetTableAdapters.ChildrenTableAdapter
    Friend WithEvents TableAdapterManager As _St_Paul_Children_s_HomeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JoinedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SchoolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
