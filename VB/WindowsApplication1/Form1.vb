Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraSpellChecker

Namespace WindowsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            Me.memoEdit1.Text = "Wie er so dahin gieng und immer ein Bein vor das andere setzte, kam ihm ein Reiter in die Augen, der frisch und frohlich auf einem muntern Pferd vorbei trabte."
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            spellChecker1.Check(memoEdit1)
        End Sub
        #Region "#formload"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType
            spellChecker1.Check(memoEdit1)
        End Sub
        #End Region ' #formload
    End Class
End Namespace