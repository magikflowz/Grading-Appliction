Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Add_Student_Click(sender As Object, e As EventArgs) Handles Add_Student.Click
        Student_Information_box.Text = ("Students Name: " + student_name_textbox.Text.ToUpper & Environment.NewLine & "================" & Environment.NewLine)

    End Sub

    Private Sub Student_Information_box_TextChanged(sender As Object, e As EventArgs) Handles Student_Information_box.TextChanged
        'Student Information Textbox Function'
    End Sub

    Private Sub Student_textbox_TextChanged(sender As Object, e As EventArgs) Handles student_name_textbox.TextChanged

    End Sub

    Private Sub Add_Class_Click(sender As Object, e As EventArgs) 'Add Class Button'
        Student_Information_box.AppendText(Environment.NewLine & "======================" & Environment.NewLine)
    End Sub

    Private Sub Class_box_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Homework_name_box_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Student_Information_box.AppendText(Environment.NewLine & "======================")
    End Sub

    Private Sub Add_Homework_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Remove_Homework_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List.SelectedIndexChanged
        'Select Class Combo Box '
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Select_btn.Click 'Select Button Funcions and code'
        Dim MyVariable As String
        MyVariable = Environment.NewLine & "Class: " + List.Text
        Student_Information_box.AppendText(MyVariable)
    End Sub

    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click 'Add Assignment Button with inputbox'
        Dim Add As String
        Dim Score As String
        Dim Letter_Grade As String
        Dim Range As Integer

        Try

            Add = InputBox("Add Assigment", "Assignment")

            Score = InputBox("What is the assignment score", "Score")

            Range = Score

            Select Case Range

                Case 90 To 100
                    Letter_Grade = "A"
                    Dim Item As New ListViewItem(Add)
                    Item.SubItems.Add(Score)
                    Item.SubItems.Add(Letter_Grade)
                    List_assigns.Items.Add(Item)

                Case 80 To 89
                    Letter_Grade = "B"
                    Dim Item As New ListViewItem(Add)
                    Item.SubItems.Add(Score)
                    Item.SubItems.Add(Letter_Grade)
                    List_assigns.Items.Add(Item)

                Case 70 To 79
                    Letter_Grade = "C"
                    Dim Item As New ListViewItem(Add)
                    Item.SubItems.Add(Score)
                    Item.SubItems.Add(Letter_Grade)
                    List_assigns.Items.Add(Item)

                Case 60 To 69
                    Letter_Grade = "D"
                    Dim Item As New ListViewItem(Add)
                    Item.SubItems.Add(Score)
                    Item.SubItems.Add(Letter_Grade)
                    List_assigns.Items.Add(Item)

                Case 0 To 59
                    Letter_Grade = "F"
                    Dim Item As New ListViewItem(Add)
                    Item.SubItems.Add(Score)
                    Item.SubItems.Add(Letter_Grade)
                    List_assigns.Items.Add(Item)
            End Select

        Catch ex As Exception
            MessageBox.Show("Invalid", "Error", MessageBoxButtons.OK)

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Remove_btn_Click(sender As Object, e As EventArgs) Handles Remove_btn.Click 'Remove Button'
        For Each i As ListViewItem In List_assigns.SelectedItems
            List_assigns.Items.Remove(i)
        Next
    End Sub

    Private Sub List_assigns_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Add_test_btn_Click(sender As Object, e As EventArgs) Handles Add_test_btn.Click 'Add Test with input box'
        Dim AddT As String
        Dim ScoreT As String
        Dim Letter_GradeT As String
        Dim RangeT As Integer

        Try

            AddT = InputBox("Add Test", "Test #")

            ScoreT = InputBox("What is the Test score", "Score")

            RangeT = ScoreT

            Select Case RangeT

                Case 90 To 100
                    Letter_GradeT = "A"
                    Dim Item As New ListViewItem(AddT)
                    Item.SubItems.Add(ScoreT)
                    Item.SubItems.Add(Letter_GradeT)
                    List_Test.Items.Add(Item)

                Case 80 To 89
                    Letter_GradeT = "B"
                    Dim Item As New ListViewItem(AddT)
                    Item.SubItems.Add(ScoreT)
                    Item.SubItems.Add(Letter_GradeT)
                    List_Test.Items.Add(Item)

                Case 70 To 79
                    Letter_GradeT = "C"
                    Dim Item As New ListViewItem(AddT)
                    Item.SubItems.Add(ScoreT)
                    Item.SubItems.Add(Letter_GradeT)
                    List_Test.Items.Add(Item)

                Case 60 To 69
                    Letter_GradeT = "D"
                    Dim Item As New ListViewItem(AddT)
                    Item.SubItems.Add(ScoreT)
                    Item.SubItems.Add(Letter_GradeT)
                    List_Test.Items.Add(Item)

                Case 0 To 59
                    Letter_GradeT = "F"
                    Dim Item As New ListViewItem(AddT)
                    Item.SubItems.Add(ScoreT)
                    Item.SubItems.Add(Letter_GradeT)
                    List_Test.Items.Add(Item)
            End Select

        Catch ex As Exception
            MessageBox.Show("Invalid", "Error", MessageBoxButtons.OK)

        End Try
    End Sub

    Private Sub Remove_Test_Btn_Click(sender As Object, e As EventArgs) Handles Remove_Test_Btn.Click 'Remove Test Button Function'
        For Each i As ListViewItem In List_Test.SelectedItems
            List_Test.Items.Remove(i)
        Next
    End Sub

    Private Sub Send_assign_Click(sender As Object, e As EventArgs) Handles Send_assign.Click 'Send assignment'
        Try
            Dim Assigns As String
            Assigns = List_assigns.SelectedItems.ToString
            Student_Information_box.AppendText(Environment.NewLine)
            Assigns = List_assigns.SelectedItems(0).SubItems(0).Text + ", " + List_assigns.SelectedItems(0).SubItems(1).Text + ", " + List_assigns.SelectedItems(0).SubItems(2).Text
            Student_Information_box.AppendText(Environment.NewLine)
            Student_Information_box.AppendText(Assigns)
            Student_Information_box.AppendText(Environment.NewLine)

        Catch ex As Exception
            MessageBox.Show("Select an option", "Error", MessageBoxButtons.OK)
        End Try


    End Sub

    Private Sub Send_assign_MouseClick(sender As Object, e As MouseEventArgs) Handles Send_assign.MouseClick

    End Sub


    Private Sub List_assigns_Click(sender As Object, e As EventArgs) Handles List_assigns.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Export_btn.Click 'Export Button'
        If Student_Information_box.Text.Length > 0 Then
            SaveFileDialog1.ShowDialog()
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, Student_Information_box.Text)
        End If

    End Sub

    Private Sub Send_Test_Click(sender As Object, e As EventArgs) Handles Send_Test.Click 'Send Test Button'
        Try
            Dim Test As String
            Test = List_Test.SelectedItems.ToString
            Student_Information_box.AppendText(Environment.NewLine)
            Test = List_Test.SelectedItems(0).SubItems(0).Text + ", " + List_Test.SelectedItems(0).SubItems(1).Text + ", " + List_Test.SelectedItems(0).SubItems(2).Text
            Student_Information_box.AppendText(Environment.NewLine)
            Student_Information_box.AppendText(Test)
            Student_Information_box.AppendText(Environment.NewLine)

        Catch ex As Exception
            MessageBox.Show("Select an option", "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub End_Class_Click(sender As Object, e As EventArgs) Handles End_Class.Click 'End Class Button'
        Student_Information_box.AppendText(Environment.NewLine & "Class Ended " & Environment.NewLine & "======================")
        Student_Information_box.AppendText(Environment.NewLine)
    End Sub

    Private Sub Clear_txtbox_Click(sender As Object, e As EventArgs) Handles Clear_txtbox.Click 'Clear Button'
        Student_Information_box.Clear()
    End Sub

    Private Sub student_info_Click(sender As Object, e As EventArgs) Handles student_info.Click

    End Sub

    Private Sub Open_Click(sender As Object, e As EventArgs) Handles Open.Click 'Open Button'

        Dim strtext As String
        OpenFileDialog1.InitialDirectory = "C:\Destop"
        OpenFileDialog1.Title = "Student Text File"
        OpenFileDialog1.ShowDialog()

        strtext = OpenFileDialog1.FileName
        Student_Information_box.AppendText(My.Computer.FileSystem.ReadAllText(strtext))

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        'This is the students name label'
    End Sub

    Private Sub Select_Class_Click(sender As Object, e As EventArgs) Handles Select_Class.Click
        'Select a class label'
    End Sub
End Class
