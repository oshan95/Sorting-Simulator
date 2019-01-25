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
using System.Timers;

namespace Sorting_Simulator
{
    public partial class Form1 : Form
    {
        string st,st1;
        int num1, num2;
        

        Point tmp = new Point(0,0);
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           // label13.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            //Assigning values of the text boxes into variables
            string a, b, c, d, f, g, h, i, j, k;
            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox3.Text;
            d = textBox4.Text;
            f = textBox5.Text;
            g = textBox6.Text;
            h = textBox7.Text;
            i = textBox8.Text;
            j = textBox9.Text;
            k = textBox10.Text;

            //Validation of textboxes
            if ((a.IndexOf('.') != a.LastIndexOf('.')) || (b.IndexOf('.') != b.LastIndexOf('.')) || (c.IndexOf('.') != c.LastIndexOf('.')) || (d.IndexOf('.') != d.LastIndexOf('.')) || (f.IndexOf('.') != f.LastIndexOf('.')) || (g.IndexOf('.') != g.LastIndexOf('.')) || (h.IndexOf('.') != h.LastIndexOf('.')) || (i.IndexOf('.') != i.LastIndexOf('.')) || (j.IndexOf('.') != j.LastIndexOf('.')) || (k.IndexOf('.') != k.LastIndexOf('.')) || a.Equals("") || b.Equals("") || c.Equals("") || d.Equals("") || f.Equals("") || g.Equals("") || h.Equals("") || i.Equals("") || j.Equals("") || k.Equals("") || (a.IndexOf('-') != a.LastIndexOf('-')) || (b.IndexOf('-') != b.LastIndexOf('-')) || (c.IndexOf('-') != c.LastIndexOf('-')) || (d.IndexOf('-') != d.LastIndexOf('-')) || (f.IndexOf('-') != f.LastIndexOf('-')) || (g.IndexOf('-') != g.LastIndexOf('-')) || (h.IndexOf('-') != h.LastIndexOf('-')) || (i.IndexOf('-') != i.LastIndexOf('-')) || (j.IndexOf('-') != j.LastIndexOf('-')) || (k.IndexOf('-') != k.LastIndexOf('-')))
            {
                MessageBox.Show("Inserted values are not supported");
            }
            else
            {

                //Disabling simulate button while sorting numbers
                button1.Enabled = false;

                //enabling visibility of a label for the sorted array once the simulate button is clicked
                label13.Visible = true;

                //Enabling visibility of the  ritchTextBox    
                richTextBox1.Visible = true;

                //Taking the values in the textboxes into a integer arrray by converting each textbox value to integer
                int [] list  = {Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text) };
                int x, tmp;

                    for (int v = 1; v < list.Length; v++)
                    {
                        x = v - 1;
                        num1 = x; //To display the line that have changed when sorting
                        tmp = list[v];

                            while (x >= 0 && list[x] > tmp)
                            {
                            num2 = list[x]; //To display the line that have changed when sorting
                            list[x + 1] = list[x];
                            x = x - 1;
                            }
                        list[x + 1] = tmp;

                    this.richTextBox1.AppendText("    \n");

                    for (int y = 0; y < list.Length; y++) //Displaying values in the ritchBox
                    {
                        this.richTextBox1.AppendText(Convert.ToString(list[y]) + "    ");
                    }
                    if (num1 == num2 || num2 < num1)
                    {
                        st = "No change";
                    }
                    else {
                        st = "Changed";
                    }
                    this.richTextBox1.AppendText("    "+st); 
                    this.richTextBox1.AppendText(" \n");



                }


                    //Changing the color of labels to show sorted array
                    label2.BackColor = Color.FromArgb(148, 0, 211);
                    label3.BackColor = Color.FromArgb(148, 0, 211);
                    label4.BackColor = Color.FromArgb(148, 0, 211);
                    label5.BackColor = Color.FromArgb(148, 0, 211);
                    label6.BackColor = Color.FromArgb(148, 0, 211);
                    label7.BackColor = Color.FromArgb(148, 0, 211);
                    label8.BackColor = Color.FromArgb(148, 0, 211);
                    label9.BackColor = Color.FromArgb(148, 0, 211);
                    label10.BackColor = Color.FromArgb(148, 0, 211);
                    label11.BackColor = Color.FromArgb(148, 0, 211);

