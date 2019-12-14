namespace Kyrsach
{
    partial class AboutCreator
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
            this.back_button1 = new System.Windows.Forms.Button();
            this.Close_program = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_button1
            // 
            this.back_button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_button1.Location = new System.Drawing.Point(0, -1);
            this.back_button1.Name = "back_button1";
            this.back_button1.Size = new System.Drawing.Size(62, 29);
            this.back_button1.TabIndex = 8;
            this.back_button1.Text = "Back";
            this.back_button1.UseVisualStyleBackColor = false;
            this.back_button1.Click += new System.EventHandler(this.back_button1_Click);
            this.back_button1.MouseEnter += new System.EventHandler(this.back_button1_MouseEnter);
            this.back_button1.MouseLeave += new System.EventHandler(this.back_button1_MouseLeave);
            // 
            // Close_program
            // 
            this.Close_program.AutoSize = true;
            this.Close_program.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Close_program.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_program.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_program.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_program.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Close_program.Location = new System.Drawing.Point(478, -1);
            this.Close_program.Name = "Close_program";
            this.Close_program.Size = new System.Drawing.Size(24, 29);
            this.Close_program.TabIndex = 9;
            this.Close_program.Text = "x";
            this.Close_program.Click += new System.EventHandler(this.Close_program_Click);
            this.Close_program.MouseEnter += new System.EventHandler(this.Close_program_MouseEnter);
            this.Close_program.MouseLeave += new System.EventHandler(this.Close_program_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 483);
            this.label1.TabIndex = 10;
            this.label1.Text = "Алгоритми:Каранда Владислав,Омельченко Станислав\r\n\r\nРобота з даними:Омельченко Ст" +
    "анислав\r\n\r\nГрафічний дизайн:Кравченко Владислав\r\n\r\nГрупа:КНТ-128\r\n";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // AboutCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kyrsach.Properties.Resources._86_2560_1600_beautypic_ru;
            this.ClientSize = new System.Drawing.Size(502, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close_program);
            this.Controls.Add(this.back_button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutCreator";
            this.Text = "AboutCreator";
            this.Load += new System.EventHandler(this.AboutCreator_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AboutCreator_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AboutCreator_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button1;
        private System.Windows.Forms.Label Close_program;
        private System.Windows.Forms.Label label1;
    }
}