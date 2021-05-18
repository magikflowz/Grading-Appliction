<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.student_name_textbox = New System.Windows.Forms.TextBox()
        Me.Student_Information_box = New System.Windows.Forms.TextBox()
        Me.student_info = New System.Windows.Forms.Label()
        Me.Select_Class = New System.Windows.Forms.Label()
        Me.Add_Student = New System.Windows.Forms.Button()
        Me.Export_btn = New System.Windows.Forms.Button()
        Me.List = New System.Windows.Forms.ComboBox()
        Me.Select_btn = New System.Windows.Forms.Button()
        Me.Assignments = New System.Windows.Forms.Label()
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.Remove_btn = New System.Windows.Forms.Button()
        Me.Test = New System.Windows.Forms.Label()
        Me.Add_test_btn = New System.Windows.Forms.Button()
        Me.Remove_Test_Btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.List_assigns = New System.Windows.Forms.ListView()
        Me.Assignment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Score = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Grade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.List_Test = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Send_assign = New System.Windows.Forms.Button()
        Me.Send_Test = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.End_Class = New System.Windows.Forms.Button()
        Me.Clear_txtbox = New System.Windows.Forms.Button()
        Me.Open = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Students Name"
        '
        'student_name_textbox
        '
        Me.student_name_textbox.Location = New System.Drawing.Point(13, 59)
        Me.student_name_textbox.Name = "student_name_textbox"
        Me.student_name_textbox.Size = New System.Drawing.Size(100, 20)
        Me.student_name_textbox.TabIndex = 1
        '
        'Student_Information_box
        '
        Me.Student_Information_box.Location = New System.Drawing.Point(542, 42)
        Me.Student_Information_box.Multiline = True
        Me.Student_Information_box.Name = "Student_Information_box"
        Me.Student_Information_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Student_Information_box.Size = New System.Drawing.Size(246, 396)
        Me.Student_Information_box.TabIndex = 2
        '
        'student_info
        '
        Me.student_info.AutoSize = True
        Me.student_info.Location = New System.Drawing.Point(434, 21)
        Me.student_info.Name = "student_info"
        Me.student_info.Size = New System.Drawing.Size(104, 13)
        Me.student_info.TabIndex = 3
        Me.student_info.Text = "Students Information"
        '
        'Select_Class
        '
        Me.Select_Class.AutoSize = True
        Me.Select_Class.Location = New System.Drawing.Point(122, 42)
        Me.Select_Class.Name = "Select_Class"
        Me.Select_Class.Size = New System.Drawing.Size(65, 13)
        Me.Select_Class.TabIndex = 4
        Me.Select_Class.Text = "Select Class"
        '
        'Add_Student
        '
        Me.Add_Student.Location = New System.Drawing.Point(12, 80)
        Me.Add_Student.Name = "Add_Student"
        Me.Add_Student.Size = New System.Drawing.Size(101, 23)
        Me.Add_Student.TabIndex = 15
        Me.Add_Student.Text = "Add Student"
        Me.Add_Student.UseVisualStyleBackColor = True
        '
        'Export_btn
        '
        Me.Export_btn.AccessibleName = "Export_btn"
        Me.Export_btn.Location = New System.Drawing.Point(632, 16)
        Me.Export_btn.Name = "Export_btn"
        Me.Export_btn.Size = New System.Drawing.Size(75, 23)
        Me.Export_btn.TabIndex = 20
        Me.Export_btn.Text = "Export"
        Me.Export_btn.UseVisualStyleBackColor = True
        '
        'List
        '
        Me.List.FormattingEnabled = True
        Me.List.Items.AddRange(New Object() {"Science", "Technology", "Engineering", "Mathematics "})
        Me.List.Location = New System.Drawing.Point(125, 58)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(121, 21)
        Me.List.TabIndex = 23
        '
        'Select_btn
        '
        Me.Select_btn.Location = New System.Drawing.Point(252, 59)
        Me.Select_btn.Name = "Select_btn"
        Me.Select_btn.Size = New System.Drawing.Size(75, 23)
        Me.Select_btn.TabIndex = 24
        Me.Select_btn.Text = "Select"
        Me.Select_btn.UseVisualStyleBackColor = True
        '
        'Assignments
        '
        Me.Assignments.AutoSize = True
        Me.Assignments.Location = New System.Drawing.Point(12, 134)
        Me.Assignments.Name = "Assignments"
        Me.Assignments.Size = New System.Drawing.Size(66, 13)
        Me.Assignments.TabIndex = 26
        Me.Assignments.Text = "Assignments"
        '
        'Add_btn
        '
        Me.Add_btn.Location = New System.Drawing.Point(447, 150)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(89, 23)
        Me.Add_btn.TabIndex = 27
        Me.Add_btn.Text = "Add"
        Me.Add_btn.UseVisualStyleBackColor = True
        '
        'Remove_btn
        '
        Me.Remove_btn.Location = New System.Drawing.Point(447, 179)
        Me.Remove_btn.Name = "Remove_btn"
        Me.Remove_btn.Size = New System.Drawing.Size(89, 23)
        Me.Remove_btn.TabIndex = 28
        Me.Remove_btn.Text = "Remove"
        Me.Remove_btn.UseVisualStyleBackColor = True
        '
        'Test
        '
        Me.Test.AutoSize = True
        Me.Test.Location = New System.Drawing.Point(12, 288)
        Me.Test.Name = "Test"
        Me.Test.Size = New System.Drawing.Size(28, 13)
        Me.Test.TabIndex = 30
        Me.Test.Text = "Test"
        '
        'Add_test_btn
        '
        Me.Add_test_btn.Location = New System.Drawing.Point(446, 316)
        Me.Add_test_btn.Name = "Add_test_btn"
        Me.Add_test_btn.Size = New System.Drawing.Size(87, 23)
        Me.Add_test_btn.TabIndex = 31
        Me.Add_test_btn.Text = "Add"
        Me.Add_test_btn.UseVisualStyleBackColor = True
        '
        'Remove_Test_Btn
        '
        Me.Remove_Test_Btn.Location = New System.Drawing.Point(447, 345)
        Me.Remove_Test_Btn.Name = "Remove_Test_Btn"
        Me.Remove_Test_Btn.Size = New System.Drawing.Size(87, 23)
        Me.Remove_Test_Btn.TabIndex = 32
        Me.Remove_Test_Btn.Text = "Remove"
        Me.Remove_Test_Btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(444, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Test Controls"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(434, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Assignment Controls"
        '
        'List_assigns
        '
        Me.List_assigns.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.List_assigns.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Assignment, Me.Score, Me.Grade})
        Me.List_assigns.FullRowSelect = True
        Me.List_assigns.GridLines = True
        Me.List_assigns.HideSelection = False
        Me.List_assigns.HotTracking = True
        Me.List_assigns.HoverSelection = True
        Me.List_assigns.Location = New System.Drawing.Point(8, 150)
        Me.List_assigns.Name = "List_assigns"
        Me.List_assigns.Size = New System.Drawing.Size(433, 135)
        Me.List_assigns.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.List_assigns.TabIndex = 38
        Me.List_assigns.UseCompatibleStateImageBehavior = False
        Me.List_assigns.View = System.Windows.Forms.View.Details
        '
        'Assignment
        '
        Me.Assignment.Text = "Assignment"
        Me.Assignment.Width = 132
        '
        'Score
        '
        Me.Score.Text = "Score"
        Me.Score.Width = 119
        '
        'Grade
        '
        Me.Grade.Text = "Grade"
        Me.Grade.Width = 188
        '
        'List_Test
        '
        Me.List_Test.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.List_Test.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.List_Test.FullRowSelect = True
        Me.List_Test.GridLines = True
        Me.List_Test.HideSelection = False
        Me.List_Test.HotTracking = True
        Me.List_Test.HoverSelection = True
        Me.List_Test.Location = New System.Drawing.Point(8, 304)
        Me.List_Test.Name = "List_Test"
        Me.List_Test.Size = New System.Drawing.Size(433, 135)
        Me.List_Test.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.List_Test.TabIndex = 40
        Me.List_Test.UseCompatibleStateImageBehavior = False
        Me.List_Test.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Test"
        Me.ColumnHeader1.Width = 132
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Score"
        Me.ColumnHeader2.Width = 119
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Grade"
        Me.ColumnHeader3.Width = 188
        '
        'Send_assign
        '
        Me.Send_assign.Location = New System.Drawing.Point(448, 209)
        Me.Send_assign.Name = "Send_assign"
        Me.Send_assign.Size = New System.Drawing.Size(88, 23)
        Me.Send_assign.TabIndex = 41
        Me.Send_assign.Text = "Send"
        Me.Send_assign.UseVisualStyleBackColor = True
        '
        'Send_Test
        '
        Me.Send_Test.Location = New System.Drawing.Point(446, 375)
        Me.Send_Test.Name = "Send_Test"
        Me.Send_Test.Size = New System.Drawing.Size(87, 23)
        Me.Send_Test.TabIndex = 42
        Me.Send_Test.Text = "Send"
        Me.Send_Test.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        '
        'End_Class
        '
        Me.End_Class.AccessibleName = ""
        Me.End_Class.Location = New System.Drawing.Point(334, 59)
        Me.End_Class.Name = "End_Class"
        Me.End_Class.Size = New System.Drawing.Size(75, 23)
        Me.End_Class.TabIndex = 43
        Me.End_Class.Text = "End Class"
        Me.End_Class.UseVisualStyleBackColor = True
        '
        'Clear_txtbox
        '
        Me.Clear_txtbox.Location = New System.Drawing.Point(713, 16)
        Me.Clear_txtbox.Name = "Clear_txtbox"
        Me.Clear_txtbox.Size = New System.Drawing.Size(75, 23)
        Me.Clear_txtbox.TabIndex = 44
        Me.Clear_txtbox.Text = "Clear"
        Me.Clear_txtbox.UseVisualStyleBackColor = True
        '
        'Open
        '
        Me.Open.Location = New System.Drawing.Point(542, 16)
        Me.Open.Name = "Open"
        Me.Open.Size = New System.Drawing.Size(75, 23)
        Me.Open.TabIndex = 45
        Me.Open.Text = "Open"
        Me.Open.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Open)
        Me.Controls.Add(Me.Clear_txtbox)
        Me.Controls.Add(Me.End_Class)
        Me.Controls.Add(Me.Send_Test)
        Me.Controls.Add(Me.Send_assign)
        Me.Controls.Add(Me.List_Test)
        Me.Controls.Add(Me.List_assigns)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Remove_Test_Btn)
        Me.Controls.Add(Me.Add_test_btn)
        Me.Controls.Add(Me.Test)
        Me.Controls.Add(Me.Remove_btn)
        Me.Controls.Add(Me.Add_btn)
        Me.Controls.Add(Me.Assignments)
        Me.Controls.Add(Me.Select_btn)
        Me.Controls.Add(Me.List)
        Me.Controls.Add(Me.Export_btn)
        Me.Controls.Add(Me.Add_Student)
        Me.Controls.Add(Me.Select_Class)
        Me.Controls.Add(Me.student_info)
        Me.Controls.Add(Me.Student_Information_box)
        Me.Controls.Add(Me.student_name_textbox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents student_name_textbox As TextBox
    Friend WithEvents Student_Information_box As TextBox
    Friend WithEvents student_info As Label
    Friend WithEvents Select_Class As Label
    Friend WithEvents Add_Student As Button
    Friend WithEvents Export_btn As Button
    Friend WithEvents Select_btn As Button
    Private WithEvents List As ComboBox
    Friend WithEvents Assignments As Label
    Friend WithEvents Add_btn As Button
    Friend WithEvents Remove_btn As Button
    Friend WithEvents Test As Label
    Friend WithEvents Add_test_btn As Button
    Friend WithEvents Remove_Test_Btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents List_assigns As ListView
    Private WithEvents Assignment As ColumnHeader
    Friend WithEvents Score As ColumnHeader
    Friend WithEvents Grade As ColumnHeader
    Friend WithEvents List_Test As ListView
    Private WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Send_assign As Button
    Friend WithEvents Send_Test As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents End_Class As Button
    Friend WithEvents Clear_txtbox As Button
    Friend WithEvents Open As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
