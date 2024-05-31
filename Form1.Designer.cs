namespace Ch14_Lab8
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_ListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.exit_Button = new System.Windows.Forms.Button();
            this.opening_Label = new System.Windows.Forms.Label();
            this.closing_Label = new System.Windows.Forms.Label();
            this.high_Label = new System.Windows.Forms.Label();
            this.low_Label = new System.Windows.Forms.Label();
            this.date_Label = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.value_TextBox = new System.Windows.Forms.TextBox();
            this.cloestDate_Button = new System.Windows.Forms.Button();
            this.allDates_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_ListBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select A Date";
            // 
            // date_ListBox
            // 
            this.date_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ListBox.FormattingEnabled = true;
            this.date_ListBox.Location = new System.Drawing.Point(6, 19);
            this.date_ListBox.Name = "date_ListBox";
            this.date_ListBox.Size = new System.Drawing.Size(188, 173);
            this.date_ListBox.TabIndex = 0;
            this.date_ListBox.SelectedIndexChanged += new System.EventHandler(this.date_ListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opening_Label);
            this.groupBox2.Location = new System.Drawing.Point(227, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opening Value";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.high_Label);
            this.groupBox3.Location = new System.Drawing.Point(227, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 64);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Highest Value";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.date_Label);
            this.groupBox4.Location = new System.Drawing.Point(227, 152);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 64);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Date";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.closing_Label);
            this.groupBox5.Location = new System.Drawing.Point(433, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 64);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Closing Value";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.low_Label);
            this.groupBox6.Location = new System.Drawing.Point(433, 82);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 64);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Lowest Value";
            // 
            // exit_Button
            // 
            this.exit_Button.BackColor = System.Drawing.Color.Tomato;
            this.exit_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit_Button.Location = new System.Drawing.Point(12, 309);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(621, 23);
            this.exit_Button.TabIndex = 3;
            this.exit_Button.Text = "EXIT";
            this.exit_Button.UseVisualStyleBackColor = false;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // opening_Label
            // 
            this.opening_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.opening_Label.Location = new System.Drawing.Point(6, 19);
            this.opening_Label.Name = "opening_Label";
            this.opening_Label.Size = new System.Drawing.Size(188, 37);
            this.opening_Label.TabIndex = 0;
            this.opening_Label.Text = "label1";
            this.opening_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closing_Label
            // 
            this.closing_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.closing_Label.Location = new System.Drawing.Point(6, 19);
            this.closing_Label.Name = "closing_Label";
            this.closing_Label.Size = new System.Drawing.Size(188, 37);
            this.closing_Label.TabIndex = 1;
            this.closing_Label.Text = "label2";
            this.closing_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // high_Label
            // 
            this.high_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.high_Label.Location = new System.Drawing.Point(6, 19);
            this.high_Label.Name = "high_Label";
            this.high_Label.Size = new System.Drawing.Size(188, 37);
            this.high_Label.TabIndex = 1;
            this.high_Label.Text = "label3";
            this.high_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // low_Label
            // 
            this.low_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.low_Label.Location = new System.Drawing.Point(6, 19);
            this.low_Label.Name = "low_Label";
            this.low_Label.Size = new System.Drawing.Size(188, 37);
            this.low_Label.TabIndex = 1;
            this.low_Label.Text = "label4";
            this.low_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_Label
            // 
            this.date_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.date_Label.Location = new System.Drawing.Point(8, 17);
            this.date_Label.Name = "date_Label";
            this.date_Label.Size = new System.Drawing.Size(391, 37);
            this.date_Label.TabIndex = 1;
            this.date_Label.Text = "label5";
            this.date_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.allDates_Button);
            this.groupBox7.Controls.Add(this.cloestDate_Button);
            this.groupBox7.Controls.Add(this.value_TextBox);
            this.groupBox7.Location = new System.Drawing.Point(12, 222);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(624, 81);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Search Closing Value Dates";
            // 
            // value_TextBox
            // 
            this.value_TextBox.Location = new System.Drawing.Point(6, 19);
            this.value_TextBox.Name = "value_TextBox";
            this.value_TextBox.Size = new System.Drawing.Size(609, 20);
            this.value_TextBox.TabIndex = 0;
            // 
            // cloestDate_Button
            // 
            this.cloestDate_Button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cloestDate_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cloestDate_Button.Location = new System.Drawing.Point(171, 45);
            this.cloestDate_Button.Name = "cloestDate_Button";
            this.cloestDate_Button.Size = new System.Drawing.Size(126, 23);
            this.cloestDate_Button.TabIndex = 1;
            this.cloestDate_Button.Text = "First Closest Date";
            this.cloestDate_Button.UseVisualStyleBackColor = false;
            // 
            // allDates_Button
            // 
            this.allDates_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.allDates_Button.ForeColor = System.Drawing.Color.AliceBlue;
            this.allDates_Button.Location = new System.Drawing.Point(303, 45);
            this.allDates_Button.Name = "allDates_Button";
            this.allDates_Button.Size = new System.Drawing.Size(126, 23);
            this.allDates_Button.TabIndex = 2;
            this.allDates_Button.Text = "All Dates";
            this.allDates_Button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 341);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.form_OnLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox date_ListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Label opening_Label;
        private System.Windows.Forms.Label high_Label;
        private System.Windows.Forms.Label date_Label;
        private System.Windows.Forms.Label closing_Label;
        private System.Windows.Forms.Label low_Label;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button allDates_Button;
        private System.Windows.Forms.Button cloestDate_Button;
        private System.Windows.Forms.TextBox value_TextBox;
    }
}

