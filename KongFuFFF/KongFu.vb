﻿Public Class KongFuChose
    Dim zsTaiJi As String() = {"【引手】", "【攀打】", "【推手】", "【擒拿】", "【双峰贯耳】", "【云手】", "【卸力化劲】"}
    Dim zsTaiQr As String() = {"【直拳】", "【左勾拳】", "【右勾拳】", "【上勾拳】", "【膝撞】", "【蹬腿】", "【踢腿】", "【左肘击】", "【右肘击】", "【膝档】", "【双手遮挡】"}
    Public zs As Integer '1太极，2泰拳
    Public miaosuci As String

    Public Function watt(ByVal Zhaosi As String) As Integer
        Select Case Zhaosi
            Case "【攀打】"
                watt = 5
            Case "【推手】"
                watt = 2
            Case "【擒拿】"
                watt = 2
            Case "【双峰贯耳】"
                watt = 5
            Case "【直拳】"
                watt = 5
            Case "【左勾拳】"
                watt = 8
            Case "【右勾拳】"
                watt = 8
            Case "【上勾拳】"
                watt = 8
            Case "【膝撞】"
                watt = 20
            Case "【蹬腿】"
                watt = 10
            Case "【踢腿】"
                watt = 12
            Case "【左肘击】"
                watt = 18
            Case "【右肘击】"
                watt = 18
            Case Else
                watt = 0
        End Select
    End Function

    Public Function natt(ByVal Zhaosi As String) As Integer
        Select Case Zhaosi
            Case "【攀打】"
                natt = 5
            Case "【推手】"
                natt = 8
            Case "【擒拿】"
                natt = 35
            Case "【双峰贯耳】"
                natt = 7
            Case "【直拳】"
                natt = 0
            Case "【左勾拳】"
                natt = 0
            Case "【右勾拳】"
                natt = 0
            Case "【上勾拳】"
                natt = 0
            Case "【膝撞】"
                natt = 0
            Case "【蹬腿】"
                natt = 0
            Case "【踢腿】"
                natt = 0
            Case "【左肘击】"
                natt = 0
            Case "【右肘击】"
                natt = 0
            Case Else
                natt = 0
        End Select
    End Function

    Public Function attWD(ByVal Zhaosi As String) As Integer
        Select Case Zhaosi
            Case "【攀打】"
                attWD = 3
            Case "【推手】"
                attWD = 30
            Case "【擒拿】"
                attWD = 1
            Case "【双峰贯耳】"
                attWD = 5
            Case "【云手】"
                attWD = 40
            Case "【卸力化劲】"
                attWD = 10
            Case "【直拳】"
                attWD = 10
            Case "【左勾拳】"
                attWD = 20
            Case "【右勾拳】"
                attWD = 20
            Case "【上勾拳】"
                attWD = 20
            Case "【膝撞】"
                attWD = 25
            Case "【蹬腿】"
                attWD = 30
            Case "【踢腿】"
                attWD = 20
            Case "【左肘击】"
                attWD = 25
            Case "【右肘击】"
                attWD = 25
            Case Else
                attWD = 0
        End Select
    End Function

    Public Function zsChose(ByVal PaiXi As String, ByVal Att_Con As Integer, ByVal LianJi As String， ByVal SiHeng As Integer) As String
        Select Case PaiXi
            Case "太极"
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
                    zsChose = zsTaiJi(Val(Rndz(-1, 4)))
                Else
                    '防御
                    zsChose = "【云手】"
                End If
            Case "泰拳"
                If Att_Con = 1 Then '攻击
                    If LianJi <> "【左勾拳】" Then
                        zsChose = zsTaiQr(Val(Rndz(-1, 9)))
                    ElseIf LianJi <> "【右勾拳】" Then
                        zsChose = zsTaiQr(Val(Rndz(-1, 9)))
                    Else
                        zsChose = zsTaiQr(Val(Rndz(-1, 7)))
                    End If
                Else
                    '防御
                    zsChose = zsTaiQr(Val(Rndz(8, 11)))
                End If
        End Select

    End Function

    Public Function AttBuWei(ByVal PaiXi As String, ByVal wz As Integer, ByVal zsChose As String, ByVal siheng As Integer) As String
        Select Case PaiXi
            Case "太极"
                Select Case zsChose
                    Case "【引手】"
                        AttBuWei = "攻击"
                        miaosuci = "引诱"
                    Case "【攀打】"
                        If wz = 0 Then '面对面
                            If Val(Rndz(0, 3)) = 1 Then
                                AttBuWei = "头部"
                            Else
                                AttBuWei = "胸部"
                            End If
                        Else
                            If Val(Rndz(0, 3)) = 1 Then
                                AttBuWei = "头部"
                            Else
                                AttBuWei = "后背"
                            End If
                        End If
                        miaosuci = "击向"
                    Case "【推手】"
                        If wz = 0 Then '面对面
                            AttBuWei = "胸部"
                        Else
                            AttBuWei = "后背"
                        End If
                        miaosuci = "推向"
                    Case "【擒拿】"
                        If Val(Rndz(0, 3)) = 1 Then
                            If Val(Rndz(0, 3)) = 1 Then
                                AttBuWei = "左手"
                            Else
                                AttBuWei = "右手"
                            End If
                            miaosuci = "抓向"
                        Else
                            If Val(Rndz(0, 3)) = 1 Then
                                AttBuWei = "左腿"
                            Else
                                AttBuWei = "右腿"
                            End If
                            miaosuci = "缠绊"
                        End If
                    Case "【双峰贯耳】"
                        AttBuWei = "头部"
                        miaosuci = "拍向"
                    Case Else
                        AttBuWei = "落空"
                        miaosuci = ""
                End Select
            Case "泰拳"
                Select Case zsChose
                    Case "【直拳】", "【左勾拳】", "【右勾拳】", "【左肘击】", "【右肘击】"
                        If wz = 1 Then
                            Select Case Val(Rndz(0, 4))
                                Case 1
                                    AttBuWei = "头部"
                                Case 2
                                    AttBuWei = "胸部"
                                Case 3
                                    AttBuWei = "后背"
                            End Select
                        Else
                            Select Case Val(Rndz(0, 3))
                                Case 1
                                    AttBuWei = "头部"
                                Case 2
                                    AttBuWei = "胸部"
                            End Select
                        End If
                        miaosuci = "击向"
                    Case "【上勾拳】"
                        If wz = 1 Then
                            Select Case Val(Rndz(0, 5))
                                Case 1
                                    AttBuWei = "头部"
                                Case 2
                                    AttBuWei = "胸部"
                                Case 3
                                    AttBuWei = "小腹"
                                Case 4
                                    AttBuWei = "后背"
                            End Select
                        Else
                            Select Case Val(Rndz(0, 4))
                                Case 1
                                    AttBuWei = "头部"
                                Case 2
                                    AttBuWei = "胸部"
                                Case 3
                                    AttBuWei = "小腹"
                            End Select
                        End If
                        miaosuci = "击向"
                    Case "【膝撞】"
                        If siheng = 1 Then '失衡
                            If wz = 1 Then '面向后背
                                Select Case Val(Rndz(0, 5))
                                    Case 1
                                        AttBuWei = "头部"
                                    Case 2
                                        AttBuWei = "胸部"
                                    Case 3
                                        AttBuWei = "小腹"
                                    Case 4
                                        AttBuWei = "后背"
                                End Select
                            Else
                                Select Case Val(Rndz(0, 4))
                                    Case 1
                                        AttBuWei = "头部"
                                    Case 2
                                        AttBuWei = "胸部"
                                    Case 3
                                        AttBuWei = "小腹"
                                End Select
                            End If
                        Else '不失衡
                            If wz = 1 Then
                                Select Case Val(Rndz(0, 3))
                                    Case 1
                                        AttBuWei = "小腹"
                                    Case 2
                                        AttBuWei = "后背"
                                End Select
                            Else
                                AttBuWei = "胸部"
                            End If
                        End If
                        miaosuci = "撞向"
                    Case "【蹬腿】"
                        If wz = 1 Then
                            Select Case Val(Rndz(0, 3))
                                Case 1
                                    AttBuWei = "小腹"
                                Case 2
                                    AttBuWei = "后背"
                            End Select
                        Else
                            AttBuWei = "小腹"
                        End If
                        miaosuci = "蹬向"
                    Case "【踢腿】"
                        If siheng = 1 Then '失衡
                            If wz = 1 Then '面向后背
                                Select Case Val(Rndz(0, 6))
                                    Case 1
                                        AttBuWei = "头部"
                                    Case 2
                                        If Val(Rndz(0, 3)) = 1 Then
                                            AttBuWei = "左手"
                                        Else
                                            AttBuWei = "右手"
                                        End If
                                    Case 3
                                        AttBuWei = "小腹"
                                    Case 4
                                        AttBuWei = "后背"
                                    Case 5
                                        If Val(Rndz(0, 3)) = 1 Then
                                            AttBuWei = "左腿"
                                        Else
                                            AttBuWei = "右腿"
                                        End If
                                End Select
                            Else
                                Select Case Val(Rndz(0, 5))
                                    Case 1
                                        AttBuWei = "头部"
                                    Case 2
                                        If Val(Rndz(0, 3)) = 1 Then
                                            AttBuWei = "左手"
                                        Else
                                            AttBuWei = "右手"
                                        End If
                                    Case 3
                                        AttBuWei = "小腹"
                                    Case 4
                                        If Val(Rndz(0, 3)) = 1 Then
                                            AttBuWei = "左腿"
                                        Else
                                            AttBuWei = "右腿"
                                        End If
                                End Select
                            End If
                        Else '不失衡
                            If wz = 1 Then
                                Select Case Val(Rndz(0, 5))
                                    Case 1
                                        If Val(Rndz(0, 3)) = 1 Then
                                            AttBuWei = "左手"
                                        Else
                                            AttBuWei = "右手"
                                        End If
                                    Case 2
                                        AttBuWei = "小腹"
                                    Case 3
                                        AttBuWei = "后背"
                                    Case 4
                                        If Val(Rndz(0, 3)) = 1 Then
                                            AttBuWei = "左腿"
                                        Else
                                            AttBuWei = "右腿"
                                        End If
                                End Select
                            Else
                                Select Case Val(Rndz(0, 4))
                                    Case 1
                                        If Val(Rndz(0, 3)) = 1 Then
                                            AttBuWei = "左手"
                                        Else
                                            AttBuWei = "右手"
                                        End If
                                    Case 2
                                        AttBuWei = "小腹"
                                    Case 3
                                        If Val(Rndz(0, 3)) = 1 Then
                                            AttBuWei = "左腿"
                                        Else
                                            AttBuWei = "右腿"
                                        End If
                                End Select
                            End If
                        End If
                        miaosuci = "踢向"
                End Select
        End Select
    End Function

