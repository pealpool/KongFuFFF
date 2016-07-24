Public Class Form1
    Public per1, per2 As New Person
    Public per1zc As New TaiJiChose
    Public per2zc As New TaiQChose
    Public per1zcX， per2zcX As String '使出的招式
    Public BuWei1， BuWei2 As String '攻击的部位
    Public LianJi As String = 0 '连击
    Public siHeng As Integer = 0 '失衡=1
    Public wz As Integer = 0 'wz 位置状态，0：面对面，1：per1优势，2：per2优势



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With per1
            .Pow = TextBox1_Pow.Text
            .Dev = TextBox1_Dev.Text
            .Int = TextBox1_Int.Text
            .WenDi = TextBox1_WenDi.Text
            .head_hp = TextBox1_Head_hp.Text
            .head_Con = TextBox1_Head_con.Text
            .body_hp = TextBox1_body_hp.Text
            .body_xiong_Con = TextBox1_Xiong_con.Text
            .body_back_Con = TextBox1_back_con.Text
            .body_yao_Con = TextBox1_yao_con.Text
            .armLeft_hp = TextBox1_arm_hp.Text
            .armLeft_Con = TextBox1_arm_con.Text
            .armRight_hp = TextBox1_arm_hp.Text
            .armRight_Con = TextBox1_arm_con.Text
            .footLeft_hp = TextBox1_foot_hp.Text
            .footLeft_Con = TextBox1_foot_con.Text
            .footRight_hp = TextBox1_foot_hp.Text
            .footRight_Con = TextBox1_foot_con.Text
        End With
        With per2
            .Pow = TextBox2_Pow.Text
            .Dev = TextBox2_Dev.Text
            .Int = TextBox2_Int.Text
            .WenDi = TextBox2_WenDi.Text
            .head_hp = TextBox2_Head_hp.Text
            .head_Con = TextBox2_Head_con.Text
            .body_hp = TextBox2_body_hp.Text
            .body_xiong_Con = TextBox2_Xiong_con.Text
            .body_back_Con = TextBox2_back_con.Text
            .body_yao_Con = TextBox2_yao_con.Text
            .armLeft_hp = TextBox2_arm_hp.Text
            .armLeft_Con = TextBox2_arm_con.Text
            .armRight_hp = TextBox2_arm_hp.Text
            .armRight_Con = TextBox2_arm_con.Text
            .footLeft_hp = TextBox2_foot_hp.Text
            .footLeft_Con = TextBox2_foot_con.Text
            .footRight_hp = TextBox2_foot_hp.Text
            .footRight_Con = TextBox2_foot_con.Text
        End With

        With Me
            Dim Dwidth As Double = 200 / per1.body_hp
            .ProgressBar1_Head.Width = per1.head_hp * Dwidth
            .ProgressBar1_Head.Value = 100
            .ProgressBar1_body.Value = 100
            .ProgressBar1_aLeft.Width = per1.armLeft_hp * Dwidth
            .ProgressBar1_aLeft.Value = 100
            .ProgressBar1_aRight.Width = per1.armRight_hp * Dwidth
            .ProgressBar1_aRight.Value = 100
            .ProgressBar1_fLeft.Width = per1.footLeft_hp * Dwidth
            .ProgressBar1_fLeft.Value = 100
            .ProgressBar1_fRight.Width = per1.footRight_hp * Dwidth
            .ProgressBar1_fRight.Value = 100

            Dwidth = 200 / per2.body_hp
            .ProgressBar2_Head.Width = per2.head_hp * Dwidth
            .ProgressBar2_Head.Value = 100
            .ProgressBar2_body.Value = 100
            .ProgressBar2_aLeft.Width = per2.armLeft_hp * Dwidth
            .ProgressBar2_aLeft.Value = 100
            .ProgressBar2_aRight.Width = per2.armRight_hp * Dwidth
            .ProgressBar2_aRight.Value = 100
            .ProgressBar2_fLeft.Width = per2.footLeft_hp * Dwidth
            .ProgressBar2_fLeft.Value = 100
            .ProgressBar2_fRight.Width = per2.footRight_hp * Dwidth
            .ProgressBar2_fRight.Value = 100
        End With


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        per1zcX = per1zc.zsChose(1, LianJi， 0)
        BuWei1 = per1zc.AttBuWei(1, wz, per1zcX, siHeng)
        With RichTextBox1
            .AppendText("per1 使出了")
            .SelectionColor = Color.Green
            .AppendText(per1zcX)
            .SelectionColor = Color.Black
            .AppendText(per1zc.miaosuci + " per2 ")
            .AppendText(BuWei1 + Environment.NewLine)
        End With





        per2zcX = per2zc.zsChose(1, LianJi， 0)
        BuWei2 = per2zc.AttBuWei(1, wz, per2zcX, siHeng)
        With RichTextBox1
            .AppendText("per2 使出了")
            .SelectionColor = Color.Green
            .AppendText(per2zcX)
            .SelectionColor = Color.Black
            .AppendText(per2zc.miaosuci + " per1 ")
            .AppendText(BuWei2 + Environment.NewLine)
        End With


        RichTextBox1.ScrollToCaret() '滚动到光标处



    End Sub



End Class
