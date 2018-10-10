namespace BasicDistribution
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loadFile = new System.Windows.Forms.Button();
            this.textFile = new System.Windows.Forms.TextBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.frequencyDistribution = new System.Windows.Forms.Button();
            this.textDistribution = new System.Windows.Forms.TextBox();
            this.distributionLabel = new System.Windows.Forms.Label();
            this.distributionOn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadFile
            // 
            resources.ApplyResources(this.loadFile, "loadFile");
            this.loadFile.BackColor = System.Drawing.Color.Silver;
            this.loadFile.Name = "loadFile";
            this.loadFile.UseVisualStyleBackColor = false;
            this.loadFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // textFile
            // 
            resources.ApplyResources(this.textFile, "textFile");
            this.textFile.Name = "textFile";
            // 
            // fileLabel
            // 
            resources.ApplyResources(this.fileLabel, "fileLabel");
            this.fileLabel.Name = "fileLabel";
            // 
            // frequencyDistribution
            // 
            resources.ApplyResources(this.frequencyDistribution, "frequencyDistribution");
            this.frequencyDistribution.BackColor = System.Drawing.Color.Silver;
            this.frequencyDistribution.Name = "frequencyDistribution";
            this.frequencyDistribution.UseVisualStyleBackColor = false;
            this.frequencyDistribution.Click += new System.EventHandler(this.button2_Click);
            // 
            // textDistribution
            // 
            resources.ApplyResources(this.textDistribution, "textDistribution");
            this.textDistribution.Name = "textDistribution";
            // 
            // distributionLabel
            // 
            resources.ApplyResources(this.distributionLabel, "distributionLabel");
            this.distributionLabel.Name = "distributionLabel";
            // 
            // distributionOn
            // 
            resources.ApplyResources(this.distributionOn, "distributionOn");
            this.distributionOn.FormattingEnabled = true;
            this.distributionOn.Items.AddRange(new object[] {
            resources.GetString("distributionOn.Items"),
            resources.GetString("distributionOn.Items1"),
            resources.GetString("distributionOn.Items2")});
            this.distributionOn.Name = "distributionOn";
            this.distributionOn.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.distributionOn);
            this.Controls.Add(this.distributionLabel);
            this.Controls.Add(this.textDistribution);
            this.Controls.Add(this.frequencyDistribution);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.loadFile);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button frequencyDistribution;
        private System.Windows.Forms.TextBox textDistribution;
        private System.Windows.Forms.Label distributionLabel;
        private System.Windows.Forms.ComboBox distributionOn;
        private System.Windows.Forms.Label label1;
    }
}

