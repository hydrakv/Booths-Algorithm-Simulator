' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

Imports Windows.UI.Popups
''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        'new code
        If cb1.SelectedIndex = 1 Then
            bits.Text = "0"
            GoTo Dec
        ElseIf cb1.SelectedIndex = 0 Then
            GoTo Bin
        End If
Dec:
        If bits.Text = "0" Then
            Dim f1 As Integer
            Try
                f1 = mm2.Text
            Catch ex2 As Exception
                op.Text = "Enter a Multiplicand"
                GoTo ender1
            End Try
            Dim ff1 As Integer = f1
            If ff1 > 0 Then
                ff1 = f1
            ElseIf ff1 < 0 Then
                ff1 = f1.ToString.Substring(1)
            End If
            Dim bin As Integer = 0
            Dim bin2 As Integer = 0
            Dim sft As String
            Dim sft1 As String
            Dim mf1 As Integer = 0
            If f1 <> 0 Then
                Dim remainder As Integer = 0
                If f1 < 0 Then
                    mf1 = f1.ToString.Substring(1)        ' may error
                    sft = Convert.ToString(mf1, 2)
                ElseIf f1 > 0 Then

                    sft = Convert.ToString(f1, 2)

                End If
                Dim i As Integer = 1

                Dim str1 As String = sft
                ss.Text = sft
                bin = sft
                Dim str2 As String = bin2
                Dim j As Integer = 0
                If f1 > 0 Then

                    If ss.Text.Length = 2 Then
                        j = 1
                        bits.Text = "3"
                        m1.Text = "0"
                        m2.Text = "0"
                        m3.Text = "0"
                        m4.Text = "0"
                        m5.Text = "0"
                        While (j > -1)
                            m7.Text = str1.Substring(1)
                            j = j - 1
                            m6.Text = str1.Substring(0, 1)
                            j = j - 1
                        End While
                    ElseIf ss.Text.Length = 1 Then
                        j = 0
                        bits.Text = "3"
                        m1.Text = "0"
                        m2.Text = "0"
                        m3.Text = "0"
                        m4.Text = "0"
                        m5.Text = "0"
                        m6.Text = "0"
                        While (j > -1)
                            m7.Text = str1.Substring(1)
                            j = j - 1
                        End While
                    ElseIf (ss.Text.Length = 3) Then
                        j = 2
                        bits.Text = "4"
                        m1.Text = "0"
                        m2.Text = "0"
                        m3.Text = "0"
                        m4.Text = "0"
                        While (j > -1)

                            m5.Text = str1.Substring(0, 1)

                            j = j - 1

                            m6.Text = str1.Substring(1, 1)
                            j = j - 1

                            m7.Text = str1.Substring(2)
                            j = j - 1

                        End While
                    ElseIf (ss.Text.Length = 4) Then
                        j = 3
                        bits.Text = "5"
                        m1.Text = "0"
                        m2.Text = "0"
                        m3.Text = "0"
                        While (j > -1)
                            m4.Text = str1.Substring(0, 1)
                            j = j - 1
                            m5.Text = str1.Substring(1, 1)
                            j = j - 1
                            m6.Text = str1.Substring(2, 1)
                            j = j - 1
                            m7.Text = str1.Substring(3)
                            j = j - 1

                        End While
                    ElseIf (ss.Text.Length = 5) Then
                        j = 4
                        bits.Text = "6"
                        m1.Text = "0"
                        m2.Text = "0"
                        While (j > -1)
                            m3.Text = str1.Substring(0, 1)
                            j = j - 1
                            m4.Text = str1.Substring(1, 1)
                            j = j - 1
                            m5.Text = str1.Substring(2, 1)
                            j = j - 1
                            m6.Text = str1.Substring(3, 1)
                            j = j - 1
                            m7.Text = str1.Substring(4)
                            j = j - 1

                        End While
                    ElseIf (ss.Text.Length = 6) Then
                        j = 5
                        bits.Text = "7"
                        m1.Text = "0"
                        While (j > -1)
                            m2.Text = str1.Substring(0, 1)
                            j = j - 1
                            m3.Text = str1.Substring(1, 1)
                            j = j - 1
                            m4.Text = str1.Substring(2, 1)
                            j = j - 1
                            m5.Text = str1.Substring(3, 1)
                            j = j - 1
                            m6.Text = str1.Substring(4, 1)
                            j = j - 1
                            m7.Text = str1.Substring(5)
                            j = j - 1

                        End While
                    ElseIf (ss.Text.Length > 6) Then
                        op.Text = "PLEASE ENTER VALUE LESS THAN 64"
                        GoTo ender1
                    End If
                ElseIf f1 < 0 Then
                    If ss.Text.Length = 2 Then
                        j = 1
                        bits.Text = "3"
                        m1.Text = "1"
                        m2.Text = "1"
                        m3.Text = "1"
                        m4.Text = "1"
                        m5.Text = "1"
                        While (j > -1)
                            m7.Text = str1.Substring(1)
                            j = j - 1
                            m6.Text = str1.Substring(0, 1)
                            j = j - 1
                        End While
                        GoTo minus1
                    ElseIf ss.Text.Length = 1 Then
                        j = 0
                        bits.Text = "2"
                        m1.Text = "1"
                        m2.Text = "1"
                        m3.Text = "1"
                        m4.Text = "1"
                        m5.Text = "1"
                        m6.Text = "1"
                        While (j > -1)
                            m7.Text = str1.Substring(1)
                            j = j - 1
                        End While
                        GoTo minus1
                    ElseIf (ss.Text.Length = 3) Then
                        j = 2
                        bits.Text = "4"
                        m1.Text = "1"
                        m2.Text = "1"
                        m3.Text = "1"
                        m4.Text = "1"
                        While (j > -1)

                            m5.Text = str1.Substring(0, 1)

                            j = j - 1

                            m6.Text = str1.Substring(1, 1)
                            j = j - 1

                            m7.Text = str1.Substring(2)
                            j = j - 1

                        End While
                        GoTo minus1
                    ElseIf (ss.Text.Length = 4) Then
                        j = 3
                        bits.Text = "5"
                        m1.Text = "1"
                        m2.Text = "1"
                        m3.Text = "1"
                        While (j > -1)
                            m4.Text = str1.Substring(0, 1)
                            j = j - 1
                            m5.Text = str1.Substring(1, 1)
                            j = j - 1
                            m6.Text = str1.Substring(2, 1)
                            j = j - 1
                            m7.Text = str1.Substring(3)
                            j = j - 1

                        End While
                        GoTo minus1
                    ElseIf (ss.Text.Length = 5) Then
                        j = 4
                        bits.Text = "6"
                        m1.Text = "1"
                        m2.Text = "1"
                        While (j > -1)
                            m3.Text = str1.Substring(0, 1)
                            j = j - 1
                            m4.Text = str1.Substring(1, 1)
                            j = j - 1
                            m5.Text = str1.Substring(2, 1)
                            j = j - 1
                            m6.Text = str1.Substring(3, 1)
                            j = j - 1
                            m7.Text = str1.Substring(4)
                            j = j - 1

                        End While
                        GoTo minus1
                    ElseIf (ss.Text.Length = 6) Then
                        j = 5
                        bits.Text = "7"
                        m1.Text = "1"
                        While (j > -1)
                            m2.Text = str1.Substring(0, 1)
                            j = j - 1
                            m3.Text = str1.Substring(1, 1)
                            j = j - 1
                            m4.Text = str1.Substring(2, 1)
                            j = j - 1
                            m5.Text = str1.Substring(3, 1)
                            j = j - 1
                            m6.Text = str1.Substring(4, 1)
                            j = j - 1
                            m7.Text = str1.Substring(5)
                            j = j - 1

                        End While
                        GoTo minus1
                    ElseIf (ss.Text.Length > 6) Then
                        op.Text = "PLEASE ENTER VALUE LESS THAN 64"
                        GoTo ender1
                    End If

