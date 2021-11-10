
namespace FrontendApplication
{
    partial class OtherControlsForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.UpdateFirstNameButton = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(13, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(291, 199);
            this.listBox1.TabIndex = 0;
            // 
            // UpdateFirstNameButton
            // 
            this.UpdateFirstNameButton.Location = new System.Drawing.Point(11, 218);
            this.UpdateFirstNameButton.Name = "UpdateFirstNameButton";
            this.UpdateFirstNameButton.Size = new System.Drawing.Size(98, 23);
            this.UpdateFirstNameButton.TabIndex = 1;
            this.UpdateFirstNameButton.Text = "Update First Name";
            this.UpdateFirstNameButton.UseVisualStyleBackColor = true;
            this.UpdateFirstNameButton.Click += new System.EventHandler(this.UpdateFirstNameButton_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(115, 220);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.PlaceholderText = "Enter replacement first name";
            this.FirstNameTextBox.Size = new System.Drawing.Size(189, 23);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // OtherControlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 255);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.UpdateFirstNameButton);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OtherControlsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button UpdateFirstNameButton;
        private System.Windows.Forms.TextBox FirstNameTextBox;
    }
}