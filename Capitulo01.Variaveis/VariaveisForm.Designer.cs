namespace Capitulo01.Variaveis
{
    partial class VariaveisForm
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
            this.MenuSuperior = new System.Windows.Forms.MenuStrip();
            this.operacoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritimeticaSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reduzidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operadoresIncrementaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boolenasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logícaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultadoListBox = new System.Windows.Forms.ListBox();
            this.ternariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuSuperior
            // 
            this.MenuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacoesToolStripMenuItem});
            this.MenuSuperior.Location = new System.Drawing.Point(20, 60);
            this.MenuSuperior.Name = "MenuSuperior";
            this.MenuSuperior.Size = new System.Drawing.Size(657, 24);
            this.MenuSuperior.TabIndex = 0;
            this.MenuSuperior.Text = "menuStrip1";
            // 
            // operacoesToolStripMenuItem
            // 
            this.operacoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aritimeticaSubMenu,
            this.reduzidasToolStripMenuItem,
            this.operadoresIncrementaisToolStripMenuItem,
            this.boolenasToolStripMenuItem,
            this.logícaToolStripMenuItem,
            this.ternariasToolStripMenuItem});
            this.operacoesToolStripMenuItem.Name = "operacoesToolStripMenuItem";
            this.operacoesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.operacoesToolStripMenuItem.Text = "&Operações";
            // 
            // aritimeticaSubMenu
            // 
            this.aritimeticaSubMenu.Name = "aritimeticaSubMenu";
            this.aritimeticaSubMenu.Size = new System.Drawing.Size(226, 22);
            this.aritimeticaSubMenu.Text = "&Aritiméticas";
            this.aritimeticaSubMenu.Click += new System.EventHandler(this.aritimeticaSubMenu_Click);
            // 
            // reduzidasToolStripMenuItem
            // 
            this.reduzidasToolStripMenuItem.Name = "reduzidasToolStripMenuItem";
            this.reduzidasToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.reduzidasToolStripMenuItem.Text = "&Reduzidas";
            this.reduzidasToolStripMenuItem.Click += new System.EventHandler(this.reduzidasToolStripMenuItem_Click);
            // 
            // operadoresIncrementaisToolStripMenuItem
            // 
            this.operadoresIncrementaisToolStripMenuItem.Name = "operadoresIncrementaisToolStripMenuItem";
            this.operadoresIncrementaisToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.operadoresIncrementaisToolStripMenuItem.Text = "Incrementais e Decrementais";
            this.operadoresIncrementaisToolStripMenuItem.Click += new System.EventHandler(this.operadoresIncrementaisToolStripMenuItem_Click);
            // 
            // boolenasToolStripMenuItem
            // 
            this.boolenasToolStripMenuItem.Name = "boolenasToolStripMenuItem";
            this.boolenasToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.boolenasToolStripMenuItem.Text = "&Boolenas";
            this.boolenasToolStripMenuItem.Click += new System.EventHandler(this.boolenasToolStripMenuItem_Click);
            // 
            // logícaToolStripMenuItem
            // 
            this.logícaToolStripMenuItem.Name = "logícaToolStripMenuItem";
            this.logícaToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.logícaToolStripMenuItem.Text = "Logíca";
            this.logícaToolStripMenuItem.Click += new System.EventHandler(this.logícaToolStripMenuItem_Click);
            // 
            // ResultadoListBox
            // 
            this.ResultadoListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultadoListBox.FormattingEnabled = true;
            this.ResultadoListBox.Location = new System.Drawing.Point(20, 84);
            this.ResultadoListBox.Name = "ResultadoListBox";
            this.ResultadoListBox.Size = new System.Drawing.Size(657, 246);
            this.ResultadoListBox.TabIndex = 1;
            this.ResultadoListBox.SelectedIndexChanged += new System.EventHandler(this.ResultadoListBox_SelectedIndexChanged);
            // 
            // ternariasToolStripMenuItem
            // 
            this.ternariasToolStripMenuItem.Name = "ternariasToolStripMenuItem";
            this.ternariasToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.ternariasToolStripMenuItem.Text = "Ternarias";
            this.ternariasToolStripMenuItem.Click += new System.EventHandler(this.ternariasToolStripMenuItem_Click);
            // 
            // VariaveisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 350);
            this.Controls.Add(this.ResultadoListBox);
            this.Controls.Add(this.MenuSuperior);
            this.MainMenuStrip = this.MenuSuperior;
            this.Name = "VariaveisForm";
            this.Text = "Variaveis e Operações";
            this.MenuSuperior.ResumeLayout(false);
            this.MenuSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuSuperior;
        private System.Windows.Forms.ListBox ResultadoListBox;
        private System.Windows.Forms.ToolStripMenuItem operacoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritimeticaSubMenu;
        private System.Windows.Forms.ToolStripMenuItem reduzidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operadoresIncrementaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boolenasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logícaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ternariasToolStripMenuItem;
    }
}

