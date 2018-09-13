using System;
namespace WindowsFormsApp1
{
    partial class NameApplication
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
            this.InputText = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InputText.Location = new System.Drawing.Point(213, 95);
            this.InputText.Margin = new System.Windows.Forms.Padding(2);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(203, 38);
            this.InputText.TabIndex = 0;
            // 
            // InputLabel
            // 
            this.InputLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.ForeColor = System.Drawing.Color.Yellow;
            this.InputLabel.Location = new System.Drawing.Point(55, 98);
            this.InputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(154, 28);
            this.InputLabel.TabIndex = 1;
            this.InputLabel.Text = "Enter your name:";
            this.InputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(239, 164);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(141, 30);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // outputText
            // 
            this.outputText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.ForeColor = System.Drawing.Color.Yellow;
            this.outputText.Location = new System.Drawing.Point(100, 251);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(400, 45);
            this.outputText.TabIndex = 3;
            this.outputText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InputText);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NameApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name Retrieval App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label outputText;
    }
}
       


