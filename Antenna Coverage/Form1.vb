Public Class Form1
    Public pi As String

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim pi As String
        'pi = 3.1415926535
        'TextBox5.Text = (TextBox1.Text - TextBox2.Text) / Math.Tan(TextBox3.Text * (pi / 180))
        'T'extBox6.Text = +((((TextBox1.Text - TextBox2.Text) * 3.2808398950131) / (Math.Tan((TextBox3.Text * (pi / 180)) + (TextBox4.Text * (pi / 180) / 2)))) / 5280) * 1609.344
        'TextBox7.Text = +((((TextBox1.Text - TextBox2.Text) * 3.2808398950131) / (Math.Tan((TextBox3.Text * (pi / 180)) - (TextBox4.Text * (pi / 180) / 2)))) / 5280) * 1609.344

        'TextBox12.Text = (Math.Tan((TextBox8.Text - TextBox9.Text) / TextBox10.Text)) * (180 / pi)
        'TextBox13.Text = +((((TextBox8.Text - TextBox9.Text) * 3.2808398950131) / (Math.Tan((TextBox12.Text * (pi / 180)) + (TextBox11.Text * (pi / 180) / 2)))) / 5280) * 1609.344

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim pi As String
        pi = 3.1415926535
        On Error Resume Next

        If TextBox1.Text < TextBox2.Text Then
            MessageBox.Show("On condition that (Ht > Hr)")
            TextBox2.Text = TextBox1.Text - 1
        End If

        TextBox5.Text = Format((TextBox1.Text - TextBox2.Text) / Math.Tan(TextBox3.Text * (pi / 180)), "#0.##0")
        TextBox6.Text = Format(+((((TextBox1.Text - TextBox2.Text) * 3.2808398950131) / (Math.Tan((TextBox3.Text * (pi / 180)) + (TextBox4.Text * (pi / 180) / 2)))) / 5280) * 1609.344, "#0.##0")
        TextBox7.Text = Format(+((((TextBox1.Text - TextBox2.Text) * 3.2808398950131) / (Math.Tan((TextBox3.Text * (pi / 180)) - (TextBox4.Text * (pi / 180) / 2)))) / 5280) * 1609.344, "#0.##0")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim pi As String
        pi = 3.1415926535
        On Error Resume Next

        If TextBox8.Text < TextBox9.Text Then
            MessageBox.Show("On condition that (Ht > Hr)")
            TextBox9.Text = TextBox8.Text - 1
        End If

        TextBox12.Text = Format((Math.Atan((TextBox8.Text - TextBox9.Text) / TextBox10.Text)) * (180 / pi), "#0.##0")
        TextBox13.Text = Format(+((((TextBox8.Text - TextBox9.Text) * 3.2808398950131) / (Math.Tan((TextBox12.Text * (pi / 180)) + (TextBox11.Text * (pi / 180) / 2)))) / 5280) * 1609.344, "#0.##0")
        TextBox14.Text = Format(+((((TextBox8.Text - TextBox9.Text) * 3.2808398950131) / (Math.Tan((TextBox12.Text * (pi / 180)) - (TextBox11.Text * (pi / 180) / 2)))) / 5280) * 1609.344, "#0.##0")
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click
        System.Diagnostics.Process.Start("chrome.exe", "http://antenna-design.tistory.com/22")
    End Sub

End Class
