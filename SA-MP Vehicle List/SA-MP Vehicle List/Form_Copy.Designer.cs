namespace SA_MP_Vehicle_List
{
    partial class Form_Copy
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
            this.RichTextBox_Copy = new System.Windows.Forms.RichTextBox();
            this.Label_Copy = new System.Windows.Forms.Label();
            this.Button_Copy = new System.Windows.Forms.Button();
            this.StatusStrip_Copy = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // RichTextBox_Copy
            // 
            this.RichTextBox_Copy.Location = new System.Drawing.Point(12, 38);
            this.RichTextBox_Copy.Name = "RichTextBox_Copy";
            this.RichTextBox_Copy.ReadOnly = true;
            this.RichTextBox_Copy.Size = new System.Drawing.Size(251, 199);
            this.RichTextBox_Copy.TabIndex = 0;
            this.RichTextBox_Copy.Text = "";
            // 
            // Label_Copy
            // 
            this.Label_Copy.AutoSize = true;
            this.Label_Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Copy.Location = new System.Drawing.Point(8, 14);
            this.Label_Copy.Name = "Label_Copy";
            this.Label_Copy.Size = new System.Drawing.Size(131, 20);
            this.Label_Copy.TabIndex = 1;
            this.Label_Copy.Text = "Extracted array";
            // 
            // Button_Copy
            // 
            this.Button_Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Copy.Location = new System.Drawing.Point(188, 11);
            this.Button_Copy.Name = "Button_Copy";
            this.Button_Copy.Size = new System.Drawing.Size(75, 23);
            this.Button_Copy.TabIndex = 2;
            this.Button_Copy.Text = "Copy";
            this.Button_Copy.UseVisualStyleBackColor = true;
            this.Button_Copy.Click += new System.EventHandler(this.Button_Copy_Click);
            // 
            // StatusStrip_Copy
            // 
            this.StatusStrip_Copy.Location = new System.Drawing.Point(0, 250);
            this.StatusStrip_Copy.Name = "StatusStrip_Copy";
            this.StatusStrip_Copy.Size = new System.Drawing.Size(275, 22);
            this.StatusStrip_Copy.TabIndex = 3;
            this.StatusStrip_Copy.Text = "statusStrip1";
            // 
            // Form_Copy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 272);
            this.Controls.Add(this.StatusStrip_Copy);
            this.Controls.Add(this.Button_Copy);
            this.Controls.Add(this.Label_Copy);
            this.Controls.Add(this.RichTextBox_Copy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Copy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vehicle List Copy";
            this.Load += new System.EventHandler(this.Form_Copy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBox_Copy;
        private System.Windows.Forms.Label Label_Copy;
        private System.Windows.Forms.Button Button_Copy;
        private System.Windows.Forms.StatusStrip StatusStrip_Copy;
    }
}