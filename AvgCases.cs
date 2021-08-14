/*
 * Group 3- Saimen Preet Singh and Elaine Nankanja
 * File Name- AvgCases.cs
 * Last Modified- August 13, 2021
 * Description- This is the average weekly cases child form.
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
    public partial class AvgCases : Form
    {
        public AvgCases()
        {
            InitializeComponent();

        }
        private void btnEnter_Click(object sender, EventArgs e)
        {

            //if case value contain fraction part or it is less than 0 or exceeds maximum
            //integer value
            if (!int.TryParse(txtInput.Text, out int k) || (Convert.ToInt32(txtInput.Text) < 0 || Convert.ToInt32(txtInput.Text) > int.MaxValue))
            {
                MessageBox.Show("Invalid case value");
                txtInput.Focus();
                //selecting the case entry value
                txtInput.SelectionStart = 0;
                txtInput.SelectionLength = txtInput.Text.Length;
            }

            else
            {
                double total = 0;
                int day = 0;
                double avg = 0;
                //adding case value to text2 text box
                txtCases.Text = txtCases.Text + txtInput.Text;
                txtCases.Text += "\r\n";
                total += Convert.ToInt32(txtInput.Text);//adding case to total
                day += 1; //increment day
                txtInput.Text = "";//clearing case entry
                txtInput.Focus();//setting focus to case entry
                if (day == 8)
                {
                    //making enter and case entry button disable
                    btnEnter.Enabled = false;
                    txtInput.Enabled = false;
                    avg = Math.Round(total / 7.0, 2);
                    //setting average to this lablel
                    lblResult.Text = "Average per day : " + avg.ToString();
                    btnReset.Focus();
                }
                else
                    //set day number to this label
                    lblDays.Text = day.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            int day = 0;
            //reset button
            //clearing all the text boxes and labels
            btnEnter.Enabled = true;
            txtInput.Enabled = true;
            txtCases.Clear();
            day = 1;
            lblDays.Text = day.ToString();
            lblResult.Text = "";
            txtInput.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit button
            Application.Exit();
        }

    }

}
