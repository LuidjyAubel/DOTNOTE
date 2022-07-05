namespace NOTEPAD
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistreSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomAvantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomArrièreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomDéfaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionnéToutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirDansLexplorateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.affichageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem,
            this.enregistreSousToolStripMenuItem,
            this.imprimerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(117, 31);
            this.fichierToolStripMenuItem.Text = "Fichier";
            this.fichierToolStripMenuItem.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(474, 32);
            this.ouvrirToolStripMenuItem.Text = "Nouveau";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(474, 32);
            this.enregistrerToolStripMenuItem.Text = "Ouvrir...";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(474, 32);
            this.enregistrerSousToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerSousToolStripMenuItem.Click += new System.EventHandler(this.enregistrerSousToolStripMenuItem_Click);
            // 
            // enregistreSousToolStripMenuItem
            // 
            this.enregistreSousToolStripMenuItem.Name = "enregistreSousToolStripMenuItem";
            this.enregistreSousToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.enregistreSousToolStripMenuItem.Size = new System.Drawing.Size(474, 32);
            this.enregistreSousToolStripMenuItem.Text = "Enregistre sous...";
            this.enregistreSousToolStripMenuItem.Click += new System.EventHandler(this.enregistreSousToolStripMenuItem_Click);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(474, 32);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            this.imprimerToolStripMenuItem.Click += new System.EventHandler(this.imprimerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(474, 32);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annulerToolStripMenuItem,
            this.restaurerToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(117, 31);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(305, 32);
            this.annulerToolStripMenuItem.Text = "Annuler";
            this.annulerToolStripMenuItem.Click += new System.EventHandler(this.annulerToolStripMenuItem_Click);
            // 
            // restaurerToolStripMenuItem
            // 
            this.restaurerToolStripMenuItem.Name = "restaurerToolStripMenuItem";
            this.restaurerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.restaurerToolStripMenuItem.Size = new System.Drawing.Size(305, 32);
            this.restaurerToolStripMenuItem.Text = "Restaurer";
            this.restaurerToolStripMenuItem.Click += new System.EventHandler(this.restaurerToolStripMenuItem_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.policeToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(143, 31);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // policeToolStripMenuItem
            // 
            this.policeToolStripMenuItem.Name = "policeToolStripMenuItem";
            this.policeToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.policeToolStripMenuItem.Text = "Police...";
            this.policeToolStripMenuItem.Click += new System.EventHandler(this.policeToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomAvantToolStripMenuItem,
            this.zoomArrièreToolStripMenuItem,
            this.zoomDéfaultToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.zoomToolStripMenuItem.Text = " Zoom";
            // 
            // zoomAvantToolStripMenuItem
            // 
            this.zoomAvantToolStripMenuItem.Name = "zoomAvantToolStripMenuItem";
            this.zoomAvantToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Num +";
            this.zoomAvantToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Add)));
            this.zoomAvantToolStripMenuItem.Size = new System.Drawing.Size(396, 32);
            this.zoomAvantToolStripMenuItem.Text = "Zoom avant";
            this.zoomAvantToolStripMenuItem.Click += new System.EventHandler(this.zoomAvantToolStripMenuItem_Click);
            // 
            // zoomArrièreToolStripMenuItem
            // 
            this.zoomArrièreToolStripMenuItem.Name = "zoomArrièreToolStripMenuItem";
            this.zoomArrièreToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Num -";
            this.zoomArrièreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Subtract)));
            this.zoomArrièreToolStripMenuItem.Size = new System.Drawing.Size(396, 32);
            this.zoomArrièreToolStripMenuItem.Text = "Zoom arrière";
            this.zoomArrièreToolStripMenuItem.Click += new System.EventHandler(this.zoomArrièreToolStripMenuItem_Click);
            // 
            // zoomDéfaultToolStripMenuItem
            // 
            this.zoomDéfaultToolStripMenuItem.Name = "zoomDéfaultToolStripMenuItem";
            this.zoomDéfaultToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Num /";
            this.zoomDéfaultToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Divide)));
            this.zoomDéfaultToolStripMenuItem.Size = new System.Drawing.Size(396, 32);
            this.zoomDéfaultToolStripMenuItem.Text = "Zoom défaut";
            this.zoomDéfaultToolStripMenuItem.Click += new System.EventHandler(this.zoomDéfaultToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 35);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 415);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.couperToolStripMenuItem,
            this.selectionnéToutToolStripMenuItem,
            this.ouvrirDansLexplorateurToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 124);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.collerToolStripMenuItem.Text = "Coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.couperToolStripMenuItem.Text = "Couper";
            this.couperToolStripMenuItem.Click += new System.EventHandler(this.couperToolStripMenuItem_Click);
            // 
            // selectionnéToutToolStripMenuItem
            // 
            this.selectionnéToutToolStripMenuItem.Name = "selectionnéToutToolStripMenuItem";
            this.selectionnéToutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectionnéToutToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.selectionnéToutToolStripMenuItem.Text = "Selectionné tout";
            this.selectionnéToutToolStripMenuItem.Click += new System.EventHandler(this.selectionnéToutToolStripMenuItem_Click);
            // 
            // ouvrirDansLexplorateurToolStripMenuItem
            // 
            this.ouvrirDansLexplorateurToolStripMenuItem.Name = "ouvrirDansLexplorateurToolStripMenuItem";
            this.ouvrirDansLexplorateurToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.ouvrirDansLexplorateurToolStripMenuItem.Text = "Ouvrir dans l\'explorateur";
            this.ouvrirDansLexplorateurToolStripMenuItem.Click += new System.EventHandler(this.ouvrirDansLexplorateurToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Main";
            this.Text = "DotNote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistreSousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policeToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem restaurerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomAvantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomArrièreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomDéfaultToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirDansLexplorateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionnéToutToolStripMenuItem;
    }
}