minus1:             Dim xcnt As Integer = 0
                    If m7.Text = "0" Then
                        m7.Text = "0"
                        xcnt = 0
                    ElseIf m7.Text = "1" Then
                        m7.Text = "1"
                        xcnt = 1
                    End If
                    If xcnt = 1 Then
                        If m6.Text = "0" Then
                            m6.Text = "1"
                            xcnt = 0
                        ElseIf m6.Text = "1" Then
                            m6.Text = "0"
                            xcnt = 1
                        End If
                    ElseIf xcnt = 0 Then
                        If m6.Text = "0" Then
                            m6.Text = "0"
                            xcnt = 0
                        ElseIf m6.Text = "1" Then
                            m6.Text = "1"
                            xcnt = 0
                        End If
                    End If
                    If xcnt = 1 Then
                        If m5.Text = "0" Then
                            m5.Text = "1"
                            xcnt = 0
                        ElseIf m5.Text = "1" Then
                            m5.Text = "0"
                            xcnt = 1
                        End If
                    ElseIf xcnt = 0 Then
                        If m5.Text = "0" Then
                            m5.Text = "0"
                            xcnt = 0
                        ElseIf m5.Text = "1" Then
                            m5.Text = "1"
                            xcnt = 0
                        End If
                    End If
                    If xcnt = 1 Then
                        If m4.Text = "0" Then
                            m4.Text = "1"
                            xcnt = 0
                        ElseIf m4.Text = "1" Then
                            m4.Text = "0"
                            xcnt = 1
                        End If
                    ElseIf xcnt = 0 Then
                        If m4.Text = "0" Then
                            m4.Text = "0"
                            xcnt = 0
                        ElseIf m4.Text = "1" Then
                            m4.Text = "1"
                            xcnt = 0
                        End If
                    End If
                    If xcnt = 1 Then
                        If m3.Text = "0" Then
                            m3.Text = "1"
                            xcnt = 0
                        ElseIf m3.Text = "1" Then
                            m3.Text = "0"
                            xcnt = 1
                        End If
                    ElseIf xcnt = 0 Then
                        If m3.Text = "0" Then
                            m3.Text = "0"
                            xcnt = 0
                        ElseIf m3.Text = "1" Then
                            m3.Text = "1"
                            xcnt = 0
                        End If
                    End If
                    If xcnt = 1 Then
                        If m2.Text = "0" Then
                            m2.Text = "1"
                            xcnt = 0
                        ElseIf m2.Text = "1" Then
                            m2.Text = "0"
                            xcnt = 1
                        End If
                    ElseIf xcnt = 0 Then
                        If m2.Text = "0" Then
                            m2.Text = "0"
                            xcnt = 0
                        ElseIf m2.Text = "1" Then
                            m2.Text = "1"
                            xcnt = 0
                        End If
                    End If
                    If xcnt = 1 Then
                        If m1.Text = "0" Then
                            m1.Text = "1"
                            xcnt = 0
                        ElseIf m1.Text = "1" Then
                            m1.Text = "0"
                            xcnt = 1
                        End If
                    ElseIf xcnt = 0 Then
                        If m1.Text = "0" Then
                            m1.Text = "0"
                            xcnt = 0
                        ElseIf m1.Text = "1" Then
                            m1.Text = "1"
                            xcnt = 0
                        End If
                    End If
                End If


            End If
            Dim f2 As Integer
            Try
                f2 = qm2.Text
            Catch ex As Exception
                op.Text = "Enter a Multiplier (Q)"
                GoTo ender1
            End Try

            Dim ff2 As Integer = f2
            If ff2 > 0 Then
                ff2 = f2
            ElseIf f2 < 0 Then
                ff2 = f2.ToString.Substring(1)
            End If

            If f2 <> 0 Then
                Dim remainder As Integer = 0
                sft1 = Convert.ToString(f2, 2)
                If f2 < 0 Then
                    mf1 = f2.ToString.Substring(1)        ' may error
                    sft1 = Convert.ToString(mf1, 2)
                ElseIf f1 > 0 Then

                    sft1 = Convert.ToString(f2, 2)

                End If
                Dim i As Integer = 1

                Dim str1 As String = sft1
                ss.Text = sft1
                bin2 = sft1
                ss.Text = bin2

                Dim str2 As String = bin2
                Dim j As Integer = 0
                If f2 > 0 Then
                    If (ss.Text.Length = 2) Then
                        j = 1
                        bits.Text = "3"
                        n1.Text = "0"
                        n2.Text = "0"
                        n3.Text = "0"
                        n4.Text = "0"
                        n5.Text = "0"
                        While (j > -1)
                            n7.Text = str2.Substring(1)
                            j = j - 1
                            n6.Text = str2.Substring(0, 1)
                            j = j - 1

                        End While
                    ElseIf ss.Text.Length = 1 Then
                        j = 0
                        bits.Text = "2"
                        n1.Text = "0"
                        n2.Text = "0"
                        n3.Text = "0"
                        n4.Text = "0"
                        n5.Text = "0"
                        n6.Text = "0"
                        While (j > -1)
                            n7.Text = str2.Substring(1)
                            j = j - 1


                        End While
                    ElseIf (ss.Text.Length = 3) Then
                        j = 2
                        bits.Text = "4"
                        n1.Text = "0"
                        n2.Text = "0"
                        n3.Text = "0"
                        n4.Text = "0"
                        While (j > -1)

                            n5.Text = str2.Substring(0, 1)

                            j = j - 1

                            n6.Text = str2.Substring(1, 1)
                            j = j - 1

                            n7.Text = str2.Substring(2)
                            j = j - 1

                        End While
                    ElseIf (ss.Text.Length = 4) Then
                        j = 3
                        bits.Text = "5"
                        n1.Text = "0"
                        n2.Text = "0"
                        n3.Text = "0"
                        While (j > -1)
                            n4.Text = str2.Substring(0, 1)
                            j = j - 1
                            n5.Text = str2.Substring(1, 1)
                            j = j - 1
                            n6.Text = str2.Substring(2, 1)
                            j = j - 1
                            n7.Text = str2.Substring(3)
                            j = j - 1

                        End While
                    ElseIf (ss.Text.Length = 5) Then
                        j = 4
                        bits.Text = "6"
                        n1.Text = "0"
                        n2.Text = "0"
                        While (j > -1)
                            n3.Text = str2.Substring(0, 1)
                            j = j - 1
                            n4.Text = str2.Substring(1, 1)
                            j = j - 1
                            n5.Text = str2.Substring(2, 1)
                            j = j - 1
                            n6.Text = str2.Substring(3, 1)
                            j = j - 1
                            n7.Text = str2.Substring(4)
                            j = j - 1

                        End While
                    ElseIf (ss.Text.Length = 6) Then
                        j = 5
                        bits.Text = "7"
                        n1.Text = "0"
                        While (j > -1)
                            n2.Text = str2.Substring(0, 1)
                            j = j - 1
                            n3.Text = str2.Substring(1, 1)
                            j = j - 1
                            n4.Text = str2.Substring(2, 1)
                            j = j - 1
                            n5.Text = str2.Substring(3, 1)
                            j = j - 1
                            n6.Text = str2.Substring(4, 1)
                            j = j - 1
                            n7.Text = str2.Substring(5)
                            j = j - 1

                        End While

                    ElseIf (ss.Text.Length > 6) Then
                        op.Text = "PLEASE ENTER VALUE LESS THAN 64"

                        GoTo ender1
                    End If
                ElseIf f2 < 0 Then
                    If ss.Text.Length = 2 Then
                        j = 1
                        bits.Text = "3"
                        n1.Text = "1"
                        n2.Text = "1"
                        n3.Text = "1"
                        n4.Text = "1"
                        n5.Text = "1"
                        While (j > -1)
                            n7.Text = str2.Substring(1)
                            j = j - 1
                            n6.Text = str2.Substring(0, 1)
                            j = j - 1
                        End While
                        GoTo minus
                    ElseIf ss.Text.Length = 1 Then
                        j = 0
                        bits.Text = "2"
                        n1.Text = "1"
                        n2.Text = "1"
                        n3.Text = "1"
                        n4.Text = "1"
                        n5.Text = "1"
                        n6.Text = "1"
                        While (j > -1)
                            n7.Text = str2.Substring(1)
                            j = j - 1
                        End While
                        GoTo minus
                    ElseIf (ss.Text.Length = 3) Then
                        j = 2
                        bits.Text = "4"
                        n1.Text = "1"
                        n2.Text = "1"
                        n3.Text = "1"
                        n4.Text = "1"
                        While (j > -1)

                            n5.Text = str2.Substring(0, 1)
                            j = j - 1

                            n6.Text = str2.Substring(1, 1)
                            j = j - 1

                            n7.Text = str2.Substring(2)
                            j = j - 1

                        End While
                        GoTo minus

                    ElseIf (ss.Text.Length = 4) Then
                        j = 3
                        bits.Text = "5"
                        n1.Text = "1"
                        n2.Text = "1"
                        n3.Text = "1"
                        While (j > -1)
                            n4.Text = str2.Substring(0, 1)
                            j = j - 1
                            n5.Text = str2.Substring(1, 1)
                            j = j - 1
                            n6.Text = str2.Substring(2, 1)
                            j = j - 1
                            n7.Text = str2.Substring(3)
                            j = j - 1

                        End While
                        GoTo minus

                    ElseIf (ss.Text.Length = 5) Then
                        j = 4
                        bits.Text = "6"
                        n1.Text = "1"
                        n2.Text = "1"
                        While (j > -1)
                            n3.Text = str2.Substring(0, 1)
                            j = j - 1
                            n4.Text = str2.Substring(1, 1)
                            j = j - 1
                            n5.Text = str2.Substring(2, 1)
                            j = j - 1
                            n6.Text = str2.Substring(3, 1)
                            j = j - 1
                            n7.Text = str2.Substring(4)
                            j = j - 1
                        End While
                        GoTo minus

                    ElseIf (ss.Text.Length = 6) Then
                        j = 5
                        bits.Text = "7"
                        n1.Text = "1"
                        While (j > -1)
                            n2.Text = str2.Substring(0, 1)
                            j = j - 1
                            n3.Text = str2.Substring(1, 1)
                            j = j - 1
                            n4.Text = str2.Substring(2, 1)
                            j = j - 1
                            n5.Text = str2.Substring(3, 1)
                            j = j - 1
                            n6.Text = str2.Substring(4, 1)
                            j = j - 1
                            n7.Text = str2.Substring(5)
                            j = j - 1
                            GoTo minus
                        End While
                    ElseIf (ss.Text.Length > 6) Then
                        op.Text = "PLEASE ENTER VALUE LESS THAN 64"
                        GoTo ender1
                    End If

minus:              Dim xcnt As Integer = 0
                    If n7.Text = "0" Then
                        n7.Text = "0"
                        xcnt = 0
                    ElseIf m7.Text = "1" Then
                        n7.Text = "1"
                        xcnt = 1
                    End If
                    If xcnt = 1 Then
                        If n6.Text = "0" Then
                            n6.Text = "1"
                            xcnt = 0
                        ElseIf n6.Text = "1" Then
                            n6.Text = "0"
                            xcnt = 1
                        End If
                    ElseIf xcnt = 0 Then
                        If n6.Text = "0" Then
                            n6.Text = "0"
                            xcnt = 0
                        ElseIf n6.Text = "1" Then
                            n6.Text = "1"
                            xcnt = 0
                        End If
                    End If
                    If xcnt = 1 Then
                        If n5.Text = "0" Then
                            n5.Text = "1"
                            xcnt = 0
                        ElseIf n5.Text = "1" Then
                            n5.Text = "0"
                            xcnt = 1
                        End If
                    ElseIf xcnt = 0 Then
                        If n5.Text = "0" Then
                            n5.Text = "0"
                            xcnt = 0
                        ElseIf n5.Text = "1" Then
                            n5.Text = "1"
                            xcnt = 0
                        End If
                    End If
                    If xcnt = 1 Then
                        If n4.Text = "0" Then
                            n4.Text = "1"
                            xcnt = 0
                        ElseIf n4.Text = "1" Then
                            n4.Text = "0"
                            xcnt = 1
                        End If
                    ElseIf xcnt = 0 Then
                        If n4.Text = "0" Then
                            n4.Text = "0"
                            xcnt = 0
                        ElseIf n4.Text = "1" Then
                            n4.Text = "1"
                            xcnt = 0
                        End If
                    End If
                    If xcnt = 1 Then
                        If n3.Text = "0" Then
                            n3.Text = "1"
                            xcnt = 0
                        ElseIf n3.Text = "1" Then
                            n3.Text = "0"
                            xcnt = 1
                        End If
                    ElseIf xcnt = 0 Then
                        If n3.Text = "0" Then
                            n3.Text = "0"
                            xcnt = 0
                        ElseIf n3.Text = "1" Then
                            n3.Text = "1"
                            xcnt = 0
                        End If
                    End If
                    If xcnt = 1 Then
                        If n2.Text = "0" Then
                            n2.Text = "1"
                            xcnt = 0
                        ElseIf n2.Text = "1" Then
                            n2.Text = "0"
                            xcnt = 1
                        End If
                    ElseIf xcnt = 0 Then
                        If n2.Text = "0" Then
                            n2.Text = "0"
                            xcnt = 0
                        ElseIf n2.Text = "1" Then
                            n2.Text = "1"
                            xcnt = 0
                        End If
                    End If
                    If xcnt = 1 Then
                        If n1.Text = "0" Then
                            n1.Text = "1"
                            xcnt = 0
                        ElseIf n1.Text = "1" Then
                            n1.Text = "0"
                            xcnt = 1
                        End If
                    ElseIf xcnt = 0 Then
                        If n1.Text = "0" Then
                            n1.Text = "0"
                            xcnt = 0
                        ElseIf n1.Text = "1" Then
                            n1.Text = "1"
                            xcnt = 0
                        End If
                    End If



                End If

            End If


            If ff1 > ff2 Then
                bits.Text = bin.ToString.Length + 1
            ElseIf ff2 > ff1 Then
                bits.Text = bin2.ToString.Length + 1
            Else
                bits.Text = bin.ToString.Length + 1

            End If

            If bits.Text = "6" Then
                m1.Text = ""
                n1.Text = ""
            ElseIf bits.Text = "5" Then
                m1.Text = ""
                n1.Text = ""
                m2.Text = ""
                n2.Text = ""
            ElseIf bits.Text = "4" Then
                m1.Text = ""
                n1.Text = ""
                m2.Text = ""
                n2.Text = ""
                m3.Text = ""
                n3.Text = ""
            ElseIf bits.Text = "3" Then
                m1.Text = ""
                n1.Text = ""
                m2.Text = ""
                n2.Text = ""
                m3.Text = ""
                n3.Text = ""
                m4.Text = ""
                n4.Text = ""
            ElseIf bits.Text = "2" Then
                m1.Text = ""
                n1.Text = ""
                m2.Text = ""
                n2.Text = ""
                m3.Text = ""
                n3.Text = ""
                m4.Text = ""
                n4.Text = ""
                m5.Text = ""
                n5.Text = ""

            End If
        End If






        'end of new code