End Class


'太极拳
'Public Class TaiJiChose
'    Dim zs As String() = {"【引手】", "【攀打】", "【推手】", "【擒拿】", "【双峰贯耳】", "【云手】", "【卸力化劲】"}
'    Public miaosuci As String

'    Public Function watt(ByVal Zhaosi As String) As Integer
'        Select Case Zhaosi
'            Case "【攀打】"
'                watt = 5
'            Case "【推手】"
'                watt = 2
'            Case "【擒拿】"
'                watt = 2
'            Case "【双峰贯耳】"
'                watt = 5
'            Case Else
'                watt = 0
'        End Select
'    End Function

'    Public Function natt(ByVal Zhaosi As String) As Integer
'        Select Case Zhaosi
'            Case "【攀打】"
'                natt = 5
'            Case "【推手】"
'                natt = 8
'            Case "【擒拿】"
'                natt = 35
'            Case "【双峰贯耳】"
'                natt = 7
'            Case Else
'                natt = 0
'        End Select
'    End Function

'    Public Function attWD(ByVal Zhaosi As String) As Integer
'        Select Case Zhaosi
'            Case "【攀打】"
'                attWD = 3
'            Case "【推手】"
'                attWD = 30
'            Case "【擒拿】"
'                attWD = 1
'            Case "【双峰贯耳】"
'                attWD = 5
'            Case "【云手】"
'                attWD = 40
'            Case "【卸力化劲】"
'                attWD = 10
'            Case Else
'                attWD = 0
'        End Select
'    End Function

