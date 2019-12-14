namespace Kyrsach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close_program = new System.Windows.Forms.Label();
            this.Start_the_test = new Kyrsach.Circlebutton();
            this.AboutCreator_Form = new Kyrsach.Circlebutton();
            this.Result_button = new Kyrsach.Circlebutton();
            this.Test_diff_color = new Kyrsach.Circlebutton();
            this.About_daltonizm = new Kyrsach.Circlebutton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Kyrsach.Properties.Resources.gnome_color_browser;
            this.pictureBox1.Image = global::Kyrsach.Properties.Resources._18_Retina_Ready_Web_Design_256;
            this.pictureBox1.Location = new System.Drawing.Point(197, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Close_program
            // 
            this.Close_program.AutoSize = true;
            this.Close_program.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Close_program.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_program.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_program.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_program.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Close_program.Location = new System.Drawing.Point(480, 0);
            this.Close_program.Name = "Close_program";
            this.Close_program.Size = new System.Drawing.Size(24, 29);
            this.Close_program.TabIndex = 5;
            this.Close_program.Text = "x";
            this.Close_program.Click += new System.EventHandler(this.Close_program_Click);
            this.Close_program.MouseEnter += new System.EventHandler(this.Close_program_MouseEnter);
            this.Close_program.MouseLeave += new System.EventHandler(this.Close_program_MouseLeave);
            // 
            // Start_the_test
            // 
            this.Start_the_test.BackColor = System.Drawing.Color.DimGray;
            this.Start_the_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_the_test.Location = new System.Drawing.Point(139, 136);
            this.Start_the_test.Name = "Start_the_test";
            this.Start_the_test.Size = new System.Drawing.Size(246, 51);
            this.Start_the_test.TabIndex = 9;
            this.Start_the_test.Text = "Розпочати тест";
            this.Start_the_test.UseVisualStyleBackColor = false;
            this.Start_the_test.Click += new System.EventHandler(this.Start_the_test_Click_2);
            // 
            // AboutCreator_Form
            // 
            this.AboutCreator_Form.BackColor = System.Drawing.Color.DimGray;
            this.AboutCreator_Form.FlatAppearance.BorderSize = 0;
            this.AboutCreator_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutCreator_Form.Location = new System.Drawing.Point(139, 341);
            this.AboutCreator_Form.Name = "AboutCreator_Form";
            this.AboutCreator_Form.Size = new System.Drawing.Size(246, 51);
            this.AboutCreator_Form.TabIndex = 8;
            this.AboutCreator_Form.Text = "О розробниках";
            this.AboutCreator_Form.UseVisualStyleBackColor = false;
            this.AboutCreator_Form.Click += new System.EventHandler(this.AboutCreator_Form_Click);
            // 
            // Result_button
            // 
            this.Result_button.BackColor = System.Drawing.Color.DimGray;
            this.Result_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Result_button.Location = new System.Drawing.Point(139, 272);
            this.Result_button.Name = "Result_button";
            this.Result_button.Size = new System.Drawing.Size(123, 51);
            this.Result_button.TabIndex = 7;
            this.Result_button.Text = "Результати тесту";
            this.Result_button.UseVisualStyleBackColor = false;
            this.Result_button.Click += new System.EventHandler(this.Result_button_Click);
            // 
            // Test_diff_color
            // 
            this.Test_diff_color.BackColor = System.Drawing.Color.DimGray;
            this.Test_diff_color.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Test_diff_color.FlatAppearance.BorderSize = 0;
            this.Test_diff_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Test_diff_color.Location = new System.Drawing.Point(139, 205);
            this.Test_diff_color.Name = "Test_diff_color";
            this.Test_diff_color.Size = new System.Drawing.Size(246, 51);
            this.Test_diff_color.TabIndex = 6;
            this.Test_diff_color.Text = "Тест за певним кольором";
            this.Test_diff_color.UseVisualStyleBackColor = false;
            this.Test_diff_color.Click += new System.EventHandler(this.Test_diff_color_Click);
            // 
            // About_daltonizm
            // 
            this.About_daltonizm.BackColor = System.Drawing.Color.DimGray;
            this.About_daltonizm.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.About_daltonizm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_daltonizm.Location = new System.Drawing.Point(268, 272);
            this.About_daltonizm.Name = "About_daltonizm";
            this.About_daltonizm.Size = new System.Drawing.Size(117, 51);
            this.About_daltonizm.TabIndex = 3;
            this.About_daltonizm.Text = "Про дальтонізм";
            this.About_daltonizm.UseVisualStyleBackColor = false;
            this.About_daltonizm.Click += new System.EventHandler(this.About_daltonizm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(502, 514);
            this.Controls.Add(this.Start_the_test);
            this.Controls.Add(this.AboutCreator_Form);
            this.Controls.Add(this.Result_button);
            this.Controls.Add(this.Test_diff_color);
            this.Controls.Add(this.Close_program);
            this.Controls.Add(this.About_daltonizm);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Circlebutton About_daltonizm;
        private System.Windows.Forms.Label Close_program;
        private Circlebutton Test_diff_color;
        private Circlebutton Result_button;
        private Circlebutton AboutCreator_Form;
        private Circlebutton Start_the_test;
    }
}

