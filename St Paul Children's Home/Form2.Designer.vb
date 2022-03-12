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
        Dim SchoolLabel As System.Windows.Forms.Label
        Dim RoomLabel As System.Windows.Forms.Label
        Dim JoinedLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DobLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me._St_Paul_Children_s_HomeDataSet = New St_Paul_Children_s_Home._St_Paul_Children_s_HomeDataSet()
        Me.ChildrenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChildrenTableAdapter = New St_Paul_Children_s_Home._St_Paul_Children_s_HomeDataSetTableAdapters.ChildrenTableAdapter()
        Me.TableAdapterManager = New St_Paul_Children_s_Home._St_Paul_Children_s_HomeDataSetTableAdapters.TableAdapterManager()
        Me.ChildrenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChildrenBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ChildrenDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.headshtBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.JoinedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RoomTextBox = New System.Windows.Forms.TextBox()
        Me.SchoolTextBox = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DobDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.nxtBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        SchoolLabel = New System.Windows.Forms.Label()
        RoomLabel = New System.Windows.Forms.Label()
        JoinedLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DobLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        CType(Me._St_Paul_Children_s_HomeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChildrenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChildrenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChildrenBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.ChildrenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SchoolLabel
        '
        SchoolLabel.AutoSize = True
        SchoolLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SchoolLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        SchoolLabel.Location = New System.Drawing.Point(14, 92)
        SchoolLabel.Name = "SchoolLabel"
        SchoolLabel.Size = New System.Drawing.Size(74, 24)
        SchoolLabel.TabIndex = 38
        SchoolLabel.Text = "School:"
        '
        'RoomLabel
        '
        RoomLabel.AutoSize = True
        RoomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RoomLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        RoomLabel.Location = New System.Drawing.Point(14, 56)
        RoomLabel.Name = "RoomLabel"
        RoomLabel.Size = New System.Drawing.Size(66, 24)
        RoomLabel.TabIndex = 36
        RoomLabel.Text = "Room:"
        '
        'JoinedLabel
        '
        JoinedLabel.AutoSize = True
        JoinedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JoinedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        JoinedLabel.Location = New System.Drawing.Point(14, 24)
        JoinedLabel.Name = "JoinedLabel"
        JoinedLabel.Size = New System.Drawing.Size(72, 24)
        JoinedLabel.TabIndex = 34
        JoinedLabel.Text = "Joined:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        GenderLabel.Location = New System.Drawing.Point(14, 123)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(79, 24)
        GenderLabel.TabIndex = 22
        GenderLabel.Text = "Gender:"
        '
        'DobLabel
        '
        DobLabel.AutoSize = True
        DobLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DobLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DobLabel.Location = New System.Drawing.Point(14, 77)
        DobLabel.Name = "DobLabel"
        DobLabel.Size = New System.Drawing.Size(50, 24)
        DobLabel.TabIndex = 20
        DobLabel.Text = "Dob:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        NameLabel.Location = New System.Drawing.Point(14, 28)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(66, 24)
        NameLabel.TabIndex = 18
        NameLabel.Text = "Name:"
        '
        '_St_Paul_Children_s_HomeDataSet
        '
        Me._St_Paul_Children_s_HomeDataSet.DataSetName = "_St_Paul_Children_s_HomeDataSet"
        Me._St_Paul_Children_s_HomeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChildrenBindingSource
        '
        Me.ChildrenBindingSource.DataMember = "Children"
        Me.ChildrenBindingSource.DataSource = Me._St_Paul_Children_s_HomeDataSet
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
        'ChildrenBindingNavigator
        '
        Me.ChildrenBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ChildrenBindingNavigator.BindingSource = Me.ChildrenBindingSource
        Me.ChildrenBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ChildrenBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ChildrenBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ChildrenBindingNavigatorSaveItem})
        Me.ChildrenBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ChildrenBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ChildrenBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ChildrenBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ChildrenBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ChildrenBindingNavigator.Name = "ChildrenBindingNavigator"
        Me.ChildrenBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ChildrenBindingNavigator.Size = New System.Drawing.Size(1025, 25)
        Me.ChildrenBindingNavigator.TabIndex = 1
        Me.ChildrenBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ChildrenBindingNavigatorSaveItem
        '
        Me.ChildrenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ChildrenBindingNavigatorSaveItem.Image = CType(resources.GetObject("ChildrenBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ChildrenBindingNavigatorSaveItem.Name = "ChildrenBindingNavigatorSaveItem"
        Me.ChildrenBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ChildrenBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1003, 617)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.ChildrenDataGridView)
        Me.Panel6.Location = New System.Drawing.Point(58, 354)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(921, 238)
        Me.Panel6.TabIndex = 25
        '
        'ChildrenDataGridView
        '
        Me.ChildrenDataGridView.AutoGenerateColumns = False
        Me.ChildrenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ChildrenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ChildrenDataGridView.DataSource = Me.ChildrenBindingSource
        Me.ChildrenDataGridView.Location = New System.Drawing.Point(102, 11)
        Me.ChildrenDataGridView.Name = "ChildrenDataGridView"
        Me.ChildrenDataGridView.Size = New System.Drawing.Size(640, 220)
        Me.ChildrenDataGridView.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.headshtBtn)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(13, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(966, 305)
        Me.Panel2.TabIndex = 24
        '
        'headshtBtn
        '
        Me.headshtBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.headshtBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headshtBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.headshtBtn.Location = New System.Drawing.Point(801, 147)
        Me.headshtBtn.Name = "headshtBtn"
        Me.headshtBtn.Size = New System.Drawing.Size(132, 48)
        Me.headshtBtn.TabIndex = 43
        Me.headshtBtn.Text = "Upload Photo"
        Me.headshtBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ChildrenBindingSource, "Headshot", True))
        Me.PictureBox1.Location = New System.Drawing.Point(801, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 119)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(JoinedLabel)
        Me.Panel5.Controls.Add(Me.JoinedDateTimePicker)
        Me.Panel5.Controls.Add(RoomLabel)
        Me.Panel5.Controls.Add(Me.RoomTextBox)
        Me.Panel5.Controls.Add(SchoolLabel)
        Me.Panel5.Controls.Add(Me.SchoolTextBox)
        Me.Panel5.Location = New System.Drawing.Point(388, 22)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(372, 173)
        Me.Panel5.TabIndex = 34
        '
        'JoinedDateTimePicker
        '
        Me.JoinedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ChildrenBindingSource, "Joined", True))
        Me.JoinedDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JoinedDateTimePicker.Location = New System.Drawing.Point(147, 27)
        Me.JoinedDateTimePicker.Name = "JoinedDateTimePicker"
        Me.JoinedDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.JoinedDateTimePicker.TabIndex = 35
        '
        'RoomTextBox
        '
        Me.RoomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildrenBindingSource, "Room", True))
        Me.RoomTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTextBox.Location = New System.Drawing.Point(147, 59)
        Me.RoomTextBox.Name = "RoomTextBox"
        Me.RoomTextBox.Size = New System.Drawing.Size(200, 22)
        Me.RoomTextBox.TabIndex = 37
        '
        'SchoolTextBox
        '
        Me.SchoolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildrenBindingSource, "School", True))
        Me.SchoolTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolTextBox.Location = New System.Drawing.Point(147, 95)
        Me.SchoolTextBox.Name = "SchoolTextBox"
        Me.SchoolTextBox.Size = New System.Drawing.Size(200, 22)
        Me.SchoolTextBox.TabIndex = 39
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(NameLabel)
        Me.Panel4.Controls.Add(Me.NameTextBox)
        Me.Panel4.Controls.Add(DobLabel)
        Me.Panel4.Controls.Add(Me.DobDateTimePicker)
        Me.Panel4.Controls.Add(GenderLabel)
        Me.Panel4.Controls.Add(Me.GenderTextBox)
        Me.Panel4.Location = New System.Drawing.Point(38, 21)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(333, 174)
        Me.Panel4.TabIndex = 33
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildrenBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(118, 31)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NameTextBox.TabIndex = 19
        '
        'DobDateTimePicker
        '
        Me.DobDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ChildrenBindingSource, "Dob", True))
        Me.DobDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DobDateTimePicker.Location = New System.Drawing.Point(118, 79)
        Me.DobDateTimePicker.Name = "DobDateTimePicker"
        Me.DobDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.DobDateTimePicker.TabIndex = 21
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildrenBindingSource, "Gender", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(118, 126)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 22)
        Me.GenderTextBox.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.closeBtn)
        Me.Panel3.Controls.Add(Me.exitBtn)
        Me.Panel3.Controls.Add(Me.previousBtn)
        Me.Panel3.Controls.Add(Me.deleteBtn)
        Me.Panel3.Controls.Add(Me.nxtBtn)
        Me.Panel3.Controls.Add(Me.saveBtn)
        Me.Panel3.Location = New System.Drawing.Point(38, 216)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(901, 82)
        Me.Panel3.TabIndex = 32
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.closeBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.closeBtn.Location = New System.Drawing.Point(627, 25)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(120, 40)
        Me.closeBtn.TabIndex = 43
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = False
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.exitBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.exitBtn.Location = New System.Drawing.Point(767, 25)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(120, 40)
        Me.exitBtn.TabIndex = 42
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'previousBtn
        '
        Me.previousBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.previousBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previousBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.previousBtn.Location = New System.Drawing.Point(487, 25)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(120, 40)
        Me.previousBtn.TabIndex = 41
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.deleteBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.deleteBtn.Location = New System.Drawing.Point(167, 25)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(120, 40)
        Me.deleteBtn.TabIndex = 40
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'nxtBtn
        '
        Me.nxtBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.nxtBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nxtBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nxtBtn.Location = New System.Drawing.Point(330, 25)
        Me.nxtBtn.Name = "nxtBtn"
        Me.nxtBtn.Size = New System.Drawing.Size(120, 40)
        Me.nxtBtn.TabIndex = 39
        Me.nxtBtn.Text = "Next"
        Me.nxtBtn.UseVisualStyleBackColor = False
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.saveBtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.saveBtn.Location = New System.Drawing.Point(18, 25)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(120, 40)
        Me.saveBtn.TabIndex = 38
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Dob"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Dob"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Joined"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Joined"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Room"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Room"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "School"
        Me.DataGridViewTextBoxColumn8.HeaderText = "School"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 641)
        Me.Controls.Add(Me.ChildrenBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Children"
        CType(Me._St_Paul_Children_s_HomeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChildrenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChildrenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChildrenBindingNavigator.ResumeLayout(False)
        Me.ChildrenBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.ChildrenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _St_Paul_Children_s_HomeDataSet As _St_Paul_Children_s_HomeDataSet
    Friend WithEvents ChildrenBindingSource As BindingSource
    Friend WithEvents ChildrenTableAdapter As _St_Paul_Children_s_HomeDataSetTableAdapters.ChildrenTableAdapter
    Friend WithEvents TableAdapterManager As _St_Paul_Children_s_HomeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ChildrenBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ChildrenBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents closeBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents previousBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents nxtBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents headshtBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ChildrenDataGridView As DataGridView
    Friend WithEvents JoinedDateTimePicker As DateTimePicker
    Friend WithEvents RoomTextBox As TextBox
    Friend WithEvents SchoolTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DobDateTimePicker As DateTimePicker
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
