using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Kyrsach
{
    public partial class Test_diff_color : Form
    {
        FileEditor csv = new FileEditor("reult.csv");
        private int[] answer;
        private int[] answer2;
        private int number;
        private int color;
        private char[] otvet;
        private double []c;
        private Random rand = new Random();
        System.Threading.Thread next_form;
        private int i = 0;
        public int timermin=0;
        public int timersec=0;
        public int[,] timerfoul;
        Timer timer1 = new Timer();
        public int min = 0;
        public int sec = 0;
        int s = 0;
        public Test_diff_color()
        {
            c = new double[] { 0.9, 0.92, 0.94, 0.96 };
            otvet = new char[4];
            answer = new int[4];
            answer2 = new int[4];
            timerfoul = new int[4, 2];
            InitializeComponent();
        }

        private void Test_diff_color_Load(object sender, EventArgs e)
        {
            label2.Hide();
            Answer1.Hide();
            Answer2.Hide();
            Answer3.Hide();
            Answer4.Hide();
            button1.Hide();
            richTextBox1.Hide();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        Point LastPoint4;
        private void Test_diff_color_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint4.X;
                this.Top += e.Y - LastPoint4.Y;
            }
        }

        private void Test_diff_color_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint4 = new Point(e.X, e.Y);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            next_form = new System.Threading.Thread(open);
            next_form.SetApartmentState(System.Threading.ApartmentState.STA);
            next_form.Start();
        }
        public void open(object obj)
        {
            Application.Run(new Form1());
        }
        private void Close_program_Click(object sender, EventArgs e)
        {
            csv.error();
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

        private void Red_test_Click(object sender, EventArgs e)
        {
            color = 0;
            hide();
            testing(i);
            i++;
        }
        private void Blue_test_Click(object sender, EventArgs e)
        {
            color = 1;
            hide();
            testing(i);
            i++;
        }

        private void Green_test_Click(object sender, EventArgs e)
        {
            color = 2;
            hide();
            testing(i);
            i++;
        }
        public void hide()
        {
            label1.Hide();
            Red_test.Hide();
            Blue_test.Hide();
            Green_test.Hide();
            label2.Show();
            Answer1.Show();
            Answer2.Show();
            Answer3.Show();
            Answer4.Show();
            button1.Show();
            richTextBox1.Show();
        }
        public void testing(int i)
        {
            int count=0;
            int trueans = 0;
            if (i == 4) {
                button1.Enabled = false;
                for (int j = 0; j < 4; j++)
                {
                    if (answer[j] == answer2[j]) { otvet[count++] = '+'; trueans++; }
                    else otvet[count++] = '-';
                }
                    if (color == 0)
                    {
                        for (int j = 0; j < 4; j++) csv.writefile(otvet[j].ToString(), timerfoul[j, 0], timerfoul[j, 1]);
                    for (int p = 0; p < 8; p++) csv.writefile(" ");
                }
                    else if (color == 1)
                    {
                        for(int p =0;p<4;p++) csv.writefile(" ");
                        for (int j = 0; j < 4; j++) csv.writefile(otvet[j].ToString(), timerfoul[j, 0], timerfoul[j, 1]);
                    for (int p = 0; p < 4; p++) csv.writefile(" ");
                }
                    else
                    {
                        for (int p = 0; p < 8; p++) csv.writefile(" ");
                        for (int j = 0; j < 4; j++) csv.writefile(otvet[j].ToString(),timerfoul[j,0],timerfoul[j,1]);
                    }
                if (color == 0) 
                {
                    if (trueans > 3) csv.writeresult(min,sec,"Все добре"," ", " ");
                    else csv.writeresult(min,sec, "Присутні відхилення", " ", " ");
                }
                else if (color == 1) 
                {
                    if (trueans > 3) csv.writeresult(min,sec," ", "Все добре", " ");
                    else csv.writeresult(min,sec," ", "Присутні відхилення", " ");
                }
                else
                {
                    if (trueans > 3) csv.writeresult(min,sec," "," ", "Все добре");
                    else csv.writeresult(min,sec," "," ", "Присутні відхилення");
                }
                this.Close();
                next_form = new System.Threading.Thread(open);
                next_form.SetApartmentState(System.Threading.ApartmentState.STA);
                next_form.Start();
            }
            else
            {
                number = rnd(100);
                if (color == 0)
                {
                    label2.Text = Convert.ToString(number);
                    Answer1.Text = Convert.ToString(number);
                    Answer2.Text = Convert.ToString(rnd(100));
                    Answer3.Text = Convert.ToString(rnd(100));
                }
                else if (color == 1)
                {
                    label2.Text = Convert.ToString(number);
                    Answer1.Text = Convert.ToString(rnd(100));
                    Answer2.Text = Convert.ToString(number);
                    Answer3.Text = Convert.ToString(rnd(100));
                }
                else if (color == 2)
                {
                    label2.Text = Convert.ToString(number);
                    Answer1.Text = Convert.ToString(rnd(100));
                    Answer2.Text = Convert.ToString(rnd(100));
                    Answer3.Text = Convert.ToString(number);
                }
                Color c1 = Color.White;
                if (color == 0)
                {
                    c1 = Color.Red;
                    label2.ForeColor = Color.Red;
                }
                else if (color == 1)
                {
                    c1 = Color.Blue;
                    label2.ForeColor = Color.Blue;
                }
                else if (color == 2)
                {
                    c1 = Color.Green;
                    label2.ForeColor = Color.Green;
                }
                label2.BackColor = Color.FromArgb(c1.A,
        (int)(c1.R * c[i]), (int)(c1.G * c[i]), (int)(c1.B * c[i]));
            } 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            if (timersec == 60)
            {
                min++;
                timermin++;
                sec = 0;
                timersec = 0;
            }
            sec++;
            timersec++;
        }
        public int rnd(int j)
        {
            int p = rand.Next(1, j + 1);
            return p;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerfoul[s,0] = timermin;
            timerfoul[s++,1] = timersec;
            timersec = 0;
            timermin = 0;
            timer1.Start();
            if (Answer1.Checked)
            {
               answer[i-1] = Convert.ToInt32(Answer1.Text); Answer1.Checked = false;
            }
            else if (Answer2.Checked)
            {
                answer[i-1] = Convert.ToInt32(Answer2.Text); Answer2.Checked = false;
            }
            else if (Answer3.Checked)
            {
                Answer3.Checked = false; answer[i-1] = Convert.ToInt32(Answer3.Text);
            }
            else if (Answer4.Checked)
            {
                answer[i-1] = 00; Answer4.Checked = false;
            }
            answer2[i-1] = number;
            testing(i);
            i++;
        }

        private void back_button_MouseEnter(object sender, EventArgs e)
        {
            back_button.ForeColor = Color.Green;
        }

        private void back_button_MouseLeave(object sender, EventArgs e)
        {
            back_button.ForeColor = Color.White;
        }

        private void back_button_Click_1(object sender, EventArgs e)
        {
            csv.error();
            this.Close();
            next_form = new System.Threading.Thread(open);
            next_form.SetApartmentState(System.Threading.ApartmentState.STA);
            next_form.Start();
        }
    }
}