Bin:    Dim count As Integer = 0
        If m7.Text = "0" Then
            t7.Text = m7.Text
        ElseIf m7.Text = "1" Then
            count = 1
            t7.Text = m7.Text
        End If
        If count = 1 Then
            If m6.Text = "0" Then
                t6.Text = "1"
            ElseIf m6.Text = "1" Then
                t6.Text = "0"
            End If
        ElseIf count = 0 Then
            t6.Text = m6.Text
            If m6.Text = "1" Then
                count = 1
            End If
        End If
        If count = 1 Then
            If m5.Text = "0" Then
                t5.Text = "1"
            ElseIf m5.Text = "1" Then
                t5.Text = "0"
            End If
        ElseIf count = 0 Then
            t5.Text = m5.Text
            If m5.Text = "1" Then
                count = 1
            End If
        End If
        If count = 1 Then
            If m4.Text = "0" Then
                t4.Text = "1"
            ElseIf m4.Text = "1" Then
                t4.Text = "0"
            End If
        ElseIf count = 0 Then
            t4.Text = m4.Text
            If m4.Text = "1" Then
                count = 1
            End If
        End If
        If count = 1 Then
            If m3.Text = "0" Then
                t3.Text = "1"
            ElseIf m3.Text = "1" Then
                t3.Text = "0"
            End If
        ElseIf count = 0 Then
            t3.Text = m3.Text
            If m3.Text = "1" Then
                count = 1
            End If
        End If
        If count = 1 Then
            If m2.Text = "0" Then
                t2.Text = "1"
            ElseIf m2.Text = "1" Then
                t2.Text = "0"
            End If
        ElseIf count = 0 Then
            t2.Text = m2.Text
            If m2.Text = "1" Then
                count = 1
            End If
        End If
        If count = 1 Then
            If m1.Text = "0" Then
                t1.Text = "1"
            ElseIf m1.Text = "1" Then
                t1.Text = "0"
            End If
        ElseIf count = 0 Then
            t1.Text = m1.Text
            If m1.Text = "1" Then
                count = 1
            End If
        End If


        If m1.Text = "" Then
            t1.Text = "-"
        End If
        If m2.Text = "" Then
            t2.Text = "-"
        End If
        If m3.Text = "" Then
            t3.Text = "-"
        End If
        If m4.Text = "" Then
            t4.Text = "-"
        End If
        If m5.Text = "" Then
            t5.Text = "-"
        End If
        If m6.Text = "" Then
            t6.Text = "-"
        End If
        If m7.Text = "" Then
            t7.Text = "-"
        End If
        If bits.Text = "1" Then
            at.Text = "0"
        ElseIf bits.Text = "2" Then
            at.Text = "00"
        ElseIf bits.Text = "3" Then
            at.Text = "000"
        ElseIf bits.Text = "4" Then
            at.Text = "0000"
        ElseIf bits.Text = "5" Then
            at.Text = "00000"
        ElseIf bits.Text = "6" Then
            at.Text = "000000"
        ElseIf bits.Text = "7" Then
            at.Text = "0000000"
        Else
            at.Text = "INVALID"



        End If
        If bits.Text = "7" Then
            op.Text = "A=" + at.Text + " M=" + m1.Text + m2.Text + m3.Text + m4.Text + m5.Text + m6.Text + m7.Text + " Q=" + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + " n=" + bits.Text
            a1.Text = "0"
            a2.Text = "0"
            a3.Text = "0"
            a4.Text = "0"
            a5.Text = "0"
            a6.Text = "0"
            a7.Text = "0"
        ElseIf bits.Text = "6" Then
            op.Text = "A=" + at.Text + " M=" + m2.Text + m3.Text + m4.Text + m5.Text + m6.Text + m7.Text + " Q=" + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + " n=" + bits.Text
            a1.Text = "-"
            a2.Text = "0"
            a3.Text = "0"
            a4.Text = "0"
            a5.Text = "0"
            a6.Text = "0"
            a7.Text = "0"
        ElseIf bits.Text = "5" Then
            op.Text = "A=" + at.Text + " M=" + m3.Text + m4.Text + m5.Text + m6.Text + m7.Text + " Q=" + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + " n=" + bits.Text
            a1.Text = "-"
            a2.Text = "-"
            a3.Text = "0"
            a4.Text = "0"
            a5.Text = "0"
            a6.Text = "0"
            a7.Text = "0"
        ElseIf bits.Text = "4" Then
            op.Text = "A=" + at.Text + " M=" + m4.Text + m5.Text + m6.Text + m7.Text + " Q=" + n4.Text + n5.Text + n6.Text + n7.Text + " n=" + bits.Text
            a1.Text = "-"
            a2.Text = "-"
            a3.Text = "-"
            a4.Text = "0"
            a5.Text = "0"
            a6.Text = "0"
            a7.Text = "0"
        ElseIf bits.Text = "3" Then
            op.Text = "A=" + at.Text + " M=" + m5.Text + m6.Text + m7.Text + " Q=" + n5.Text + n6.Text + n7.Text + " n=" + bits.Text
            a1.Text = "-"
            a2.Text = "-"
            a3.Text = "-"
            a4.Text = "-"
            a5.Text = "0"
            a6.Text = "0"
            a7.Text = "0"
        ElseIf bits.Text = "2" Then
            op.Text = "A=" + at.Text + " M=" + m6.Text + m7.Text + " Q=" + n6.Text + n7.Text + " n=" + bits.Text
            a1.Text = "-"
            a2.Text = "-"
            a3.Text = "-"
            a4.Text = "-"
            a5.Text = "-"
            a6.Text = "0"
            a7.Text = "0"
        ElseIf bits.Text = "1" Then
            op.Text = "A=" + at.Text + " M=" + m7.Text + " Q=" + n7.Text + " n=" + bits.Text
            a1.Text = "-"
            a2.Text = "-"
            a3.Text = "-"
            a4.Text = "-"
            a5.Text = "-"
            a6.Text = "-"
            a7.Text = "0"
        Else
            op.Text = "ENTER A VALID VALUE BETWEEN 1-7 BITS"
        End If

        Dim an1 As String
        Dim an2 As String
        Dim an3 As String
        Dim an4 As String
        Dim an5 As String
        Dim an6 As String
        Dim an7 As String
        an1 = n1.Text
        an2 = n2.Text
        an3 = n3.Text
        an4 = n4.Text
        an5 = n5.Text
        an6 = n6.Text
        an7 = n7.Text

        op.Text = op.Text + Environment.NewLine + "===================================="

        Dim n As Integer = 0
        If bits.Text = "8" Then



        ElseIf bits.Text = "2" Then
            q.Text = "0"
            op.Text = op.Text + Environment.NewLine + "A    Q    Q-1     "
            op.Text = op.Text + Environment.NewLine + a6.Text + a7.Text + "   " + n6.Text + n7.Text + "   " + q.Text + "                                [Initial Value]"
            op.Text = op.Text + Environment.NewLine + "===================================="
            If q.Text = "0" And n7.Text = "1" Then

                a6.Text = t6.Text
                a7.Text = t7.Text
                op.Text = op.Text + Environment.NewLine + a6.Text + a7.Text + "   " + n6.Text + n7.Text + "  " + q.Text + "                                 [A <-- A-M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + " " + "↘" + "↘" + "  " + ""
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a6.Text


                op.Text = op.Text + Environment.NewLine + a6.Text + a7.Text + "   " + n6.Text + n7.Text + "   " + q.Text + "                                [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="


            ElseIf q.Text = "1" And n7.Text = "0" Then

                a6.Text = m6.Text
                a7.Text = m7.Text
                op.Text = op.Text + Environment.NewLine + a6.Text + a7.Text + "   " + n6.Text + n7.Text + "  " + q.Text + "                                 [A <-- A+M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + " " + "↘" + "↘" + "  " + ""
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = a7.Text

                a7.Text = a6.Text
                a6.Text = a6.Text


                op.Text = op.Text + Environment.NewLine + a6.Text + a7.Text + "   " + n6.Text + n7.Text + "   " + q.Text + "                                [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

            ElseIf q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                op.Text = op.Text + Environment.NewLine + a6.Text + a7.Text + "   " + n6.Text + n7.Text + "  " + q.Text
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + " " + "↘" + "↘" + "  " + ""
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = a7.Text

                a7.Text = a6.Text
                a6.Text = a6.Text
                op.Text = op.Text + Environment.NewLine + a6.Text + a7.Text + "   " + n6.Text + n7.Text + "  " + q.Text + "                                [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="


            End If
            Dim gcnt As Integer = 0
            GoTo Actual
ad:         gcnt = 0
            If a7.Text = "0" And m7.Text = "0" Then
                a7.Text = "0"
            ElseIf a7.Text = "1" And m7.Text = "1" Then
                a7.Text = "0"
                gcnt = 1
            ElseIf (a7.Text = "0" And m7.Text = "1") Or (a7.Text = "1" And m7.Text = "0") Then
                a7.Text = "1"
            End If
            If gcnt = 1 Then
                If a6.Text = "0" And m6.Text = "0" Then
                    a6.Text = "1"
                    gcnt = 0
                ElseIf a6.Text = "1" And m6.Text = "1" Then
                    a6.Text = "1"

                ElseIf (a6.Text = "0" And m6.Text = "1") Or (a6.Text = "1" And m6.Text = "0") Then
                    a6.Text = "0"
                End If
                GoTo alpha
            End If


Am:
            If a7.Text = "0" And t7.Text = "0" Then
                a7.Text = "0"
            ElseIf a7.Text = "1" And t7.Text = "1" Then
                a7.Text = "0"
                gcnt = 1
            ElseIf (a7.Text = "0" And t7.Text = "1") Or (a7.Text = "1" And t7.Text = "0") Then
                a7.Text = "1"
            End If
            If gcnt = 1 Then
                If a6.Text = "0" And t6.Text = "0" Then
                    a6.Text = "1"
                    gcnt = 0
                ElseIf a6.Text = "1" And t6.Text = "1" Then
                    a6.Text = "1"

                ElseIf (a6.Text = "0" And t6.Text = "1") Or (a6.Text = "1" And t6.Text = "0") Then
                    a6.Text = "0"
                End If
            End If

            GoTo alpha1


            'iteration 2
Actual:     If q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                op.Text = op.Text + Environment.NewLine + a6.Text + a7.Text + "   " + n6.Text + n7.Text + "  " + q.Text
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + " " + "↘" + "↘" + "  " + ""
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = a7.Text

                a7.Text = a6.Text
                a6.Text = a6.Text
                op.Text = op.Text + Environment.NewLine + a6.Text + a7.Text + "   " + n6.Text + n7.Text + "  " + q.Text + "                                [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

            ElseIf q.Text = "0" And n7.Text = "1" Then
                GoTo Am
alpha1:
                op.Text = op.Text + Environment.NewLine + a6.Text + a7.Text + "   " + n6.Text + n7.Text + "  " + q.Text + "                                 [A <-- A-M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + " " + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a6.Text


                op.Text = op.Text + Environment.NewLine + a6.Text + a7.Text + "   " + n6.Text + n7.Text + "   " + q.Text + "                                [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

            ElseIf q.Text = "1" And n7.Text = "0" Then
                GoTo ad
