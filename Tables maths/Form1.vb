Imports System.Timers
Imports System.IO

Public Class Form1

    Dim a As Integer
    Dim b As Integer
    Dim table As String
    Dim score As Integer
    Dim questions As Integer
    Dim compteur As Integer

    Private Declare Function GetSystemMenu Lib "user32" (ByVal hwnd As Integer, ByVal revert As Integer) As Integer
    Private Declare Function EnableMenuItem Lib "user32" (ByVal menu As Integer, ByVal ideEnableItem As Integer, ByVal enable As Integer) As Integer
    Private Const SC_CLOSE As Integer = &HF060
    Private Const MF_BYCOMMAND As Integer = &H0
    Private Const MF_GRAYED As Integer = &H1
    Private Const MF_ENABLED As Integer = &H0

    Public Shared Sub Disable(ByVal form As System.Windows.Forms.Form)

        ' The return value specifies the previous state of the menu item (it is either     
        ' MF_ENABLED or MF_GRAYED). 0xFFFFFFFF indicates   that the menu item does not exist.     
        Select Case EnableMenuItem(GetSystemMenu(form.Handle.ToInt32, 0), SC_CLOSE, MF_BYCOMMAND Or MF_GRAYED)
            Case MF_ENABLED
            Case MF_GRAYED
            Case &HFFFFFFFF
                Throw New Exception("The Close menu item does not exist.")
            Case Else
        End Select
    End Sub

    Sub état_origine()
        Liste_tables.SelectedIndex = 0
        Nombre.SelectedIndex = 3
        Commentaire.Text = ""
        Bonne_réponse.Text = ""
        Résultat.Text = ""
        question.Text = ""
        Note.Text = ""
        questions = 0
        score = 0
        chrono.Text = ""
        Résultat.Visible = False
        RectangleShape1.Visible = False
        Label_score.Visible = False
        Prénom.Select()
        Me.TopMost = False
        If Prénom.Text = "" Then
            Départ.Enabled = False
        Else
            Départ.Enabled = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        état_origine()
    End Sub

    Sub aleatoire()
        If questions.ToString() <> Nombre.Text Then
            Résultat.Enabled = True
            Me.Résultat.Focus()
            Randomize()
            b = Int(12 * Rnd())
            questions = questions + 1
            chrono.Text = 10
        Else
            MessageBox.Show(Prénom.Text & ", ton score est de " & score.ToString() & " / " & questions)
            Dim FichierScores As StreamWriter = New StreamWriter("\\laurent\d\laurent.txt", True)
            FichierScores.WriteLine(Now & Chr(9) & Prénom.Text & Chr(9) & Liste_tables.Text & Chr(9) & Note.Text)
            FichierScores.Close()
            Application.Restart()
            Call Disable(Me)
        End If
    End Sub

    Sub choix_table()
        Select Case Liste_tables.Text
            Case "Table de 1"
                a = 1
            Case "Table de 2"
                a = 2
            Case "Table de 3"
                a = 3
            Case "Table de 4"
                a = 4
            Case "Table de 5"
                a = 5
            Case "Table de 6"
                a = 6
            Case "Table de 7"
                a = 7
            Case "Table de 8"
                a = 8
            Case "Table de 9"
                a = 9
        End Select
    End Sub

    Private Sub Départ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Départ.Click
        Call Disable(Me)
        questions = 0
        score = 0
        Résultat.Visible = True
        RectangleShape1.Visible = True
        Label_score.Visible = True
        choix_table()
        aleatoire()
        question.Text = a & " X " & b & " = "
        Bonne_réponse.Text = ""
        Résultat.Text = ""
        Commentaire.Text = ""
        Nombre.Enabled = False
        Liste_tables.Enabled = False
        Prénom.Enabled = False
        Départ.Enabled = False
        Timer2.Enabled = True
        Décompteur.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Résultat.TextChanged
        If Résultat.Text = (a * b).ToString() Then
            Commentaire.Text = "Bravo " & Prénom.Text & " !!!"
            Résultat.BackColor = Color.Lime
            score = score + 1
            Note.Text = score.ToString() & " / " & questions
            Timer1.Enabled = True
            Timer1.Interval = 2000
            Timer2.Enabled = False
            Décompteur.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Résultat.BackColor = Color.LightPink
        Résultat.Text = ""
        Commentaire.Text = ""
        Bonne_réponse.Text = ""
        aleatoire()
        question.Text = a & " X " & b & " = "
        chrono.Text = 10
        Timer2.Enabled = True
        Décompteur.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Commentaire.Text = "Trop tard " & Prénom.Text & " !!!"
        Résultat.Enabled = False
        Bonne_réponse.Text = a & " X " & b & " = " & (a * b).ToString()
        Note.Text = score.ToString() & " / " & questions
        Timer1.Interval = 4000
        Timer1.Enabled = True
        Timer2.Enabled = False
        Résultat.Text = ""
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Décompteur.Tick
        If chrono.Text <> 0 Then
            chrono.Text = chrono.Text - 1
        Else
            Décompteur.Enabled = False
        End If
    End Sub

    Private Sub Prénom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prénom.TextChanged
        If Prénom.Text = "" Then
            Départ.Enabled = False
        Else
            Départ.Enabled = True
        End If
    End Sub

    Private Sub Liste_tables_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Liste_tables.SelectedIndexChanged
        Nombre.Select()
    End Sub
End Class
