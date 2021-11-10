﻿
namespace FrontendApplication
{
    partial class Form3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DebugViewButton = new System.Windows.Forms.Button();
            this.ViewCheckBox = new System.Windows.Forms.CheckBox();
            this.CurrentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstNameColumn,
            this.LastNameColumn});
            this.dataGridView1.Location = new System.Drawing.Point(3, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(276, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.DataPropertyName = "FirstName";
            this.FirstNameColumn.HeaderText = "First";
            this.FirstNameColumn.Name = "FirstNameColumn";
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.DataPropertyName = "LastName";
            this.LastNameColumn.HeaderText = "Last";
            this.LastNameColumn.Name = "LastNameColumn";
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(12, 244);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(105, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(17, 202);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.PlaceholderText = "Enter first name";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.FirstNameTextBox.TabIndex = 2;
            this.FirstNameTextBox.Text = "Karen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "First name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(173, 202);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.PlaceholderText = "Enter last name";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.LastNameTextBox.TabIndex = 4;
            this.LastNameTextBox.Text = "Payne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last name";
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location = new System.Drawing.Point(174, 244);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(105, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DebugViewButton
            // 
            this.DebugViewButton.Enabled = false;
            this.DebugViewButton.Image = ((System.Drawing.Image)(resources.GetObject("DebugViewButton.Image")));
            this.DebugViewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DebugViewButton.Location = new System.Drawing.Point(12, 273);
            this.DebugViewButton.Name = "DebugViewButton";
            this.DebugViewButton.Size = new System.Drawing.Size(105, 23);
            this.DebugViewButton.TabIndex = 7;
            this.DebugViewButton.Text = "  Debug view";
            this.DebugViewButton.UseVisualStyleBackColor = true;
            this.DebugViewButton.Click += new System.EventHandler(this.DebugViewButton_Click);
            // 
            // ViewCheckBox
            // 
            this.ViewCheckBox.AutoSize = true;
            this.ViewCheckBox.Location = new System.Drawing.Point(126, 274);
            this.ViewCheckBox.Name = "ViewCheckBox";
            this.ViewCheckBox.Size = new System.Drawing.Size(80, 19);
            this.ViewCheckBox.TabIndex = 8;
            this.ViewCheckBox.Text = "Long view";
            this.ViewCheckBox.UseVisualStyleBackColor = true;
            // 
            // CurrentButton
            // 
            this.CurrentButton.Enabled = false;
            this.CurrentButton.Image = global::FrontendApplication.Properties.Resources.Item;
            this.CurrentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurrentButton.Location = new System.Drawing.Point(12, 305);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(261, 23);
            this.CurrentButton.TabIndex = 9;
            this.CurrentButton.Text = "Currrent";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 353);
            this.Controls.Add(this.CurrentButton);
            this.Controls.Add(this.ViewCheckBox);
            this.Controls.Add(this.DebugViewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bingo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DebugViewButton;
        private System.Windows.Forms.CheckBox ViewCheckBox;
        private System.Windows.Forms.Button CurrentButton;
    }
}