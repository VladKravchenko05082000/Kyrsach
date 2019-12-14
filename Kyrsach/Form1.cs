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
    public partial class Form1 : Form
    {
        
        Thread next_form;
        FileEditor csv;
        public Form1()
        {
            csv = new FileEditor("reult.csv");
            InitializeComponent();
        }
        private void Start_the_test_Click(object sender, EventArgs e)
        {
            this.Close();
            next_form = new Thread(open);
            next_form.SetApartmentState(ApartmentState.STA);
            next_form.Start();
        }

        private void About_daltonizm_Click(object sender, EventArgs e)
        {
            this.Close();
            next_form = new Thread(open2);
            next_form.SetApartmentState(ApartmentState.STA);
            next_form.Start();
        }
        public void open(object obj)
        {
            Application.Run(new Test_Form_Name());

        }
        public void open2(object obj2)
        {
            Application.Run(new InfoForm());

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
        Point LastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void Test_diff_color_Click(object sender, EventArgs e)
        {
            this.Close();
            next_form = new Thread(open3);
            next_form.SetApartmentState(ApartmentState.STA);
            next_form.Start();
        }
        public void open3(object obj3)
        {
            Application.Run(new Test_Form_Name_diff());
        }

        private void Result_button_Click(object sender, EventArgs e)
        {
            csv.readfile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AboutCreator_Form_Click(object sender, EventArgs e)
        {
            this.Close();
            next_form = new Thread(open4);
            next_form.SetApartmentState(ApartmentState.STA);
            next_form.Start();
        }
        public void open4(object obj4)
        {
            Application.Run(new AboutCreator());
        }      

        private void Start_the_test_Click_2(object sender, EventArgs e)
        {
            this.Close();
            next_form = new Thread(open);
            next_form.SetApartmentState(ApartmentState.STA);
            next_form.Start();
        }
    }
}
