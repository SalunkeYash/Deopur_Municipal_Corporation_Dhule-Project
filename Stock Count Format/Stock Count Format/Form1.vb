Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        TextBox8.Text = TextBox7.Text + TextBox6.Text + TextBox5.Text
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        TextBox13.Text = TextBox12.Text + TextBox11.Text + TextBox10.Text
    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged
        TextBox18.Text = TextBox17.Text + TextBox16.Text + TextBox15.Text
    End Sub

    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles TextBox23.TextChanged
        TextBox23.Text = TextBox22.Text + TextBox21.Text + TextBox20.Text
    End Sub

    Private Sub TextBox28_TextChanged(sender As Object, e As EventArgs) Handles TextBox28.TextChanged
        TextBox28.Text = TextBox27.Text + TextBox26.Text + TextBox25.Text
    End Sub

    Private Sub TextBox33_TextChanged(sender As Object, e As EventArgs) Handles TextBox33.TextChanged
        TextBox33.Text = TextBox32.Text + TextBox31.Text + TextBox30.Text
    End Sub

    Private Sub TextBox38_TextChanged(sender As Object, e As EventArgs) Handles TextBox38.TextChanged
        TextBox38.Text = TextBox37.Text + TextBox36.Text + TextBox35.Text
    End Sub

    Private Sub TextBox43_TextChanged(sender As Object, e As EventArgs) Handles TextBox43.TextChanged
        TextBox48.Text = TextBox47.Text + TextBox46.Text + TextBox45.Text
    End Sub

    Private Sub TextBox48_TextChanged(sender As Object, e As EventArgs) Handles TextBox48.TextChanged
        TextBox48.Text = TextBox47.Text + TextBox46.Text + TextBox45.Text
    End Sub

    Private Sub TextBox53_TextChanged(sender As Object, e As EventArgs) Handles TextBox53.TextChanged
        TextBox53.Text = TextBox52.Text + TextBox51.Text + TextBox50.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TextBox8.Text = Val(TextBox7.Text) + Val(TextBox6.Text) + Val(TextBox5.Text)
        TextBox13.Text = Val(TextBox12.Text) + Val(TextBox11.Text) + Val(TextBox10.Text)
        TextBox18.Text = Val(TextBox17.Text) + Val(TextBox16.Text) + Val(TextBox15.Text)
        TextBox23.Text = Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text)
        TextBox28.Text = Val(TextBox27.Text) + Val(TextBox26.Text) + Val(TextBox25.Text)
        TextBox33.Text = Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text)
        TextBox38.Text = Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text)
        TextBox48.Text = Val(TextBox47.Text) + Val(TextBox46.Text) + Val(TextBox45.Text)
        TextBox48.Text = Val(TextBox47.Text) + Val(TextBox46.Text) + Val(TextBox45.Text)
        TextBox53.Text = Val(TextBox52.Text) + Val(TextBox51.Text) + Val(TextBox50.Text)
    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