'    Public Function zsChose(ByVal Att_Con As Integer, ByVal LianJi As String， ByVal SiHeng As Integer) As String
'        If Att_Con = 1 Then '攻击
'            If SiHeng = 1 Then '失衡
'                If Val(Rndz(0, 3)) = 1 Then
'                    zsChose = "【双峰贯耳】"
'                    Exit Function
'                End If
'            End If
'            If LianJi = "【攀打】" Then
'                If Val(Rndz(0, 3)) = 1 Then
'                    zsChose = "【攀打】"
'                    Exit Function
'                End If
'            End If
'            zsChose = zs(Val(Rndz(-1, 4)))
'        Else
'            '防御
'            zsChose = "【云手】"
'        End If
'    End Function

'    Public Function AttBuWei(ByVal who As Integer, ByVal wz As Integer, ByVal zsChose As String, ByVal siheng As Integer) As String
'        Select Case zsChose
'            Case "【引手】"
'                AttBuWei = "攻击"
'                miaosuci = "引诱"
'            Case "【攀打】"
'                If wz = 0 Then '面对面
'                    If Val(Rndz(0, 3)) = 1 Then
'                        AttBuWei = "头部"
'                    Else
'                        AttBuWei = "胸部"
'                    End If
'                Else
'                    If Val(Rndz(0, 3)) = 1 Then
'                        AttBuWei = "头部"
'                    Else
'                        AttBuWei = "后背"
'                    End If
'                End If
'                miaosuci = "击向"
'            Case "【推手】"
'                AttBuWei = "身体"
'                miaosuci = "推向"
'            Case "【擒拿】"
'                If Val(Rndz(0, 3)) = 1 Then
'                    AttBuWei = "手部"
'                    miaosuci = "抓向"
'                Else
'                    AttBuWei = "腿部"
'                    miaosuci = "缠绊"
'                End If
'            Case "【双峰贯耳】"
'                AttBuWei = "头部"
'                miaosuci = "拍向"
'        End Select
'        If AttBuWei = "" Then
'            AttBuWei = "落空"
'            miaosuci = ""
'        End If
'    End Function