alpha:
                op.Text = op.Text + Environment.NewLine + a6.Text + a7.Text + "   " + n6.Text + n7.Text + "  " + q.Text + "                                 [A <-- A+M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + " " + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = a7.Text

                a7.Text = a6.Text
                a6.Text = a6.Text


                op.Text = op.Text + Environment.NewLine + a6.Text + a7.Text + "   " + n6.Text + n7.Text + "   " + q.Text + "                                [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="


            End If



            '3bits
        ElseIf bits.Text = "3" Then
            q.Text = "0"
            op.Text = op.Text + Environment.NewLine + "A      Q      Q-1     "
            op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + "    " + n5.Text + n6.Text + n7.Text + "   " + q.Text + "                                [Initial Value]"
            op.Text = op.Text + Environment.NewLine + "===================================="
            If q.Text = "0" And n7.Text = "1" Then
                a5.Text = t5.Text
                a6.Text = t6.Text
                a7.Text = t7.Text
                op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + "   " + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                                 [A <-- A-M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "  " + ""
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a5.Text


                op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + "    " + n5.Text + n6.Text + n7.Text + "   " + q.Text + "                                [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="
            ElseIf q.Text = "1" And n7.Text = "0" Then
                a5.Text = m5.Text
                a6.Text = m6.Text
                a7.Text = m7.Text
                op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + "    " + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                                 [A <-- A+M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "  " + ""
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a5.Text


                op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + "    " + n5.Text + n6.Text + n7.Text + "   " + q.Text + "                                [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

            ElseIf q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + "    " + n5.Text + n6.Text + n7.Text + "  " + q.Text
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "  " + ""
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a5.Text
                op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + "    " + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                                [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="


            End If
            Dim gcnt As Integer = 0
            GoTo Actual1
bd:
            If a7.Text = "0" And m7.Text = "0" Then
                a7.Text = "0"
            ElseIf a7.Text = "1" And m7.Text = "1" Then
                a7.Text = "0"
                gcnt = 1
            ElseIf (a7.Text = "0" And m7.Text = "1") Or (a7.Text = "1" And m7.Text = "0") Then
                a7.Text = "1"
            End If
            If gcnt = 1 Then
                If a6.Text = "0" And m6.Text = "0" Then
                    a6.Text = "1"
                    gcnt = 0
                ElseIf a6.Text = "1" And m6.Text = "1" Then
                    a6.Text = "1"

                ElseIf (a6.Text = "0" And m6.Text = "1") Or (a6.Text = "1" And m6.Text = "0") Then
                    a6.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a6.Text = "0" And m6.Text = "0" Then
                    a6.Text = "0"

                ElseIf a6.Text = "1" And m6.Text = "1" Then
                    a6.Text = "0"
                    gcnt = 1
                ElseIf (a6.Text = "0" And m6.Text = "1") Or (a6.Text = "1" And m6.Text = "0") Then
                    a6.Text = "1"
                End If
                'GoTo bravo
            End If
            If gcnt = 1 Then
                If a5.Text = "0" And m5.Text = "0" Then
                    a5.Text = "1"
                    gcnt = 0
                ElseIf a5.Text = "1" And m5.Text = "1" Then
                    a5.Text = "1"

                ElseIf (a5.Text = "0" And m5.Text = "1") Or (a5.Text = "1" And m5.Text = "0") Then
                    a5.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a5.Text = "0" And m5.Text = "0" Then
                    a5.Text = "0"

                ElseIf a5.Text = "1" And m5.Text = "1" Then
                    a5.Text = "0"
                    gcnt = 1
                ElseIf (a5.Text = "0" And m5.Text = "1") Or (a5.Text = "1" And m5.Text = "0") Then
                    a5.Text = "1"
                End If
                'GoTo bravo
            End If
            GoTo bravo

bm:         gcnt = 0
            If a7.Text = "0" And t7.Text = "0" Then
                a7.Text = "0"
            ElseIf a7.Text = "1" And t7.Text = "1" Then
                a7.Text = "0"
                gcnt = 1
            ElseIf (a7.Text = "0" And t7.Text = "1") Or (a7.Text = "1" And t7.Text = "0") Then
                a7.Text = "1"
            End If
            If gcnt = 1 Then
                If a6.Text = "0" And t6.Text = "0" Then
                    a6.Text = "1"
                    gcnt = 0
                ElseIf a6.Text = "1" And t6.Text = "1" Then
                    a6.Text = "1"
                    gcnt = 1
                ElseIf (a6.Text = "0" And t6.Text = "1") Or (a6.Text = "1" And t6.Text = "0") Then
                    a6.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a6.Text = "0" And t6.Text = "0" Then
                    a6.Text = "0"

                ElseIf a6.Text = "1" And t6.Text = "1" Then
                    a6.Text = "0"
                    gcnt = 1
                ElseIf (a6.Text = "0" And t6.Text = "1") Or (a6.Text = "1" And t6.Text = "0") Then
                    a6.Text = "1"
                End If
            End If

            If gcnt = 1 Then
                If a5.Text = "0" And t5.Text = "0" Then
                    a5.Text = "1"
                    gcnt = 0
                ElseIf a5.Text = "1" And t5.Text = "1" Then
                    a5.Text = "1"

                ElseIf (a5.Text = "0" And t5.Text = "1") Or (a5.Text = "1" And t5.Text = "0") Then
                    a5.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a5.Text = "0" And t5.Text = "0" Then
                    a5.Text = "0"

                ElseIf a5.Text = "1" And t5.Text = "1" Then
                    a5.Text = "0"
                    gcnt = 1
                ElseIf (a5.Text = "0" And t5.Text = "1") Or (a5.Text = "1" And t5.Text = "0") Then
                    a5.Text = "1"
                End If
            End If
            GoTo bravo1
            'iteration 2
Actual1:
            If q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + "    " + n5.Text + n6.Text + n7.Text + "  " + q.Text
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "  " + ""
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a5.Text
                op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + "    " + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                                [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="


            ElseIf q.Text = "0" And n7.Text = "1" Then

                a5.Text = t5.Text
                a6.Text = t6.Text
                a7.Text = t7.Text
                GoTo bm
bravo1:         op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + "    " + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                                 [A <-- A-M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "  " + ""
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a5.Text


                op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + "    " + n5.Text + n6.Text + n7.Text + "   " + q.Text + "                                [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

            ElseIf q.Text = "1" And n7.Text = "0" Then
                GoTo bd
                a5.Text = m5.Text
                a6.Text = m6.Text
                a7.Text = m7.Text
bravo:          op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + "    " + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                                 [A <-- A+M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "  " + ""
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a5.Text


                op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + "    " + n5.Text + n6.Text + n7.Text + "   " + q.Text + "                                [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="
                If (n = 3) Then
                    GoTo ender1
                End If

            End If
            'iteration 3
            If q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + "    " + n5.Text + n6.Text + n7.Text + "  " + q.Text
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "  " + ""
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a5.Text
                op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + "    " + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                                [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="
                If (n = 3) Then
                    GoTo ender1
                End If
                n = 3
            ElseIf q.Text = "0" And n7.Text = "1" Then
                n = 3
                GoTo bm
            ElseIf q.Text = "1" And n7.Text = "0" Then
                n = 3
                GoTo bd

            End If

            '4bits
        ElseIf bits.Text = "4" Then
            q.Text = "0"
            op.Text = op.Text + Environment.NewLine + "A         Q       Q-1     "
            op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + "    " + n4.Text + n5.Text + n6.Text + n7.Text + "   " + q.Text + "                              [Initial Value]"
            op.Text = op.Text + Environment.NewLine + "===================================="
            If q.Text = "0" And n7.Text = "1" Then
                a4.Text = t4.Text
                a5.Text = t5.Text
                a6.Text = t6.Text
                a7.Text = t7.Text
                op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                               [A <-- A-M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a4.Text

                op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + "    " + n4.Text + n5.Text + n6.Text + n7.Text + "   " + q.Text + "                              [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

            ElseIf q.Text = "1" And n7.Text = "0" Then
                a4.Text = t4.Text
                a5.Text = m5.Text
                a6.Text = m6.Text
                a7.Text = m7.Text
                op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + "    " + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                                 [A <-- A+M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a4.Text


                op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + "    " + n4.Text + n5.Text + n6.Text + n7.Text + "   " + q.Text + "                              [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

            ElseIf q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + "    " + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a4.Text


                op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + "    " + n4.Text + n5.Text + n6.Text + n7.Text + "   " + q.Text + "                              [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

            End If
            Dim gcnt As Integer = 0
            GoTo Actual2
cd:
            If a7.Text = "0" And m7.Text = "0" Then
                a7.Text = "0"
            ElseIf a7.Text = "1" And m7.Text = "1" Then
                a7.Text = "0"
                gcnt = 1
            ElseIf (a7.Text = "0" And m7.Text = "1") Or (a7.Text = "1" And m7.Text = "0") Then
                a7.Text = "1"
            End If
            If gcnt = 1 Then
                If a6.Text = "0" And m6.Text = "0" Then
                    a6.Text = "1"
                    gcnt = 0
                ElseIf a6.Text = "1" And m6.Text = "1" Then
                    a6.Text = "1"
                    gcnt = 1
                ElseIf (a6.Text = "0" And m6.Text = "1") Or (a6.Text = "1" And m6.Text = "0") Then
                    a6.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a6.Text = "0" And m6.Text = "0" Then
                    a6.Text = "0"

                ElseIf a6.Text = "1" And m6.Text = "1" Then
                    a6.Text = "0"
                    gcnt = 1
                ElseIf (a6.Text = "0" And m6.Text = "1") Or (a6.Text = "1" And m6.Text = "0") Then
                    a6.Text = "1"
                End If
                'GoTo bravo
            End If
            If gcnt = 1 Then
                If a5.Text = "0" And m5.Text = "0" Then
                    a5.Text = "1"
                    gcnt = 0
                ElseIf a5.Text = "1" And m5.Text = "1" Then
                    a5.Text = "1"
                    gcnt = 1
                ElseIf (a5.Text = "0" And m5.Text = "1") Or (a5.Text = "1" And m5.Text = "0") Then
                    a5.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a5.Text = "0" And m5.Text = "0" Then
                    a5.Text = "0"

                ElseIf a5.Text = "1" And m5.Text = "1" Then
                    a5.Text = "0"
                    gcnt = 1
                ElseIf (a5.Text = "0" And m5.Text = "1") Or (a5.Text = "1" And m5.Text = "0") Then
                    a5.Text = "1"
                End If

            End If
            If gcnt = 1 Then
                If a4.Text = "0" And m4.Text = "0" Then
                    a4.Text = "1"
                    gcnt = 0
                ElseIf a4.Text = "1" And m4.Text = "1" Then
                    a4.Text = "1"
                    gcnt = 1
                ElseIf (a4.Text = "0" And m4.Text = "1") Or (a4.Text = "1" And m4.Text = "0") Then
                    a4.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a4.Text = "0" And m4.Text = "0" Then
                    a4.Text = "0"

                ElseIf a4.Text = "1" And m4.Text = "1" Then
                    a4.Text = "0"
                    gcnt = 1
                ElseIf (a4.Text = "0" And m4.Text = "1") Or (a4.Text = "1" And m4.Text = "0") Then
                    a4.Text = "1"
                End If
                'GoTo charlie
            End If
            GoTo charlie

cm:         gcnt = 0
            If a7.Text = "0" And t7.Text = "0" Then
                a7.Text = "0"
            ElseIf a7.Text = "1" And t7.Text = "1" Then
                a7.Text = "0"
                gcnt = 1
            ElseIf (a7.Text = "0" And t7.Text = "1") Or (a7.Text = "1" And t7.Text = "0") Then
                a7.Text = "1"
            End If
            If gcnt = 1 Then
                If a6.Text = "0" And t6.Text = "0" Then
                    a6.Text = "1"
                    gcnt = 0
                ElseIf a6.Text = "1" And t6.Text = "1" Then
                    a6.Text = "1"
                    gcnt = 1
                ElseIf (a6.Text = "0" And t6.Text = "1") Or (a6.Text = "1" And t6.Text = "0") Then
                    a6.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a6.Text = "0" And t6.Text = "0" Then
                    a6.Text = "0"

                ElseIf a6.Text = "1" And t6.Text = "1" Then
                    a6.Text = "0"
                    gcnt = 1
                ElseIf (a6.Text = "0" And t6.Text = "1") Or (a6.Text = "1" And t6.Text = "0") Then
                    a6.Text = "1"
                End If
            End If

            If gcnt = 1 Then
                If a5.Text = "0" And t5.Text = "0" Then
                    a5.Text = "1"
                    gcnt = 0
                ElseIf a5.Text = "1" And t5.Text = "1" Then
                    a5.Text = "1"
                    gcnt = 1
                ElseIf (a5.Text = "0" And t5.Text = "1") Or (a5.Text = "1" And t5.Text = "0") Then
                    a5.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a5.Text = "0" And t5.Text = "0" Then
                    a5.Text = "0"

                ElseIf a5.Text = "1" And t5.Text = "1" Then
                    a5.Text = "0"
                    gcnt = 1
                ElseIf (a5.Text = "0" And t5.Text = "1") Or (a5.Text = "1" And t5.Text = "0") Then
                    a5.Text = "1"
                End If
            End If
            If gcnt = 1 Then
                If a4.Text = "0" And t4.Text = "0" Then
                    a4.Text = "1"
                    gcnt = 0
                ElseIf a4.Text = "1" And t4.Text = "1" Then
                    a4.Text = "1"
                    gcnt = 1

                ElseIf (a4.Text = "0" And t4.Text = "1") Or (a4.Text = "1" And t4.Text = "0") Then
                    a4.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a4.Text = "0" And t4.Text = "0" Then
                    a4.Text = "0"

                ElseIf a4.Text = "1" And t4.Text = "1" Then
                    a4.Text = "0"
                    gcnt = 1
                ElseIf (a4.Text = "0" And t4.Text = "1") Or (a4.Text = "1" And t4.Text = "0") Then
                    a4.Text = "1"
                End If
            End If
            GoTo charlie1
            'iteration 2
Actual2:
            If q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                n = 2
                op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a4.Text
                op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + "    " + n4.Text + n5.Text + n6.Text + n7.Text + "   " + q.Text + "                              [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="
                'n = 2
                GoTo charlie2
            ElseIf q.Text = "0" And n7.Text = "1" Then
                n = 2
                GoTo cm

                a4.Text = t4.Text
                a5.Text = t5.Text
                a6.Text = t6.Text
                a7.Text = t7.Text
charlie1:       op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                                [A <-- A-M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a4.Text


                op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + "    " + n4.Text + n5.Text + n6.Text + n7.Text + "   " + q.Text + "                              [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="
                'If (n = 5) Then
                'GoTo ender1
                'End If
                'n = 2
                GoTo charlie2
            ElseIf q.Text = "1" And n7.Text = "0" Then
                n = 2
                GoTo cd

                a4.Text = m4.Text
                a5.Text = m5.Text
                a6.Text = m6.Text
                a7.Text = m7.Text
charlie:        op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                               [A <-- A+M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a4.Text

                op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + "    " + n4.Text + n5.Text + n6.Text + n7.Text + "   " + q.Text + "                              [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

                'If (n = 5) Then
                'GoTo ender1
                'end If
                'n = 2
                GoTo charlie2
            End If
            'iteration 3


            'iteration 4
charlie2:   n = n + 1
            If (n = 5) Then
                GoTo ender1
            Else
                If q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                    op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text
                    op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘"
                    q.Text = n7.Text
                    n7.Text = n6.Text
                    n6.Text = n5.Text
                    n5.Text = n4.Text
                    n4.Text = a7.Text
                    a7.Text = a6.Text
                    a6.Text = a5.Text
                    a5.Text = a4.Text
                    a4.Text = a4.Text

                    op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + "    " + n4.Text + n5.Text + n6.Text + n7.Text + "   " + q.Text + "                              [Arithematic Right Shift]"
                    op.Text = op.Text + Environment.NewLine + "===================================="
                    If n < 5 Then
                        GoTo charlie2
                    End If


                ElseIf (q.Text = "0" And n7.Text = "1") Then
                    'n = n + 1
                    GoTo cm
                ElseIf (q.Text = "1" And n7.Text = "0") Then
                    'n = n + 1
                    GoTo cd

                End If
            End If
            '5 bits
        ElseIf bits.Text = "5" Then
            q.Text = "0"
            op.Text = op.Text + Environment.NewLine + "A            Q         Q-1     "
            op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "    " + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "   " + q.Text + "                            [Initial Value]"
            op.Text = op.Text + Environment.NewLine + "===================================="
            If q.Text = "0" And n7.Text = "1" Then
                a3.Text = t3.Text
                a4.Text = t4.Text
                a5.Text = t5.Text
                a6.Text = t6.Text
                a7.Text = t7.Text
                op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                             [A <-- A-M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a3.Text


                op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

            ElseIf q.Text = "1" And n7.Text = "0" Then
                a3.Text = m3.Text
                a4.Text = m4.Text
                a5.Text = m5.Text
                a6.Text = m6.Text
                a7.Text = m7.Text
                op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                             [A <-- A+M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a3.Text


                op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

            ElseIf q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a3.Text


                op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

            End If
            Dim gcnt As Integer = 0
            GoTo Actual3
dd:
            If a7.Text = "0" And m7.Text = "0" Then
                a7.Text = "0"
            ElseIf a7.Text = "1" And m7.Text = "1" Then
                a7.Text = "0"
                gcnt = 1
            ElseIf (a7.Text = "0" And m7.Text = "1") Or (a7.Text = "1" And m7.Text = "0") Then
                a7.Text = "1"
            End If
            If gcnt = 1 Then
                If a6.Text = "0" And m6.Text = "0" Then
                    a6.Text = "1"
                    gcnt = 0
                ElseIf a6.Text = "1" And m6.Text = "1" Then
                    a6.Text = "1"
                    gcnt = 1
                ElseIf (a6.Text = "0" And m6.Text = "1") Or (a6.Text = "1" And m6.Text = "0") Then
                    a6.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a6.Text = "0" And m6.Text = "0" Then
                    a6.Text = "0"

                ElseIf a6.Text = "1" And m6.Text = "1" Then
                    a6.Text = "0"
                    gcnt = 1
                ElseIf (a6.Text = "0" And m6.Text = "1") Or (a6.Text = "1" And m6.Text = "0") Then
                    a6.Text = "1"
                End If
                'GoTo bravo
            End If
            If gcnt = 1 Then
                If a5.Text = "0" And m5.Text = "0" Then
                    a5.Text = "1"
                    gcnt = 0
                ElseIf a5.Text = "1" And m5.Text = "1" Then
                    a5.Text = "1"
                    gcnt = 1
                ElseIf (a5.Text = "0" And m5.Text = "1") Or (a5.Text = "1" And m5.Text = "0") Then
                    a5.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a5.Text = "0" And m5.Text = "0" Then
                    a5.Text = "0"

                ElseIf a5.Text = "1" And m5.Text = "1" Then
                    a5.Text = "0"
                    gcnt = 1
                ElseIf (a5.Text = "0" And m5.Text = "1") Or (a5.Text = "1" And m5.Text = "0") Then
                    a5.Text = "1"
                End If

            End If
            If gcnt = 1 Then
                If a4.Text = "0" And m4.Text = "0" Then
                    a4.Text = "1"
                    gcnt = 0
                ElseIf a4.Text = "1" And m4.Text = "1" Then
                    a4.Text = "1"
                    gcnt = 1
                ElseIf (a4.Text = "0" And m4.Text = "1") Or (a4.Text = "1" And m4.Text = "0") Then
                    a4.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a4.Text = "0" And m4.Text = "0" Then
                    a4.Text = "0"

                ElseIf a4.Text = "1" And m4.Text = "1" Then
                    a4.Text = "0"
                    gcnt = 1
                ElseIf (a4.Text = "0" And m4.Text = "1") Or (a4.Text = "1" And m4.Text = "0") Then
                    a4.Text = "1"
                End If
                'GoTo charlie
            End If
            If gcnt = 1 Then
                If a3.Text = "0" And m3.Text = "0" Then
                    a3.Text = "1"
                    gcnt = 0
                ElseIf a3.Text = "1" And m3.Text = "1" Then
                    a3.Text = "1"
                    gcnt = 1
                ElseIf (a3.Text = "0" And m3.Text = "1") Or (a3.Text = "1" And m3.Text = "0") Then
                    a3.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a3.Text = "0" And m3.Text = "0" Then
                    a3.Text = "0"

                ElseIf a3.Text = "1" And m3.Text = "1" Then
                    a3.Text = "0"
                    gcnt = 1
                ElseIf (a3.Text = "0" And m3.Text = "1") Or (a3.Text = "1" And m3.Text = "0") Then
                    a3.Text = "1"
                End If
                'GoTo charlie
            End If
            GoTo delta

dm:         gcnt = 0
            If a7.Text = "0" And t7.Text = "0" Then
                a7.Text = "0"
            ElseIf a7.Text = "1" And t7.Text = "1" Then
                a7.Text = "0"
                gcnt = 1
            ElseIf (a7.Text = "0" And t7.Text = "1") Or (a7.Text = "1" And t7.Text = "0") Then
                a7.Text = "1"
            End If
            If gcnt = 1 Then
                If a6.Text = "0" And t6.Text = "0" Then
                    a6.Text = "1"
                    gcnt = 0
                ElseIf a6.Text = "1" And t6.Text = "1" Then
                    a6.Text = "1"
                    gcnt = 1
                ElseIf (a6.Text = "0" And t6.Text = "1") Or (a6.Text = "1" And t6.Text = "0") Then
                    a6.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a6.Text = "0" And t6.Text = "0" Then
                    a6.Text = "0"

                ElseIf a6.Text = "1" And t6.Text = "1" Then
                    a6.Text = "0"
                    gcnt = 1
                ElseIf (a6.Text = "0" And t6.Text = "1") Or (a6.Text = "1" And t6.Text = "0") Then
                    a6.Text = "1"
                End If
            End If

            If gcnt = 1 Then
                If a5.Text = "0" And t5.Text = "0" Then
                    a5.Text = "1"
                    gcnt = 0
                ElseIf a5.Text = "1" And t5.Text = "1" Then
                    a5.Text = "1"
                    gcnt = 1
                ElseIf (a5.Text = "0" And t5.Text = "1") Or (a5.Text = "1" And t5.Text = "0") Then
                    a5.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a5.Text = "0" And t5.Text = "0" Then
                    a5.Text = "0"

                ElseIf a5.Text = "1" And t5.Text = "1" Then
                    a5.Text = "0"
                    gcnt = 1
                ElseIf (a5.Text = "0" And t5.Text = "1") Or (a5.Text = "1" And t5.Text = "0") Then
                    a5.Text = "1"
                End If
            End If
            If gcnt = 1 Then
                If a4.Text = "0" And t4.Text = "0" Then
                    a4.Text = "1"
                    gcnt = 0
                ElseIf a4.Text = "1" And t4.Text = "1" Then
                    a4.Text = "1"
                    gcnt = 1

                ElseIf (a4.Text = "0" And t4.Text = "1") Or (a4.Text = "1" And t4.Text = "0") Then
                    a4.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a4.Text = "0" And t4.Text = "0" Then
                    a4.Text = "0"

                ElseIf a4.Text = "1" And t4.Text = "1" Then
                    a4.Text = "0"
                    gcnt = 1
                ElseIf (a4.Text = "0" And t4.Text = "1") Or (a4.Text = "1" And t4.Text = "0") Then
                    a4.Text = "1"
                End If
            End If
            If gcnt = 1 Then
                If a3.Text = "0" And t3.Text = "0" Then
                    a3.Text = "1"
                    gcnt = 0
                ElseIf a3.Text = "1" And t3.Text = "1" Then
                    a3.Text = "1"
                    gcnt = 1

                ElseIf (a3.Text = "0" And t3.Text = "1") Or (a3.Text = "1" And t3.Text = "0") Then
                    a3.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a3.Text = "0" And t3.Text = "0" Then
                    a3.Text = "0"

                ElseIf a3.Text = "1" And t3.Text = "1" Then
                    a3.Text = "0"
                    gcnt = 1
                ElseIf (a3.Text = "0" And t3.Text = "1") Or (a3.Text = "1" And t3.Text = "0") Then
                    a3.Text = "1"
                End If
            End If
            GoTo delta1
            'iteration 2
Actual3:
            If q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                n = 2
                op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a3.Text
                op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="
                'n = 2
                GoTo delta2
            ElseIf q.Text = "0" And n7.Text = "1" Then
                n = 2
                GoTo dm
                a3.Text = a3.Text
                a4.Text = t4.Text
                a5.Text = t5.Text
                a6.Text = t6.Text
                a7.Text = t7.Text
delta1:         op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                             [A <-- A-M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a3.Text


                op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="
                'If (n = 5) Then
                'GoTo ender1
                'End If
                'n = 2
                GoTo delta2
            ElseIf q.Text = "1" And n7.Text = "0" Then
                n = 2
                GoTo dd
                a3.Text = m3.Text
                a4.Text = m4.Text
                a5.Text = m5.Text
                a6.Text = m6.Text
                a7.Text = m7.Text
delta:          op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                             [A <-- A+M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a3.Text

                op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="
                'If (n = 5) Then
                'GoTo ender1
                'end If
                'n = 2
                GoTo delta2
            End If
            'iteration 3


            'iteration 4
delta2:     n = n + 1
            If (n = 6) Then
                GoTo ender1
            Else
                If q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                    op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text
                    op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘"
                    q.Text = n7.Text
                    n7.Text = n6.Text
                    n6.Text = n5.Text
                    n5.Text = n4.Text
                    n4.Text = n3.Text
                    n3.Text = a7.Text
                    a7.Text = a6.Text
                    a6.Text = a5.Text
                    a5.Text = a4.Text
                    a4.Text = a3.Text
                    a3.Text = a3.Text

                    op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                    op.Text = op.Text + Environment.NewLine + "===================================="
                    If n < 6 Then
                        GoTo delta2
                    End If


                ElseIf (q.Text = "0" And n7.Text = "1") Then
                    'n = n + 1
                    GoTo dm
                ElseIf (q.Text = "1" And n7.Text = "0") Then
                    'n = n + 1
                    GoTo dd

                End If
            End If

            '6bits
        ElseIf bits.Text = "6" Then
            q.Text = "0"
            op.Text = op.Text + Environment.NewLine + "A            Q         Q-1     "
            op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "    " + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "   " + q.Text + "                            [Initial Value]"
            op.Text = op.Text + Environment.NewLine + "===================================="
            If q.Text = "0" And n7.Text = "1" Then
                a2.Text = t2.Text
                a3.Text = t3.Text
                a4.Text = t4.Text
                a5.Text = t5.Text
                a6.Text = t6.Text
                a7.Text = t7.Text
                op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                             [A <-- A-M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = n2.Text
                n2.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a2.Text
                a2.Text = a2.Text

                op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

            ElseIf q.Text = "1" And n7.Text = "0" Then
                a2.Text = m2.Text
                a3.Text = m3.Text
                a4.Text = m4.Text
                a5.Text = m5.Text
                a6.Text = m6.Text
                a7.Text = m7.Text
                op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                             [A <-- A+M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = n2.Text
                n2.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a2.Text
                a2.Text = a2.Text

                op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="
                ''
            ElseIf q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = n2.Text
                n2.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a2.Text
                a2.Text = a2.Text


                op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="
                ''
            End If
            Dim gcnt As Integer = 0
            GoTo Actual4
ed:
            If a7.Text = "0" And m7.Text = "0" Then
                a7.Text = "0"
            ElseIf a7.Text = "1" And m7.Text = "1" Then
                a7.Text = "0"
                gcnt = 1
            ElseIf (a7.Text = "0" And m7.Text = "1") Or (a7.Text = "1" And m7.Text = "0") Then
                a7.Text = "1"
            End If
            If gcnt = 1 Then
                If a6.Text = "0" And m6.Text = "0" Then
                    a6.Text = "1"
                    gcnt = 0
                ElseIf a6.Text = "1" And m6.Text = "1" Then
                    a6.Text = "1"
                    gcnt = 1
                ElseIf (a6.Text = "0" And m6.Text = "1") Or (a6.Text = "1" And m6.Text = "0") Then
                    a6.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a6.Text = "0" And m6.Text = "0" Then
                    a6.Text = "0"

                ElseIf a6.Text = "1" And m6.Text = "1" Then
                    a6.Text = "0"
                    gcnt = 1
                ElseIf (a6.Text = "0" And m6.Text = "1") Or (a6.Text = "1" And m6.Text = "0") Then
                    a6.Text = "1"
                End If

            End If
            If gcnt = 1 Then
                If a5.Text = "0" And m5.Text = "0" Then
                    a5.Text = "1"
                    gcnt = 0
                ElseIf a5.Text = "1" And m5.Text = "1" Then
                    a5.Text = "1"
                    gcnt = 1
                ElseIf (a5.Text = "0" And m5.Text = "1") Or (a5.Text = "1" And m5.Text = "0") Then
                    a5.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a5.Text = "0" And m5.Text = "0" Then
                    a5.Text = "0"

                ElseIf a5.Text = "1" And m5.Text = "1" Then
                    a5.Text = "0"
                    gcnt = 1
                ElseIf (a5.Text = "0" And m5.Text = "1") Or (a5.Text = "1" And m5.Text = "0") Then
                    a5.Text = "1"
                End If

            End If
            If gcnt = 1 Then
                If a4.Text = "0" And m4.Text = "0" Then
                    a4.Text = "1"
                    gcnt = 0
                ElseIf a4.Text = "1" And m4.Text = "1" Then
                    a4.Text = "1"
                    gcnt = 1
                ElseIf (a4.Text = "0" And m4.Text = "1") Or (a4.Text = "1" And m4.Text = "0") Then
                    a4.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a4.Text = "0" And m4.Text = "0" Then
                    a4.Text = "0"

                ElseIf a4.Text = "1" And m4.Text = "1" Then
                    a4.Text = "0"
                    gcnt = 1
                ElseIf (a4.Text = "0" And m4.Text = "1") Or (a4.Text = "1" And m4.Text = "0") Then
                    a4.Text = "1"
                End If

            End If
            If gcnt = 1 Then
                If a3.Text = "0" And m3.Text = "0" Then
                    a3.Text = "1"
                    gcnt = 0
                ElseIf a3.Text = "1" And m3.Text = "1" Then
                    a3.Text = "1"
                    gcnt = 1
                ElseIf (a3.Text = "0" And m3.Text = "1") Or (a3.Text = "1" And m3.Text = "0") Then
                    a3.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a3.Text = "0" And m3.Text = "0" Then
                    a3.Text = "0"

                ElseIf a3.Text = "1" And m3.Text = "1" Then
                    a3.Text = "0"
                    gcnt = 1
                ElseIf (a3.Text = "0" And m3.Text = "1") Or (a3.Text = "1" And m3.Text = "0") Then
                    a3.Text = "1"
                End If

            End If
            If gcnt = 1 Then
                If a2.Text = "0" And m2.Text = "0" Then
                    a2.Text = "1"
                    gcnt = 0
                ElseIf a2.Text = "1" And m2.Text = "1" Then
                    a2.Text = "1"
                    gcnt = 1
                ElseIf (a2.Text = "0" And m2.Text = "1") Or (a2.Text = "1" And m2.Text = "0") Then
                    a2.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a2.Text = "0" And m2.Text = "0" Then
                    a2.Text = "0"

                ElseIf a2.Text = "1" And m2.Text = "1" Then
                    a2.Text = "0"
                    gcnt = 1
                ElseIf (a2.Text = "0" And m2.Text = "1") Or (a2.Text = "1" And m2.Text = "0") Then
                    a2.Text = "1"
                End If

            End If
            GoTo echo

em:         gcnt = 0
            If a7.Text = "0" And t7.Text = "0" Then
                a7.Text = "0"
            ElseIf a7.Text = "1" And t7.Text = "1" Then
                a7.Text = "0"
                gcnt = 1
            ElseIf (a7.Text = "0" And t7.Text = "1") Or (a7.Text = "1" And t7.Text = "0") Then
                a7.Text = "1"
            End If
            If gcnt = 1 Then
                If a6.Text = "0" And t6.Text = "0" Then
                    a6.Text = "1"
                    gcnt = 0
                ElseIf a6.Text = "1" And t6.Text = "1" Then
                    a6.Text = "1"
                    gcnt = 1
                ElseIf (a6.Text = "0" And t6.Text = "1") Or (a6.Text = "1" And t6.Text = "0") Then
                    a6.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a6.Text = "0" And t6.Text = "0" Then
                    a6.Text = "0"

                ElseIf a6.Text = "1" And t6.Text = "1" Then
                    a6.Text = "0"
                    gcnt = 1
                ElseIf (a6.Text = "0" And t6.Text = "1") Or (a6.Text = "1" And t6.Text = "0") Then
                    a6.Text = "1"
                End If
            End If

            If gcnt = 1 Then
                If a5.Text = "0" And t5.Text = "0" Then
                    a5.Text = "1"
                    gcnt = 0
                ElseIf a5.Text = "1" And t5.Text = "1" Then
                    a5.Text = "1"
                    gcnt = 1
                ElseIf (a5.Text = "0" And t5.Text = "1") Or (a5.Text = "1" And t5.Text = "0") Then
                    a5.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a5.Text = "0" And t5.Text = "0" Then
                    a5.Text = "0"

                ElseIf a5.Text = "1" And t5.Text = "1" Then
                    a5.Text = "0"
                    gcnt = 1
                ElseIf (a5.Text = "0" And t5.Text = "1") Or (a5.Text = "1" And t5.Text = "0") Then
                    a5.Text = "1"
                End If
            End If
            If gcnt = 1 Then
                If a4.Text = "0" And t4.Text = "0" Then
                    a4.Text = "1"
                    gcnt = 0
                ElseIf a4.Text = "1" And t4.Text = "1" Then
                    a4.Text = "1"
                    gcnt = 1

                ElseIf (a4.Text = "0" And t4.Text = "1") Or (a4.Text = "1" And t4.Text = "0") Then
                    a4.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a4.Text = "0" And t4.Text = "0" Then
                    a4.Text = "0"

                ElseIf a4.Text = "1" And t4.Text = "1" Then
                    a4.Text = "0"
                    gcnt = 1
                ElseIf (a4.Text = "0" And t4.Text = "1") Or (a4.Text = "1" And t4.Text = "0") Then
                    a4.Text = "1"
                End If
            End If
            If gcnt = 1 Then
                If a3.Text = "0" And t3.Text = "0" Then
                    a3.Text = "1"
                    gcnt = 0
                ElseIf a3.Text = "1" And t3.Text = "1" Then
                    a3.Text = "1"
                    gcnt = 1

                ElseIf (a3.Text = "0" And t3.Text = "1") Or (a3.Text = "1" And t3.Text = "0") Then
                    a3.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a3.Text = "0" And t3.Text = "0" Then
                    a3.Text = "0"

                ElseIf a3.Text = "1" And t3.Text = "1" Then
                    a3.Text = "0"
                    gcnt = 1
                ElseIf (a3.Text = "0" And t3.Text = "1") Or (a3.Text = "1" And t3.Text = "0") Then
                    a3.Text = "1"
                End If
            End If
            If gcnt = 1 Then
                If a2.Text = "0" And t2.Text = "0" Then
                    a2.Text = "1"
                    gcnt = 0
                ElseIf a2.Text = "1" And t2.Text = "1" Then
                    a2.Text = "1"
                    gcnt = 1

                ElseIf (a2.Text = "0" And t2.Text = "1") Or (a2.Text = "1" And t2.Text = "0") Then
                    a2.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a2.Text = "0" And t2.Text = "0" Then
                    a2.Text = "0"

                ElseIf a2.Text = "1" And t2.Text = "1" Then
                    a2.Text = "0"
                    gcnt = 1
                ElseIf (a2.Text = "0" And t2.Text = "1") Or (a2.Text = "1" And t2.Text = "0") Then
                    a2.Text = "1"
                End If
            End If
            GoTo echo1
            'iteration 2
Actual4:
            If q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                n = 2
                op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = n2.Text
                n2.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a2.Text
                a2.Text = a2.Text


                op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="
                'n = 2
                GoTo echo2
            ElseIf q.Text = "0" And n7.Text = "1" Then
                n = 2
                GoTo em
                a2.Text = t2.Text
                a3.Text = t3.Text
                a4.Text = t4.Text
                a5.Text = t5.Text
                a6.Text = t6.Text
                a7.Text = t7.Text
echo1:          op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                             [A <-- A-M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = n2.Text
                n2.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a2.Text
                a2.Text = a2.Text


                op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="
                'If (n = 5) Then
                'GoTo ender1
                'End If
                'n = 2
                GoTo echo2
            ElseIf q.Text = "1" And n7.Text = "0" Then
                n = 2
                GoTo ed
                a2.Text = m2.Text
                a3.Text = m3.Text
                a4.Text = m4.Text
                a5.Text = m5.Text
                a6.Text = m6.Text
                a7.Text = m7.Text
echo:           op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                             [A <-- A-M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = n2.Text
                n2.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a2.Text
                a2.Text = a2.Text
                op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

                GoTo echo2
            End If
            'iteration 3


            'iteration 4
echo2:      n = n + 1
            If (n = 7) Then
                GoTo ender1
            Else
                If q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                    op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                             "
                    op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘" + "↘"
                    q.Text = n7.Text
                    n7.Text = n6.Text
                    n6.Text = n5.Text
                    n5.Text = n4.Text
                    n4.Text = n3.Text
                    n3.Text = n2.Text
                    n2.Text = a7.Text
                    a7.Text = a6.Text
                    a6.Text = a5.Text
                    a5.Text = a4.Text
                    a4.Text = a3.Text
                    a3.Text = a2.Text
                    a2.Text = a2.Text
                    op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                    op.Text = op.Text + Environment.NewLine + "===================================="
                    If n < 7 Then
                        GoTo echo2
                    End If




                ElseIf (q.Text = "0" And n7.Text = "1") Then
                    'n = n + 1
                    GoTo em
                ElseIf (q.Text = "1" And n7.Text = "0") Then
                    'n = n + 1
                    GoTo ed

                End If
            End If

            '7bits
        ElseIf bits.Text = "7" Then
            q.Text = "0"
            op.Text = op.Text + Environment.NewLine + "A                  Q           Q-1     "
            op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "    " + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "   " + q.Text + "                            [Initial Value]"
            op.Text = op.Text + Environment.NewLine + "===================================="
            If q.Text = "0" And n7.Text = "1" Then
                a1.Text = t1.Text
                a2.Text = t2.Text
                a3.Text = t3.Text
                a4.Text = t4.Text
                a5.Text = t5.Text
                a6.Text = t6.Text
                a7.Text = t7.Text
                op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                             [A <-- A-M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = n2.Text
                n2.Text = n1.Text
                n1.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a2.Text
                a2.Text = a1.Text
                a1.Text = a1.Text

                op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

            ElseIf q.Text = "1" And n7.Text = "0" Then
                a1.Text = m1.Text
                a2.Text = m2.Text
                a3.Text = m3.Text
                a4.Text = m4.Text
                a5.Text = m5.Text
                a6.Text = m6.Text
                a7.Text = m7.Text
                op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                             [A <-- A+M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘" + "↘"
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = n2.Text
                n2.Text = n1.Text
                n1.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a2.Text
                a2.Text = a1.Text
                a1.Text = a1.Text
                op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

            ElseIf q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = n2.Text
                n2.Text = n1.Text
                n1.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a2.Text
                a2.Text = a1.Text
                a1.Text = a1.Text

                op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

            End If
            Dim gcnt As Integer = 0
            GoTo Actual5
fd:
            If a7.Text = "0" And m7.Text = "0" Then
                a7.Text = "0"
            ElseIf a7.Text = "1" And m7.Text = "1" Then
                a7.Text = "0"
                gcnt = 1
            ElseIf (a7.Text = "0" And m7.Text = "1") Or (a7.Text = "1" And m7.Text = "0") Then
                a7.Text = "1"
            End If
            If gcnt = 1 Then
                If a6.Text = "0" And m6.Text = "0" Then
                    a6.Text = "1"
                    gcnt = 0
                ElseIf a6.Text = "1" And m6.Text = "1" Then
                    a6.Text = "1"
                    gcnt = 1
                ElseIf (a6.Text = "0" And m6.Text = "1") Or (a6.Text = "1" And m6.Text = "0") Then
                    a6.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a6.Text = "0" And m6.Text = "0" Then
                    a6.Text = "0"

                ElseIf a6.Text = "1" And m6.Text = "1" Then
                    a6.Text = "0"
                    gcnt = 1
                ElseIf (a6.Text = "0" And m6.Text = "1") Or (a6.Text = "1" And m6.Text = "0") Then
                    a6.Text = "1"
                End If

            End If
            If gcnt = 1 Then
                If a5.Text = "0" And m5.Text = "0" Then
                    a5.Text = "1"
                    gcnt = 0
                ElseIf a5.Text = "1" And m5.Text = "1" Then
                    a5.Text = "1"
                    gcnt = 1
                ElseIf (a5.Text = "0" And m5.Text = "1") Or (a5.Text = "1" And m5.Text = "0") Then
                    a5.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a5.Text = "0" And m5.Text = "0" Then
                    a5.Text = "0"

                ElseIf a5.Text = "1" And m5.Text = "1" Then
                    a5.Text = "0"
                    gcnt = 1
                ElseIf (a5.Text = "0" And m5.Text = "1") Or (a5.Text = "1" And m5.Text = "0") Then
                    a5.Text = "1"
                End If

            End If
            If gcnt = 1 Then
                If a4.Text = "0" And m4.Text = "0" Then
                    a4.Text = "1"
                    gcnt = 0
                ElseIf a4.Text = "1" And m4.Text = "1" Then
                    a4.Text = "1"
                    gcnt = 1
                ElseIf (a4.Text = "0" And m4.Text = "1") Or (a4.Text = "1" And m4.Text = "0") Then
                    a4.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a4.Text = "0" And m4.Text = "0" Then
                    a4.Text = "0"

                ElseIf a4.Text = "1" And m4.Text = "1" Then
                    a4.Text = "0"
                    gcnt = 1
                ElseIf (a4.Text = "0" And m4.Text = "1") Or (a4.Text = "1" And m4.Text = "0") Then
                    a4.Text = "1"
                End If

            End If
            If gcnt = 1 Then
                If a3.Text = "0" And m3.Text = "0" Then
                    a3.Text = "1"
                    gcnt = 0
                ElseIf a3.Text = "1" And m3.Text = "1" Then
                    a3.Text = "1"
                    gcnt = 1
                ElseIf (a3.Text = "0" And m3.Text = "1") Or (a3.Text = "1" And m3.Text = "0") Then
                    a3.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a3.Text = "0" And m3.Text = "0" Then
                    a3.Text = "0"

                ElseIf a3.Text = "1" And m3.Text = "1" Then
                    a3.Text = "0"
                    gcnt = 1
                ElseIf (a3.Text = "0" And m3.Text = "1") Or (a3.Text = "1" And m3.Text = "0") Then
                    a3.Text = "1"
                End If

            End If
            If gcnt = 1 Then
                If a2.Text = "0" And m2.Text = "0" Then
                    a2.Text = "1"
                    gcnt = 0
                ElseIf a2.Text = "1" And m2.Text = "1" Then
                    a2.Text = "1"
                    gcnt = 1
                ElseIf (a2.Text = "0" And m2.Text = "1") Or (a2.Text = "1" And m2.Text = "0") Then
                    a2.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a2.Text = "0" And m2.Text = "0" Then
                    a2.Text = "0"

                ElseIf a2.Text = "1" And m2.Text = "1" Then
                    a2.Text = "0"
                    gcnt = 1
                ElseIf (a2.Text = "0" And m2.Text = "1") Or (a2.Text = "1" And m2.Text = "0") Then
                    a2.Text = "1"
                End If

            End If
            If gcnt = 1 Then
                If a1.Text = "0" And m1.Text = "0" Then
                    a1.Text = "1"
                    gcnt = 0
                ElseIf a1.Text = "1" And m1.Text = "1" Then
                    a1.Text = "1"
                    gcnt = 1
                ElseIf (a1.Text = "0" And m1.Text = "1") Or (a1.Text = "1" And m1.Text = "0") Then
                    a1.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a1.Text = "0" And m1.Text = "0" Then
                    a1.Text = "0"

                ElseIf a1.Text = "1" And m1.Text = "1" Then
                    a1.Text = "0"
                    gcnt = 1
                ElseIf (a1.Text = "0" And m1.Text = "1") Or (a1.Text = "1" And m1.Text = "0") Then
                    a1.Text = "1"
                End If

            End If
            GoTo foxtrot

fm:         gcnt = 0
            If a7.Text = "0" And t7.Text = "0" Then
                a7.Text = "0"
            ElseIf a7.Text = "1" And t7.Text = "1" Then
                a7.Text = "0"
                gcnt = 1
            ElseIf (a7.Text = "0" And t7.Text = "1") Or (a7.Text = "1" And t7.Text = "0") Then
                a7.Text = "1"
            End If
            If gcnt = 1 Then
                If a6.Text = "0" And t6.Text = "0" Then
                    a6.Text = "1"
                    gcnt = 0
                ElseIf a6.Text = "1" And t6.Text = "1" Then
                    a6.Text = "1"
                    gcnt = 1
                ElseIf (a6.Text = "0" And t6.Text = "1") Or (a6.Text = "1" And t6.Text = "0") Then
                    a6.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a6.Text = "0" And t6.Text = "0" Then
                    a6.Text = "0"

                ElseIf a6.Text = "1" And t6.Text = "1" Then
                    a6.Text = "0"
                    gcnt = 1
                ElseIf (a6.Text = "0" And t6.Text = "1") Or (a6.Text = "1" And t6.Text = "0") Then
                    a6.Text = "1"
                End If
            End If

            If gcnt = 1 Then
                If a5.Text = "0" And t5.Text = "0" Then
                    a5.Text = "1"
                    gcnt = 0
                ElseIf a5.Text = "1" And t5.Text = "1" Then
                    a5.Text = "1"
                    gcnt = 1
                ElseIf (a5.Text = "0" And t5.Text = "1") Or (a5.Text = "1" And t5.Text = "0") Then
                    a5.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a5.Text = "0" And t5.Text = "0" Then
                    a5.Text = "0"

                ElseIf a5.Text = "1" And t5.Text = "1" Then
                    a5.Text = "0"
                    gcnt = 1
                ElseIf (a5.Text = "0" And t5.Text = "1") Or (a5.Text = "1" And t5.Text = "0") Then
                    a5.Text = "1"
                End If
            End If
            If gcnt = 1 Then
                If a4.Text = "0" And t4.Text = "0" Then
                    a4.Text = "1"
                    gcnt = 0
                ElseIf a4.Text = "1" And t4.Text = "1" Then
                    a4.Text = "1"
                    gcnt = 1

                ElseIf (a4.Text = "0" And t4.Text = "1") Or (a4.Text = "1" And t4.Text = "0") Then
                    a4.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a4.Text = "0" And t4.Text = "0" Then
                    a4.Text = "0"

                ElseIf a4.Text = "1" And t4.Text = "1" Then
                    a4.Text = "0"
                    gcnt = 1
                ElseIf (a4.Text = "0" And t4.Text = "1") Or (a4.Text = "1" And t4.Text = "0") Then
                    a4.Text = "1"
                End If
            End If
            If gcnt = 1 Then
                If a3.Text = "0" And t3.Text = "0" Then
                    a3.Text = "1"
                    gcnt = 0
                ElseIf a3.Text = "1" And t3.Text = "1" Then
                    a3.Text = "1"
                    gcnt = 1

                ElseIf (a3.Text = "0" And t3.Text = "1") Or (a3.Text = "1" And t3.Text = "0") Then
                    a3.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a3.Text = "0" And t3.Text = "0" Then
                    a3.Text = "0"

                ElseIf a3.Text = "1" And t3.Text = "1" Then
                    a3.Text = "0"
                    gcnt = 1
                ElseIf (a3.Text = "0" And t3.Text = "1") Or (a3.Text = "1" And t3.Text = "0") Then
                    a3.Text = "1"
                End If
            End If
            If gcnt = 1 Then
                If a2.Text = "0" And t2.Text = "0" Then
                    a2.Text = "1"
                    gcnt = 0
                ElseIf a2.Text = "1" And t2.Text = "1" Then
                    a2.Text = "1"
                    gcnt = 1

                ElseIf (a2.Text = "0" And t2.Text = "1") Or (a2.Text = "1" And t2.Text = "0") Then
                    a2.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a2.Text = "0" And t2.Text = "0" Then
                    a2.Text = "0"

                ElseIf a2.Text = "1" And t2.Text = "1" Then
                    a2.Text = "0"
                    gcnt = 1
                ElseIf (a2.Text = "0" And t2.Text = "1") Or (a2.Text = "1" And t2.Text = "0") Then
                    a2.Text = "1"
                End If
            End If
            If gcnt = 1 Then
                If a1.Text = "0" And t1.Text = "0" Then
                    a1.Text = "1"
                    gcnt = 0
                ElseIf a1.Text = "1" And t1.Text = "1" Then
                    a1.Text = "1"
                    gcnt = 1

                ElseIf (a1.Text = "0" And t1.Text = "1") Or (a1.Text = "1" And t1.Text = "0") Then
                    a1.Text = "0"
                End If
            ElseIf gcnt = 0 Then
                If a1.Text = "0" And t1.Text = "0" Then
                    a1.Text = "0"

                ElseIf a1.Text = "1" And t1.Text = "1" Then
                    a1.Text = "0"
                    gcnt = 1
                ElseIf (a1.Text = "0" And t1.Text = "1") Or (a1.Text = "1" And t1.Text = "0") Then
                    a1.Text = "1"
                End If
            End If
            GoTo foxtrot1
            'iteration 2
Actual5:
            If q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                n = 2
                op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = n2.Text
                n2.Text = n1.Text
                n1.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a2.Text
                a2.Text = a1.Text
                a1.Text = a1.Text

                op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="
                GoTo foxtrot2
            ElseIf q.Text = "0" And n7.Text = "1" Then
                n = 2
                GoTo fm
                a1.Text = t1.Text
                a2.Text = t2.Text
                a3.Text = t3.Text
                a4.Text = t4.Text
                a5.Text = t5.Text
                a6.Text = t6.Text
                a7.Text = t7.Text
foxtrot1:       op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                             [A <-- A-M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = n2.Text
                n2.Text = n1.Text
                n1.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a2.Text
                a2.Text = a1.Text
                a1.Text = a1.Text

                op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="
                'If (n = 5) Then
                'GoTo ender1
                'End If
                'n = 2
                GoTo foxtrot2
            ElseIf q.Text = "1" And n7.Text = "0" Then
                n = 2
                GoTo fd
                a2.Text = m2.Text
                a3.Text = m3.Text
                a4.Text = m4.Text
                a5.Text = m5.Text
                a6.Text = m6.Text
                a7.Text = m7.Text
foxtrot:        op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                             [A <-- A-M]"
                op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘" + "↘"
                q.Text = n7.Text
                n7.Text = n6.Text
                n6.Text = n5.Text
                n5.Text = n4.Text
                n4.Text = n3.Text
                n3.Text = n2.Text
                n2.Text = n1.Text
                n1.Text = a7.Text
                a7.Text = a6.Text
                a6.Text = a5.Text
                a5.Text = a4.Text
                a4.Text = a3.Text
                a3.Text = a2.Text
                a2.Text = a1.Text
                a1.Text = a1.Text
                op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                op.Text = op.Text + Environment.NewLine + "===================================="

                GoTo foxtrot2
            End If
            'iteration 3


            'iteration 4
foxtrot2:   n = n + 1
            If (n = 8) Then
                GoTo ender1
            Else
                If q.Text = "0" And n7.Text = "0" Or q.Text = "1" And n7.Text = "1" Then
                    op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                             "
                    op.Text = op.Text + Environment.NewLine + "↓↘" + "↘" + "↘" + "↘" + "↘" + "↘" + "↘" + " " + "↘" + "↘" + "↘" + "↘" + "↘"
                    q.Text = n7.Text
                    n7.Text = n6.Text
                    n6.Text = n5.Text
                    n5.Text = n4.Text
                    n4.Text = n3.Text
                    n3.Text = n2.Text
                    n2.Text = n1.Text
                    n1.Text = a7.Text
                    a7.Text = a6.Text
                    a6.Text = a5.Text
                    a5.Text = a4.Text
                    a4.Text = a3.Text
                    a3.Text = a2.Text
                    a2.Text = a1.Text
                    a1.Text = a1.Text
                    op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + "   " + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "  " + q.Text + "                            [Arithematic Right Shift]"
                    op.Text = op.Text + Environment.NewLine + "===================================="
                    If n < 8 Then
                        GoTo foxtrot2
                    End If




                ElseIf (q.Text = "0" And n7.Text = "1") Then
                    'n = n + 1
                    GoTo fm
                ElseIf (q.Text = "1" And n7.Text = "0") Then
                    'n = n + 1
                    GoTo fd

                End If
            End If








ender1:
            Dim sftr1 As String
            Dim sftr2 As String
            Dim z1 As String
            If cb1.SelectedIndex = 0 Then
                If bits.Text = 3 Then

                    z1 = n7.Text + ((n6.Text * (2)) + (n5.Text * (2 ^ 2)) + (a7.Text * (2 ^ 3)) + (a6.Text * (2 ^ 4)))
                ElseIf bits.Text = 4 Then
                    z1 = n7.Text + ((n6.Text * (2)) + (n5.Text * (2 ^ 2)) + (n4.Text * (2 ^ 3)) + (a7.Text * (2 ^ 4)) + (a6.Text * (2 ^ 5)) + (a5.Text * (2 ^ 6)))
                ElseIf bits.Text = 5 Then
                    z1 = n7.Text + ((n6.Text * (2)) + (n5.Text * (2 ^ 2)) + (n4.Text * (2 ^ 3)) + (n3.Text * (2 ^ 4)) + (a7.Text * (2 ^ 5)) + (a6.Text * (2 ^ 6)) + (a5.Text * (2 ^ 7)) + (a4.Text * (2 ^ 8)))
                ElseIf bits.Text = 6 Then
                    z1 = n7.Text + ((n6.Text * (2)) + (n5.Text * (2 ^ 2)) + (n4.Text * (2 ^ 3)) + (n3.Text * (2 ^ 4)) + (n2.Text * (2 ^ 5)) + (a7.Text * (2 ^ 6)) + (a6.Text * (2 ^ 7)) + (a5.Text * (2 ^ 8)) + (a4.Text * (2 ^ 9)) + (a3.Text * (2 ^ 10)))
                ElseIf bits.Text = 7 Then
                    z1 = n7.Text + ((n6.Text * (2)) + (n5.Text * (2 ^ 2)) + (n4.Text * (2 ^ 3)) + (n3.Text * (2 ^ 4)) + (n2.Text * (2 ^ 5)) + (n1.Text * (2 ^ 6)) + (a7.Text * (2 ^ 7)) + (a6.Text * (2 ^ 8)) + (a5.Text * (2 ^ 9)) + (a4.Text * (2 ^ 10)) + (a3.Text * (2 ^ 11)) + (a2.Text * (2 ^ 12)))





                End If

            End If
            If cb1.SelectedIndex = 1 Then
                If bits.Text = "7" Then
                    op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + " = " & mm2.Text * qm2.Text
                ElseIf bits.Text = "6" Then
                    op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + " = " & mm2.Text * qm2.Text
                ElseIf bits.Text = "5" Then
                    op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + " = " & mm2.Text * qm2.Text
                ElseIf bits.Text = "4" Then
                    op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + n4.Text + n5.Text + n6.Text + n7.Text + " = " & mm2.Text * qm2.Text
                ElseIf bits.Text = "3" Then
                    op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + n5.Text + n6.Text + n7.Text + " = " & mm2.Text * qm2.Text
                ElseIf bits.Text = "2" Then
                    op.Text = op.Text + Environment.NewLine + a6.Text + a7.Text + n6.Text + n7.Text + " = " & mm2.Text * qm2.Text

                End If
            ElseIf cb1.SelectedIndex = 0 Then
                If bits.Text = "7" Then
                    op.Text = op.Text + Environment.NewLine + a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + n1.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "=" + z1
                ElseIf bits.Text = "6" Then
                    op.Text = op.Text + Environment.NewLine + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + n2.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "=" + z1
                ElseIf bits.Text = "5" Then
                    op.Text = op.Text + Environment.NewLine + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + n3.Text + n4.Text + n5.Text + n6.Text + n7.Text + "=" + z1
                ElseIf bits.Text = "4" Then
                    op.Text = op.Text + Environment.NewLine + a4.Text + a5.Text + a6.Text + a7.Text + n4.Text + n5.Text + n6.Text + n7.Text + "=" + z1
                ElseIf bits.Text = "3" Then
                    op.Text = op.Text + Environment.NewLine + a5.Text + a6.Text + a7.Text + n5.Text + n6.Text + n7.Text + "=" + z1
                ElseIf bits.Text = "2" Then
                    op.Text = op.Text + Environment.NewLine + a6.Text + a7.Text + n6.Text + n7.Text

                End If
            End If


            op.Text = op.Text + Environment.NewLine
            op.Text = op.Text + Environment.NewLine
            op.Text = op.Text + Environment.NewLine
            op.Text = op.Text + Environment.NewLine
            op.Text = op.Text + Environment.NewLine
            n1.Text = an1
            n2.Text = an2
            n3.Text = an3
            n4.Text = an4
            n5.Text = an5
            n6.Text = an6
            n7.Text = an7


        End If
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        op.Text = "Made by Varun Vinod,Sanket Garad and Nikhil Tiwari"
        op.Text = op.Text + Environment.NewLine + "Made with Visual Studio 2017,❤,VBScript"


    End Sub

    Private Sub Cb1_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles cb1.SelectionChanged
        If cb1.SelectedIndex = 1 Then

            mm2.IsEnabled = True
            qm2.IsEnabled = True


        ElseIf cb1.SelectedIndex = 0 Then
            mm2.IsEnabled = False
            qm2.IsEnabled = False




        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As RoutedEventArgs) Handles clear.Click
        bits.Text = ""
        m1.Text = ""
        m2.Text = ""
        m3.Text = ""
        m4.Text = ""
        m5.Text = ""
        m6.Text = ""
        m7.Text = ""
        n1.Text = ""
        n2.Text = ""
        n3.Text = ""
        n4.Text = ""
        n5.Text = ""
        n6.Text = ""
        n7.Text = ""
        t1.Text = ""
        t2.Text = ""
        t3.Text = ""
        t4.Text = ""
        t5.Text = ""
        t6.Text = ""
        t7.Text = ""
        a1.Text = ""
        a2.Text = ""
        a3.Text = ""
        a4.Text = ""
        a5.Text = ""
        a6.Text = ""
        a7.Text = ""
        qm2.Text = ""
        mm2.Text = ""
        ss.Text = ""
        at.Text = ""
        q.Text = ""
        op.Text = ""



    End Sub
End Class
