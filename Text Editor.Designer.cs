
namespace Project
{
    partial class Text_Editor
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
            this.textboxeditor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textboxeditor
            // 
            this.textboxeditor.Location = new System.Drawing.Point(12, 12);
            this.textboxeditor.Name = "textboxeditor";
            this.textboxeditor.Size = new System.Drawing.Size(776, 426);
            this.textboxeditor.TabIndex = 0;
            this.textboxeditor.Text = "";
            // 
            // Text_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxeditor);
            this.Name = "Text_Editor";
            this.Text = "Text_Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textboxeditor;
    }
}