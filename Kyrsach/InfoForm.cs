using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Kyrsach
{
    public partial class InfoForm : Form
    {
        Thread next_form;
        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }

        private void Close_program_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_program_MouseEnter(object sender, EventArgs e)
        {
            Close_program.ForeColor = Color.Green;
        }

        private void Close_program_MouseLeave(object sender, EventArgs e)
        {
            Close_program.ForeColor = Color.White;
        }
        Point LastPoint1;
        private void InfoForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint1.X;
                this.Top += e.Y - LastPoint1.Y;
            }
        }

        private void InfoForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint1 = new Point(e.X, e.Y);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            next_form = new Thread(open);
            next_form.SetApartmentState(ApartmentState.STA);
            next_form.Start();
        }
        public void open(object obj)
        {
            Application.Run(new Form1());

        }

        private void back_button1_MouseEnter(object sender, EventArgs e)
        {
            back_button1.ForeColor = Color.Green;
        }

        private void back_button1_MouseLeave(object sender, EventArgs e)
        {
            back_button1.ForeColor = Color.White;
        }

        private void Information_of_daltonizm_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint1.X;
                this.Top += e.Y - LastPoint1.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint1 = new Point(e.X, e.Y);
        }
    }
}
