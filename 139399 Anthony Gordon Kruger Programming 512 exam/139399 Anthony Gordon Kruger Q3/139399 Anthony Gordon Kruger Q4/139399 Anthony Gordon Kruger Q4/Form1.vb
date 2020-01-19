
Imports System.IO
Public Class frmEmp

    Dim fileName, empNames(8) As String

    Private Sub frmEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        empNames(0) = "Patel"
        empNames(1) = "Kumar"
        empNames(2) = "Anwar"
        empNames(3) = "Hamid"
        empNames(4) = "Kokack"
        empNames(5) = "Naidoo"
        empNames(6) = "Navash"
        empNames(7) = "Kavish"
        empNames(8) = "Gopee"

        fileName = "employee.txt"

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            Dim ObjWriter As New StreamWriter(fileName)
            For i = 0 To empNames.Length - 1
                ObjWriter.WriteLine(empNames(i))
            Next
            ObjWriter.Close()
            MsgBox("File has been successfully written.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Try
            If File.Exists(fileName) Then
                Dim objReader As New StreamReader(fileName)
                While objReader.Peek <> -1
                    lstEmpList.Items.Add(objReader.ReadLine())
                End While
                objReader.Close()
                MsgBox("File has been successfully read and displayed.")
            Else
                MsgBox("File has not yet been created.")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

        lstEmpList.Items.Clear()

        'The following code is to create a new text file with no contents and overwrite to create the effect of the file being cleared 
        Try
            Dim ObjWriter As New StreamWriter(fileName)
            ObjWriter.WriteLine("")
            ObjWriter.Close()
            MsgBox("File has been successfully been cleared.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
