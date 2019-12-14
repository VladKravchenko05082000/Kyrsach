namespace Kyrsach
{
    partial class Test_Form_Name_diff
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
            this.back_button = new System.Windows.Forms.Button();
            this.Close_program = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_name_test_form = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.back_button.TabIndex = 11;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.Back_button_Click);
            this.back_button.MouseEnter += new System.EventHandler(this.Back_button_MouseEnter);
            this.back_button.MouseLeave += new System.EventHandler(this.Back_button_MouseLeave);
            // 
            // Close_program
            // 
            this.Close_program.AutoSize = true;
            this.Close_program.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Close_program.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_program.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_program.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_program.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Close_program.Location = new System.Drawing.Point(462, 0);
            this.Close_program.Name = "Close_program";
            this.Close_program.Size = new System.Drawing.Size(24, 29);
            this.Close_program.TabIndex = 12;
            this.Close_program.Text = "x";
            this.Close_program.Click += new System.EventHandler(this.Close_program_Click);
            this.Close_program.MouseEnter += new System.EventHandler(this.Close_program_MouseEnter);
            this.Close_program.MouseLeave += new System.EventHandler(this.Close_program_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 145);
            this.textBox1.MaxLength = 17;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(179, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введіть ім\'я";
            // 
            // Button_name_test_form
            // 
            this.Button_name_test_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_name_test_form.Location = new System.Drawing.Point(185, 186);
            this.Button_name_test_form.Name = "Button_name_test_form";
            this.Button_name_test_form.Size = new System.Drawing.Size(136, 37);
            this.Button_name_test_form.TabIndex = 15;
            this.Button_name_test_form.Text = "Підтвердити";
            this.Button_name_test_form.UseVisualStyleBackColor = true;
            this.Button_name_test_form.Click += new System.EventHandler(this.Button_name_test_form_Click);
            // 
            // Test_Form_Name_diff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kyrsach.Properties.Resources._86_2560_1600_beautypic_ru;
            this.ClientSize = new System.Drawing.Size(486, 475);
            this.Controls.Add(this.Button_name_test_form);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Close_program);
            this.Controls.Add(this.back_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Test_Form_Name_diff";
            this.Text = "Test_Form_Name_diff";
            this.Load += new System.EventHandler(this.Test_Form_Name_diff_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Test_Form_Name_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Test_Form_Name_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label Close_program;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_name_test_form;
    }
}
