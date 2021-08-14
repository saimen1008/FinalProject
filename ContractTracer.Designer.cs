
namespace Project
{
    partial class ContractTracer
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
            this.components = new System.ComponentModel.Container();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.contactedBox = new System.Windows.Forms.CheckBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.lastBox = new System.Windows.Forms.TextBox();
            this.firstBox = new System.Windows.Forms.TextBox();
            this.listViewInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneBox = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.Location = new System.Drawing.Point(131, 20);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(81, 24);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLastName
            // 
            this.labelLastName.Location = new System.Drawing.Point(131, 45);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(81, 24);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Last Name";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(108, 69);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(104, 24);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email Address";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPhone
            // 
            this.labelPhone.Location = new System.Drawing.Point(100, 93);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(112, 24);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Phone Number";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOutput
            // 
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutput.Location = new System.Drawing.Point(117, 259);
            this.labelOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(504, 99);
            this.labelOutput.TabIndex = 6;
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.White;
            this.buttonEnter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonEnter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonEnter.Location = new System.Drawing.Point(260, 360);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(94, 43);
            this.buttonEnter.TabIndex = 6;
            this.buttonEnter.Text = "&Enter";
            this.toolTip6.SetToolTip(this.buttonEnter, "Add to register");
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.White;
            this.buttonReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonReset.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonReset.Location = new System.Drawing.Point(399, 360);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(104, 43);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "&Reset";
            this.toolTip7.SetToolTip(this.buttonReset, "Start Over");
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonExit.Location = new System.Drawing.Point(531, 360);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(91, 43);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "E&xit";
            this.toolTip8.SetToolTip(this.buttonExit, "Start Over");
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // contactedBox
            // 
            this.contactedBox.AutoSize = true;
            this.contactedBox.Location = new System.Drawing.Point(117, 120);
            this.contactedBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contactedBox.Name = "contactedBox";
            this.contactedBox.Size = new System.Drawing.Size(94, 21);
            this.contactedBox.TabIndex = 4;
            this.contactedBox.Text = "Contacted";
            this.contactedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip5.SetToolTip(this.contactedBox, "Tick if contacted");
            this.contactedBox.UseVisualStyleBackColor = true;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(238, 68);
            this.emailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(212, 22);
            this.emailBox.TabIndex = 2;
            this.toolTip3.SetToolTip(this.emailBox, "Enter email address here");
            // 
            // lastBox
            // 
            this.lastBox.Location = new System.Drawing.Point(238, 45);
            this.lastBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(134, 22);
            this.lastBox.TabIndex = 1;
            this.toolTip2.SetToolTip(this.lastBox, "Enter second name");
            // 
            // firstBox
            // 
            this.firstBox.Location = new System.Drawing.Point(238, 20);
            this.firstBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(134, 22);
            this.firstBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.firstBox, "Enter  first name");
            // 
            // listViewInfo
            // 
            this.listViewInfo.CheckBoxes = true;
            this.listViewInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewInfo.FullRowSelect = true;
            this.listViewInfo.HideSelection = false;
            this.listViewInfo.Location = new System.Drawing.Point(117, 142);
            this.listViewInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewInfo.MultiSelect = false;
            this.listViewInfo.Name = "listViewInfo";
            this.listViewInfo.Size = new System.Drawing.Size(505, 111);
            this.listViewInfo.TabIndex = 5;
            this.listViewInfo.UseCompatibleStateImageBehavior = false;
            this.listViewInfo.View = System.Windows.Forms.View.Details;
            this.listViewInfo.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Contacted";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 250;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Phone Number";
            this.columnHeader6.Width = 170;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(238, 92);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneBox.Mask = "(999) 000-0000";
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(170, 22);
            this.phoneBox.TabIndex = 3;
            this.toolTip4.SetToolTip(this.phoneBox, "Enter your phone number here");
            this.phoneBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.phoneBox_MaskInputRejected);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 0;
            // 
            // toolTip3
            // 
            this.toolTip3.AutomaticDelay = 0;
            // 
            // toolTip4
            // 
            this.toolTip4.AutomaticDelay = 0;
            // 
            // toolTip5
            // 
            this.toolTip5.AutomaticDelay = 0;
            // 
            // toolTip6
            // 
            this.toolTip6.AutomaticDelay = 0;
            // 
            // toolTip7
            // 
            this.toolTip7.AutomaticDelay = 0;
            // 
            // toolTip8
            // 
            this.toolTip8.AutomaticDelay = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonSave.Location = new System.Drawing.Point(118, 360);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 43);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "&Save";
            this.toolTip6.SetToolTip(this.buttonSave, "Add to register");
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ContractTracer
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(703, 413);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.listViewInfo);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.contactedBox);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ContractTracer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracer";
            this.TransparencyKey = System.Drawing.SystemColors.WindowFrame;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.CheckBox contactedBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox lastBox;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.ListView listViewInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.MaskedTextBox phoneBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
