namespace Kyrsach
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.Close_program = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Answer1 = new System.Windows.Forms.RadioButton();
            this.Answer3 = new System.Windows.Forms.RadioButton();
            this.Answer2 = new System.Windows.Forms.RadioButton();
            this.Answer4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Close_program
            // 
            this.Close_program.AutoSize = true;
            this.Close_program.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Close_program.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_program.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_program.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_program.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Close_program.Location = new System.Drawing.Point(479, 0);
            this.Close_program.Name = "Close_program";
            this.Close_program.Size = new System.Drawing.Size(24, 29);
            this.Close_program.TabIndex = 7;
            this.Close_program.Text = "x";
            this.Close_program.Click += new System.EventHandler(this.Close_program_Click);
            this.Close_program.MouseEnter += new System.EventHandler(this.Close_program_MouseEnter);
            this.Close_program.MouseLeave += new System.EventHandler(this.Close_program_MouseLeave);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_button.Location = new System.Drawing.Point(0, 0);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(62, 29);
            this.back_button.TabIndex = 8;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            this.back_button.MouseEnter += new System.EventHandler(this.back_button_MouseEnter);
            this.back_button.MouseLeave += new System.EventHandler(this.back_button_MouseLeave);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(101, 269);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(294, 31);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "        Виберіть число яке ви бачите";
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.BackColor = System.Drawing.Color.DimGray;
            this.Answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer1.Location = new System.Drawing.Point(101, 334);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(101, 20);
            this.Answer1.TabIndex = 11;
            this.Answer1.TabStop = true;
            this.Answer1.Text = "radioButton1";
            this.Answer1.UseVisualStyleBackColor = false;
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.BackColor = System.Drawing.Color.DimGray;
            this.Answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer3.Location = new System.Drawing.Point(326, 334);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(101, 20);
            this.Answer3.TabIndex = 12;
            this.Answer3.TabStop = true;
            this.Answer3.Text = "radioButton2";
            this.Answer3.UseVisualStyleBackColor = false;
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.BackColor = System.Drawing.Color.DimGray;
            this.Answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2.Location = new System.Drawing.Point(101, 397);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(101, 20);
            this.Answer2.TabIndex = 13;
            this.Answer2.TabStop = true;
            this.Answer2.Text = "radioButton3";
            this.Answer2.UseVisualStyleBackColor = false;
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.BackColor = System.Drawing.Color.DimGray;
            this.Answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer4.Location = new System.Drawing.Point(326, 397);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(69, 20);
            this.Answer4.TabIndex = 14;
            this.Answer4.TabStop = true;
            this.Answer4.Text = "Нічого";
            this.Answer4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 190);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Відповісти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(502, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Close_program);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TestForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TestForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Close_program;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.RadioButton Answer1;
        public System.Windows.Forms.RadioButton Answer3;
        public System.Windows.Forms.RadioButton Answer2;
        public System.Windows.Forms.RadioButton Answer4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
    }
}