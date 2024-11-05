using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double testl, test2, test3, average;
            string grade;


            if (double.TryParse(test1TextBox.Text, out testl))
            {
                if (double.TryParse(test2TextBox.Text, out test2))
                {
                    if (double.TryParse(test3TextBox.Text, out test3))
                    {
                        if ((testl >= 0 && testl <= 100) && (test2 >= 0 && test2 <= 100) && (test3 >= 0 && test3 <= 100))
                        {
                            average = (testl + test2 + test3) / 3.0;
                            averageLabel.Text = average.ToString("n1");

                           // if (average >= 90)
                            //{
                               // grade = "A";
                            //}
                            //else if (average >= 80)
                           // {
                               // grade = "B";
                           // }
                           // else if (average >= 70)
                            //{
                               // grade = "C";
                           // }
                            //else if (average >= 60)
                           // {
                             //   grade = "D";
                           // }
                          //  else
                           // {
                            //    grade = "E";
                            //}
                            switch ((int)average / 10)
                            {
                                case 10:
                                case 9:
                                    grade = "A";
                                    break;
                                case 8:
                                    grade = "B";
                                    break;
                                case 7:
                                    grade = "C";
                                    break;
                                case 6:
                                    grade = "D";
                                    break;
                                default:
                                    grade = "F";
                                    break;
                            }
                            MessageBox.Show("你的等級是：" + grade);
                        }
                        else
                        {
                            MessageBox.Show("請輸入0~100之間的數字");
                        }
                    }
                    else
                    {
                        MessageBox.Show("第三格式輸入錯誤");
                    }
                }
                else
                {
                    MessageBox.Show("第二格式輸入錯誤");
                }
            }
            else
            {
                MessageBox.Show("第一格式輸入錯誤");
            }
        }          

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the averageLabel control.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // Reset the focus to test1.
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            test1TextBox.Focus();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
