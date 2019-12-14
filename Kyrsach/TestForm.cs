using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;




namespace Kyrsach
{
    public partial class TestForm : Form
    {
        public test tests;
        FileEditor csv = new FileEditor("reult.csv");
        public System.Threading.Thread next_form;
        public int timermin=0;
        public int timersec=0;
        Timer timer1 = new Timer();
        public int min=0;
        public int sec=0;
        public TestForm()
        {
            tests = new test(this);
            InitializeComponent();
        }
        private void TestForm_Load(object sender, EventArgs e)
        {
            tests.testing();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            csv.error();
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
        Point LastPoint2;
        private void TestForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint2.X;
                this.Top += e.Y - LastPoint2.Y;
            }
        }

        private void TestForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint2 = new Point(e.X, e.Y);
        }

        private void back_button_MouseEnter(object sender, EventArgs e)
        {
            back_button.ForeColor = Color.Green;
        }

        private void back_button_MouseLeave(object sender, EventArgs e)
        {
            back_button.ForeColor = Color.White;
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            tests.foultime[0] = min;
            tests.foultime[1] = sec;
            tests.timeans[tests.kolvotimer,0] = timermin;
            tests.timeans[tests.kolvotimer,1] = timersec;
            tests.kolvotimer++;
            timersec = 0;
            timermin = 0;
            timer1.Start();
            if (Answer1.Checked)
            {
                tests.answer[tests.i - 1, tests.cc[tests.i - 1] - 1] = Convert.ToInt32(Answer1.Text); Answer1.Checked = false;
            }
            else if (Answer2.Checked)
            {
                tests.answer[tests.i - 1, tests.cc[tests.i - 1] - 1] = Convert.ToInt32(Answer2.Text); Answer2.Checked = false;
            }
            else if (Answer3.Checked)
            {
                Answer3.Checked = false; tests.answer[tests.i - 1, tests.cc[tests.i - 1] - 1] = Convert.ToInt32(Answer3.Text);
            }
            else if (Answer4.Checked)
            {
                tests.answer[tests.i - 1, tests.cc[tests.i - 1] - 1] = 00; Answer4.Checked = false;
            }
            tests.answer2[tests.i - 1, tests.cc[tests.i - 1] - 1] = tests.number;

            tests.testing();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            if (timersec == 60)
            {
                min++;
                timermin++;
                sec=0;
                timersec = 0;
            }
            sec++;
            timersec++;
        }
    }
    public class test
    {
        TestForm form;
        private FileEditor edit;
        private string file = "reult.csv";
        public test(TestForm form)
        {
            this.form = form;
            cc = new int[3] { 0, 0, 0 };
            timeans = new int[12,2];
            foultime = new int[2];
            answer = new int[3, 4];
            answer2 = new int[3, 4];
            c = new double[] { 0.9, 0.92, 0.94, 0.96, 0.98 };
            edit = new FileEditor(file);
            result=new string[3];
        }
        public int[] cc;
        public double[] c;
        public int[,] answer;
        public int[,] answer2;
        public int i;
        public int[] foultime;
        public int kolvotimer;
        public int[,] timeans;
        string []result;
        public int number;
        private Random rand = new Random();
        public void open1(object obj)
        {
            Application.Run(new Form1());

        }
        public void testing()
        {

            if (cc[0] + cc[1] + cc[2] == 12)
            {
                form.button1.Enabled = false;
                int []count=new int[4]{0,0,0,0};
                int buftime=0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (answer[i, j] == answer2[i, j]) { edit.writefile("+",timeans[buftime,0],timeans[buftime++,1]); count[i]++; }
                        else edit.writefile("-", timeans[buftime,0], timeans[buftime++,1]);
                    }
                }
            for(int i=0;i<3;i++)
                {
                    if(count[i]<3)result[i]= "Присутні відхилення";
                    else result[i] = "Все добре";
                }
               edit.writeresult(foultime[0],foultime[1],result[0], result[1], result[2]);
               form.Close();
               form.next_form = new System.Threading.Thread(open1);
               form.next_form.SetApartmentState(System.Threading.ApartmentState.STA);
               form.next_form.Start();
              
            }
            else {
                i = rnd(3);

                if (cc[i - 1] <= 3 && cc[0] + cc[1] + cc[2] != 12)
                {
                    countcolor(i);
                    number = rnd(100);
                    form.label1.Text = Convert.ToString(number);
                    if (i == 1)
                    {
                        form.Answer1.Text = Convert.ToString(number);
                        form.Answer2.Text = Convert.ToString(rnd(100));
                        form.Answer3.Text = Convert.ToString(rnd(100));
                    }
                    else if (i == 2)
                    {
                        form.Answer1.Text = Convert.ToString(rnd(100));
                        form.Answer2.Text = Convert.ToString(number);
                        form.Answer3.Text = Convert.ToString(rnd(100));
                    }
                    else if (i == 3)
                    {
                        form.Answer1.Text = Convert.ToString(rnd(100));
                        form.Answer2.Text = Convert.ToString(rnd(100));
                        form.Answer3.Text = Convert.ToString(number);
                    }
                    Color c1 = Color.White;
                    if (i == 1)
                    {
                        c1 = Color.Red;
                        form.label1.ForeColor = Color.Red;
                    }
                    else if (i == 2)
                    {
                        c1 = Color.Blue;
                        form.label1.ForeColor = Color.Blue;
                    }
                    else if (i == 3)
                    {
                        c1 = Color.Green;
                        form.label1.ForeColor = Color.Green;
                    }
                    form.label1.BackColor = Color.FromArgb(c1.A,
                (int)(c1.R * c[cc[i - 1]]), (int)(c1.G * c[cc[i - 1]]), (int)(c1.B * c[cc[i - 1]]));
                }
                else testing();
            }
        }
        public int rnd(int j)
        {
            int p = rand.Next(1, j + 1);
            return p;
        }
        public void countcolor(int i)
        {
            if (i == 1) cc[0]++;
            if (i == 2) cc[1]++;
            if (i == 3) cc[2]++;
        }
    }
    class FileEditor
    {
        string filename;
        public FileEditor(string filename)
        {
            this.filename = filename;
            if (!File.Exists(filename))
            {
                using (StreamWriter filewrite = new StreamWriter(filename,true, System.Text.Encoding.Default))
                {
                    filewrite.WriteLine("Ім'я користувача;Дата;№1;№2;№3;№4;№5;№6;№7;№8;№9;№10;№11;№12;Час проходження;Результат червоний;Результат синій;Результат зелений");
                }
            }
        }
        public void readfile()
        {
            using (StreamReader fileread = new StreamReader(filename, System.Text.Encoding.Default))
            {
                Form information = new Form();
                information.ClientSize = new Size(1350, 498);
                information.MinimumSize = new Size(information.Size.Width, information.Size.Height);
                information.MaximumSize = new Size(information.Size.Width, information.Size.Height);
                information.Text = "Таблиця данних";
                information.StartPosition = FormStartPosition.CenterScreen;
                ListView list = new ListView();
                list.Size = new Size(1355, 500);
                list.Location = new Point(-1, -1);
                list.Font = new Font("Consolas", 7.9f, FontStyle.Bold);
                list.View = View.Details;
                list.Columns.Add("Ім'я користувача", 110, HorizontalAlignment.Center);
                list.Columns.Add("Дата", 130, HorizontalAlignment.Center);
                list.Columns.Add("№1", 50, HorizontalAlignment.Center);
                list.Columns.Add("№2", 50, HorizontalAlignment.Center);
                list.Columns.Add("№3", 50, HorizontalAlignment.Center);
                list.Columns.Add("№4", 50, HorizontalAlignment.Center);
                list.Columns.Add("№5", 50, HorizontalAlignment.Center);
                list.Columns.Add("№6", 50, HorizontalAlignment.Center);
                list.Columns.Add("№7", 50, HorizontalAlignment.Center);
                list.Columns.Add("№8", 50, HorizontalAlignment.Center);
                list.Columns.Add("№9", 50, HorizontalAlignment.Center);
                list.Columns.Add("№10",50, HorizontalAlignment.Center);
                list.Columns.Add("№11",50, HorizontalAlignment.Center);
                list.Columns.Add("№12",50, HorizontalAlignment.Center);
                list.Columns.Add("Час проходження", 105, HorizontalAlignment.Center);
                list.Columns.Add("Результат червоний",135, HorizontalAlignment.Center);
                list.Columns.Add("Результат синій", 135, HorizontalAlignment.Center);
                list.Columns.Add("Результат зелений", 135, HorizontalAlignment.Center);
                int stolb = 0;
                string buffer = fileread.ReadToEnd();
                char[] buf = buffer.ToCharArray();
                for (int i = 131, startid = i, p = 0; i < buf.Length; i++)
                {
                    if (buf[i] == ';' || buf[i] == '\n')
                    {
                        p++;
                        if (p == 1)
                        {
                            list.Items.Add(buffer.Substring(startid, i - startid));
                            startid = i;
                        }
                        else if (p == 18)
                        {
                            list.Items[stolb++].SubItems.Add(buffer.Substring(startid + 1, i - startid - 1));
                            p = 0;
                            startid = i;
                        }
                        else
                        {
                            list.Items[stolb].SubItems.Add(buffer.Substring(startid + 1, i - startid - 1));
                            startid = i;
                        }
                    }
                }
                information.Controls.Add(list);
                //
                // Sorts
                //
                int[] filesort = new int[list.Items.Count];
                int[] updownsort = new int[list.Items.Count];
                int[] downupsort = new int[list.Items.Count];
                string[] sfilesort = new string[list.Items.Count];
                string[] supdownsort = new string[list.Items.Count];
                string[] sdownupsort = new string[list.Items.Count];
                // создание стрингов для сортировки
                for(int i = 0; i < list.Items.Count; i++)
                {
                    sfilesort[i] = list.Items[i].SubItems[14].Text;
                    supdownsort[i] = list.Items[i].SubItems[14].Text;
                    sdownupsort[i] = list.Items[i].SubItems[14].Text;
                }
                // создание инт для сортировки
                for (int i = 0; i < list.Items.Count; i++)
                {
                    string bufer = "";
                    int buferi = 0;
                    char[] a = list.Items[i].SubItems[14].Text.ToCharArray();
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (a[j] == ':')
                        {
                            buferi = j;
                            for (int c = 0; c < j; c++)
                            {
                                bufer += a[c];
                            }
                        }
                        else if (j == a.Length - 1)
                        {
                            for (int c = buferi + 1; c < a.Length; c++)
                            {
                                bufer += a[c];
                            }
                        }
                    }
                    filesort[i] = Convert.ToInt32(bufer);
                }
                //
                for (int i = 0; i < filesort.Length; i++) updownsort[i] = filesort[i];
                string newelementstr = "";
                for (int newElement,location,i = 1; i < filesort.Length; i++)
                {
                    newElement = updownsort[i];
                    newelementstr = supdownsort[i];
                    location = i - 1;
                    while (location >= 0 && updownsort[location] < newElement)
                    {
                        updownsort[location + 1] = updownsort[location];
                        supdownsort[location + 1] = supdownsort[location];
                        location = location - 1;
                    }
                    updownsort[location + 1] = newElement;
                    supdownsort[location + 1] = newelementstr;
                }
                for (int i = 0; i < filesort.Length; i++) downupsort[i] = filesort[i];
                //
                for (int newElement, location, i = 1; i < filesort.Length; i++)
                {
                    newElement = downupsort[i];
                    newelementstr = sdownupsort[i];
                    location = i - 1;
                    while (location >= 0 && downupsort[location] > newElement)
                    {
                        downupsort[location + 1] = downupsort[location];
                        sdownupsort[location + 1] = sdownupsort[location];
                        location = location - 1;
                    }
                    downupsort[location + 1] = newElement;
                    sdownupsort[location + 1] = newelementstr;
                }
                //
                information.Show();
                bool uporedownsort = true;
                list.ColumnClick += delegate (Object sender, ColumnClickEventArgs e)
                {
                    if (e.Column == 14)
                    {
                        if (uporedownsort == false)
                        {
                            for(int i = 0; i < list.Items.Count; i++)
                            {
                                for(int j = i; j < list.Items.Count; j++)
                                {
                                    if (supdownsort[i] == list.Items[j].SubItems[14].Text)
                                    {
                                        if (i == j) break;
                                        else
                                        {
                                            for(int c = 0; c < 18; c++)
                                            {
                                                string buf1= list.Items[i].SubItems[c].Text;
                                                string buf2 = list.Items[j].SubItems[c].Text;
                                                list.Items[i].SubItems[c].Text = buf2;
                                                list.Items[j].SubItems[c].Text = buf1;
                                            }
                                        }
                                    }
                                }
                            }
                            uporedownsort = true;
                        }
                        else
                        {
                            for (int i = 0; i < list.Items.Count; i++)
                            {
                                for (int j = i; j < list.Items.Count; j++)
                                {
                                    if (sdownupsort[i] == list.Items[j].SubItems[14].Text)
                                    {
                                        if (i == j) break;
                                        else
                                        {
                                            for (int c = 0; c < 18; c++)
                                            {
                                                string buf1 = list.Items[i].SubItems[c].Text;
                                                string buf2 = list.Items[j].SubItems[c].Text;
                                                list.Items[i].SubItems[c].Text = buf2;
                                                list.Items[j].SubItems[c].Text = buf1;
                                            }
                                        }
                                    }
                                }
                            }
                            uporedownsort = false;
                        }
                    }
                };
            }
        }
        public void writedata()
        {
            using (StreamWriter filewrite = new StreamWriter(filename, true, System.Text.Encoding.Default))
            {
                filewrite.Write(DateTime.Now.ToString() + ";");
            }
        }
        public void writefile(string info,int min,int sec)
        {
            using (StreamWriter filewrite = new StreamWriter(filename, true, System.Text.Encoding.Default))
            {
                filewrite.Write(info +" "+ min+":"+sec+";");
            }
        }
        public void writefile(string info)
        {
            using (StreamWriter filewrite = new StreamWriter(filename, true, System.Text.Encoding.Default))
            {
                filewrite.Write(info + ";");
            }
        }
        public void writeresult(int min,int sec,string infored, string infoblue, string infogreen)
        {
            using (StreamWriter filewrite = new StreamWriter(filename, true, System.Text.Encoding.Default))
            {
                filewrite.Write(min+":"+sec+";"+infored + ";" + infoblue + ";" + infogreen + "\n");
            }
        }
        public void error()
        {
            string[] sbuf= System.IO.File.ReadAllLines(filename, Encoding.Default);
            string text = "";
            for (int i = 0; i < sbuf.Length - 1; i++)
            {
                text += sbuf[i]+"\n";
            }
            StreamWriter filewrite = new StreamWriter(filename, false, System.Text.Encoding.Default);
            filewrite.Write(text);
            filewrite.Close();
        }
    }
}
