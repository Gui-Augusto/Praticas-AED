namespace Pratica5
{
    partial class FormOrdenacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellsortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heapsortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quicksortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergesortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seleçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shellsortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.heapsortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quicksortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mergesortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.radioButton8);
            this.panel.Controls.Add(this.radioButton4);
            this.panel.Controls.Add(this.radioButton7);
            this.panel.Controls.Add(this.radioButton5);
            this.panel.Controls.Add(this.radioButton6);
            this.panel.Location = new System.Drawing.Point(12, 53);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 305);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(439, 0);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(43, 17);
            this.radioButton8.TabIndex = 3;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "500";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(439, 92);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(64, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "500.000";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(439, 23);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(58, 17);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "10.000";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(439, 69);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(64, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "100.000";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(439, 46);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(58, 17);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "50.000";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoToolStripMenuItem,
            this.estatísticasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // algoritmoToolStripMenuItem
            // 
            this.algoritmoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem,
            this.seleçãoToolStripMenuItem,
            this.shellsortToolStripMenuItem,
            this.heapsortToolStripMenuItem,
            this.quicksortToolStripMenuItem,
            this.mergesortToolStripMenuItem,
            this.inserçãoToolStripMenuItem});
            this.algoritmoToolStripMenuItem.Name = "algoritmoToolStripMenuItem";
            this.algoritmoToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.algoritmoToolStripMenuItem.Text = "Animações";
            // 
            // bolhaToolStripMenuItem
            // 
            this.bolhaToolStripMenuItem.Name = "bolhaToolStripMenuItem";
            this.bolhaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.bolhaToolStripMenuItem.Text = "Bolha";
            this.bolhaToolStripMenuItem.Click += new System.EventHandler(this.bolhaToolStripMenuItem_Click);
            // 
            // seleçãoToolStripMenuItem
            // 
            this.seleçãoToolStripMenuItem.Name = "seleçãoToolStripMenuItem";
            this.seleçãoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.seleçãoToolStripMenuItem.Text = "Seleção";
            this.seleçãoToolStripMenuItem.Click += new System.EventHandler(this.seleçãoToolStripMenuItem_Click);
            // 
            // shellsortToolStripMenuItem
            // 
            this.shellsortToolStripMenuItem.Name = "shellsortToolStripMenuItem";
            this.shellsortToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.shellsortToolStripMenuItem.Text = "Shellsort";
            this.shellsortToolStripMenuItem.Click += new System.EventHandler(this.shellsortToolStripMenuItem_Click);
            // 
            // heapsortToolStripMenuItem
            // 
            this.heapsortToolStripMenuItem.Name = "heapsortToolStripMenuItem";
            this.heapsortToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.heapsortToolStripMenuItem.Text = "Heapsort";
            this.heapsortToolStripMenuItem.Click += new System.EventHandler(this.heapsortToolStripMenuItem_Click);
            // 
            // quicksortToolStripMenuItem
            // 
            this.quicksortToolStripMenuItem.Name = "quicksortToolStripMenuItem";
            this.quicksortToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.quicksortToolStripMenuItem.Text = "Quicksort";
            this.quicksortToolStripMenuItem.Click += new System.EventHandler(this.quicksortToolStripMenuItem_Click);
            // 
            // mergesortToolStripMenuItem
            // 
            this.mergesortToolStripMenuItem.Name = "mergesortToolStripMenuItem";
            this.mergesortToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mergesortToolStripMenuItem.Text = "Mergesort";
            this.mergesortToolStripMenuItem.Click += new System.EventHandler(this.mergesortToolStripMenuItem_Click);
            // 
            // inserçãoToolStripMenuItem
            // 
            this.inserçãoToolStripMenuItem.Name = "inserçãoToolStripMenuItem";
            this.inserçãoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.inserçãoToolStripMenuItem.Text = "Inserção";
            this.inserçãoToolStripMenuItem.Click += new System.EventHandler(this.inserçãoToolStripMenuItem_Click);
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem1,
            this.seleçãoToolStripMenuItem1,
            this.shellsortToolStripMenuItem1,
            this.heapsortToolStripMenuItem1,
            this.quicksortToolStripMenuItem1,
            this.mergesortToolStripMenuItem1,
            this.inserçãoToolStripMenuItem1});
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            // 
            // bolhaToolStripMenuItem1
            // 
            this.bolhaToolStripMenuItem1.Name = "bolhaToolStripMenuItem1";
            this.bolhaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bolhaToolStripMenuItem1.Text = "Bolha";
            this.bolhaToolStripMenuItem1.Click += new System.EventHandler(this.bolhaToolStripMenuItem1_Click_1);
            // 
            // seleçãoToolStripMenuItem1
            // 
            this.seleçãoToolStripMenuItem1.Name = "seleçãoToolStripMenuItem1";
            this.seleçãoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.seleçãoToolStripMenuItem1.Text = "Seleção";
            this.seleçãoToolStripMenuItem1.Click += new System.EventHandler(this.seleçãoToolStripMenuItem1_Click);
            // 
            // shellsortToolStripMenuItem1
            // 
            this.shellsortToolStripMenuItem1.Name = "shellsortToolStripMenuItem1";
            this.shellsortToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.shellsortToolStripMenuItem1.Text = "Shellsort";
            this.shellsortToolStripMenuItem1.Click += new System.EventHandler(this.shellsortToolStripMenuItem1_Click);
            // 
            // heapsortToolStripMenuItem1
            // 
            this.heapsortToolStripMenuItem1.Name = "heapsortToolStripMenuItem1";
            this.heapsortToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.heapsortToolStripMenuItem1.Text = "Heapsort";
            this.heapsortToolStripMenuItem1.Click += new System.EventHandler(this.heapsortToolStripMenuItem1_Click);
            // 
            // quicksortToolStripMenuItem1
            // 
            this.quicksortToolStripMenuItem1.Name = "quicksortToolStripMenuItem1";
            this.quicksortToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.quicksortToolStripMenuItem1.Text = "Quicksort";
            this.quicksortToolStripMenuItem1.Click += new System.EventHandler(this.quicksortToolStripMenuItem1_Click);
            // 
            // mergesortToolStripMenuItem1
            // 
            this.mergesortToolStripMenuItem1.Name = "mergesortToolStripMenuItem1";
            this.mergesortToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.mergesortToolStripMenuItem1.Text = "Mergesort";
            this.mergesortToolStripMenuItem1.Click += new System.EventHandler(this.mergesortToolStripMenuItem1_Click);
            // 
            // inserçãoToolStripMenuItem1
            // 
            this.inserçãoToolStripMenuItem1.Name = "inserçãoToolStripMenuItem1";
            this.inserçãoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.inserçãoToolStripMenuItem1.Text = "Inserção";
            this.inserçãoToolStripMenuItem1.Click += new System.EventHandler(this.inserçãoToolStripMenuItem1_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // bgw
            // 
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(275, 1);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Aleatorio";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(426, 1);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Decrescente";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(347, 1);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Crescente";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // FormOrdenacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 361);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormOrdenacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prática 5 2023/1 - Métodos de Ordenação";
            this.Load += new System.EventHandler(this.FormOrdenacao_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seleçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellsortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heapsortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quicksortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergesortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ToolStripMenuItem seleçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shellsortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem heapsortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quicksortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mergesortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem1;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton8;
    }
}

