namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraSpellChecker.SpellCheckerOpenOfficeDictionary spellCheckerOpenOfficeDictionary1 = new DevExpress.XtraSpellChecker.SpellCheckerOpenOfficeDictionary();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraSpellChecker.SpellCheckerCustomDictionary spellCheckerCustomDictionary1 = new DevExpress.XtraSpellChecker.SpellCheckerCustomDictionary();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling1 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            this.spellChecker1 = new DevExpress.XtraSpellChecker.SpellChecker();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spellChecker1
            // 
            this.spellChecker1.Culture = new System.Globalization.CultureInfo("de-DE");
            spellCheckerOpenOfficeDictionary1.AlphabetPath = "";
            spellCheckerOpenOfficeDictionary1.CacheKey = null;
            spellCheckerOpenOfficeDictionary1.Culture = new System.Globalization.CultureInfo("de-DE");
            spellCheckerOpenOfficeDictionary1.DictionaryPath = "Dictionaries\\de_DE.dic";
            spellCheckerOpenOfficeDictionary1.Encoding = ((System.Text.Encoding)(resources.GetObject("spellCheckerOpenOfficeDictionary1.Encoding")));
            spellCheckerOpenOfficeDictionary1.GrammarPath = "Dictionaries\\de_DE.aff";
            spellCheckerCustomDictionary1.AlphabetPath = "Dictionaries\\GermanAlphabet.txt";
            spellCheckerCustomDictionary1.CacheKey = null;
            spellCheckerCustomDictionary1.Culture = new System.Globalization.CultureInfo("de-DE");
            spellCheckerCustomDictionary1.DictionaryPath = "Dictionaries\\CustomGermanDictionary.txt";
            spellCheckerCustomDictionary1.Encoding = ((System.Text.Encoding)(resources.GetObject("spellCheckerCustomDictionary1.Encoding")));
            this.spellChecker1.Dictionaries.Add(spellCheckerOpenOfficeDictionary1);
            this.spellChecker1.Dictionaries.Add(spellCheckerCustomDictionary1);
            this.spellChecker1.ParentContainer = null;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(25, 12);
            this.memoEdit1.Name = "memoEdit1";
            this.spellChecker1.SetShowSpellCheckMenu(this.memoEdit1, true);
            this.memoEdit1.Size = new System.Drawing.Size(272, 227);
            this.spellChecker1.SetSpellCheckerOptions(this.memoEdit1, optionsSpelling1);
            this.memoEdit1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(206, 261);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(91, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Check spelling";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 296);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.memoEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraSpellChecker.SpellChecker spellChecker1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

