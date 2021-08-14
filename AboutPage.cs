/*
 * Group 3- Saimen Preet Singh and Elaine Nankanja
 * File Name- AboutPage.cs
 * Last Modified- August 13, 2021
 * Description- This is the About Page of our project.
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
    public partial class AboutPage : Form
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}