                    //Applying values in the sorted array into labels
                    label2.Text = Convert.ToString(list[0]);
                    label3.Text = Convert.ToString(list[1]);
                    label4.Text = Convert.ToString(list[2]);
                    label5.Text = Convert.ToString(list[3]);
                    label6.Text = Convert.ToString(list[4]);
                    label7.Text = Convert.ToString(list[5]);
                    label8.Text = Convert.ToString(list[6]);
                    label9.Text = Convert.ToString(list[7]);
                    label10.Text = Convert.ToString(list[8]);
                    label11.Text = Convert.ToString(list[9]);


                }



            }

        

        private void button2_Click(object sender, EventArgs e)
        {
            //taking values in the textboxes to seperate variables
            string a, b, c, d, f, g, h, i, j, k;
            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox3.Text;
            d = textBox4.Text;
            f = textBox5.Text;
            g = textBox6.Text;
            h = textBox7.Text;
            i = textBox8.Text;
            j = textBox9.Text;
            k = textBox10.Text;

            //Check wheather if there are empty fileds before resetting fields
            if (a.Equals("") || b.Equals("") || c.Equals("") || d.Equals("") || f.Equals("") || g.Equals("") || h.Equals("") || i.Equals("") || j.Equals("") || k.Equals(""))
            {
                MessageBox.Show("Fields are empty !");
            }
            else
            {
                // reset button changes for labels
                label2.Text = null;
                label3.Text = null;
                label4.Text = null;
                label5.Text = null;
                label6.Text = null;
                label7.Text = null;
                label8.Text = null;
                label9.Text = null;
                label10.Text = null;
                label11.Text = null;

                //reset button changes for textboxes
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                textBox6.Text = null;
                textBox7.Text = null;
                textBox8.Text = null;
                textBox9.Text = null;
                textBox10.Text = null;
                button1.Enabled = true;

                //Setting unneccessary objects hind when the reset button is clicked
                label13.Visible = false;
                this.richTextBox1.Text = "";

            }
        }


  //Adding validations for key press events of the text boxes 
    
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' ||e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back ;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tmp = label2.Location;
            label2.Location = label3.Location;
            label3.Location = tmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            label14.Visible = false;
            label13.Visible = false;
            richTextBox2.Visible = false;
            richTextBox1.Visible = false;


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            label14.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {


            //Assining valus of the text boxes into variables
            string a, b, c, d, f, g, h, i, j, k;
            a = textBox20.Text;
            b = textBox19.Text;
            c = textBox18.Text;
            d = textBox17.Text;
            f = textBox16.Text;
            g = textBox15.Text;
            h = textBox14.Text;
            i = textBox13.Text;
            j = textBox12.Text;
            k = textBox11.Text;

            //Validation of textboxes
            if ((a.IndexOf('.') != a.LastIndexOf('.')) || (b.IndexOf('.') != b.LastIndexOf('.')) || (c.IndexOf('.') != c.LastIndexOf('.')) || (d.IndexOf('.') != d.LastIndexOf('.')) || (f.IndexOf('.') != f.LastIndexOf('.')) || (g.IndexOf('.') != g.LastIndexOf('.')) || (h.IndexOf('.') != h.LastIndexOf('.')) || (i.IndexOf('.') != i.LastIndexOf('.')) || (j.IndexOf('.') != j.LastIndexOf('.')) || (k.IndexOf('.') != k.LastIndexOf('.')) || a.Equals("") || b.Equals("") || c.Equals("") || d.Equals("") || f.Equals("") || g.Equals("") || h.Equals("") || i.Equals("") || j.Equals("") || k.Equals("") || (a.IndexOf('-') != a.LastIndexOf('-')) || (b.IndexOf('-') != b.LastIndexOf('-')) || (c.IndexOf('-') != c.LastIndexOf('-')) || (d.IndexOf('-') != d.LastIndexOf('-')) || (f.IndexOf('-') != f.LastIndexOf('-')) || (g.IndexOf('-') != g.LastIndexOf('-')) || (h.IndexOf('-') != h.LastIndexOf('-')) || (i.IndexOf('-') != i.LastIndexOf('-')) || (j.IndexOf('-') != j.LastIndexOf('-')) || (k.IndexOf('-') != k.LastIndexOf('-')))
            {
                MessageBox.Show("Inserted values are not supported");
            }
            else
            {

                
                
                button4.Enabled = false; //Disabling button if the enterd data are correct
                label14.Visible = true;
                richTextBox2.Visible = true;

                //Inserting values in the textboxes into a array
                int [] list1  = { Convert.ToInt32(textBox20.Text), Convert.ToInt32(textBox19.Text), Convert.ToInt32(textBox18.Text), Convert.ToInt32(textBox17.Text), Convert.ToInt32(textBox16.Text), Convert.ToInt32(textBox15.Text), Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox13.Text), Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox11.Text) };
                int x, tmp,numId;
                int num1 = 0;

                //Selection sort algorithm

                for (int v = 0; v < list1.Length; v++)
                {
                    x = v;
                    tmp = list1[v];

                    for (int index = v + 1; index < list1.Length; index++)
                    {
                        if (list1[index] < list1[x])
                        {
                            x = index;

                        }

                        num1 = list1[x];
                        numId = x;
                    }
                    //exchanging selected candidate values

                    int tmp1 = list1[v];
                    list1[v] = list1[x];
                    list1[x] = tmp1;

                    this.richTextBox2.AppendText(" ");

                    //inserting data into the ritchBox
                    for (int y = 0; y < list1.Length; y++)
                    {
                         this.richTextBox2.AppendText(Convert.ToString(list1[y]) + "    ");
                    }

                    if (num1 == tmp || tmp < num1)
                    {
                        st1 = "No change";
                    }
                    else
                    {
                        st1 = "Changed";
                    }
                    
                    //Dispalyin old minimum value and the new minimum values in each line
                    this.richTextBox2.AppendText("Old min = "+Convert.ToString(tmp)+"    "+"New min = "+Convert.ToString(num1)+"    "+st1);
                    this.richTextBox1.AppendText(" \n");
                    this.richTextBox2.AppendText(" \n");

                }


                //Changing the color of labels to show sorted array
                label25.BackColor = Color.FromArgb(148, 0, 211);
                label24.BackColor = Color.FromArgb(148, 0, 211);
                label23.BackColor = Color.FromArgb(148, 0, 211);
                label22.BackColor = Color.FromArgb(148, 0, 211);
                label21.BackColor = Color.FromArgb(148, 0, 211);
                label20.BackColor = Color.FromArgb(148, 0, 211);
                label19.BackColor = Color.FromArgb(148, 0, 211);
                label18.BackColor = Color.FromArgb(148, 0, 211);
                label17.BackColor = Color.FromArgb(148, 0, 211);
                label16.BackColor = Color.FromArgb(148, 0, 211);

                //inserting values in thee sorted array to labels
                label25.Text = Convert.ToString(list1[0]);
                label24.Text = Convert.ToString(list1[1]);
                label23.Text = Convert.ToString(list1[2]);
                label22.Text = Convert.ToString(list1[3]);
                label21.Text = Convert.ToString(list1[4]);
                label20.Text = Convert.ToString(list1[5]);
                label19.Text = Convert.ToString(list1[6]);
                label18.Text = Convert.ToString(list1[7]);
                label17.Text = Convert.ToString(list1[8]);
                label16.Text = Convert.ToString(list1[9]);


            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //for validation purposes
            string a, b, c, d, f, g, h, i, j, k;
            a = textBox20.Text;
            b = textBox19.Text;
            c = textBox18.Text;
            d = textBox17.Text;
            f = textBox16.Text;
            g = textBox15.Text;
            h = textBox14.Text;
            i = textBox13.Text;
            j = textBox12.Text;
            k = textBox11.Text;

            //Check wheather if there are empty fileds before resetting fields
            if (a.Equals("") || b.Equals("") || c.Equals("") || d.Equals("") || f.Equals("") || g.Equals("") || h.Equals("") || i.Equals("") || j.Equals("") || k.Equals(""))
            {
                MessageBox.Show("Fields are empty !");
            }
            else
            {
                // For labels
                label25.Text = null;
                label24.Text = null;
                label23.Text = null;
                label22.Text = null;
                label21.Text = null;
                label20.Text = null;
                label19.Text = null;
                label18.Text = null;
                label17.Text = null;
                label16.Text = null;
                //For textboxes
                textBox20.Text = null;
                textBox19.Text = null;
                textBox18.Text = null;
                textBox17.Text = null;
                textBox16.Text = null;
                textBox15.Text = null;
                textBox14.Text = null;
                textBox13.Text = null;
                textBox12.Text = null;
                textBox11.Text = null;
                button4.Enabled = true;

                label14.Visible = false;
                this.richTextBox2.Text = "";
                richTextBox2.Visible = false;

            }
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }

        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
