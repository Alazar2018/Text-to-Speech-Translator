Imports System.Collections.ObjectModel
Imports System.Speech.AudioFormat

Imports System.Speech.Synthesis


Public Class Form1


    Private synth As SpeechSynthesizer
    Private prompt As Prompt
    Private promptBuilder As PromptBuilder
    Private _selectedGender As String = ""
    Private _syncAudio As String = ""
    Private _selectedLanguage As String = ""


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the SpeechSynthesizer and PromptBuilder objects
        synth = New SpeechSynthesizer()
        promptBuilder = New PromptBuilder()
        PopulateLanguageList()
        ' Populate the list of available voices

        ToolTip1.SetToolTip(Me, "")

    End Sub

    Private Sub btnSpeak_Click(sender As Object, e As EventArgs) Handles btnSpeak.Click
        ' Clear any existing prompts
        promptBuilder.ClearContent()
        If String.IsNullOrEmpty(txtInput.Text) Then
            ' Display a pop-up message
            MessageBox.Show("Please enter some text to be read aloud.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If cbSyncAudio.Checked Then
                ' Synchronize audio is enabled
                SynchronizeAudio()
            Else
                ' Synchronize audio is not enabled

                Dim gender As String = _selectedGender
                Dim language As String = cbLanguage.SelectedItem.ToString()

                ' Populate the voice dropdown list
                PopulateVoiceList(gender, language)
                Try
                    Dim voice As String
                    If cboVoices.SelectedIndex <> -1 Then
                        voice = cboVoices.SelectedItem.ToString()
                    Else
                        Throw New Exception("No voice selected")
                    End If
                    ' Set the speaking rate, pitch, and voice based on user selections
                    synth.Rate = tbRate.Value
                    synth.Volume = tbVolume.Value
                    synth.SelectVoice(voice)

                    ' Add the text to be read aloud to the prompt builder
                    synth.Speak(txtInput.Text)
                Catch ex As Exception
                    ' An error occurred
                    Dim message As String = "No voice found for selected gender and language"
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ' Reset the gender and language selection
                    _selectedGender = ""
                    cbLanguage.SelectedIndex = -1
                    cboVoices.SelectedIndex = -1
                    cboVoices.Items.Clear()
                    PopulateVoiceList(gender, language)
                    ' Clear the gender checkboxes
                    rbFemale.Checked = False
                    rbMale.Checked = False
                End Try
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If mp3.Checked Then
            Save("mp3")
        ElseIf mp3.Checked Then
            wav.Checked = False
            Save("wav")
        End If



    End Sub
    Private Sub CustomizeForm()
        ' Show a ColorDialog to allow the user to select a new form background color
        Dim colorDialog As New ColorDialog()

        If colorDialog.ShowDialog() = DialogResult.OK Then

            ' Set the form's background color to the selected color
            Me.BackColor = colorDialog.Color
        End If

        ' Show a FontDialog to allow the user to select a new font for the input text
        Dim fontDialog As New FontDialog()
        If fontDialog.ShowDialog() = DialogResult.OK Then
            ' Set the font of the input text to the selected font
            txtInput.Font = fontDialog.Font
        End If
        Dim textColorDialog As New ColorDialog()
        If textColorDialog.ShowDialog() = DialogResult.OK Then
            ' Set the color of the input text to the selected color
            txtInput.ForeColor = textColorDialog.Color
        End If

        ' Show a ColorDialog to allow the user to select a new color for the speak button
        Dim speakColorDialog As New ColorDialog()
        If speakColorDialog.ShowDialog() = DialogResult.OK Then
            ' Set the color of the speak button to the selected color
            btnSpeak.BackColor = speakColorDialog.Color
        End If
        Dim speakFontDialog As New FontDialog()
        If speakFontDialog.ShowDialog() = DialogResult.OK Then
            ' Set the font of the speak button to the selected font
            btnSpeak.Font = speakFontDialog.Font
        End If
        Dim speakTextColorDialog As New ColorDialog()
        If speakTextColorDialog.ShowDialog() = DialogResult.OK Then
            ' Set the color of the speak button text to the selected color
            btnSpeak.ForeColor = speakTextColorDialog.Color
        End If

        ' Show a ColorDialog to allow the user to select a new color for the cancel button
        Dim cancelColorDialog As New ColorDialog()
        If cancelColorDialog.ShowDialog() = DialogResult.OK Then
            ' Set the color of the cancel button to the selected color
            btnStop.BackColor = cancelColorDialog.Color
        End If
        Dim cancelFontDialog As New FontDialog()
        If cancelFontDialog.ShowDialog() = DialogResult.OK Then
            ' Set the font of the cancel button to the selected font
            btnStop.Font = cancelFontDialog.Font
        End If
        Dim cancelTextColorDialog As New ColorDialog()
        If cancelTextColorDialog.ShowDialog() = DialogResult.OK Then
            ' Set the color of the cancel button text to the selected color
            btnStop.ForeColor = cancelTextColorDialog.Color
        End If

        ' Show a ColorDialog to allow the user to select a new color for the customize button
        Dim customizeColorDialog As New ColorDialog()
        If customizeColorDialog.ShowDialog() = DialogResult.OK Then
            ' Set the color of the customize button to the selected color
            btnCustomize.BackColor = customizeColorDialog.Color
        End If
        Dim customizeFontDialog As New FontDialog()
        If customizeFontDialog.ShowDialog() = DialogResult.OK Then
            ' Set the font of the customize button to the selected font
            btnCustomize.Font = customizeFontDialog.Font
        End If
        Dim customizeTextColorDialog As New ColorDialog()
        If customizeTextColorDialog.ShowDialog() = DialogResult.OK Then
            ' Set the color of the customize button text to the selected color
            btnCustomize.ForeColor = customizeTextColorDialog.Color
        End If

        ' Show a ColorDialog to allow the user to select a new color for the save button
        Dim saveColorDialog As New ColorDialog()
        If saveColorDialog.ShowDialog() = DialogResult.OK Then
            ' Set the color of the save button to the selected color
            btnSave.BackColor = saveColorDialog.Color
        End If
        Dim saveFontDialog As New FontDialog()
        If saveFontDialog.ShowDialog() = DialogResult.OK Then
            ' Set the font of the save button to the selected font
            btnSave.Font = saveFontDialog.Font
        End If
        Dim saveTextColorDialog As New ColorDialog()
        If saveTextColorDialog.ShowDialog() = DialogResult.OK Then
            ' Set the color of the save button text to the selected color
            btnSave.ForeColor = saveTextColorDialog.Color
        End If
    End Sub


    Private Sub btnCustomize_Click(sender As Object, e As EventArgs) Handles btnCustomize.Click
        CustomizeForm()
    End Sub

    Private Sub rbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbFemale.CheckedChanged
        If rbFemale.Checked Then
            rbMale.Checked = False
            _selectedGender = "Female"
        End If
    End Sub

    Private Sub rbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbMale.CheckedChanged
        If rbMale.Checked Then
            rbFemale.Checked = False
            _selectedGender = "Male"
        End If
    End Sub

    Private Sub cbLanguage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLanguage.SelectedIndexChanged
        If cbLanguage.SelectedIndex <> -1 Then
            ' Set the selected language
            _selectedLanguage = cbLanguage.SelectedItem.ToString()

            ' Populate the voice dropdown list
            PopulateVoiceList(_selectedGender, _selectedLanguage)
        End If
    End Sub
    Private Sub PopulateVoiceList(gender As String, language As String)
        ' Get a list of available voices
        Dim voices As ReadOnlyCollection(Of InstalledVoice) = synth.GetInstalledVoices()

        ' Clear the voice dropdown list
        cboVoices.Items.Clear()

        ' Iterate through the list of voices
        For Each voice As InstalledVoice In voices
            ' Check if the voice is in the correct language and gender
            If voice.VoiceInfo.Culture.Name.ToLower() = language.ToLower() AndAlso
           voice.VoiceInfo.Gender.ToString().ToLower() = gender.ToLower() Then
                ' Add the voice to the dropdown list
                cboVoices.Items.Add(voice.VoiceInfo.Name)
            End If
        Next

        ' Check if the dropdown list has any items
        If cboVoices.Items.Count > 0 Then
            ' Select the first voice in the dropdown list
            cboVoices.SelectedIndex = 0
        End If
    End Sub

    Private Sub PopulateLanguageList()
        ' Get a list of available voices
        Dim voices As ReadOnlyCollection(Of InstalledVoice) = synth.GetInstalledVoices()

        ' Clear the language dropdown list
        cbLanguage.Items.Clear()

        ' Create a list to store the languages
        Dim languages As New List(Of String)

        ' Iterate through the list of voices
        For Each voice As InstalledVoice In voices
            ' Get the language of the voice
            Dim language As String = voice.VoiceInfo.Culture.Name

            ' Check if the language is not already in the list
            If Not languages.Contains(language) Then
                ' Add the language to the list
                languages.Add(language)
            End If
        Next

        ' Sort the list of languages
        languages.Sort()

        ' Add the languages to the dropdown list
        For Each language As String In languages
            cbLanguage.Items.Add(language)
        Next
    End Sub

    Private Sub SynchronizeAudio()
        ' Disable the synchronize audio checkbox
        cbSyncAudio.Enabled = False

        ' Clear the current selection
        txtInput.SelectionStart = 0
        txtInput.SelectionLength = 0

        ' Set the synchronize audio flag
        _syncAudio = True

        ' Set the speaking finished event handler


        AddHandler synth.SpeakProgress, AddressOf Synth_SpeakProgress
        AddHandler synth.SpeakCompleted, AddressOf Synth_SpeakCompleted
        ' Speak the text
        synth.SpeakAsync(txtInput.Text)
    End Sub

    Private Sub Synth_SpeakCompleted(sender As Object, e As SpeakCompletedEventArgs)
        ' Reset the synchronize audio flag
        txtInput.SelectAll()
        txtInput.SelectionColor = Color.Black
        _syncAudio = True
        If _syncAudio Then
            ' Check if the synth object is not paused or stopped
            If synth.State <> SynthesizerState.Paused And synth.State <> SynthesizerState.Ready Then
                ' Highlight the text being spoken

                txtInput.SelectAll()
                txtInput.SelectionColor = Color.Black

            End If
        End If

        ' Enable the synchronize audio checkbox
        cbSyncAudio.Enabled = True

    End Sub

    Private Sub Synth_SpeakProgress(sender As Object, e As SpeakProgressEventArgs)
        ' Check if synchronize audio is enabled
        If _syncAudio Then
            ' Check if the synth object is not paused or stopped
            If synth.State <> SynthesizerState.Paused And synth.State <> SynthesizerState.Ready Then
                ' Highlight the text being spoken
                txtInput.SelectionStart = e.CharacterPosition
                txtInput.SelectionLength = e.CharacterCount
                txtInput.Focus()
                txtInput.SelectionColor = Color.Red
                txtInput.SelectionStart = 0
                txtInput.SelectionLength = 0
            End If
        End If

    End Sub
    Private Sub Save(format As String)
        ' Show a SaveFileDialog to allow the user to specify the file name and location to save the audio output
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Audio Files|*.mp3;*.wav"
            If saveDialog.ShowDialog() = DialogResult.OK Then
                ' Save the audio output in the specified format to the selected file
                Dim synth As New SpeechSynthesizer()
                Select Case format
                    Case "mp3"
                        synth.SetOutputToWaveFile(saveDialog.FileName, New SpeechAudioFormatInfo(32000, AudioBitsPerSample.Sixteen, AudioChannel.Mono))
                    Case "wav"
                        synth.SetOutputToWaveFile(saveDialog.FileName, New SpeechAudioFormatInfo(32000, AudioBitsPerSample.Sixteen, AudioChannel.Mono))
                End Select
                synth.Speak(txtInput.Text)
                synth.SetOutputToDefaultAudioDevice()
            End If
            ' Display a message indicating that the file was saved successfully
            MessageBox.Show("Audio file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' An error occurred while saving the file
            MessageBox.Show("An error occurred while saving the audio file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        synth.SpeakAsyncCancelAll()
        txtInput.SelectAll()
        txtInput.SelectionColor = Color.Black
    End Sub

    Private Sub wav_CheckedChanged(sender As Object, e As EventArgs) Handles wav.CheckedChanged
        If wav.Checked Then
            mp3.Checked = False

        End If

    End Sub

    Private Sub mp3_CheckedChanged(sender As Object, e As EventArgs) Handles mp3.CheckedChanged
        If mp3.Checked Then
            wav.Checked = False

        End If
    End Sub


End Class
