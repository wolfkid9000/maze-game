'<zach olson><12/14/17>

Option Explicit Off
Option Infer On
Option Strict Off

Public Class frmMain


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Moves the player using the keys


        Select Case e.KeyCode

            Case Keys.Left ' move your player to left

                PictureBox1.Location = New Point(PictureBox1.Location.X - 5, PictureBox1.Location.Y - 0)

                HitMazeWall()

            Case Keys.Right ' move your player to right

                PictureBox1.Location = New Point(PictureBox1.Location.X + 5, PictureBox1.Location.Y + 0)

                HitMazeWall()

            Case Keys.Up ' move your player up

                PictureBox1.Location = New Point(PictureBox1.Location.X - 0, PictureBox1.Location.Y - 5)

                HitMazeWall()

            Case Keys.Down ' move your player down

                PictureBox1.Location = New Point(PictureBox1.Location.X + 0, PictureBox1.Location.Y + 5)

                HitMazeWall()

        End Select

    End Sub


    Private Sub HitMazeWall()

        'prevent player from going through and vertical walls---------------

        'if the player hits a vertical wall
        If LabelVer2.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer2.Bounds.Right And _
           PictureBox1.Bounds.Right > LabelVer2.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer2.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer2.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer2.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If

        'prevent player from going through any horizontal walls---------

        'if player hits horizontal walls
        If LabelHor2.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor2.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor2.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor2.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor2.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor2.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelVer4.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer4.Bounds.Right And _
           PictureBox1.Bounds.Right > LabelVer4.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer4.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer4.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer4.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If

        'prevent player from going through any horizontal walls---------

        'if player hits horizontal walls
        If LabelHor4.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor4.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor4.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor4.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor4.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor4.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        'if player hits horizontal walls
        If LabelFinish.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelFinish.Bounds.Top And _
            PictureBox1.Bounds.Bottom > LabelFinish.Bounds.Top Then


            MessageBox.Show("You win. Thank you for playing.", "win", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PictureBox1.Location = New Point(PictureBox1.Location.X - 32, PictureBox1.Location.Y + 18)

        End If
        'if player hits horizontal walls
        If LabelHor3.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor3.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor3.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor3.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor3.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor3.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelVer5.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer5.Bounds.Right And _
           PictureBox1.Bounds.Right > LabelVer5.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer5.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer5.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer5.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer6.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer6.Bounds.Right And _
           PictureBox1.Bounds.Right > LabelVer6.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer6.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer6.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer6.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelHor5.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor5.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor5.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor5.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor5.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor5.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor6.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor6.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor6.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor6.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor6.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor6.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelVer7.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer7.Bounds.Right And _
           PictureBox1.Bounds.Right > LabelVer7.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer7.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer7.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer7.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer8.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer8.Bounds.Right And _
           PictureBox1.Bounds.Right > LabelVer8.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer8.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer8.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer8.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer9.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer9.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer9.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer9.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer9.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer9.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelHor7.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor7.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor7.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor7.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor7.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor7.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelVer10.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer10.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer10.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer10.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer10.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer10.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelHor8.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor8.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor8.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor8.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor8.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor8.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor9.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor9.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor9.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor9.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor9.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor9.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelVer11.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer11.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer11.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer11.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer11.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer11.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelColor1.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelColor1.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelColor1.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

            'changes the color of the label
            LabelColor1.BackColor = Color.Yellow
            PictureBox1.BackColor = Color.Yellow

        ElseIf LabelColor1.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelColor1.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelColor1.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

            'changes the color of the label
            LabelColor1.BackColor = Color.Yellow
            PictureBox1.BackColor = Color.Yellow


        End If
        If LabelVer12.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer12.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer12.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer12.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer12.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer12.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer13.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer13.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer13.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer13.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer13.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer13.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer14.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer14.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer14.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer14.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer14.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer14.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelHor10.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor10.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor10.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor10.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor10.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor10.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelVer15.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer15.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer15.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer15.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer15.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer15.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelHor11.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor11.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor11.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor11.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor11.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor11.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelVer16.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer16.Bounds.Right And _
                  PictureBox1.Bounds.Right > LabelVer16.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer16.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer16.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer16.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer17.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer17.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer17.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer17.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer17.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer17.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer18.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer18.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer18.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer18.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer18.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer18.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelHor12.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor12.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor12.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor12.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor12.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor12.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor13.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor13.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor13.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor13.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor13.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor13.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor14.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor14.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor14.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor14.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor14.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor14.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor15.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor15.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor15.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor15.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor15.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor15.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelVer19.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer19.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer19.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer19.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer19.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer19.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer20.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer20.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer20.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer20.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer20.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer20.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer21.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer21.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer21.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer21.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer21.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer21.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelHor16.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor16.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor16.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor16.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor16.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor16.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor17.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor17.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor17.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor17.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor17.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor17.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor18.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor18.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor18.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor18.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor18.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor18.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelVer22.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer22.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer22.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer22.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer22.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer22.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer23.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer23.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer23.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer23.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer23.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer23.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelHor19.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor19.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor19.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor19.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor19.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor19.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor20.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor20.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor20.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor20.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor20.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor20.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor21.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor21.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor21.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor21.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor21.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor21.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor22.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor22.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor22.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor22.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor22.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor22.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelVer24.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer24.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer24.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer24.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer24.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer24.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer25.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer25.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer25.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer25.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer25.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer25.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer26.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer26.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer26.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer26.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer26.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer26.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer27.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer27.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer27.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer27.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer27.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer27.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer28.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer28.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer28.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer28.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer28.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer28.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer29.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer29.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer29.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer29.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer29.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer29.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer30.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer30.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer30.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer30.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer30.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer30.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer31.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer31.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer31.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer31.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer31.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer31.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelHor23.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor23.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor23.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor23.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor23.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor23.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor24.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor24.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor24.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor24.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor24.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor24.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelVer32.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer32.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer32.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer32.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer32.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer32.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer33.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer33.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer33.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer33.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer33.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer33.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer34.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer34.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer34.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer34.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer34.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer34.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelHor25.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor25.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor25.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor25.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor25.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor25.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor26.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor26.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor26.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor26.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor26.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor26.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor27.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor27.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor27.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor27.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor27.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor27.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor28.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor28.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor28.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor28.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor28.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor28.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If

        If LabelVer35.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer35.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer35.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer35.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer35.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer35.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If PictureBox1.BackColor <> Color.Blue Then
            If LabelGate1.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelGate1.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelGate1.Bounds.Bottom Then

                'move the palyer down slightly
                PictureBox1.Top += 5

            ElseIf LabelGate1.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelGate1.Bounds.Top And _
               PictureBox1.Bounds.Top < LabelGate1.Bounds.Top Then

                'move the player up slightly
                PictureBox1.Top -= 5

            End If

        End If
        If PictureBox1.BackColor <> Color.Yellow Then
            If LabelGateYellow.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelGateYellow.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelGateYellow.Bounds.Right Then

                'move the player to the right a little
                PictureBox1.Left += 5

            ElseIf LabelGateYellow.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelGateYellow.Bounds.Left And _
                PictureBox1.Bounds.Left < LabelGateYellow.Bounds.Left Then

                'move the player to the left a little
                PictureBox1.Left -= 5

            End If

        End If
        If LabelHor29.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor29.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor29.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor29.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor29.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor29.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelColor2.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelColor2.Bounds.Right And _
         PictureBox1.Bounds.Right > LabelColor2.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5
            LabelColor2.BackColor = Color.Blue
            PictureBox1.BackColor = Color.Blue

        ElseIf LabelColor2.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelColor2.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelColor2.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5
            LabelColor2.BackColor = Color.Blue
            PictureBox1.BackColor = Color.Blue

        End If
        If LabelVer36.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer36.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer36.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer36.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer36.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer36.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelHor30.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor30.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor30.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor30.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor30.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor30.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor31.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor31.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor31.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor31.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor31.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor31.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor32.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor32.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor32.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor32.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor32.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor32.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelVer37.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer37.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer37.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer37.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer37.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer37.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer38.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer38.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer38.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer38.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer38.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer38.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer39.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer39.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer39.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer39.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer39.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer39.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer40.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer40.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer40.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer40.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer40.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer40.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer41.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer41.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer41.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer41.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer41.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer41.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer42.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer42.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer42.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer42.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer42.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer42.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer43.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer43.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer43.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer43.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer43.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer43.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelHor33.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor33.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor33.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor33.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor33.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor33.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor34.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor34.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor34.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor34.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor34.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor34.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor35.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor35.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor35.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor35.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor35.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor35.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor36.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor36.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor36.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor36.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor36.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor36.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor37.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor37.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor37.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor37.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor37.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor37.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor38.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor38.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor38.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor38.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor38.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor38.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor39.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor39.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor39.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor39.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor39.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor39.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelHor40.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor40.Bounds.Bottom And _
            PictureBox1.Bounds.Bottom > LabelHor40.Bounds.Bottom Then

            'move the palyer down slightly
            PictureBox1.Top += 5

        ElseIf LabelHor40.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor40.Bounds.Top And _
           PictureBox1.Bounds.Top < LabelHor40.Bounds.Top Then

            'move the player up slightly
            PictureBox1.Top -= 5

        End If
        If LabelVer44.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer44.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer44.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer44.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer44.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer44.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer45.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer45.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer45.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer45.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer45.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer45.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
        If LabelVer46.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer46.Bounds.Right And _
          PictureBox1.Bounds.Right > LabelVer46.Bounds.Right Then

            'move the player to the right a little
            PictureBox1.Left += 5

        ElseIf LabelVer46.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer46.Bounds.Left And _
            PictureBox1.Bounds.Left < LabelVer46.Bounds.Left Then

            'move the player to the left a little
            PictureBox1.Left -= 5

        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim randGen As New Random
        Dim intNum1 As Integer

        intNum1 = randGen.Next(1, 5)

        Select Case intNum1
            Case 1
                picBackground.Image = picBack1.Image
            Case 2
                picBackground.Image = picBack2.Image
            Case 3
                picBackground.Image = picBack3.Image
            Case 4
                picBackground.Image = picBack4.Image
        End Select
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar <> "." AndAlso
e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        MessageBox.Show("Welcome to my maze game.The objective of the game is to get the green square at the end of the maze.To control the red square all you need to do is use the arrow keys.A tip for the game is there are many color gates that block your path. To cross you must find the corosponding color to pass the gate.", "Instructions. ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
