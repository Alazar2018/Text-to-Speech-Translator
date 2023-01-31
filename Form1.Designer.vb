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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtInput = New System.Windows.Forms.RichTextBox()
        Me.btnSpeak = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cboVoices = New System.Windows.Forms.ComboBox()
        Me.tbVolume = New System.Windows.Forms.TrackBar()
        Me.tbRate = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCustomize = New System.Windows.Forms.Button()
        Me.rbMale = New System.Windows.Forms.CheckBox()
        Me.rbFemale = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbLanguage = New System.Windows.Forms.ComboBox()
        Me.cbSyncAudio = New System.Windows.Forms.CheckBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.wav = New System.Windows.Forms.CheckBox()
        Me.mp3 = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.tbVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(187, 95)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(438, 97)
        Me.txtInput.TabIndex = 0
        Me.txtInput.Text = ""
        '
        'btnSpeak
        '
        Me.btnSpeak.BackColor = System.Drawing.Color.Green
        Me.btnSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpeak.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSpeak.Location = New System.Drawing.Point(220, 363)
        Me.btnSpeak.Name = "btnSpeak"
        Me.btnSpeak.Size = New System.Drawing.Size(75, 23)
        Me.btnSpeak.TabIndex = 1
        Me.btnSpeak.Text = "Speak"
        Me.btnSpeak.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnSave.Location = New System.Drawing.Point(550, 363)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cboVoices
        '
        Me.cboVoices.FormattingEnabled = True
        Me.cboVoices.Location = New System.Drawing.Point(284, 236)
        Me.cboVoices.Name = "cboVoices"
        Me.cboVoices.Size = New System.Drawing.Size(160, 21)
        Me.cboVoices.TabIndex = 3
        '
        'tbVolume
        '
        Me.tbVolume.Location = New System.Drawing.Point(269, 284)
        Me.tbVolume.Minimum = -10
        Me.tbVolume.Name = "tbVolume"
        Me.tbVolume.Size = New System.Drawing.Size(104, 45)
        Me.tbVolume.TabIndex = 4
        '
        'tbRate
        '
        Me.tbRate.Location = New System.Drawing.Point(501, 284)
        Me.tbRate.Minimum = -10
        Me.tbRate.Name = "tbRate"
        Me.tbRate.Size = New System.Drawing.Size(104, 45)
        Me.tbRate.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(339, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Voice"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Volume"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(394, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Speaking Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(238, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(346, 28)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "TEXT -TO-SPEECH  TRANSLATER"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCustomize
        '
        Me.btnCustomize.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCustomize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustomize.Location = New System.Drawing.Point(342, 363)
        Me.btnCustomize.Name = "btnCustomize"
        Me.btnCustomize.Size = New System.Drawing.Size(75, 23)
        Me.btnCustomize.TabIndex = 10
        Me.btnCustomize.Text = "Customize"
        Me.btnCustomize.UseVisualStyleBackColor = False
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(187, 215)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(49, 17)
        Me.rbMale.TabIndex = 11
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(187, 238)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(60, 17)
        Me.rbFemale.TabIndex = 12
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(529, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Language"
        '
        'cbLanguage
        '
        Me.cbLanguage.FormattingEnabled = True
        Me.cbLanguage.Location = New System.Drawing.Point(492, 234)
        Me.cbLanguage.Name = "cbLanguage"
        Me.cbLanguage.Size = New System.Drawing.Size(121, 21)
        Me.cbLanguage.TabIndex = 14
        '
        'cbSyncAudio
        '
        Me.cbSyncAudio.AutoSize = True
        Me.cbSyncAudio.Location = New System.Drawing.Point(187, 262)
        Me.cbSyncAudio.Name = "cbSyncAudio"
        Me.cbSyncAudio.Size = New System.Drawing.Size(80, 17)
        Me.cbSyncAudio.TabIndex = 15
        Me.cbSyncAudio.Text = "Sync Audio"
        Me.cbSyncAudio.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.DarkRed
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStop.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnStop.Location = New System.Drawing.Point(444, 363)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 16
        Me.btnStop.Text = "Cancel"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'wav
        '
        Me.wav.AutoSize = True
        Me.wav.Location = New System.Drawing.Point(632, 354)
        Me.wav.Name = "wav"
        Me.wav.Size = New System.Drawing.Size(49, 17)
        Me.wav.TabIndex = 17
        Me.wav.Text = "Wav"
        Me.wav.UseVisualStyleBackColor = True
        '
        'mp3
        '
        Me.mp3.AutoSize = True
        Me.mp3.Location = New System.Drawing.Point(632, 378)
        Me.mp3.Name = "mp3"
        Me.mp3.Size = New System.Drawing.Size(47, 17)
        Me.mp3.TabIndex = 18
        Me.mp3.Text = "Mp3"
        Me.mp3.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mp3)
        Me.Controls.Add(Me.wav)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.cbSyncAudio)
        Me.Controls.Add(Me.cbLanguage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.btnCustomize)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbRate)
        Me.Controls.Add(Me.tbVolume)
        Me.Controls.Add(Me.cboVoices)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSpeak)
        Me.Controls.Add(Me.txtInput)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text-to-Speech"
        CType(Me.tbVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As RichTextBox
    Friend WithEvents btnSpeak As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cboVoices As ComboBox
    Friend WithEvents tbVolume As TrackBar
    Friend WithEvents tbRate As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCustomize As Button
    Friend WithEvents rbMale As CheckBox
    Friend WithEvents rbFemale As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbLanguage As ComboBox
    Friend WithEvents cbSyncAudio As CheckBox
    Friend WithEvents btnStop As Button
    Friend WithEvents wav As CheckBox
    Friend WithEvents mp3 As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
