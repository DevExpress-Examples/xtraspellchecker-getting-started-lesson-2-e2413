using System;
using System.Windows.Forms;
using DevExpress.XtraSpellChecker;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            spellChecker1.Check(memoEdit1);
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Uncomment these lines to enable the 'check as you type' mode.
            // spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType;
            // spellChecker1.Check(memoEdit1);
        }
    }
}