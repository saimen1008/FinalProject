/*
 * Group 3- Saimen Preet Singh and Elaine Nankanja
 * File Name- FormMain.cs
 * Last Modified- August 13, 2021
 * Description- This is our final project for NETD 2202.
 *            
 * 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }
        // New File
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text_Editor childform = new Text_Editor();
            childform.MdiParent = this;
            childform.Show();
        }
        // Open a File
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fileName = openFileDialog.FileName;
                if (fileName.Length != 0)
                {
                    try
                    {
                        Text_Editor childform = new Text_Editor();
                        childform.OpenFile(openFileDialog.FileName);
                        childform.MdiParent = this;
                        childform.Show();
                    }
                    catch
                    {
                        MessageBox.Show(String.Format("{0} is not " + "a valid file", fileName), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Save File
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Form activeChildForm = this.ActiveMdiChild;
                if (activeChildForm != null)
                {
                    RichTextBox RichtxtEditor = activeChildForm.ActiveControl as RichTextBox;
                    if (RichtxtEditor != null)
                    {
                        string extension = System.IO.Path.GetExtension(saveFileDialog.FileName);
                        RichtxtEditor.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Form activeChildForm = this.ActiveMdiChild;
                if (activeChildForm != null)
                {
                    RichTextBox RichtxtEditor = activeChildForm.ActiveControl as RichTextBox;
                    if (RichtxtEditor != null)
                    {
                        string extension = System.IO.Path.GetExtension(saveFileDialog.FileName);
                        RichtxtEditor.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
            }
        }
        // Cut text
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChildForm = this.ActiveMdiChild;
            if (activeChildForm != null)
            {
                RichTextBox RichtxtEditor = activeChildForm.ActiveControl as RichTextBox;
                if (RichtxtEditor != null)
                {
                    if (RichtxtEditor.SelectionLength > 0)
                        RichtxtEditor.Cut();
                }
            }
        }
        // Copy text
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChildForm = this.ActiveMdiChild;
            if (activeChildForm != null)
            {
                RichTextBox RichtxtEditor = activeChildForm.ActiveControl as RichTextBox;
                if (RichtxtEditor != null)
                {
                    if (RichtxtEditor.SelectionLength > 0)
                        RichtxtEditor.Copy();
                }
            }
        }
        // Paste text
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChildForm = this.ActiveMdiChild;
            if (activeChildForm != null)
            {
                RichTextBox RichtxtEditor = activeChildForm.ActiveControl as RichTextBox;
                if (RichtxtEditor != null)
                {
                    RichtxtEditor.Paste();
                }
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ContractTracer childform = new ContractTracer();
            childform.MdiParent = this;
            childform.Show();
        }

        private void openAverageCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgCases childform = new AvgCases ();
            childform.MdiParent = this;
            childform.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutPage childform = new AboutPage ();
            childform.MdiParent = this;
            childform.Show();
        }
    }
}



