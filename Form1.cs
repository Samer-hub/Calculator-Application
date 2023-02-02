using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        int first_nr, second_nr;
        int result = 0;
        char operation;
        bool is_operation_pressd = true;
        public Calculator()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            DisplayBox.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
                DisplayBox.Text += '2';  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayBox.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayBox.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisplayBox.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DisplayBox.Text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DisplayBox.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DisplayBox.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DisplayBox.Text += '9';
        }

        private void button0_Click(object sender, EventArgs e)
        {
            DisplayBox.Text += '0';
        }

        private void multi_button_Click(object sender, EventArgs e)
        {
            //first_nr = int.Parse(DisplayBox.Text);
            operation = '*';
            DisplayBox.Text += '*';
        }

        private void sub_button_Click(object sender, EventArgs e)
        {
            //first_nr = int.Parse(DisplayBox.Text);
            operation = '-';
            DisplayBox.Text += '-';
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            operation = '+';
            DisplayBox.Text += '+';
        }
        private void div_button_Click(object sender, EventArgs e)
        {
            //first_nr = int.Parse(DisplayBox.Text);
            operation = '/';
            DisplayBox.Text += '/';
        }

        private void c_button_Click(object sender, EventArgs e)
        {
            first_nr = 0;
            second_nr = 0;
            operation = ' ';
            DisplayBox.Text = "";

        }

        private int Expresion(int n1, int n2, char _operation)
        {
            return 0;
            
        }

        private void lika_button_Click(object sender, EventArgs e)
        {
            //String[] seperator = DisplayBox.Text.Split(operation);
            //int[] numbers = new int[seperator.Length];
            /*string[] seperator = DisplayBox.Text.Split(operation);
            foreach (string item in seperator)
            {
                first_nr = int.Parse(seperator[0]);
                second_nr = int.Parse(seperator[1]);
            }*/
            string _input = DisplayBox.Text;
            int[] numbers = new int[100];
            char[] op = new char[99];
            string str = "";
            int x = 0;
            int y = 0; 
            foreach (char ch in _input)
            {
                if (ch >= 48 && ch <= 57)
                {
                    str += ch;
                }
                else
                {
                    numbers[x++]= int.Parse(str);
                    str = "";
                    op[y++]= ch;
                }
            }
            numbers[x++] = int.Parse(str);
            result = numbers[0];
            for (int i = 0; i < op.Length; i++)
            {
                //result = Expresion(result, numbers[i+1], op[i]);
                if (op[i] == '+') result = result + numbers[i+1];
                if (op[i] == '-') result = result - numbers[i + 1];
                if (op[i] == '/')
                { if (numbers[i + 1] != 0)
                        result = result / numbers[i + 1];
                    else {
                        DisplayBox.Text = "";
                        DisplayBox.Text = " DIVIDE BY 0 \n Error!";break;
                    }   
                } 
                if (op[i] == '*') result = result * numbers[i + 1];
            }

            //second_nr = int.Parse(DisplayBox.Text);
            DisplayBox.Text += '=';
            /*switch (operation)
            {
                case '+': result = first_nr + second_nr; break;
                case '-': result = first_nr - second_nr; break;
                case '*': result = first_nr * second_nr; break;
                case '/': 
                    if (second_nr == 0)
                    {
                        DisplayBox.Text = "";
                        DisplayBox.Text = " DIVIDE BY 0 \n Error!";
                    }
                    else 
                    {
                        result = first_nr / second_nr;
                    } break;
            }*/
            DisplayBox.Text = result.ToString();
        }


    }
}
