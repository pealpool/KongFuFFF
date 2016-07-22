Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'RichTextBox1.SelectionColor = Color.Red
        'RichTextBox1.AppendText("per1")
        'RichTextBox1.SelectionColor = Color.Green
        'RichTextBox1.AppendText("att for")
        'RichTextBox1.SelectionColor = Color.Blue
        'RichTextBox1.AppendText("30" + Environment.NewLine)

        Dim per1zc As New TaiJiChose
        Dim per2zc As New TaiQChose
        Dim per1zcX， per2zcX As String

        Dim wz As Integer = 0
        'wz 位置状态，0：面对面，1：per1优势，2：per2优势

        RichTextBox1.SelectionColor = Color.Red
        RichTextBox1.AppendText("per1 使出了 ")
        RichTextBox1.SelectionColor = Color.Green
        per1zcX = per1zc.zsChose(1, "【攀打】"， 0)
        RichTextBox1.AppendText(per1zcX)
        'RichTextBox1.SelectionColor = Color.Black
        per1zc.AttBuWei(1, wz, per1zcX)
        'RichTextBox1.AppendText(per1zc.AttBuWei(1, wz, per1zcX) + Environment.NewLine)




        RichTextBox1.SelectionColor = Color.Blue
        RichTextBox1.AppendText("per2 使出了 ")
        RichTextBox1.SelectionColor = Color.Green
        per2zcX = per2zc.zsChose(1, "【攀打】")
        RichTextBox1.AppendText(per2zcX)
        per2zc.AttBuWei(1, wz, per2zcX, 1)

        RichTextBox1.ScrollToCaret() '滚动到光标处
    End Sub



End Class
