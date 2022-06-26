
namespace BankAnalyse
{
    partial class FormBankAnalyse
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
            this.LView = new System.Windows.Forms.ListView();
            this.LblLog = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblIncome = new System.Windows.Forms.Label();
            this.LblExpenses = new System.Windows.Forms.Label();
            this.LblAverageExpenses = new System.Windows.Forms.Label();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LView
            // 
            this.LView.FullRowSelect = true;
            this.LView.HideSelection = false;
            this.LView.Location = new System.Drawing.Point(16, 57);
            this.LView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LView.MultiSelect = false;
            this.LView.Name = "LView";
            this.LView.Size = new System.Drawing.Size(996, 238);
            this.LView.TabIndex = 0;
            this.LView.UseCompatibleStateImageBehavior = false;
            this.LView.View = System.Windows.Forms.View.Details;
            // 
            // LblLog
            // 
            this.LblLog.AutoSize = true;
            this.LblLog.Location = new System.Drawing.Point(16, 431);
            this.LblLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLog.Name = "LblLog";
            this.LblLog.Size = new System.Drawing.Size(0, 17);
            this.LblLog.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1388, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importCSVToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importCSVToolStripMenuItem
            // 
            this.importCSVToolStripMenuItem.Name = "importCSVToolStripMenuItem";
            this.importCSVToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importCSVToolStripMenuItem.Text = "Import CSV ...";
            this.importCSVToolStripMenuItem.Click += new System.EventHandler(this.importCSVToolStripMenuItem_Click);
            // 
            // LblIncome
            // 
            this.LblIncome.AutoSize = true;
            this.LblIncome.Location = new System.Drawing.Point(1084, 57);
            this.LblIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIncome.Name = "LblIncome";
            this.LblIncome.Size = new System.Drawing.Size(119, 17);
            this.LblIncome.TabIndex = 3;
            this.LblIncome.Text = "Summe Eingänge";
            // 
            // LblExpenses
            // 
            this.LblExpenses.AutoSize = true;
            this.LblExpenses.Location = new System.Drawing.Point(1084, 87);
            this.LblExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblExpenses.Name = "LblExpenses";
            this.LblExpenses.Size = new System.Drawing.Size(123, 17);
            this.LblExpenses.TabIndex = 4;
            this.LblExpenses.Text = "Summe Ausgänge";
            // 
            // LblAverageExpenses
            // 
            this.LblAverageExpenses.AutoSize = true;
            this.LblAverageExpenses.Location = new System.Drawing.Point(1084, 117);
            this.LblAverageExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAverageExpenses.Name = "LblAverageExpenses";
            this.LblAverageExpenses.Size = new System.Drawing.Size(155, 17);
            this.LblAverageExpenses.TabIndex = 5;
            this.LblAverageExpenses.Text = "Durchschnitt pro Monat";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // FormBankAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 587);
            this.Controls.Add(this.LblAverageExpenses);
            this.Controls.Add(this.LblExpenses);
            this.Controls.Add(this.LblIncome);
            this.Controls.Add(this.LblLog);
            this.Controls.Add(this.LView);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBankAnalyse";
            this.Text = "Bank Analyse";
            this.Load += new System.EventHandler(this.FormBankAnalyse_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LView;
        private System.Windows.Forms.Label LblLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCSVToolStripMenuItem;
        private System.Windows.Forms.Label LblIncome;
        private System.Windows.Forms.Label LblExpenses;
        private System.Windows.Forms.Label LblAverageExpenses;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
    }
}

