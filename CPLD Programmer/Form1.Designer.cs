namespace CPLD_Programmer
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.compCheckBox = new System.Windows.Forms.CheckBox();
            this.verbCheckBox = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logTxtBox = new System.Windows.Forms.TextBox();
            this.deleteCheckBox = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // compCheckBox
            // 
            this.compCheckBox.AutoSize = true;
            this.compCheckBox.Checked = true;
            this.compCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compCheckBox.Location = new System.Drawing.Point(15, 41);
            this.compCheckBox.Name = "compCheckBox";
            this.compCheckBox.Size = new System.Drawing.Size(126, 21);
            this.compCheckBox.TabIndex = 4;
            this.compCheckBox.Text = "Compare Mode";
            this.compCheckBox.UseVisualStyleBackColor = true;
            // 
            // verbCheckBox
            // 
            this.verbCheckBox.AutoSize = true;
            this.verbCheckBox.Checked = true;
            this.verbCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.verbCheckBox.Location = new System.Drawing.Point(15, 68);
            this.verbCheckBox.Name = "verbCheckBox";
            this.verbCheckBox.Size = new System.Drawing.Size(83, 21);
            this.verbCheckBox.TabIndex = 5;
            this.verbCheckBox.Text = "Verbose";
            this.verbCheckBox.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "SVF Files|*.svf";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "SVF File:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(116, 134);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 17);
            this.idLabel.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logTxtBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 293);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logs";
            // 
            // logTxtBox
            // 
            this.logTxtBox.Location = new System.Drawing.Point(7, 23);
            this.logTxtBox.Multiline = true;
            this.logTxtBox.Name = "logTxtBox";
            this.logTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTxtBox.Size = new System.Drawing.Size(487, 263);
            this.logTxtBox.TabIndex = 0;
            // 
            // deleteCheckBox
            // 
            this.deleteCheckBox.AutoSize = true;
            this.deleteCheckBox.Checked = true;
            this.deleteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteCheckBox.Location = new System.Drawing.Point(15, 95);
            this.deleteCheckBox.Name = "deleteCheckBox";
            this.deleteCheckBox.Size = new System.Drawing.Size(228, 21);
            this.deleteCheckBox.TabIndex = 6;
            this.deleteCheckBox.Text = "Delete log files after completion";
            this.deleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(526, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoToolTip = true;
            this.statusLabel.BackColor = System.Drawing.Color.Silver;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(60, 20);
            this.statusLabel.Text = "Waiting";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(393, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "Clear logs";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 494);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.deleteCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.verbCheckBox);
            this.Controls.Add(this.compCheckBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CPLD Programmer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox compCheckBox;
        private System.Windows.Forms.CheckBox verbCheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox logTxtBox;
        private System.Windows.Forms.CheckBox deleteCheckBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

