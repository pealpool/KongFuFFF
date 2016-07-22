'太极拳
Public Class TaiJiChose
    Dim zs As String() = {"【引手】", "【攀打】", "【推手】", "【擒拿】", "【双峰贯耳】", "【云手】"}


    Public Function zsChose(ByVal Att_Con As Integer, ByVal LianJi As String， ByVal SiHeng As Integer) As String
        If Att_Con = 1 Then '攻击
            If SiHeng = 1 Then '失衡
                If Val(Rndz(0, 3)) = 1 Then
                    zsChose = "【双峰贯耳】"
                    Exit Function
                End If
            End If
            If LianJi = "【攀打】" Then
                If Val(Rndz(0, 3)) = 1 Then
                    zsChose = "【攀打】"
                    Exit Function
                End If
            End If
            zsChose = zs(Val(Rndz(0, 4)))
        Else
            '防御
            zsChose = "【云手】"
        End If
    End Function

    Public Function AttBuWei(ByVal who As Integer, ByVal wz As Integer, ByVal zsChose As String) As String
        Dim attbw As String
        Select Case zsChose
            Case "【引手】"
                Form1.RichTextBox1.SelectionColor = Color.Brown
                Form1.RichTextBox1.AppendText("，引诱对方进攻 " + Environment.NewLine)
                AttBuWei = "，引诱对方进攻"
            Case "【攀打】"
                If wz = 0 Then '面对面
                    If Val(Rndz(0, 3)) = 1 Then
                        attbw = "头部"
                    Else
                        attbw = "胸部"
                    End If
                    Form1.RichTextBox1.SelectionColor = Color.Black
                    Form1.RichTextBox1.AppendText("击向 per2 ")
                    Form1.RichTextBox1.SelectionColor = Color.Brown
                    Form1.RichTextBox1.AppendText(attbw + Environment.NewLine)
                Else
                    If Val(Rndz(0, 3)) = 1 Then
                        attbw = "头部"
                    Else
                        attbw = "背部"
                    End If
                    Form1.RichTextBox1.SelectionColor = Color.Black
                    Form1.RichTextBox1.AppendText("击向 per2 ")
                    Form1.RichTextBox1.SelectionColor = Color.Brown
                    Form1.RichTextBox1.AppendText(attbw + Environment.NewLine)
                End If
            Case "【推手】"
                attbw = "身体"
                Form1.RichTextBox1.SelectionColor = Color.Black
                Form1.RichTextBox1.AppendText("推向 per2 ")
                Form1.RichTextBox1.SelectionColor = Color.Brown
                Form1.RichTextBox1.AppendText(attbw + Environment.NewLine)
            Case "【擒拿】"
                If Val(Rndz(0, 3)) = 1 Then
                    attbw = "手部"
                Else
                    attbw = "腿部"
                End If
                Form1.RichTextBox1.SelectionColor = Color.Black
                Form1.RichTextBox1.AppendText("抓向 per2 ")
                Form1.RichTextBox1.SelectionColor = Color.Brown
                Form1.RichTextBox1.AppendText(attbw + Environment.NewLine)
            Case "【双峰贯耳】"
                attbw = "头部"
                Form1.RichTextBox1.SelectionColor = Color.Black
                Form1.RichTextBox1.AppendText("拍向 per2 ")
                Form1.RichTextBox1.SelectionColor = Color.Brown
                Form1.RichTextBox1.AppendText(“两耳” + Environment.NewLine)
        End Select
        If attbw = "" Then
            attbw = "落空"
        End If
        AttBuWei = attbw
    End Function


End Class


