using System.Runtime.ExceptionServices;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        double firstNum;
        double secondNum;
        double ans;
        char oper;
        const double pi = 3.141592653;

        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zero_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "0";
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0" && Output.Text != null)
            {
                Output.Text = "1";
            }
            else
            {
                Output.Text = Output.Text + "1";
            }
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0" && Output.Text != null)
            {
                Output.Text = "2";
            }
            else
            {
                Output.Text = Output.Text + "2";
            }
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0" && Output.Text != null)
            {
                Output.Text = "3";
            }
            else
            {
                Output.Text = Output.Text + "3";
            }
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0" && Output.Text != null)
            {
                Output.Text = "4";
            }
            else
            {
                Output.Text = Output.Text + "4";
            }
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0" && Output.Text != null)
            {
                Output.Text = "5";
            }
            else
            {
                Output.Text = Output.Text + "5";
            }
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0" && Output.Text != null)
            {
                Output.Text = "6";
            }
            else
            {
                Output.Text = Output.Text + "6";
            }
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0" && Output.Text != null)
            {
                Output.Text = "7";
            }
            else
            {
                Output.Text = Output.Text + "7";
            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0" && Output.Text != null)
            {
                Output.Text = "8";
            }
            else
            {
                Output.Text = Output.Text + "8";
            }
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0" && Output.Text != null)
            {
                Output.Text = "9";
            }
            else
            {
                Output.Text = Output.Text + "9";
            }
        }

      
        private void Point_Click(object sender, EventArgs e)
        {
            Output.Text += ".";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(Output.Text);
            Output.Clear();
            oper = '*';
        }

        private void Add_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(Output.Text);
            Output.Clear();
            oper = '+';
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(Output.Text);
            Output.Clear();
            oper = '-';
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(Output.Text);
            Output.Clear();
            oper = '/';
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Output.Clear();
            Output.Text = "0";
        }





        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Equals_Click(object sender, EventArgs e)
        {
            secondNum = Convert.ToDouble(Output.Text);
            Output.Clear();

            //if (secondNum == 0 && oper == '/')
            //{
            //    Output.Text = "MathErr";
            //}
            switch (oper)
            {
                default:

                    break;

                case '*':
                    Output.Text = (firstNum * secondNum).ToString();
                    break;

                case '/':

                    Output.Text = (firstNum / secondNum).ToString();
                    break;

                case '+':
                    Output.Text = (firstNum + secondNum).ToString();
                    break;

                case '-':
                    Output.Text = (firstNum - secondNum).ToString();
                    break;

                case '^':
                    Output.Text = (Math.Pow(firstNum,secondNum)).ToString();
                break;


            }
        }

        private void NaturalLog_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(Output.Text);
            Output.Clear();
            Output.Text = Math.Log(firstNum).ToString();
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(Output.Text);
            Output.Clear();
            Output.Text = Math.Sqrt(firstNum).ToString();
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            Output.Text = pi.ToString();
        }


        private void Power_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(Output.Text);
            Output.Clear();
            oper = '^';
        }
    }
}
