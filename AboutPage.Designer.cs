
namespace Project
{
    partial class AboutPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutPage));
            this.labelAbout = new System.Windows.Forms.Label();
            this.textAbout = new System.Windows.Forms.TextBox();
            this.buttonOkay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAbout
            // 
            this.labelAbout.BackColor = System.Drawing.Color.SlateGray;
            this.labelAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbout.Location = new System.Drawing.Point(0, 0);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(387, 30);
            this.labelAbout.TabIndex = 0;
            this.labelAbout.Text = "Information Regarding Final Project";
            this.labelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textAbout
            // 
            this.textAbout.Location = new System.Drawing.Point(12, 32);
            this.textAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textAbout.Multiline = true;
            this.textAbout.Name = "textAbout";
            this.textAbout.ReadOnly = true;
            this.textAbout.Size = new System.Drawing.Size(362, 224);
            this.textAbout.TabIndex = 1;
            this.textAbout.Text = resources.GetString("textAbout.Text");
            this.textAbout.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonOkay
            // 
            this.buttonOkay.Location = new System.Drawing.Point(120, 272);
            this.buttonOkay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOkay.Name = "buttonOkay";
            this.buttonOkay.Size = new System.Drawing.Size(90, 32);
            this.buttonOkay.TabIndex = 2;
            this.buttonOkay.Text = "OK";
            this.buttonOkay.UseVisualStyleBackColor = true;
            this.buttonOkay.Click += new System.EventHandler(this.buttonOkay_Click);
            // 
            // AboutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 318);
            this.Controls.Add(this.buttonOkay);
            this.Controls.Add(this.textAbout);
            this.Controls.Add(this.labelAbout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AboutPage";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.TextBox textAbout;
        private System.Windows.Forms.Button buttonOkay;
    }
}