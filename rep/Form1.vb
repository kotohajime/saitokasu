Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = 40 Then
            If sainome.Text = 1 Then
                t1.Enabled = True
            ElseIf sainome.Text = 2 Then
                t2.Enabled = True
            ElseIf sainome.Text = 3 Then
                t3.Enabled = True
            ElseIf sainome.Text = 4 Then
                t4.Enabled = True
            ElseIf sainome.Text = 5 Then
                t5.Enabled = True
            Else
                t6.Enabled = True
            End If
        End If
        If e.KeyCode = 32 Then
            sayuu.Text = Int(Rnd() * 2)
            sainome.Text = Int(Rnd() * 6) + 1
            If sainome.Text = 1 Then
                g1.Visible = True
                g2.Visible = False
                g3.Visible = False
                g4.Visible = False
                g5.Visible = False
                g6.Visible = False
            ElseIf sainome.Text = 2 Then
                g2.Visible = True
                g1.Visible = False
                g3.Visible = False
                g4.Visible = False
                g5.Visible = False
                g6.Visible = False
            ElseIf sainome.Text = 3 Then
                g3.Visible = True
                g1.Visible = False
                g2.Visible = False
                g4.Visible = False
                g5.Visible = False
                g6.Visible = False
            ElseIf sainome.Text = 4 Then
                g4.Visible = True
                g1.Visible = False
                g2.Visible = False
                g3.Visible = False
                g5.Visible = False
                g6.Visible = False
            ElseIf sainome.Text = 5 Then
                g5.Visible = True
                g1.Visible = False
                g2.Visible = False
                g3.Visible = False
                g4.Visible = False
                g6.Visible = False
            Else
                g6.Visible = True
                g1.Visible = False
                g2.Visible = False
                g3.Visible = False
                g4.Visible = False
                g5.Visible = False
            End If
        End If
    End Sub

    Private Sub t1_Tick(sender As System.Object, e As System.EventArgs) Handles t1.Tick
        f1.Text = f1.Text + 1

        If sayuu.Text = 0 Then
            If f1.Text = 1 Then
                s1.Left = g1.Left + 6
                g1.Visible = False
                s1.Visible = True
            ElseIf f1.Text = 2 Then
                g1.Left = s1.Left + 14
                s1.Visible = False
                g1.Visible = True

                g4.Left = g1.Left
                g2.Left = g1.Left
                g3.Left = g1.Left
                g5.Left = g1.Left
                g6.Left = g1.Left
                sayuu.Text = Int(Rnd() * 2)
                f1.Text = 0
                t1.Enabled = False
            End If
        End If

        If sayuu.Text = 1 Then
            If f1.Text = 1 Then
                s1.Left = g1.Left - 14
                g1.Visible = False
                s1.Visible = True
            ElseIf f1.Text = 2 Then
                g1.Left = s1.Left - 6
                s1.Visible = False
                g1.Visible = True

                g4.Left = g1.Left
                g2.Left = g1.Left
                g3.Left = g1.Left
                g5.Left = g1.Left
                g6.Left = g1.Left
                sayuu.Text = Int(Rnd() * 2)
                f1.Text = 0
                t1.Enabled = False
            End If
        End If
    End Sub

    Private Sub t2_Tick(sender As System.Object, e As System.EventArgs) Handles t2.Tick
        f2.Text = f2.Text + 1

        If sayuu.Text = 0 Then
            If f2.Text = 1 Then
                r2.Left = g2.Left + 6
                r2.Visible = True
                g2.Visible = False
            ElseIf f2.Text = 2 Then
                r2.Visible = False
                y2.Left = r2.Left + 14
                y2.Visible = True
            ElseIf f2.Text = 3 Then
                y2.Visible = False
                l2.Left = y2.Left + 6
                l2.Visible = True
            ElseIf f2.Text = 4 Then
                l2.Visible = False
                g2.Left = l2.Left + 14
                g2.Visible = True
                g1.Left = g2.Left
                g6.Left = g2.Left
                g3.Left = g2.Left
                g4.Left = g2.Left
                g5.Left = g2.Left
                sayuu.Text = Int(Rnd() * 2)
                f2.Text = 0
                t2.Enabled = False
            End If
        ElseIf sayuu.Text = 1 Then
            If f2.Text = 1 Then
                l2.Left = g2.Left - 14
                l2.Visible = True
                g2.Visible = False
            ElseIf f2.Text = 2 Then
                l2.Visible = False
                y2.Left = l2.Left - 6
                y2.Visible = True
            ElseIf f2.Text = 3 Then
                y2.Visible = False
                r2.Left = y2.Left - 14
                r2.Visible = True
            ElseIf f2.Text = 4 Then
                r2.Visible = False
                g2.Left = r2.Left - 6
                g2.Visible = True
                g1.Left = g2.Left
                g6.Left = g2.Left
                g3.Left = g2.Left
                g4.Left = g2.Left
                g5.Left = g2.Left
                sayuu.Text = Int(Rnd() * 2)
                f2.Text = 0
                t2.Enabled = False
            End If
        End If
    End Sub

    Private Sub t3_Tick(sender As System.Object, e As System.EventArgs) Handles t3.Tick
        f3.Text = f3.Text + 1

        If sayuu.Text = 0 Then
            If f3.Text = 1 Then
                r3.Left = g3.Left + 6
                r3.Visible = True
                g3.Visible = False
            ElseIf f3.Text = 2 Then
                r3.Visible = False
                y3.Left = r3.Left + 14
                y3.Visible = True
            ElseIf f3.Text = 3 Then
                y3.Visible = False
                l3.Left = y3.Left + 6
                l3.Visible = True
            ElseIf f3.Text = 4 Then
                l3.Visible = False
                g3.Left = l3.Left + 14
                g3.Visible = True
            ElseIf f3.Text = 5 Then
                r3.Left = g3.Left + 6
                r3.Visible = True
                g3.Visible = False
            ElseIf f3.Text = 6 Then
                r3.Visible = False
                g3.Left = r3.Left + 14
                g3.Visible = True
                g1.Left = g3.Left
                g2.Left = g3.Left
                g6.Left = g3.Left
                g4.Left = g3.Left
                g5.Left = g3.Left
                sayuu.Text = Int(Rnd() * 2)
                f3.Text = 0
                t3.Enabled = False
            End If
        ElseIf sayuu.Text = 1 Then
            If f3.Text = 1 Then
                l3.Left = g3.Left - 14
                l3.Visible = True
                g3.Visible = False
            ElseIf f3.Text = 2 Then
                l3.Visible = False
                y3.Left = l3.Left - 6
                y3.Visible = True
            ElseIf f3.Text = 3 Then
                y3.Visible = False
                r3.Left = y3.Left - 14
                r3.Visible = True
            ElseIf f3.Text = 4 Then
                r3.Visible = False
                g3.Left = r3.Left - 6
                g3.Visible = True
            ElseIf f3.Text = 5 Then
                l3.Left = g3.Left - 14
                l3.Visible = True
                g3.Visible = False
            ElseIf f3.Text = 6 Then
                l3.Visible = False
                g3.Left = l3.Left - 6
                g3.Visible = True
                g1.Left = g3.Left
                g2.Left = g3.Left
                g6.Left = g3.Left
                g4.Left = g3.Left
                g5.Left = g3.Left
                sayuu.Text = Int(Rnd() * 2)
                f3.Text = 0
                t3.Enabled = False
            End If
        End If
    End Sub

    Private Sub t4_Tick(sender As System.Object, e As System.EventArgs) Handles t4.Tick
        f4.Text = f4.Text + 1

        If sayuu.Text = 0 Then
            If f4.Text = 1 Then
                s4.Left = g4.Left + 6
                g4.Visible = False
                s4.Visible = True
            ElseIf f4.Text = 2 Then
                g4.Left = s4.Left + 14
                s4.Visible = False
                g4.Visible = True
            ElseIf f4.Text = 3 Then
                s4.Left = g4.Left + 6
                g4.Visible = False
                s4.Visible = True
            ElseIf f4.Text = 4 Then
                g4.Left = s4.Left + 14
                s4.Visible = False
                g4.Visible = True
            ElseIf f4.Text = 5 Then
                s4.Left = g4.Left + 6
                g4.Visible = False
                s4.Visible = True
            ElseIf f4.Text = 6 Then
                g4.Left = s4.Left + 14
                s4.Visible = False
                g4.Visible = True
            ElseIf f4.Text = 7 Then
                s4.Left = g4.Left + 6
                g4.Visible = False
                s4.Visible = True
            ElseIf f4.Text = 8 Then
                g4.Left = s4.Left + 14
                s4.Visible = False
                g4.Visible = True

                g1.Left = g4.Left
                g2.Left = g4.Left
                g3.Left = g4.Left
                g5.Left = g4.Left
                g6.Left = g4.Left
                sayuu.Text = Int(Rnd() * 2)
                f4.Text = 0
                t4.Enabled = False
            End If
        End If

        If sayuu.Text = 1 Then
            If f4.Text = 1 Then
                s4.Left = g4.Left - 14
                g4.Visible = False
                s4.Visible = True
            ElseIf f4.Text = 2 Then
                g4.Left = s4.Left - 6
                s4.Visible = False
                g4.Visible = True
            ElseIf f4.Text = 3 Then
                s4.Left = g4.Left - 14
                g4.Visible = False
                s4.Visible = True
            ElseIf f4.Text = 4 Then
                g4.Left = s4.Left - 6
                s4.Visible = False
                g4.Visible = True
            ElseIf f4.Text = 5 Then
                s4.Left = g4.Left - 14
                g4.Visible = False
                s4.Visible = True
            ElseIf f4.Text = 6 Then
                g4.Left = s4.Left - 6
                s4.Visible = False
                g4.Visible = True
            ElseIf f4.Text = 7 Then
                s4.Left = g4.Left - 14
                g4.Visible = False
                s4.Visible = True
            ElseIf f4.Text = 8 Then
                g4.Left = s4.Left - 6
                s4.Visible = False
                g4.Visible = True

                g1.Left = g4.Left
                g2.Left = g4.Left
                g3.Left = g4.Left
                g5.Left = g4.Left
                g6.Left = g4.Left
                sayuu.Text = Int(Rnd() * 2)
                f4.Text = 0
                t4.Enabled = False
            End If
        End If
    End Sub

    Private Sub t5_Tick(sender As System.Object, e As System.EventArgs) Handles t5.Tick
        f5.Text = f5.Text + 1

        If sayuu.Text = 0 Then
            If f5.Text = 1 Then
                s5.Left = g5.Left + 6
                g5.Visible = False
                s5.Visible = True
            ElseIf f5.Text = 2 Then
                g5.Left = s5.Left + 14
                s5.Visible = False
                g5.Visible = True
            ElseIf f5.Text = 3 Then
                s5.Left = g5.Left + 6
                g5.Visible = False
                s5.Visible = True
            ElseIf f5.Text = 4 Then
                g5.Left = s5.Left + 14
                s5.Visible = False
                g5.Visible = True
            ElseIf f5.Text = 5 Then
                s5.Left = g5.Left + 6
                g5.Visible = False
                s5.Visible = True
            ElseIf f5.Text = 6 Then
                g5.Left = s5.Left + 14
                s5.Visible = False
                g5.Visible = True
            ElseIf f5.Text = 7 Then
                s5.Left = g5.Left + 6
                g5.Visible = False
                s5.Visible = True
            ElseIf f5.Text = 8 Then
                g5.Left = s5.Left + 14
                s5.Visible = False
                g5.Visible = True
            ElseIf f5.Text = 9 Then
                s5.Left = g5.Left + 6
                g5.Visible = False
                s5.Visible = True
            ElseIf f5.Text = 10 Then
                g5.Left = s5.Left + 14
                s5.Visible = False
                g5.Visible = True
                g1.Left = g5.Left
                g2.Left = g5.Left
                g3.Left = g5.Left
                g4.Left = g5.Left
                g6.Left = g5.Left
                sayuu.Text = Int(Rnd() * 2)
                f5.Text = 0
                t5.Enabled = False
            End If
        End If

        If sayuu.Text = 1 Then
            If f5.Text = 1 Then
                s5.Left = g5.Left - 14
                g5.Visible = False
                s5.Visible = True
            ElseIf f5.Text = 2 Then
                g5.Left = s5.Left - 6
                s5.Visible = False
                g5.Visible = True
            ElseIf f5.Text = 3 Then
                s5.Left = g5.Left - 14
                g5.Visible = False
                s5.Visible = True
            ElseIf f5.Text = 4 Then
                g5.Left = s5.Left - 6
                s5.Visible = False
                g5.Visible = True
            ElseIf f5.Text = 5 Then
                s5.Left = g5.Left - 14
                g5.Visible = False
                s5.Visible = True
            ElseIf f5.Text = 6 Then
                g5.Left = s5.Left - 6
                s5.Visible = False
                g5.Visible = True
            ElseIf f5.Text = 7 Then
                s5.Left = g5.Left - 14
                g5.Visible = False
                s5.Visible = True
            ElseIf f5.Text = 8 Then
                g5.Left = s5.Left - 6
                s5.Visible = False
                g5.Visible = True
            ElseIf f5.Text = 9 Then
                s5.Left = g5.Left - 14
                g5.Visible = False
                s5.Visible = True
            ElseIf f5.Text = 10 Then
                g5.Left = s5.Left - 6
                s5.Visible = False
                g5.Visible = True
                g1.Left = g5.Left
                g2.Left = g5.Left
                g3.Left = g5.Left
                g4.Left = g5.Left
                g6.Left = g5.Left
                sayuu.Text = Int(Rnd() * 2)
                f5.Text = 0
                t5.Enabled = False
            End If
        End If
    End Sub

    Private Sub t6_Tick(sender As System.Object, e As System.EventArgs) Handles t6.Tick
        f6.Text = f6.Text + 1

        If sayuu.Text = 0 Then
            If f6.Text = 1 Then
                If y6.Visible = False Then
                    r6.Left = g6.Left + 6
                    r6.Visible = True
                    g6.Visible = False
                    If r6.Left > 605 Then
                        r6.Visible = False
                        g6.Visible = True
                        g1.Left = g6.Left
                        g2.Left = g6.Left
                        g3.Left = g6.Left
                        g4.Left = g6.Left
                        g5.Left = g6.Left
                        y6.Left = g6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                Else
                    y6.Visible = False
                    l6.Left = y6.Left + 6
                    l6.Visible = True
                    If l6.Left > 605 Then
                        l6.Visible = False
                        y6.Visible = True
                        g1.Left = y6.Left
                        g2.Left = y6.Left
                        g3.Left = y6.Left
                        g4.Left = y6.Left
                        g5.Left = y6.Left
                        g6.Left = y6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                End If
            End If


            If f6.Text = 2 Then
                If l6.Visible = False Then
                    r6.Visible = False
                    y6.Left = r6.Left + 14
                    y6.Visible = True
                Else
                    l6.Visible = False
                    g6.Left = l6.Left + 14
                    g6.Visible = True
                End If
            End If

            If f6.Text = 3 Then
                If g6.Visible = False Then
                    y6.Visible = False
                    l6.Left = y6.Left + 6
                    l6.Visible = True
                    If l6.Left > 605 Then
                        l6.Visible = False
                        y6.Visible = True
                        g1.Left = y6.Left
                        g2.Left = y6.Left
                        g3.Left = y6.Left
                        g4.Left = y6.Left
                        g5.Left = y6.Left
                        g6.Left = y6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                Else
                    g6.Visible = False
                    r6.Left = g6.Left + 6
                    r6.Visible = True
                    If r6.Left > 605 Then
                        r6.Visible = False
                        g6.Visible = True
                        g1.Left = g6.Left
                        g2.Left = g6.Left
                        g3.Left = g6.Left
                        g4.Left = g6.Left
                        g5.Left = g6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                End If
            End If



            If f6.Text = 4 Then
                If r6.Visible = False Then
                    l6.Visible = False
                    g6.Left = l6.Left + 14
                    g6.Visible = True
                Else
                    r6.Visible = False
                    y6.Left = r6.Left + 14
                    y6.Visible = True
                End If
            End If



            If f6.Text = 5 Then
                If y6.Visible = False Then
                    r6.Left = g6.Left + 6
                    r6.Visible = True
                    g6.Visible = False
                    If r6.Left > 605 Then
                        r6.Visible = False
                        g6.Visible = True
                        g1.Left = g6.Left
                        g2.Left = g6.Left
                        g3.Left = g6.Left
                        g4.Left = g6.Left
                        g5.Left = g6.Left
                        y6.Left = g6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                Else
                    y6.Visible = False
                    l6.Left = y6.Left + 6
                    l6.Visible = True
                    If l6.Left > 605 Then
                        l6.Visible = False
                        y6.Visible = True
                        g1.Left = y6.Left
                        g2.Left = y6.Left
                        g3.Left = y6.Left
                        g4.Left = y6.Left
                        g5.Left = y6.Left
                        g6.Left = y6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                End If
            End If


            If f6.Text = 6 Then
                If l6.Visible = False Then
                    r6.Visible = False
                    y6.Left = r6.Left + 14
                    y6.Visible = True
                Else
                    l6.Visible = False
                    g6.Left = l6.Left + 14
                    g6.Visible = True
                End If
            End If

            If f6.Text = 7 Then
                If g6.Visible = False Then
                    y6.Visible = False
                    l6.Left = y6.Left + 6
                    l6.Visible = True
                    If l6.Left > 605 Then
                        l6.Visible = False
                        y6.Visible = True
                        g1.Left = y6.Left
                        g2.Left = y6.Left
                        g3.Left = y6.Left
                        g4.Left = y6.Left
                        g5.Left = y6.Left
                        g6.Left = y6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                Else
                    g6.Visible = False
                    r6.Left = g6.Left + 6
                    r6.Visible = True
                    If r6.Left > 605 Then
                        r6.Visible = False
                        g6.Visible = True
                        g1.Left = g6.Left
                        g2.Left = g6.Left
                        g3.Left = g6.Left
                        g4.Left = g6.Left
                        g5.Left = g6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                End If
            End If


            If f6.Text = 8 Then
                If r6.Visible = False Then
                    l6.Visible = False
                    g6.Left = l6.Left + 14
                    g6.Visible = True
                Else
                    r6.Visible = False
                    y6.Left = r6.Left + 14
                    y6.Visible = True
                End If
            End If

            If f6.Text = 9 Then
                If y6.Visible = False Then
                    r6.Left = g6.Left + 6
                    r6.Visible = True
                    g6.Visible = False
                    If r6.Left > 605 Then
                        r6.Visible = False
                        g6.Visible = True
                        g1.Left = g6.Left
                        g2.Left = g6.Left
                        g3.Left = g6.Left
                        g4.Left = g6.Left
                        g5.Left = g6.Left
                        y6.Left = g6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                Else
                    y6.Visible = False
                    l6.Left = y6.Left + 6
                    l6.Visible = True
                    If l6.Left > 605 Then
                        l6.Visible = False
                        y6.Visible = True
                        g1.Left = y6.Left
                        g2.Left = y6.Left
                        g3.Left = y6.Left
                        g4.Left = y6.Left
                        g5.Left = y6.Left
                        g6.Left = y6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                End If
            End If

            If f6.Text = 10 Then
                If l6.Visible = False Then
                    r6.Visible = False
                    y6.Left = r6.Left + 14
                    y6.Visible = True
                Else
                    l6.Visible = False
                    g6.Left = l6.Left + 14
                    g6.Visible = True
                End If
            End If


            If f6.Text = 11 Then
                If g6.Visible = False Then
                    y6.Visible = False
                    l6.Left = y6.Left + 6
                    l6.Visible = True
                    If l6.Left > 605 Then
                        l6.Visible = False
                        y6.Visible = True
                        g1.Left = y6.Left
                        g2.Left = y6.Left
                        g3.Left = y6.Left
                        g4.Left = y6.Left
                        g5.Left = y6.Left
                        g6.Left = y6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                Else
                    g6.Visible = False
                    r6.Left = g6.Left + 6
                    r6.Visible = True
                    If r6.Left > 605 Then
                        r6.Visible = False
                        g6.Visible = True
                        g1.Left = g6.Left
                        g2.Left = g6.Left
                        g3.Left = g6.Left
                        g4.Left = g6.Left
                        g5.Left = g6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                End If
            End If


            If f6.Text = 12 Then
                If r6.Visible = False Then
                    l6.Visible = False
                    g6.Left = l6.Left + 14
                    g6.Visible = True
                    g1.Left = g6.Left
                    g2.Left = g6.Left
                    g3.Left = g6.Left
                    g4.Left = g6.Left
                    g5.Left = g6.Left
                    sayuu.Text = Int(Rnd() * 2)
                    f6.Text = 0
                    t6.Enabled = False
                Else
                    r6.Visible = False
                    y6.Left = r6.Left + 14
                    y6.Visible = True
                    g1.Left = g6.Left
                    g2.Left = g6.Left
                    g3.Left = g6.Left
                    g4.Left = g6.Left
                    g5.Left = g6.Left
                    sayuu.Text = Int(Rnd() * 2)
                    f6.Text = 0
                    t6.Enabled = False
                End If
            End If




        ElseIf sayuu.Text = 1 Then
            If f6.Text = 1 Then
                If y6.Visible = False Then
                    l6.Left = g6.Left - 14
                    l6.Visible = True
                    g6.Visible = False
                    If l6.Left < -10 Then
                        l6.Visible = False
                        g6.Visible = True
                        g1.Left = g6.Left
                        g2.Left = g6.Left
                        g3.Left = g6.Left
                        g4.Left = g6.Left
                        g5.Left = g6.Left
                        y6.Left = g6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                Else
                    y6.Visible = False
                    r6.Visible = True
                    r6.Left = y6.Left - 14
                    If r6.Left < -10 Then
                        r6.Visible = False
                        y6.Visible = True
                        g1.Left = y6.Left
                        g2.Left = y6.Left
                        g3.Left = y6.Left
                        g4.Left = y6.Left
                        g5.Left = y6.Left
                        g6.Left = y6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                End If
            End If




            If f6.Text = 2 Then
                If r6.Visible = False Then
                    l6.Visible = False
                    y6.Left = l6.Left - 6
                    y6.Visible = True
                Else
                    r6.Visible = False
                    g6.Left = r6.Left - 6
                    g6.Visible = True
                End If
            End If


            If f6.Text = 3 Then
                If g6.Visible = False Then
                    y6.Visible = False
                    r6.Left = y6.Left - 14
                    r6.Visible = True
                    If r6.Left < -10 Then
                        r6.Visible = False
                        y6.Visible = True
                        g1.Left = y6.Left
                        g2.Left = y6.Left
                        g3.Left = y6.Left
                        g4.Left = y6.Left
                        g5.Left = y6.Left
                        g6.Left = y6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                Else
                    g6.Visible = False
                    l6.Left = g6.Left - 14
                    l6.Visible = True
                    If l6.Left < -10 Then
                        l6.Visible = False
                        g6.Visible = True
                        g1.Left = g6.Left
                        g2.Left = g6.Left
                        g3.Left = g6.Left
                        g4.Left = g6.Left
                        g5.Left = g6.Left
                        y6.Left = g6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                End If
            End If



            If f6.Text = 4 Then
                If l6.Visible = False Then
                    r6.Visible = False
                    g6.Left = r6.Left - 6
                    g6.Visible = True
                Else
                    l6.Visible = False
                    y6.Left = l6.Left - 6
                    y6.Visible = True
                End If
            End If


            If f6.Text = 5 Then
                If y6.Visible = False Then
                    l6.Left = g6.Left - 14
                    l6.Visible = True
                    g6.Visible = False
                    If l6.Left < -10 Then
                        l6.Visible = False
                        g6.Visible = True
                        g1.Left = g6.Left
                        g2.Left = g6.Left
                        g3.Left = g6.Left
                        g4.Left = g6.Left
                        g5.Left = g6.Left
                        y6.Left = g6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                Else
                    y6.Visible = False
                    r6.Left = y6.Left - 14
                    r6.Visible = True
                    If r6.Left < -10 Then
                        r6.Visible = False
                        y6.Visible = True
                        g1.Left = y6.Left
                        g2.Left = y6.Left
                        g3.Left = y6.Left
                        g4.Left = y6.Left
                        g5.Left = y6.Left
                        g6.Left = y6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                End If
            End If

            If f6.Text = 6 Then
                If r6.Visible = False Then
                    l6.Visible = False
                    y6.Left = l6.Left - 6
                    y6.Visible = True
                Else
                    r6.Visible = False
                    g6.Left = r6.Left - 6
                    g6.Visible = True
                End If
            End If


            If f6.Text = 7 Then
                If g6.Visible = False Then
                    y6.Visible = False
                    r6.Left = y6.Left - 14
                    r6.Visible = True
                    If r6.Left < -10 Then
                        r6.Visible = False
                        y6.Visible = True
                        g1.Left = y6.Left
                        g2.Left = y6.Left
                        g3.Left = y6.Left
                        g4.Left = y6.Left
                        g5.Left = y6.Left
                        g6.Left = y6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                Else
                    g6.Visible = False
                    l6.Left = g6.Left - 14
                    l6.Visible = True
                    If l6.Left < -10 Then
                        l6.Visible = False
                        g6.Visible = True
                        g1.Left = g6.Left
                        g2.Left = g6.Left
                        g3.Left = g6.Left
                        g4.Left = g6.Left
                        g5.Left = g6.Left
                        y6.Left = g6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                End If
            End If

            If f6.Text = 8 Then
                If l6.Visible = False Then
                    r6.Visible = False
                    g6.Left = r6.Left - 6
                    g6.Visible = True
                Else
                    l6.Visible = False
                    y6.Left = l6.Left - 6
                    y6.Visible = True
                End If
            End If

            If f6.Text = 9 Then
                If y6.Visible = False Then
                    l6.Left = g6.Left - 14
                    l6.Visible = True
                    g6.Visible = False
                    If l6.Left < -10 Then
                        l6.Visible = False
                        g6.Visible = True
                        g1.Left = g6.Left
                        g2.Left = g6.Left
                        g3.Left = g6.Left
                        g4.Left = g6.Left
                        g5.Left = g6.Left
                        y6.Left = g6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                Else
                    y6.Visible = False
                    r6.Left = y6.Left - 14
                    r6.Visible = True
                    If r6.Left < -10 Then
                        r6.Visible = False
                        y6.Visible = True
                        g1.Left = y6.Left
                        g2.Left = y6.Left
                        g3.Left = y6.Left
                        g4.Left = y6.Left
                        g5.Left = y6.Left
                        g6.Left = y6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                End If
            End If

            If f6.Text = 10 Then
                If r6.Visible = False Then
                    l6.Visible = False
                    y6.Left = l6.Left - 6
                    y6.Visible = True
                Else
                    r6.Visible = False
                    g6.Left = r6.Left - 6
                    g6.Visible = True
                End If
            End If

            If f6.Text = 11 Then
                If g6.Visible = False Then
                    y6.Visible = False
                    r6.Left = y6.Left - 14
                    r6.Visible = True
                    If r6.Left < -10 Then
                        r6.Visible = False
                        y6.Visible = True
                        g1.Left = y6.Left
                        g2.Left = y6.Left
                        g3.Left = y6.Left
                        g4.Left = y6.Left
                        g5.Left = y6.Left
                        g6.Left = y6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                Else
                    g6.Visible = False
                    l6.Left = g6.Left - 14
                    l6.Visible = True
                    If l6.Left < -10 Then
                        l6.Visible = False
                        g6.Visible = True
                        g1.Left = g6.Left
                        g2.Left = g6.Left
                        g3.Left = g6.Left
                        g4.Left = g6.Left
                        g5.Left = g6.Left
                        y6.Left = g6.Left
                        sayuu.Text = Int(Rnd() * 2)
                        f6.Text = 0
                        t6.Enabled = False
                    End If
                End If
            End If

            If f6.Text = 12 Then
                If l6.Visible = False Then
                    r6.Visible = False
                    g6.Left = r6.Left - 6
                    g6.Visible = True
                    g1.Left = g6.Left
                    g2.Left = g6.Left
                    g3.Left = g6.Left
                    g4.Left = g6.Left
                    g5.Left = g6.Left
                    sayuu.Text = Int(Rnd() * 2)
                    f6.Text = 0
                    t6.Enabled = False
                Else
                    l6.Visible = False
                    y6.Left = l6.Left - 6
                    y6.Visible = True
                    g1.Left = y6.Left
                    g2.Left = y6.Left
                    g3.Left = y6.Left
                    g4.Left = y6.Left
                    g5.Left = y6.Left
                    g6.Left = y6.Left
                    sayuu.Text = Int(Rnd() * 2)
                    f6.Text = 0
                    t6.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles start.Click
        sayuu.Text = Int(Rnd() * 2)
        sainome.Text = Int(Rnd() * 6) + 1
        If sainome.Text = 1 Then
            g1.Visible = True
            g2.Visible = False
            g3.Visible = False
            g4.Visible = False
            g5.Visible = False
            g6.Visible = False
        ElseIf sainome.Text = 2 Then
            g2.Visible = True
            g1.Visible = False
            g3.Visible = False
            g4.Visible = False
            g5.Visible = False
            g6.Visible = False
        ElseIf sainome.Text = 3 Then
            g3.Visible = True
            g1.Visible = False
            g2.Visible = False
            g4.Visible = False
            g5.Visible = False
            g6.Visible = False
        ElseIf sainome.Text = 4 Then
            g4.Visible = True
            g1.Visible = False
            g2.Visible = False
            g3.Visible = False
            g5.Visible = False
            g6.Visible = False
        ElseIf sainome.Text = 5 Then
            g5.Visible = True
            g1.Visible = False
            g2.Visible = False
            g3.Visible = False
            g4.Visible = False
            g6.Visible = False
        Else
            g6.Visible = True
            g1.Visible = False
            g2.Visible = False
            g3.Visible = False
            g4.Visible = False
            g5.Visible = False
        End If

        start.Visible = False
        title.Visible = False
        sm1.Visible = True
        sm2.Visible = True
        sm3.Visible = True
        sm4.Visible = True
        sm5.Visible = True
        sm6.Visible = True
        ready.Visible = True


    End Sub
End Class
