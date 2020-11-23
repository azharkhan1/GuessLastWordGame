using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int score = 0;
        Image img;
        string text;
        int Tno = 0;
        private int _tickets;
        
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            _tickets = 10;
            images();
            panel1.Hide();

           
        }
       
      
        public void images()
        {
            textBox1.Text = "";
            Tno = 5;
            text = "QUAID";
            textBox1.Text = "QUAI";
            textBox1.Enabled = false;
            img = Image.FromFile("places/1.jpg");
            this.pictureBox1.Image = img;

            img = Image.FromFile("places/3.jpg");
            this.pictureBox2.Image = img;
           
            img = Image.FromFile("places/4.jpg");
            this.pictureBox3.Image = img;
           
            img = Image.FromFile("places/2.jpg");
            this.pictureBox4.Image = img;
            
            button1.Text = "D";
            button2.Text = "E";
            button3.Text = "X";
            button4.Text = "T";
            button5.Text = "O";
            button6.Text = "N";
            enable();
        }
        public void images1()
        {
          
            Tno = 6;
            textBox1.Text = "";
            text = "ALTO";
            textBox1.Text = "ALT";

            img = Image.FromFile("cars/1.jpg");
            this.pictureBox1.Image = img;

            img = Image.FromFile("cars/2.jpg");
            this.pictureBox2.Image = img;

            img = Image.FromFile("cars/3.jpg");
            this.pictureBox3.Image = img;

            img = Image.FromFile("cars/4.jpg");
            this.pictureBox4.Image = img;

            button1.Text = "L";
            button2.Text = "R";
            button3.Text = "N";
            button4.Text = "O";
            button5.Text = "E";
            button6.Text = "N";

            enable();

        }
        public void images2()
        {
            Tno = 6;
            textBox1.Text = "";
            text = "TIGER";
            textBox1.Text = "TIGE";

            img = Image.FromFile("animal/1.jpg");
            this.pictureBox1.Image = img;

            img = Image.FromFile("animal/2.jpg");
            this.pictureBox2.Image = img;

            img = Image.FromFile("animal/3.jpg");
            this.pictureBox3.Image = img;

            img = Image.FromFile("animal/4.jpg");
            this.pictureBox4.Image = img;

            button1.Text = "D";
            button2.Text = "O";
            button3.Text = "T";
            button4.Text = "V";
            button5.Text = "E";
            button6.Text = "R";
            enable();


        }
        public void images3()
        {
            Tno = 6;
            textBox1.Text = "";
            text = "RAZER";
            textBox1.Text = "RAZE";

            img = Image.FromFile("mouse/1.jpg");
            this.pictureBox1.Image = img;

            img = Image.FromFile("mouse/2.jpg");
            this.pictureBox2.Image = img;

            img = Image.FromFile("mouse/3.jpg");
            this.pictureBox3.Image = img;

            img = Image.FromFile("mouse/4.png");
            this.pictureBox4.Image = img;

            button1.Text = "H";
            button2.Text = "R";
            button3.Text = "S";
            button4.Text = "V";
            button5.Text = "F";
            button6.Text = "G";
            enable();


        }
        public void images4()
        {
            Tno = 6;
            textBox1.Text = "";
            text = "APPLE";
            textBox1.Text = "APPL";

            img = Image.FromFile("mobile/1.png");
            this.pictureBox1.Image = img;

            img = Image.FromFile("mobile/2.jpg");
            this.pictureBox2.Image = img;

            img = Image.FromFile("mobile/3.png");
            this.pictureBox3.Image = img;

            img = Image.FromFile("mobile/4.jpg");
            this.pictureBox4.Image = img;

            button1.Text = "E";
            button2.Text = "G";
            button3.Text = "A";
            button4.Text = "N";
            button5.Text = "I";
            button6.Text = "D";
            enable();


        }

        int va = 0;
      
        public void check()
        {
            va++;
            timer1.Stop();
            if (textBox1.Text == text)
            {

                MessageBox.Show("Correct Answer");
                score++;     

            }
           else if (textBox1.Text.Length == Tno || textBox1.Text != text)
            {
                MessageBox.Show("wrong");
            }
            if (va == 1)
            {
                images1();
            }
            else if (va == 2)
            {
                images2();
            }
            else if (va == 3)
            {
                images3();
            }
            else if (va == 4)
            {
                images4();

            }
            else
            {

                panel1.Show();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                label2.Text = "your score is = " + score;
                label1.Hide();
                textBox1.Hide();
                button1.Hide();
                button2.Hide();
                button3.Hide();
                button4.Hide();
                button5.Hide();
                button6.Hide();
            }
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + button1.Text;
            button1.Enabled = false;
            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+ button2.Text;
            button2.Enabled = false;
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
            button3.Enabled = false;
            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
            button4.Enabled = false;
            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
            button5.Enabled = false;
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
            button6.Enabled = false;
            check();
        }
        public void enable()
        {
            _tickets = 60;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            _tickets--;
            this.Text = _tickets.ToString();
            label1.Text = this.Text;
            if (_tickets == 0)
            {

                timer1.Stop();
                MessageBox.Show("You Time is UP");
                Application.Exit();
            }

        }
      
    }
}
