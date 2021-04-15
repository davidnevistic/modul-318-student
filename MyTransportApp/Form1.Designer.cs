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
            this.VorschlagBox2 = new System.Windows.Forms.ListBox();
            this.VorschlagBox1 = new System.Windows.Forms.ListBox();
            this.AusgabeFahrplan = new System.Windows.Forms.DataGridView();
            this.LinieFahrplan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbfahrtszeitFahrplan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationenFahrplan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnkunftszeitFahrplan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuchenButton1 = new System.Windows.Forms.Button();
            this.ZielortSuchleiste = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartortSuchleiste1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VorschlagBox3 = new System.Windows.Forms.ListBox();
            this.AusgabeAbfahrtstafel = new System.Windows.Forms.DataGridView();
            this.SuchenButton2 = new System.Windows.Forms.Button();
            this.StartortSuchleiste2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LinieAbfahrtstafel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbfahrtszeitAbfahrtstafel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnkunftszeitAbfahrtstafel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZielortAbfahrtstafel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AusgabeFahrplan)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AusgabeAbfahrtstafel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VorschlagBox2);
            this.groupBox1.Controls.Add(this.VorschlagBox1);
            this.groupBox1.Controls.Add(this.AusgabeFahrplan);
            this.groupBox1.Controls.Add(this.SuchenButton1);
            this.groupBox1.Controls.Add(this.ZielortSuchleiste);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StartortSuchleiste1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 517);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fahrplan";
            // 
            // VorschlagBox2
            // 
            this.VorschlagBox2.FormattingEnabled = true;
            this.VorschlagBox2.Location = new System.Drawing.Point(227, 83);
            this.VorschlagBox2.Name = "VorschlagBox2";
            this.VorschlagBox2.Size = new System.Drawing.Size(172, 82);
            this.VorschlagBox2.TabIndex = 7;
            this.VorschlagBox2.SelectedIndexChanged += new System.EventHandler(this.VorschlagBox2_SelectedIndexChanged);
            // 
            // VorschlagBox1
            // 
            this.VorschlagBox1.FormattingEnabled = true;
            this.VorschlagBox1.Location = new System.Drawing.Point(9, 83);
            this.VorschlagBox1.Name = "VorschlagBox1";
            this.VorschlagBox1.Size = new System.Drawing.Size(173, 82);
            this.VorschlagBox1.TabIndex = 6;
            this.VorschlagBox1.SelectedIndexChanged += new System.EventHandler(this.VorschlagBox1_SelectedIndexChanged);
            // 
            // AusgabeFahrplan
            // 
            this.AusgabeFahrplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AusgabeFahrplan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LinieFahrplan,
            this.AbfahrtszeitFahrplan,
            this.StationenFahrplan,
            this.AnkunftszeitFahrplan});
            this.AusgabeFahrplan.Location = new System.Drawing.Point(0, 171);
            this.AusgabeFahrplan.Name = "AusgabeFahrplan";
            this.AusgabeFahrplan.RowHeadersVisible = false;
            this.AusgabeFahrplan.Size = new System.Drawing.Size(480, 340);
            this.AusgabeFahrplan.TabIndex = 5;
            // 
            // LinieFahrplan
            // 
            this.LinieFahrplan.HeaderText = "Kante/Gleis";
            this.LinieFahrplan.Name = "LinieFahrplan";
            this.LinieFahrplan.Width = 109;
            // 
            // AbfahrtszeitFahrplan
            // 
            this.AbfahrtszeitFahrplan.HeaderText = "Abfahrtszeit";
            this.AbfahrtszeitFahrplan.Name = "AbfahrtszeitFahrplan";
            this.AbfahrtszeitFahrplan.Width = 109;
            // 
            // StationenFahrplan
            // 
            this.StationenFahrplan.HeaderText = "Ankunftszeit";
            this.StationenFahrplan.Name = "StationenFahrplan";
            this.StationenFahrplan.Width = 109;
            // 
            // AnkunftszeitFahrplan
            // 
            this.AnkunftszeitFahrplan.HeaderText = "Reisedauer";
            this.AnkunftszeitFahrplan.Name = "AnkunftszeitFahrplan";
            this.AnkunftszeitFahrplan.Width = 109;
            // 
            // SuchenButton1
            // 
            this.SuchenButton1.Location = new System.Drawing.Point(422, 46);
            this.SuchenButton1.Name = "SuchenButton1";
            this.SuchenButton1.Size = new System.Drawing.Size(75, 23);
            this.SuchenButton1.TabIndex = 4;
            this.SuchenButton1.Text = "Suchen";
            this.SuchenButton1.UseVisualStyleBackColor = true;
            this.SuchenButton1.Click += new System.EventHandler(this.SuchenButton1_Click);
            // 
            // ZielortSuchleiste
            // 
            this.ZielortSuchleiste.Location = new System.Drawing.Point(227, 50);
            this.ZielortSuchleiste.Name = "ZielortSuchleiste";
            this.ZielortSuchleiste.Size = new System.Drawing.Size(172, 20);
            this.ZielortSuchleiste.TabIndex = 3;
            this.ZielortSuchleiste.TextChanged += new System.EventHandler(this.ZielortSuchleiste_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zielort";
            // 
            // StartortSuchleiste1
            // 
            this.StartortSuchleiste1.Location = new System.Drawing.Point(7, 49);
            this.StartortSuchleiste1.Name = "StartortSuchleiste1";
            this.StartortSuchleiste1.Size = new System.Drawing.Size(175, 20);
            this.StartortSuchleiste1.TabIndex = 1;
            this.StartortSuchleiste1.TextChanged += new System.EventHandler(this.StartortSuchleiste1_TextChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VorschlagBox3);
            this.groupBox2.Controls.Add(this.AusgabeAbfahrtstafel);
            this.groupBox2.Controls.Add(this.SuchenButton2);
            this.groupBox2.Controls.Add(this.StartortSuchleiste2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(533, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 517);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abfahrtstafel";
            // 
            // VorschlagBox3
            // 
            this.VorschlagBox3.FormattingEnabled = true;
            this.VorschlagBox3.Location = new System.Drawing.Point(9, 81);
            this.VorschlagBox3.Name = "VorschlagBox3";
            this.VorschlagBox3.Size = new System.Drawing.Size(160, 82);
            this.VorschlagBox3.TabIndex = 4;
            // 
            // AusgabeAbfahrtstafel
            // 
            this.AusgabeAbfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AusgabeAbfahrtstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LinieAbfahrtstafel,
            this.AbfahrtszeitAbfahrtstafel,
            this.AnkunftszeitAbfahrtstafel,
            this.ZielortAbfahrtstafel});
            this.AusgabeAbfahrtstafel.Location = new System.Drawing.Point(9, 171);
            this.AusgabeAbfahrtstafel.Name = "AusgabeAbfahrtstafel";
            this.AusgabeAbfahrtstafel.RowHeadersVisible = false;
            this.AusgabeAbfahrtstafel.Size = new System.Drawing.Size(371, 346);
            this.AusgabeAbfahrtstafel.TabIndex = 3;
            // 
            // SuchenButton2
            // 
            this.SuchenButton2.Location = new System.Drawing.Point(208, 50);
            this.SuchenButton2.Name = "SuchenButton2";
            this.SuchenButton2.Size = new System.Drawing.Size(75, 23);
            this.SuchenButton2.TabIndex = 2;
            this.SuchenButton2.Text = "Suchen";
            this.SuchenButton2.UseVisualStyleBackColor = true;
            // 
            // StartortSuchleiste2
            // 
            this.StartortSuchleiste2.Location = new System.Drawing.Point(7, 50);
            this.StartortSuchleiste2.Name = "StartortSuchleiste2";
            this.StartortSuchleiste2.Size = new System.Drawing.Size(163, 20);
            this.StartortSuchleiste2.TabIndex = 1;
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
            // LinieAbfahrtstafel
            // 
            this.LinieAbfahrtstafel.HeaderText = "Kante/Gleis";
            this.LinieAbfahrtstafel.Name = "LinieAbfahrtstafel";
            this.LinieAbfahrtstafel.Width = 75;
            // 
            // AbfahrtszeitAbfahrtstafel
            // 
            this.AbfahrtszeitAbfahrtstafel.HeaderText = "Abfahrtszeit";
            this.AbfahrtszeitAbfahrtstafel.Name = "AbfahrtszeitAbfahrtstafel";
            this.AbfahrtszeitAbfahrtstafel.Width = 90;
            // 
            // AnkunftszeitAbfahrtstafel
            // 
            this.AnkunftszeitAbfahrtstafel.HeaderText = "Ankunftszeit";
            this.AnkunftszeitAbfahrtstafel.Name = "AnkunftszeitAbfahrtstafel";
            this.AnkunftszeitAbfahrtstafel.Width = 90;
            // 
            // ZielortAbfahrtstafel
            // 
            this.ZielortAbfahrtstafel.HeaderText = "Zielort";
            this.ZielortAbfahrtstafel.Name = "ZielortAbfahrtstafel";
            this.ZielortAbfahrtstafel.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 541);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AusgabeFahrplan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AusgabeAbfahrtstafel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SuchenButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SuchenButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView AusgabeFahrplan;
        private System.Windows.Forms.DataGridView AusgabeAbfahrtstafel;
        private System.Windows.Forms.TextBox ZielortSuchleiste;
        private System.Windows.Forms.TextBox StartortSuchleiste1;
        private System.Windows.Forms.TextBox StartortSuchleiste2;
        private System.Windows.Forms.ListBox VorschlagBox2;
        private System.Windows.Forms.ListBox VorschlagBox1;
        private System.Windows.Forms.ListBox VorschlagBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinieFahrplan;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbfahrtszeitFahrplan;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationenFahrplan;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnkunftszeitFahrplan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinieAbfahrtstafel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbfahrtszeitAbfahrtstafel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnkunftszeitAbfahrtstafel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZielortAbfahrtstafel;
    }
}

