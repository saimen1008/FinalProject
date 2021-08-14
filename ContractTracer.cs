/*
 * Group 3- Saimen Preet Singh and Elaine Nankanja
 * File Name- ContractTracer.cs
 * Last Modified- August 13, 2021
 * Description- This is the contract tracer child form.
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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project
{
    public partial class ContractTracer : Form
    {
        public ContractTracer()
        {
            InitializeComponent();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


            listViewInfo.CheckBoxes = true;

            listViewInfo.Columns.Add("Contacted", 60);



            firstBox.Text = listViewInfo.FocusedItem.SubItems[1].Text;
            lastBox.Text = listViewInfo.FocusedItem.SubItems[2].Text;
            emailBox.Text = listViewInfo.FocusedItem.SubItems[3].Text;
            phoneBox.Text = listViewInfo.FocusedItem.SubItems[4].Text;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            firstBox.Clear();
            lastBox.Clear();
            emailBox.Clear();
            phoneBox.Clear();
            contactedBox.Checked = false;



        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {



            String pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";


            if (firstBox.Text == "")
            {
                labelOutput.Text = "Please Enter your first Name!";
                firstBox.Select();
            }
            else if (lastBox.Text == "")
            {
                labelOutput.Text = "Please Enter your last name!";
                lastBox.Select();
            }
            else if (emailBox.Text == "")
            {
                labelOutput.Text = "Please Enter your email address!";
                emailBox.Select();
            }
            else if (phoneBox.Text == "")
            {
                labelOutput.Text = "Please enter your phone number!";
                phoneBox.Select();
            }

            else if (!(Regex.IsMatch(emailBox.Text, pattern)))
            {
                labelOutput.Text = "Invalid Email Address. Please try Again!";
                emailBox.Clear();
                emailBox.Select();

            }

            else
            {
                if (string.IsNullOrEmpty(firstBox.Text) || string.IsNullOrEmpty(lastBox.Text) || string.IsNullOrEmpty(emailBox.Text) || string.IsNullOrEmpty(phoneBox.Text))

                    return;
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(firstBox.Text);
                item.SubItems.Add(lastBox.Text);

                item.SubItems.Add(emailBox.Text);
                item.SubItems.Add(phoneBox.Text);
                listViewInfo.Items.Add(item);
                labelOutput.Text = "";
            }




        }

        private void phoneBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {






        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String filename = string.Empty;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;

                MessageBox.Show("Save was complete", "Save Confirmation",
                    MessageBoxButtons.OK);

            }
        }
    }
}

