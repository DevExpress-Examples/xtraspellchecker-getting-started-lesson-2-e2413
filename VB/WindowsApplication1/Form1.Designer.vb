Namespace WindowsApplication1
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim spellCheckerOpenOfficeDictionary1 As New DevExpress.XtraSpellChecker.SpellCheckerOpenOfficeDictionary()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim spellCheckerCustomDictionary1 As New DevExpress.XtraSpellChecker.SpellCheckerCustomDictionary()
            Dim optionsSpelling1 As New DevExpress.XtraSpellChecker.OptionsSpelling()
            Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' spellChecker1
            ' 
            Me.spellChecker1.Culture = New System.Globalization.CultureInfo("de-DE")
            spellCheckerOpenOfficeDictionary1.AlphabetPath = ""
            spellCheckerOpenOfficeDictionary1.CacheKey = Nothing
            spellCheckerOpenOfficeDictionary1.Culture = New System.Globalization.CultureInfo("de-DE")
            spellCheckerOpenOfficeDictionary1.DictionaryPath = "Dictionaries\de_DE.dic"
            spellCheckerOpenOfficeDictionary1.Encoding = (CType(resources.GetObject("spellCheckerOpenOfficeDictionary1.Encoding"), System.Text.Encoding))
            spellCheckerOpenOfficeDictionary1.GrammarPath = "Dictionaries\de_DE.aff"
            spellCheckerCustomDictionary1.AlphabetPath = "Dictionaries\GermanAlphabet.txt"
            spellCheckerCustomDictionary1.CacheKey = Nothing
            spellCheckerCustomDictionary1.Culture = New System.Globalization.CultureInfo("de-DE")
            spellCheckerCustomDictionary1.DictionaryPath = "Dictionaries\CustomGermanDictionary.txt"
            spellCheckerCustomDictionary1.Encoding = (CType(resources.GetObject("spellCheckerCustomDictionary1.Encoding"), System.Text.Encoding))
            Me.spellChecker1.Dictionaries.Add(spellCheckerOpenOfficeDictionary1)
            Me.spellChecker1.Dictionaries.Add(spellCheckerCustomDictionary1)
            Me.spellChecker1.ParentContainer = Nothing
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Location = New System.Drawing.Point(25, 12)
            Me.memoEdit1.Name = "memoEdit1"
            Me.spellChecker1.SetShowSpellCheckMenu(Me.memoEdit1, True)
            Me.memoEdit1.Size = New System.Drawing.Size(272, 227)
            Me.spellChecker1.SetSpellCheckerOptions(Me.memoEdit1, optionsSpelling1)
            Me.memoEdit1.TabIndex = 0
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(206, 261)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(91, 23)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "Check spelling"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(325, 296)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.memoEdit1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace

