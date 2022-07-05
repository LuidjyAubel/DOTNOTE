using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTEPAD
{
    public partial class Main : Form
    {
        private string FileName;
        public Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ouvrir un fichier texte.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
            this.FileName = openFileDialog1.FileName;
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
            this.FileName = openFileDialog1.FileName;
        }

        private void enregistreSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
            this.FileName = openFileDialog1.FileName;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.SaveFile(this.FileName, RichTextBoxStreamType.PlainText);
            //MessageBox.Show(this.FileName);
            StreamWriter sw = new StreamWriter(this.FileName);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
        }

        private void policeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = richTextBox1.Font;
            fontDialog1.Color = richTextBox1.ForeColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void imprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void zoomAvantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor < 3)
            {
                richTextBox1.ZoomFactor += 0.3F;
            }
        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void selectionnéToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void ouvrirDansLexplorateurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void restaurerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo)
            {
                richTextBox1.Redo();
            }
        }

        private void zoomArrièreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor > 0.7F)
            {
                richTextBox1.ZoomFactor -= 0.3F;
            }
        }

        private void zoomDéfaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor -= 1F;
        }

        private void annulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
            }
        }
    }
}
