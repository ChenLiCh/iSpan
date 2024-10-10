using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Calculator {
    public partial class Form1 : Form {
        double result = 0;
        //string operationPerformed = "", formula="";
        bool isOperationPerformed = false, isComputed = false, clickSign = false;
        string expression = "";

        public Form1() {
            InitializeComponent();
        }

        // 輸入數字 0~9 及小數點
        private void button_click(object sender, EventArgs e) {
            Button button = (Button)sender;

            if (tbDisplayResult.Text == "0" || isOperationPerformed) {
                if (button.Text != ".") tbDisplayResult.Clear();
                isOperationPerformed = false;
            }


            if (button.Text == ".") {
                if (!tbDisplayResult.Text.Contains(".")) {
                    tbDisplayResult.Text += button.Text;
                }
            } else {
                tbDisplayResult.Text += button.Text;
            }
        }

        // + - * /
        private void operator_click(object sender, EventArgs e) {
            if (expression != "" && !isComputed) {
                expression += tbDisplayResult.Text;
            } else {
                expression = tbDisplayResult.Text;
                isComputed = false;
            }

            char[] operators = { '+', '-', '*', '/' };
            char lastChar = expression[expression.Length - 1];
            Button button = (Button)sender;
            if (!operators.Contains(lastChar)) {
                switch (button.Text) {
                    case "x":
                        button.Text = "*";
                        break;
                    case "÷":
                        button.Text = "/";
                        break;
                    default:
                        break;
                }
                expression += button.Text;
                isOperationPerformed = true;
            }
        }

        // 
        private void btnSign_click(object sender, EventArgs e) {
            clickSign = true;
            if (expression != "" && !isComputed) {
                expression += tbDisplayResult.Text;
            } else {
                expression = tbDisplayResult.Text;
                isComputed = false;
            }

            int lastIndex;
            string replaceStr;
            if (tbDisplayResult.Text == "0" && expression == "") {
                // tbDisplayResult.Text = "0" expression = "" 
                
            } else if (tbDisplayResult.Text != "0" && expression == "") {
                // tbDisplayResult.Text != "0" expression = "" (-1)
                lastIndex = expression.LastIndexOf(tbDisplayResult.Text);
                replaceStr = "(-1)*" + tbDisplayResult.Text;
                expression = expression.Remove(lastIndex, tbDisplayResult.Text.Length).Insert(lastIndex, replaceStr); ;
                tbDisplayResult.Text = "(-" + tbDisplayResult.Text + ")";
            } else if (tbDisplayResult.Text == "0" && expression != "") {
                // tbDisplayResult.Text = "0" expression != "" 兩個都為 0

            } else if (tbDisplayResult.Text != "0" && expression != "") {
                // tbDisplayResult.Text != "0" expression != "" 1+(-2345)
                lastIndex = expression.LastIndexOf(tbDisplayResult.Text);
                replaceStr = "(-1)*"+ tbDisplayResult.Text;
                expression = expression.Remove(lastIndex, tbDisplayResult.Text.Length).Insert(lastIndex, replaceStr); ;
                tbDisplayResult.Text = "(-" + tbDisplayResult.Text + ")";
            }
        }

        // =
        private void btnEqual_Click(object sender, EventArgs e) {
            isComputed = true;
            if(!clickSign) expression += tbDisplayResult.Text;
            else { clickSign = false; }

            lbCurrentOp.Text = expression;
            isOperationPerformed = false;
            Expression exp = new Expression(expression);
            result = Convert.ToDouble(exp.Evaluate());

            tbDisplayResult.Text = result.ToString();
            expression = result.ToString(); ;
        }

        // CE clear entry 清除上一步
        private void btnCE_Click(object sender, EventArgs e) {
            if (isComputed) lbCurrentOp.Text = "";
            tbDisplayResult.Text = "0";
        }

        // C clear all
        private void btnC_Click(object sender, EventArgs e) {
            tbDisplayResult.Text = "0";
            expression = "";
            lbCurrentOp.Text = "";
            result = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (tbDisplayResult.Text.Length > 0) {
                tbDisplayResult.Text = tbDisplayResult.Text.Remove(tbDisplayResult.Text.Length - 1, 1);
            }
            if (tbDisplayResult.Text == "") {
                tbDisplayResult.Text = "0";
            }
        }
    }
}
