<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.reclama = New System.Windows.Forms.TextBox()
        Me.pornire = New System.Windows.Forms.PictureBox()
        Me.efect_inceput = New System.Windows.Forms.Timer(Me.components)
        Me.oprire = New System.Windows.Forms.PictureBox()
        Me.scurtatura = New System.Windows.Forms.Timer(Me.components)
        Me.buton_informatii = New System.Windows.Forms.Button()
        Me.buton_credite = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cronometru_interval = New System.Windows.Forms.NumericUpDown()
        Me.intarziere = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.efect = New System.Windows.Forms.ComboBox()
        Me.avertisment = New System.Windows.Forms.Timer(Me.components)
        Me.efect_sfarsit = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pornire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oprire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cronometru_interval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'reclama
        '
        Me.reclama.Location = New System.Drawing.Point(0, 0)
        Me.reclama.Name = "reclama"
        Me.reclama.Size = New System.Drawing.Size(301, 20)
        Me.reclama.TabIndex = 0
        Me.reclama.Text = "Portable Bank, Download: megaupload.C 0M/?d=HO4HU61C"
        '
        'pornire
        '
        Me.pornire.BackgroundImage = Global.RuneScape_Advertiser.My.Resources.Resources.start1
        Me.pornire.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pornire.Location = New System.Drawing.Point(0, 20)
        Me.pornire.Name = "pornire"
        Me.pornire.Size = New System.Drawing.Size(160, 151)
        Me.pornire.TabIndex = 1
        Me.pornire.TabStop = False
        '
        'efect_inceput
        '
        '
        'oprire
        '
        Me.oprire.BackgroundImage = Global.RuneScape_Advertiser.My.Resources.Resources.stop1
        Me.oprire.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oprire.Location = New System.Drawing.Point(0, 20)
        Me.oprire.Name = "oprire"
        Me.oprire.Size = New System.Drawing.Size(160, 151)
        Me.oprire.TabIndex = 2
        Me.oprire.TabStop = False
        Me.oprire.Visible = False
        '
        'scurtatura
        '
        '
        'buton_informatii
        '
        Me.buton_informatii.Location = New System.Drawing.Point(166, 145)
        Me.buton_informatii.Name = "buton_informatii"
        Me.buton_informatii.Size = New System.Drawing.Size(60, 23)
        Me.buton_informatii.TabIndex = 3
        Me.buton_informatii.Text = "Info"
        Me.buton_informatii.UseVisualStyleBackColor = True
        '
        'buton_credite
        '
        Me.buton_credite.Location = New System.Drawing.Point(234, 145)
        Me.buton_credite.Name = "buton_credite"
        Me.buton_credite.Size = New System.Drawing.Size(60, 23)
        Me.buton_credite.TabIndex = 4
        Me.buton_credite.Text = "Credits"
        Me.buton_credite.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cronometru_interval)
        Me.GroupBox1.Location = New System.Drawing.Point(166, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 50)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Interval"
        '
        'cronometru_interval
        '
        Me.cronometru_interval.Location = New System.Drawing.Point(6, 19)
        Me.cronometru_interval.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.cronometru_interval.Name = "cronometru_interval"
        Me.cronometru_interval.Size = New System.Drawing.Size(116, 20)
        Me.cronometru_interval.TabIndex = 0
        Me.cronometru_interval.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'intarziere
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.efect)
        Me.GroupBox2.Location = New System.Drawing.Point(166, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 50)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Effects"
        '
        'efect
        '
        Me.efect.FormattingEnabled = True
        Me.efect.Items.AddRange(New Object() {"", "[ [                   ] ]", ">>>             <<<", "===                 ==="})
        Me.efect.Location = New System.Drawing.Point(6, 19)
        Me.efect.Name = "efect"
        Me.efect.Size = New System.Drawing.Size(116, 21)
        Me.efect.TabIndex = 0
        '
        'avertisment
        '
        '
        'efect_sfarsit
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 170)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.buton_credite)
        Me.Controls.Add(Me.buton_informatii)
        Me.Controls.Add(Me.oprire)
        Me.Controls.Add(Me.pornire)
        Me.Controls.Add(Me.reclama)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RuneScape Advertiser"
        CType(Me.pornire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oprire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.cronometru_interval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents reclama As System.Windows.Forms.TextBox
    Friend WithEvents pornire As System.Windows.Forms.PictureBox
    Friend WithEvents efect_inceput As System.Windows.Forms.Timer
    Friend WithEvents oprire As System.Windows.Forms.PictureBox
    Friend WithEvents scurtatura As System.Windows.Forms.Timer
    Friend WithEvents buton_informatii As System.Windows.Forms.Button
    Friend WithEvents buton_credite As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cronometru_interval As System.Windows.Forms.NumericUpDown
    Friend WithEvents intarziere As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents efect As System.Windows.Forms.ComboBox
    Friend WithEvents avertisment As System.Windows.Forms.Timer
    Friend WithEvents efect_sfarsit As System.Windows.Forms.Timer

End Class