'End Class


''泰拳
'Public Class TaiQChose
'    Dim zs As String() = {"【直拳】", "【左勾拳】", "【右勾拳】", "【上勾拳】", "【膝撞】", "【蹬腿】", "【踢腿】", "【左肘击】", "【右肘击】", "【膝档】", "【双手遮挡】"}
'    Public miaosuci As String

'    Public Function watt(ByVal Zhaosi As String) As Integer
'        Select Case Zhaosi
'            Case "【直拳】"
'                watt = 5
'            Case "【左勾拳】"
'                watt = 8
'            Case "【右勾拳】"
'                watt = 8
'            Case "【上勾拳】"
'                watt = 8
'            Case "【膝撞】"
'                watt = 20
'            Case "【蹬腿】"
'                watt = 10
'            Case "【踢腿】"
'                watt = 12
'            Case "【左肘击】"
'                watt = 18
'            Case "【右肘击】"
'                watt = 18
'            Case Else
'                watt = 0
'        End Select
'    End Function

'    Public Function natt(ByVal Zhaosi As String) As Integer
'        Select Case Zhaosi
'            Case "【直拳】"
'                natt = 0
'            Case "【左勾拳】"
'                natt = 0
'            Case "【右勾拳】"
'                natt = 0
'            Case "【上勾拳】"
'                natt = 0
'            Case "【膝撞】"
'                natt = 0
'            Case "【蹬腿】"
'                natt = 0
'            Case "【踢腿】"
'                natt = 0
'            Case "【左肘击】"
'                natt = 0
'            Case "【右肘击】"
'                natt = 0
'            Case Else
'                natt = 0
'        End Select
'    End Function