'泰拳
Public Class TaiQChose
    Dim zs As String() = {"【直拳】", "【左勾拳】", "【右勾拳】", "【上勾拳】", "【膝撞】", "【蹬腿】", "【踢腿】", "【左肘击】", "【右肘击】", "【膝档】", "【双手遮挡】"}


    Public Function zsChose(ByVal Att_Con As Integer, ByVal LianJi As String) As String
        If Att_Con = 1 Then '攻击
            If LianJi <> "【左勾拳】" Then
                zsChose = zs(Val(Rndz(-1, 9)))
            ElseIf LianJi <> "【右勾拳】" Then
                zsChose = zs(Val(Rndz(-1, 9)))
            Else
                zsChose = zs(Val(Rndz(-1, 7)))
            End If
        Else
            '防御
            zsChose = zs(Val(Rndz(8, 11)))
        End If
    End Function


    Public Function AttBuWei(ByVal who As Integer, ByVal wz As Integer, ByVal zsChose As String, ByVal siheng As Integer) As String
        Dim attbw As String
        Select Case zsChose
            Case "【直拳】", "【左勾拳】", "【右勾拳】", "【左肘击】", "【右肘击】"
                If wz = 1 Then
                    Select Case Val(Rndz(0, 4))
                        Case 1
                            attbw = "头部"
                        Case 2
                            attbw = "胸部"
                        Case 3
                            attbw = "后背"
                    End Select
                Else
                    Select Case Val(Rndz(0, 3))
                        Case 1
                            attbw = "头部"
                        Case 2
                            attbw = "胸部"
                    End Select
                End If
                Form1.RichTextBox1.SelectionColor = Color.Black
                Form1.RichTextBox1.AppendText("击向 per1 ")
                Form1.RichTextBox1.SelectionColor = Color.Brown
                Form1.RichTextBox1.AppendText(attbw + Environment.NewLine)
            Case "【上勾拳】"
                If wz = 1 Then
                    Select Case Val(Rndz(0, 5))
                        Case 1
                            attbw = "头部"
                        Case 2
                            attbw = "胸部"
                        Case 3
                            attbw = "肚子"
                        Case 4
                            attbw = "后背"
                    End Select
                Else
                    Select Case Val(Rndz(0, 4))
                        Case 1
                            attbw = "头部"
                        Case 2
                            attbw = "胸部"
                        Case 3
                            attbw = "肚子"
                    End Select
                End If
                Form1.RichTextBox1.SelectionColor = Color.Black
                Form1.RichTextBox1.AppendText("击向 per1 ")
                Form1.RichTextBox1.SelectionColor = Color.Brown
                Form1.RichTextBox1.AppendText(attbw + Environment.NewLine)
            Case "【膝撞】"
                If siheng = 1 Then '失衡
                    If wz = 1 Then '面向后背
                        Select Case Val(Rndz(0, 5))
                            Case 1
                                attbw = "头部"
                            Case 2
                                attbw = "胸部"
                            Case 3
                                attbw = "肚子"
                            Case 4
                                attbw = "后背"
                        End Select
                    Else
                        Select Case Val(Rndz(0, 4))
                            Case 1
                                attbw = "头部"
                            Case 2
                                attbw = "胸部"
                            Case 3
                                attbw = "肚子"
                        End Select
                    End If
                Else '不失衡
                    If wz = 1 Then
                        Select Case Val(Rndz(0, 3))
                            Case 1
                                attbw = "肚子"
                            Case 2
                                attbw = "后背"
                        End Select
                    Else
                        attbw = "胸部"
                    End If
                End If
                Form1.RichTextBox1.SelectionColor = Color.Black
                Form1.RichTextBox1.AppendText("撞向 per1 ")
                Form1.RichTextBox1.SelectionColor = Color.Brown
                Form1.RichTextBox1.AppendText(attbw + Environment.NewLine)
            Case "【蹬腿】"
                If wz = 1 Then
                    Select Case Val(Rndz(0, 3))
                        Case 1
                            attbw = "肚子"
                        Case 2
                            attbw = "后背"
                    End Select
                Else
                    attbw = "肚子"
                End If
                Form1.RichTextBox1.SelectionColor = Color.Black
                Form1.RichTextBox1.AppendText("蹬向 per1 ")
                Form1.RichTextBox1.SelectionColor = Color.Brown
                Form1.RichTextBox1.AppendText(attbw + Environment.NewLine)
            Case "【踢腿】"
                If siheng = 1 Then '失衡
                    If wz = 1 Then '面向后背
                        Select Case Val(Rndz(0, 6))
                            Case 1
                                attbw = "头部"
                            Case 2
                                attbw = "手臂"
                            Case 3
                                attbw = "肚子"
                            Case 4
                                attbw = "后背"
                            Case 5
                                attbw = "腿部"
                        End Select
                    Else
                        Select Case Val(Rndz(0, 5))
                            Case 1
                                attbw = "头部"
                            Case 2
                                attbw = "手臂"
                            Case 3
                                attbw = "肚子"
                            Case 4
                                attbw = "腿部"
                        End Select
                    End If
                Else '不失衡
                    If wz = 1 Then
                        Select Case Val(Rndz(0, 5))
                            Case 1
                                attbw = "手臂"
                            Case 2
                                attbw = "肚子"
                            Case 3
                                attbw = "后背"
                            Case 4
                                attbw = "腿部"
                        End Select
                    Else
                        Select Case Val(Rndz(0, 4))
                            Case 1
                                attbw = "手臂"
                            Case 2
                                attbw = "肚子"
                            Case 3
                                attbw = "腿部"
                        End Select
                    End If
                End If
                Form1.RichTextBox1.SelectionColor = Color.Black
                Form1.RichTextBox1.AppendText("踢向 per1 ")
                Form1.RichTextBox1.SelectionColor = Color.Brown
                Form1.RichTextBox1.AppendText(attbw + Environment.NewLine)
        End Select
    End Function


End Class
