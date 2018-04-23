Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraSpellChecker

Namespace WindowsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            spellChecker1.Check(memoEdit1)
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Uncomment these lines to enable the 'check as you type' mode.
            ' spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType;
            ' spellChecker1.Check(memoEdit1);
        End Sub
    End Class
End Namespace