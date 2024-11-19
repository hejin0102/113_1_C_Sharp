using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program4_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calory; //熱量(卡路里)
            double gram;   //克數(脂肪重量)

            if (double.TryParse(textBox1.Text, out calory) || calory <= 0)
            {
                MessageBox.Show("請輸入有效的總卡路里數字！", "輸入錯誤");
                return;
            }

            if (double.TryParse(textBox2.Text, out gram) || gram < 0)
            {
                MessageBox.Show("請輸入有效的脂肪克數！", "輸入錯誤");
                return;
            }

            double fatCalories = gram * 9;

            if (fatCalories > calory)
            {
                MessageBox.Show("脂肪卡路里不能超過總卡路里！", "輸入錯誤");
                return;
            }

            double fatPercentage = (fatCalories / calory) * 100;

            string result = "脂肪卡路里數：" + fatCalories.ToString("F2") + "\n" +
                            "脂肪卡路里百分比：" + fatPercentage.ToString("F2") + "%";

            if (radioButton1.Checked)
            {
                if (fatPercentage < 30)
                {
                    result += "\n此食物被認為是低脂食物。";
                }
                else
                {
                    result += "\n此食物不被認為是低脂食物。";
                }
            }

            label3.Text = result;
        }
    }
}