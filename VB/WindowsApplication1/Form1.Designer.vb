Imports Microsoft.VisualBasic
Imports System
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
			Dim spellCheckerISpellDictionary2 As New DevExpress.XtraSpellChecker.SpellCheckerISpellDictionary()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim spellCheckerCustomDictionary2 As New DevExpress.XtraSpellChecker.SpellCheckerCustomDictionary()
			Dim optionsSpelling2 As New DevExpress.XtraSpellChecker.OptionsSpelling()
			Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker()
			Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' spellChecker1
			' 
			Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
			spellCheckerISpellDictionary2.AlphabetPath = "Dictionaries\EnglishAlphabet." & "txt"
			spellCheckerISpellDictionary2.CacheKey = Nothing
			spellCheckerISpellDictionary2.Culture = New System.Globalization.CultureInfo("en-US")
			spellCheckerISpellDictionary2.DictionaryPath = "Dictionaries\american.xlg"
			spellCheckerISpellDictionary2.Encoding = (CType(resources.GetObject("spellCheckerISpellDictionary2.Encoding"), System.Text.Encoding))
			spellCheckerISpellDictionary2.GrammarPath = "Dictionaries\english.aff"
			spellCheckerCustomDictionary2.AlphabetPath = "Dictionaries\EnglishAlphabet." & "txt"
			spellCheckerCustomDictionary2.CacheKey = Nothing
			spellCheckerCustomDictionary2.Culture = New System.Globalization.CultureInfo("en-US")
			spellCheckerCustomDictionary2.DictionaryPath = "Dictionaries\CustomEnglish.di" & "c"
			spellCheckerCustomDictionary2.Encoding = (CType(resources.GetObject("spellCheckerCustomDictionary2.Encoding"), System.Text.Encoding))
			Me.spellChecker1.Dictionaries.Add(spellCheckerISpellDictionary2)
			Me.spellChecker1.Dictionaries.Add(spellCheckerCustomDictionary2)
			Me.spellChecker1.ParentContainer = Nothing
			' 
			' memoEdit1
			' 
			Me.memoEdit1.Location = New System.Drawing.Point(25, 12)
			Me.memoEdit1.Name = "memoEdit1"
			Me.spellChecker1.SetShowSpellCheckMenu(Me.memoEdit1, True)
			Me.memoEdit1.Size = New System.Drawing.Size(272, 227)
			Me.spellChecker1.SetSpellCheckerOptions(Me.memoEdit1, optionsSpelling2)
			Me.memoEdit1.TabIndex = 0
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(222, 261)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "simpleButton1"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(325, 296)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.memoEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
		Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

