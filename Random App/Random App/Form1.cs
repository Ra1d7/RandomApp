using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using SKYPE4COMLib;

namespace Random_App
{
    
    public partial class Form1 : Form
    {
        Skype skype = new Skype();
        int index = -1;
        bool Underline;
        int inc = 0;
        Random _random = new Random();
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.Red;
            panel2.BackColor = Color.Green;
            panel3.BackColor = Color.Blue;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            label1.Text =  DateTime.Now.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            tabControl1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            
            tabPage2.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            tabPage3.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            tabPage4.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            
            
            
            
            
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            tabControl1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            
            tabPage2.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            tabPage3.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            tabPage4.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            
            
            
            
            
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            tabControl1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            
            tabPage2.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            tabPage3.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            tabPage4.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            
            
            
            
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label6.Text = Environment.MachineName;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Font = new Font(comboBox1.Text, 8);
            groupBox1.Font = new Font(comboBox1.Text, 8);
            groupBox2.Font = new Font(comboBox1.Text, 8);
            groupBox3.Font = new Font(comboBox1.Text, 8);
            groupBox4.Font = new Font(comboBox1.Text, 8);
            groupBox5.Font = new Font(comboBox1.Text, 8);
            groupBox6.Font = new Font(comboBox1.Text, 8);
            label3.Font = new Font(comboBox1.Text, 8);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                this.Font = new Font(comboBox1.Text, 8, FontStyle.Underline);
                groupBox1.Font = new Font(comboBox1.Text, 8, FontStyle.Underline);
                groupBox2.Font = new Font(comboBox1.Text, 8, FontStyle.Underline);
                groupBox3.Font = new Font(comboBox1.Text, 8, FontStyle.Underline);
                groupBox4.Font = new Font(comboBox1.Text, 8, FontStyle.Underline);
                groupBox5.Font = new Font(comboBox1.Text, 8, FontStyle.Underline);
                groupBox6.Font = new Font(comboBox1.Text, 8, FontStyle.Underline);
                label3.Font = new Font(comboBox1.Text, 8, FontStyle.Underline);
            }
            if (checkBox3.Checked == false)
            {
                this.Font = new Font(comboBox1.Text, 8, FontStyle.Regular);
                groupBox1.Font = new Font(comboBox1.Text, 8, FontStyle.Regular);
                groupBox2.Font = new Font(comboBox1.Text, 8, FontStyle.Regular);
                groupBox3.Font = new Font(comboBox1.Text, 8, FontStyle.Regular);
                groupBox4.Font = new Font(comboBox1.Text, 8, FontStyle.Regular);
                groupBox5.Font = new Font(comboBox1.Text, 8, FontStyle.Regular);
                groupBox6.Font = new Font(comboBox1.Text, 8, FontStyle.Regular);
                label3.Font = new Font(comboBox1.Text, 8, FontStyle.Regular);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           // Bold = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Strikeout = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("you should type something :)","Error404 LOL");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            }
            catch
            {
                MessageBox.Show("There are no items to remove");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = listBox1.Items.Count;
           int Rnum = _random.Next(0,num);
           foreach (string item in listBox1.Items)
           {
               //MessageBox.Show("RNum" +Rnum.ToString());
               //MessageBox.Show("inc" + inc.ToString());
               if (Rnum == inc)
               {
                   MessageBox.Show(item);
                   inc = 0;
                   Rnum = 0;
                   break;
               }
               ++inc;
           }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != null)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        listBox1.Items.Add(textBox1.Text);
                        textBox1.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("you should type something :)", "Error404 LOL");
                }
                
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                if (radioButton2.Checked == true)
                {
                    int nums = _random.Next(0, 4);
                    switch (nums)
                    {
                        case 0:
                            MessageBox.Show("No, Not in your dreams.");
                            break;
                        case 1:
                            MessageBox.Show("No.");
                            break;
                        case 2:
                            MessageBox.Show("Yes! Yes! Yes!");
                            break;
                        case 3:
                            MessageBox.Show("Yes.");
                            break;
                    }
                }
                if (radioButton1.Checked == true)
                {
                    int numss = _random.Next(0, 4);
                    switch (numss)
                    {
                        case 0:
                            MessageBox.Show("Fuck no.");
                            break;
                        case 1:
                            MessageBox.Show("Oh Hell Naww");
                            break;
                        case 2:
                            MessageBox.Show("Fuck Yeah!!");
                            break;
                        case 3:
                            MessageBox.Show("Yeah bitch!");
                            break;
                    }
                }
            }
            textBox2.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_BackgroundImageChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_BindingContextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = _random.Next(0, listBox1.Items.Count - 1);
            Thread.Sleep(100);
            listBox1.SelectedIndex = _random.Next(0, listBox1.Items.Count - 1);
            Thread.Sleep(100);
            listBox1.SelectedIndex = _random.Next(0, listBox1.Items.Count - 1);
            Thread.Sleep(100);
            listBox1.SelectedIndex = _random.Next(0, listBox1.Items.Count - 1);
            Thread.Sleep(100);
            listBox1.SelectedIndex = _random.Next(0, listBox1.Items.Count - 1);
            Thread.Sleep(100);
            listBox1.SelectedIndex = _random.Next(0, listBox1.Items.Count - 1);
            Thread.Sleep(100);
            listBox1.SelectedIndex = _random.Next(0, listBox1.Items.Count - 1);
            Thread.Sleep(100);
            listBox1.SelectedIndex = _random.Next(0, listBox1.Items.Count - 1);
            Thread.Sleep(100);
            listBox1.SelectedIndex = _random.Next(0, listBox1.Items.Count - 1);
            Thread.Sleep(100);
            listBox1.SelectedIndex = _random.Next(0, listBox1.Items.Count - 1);
            Thread.Sleep(100);

            int num = listBox1.Items.Count;
            int Rnum = _random.Next(0, num);
            foreach (string item in listBox1.Items)
            {
                ++index;
                //MessageBox.Show("RNum" +Rnum.ToString());
                //MessageBox.Show("inc" + inc.ToString());
                if (Rnum == inc)
                {
                    listBox1.SelectedIndex = index;
                    MessageBox.Show(item);
                    inc = 0;
                    Rnum = 0;
                    index = -1;
                    break;
                }
                ++inc;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                if (radioButton2.Checked == true)
                {
                    int nums = _random.Next(0, 4);
                    switch (nums)
                    {
                        case 0:
                            MessageBox.Show("No, Not in your dreams.");
                            break;
                        case 1:
                            MessageBox.Show("No.");
                            break;
                        case 2:
                            MessageBox.Show("Yes! Yes! Yes!");
                            break;
                        case 3:
                            MessageBox.Show("Yes.");
                            break;
                    }
                }
                if (radioButton1.Checked == true)
                {
                    int numss = _random.Next(0, 4);
                    switch (numss)
                    {
                        case 0:
                            MessageBox.Show("Fuck no.");
                            break;
                        case 1:
                            MessageBox.Show("Oh Hell Naww");
                            break;
                        case 2:
                            MessageBox.Show("Fuck Yeah!!");
                            break;
                        case 3:
                            MessageBox.Show("Yeah bitch!");
                            break;
                    }
                }
            }
            textBox2.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox2.Text.Length != 0)
                {
                    if (radioButton2.Checked == true)
                    {
                        int nums = _random.Next(0, 4);
                        switch (nums)
                        {
                            case 0:
                                MessageBox.Show("No, Not in your dreams.");
                                break;
                            case 1:
                                MessageBox.Show("No.");
                                break;
                            case 2:
                                MessageBox.Show("Yes! Yes! Yes!");
                                break;
                            case 3:
                                MessageBox.Show("Yes.");
                                break;
                        }
                    }
                    if (radioButton1.Checked == true)
                    {
                        int numss = _random.Next(0, 4);
                        switch (numss)
                        {
                            case 0:
                                MessageBox.Show("Fuck no.");
                                break;
                            case 1:
                                MessageBox.Show("Oh Hell Naww");
                                break;
                            case 2:
                                MessageBox.Show("Fuck Yeah!!");
                                break;
                            case 3:
                                MessageBox.Show("Yeah bitch!");
                                break;
                        }
                    }
                }
                textBox2.Clear();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          DialogResult result =  MessageBox.Show("r u sure m8? :(", "Exit Dialog", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
          if (result == DialogResult.Yes)
          {
              //do nothing lol
          }
          if (result == DialogResult.No)
          {
              e.Cancel = true;
          }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            try
            {
                foreach (User u in skype.Friends)
                {
                    if (u.OnlineStatus != TOnlineStatus.olsOffline)
                    {
                        skype.SendMessage(u.Handle, string.Format("Hello, you are online and your display name is \"{0}\"", u.FullName != null ? u.FullName : "null"));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to send.. make sure you have the tool attached to your skype");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Attaching...\nMake sure to allow it to access your skype from your skype main menu");
            try
            {
                Skype skype = new Skype();
                if (!skype.Client.IsRunning)
                {
                    // start minimized with no splash screen
                    skype.Client.Start(true, true);
                }

                // wait for the client to be connected and ready
                skype.Attach(6, true);
                MessageBox.Show("Skype has been attached!\nyou can use the tools available now");
            }
            catch
            {
                Console.Beep();
                MessageBox.Show("<[<[<Failed to attach>]>]> \n####Things you can do####\n --> make sure that skype is opened <-- \n -- >allow access to the program when the popup nofication comes on skype <--\n --> make sure you have a internet connection <--");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int num = int.Parse(comboBox2.Text);
            try
            {
                while (num > 0)
                {
                    Thread.Sleep(200);
                    --num;
                    foreach (Chat chat in skype.ActiveChats)
                        chat.SendMessage(textBox3.Text);
                }
            }
            catch
            {
                MessageBox.Show("Failed..Make sure you select the amount of messages to send");
            }
        }
    }
}
