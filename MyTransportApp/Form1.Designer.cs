namespace MyTransportApp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartortSuchleiste1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ZielortSuchleiste = new System.Windows.Forms.TextBox();
            this.SuchenButton1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StartortSuchleiste2 = new System.Windows.Forms.TextBox();
            this.SuchenButton2 = new System.Windows.Forms.Button();
            this.FahrplanAusgabe = new System.Windows.Forms.ListBox();
            this.AbfahrtstafelAusgabe = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FahrplanAusgabe);
            this.groupBox1.Controls.Add(this.SuchenButton1);
            this.groupBox1.Controls.Add(this.ZielortSuchleiste);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StartortSuchleiste1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fahrplan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Startort";
            // 
            // StartortSuchleiste1
            // 
            this.StartortSuchleiste1.Location = new System.Drawing.Point(7, 49);
            this.StartortSuchleiste1.Name = "StartortSuchleiste1";
            this.StartortSuchleiste1.Size = new System.Drawing.Size(165, 20);
            this.StartortSuchleiste1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zielort";
            // 
            // ZielortSuchleiste
            // 
            this.ZielortSuchleiste.Location = new System.Drawing.Point(7, 100);
            this.ZielortSuchleiste.Name = "ZielortSuchleiste";
            this.ZielortSuchleiste.Size = new System.Drawing.Size(165, 20);
            this.ZielortSuchleiste.TabIndex = 3;
            // 
            // SuchenButton1
            // 
            this.SuchenButton1.Location = new System.Drawing.Point(9, 136);
            this.SuchenButton1.Name = "SuchenButton1";
            this.SuchenButton1.Size = new System.Drawing.Size(75, 23);
            this.SuchenButton1.TabIndex = 4;
            this.SuchenButton1.Text = "Suchen";
            this.SuchenButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AbfahrtstafelAusgabe);
            this.groupBox2.Controls.Add(this.SuchenButton2);
            this.groupBox2.Controls.Add(this.StartortSuchleiste2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(434, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abfahrtstafel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Startort";
            // 
            // StartortSuchleiste2
            // 
            this.StartortSuchleiste2.Location = new System.Drawing.Point(7, 50);
            this.StartortSuchleiste2.Name = "StartortSuchleiste2";
            this.StartortSuchleiste2.Size = new System.Drawing.Size(163, 20);
            this.StartortSuchleiste2.TabIndex = 1;
            // 
            // SuchenButton2
            // 
            this.SuchenButton2.Location = new System.Drawing.Point(9, 76);
            this.SuchenButton2.Name = "SuchenButton2";
            this.SuchenButton2.Size = new System.Drawing.Size(75, 23);
            this.SuchenButton2.TabIndex = 2;
            this.SuchenButton2.Text = "Suchen";
            this.SuchenButton2.UseVisualStyleBackColor = true;
            // 
            // FahrplanAusgabe
            // 
            this.FahrplanAusgabe.FormattingEnabled = true;
            this.FahrplanAusgabe.Location = new System.Drawing.Point(7, 170);
            this.FahrplanAusgabe.Name = "FahrplanAusgabe";
            this.FahrplanAusgabe.Size = new System.Drawing.Size(381, 251);
            this.FahrplanAusgabe.TabIndex = 5;
            // 
            // AbfahrtstafelAusgabe
            // 
            this.AbfahrtstafelAusgabe.FormattingEnabled = true;
            this.AbfahrtstafelAusgabe.Location = new System.Drawing.Point(7, 122);
            this.AbfahrtstafelAusgabe.Name = "AbfahrtstafelAusgabe";
            this.AbfahrtstafelAusgabe.Size = new System.Drawing.Size(332, 303);
            this.AbfahrtstafelAusgabe.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SuchenButton1;
        private System.Windows.Forms.TextBox ZielortSuchleiste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StartortSuchleiste1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox FahrplanAusgabe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox AbfahrtstafelAusgabe;
        private System.Windows.Forms.Button SuchenButton2;
        private System.Windows.Forms.TextBox StartortSuchleiste2;
        private System.Windows.Forms.Label label3;
    }
}

