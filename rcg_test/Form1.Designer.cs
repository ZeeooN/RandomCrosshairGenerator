namespace rcg_test
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fileCfgName = new System.Windows.Forms.TextBox();
            this.fileTxtName = new System.Windows.Forms.TextBox();
            this.setTxtName = new System.Windows.Forms.Button();
            this.setCfgName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.OutputTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OutputTextBox.Location = new System.Drawing.Point(12, 92);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.OutputTextBox.Size = new System.Drawing.Size(436, 187);
            this.OutputTextBox.TabIndex = 0;
            this.OutputTextBox.Text = resources.GetString("OutputTextBox.Text");
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate crosshair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileCfgName
            // 
            this.fileCfgName.Location = new System.Drawing.Point(12, 62);
            this.fileCfgName.Name = "fileCfgName";
            this.fileCfgName.Size = new System.Drawing.Size(192, 20);
            this.fileCfgName.TabIndex = 2;
            // 
            // fileTxtName
            // 
            this.fileTxtName.Location = new System.Drawing.Point(12, 25);
            this.fileTxtName.Name = "fileTxtName";
            this.fileTxtName.Size = new System.Drawing.Size(192, 20);
            this.fileTxtName.TabIndex = 3;
            this.fileTxtName.TextChanged += new System.EventHandler(this.fileTxtName_TextChanged);
            // 
            // setTxtName
            // 
            this.setTxtName.Location = new System.Drawing.Point(210, 26);
            this.setTxtName.Name = "setTxtName";
            this.setTxtName.Size = new System.Drawing.Size(80, 19);
            this.setTxtName.TabIndex = 4;
            this.setTxtName.Text = "Set";
            this.setTxtName.UseVisualStyleBackColor = true;
            this.setTxtName.Click += new System.EventHandler(this.setTxtName_Click);
            // 
            // setCfgName
            // 
            this.setCfgName.Location = new System.Drawing.Point(210, 63);
            this.setCfgName.Name = "setCfgName";
            this.setCfgName.Size = new System.Drawing.Size(80, 19);
            this.setCfgName.TabIndex = 5;
            this.setCfgName.Text = "Set";
            this.setCfgName.UseVisualStyleBackColor = true;
            this.setCfgName.Click += new System.EventHandler(this.setCfgName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cfg path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Txt path:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(460, 291);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setCfgName);
            this.Controls.Add(this.setTxtName);
            this.Controls.Add(this.fileTxtName);
            this.Controls.Add(this.fileCfgName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutputTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(476, 330);
            this.MinimumSize = new System.Drawing.Size(476, 330);
            this.Name = "Form1";
            this.Text = "Random Crosshair Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fileCfgName;
        private System.Windows.Forms.TextBox fileTxtName;
        private System.Windows.Forms.Button setTxtName;
        private System.Windows.Forms.Button setCfgName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