'    Public Function attWD(ByVal Zhaosi As String) As Integer
'        Select Case Zhaosi
'            Case "【直拳】"
'                attWD = 10
'            Case "【左勾拳】"
'                attWD = 20
'            Case "【右勾拳】"
'                attWD = 20
'            Case "【上勾拳】"
'                attWD = 20
'            Case "【膝撞】"
'                attWD = 25
'            Case "【蹬腿】"
'                attWD = 30
'            Case "【踢腿】"
'                attWD = 20
'            Case "【左肘击】"
'                attWD = 25
'            Case "【右肘击】"
'                attWD = 25
'            Case Else
'                attWD = 0
'        End Select
'    End Function

'    Public Function zsChose(ByVal Att_Con As Integer, ByVal LianJi As String, ByVal SiHeng As Integer) As String
'        If Att_Con = 1 Then '攻击
'            If LianJi <> "【左勾拳】" Then
'                zsChose = zs(Val(Rndz(-1, 9)))
'            ElseIf LianJi <> "【右勾拳】" Then
'                zsChose = zs(Val(Rndz(-1, 9)))
'            Else
'                zsChose = zs(Val(Rndz(-1, 7)))
'            End If
'        Else
'            '防御
'            zsChose = zs(Val(Rndz(8, 11)))
'        End If
'    End Function


'    Public Function AttBuWei(ByVal who As Integer, ByVal wz As Integer, ByVal zsChose As String, ByVal siheng As Integer) As String
'        Select Case zsChose
'            Case "【直拳】", "【左勾拳】", "【右勾拳】", "【左肘击】", "【右肘击】"
'                If wz = 1 Then
'                    Select Case Val(Rndz(0, 4))
'                        Case 1
'                            AttBuWei = "头部"
'                        Case 2
'                            AttBuWei = "胸部"
'                        Case 3
'                            AttBuWei = "后背"
'                    End Select
'                Else
'                    Select Case Val(Rndz(0, 3))
'                        Case 1
'                            AttBuWei = "头部"
'                        Case 2
'                            AttBuWei = "胸部"
'                    End Select
'                End If
'                miaosuci = "击向"
'            Case "【上勾拳】"
'                If wz = 1 Then
'                    Select Case Val(Rndz(0, 5))
'                        Case 1
'                            AttBuWei = "头部"
'                        Case 2
'                            AttBuWei = "胸部"
'                        Case 3
'                            AttBuWei = "小腹"
'                        Case 4
'                            AttBuWei = "后背"
'                    End Select
'                Else
'                    Select Case Val(Rndz(0, 4))
'                        Case 1
'                            AttBuWei = "头部"
'                        Case 2
'                            AttBuWei = "胸部"
'                        Case 3
'                            AttBuWei = "小腹"
'                    End Select
'                End If
'                miaosuci = "击向"
'            Case "【膝撞】"
'                If siheng = 1 Then '失衡
'                    If wz = 1 Then '面向后背
'                        Select Case Val(Rndz(0, 5))
'                            Case 1
'                                AttBuWei = "头部"
'                            Case 2
'                                AttBuWei = "胸部"
'                            Case 3
'                                AttBuWei = "小腹"
'                            Case 4
'                                AttBuWei = "后背"
'                        End Select
'                    Else
'                        Select Case Val(Rndz(0, 4))
'                            Case 1
'                                AttBuWei = "头部"
'                            Case 2
'                                AttBuWei = "胸部"
'                            Case 3
'                                AttBuWei = "小腹"
'                        End Select
'                    End If
'                Else '不失衡
'                    If wz = 1 Then
'                        Select Case Val(Rndz(0, 3))
'                            Case 1
'                                AttBuWei = "小腹"
'                            Case 2
'                                AttBuWei = "后背"
'                        End Select
'                    Else
'                        AttBuWei = "胸部"
'                    End If
'                End If
'                miaosuci = "撞向"
'            Case "【蹬腿】"
'                If wz = 1 Then
'                    Select Case Val(Rndz(0, 3))
'                        Case 1
'                            AttBuWei = "小腹"
'                        Case 2
'                            AttBuWei = "后背"
'                    End Select
'                Else
'                    AttBuWei = "小腹"
'                End If
'                miaosuci = "蹬向"
'            Case "【踢腿】"
'                If siheng = 1 Then '失衡
'                    If wz = 1 Then '面向后背
'                        Select Case Val(Rndz(0, 6))
'                            Case 1
'                                AttBuWei = "头部"
'                            Case 2
'                                AttBuWei = "手臂"
'                            Case 3
'                                AttBuWei = "小腹"
'                            Case 4
'                                AttBuWei = "后背"
'                            Case 5
'                                AttBuWei = "腿部"
'                        End Select
'                    Else
'                        Select Case Val(Rndz(0, 5))
'                            Case 1
'                                AttBuWei = "头部"
'                            Case 2
'                                AttBuWei = "手臂"
'                            Case 3
'                                AttBuWei = "小腹"
'                            Case 4
'                                AttBuWei = "腿部"
'                        End Select
'                    End If
'                Else '不失衡
'                    If wz = 1 Then
'                        Select Case Val(Rndz(0, 5))
'                            Case 1
'                                AttBuWei = "手臂"
'                            Case 2
'                                AttBuWei = "小腹"
'                            Case 3
'                                AttBuWei = "后背"
'                            Case 4
'                                AttBuWei = "腿部"
'                        End Select
'                    Else
'                        Select Case Val(Rndz(0, 4))
'                            Case 1
'                                AttBuWei = "手臂"
'                            Case 2
'                                AttBuWei = "小腹"
'                            Case 3
'                                AttBuWei = "腿部"
'                        End Select
'                    End If
'                End If
'                miaosuci = "踢向"
'        End Select
'    End Function
'End Class

