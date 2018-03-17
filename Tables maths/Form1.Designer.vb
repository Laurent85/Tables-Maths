<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.question = New System.Windows.Forms.Label()
        Me.Liste_tables = New System.Windows.Forms.ComboBox()
        Me.Départ = New System.Windows.Forms.Button()
        Me.Résultat = New System.Windows.Forms.TextBox()
        Me.Commentaire = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Bonne_réponse = New System.Windows.Forms.Label()
        Me.Note = New System.Windows.Forms.Label()
        Me.chrono = New System.Windows.Forms.Label()
        Me.Décompteur = New System.Windows.Forms.Timer(Me.components)
        Me.Prénom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label_score = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'question
        '
        Me.question.AutoSize = True
        Me.question.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.question.ForeColor = System.Drawing.Color.Blue
        Me.question.Location = New System.Drawing.Point(185, 68)
        Me.question.Name = "question"
        Me.question.Size = New System.Drawing.Size(131, 31)
        Me.question.TabIndex = 0
        Me.question.Text = "Question"
        '
        'Liste_tables
        '
        Me.Liste_tables.FormattingEnabled = True
        Me.Liste_tables.Items.AddRange(New Object() {"Table de 1", "Table de 2", "Table de 3", "Table de 4", "Table de 5", "Table de 6", "Table de 7", "Table de 8", "Table de 9"})
        Me.Liste_tables.Location = New System.Drawing.Point(32, 78)
        Me.Liste_tables.Name = "Liste_tables"
        Me.Liste_tables.Size = New System.Drawing.Size(121, 21)
        Me.Liste_tables.TabIndex = 1
        '
        'Départ
        '
        Me.Départ.Location = New System.Drawing.Point(32, 169)
        Me.Départ.Name = "Départ"
        Me.Départ.Size = New System.Drawing.Size(75, 23)
        Me.Départ.TabIndex = 2
        Me.Départ.Text = "Départ"
        Me.Départ.UseVisualStyleBackColor = True
        '
        'Résultat
        '
        Me.Résultat.BackColor = System.Drawing.Color.LightPink
        Me.Résultat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Résultat.Location = New System.Drawing.Point(312, 72)
        Me.Résultat.Name = "Résultat"
        Me.Résultat.Size = New System.Drawing.Size(76, 29)
        Me.Résultat.TabIndex = 4
        Me.Résultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Commentaire
        '
        Me.Commentaire.AutoSize = True
        Me.Commentaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Commentaire.ForeColor = System.Drawing.Color.Green
        Me.Commentaire.Location = New System.Drawing.Point(215, 120)
        Me.Commentaire.Name = "Commentaire"
        Me.Commentaire.Size = New System.Drawing.Size(134, 24)
        Me.Commentaire.TabIndex = 5
        Me.Commentaire.Text = "Commentaire"
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'Bonne_réponse
        '
        Me.Bonne_réponse.AutoSize = True
        Me.Bonne_réponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bonne_réponse.ForeColor = System.Drawing.Color.Red
        Me.Bonne_réponse.Location = New System.Drawing.Point(229, 153)
        Me.Bonne_réponse.Name = "Bonne_réponse"
        Me.Bonne_réponse.Size = New System.Drawing.Size(159, 24)
        Me.Bonne_réponse.TabIndex = 6
        Me.Bonne_réponse.Text = "Bonne_réponse"
        '
        'Note
        '
        Me.Note.AutoSize = True
        Me.Note.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Note.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Note.Location = New System.Drawing.Point(216, 28)
        Me.Note.Name = "Note"
        Me.Note.Size = New System.Drawing.Size(42, 17)
        Me.Note.TabIndex = 7
        Me.Note.Text = "Note"
        '
        'chrono
        '
        Me.chrono.AutoSize = True
        Me.chrono.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chrono.ForeColor = System.Drawing.Color.MediumOrchid
        Me.chrono.Location = New System.Drawing.Point(323, 16)
        Me.chrono.Name = "chrono"
        Me.chrono.Size = New System.Drawing.Size(127, 39)
        Me.chrono.TabIndex = 8
        Me.chrono.Text = "chrono"
        '
        'Décompteur
        '
        Me.Décompteur.Interval = 1000
        '
        'Prénom
        '
        Me.Prénom.Location = New System.Drawing.Point(32, 28)
        Me.Prénom.Name = "Prénom"
        Me.Prénom.Size = New System.Drawing.Size(120, 20)
        Me.Prénom.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(40, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Ecris ton prénom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(40, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Choisis ta table"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(429, 204)
        Me.ShapeContainer1.TabIndex = 12
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.SlateBlue
        Me.RectangleShape1.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.RectangleShape1.Location = New System.Drawing.Point(205, 25)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(70, 24)
        '
        'Label_score
        '
        Me.Label_score.AutoSize = True
        Me.Label_score.Location = New System.Drawing.Point(216, 9)
        Me.Label_score.Name = "Label_score"
        Me.Label_score.Size = New System.Drawing.Size(35, 13)
        Me.Label_score.TabIndex = 13
        Me.Label_score.Text = "Score"
        '
        'Nombre
        '
        Me.Nombre.FormattingEnabled = True
        Me.Nombre.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "80", "90", "100"})
        Me.Nombre.Location = New System.Drawing.Point(32, 125)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(120, 21)
        Me.Nombre.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(29, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nombre de questions"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 204)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Label_score)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Prénom)
        Me.Controls.Add(Me.chrono)
        Me.Controls.Add(Me.Note)
        Me.Controls.Add(Me.Bonne_réponse)
        Me.Controls.Add(Me.Commentaire)
        Me.Controls.Add(Me.Résultat)
        Me.Controls.Add(Me.Départ)
        Me.Controls.Add(Me.Liste_tables)
        Me.Controls.Add(Me.question)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Tables de multiplication"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents question As System.Windows.Forms.Label
    Friend WithEvents Liste_tables As System.Windows.Forms.ComboBox
    Friend WithEvents Départ As System.Windows.Forms.Button
    Friend WithEvents Résultat As System.Windows.Forms.TextBox
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents Commentaire As System.Windows.Forms.Label
    Public WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Bonne_réponse As System.Windows.Forms.Label
    Friend WithEvents Note As System.Windows.Forms.Label
    Friend WithEvents chrono As System.Windows.Forms.Label
    Friend WithEvents Décompteur As System.Windows.Forms.Timer
    Friend WithEvents Prénom As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label_score As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
