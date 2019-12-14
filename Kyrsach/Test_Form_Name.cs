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
    public partial class Test_Form_Name : Form
    {
        FileEditor csv;
        Thread next_form;
        public Test_Form_Name()
        {
            csv = new FileEditor("reult.csv");
            InitializeComponent();
        }
        Point LastPoint;
        private void Test_Form_Name_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void Test_Form_Name_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void Back_button_Click(object sender, EventArgs e)
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
        private void Back_button_MouseEnter(object sender, EventArgs e)
        {
            Close_program.ForeColor = Color.Green;
        }

        private void Back_button_MouseLeave(object sender, EventArgs e)
        {
            Close_program.ForeColor = Color.White;
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
        private void Button_name_test_form_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == " ") csv.writefile("?");
            else csv.writefile(textBox1.Text);
            csv.writedata();
            this.Close();
            next_form = new Thread(open1);
            next_form.SetApartmentState(ApartmentState.STA);
            next_form.Start();         
        }
        public void open1(object obj)
        {
            Application.Run(new TestForm());
        }

        private void Test_Form_Name_Load(object sender, EventArgs e)
        {

        }
    }
}