Public Class Person
    Public Name As String
    Public Pow As Integer '力量
    Public Dev As Integer '敏捷
    Public Int As Integer '智力
    Public WenDi As Integer '稳定度
    Public WenDiGU As Integer '稳定度固定值
    Public Falldown As Integer '失衡状态：0正常。1踉跄。2倒地。
    Public KF As String '选择的功夫

    Public head_hp As Integer
    Public head_hp_G As Integer
    Public head_Con As Integer
    Public head_ZhuangTai As Integer '部位状态：0正常。1空血。2扭伤。3出血。
    Public head_ChuXcs As Integer '出血剩余次数
    Public head_ChuXl As Integer '每次出血伤害

    'Public Sub ChuXjisuan()
    '    If ChuXcs > 0 Then
    '        hp = hp - ChuXl
    '        ChuXcs = ChuXcs - 1
    '    End If
    'End Sub

    Public Function head_Hart(ByVal watt As Integer, ByVal natt As Integer, ByVal SiHeng As Integer) As Integer
        Select Case SiHeng
            Case 2
                head_Hart = watt + natt
            Case 1
                head_Hart = watt * (10 / (0.5 * head_Con + 10)) + natt
            Case Else
                head_Hart = watt * (10 / (head_Con + 10)) + natt * (10 / (0.5 * head_Con + 10))
        End Select
        head_hp = head_hp - head_Hart
    End Function



    Public body_hp As Integer
    Public body_hp_G As Integer
    Public body_xiong_Con, body_back_Con, body_yao_Con As Integer
    Public body_ZhuangTai As Integer '部位状态：0正常。1空血。2扭伤。3出血。
    Public body_ChuXcs As Integer '出血剩余次数
    Public body_ChuXl As Integer '每次出血伤害

    Public Function body_Hart(ByVal watt As Integer, ByVal natt As Integer, ByVal SiHeng As Integer, ByVal bodyBuWei As String) As Integer
        Select Case bodyBuWei
            Case "胸部"
                Select Case SiHeng
                    Case 2
                        body_Hart = watt + natt
                    Case 1
                        body_Hart = watt * (10 / (0.5 * body_xiong_Con + 10)) + natt
                    Case Else
                        body_Hart = watt * (10 / (body_xiong_Con + 10)) + natt * (10 / (0.5 * body_xiong_Con + 10))
                End Select
            Case "后背"
                Select Case SiHeng
                    Case 2
                        body_Hart = watt + natt
                    Case 1
                        body_Hart = watt * (10 / (0.5 * body_back_Con + 10)) + natt
                    Case Else
                        body_Hart = watt * (10 / (body_back_Con + 10)) + natt * (10 / (0.5 * body_back_Con + 10))
                End Select
            Case "小腹"
                Select Case SiHeng
                    Case 2
                        body_Hart = watt + natt
                    Case 1
                        body_Hart = watt * (10 / (0.5 * body_yao_Con + 10)) + natt
                    Case Else
                        body_Hart = watt * (10 / (body_yao_Con + 10)) + natt * (10 / (0.5 * body_yao_Con + 10))
                End Select
        End Select
        body_hp = body_hp - body_Hart
    End Function


    Public armLeft_hp As Integer
    Public armLeft_hp_G As Integer
    Public armLeft_Con As Integer
    Public armLeft_ZhuangTai As Integer '部位状态：0正常。1空血。2扭伤。3出血。
    Public armLeft_ChuXcs As Integer '出血剩余次数
    Public armLeft_ChuXl As Integer '每次出血伤害

    Public Function armLeft_Hart(ByVal watt As Integer, ByVal natt As Integer, ByVal SiHeng As Integer) As Integer
        Select Case SiHeng
            Case 2
                armLeft_Hart = watt + natt
            Case 1
                armLeft_Hart = watt * (10 / (0.5 * armLeft_Con + 10)) + natt
            Case Else
                armLeft_Hart = watt * (10 / (armLeft_Con + 10)) + natt * (10 / (0.5 * armLeft_Con + 10))
        End Select
        armLeft_hp = armLeft_hp - armLeft_Hart
    End Function


    Public armRight_hp As Integer
    Public armRight_hp_G As Integer
    Public armRight_Con As Integer
    Public armRight_ZhuangTai As Integer '部位状态：0正常。1空血。2扭伤。3出血。
    Public armRight_ChuXcs As Integer '出血剩余次数
    Public armRight_ChuXl As Integer '每次出血伤害

    Public Function armRight_Hart(ByVal watt As Integer, ByVal natt As Integer, ByVal SiHeng As Integer) As Integer
        Select Case SiHeng
            Case 2
                armRight_Hart = watt + natt
            Case 1
                armRight_Hart = watt * (10 / (0.5 * armRight_Con + 10)) + natt
            Case Else
                armRight_Hart = watt * (10 / (armRight_Con + 10)) + natt * (10 / (0.5 * armRight_Con + 10))
        End Select
        armRight_hp = armRight_hp - armRight_Hart
    End Function


    Public footLeft_hp As Integer
    Public footLeft_hp_G As Integer
    Public footLeft_Con As Integer
    Public footLeft_ZhuangTai As Integer '部位状态：0正常。1空血。2扭伤。3出血。
    Public footLeft_ChuXcs As Integer '出血剩余次数
    Public footLeft_ChuXl As Integer '每次出血伤害

    Public Function footLeft_Hart(ByVal watt As Integer, ByVal natt As Integer, ByVal SiHeng As Integer) As Integer
        Select Case SiHeng
            Case 2
                footLeft_Hart = watt + natt
            Case 1
                footLeft_Hart = watt * (10 / (0.5 * footLeft_Con + 10)) + natt
            Case Else
                footLeft_Hart = watt * (10 / (footLeft_Con + 10)) + natt * (10 / (0.5 * footLeft_Con + 10))
        End Select
        footLeft_hp = footLeft_hp - footLeft_Hart
    End Function


    Public footRight_hp As Integer
    Public footRight_hp_G As Integer
    Public footRight_Con As Integer
    Public footRight_ZhuangTai As Integer '部位状态：0正常。1空血。2扭伤。3出血。
    Public footRight_ChuXcs As Integer '出血剩余次数
    Public footRight_ChuXl As Integer '每次出血伤害

    Public Function footRight_Hart(ByVal watt As Integer, ByVal natt As Integer, ByVal SiHeng As Integer) As Integer
        Select Case SiHeng
            Case 2
                footRight_Hart = watt + natt
            Case 1
                footRight_Hart = watt * (10 / (0.5 * footRight_Con + 10)) + natt
            Case Else
                footRight_Hart = watt * (10 / (footRight_Con + 10)) + natt * (10 / (0.5 * footRight_Con + 10))
        End Select
        footRight_hp = footRight_hp - footRight_Hart
    End Function


End Class