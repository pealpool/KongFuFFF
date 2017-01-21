Public Class Form1
    Public per1, per2 As New Person
    Public per1zc, per2zc As New KongFuChose
    'Public per1zc As New TaiJiChose
    'Public per2zc As New TaiQChose
    Public per1zcX， per2zcX As String '使出的招式
    Public BuWei1， BuWei2 As String '攻击的部位
    Public LianJi As String = 0 '连击
    Public siHeng As Integer = 0 '失衡=1,倒地=2
    Public wz As Integer = 0 'wz 位置状态，0：面对面，1：per1优势，2：per2优势
    Public WenD1, WenD2 As Integer '稳定度
    Public Dwidth1, Dwidth2 As Double 'ProgressBar单位/hp
    Public HuiHe As Integer = 1 '1=per1回合，2=per2回合
    Public HUiHeShu As Integer '回合数

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboBox1.SelectedIndex() = 0
        Me.ComboBox2.SelectedIndex() = 1
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GOset()
    End Sub

    Private Function MinZhong(ByVal per_Att As Person, ByVal per_Con As Person)
        Dim WenDLv As Double
        If per_Con.WenDi >= 100 Then
            WenDLv = 1
        ElseIf per_Con.WenDi >= 75 And per_Con.WenDi < 100 Then
            WenDLv = 1.4 - 0.004 * per_Con.WenDi
        ElseIf per_Con.WenDi >= 52 And per_Con.WenDi < 75 Then
            WenDLv = 2.08 - 0.01 * per_Con.WenDi
        ElseIf per_Con.WenDi >= 37 And per_Con.WenDi > 52 Then
            WenDLv = 3.48 - 0.04 * per_Con.WenDi
        ElseIf per_Con.WenDi >= 26 And per_Con.WenDi < 37 Then
            WenDLv = 5.03 - 0.08 * per_Con.WenDi
        ElseIf per_Con.WenDi < 26 Then
            WenDLv = 7.67 - 0.18 * per_Con.WenDi
        End If
        MinZhong = ((1.2 - 1.2 / (2.5 * per_Att.Dev + 1)) - (1 - 1 / (0.2 * per_Con.Dev + 1))) * WenDLv
        'MinZhong = (1.2 - 1.2 / (0.25 * per_Att.Dev + 1)) - (1 - 1 / (0.02 * per_Con.Dev + 1))
    End Function

    Private Sub GOset()
        Me.RichTextBox1.Clear()
        HuiHe = 1 '1=per1回合，2=per2回合
        HUiHeShu = 1
        With per1
            .Name = "per1"
            .Pow = TextBox1_Pow.Text
            .Dev = TextBox1_Dev.Text
            .Int = TextBox1_Int.Text
            .WenDi = TextBox1_WenDi.Text
            .KF = ComboBox1.Text
            .head_hp = TextBox1_Head_hp.Text
            .head_hp_G = TextBox1_Head_hp.Text
            .head_Con = TextBox1_Head_con.Text
            .body_hp = TextBox1_body_hp.Text
            .body_hp_G = TextBox1_body_hp.Text
            .body_xiong_Con = TextBox1_Xiong_con.Text
            .body_back_Con = TextBox1_back_con.Text
            .body_yao_Con = TextBox1_yao_con.Text
            .armLeft_hp = TextBox1_arm_hp.Text
            .armLeft_hp_G = TextBox1_arm_hp.Text
            .armLeft_Con = TextBox1_arm_con.Text
            .armRight_hp = TextBox1_arm_hp.Text
            .armRight_hp_G = TextBox1_arm_hp.Text
            .armRight_Con = TextBox1_arm_con.Text
            .footLeft_hp = TextBox1_foot_hp.Text
            .footLeft_hp_G = TextBox1_foot_hp.Text
            .footLeft_Con = TextBox1_foot_con.Text
            .footRight_hp = TextBox1_foot_hp.Text
            .footRight_hp_G = TextBox1_foot_hp.Text
            .footRight_Con = TextBox1_foot_con.Text
            .WenDiGU = TextBox1_WenDi.Text
            .WenDi = .WenDiGU
        End With
        With per2
            .Name = "per2"
            .Pow = TextBox2_Pow.Text
            .Dev = TextBox2_Dev.Text
            .Int = TextBox2_Int.Text
            .WenDi = TextBox2_WenDi.Text
            .KF = ComboBox2.Text
            .head_hp = TextBox2_Head_hp.Text
            .head_hp_G = TextBox2_Head_hp.Text
            .head_Con = TextBox2_Head_con.Text
            .body_hp = TextBox2_body_hp.Text
            .body_hp_G = TextBox2_body_hp.Text
            .body_xiong_Con = TextBox2_Xiong_con.Text
            .body_back_Con = TextBox2_back_con.Text
            .body_yao_Con = TextBox2_yao_con.Text
            .armLeft_hp = TextBox2_arm_hp.Text
            .armLeft_hp_G = TextBox2_arm_hp.Text
            .armLeft_Con = TextBox2_arm_con.Text
            .armRight_hp = TextBox2_arm_hp.Text
            .armRight_hp_G = TextBox2_arm_hp.Text
            .armRight_Con = TextBox2_arm_con.Text
            .footLeft_hp = TextBox2_foot_hp.Text
            .footLeft_hp_G = TextBox2_foot_hp.Text
            .footLeft_Con = TextBox2_foot_con.Text
            .footRight_hp = TextBox2_foot_hp.Text
            .footRight_hp_G = TextBox2_foot_hp.Text
            .footRight_Con = TextBox2_foot_con.Text
            .WenDiGU = TextBox2_WenDi.Text
            .WenDi = .WenDiGU
        End With

        With Me
            Dwidth1 = 200 / per1.body_hp
            .ProgressBar1_Head.Width = per1.head_hp * Dwidth1
            .ProgressBar1_Head.Value = 100
            .ProgressBar1_body.Value = 100
            .ProgressBar1_aLeft.Width = per1.armLeft_hp * Dwidth1
            .ProgressBar1_aLeft.Value = 100
            .ProgressBar1_aRight.Width = per1.armRight_hp * Dwidth1
            .ProgressBar1_aRight.Value = 100
            .ProgressBar1_fLeft.Width = per1.footLeft_hp * Dwidth1
            .ProgressBar1_fLeft.Value = 100
            .ProgressBar1_fRight.Width = per1.footRight_hp * Dwidth1
            .ProgressBar1_fRight.Value = 100

            Dwidth2 = 200 / per2.body_hp
            .ProgressBar2_Head.Width = per2.head_hp * Dwidth2
            .ProgressBar2_Head.Value = 100
            .ProgressBar2_body.Value = 100
            .ProgressBar2_aLeft.Width = per2.armLeft_hp * Dwidth2
            .ProgressBar2_aLeft.Value = 100
            .ProgressBar2_aRight.Width = per2.armRight_hp * Dwidth2
            .ProgressBar2_aRight.Value = 100
            .ProgressBar2_fLeft.Width = per2.footLeft_hp * Dwidth2
            .ProgressBar2_fLeft.Value = 100
            .ProgressBar2_fRight.Width = per2.footRight_hp * Dwidth2
            .ProgressBar2_fRight.Value = 100
        End With
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GOset()
        Do While HuiHe <> 0
            RichTextBox1.SelectionColor = Color.DeepPink
            RichTextBox1.AppendText("第" + HUiHeShu.ToString + "回合" + Environment.NewLine)
            RichTextBox1.SelectionColor = Color.Green
            Select Case HuiHe
                Case 1
                    ZhaoSiGO(per1, per2, per1zc, siHeng)
                    HuiHe = 2
                Case 2
                    ZhaoSiGO(per2, per1, per2zc, siHeng)
                    HuiHe = 1
            End Select
            RichTextBox1.ScrollToCaret() '滚动到光标处
            ReflashProgressBar()
            HUiHeShu = HUiHeShu + 1
        Loop
    End Sub

    Private Sub ZhaoSiGO(ByVal perAtt As Person, ByVal perCon As Person, ByVal perzc As KongFuChose, ByVal siHeng As Integer)
        Dim watt, natt, attWD, sunatt As Integer
        Dim perzcX, BuWei As String '招式，部位
        perzcX = perzc.zsChose(perAtt.KF, 1, LianJi， 0)
        BuWei = perzc.AttBuWei(perAtt.KF, wz, perzcX, siHeng)
        With RichTextBox1
            .SelectionColor = Color.Black
            .AppendText(perAtt.Name + " 使出了")
            .SelectionColor = Color.Green
            .AppendText(perzcX)
            .SelectionColor = Color.Black
            .AppendText(perzc.miaosuci + " " + perCon.Name + " ")
            .SelectionColor = Color.DarkSlateBlue
            .AppendText(BuWei + Environment.NewLine)
        End With
        If MinZhong(perAtt, perCon) >= (Val(Rndz(0, 101)) * 0.01) Then
            watt = perzc.watt(perzcX)
            natt = perzc.natt(perzcX)
            perCon.WenDi = perCon.WenDi - perzc.attWD(perzcX)
            Select Case BuWei
                Case “头部”
                    sunatt = perCon.head_Hart(watt, natt, siHeng)
                Case “胸部”
                    sunatt = perCon.body_Hart(watt, natt, siHeng, BuWei)
                Case “后背”
                    sunatt = perCon.body_Hart(watt, natt, siHeng, BuWei)
                Case “小腹”
                    sunatt = perCon.body_Hart(watt, natt, siHeng, BuWei)
                Case “左手”
                    sunatt = perCon.armLeft_Hart(watt, natt, siHeng)
                Case “右手”
                    sunatt = perCon.armRight_Hart(watt, natt, siHeng)
                Case “左腿”
                    sunatt = perCon.footLeft_Hart(watt, natt, siHeng)
                Case “右腿”
                    sunatt = perCon.footRight_Hart(watt, natt, siHeng)
            End Select
            RichTextBox1.AppendText("造成 " + sunatt.ToString + " 伤害。" + Environment.NewLine)
        Else
            RichTextBox1.AppendText("闪避" + Environment.NewLine)
            perCon.WenDi = perCon.WenDi - 10
        End If
    End Sub

    Private Sub ReflashProgressBar()
        Dim a As Integer
        a = per1.head_hp / per1.head_hp_G * 100
        If a > 0 And a <= 100 Then
            ProgressBar1_Head.Value = a
        Else
            ProgressBar1_Head.Value = 0
        End If
        a = per1.head_hp / per1.head_hp_G * 100
        If a > 0 And a <= 100 Then
            ProgressBar1_Head.Value = a
        Else
            ProgressBar1_Head.Value = 0
        End If
        a = per1.body_hp / per1.body_hp_G * 100
        If a > 0 And a <= 100 Then
            ProgressBar1_body.Value = a
        Else
            ProgressBar1_body.Value = 0
        End If
        a = per1.armLeft_hp / per1.armLeft_hp_G * 100
        If a > 0 And a <= 100 Then
            ProgressBar1_aLeft.Value = a
        Else
            ProgressBar1_aLeft.Value = 0
        End If
        a = per1.armRight_hp / per1.armRight_hp_G * 100
        If a > 0 And a <= 100 Then
            ProgressBar1_aRight.Value = a
        Else
            ProgressBar1_aRight.Value = 0
        End If
        a = per1.footLeft_hp / per1.footLeft_hp_G * 100
        If a > 0 And a <= 100 Then
            ProgressBar1_fLeft.Value = a
        Else
            ProgressBar1_fLeft.Value = 0
        End If
        a = per1.footRight_hp / per1.footRight_hp_G * 100
        If a > 0 And a <= 100 Then
            ProgressBar1_fRight.Value = a
        Else
            ProgressBar1_fRight.Value = 0
        End If

        a = per2.head_hp / per2.head_hp_G * 100
        If a > 0 And a <= 100 Then
            ProgressBar2_Head.Value = a
        Else
            ProgressBar2_Head.Value = 0
        End If
        a = per2.body_hp / per2.body_hp_G * 100
        If a > 0 And a <= 100 Then
            ProgressBar2_body.Value = a
        Else
            ProgressBar2_body.Value = 0
        End If
        a = per2.armLeft_hp / per2.armLeft_hp_G * 100
        If a > 0 And a <= 100 Then
            ProgressBar2_aLeft.Value = a
        Else
            ProgressBar2_aLeft.Value = 0
        End If
        a = per2.armRight_hp / per2.armRight_hp_G * 100
        If a > 0 And a <= 100 Then
            ProgressBar2_aRight.Value = a
        Else
            ProgressBar2_aRight.Value = 0
        End If
        a = per2.footLeft_hp / per2.footLeft_hp_G * 100
        If a > 0 And a <= 100 Then
            ProgressBar2_fLeft.Value = a
        Else
            ProgressBar2_fLeft.Value = 0
        End If
        a = per2.footRight_hp / per2.footRight_hp_G * 100
        If a > 0 And a <= 100 Then
            ProgressBar2_fRight.Value = a
        Else
            ProgressBar2_fRight.Value = 0
        End If

        If ProgressBar1_Head.Value = 0 Or ProgressBar1_body.Value = 0 Then
            Me.RichTextBox1.SelectionColor = Color.Red
            Me.RichTextBox1.AppendText(per1.Name + " 已被打倒。" + Environment.NewLine)
            HuiHe = 0
        ElseIf ProgressBar2_Head.Value = 0 Or ProgressBar2_body.Value = 0 Then
            Me.RichTextBox1.SelectionColor = Color.Red
            Me.RichTextBox1.AppendText(per2.Name + " 已被打倒。" + Environment.NewLine)
            HuiHe = 0
        End If

    End Sub



End Class
