using System;
using System.Windows.Forms;
using DevExpress.XtraSpellChecker;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.memoEdit1.Text = "Wie er so dahin gieng und immer ein Bein vor das andere setzte, kam ihm ein Reiter in die Augen, der frisch und frohlich auf einem muntern Pferd vorbei trabte.";
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            spellChecker1.Check(memoEdit1);
        }
        #region #formload
        private void Form1_Load(object sender, EventArgs e) {
            spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType;
            spellChecker1.Check(memoEdit1);
        }
        #endregion #formload
    }
}