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
    public partial class Text_Editor : Form
    {
        public Text_Editor()
        {
            InitializeComponent();
        }

        public void OpenFile(string fileName)
        {
            string strExt;
            strExt = System.IO.Path.GetExtension(fileName);
            strExt = strExt.ToUpper();
            if (strExt == ".TXT")
            {
                textboxeditor.LoadFile(fileName, RichTextBoxStreamType.PlainText);
            }
            else
            {
                System.IO.StreamReader txtReader;
                txtReader = new System.IO.StreamReader(fileName);
                textboxeditor.Text = txtReader.ReadToEnd();
                txtReader.Close();
                txtReader = null;
                textboxeditor.SelectionStart = 0;
                textboxeditor.SelectionLength = 0;
            }
            textboxeditor.Modified = false;
            this.Text = "Editor: " + fileName;
        }
    }
    
}

