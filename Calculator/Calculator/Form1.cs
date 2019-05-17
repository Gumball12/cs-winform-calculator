using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace Calculator
{
    public partial class Form : MaterialForm
    {
        private enum operators { NIL, ADD, SUB, MUL, DIV }; // operators enum
        
        private long od1 = 0, od2 = 0; // operands
        private operators op = operators.NIL; // operator

        private List<String> histories = new List<String>();  // hostiry array

        private readonly int LENGTH = 10; // operand length
        private readonly int HISTORY_LENGTH = 18; // history array length

        // constructor
        public Form()
        {
            // init component
            InitializeComponent();

            // init colorscheme (for MaterialSkin)
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        // update result field and history field
        private void updateResultField ()
        {
            resultField.Text = Convert.ToString(od1); // append operand 1

            if (op != operators.NIL) // check operator is available
            {
                string o = " ";

                switch (op)
                {
                    case operators.ADD:
                        o += "+";
                        break;
                    case operators.DIV:
                        o += "/";
                        break;
                    case operators.MUL:
                        o += "*";
                        break;
                    case operators.SUB:
                        o += "-";
                        break;
                }

                resultField.Text += o + " "; // append operator
                resultField.Text += Convert.ToString(od2); // append operand 2
            }
        }

        // update history field
        private void updateHistoryField (long result)
        {
            // history array length guard
            if (histories.Count() > HISTORY_LENGTH) // check history array length
            {
                histories = histories.GetRange(1, HISTORY_LENGTH); // reduce history array
            }

            histories.Add(resultField.Text + $" = {result}"); // append history
            historyField.Text = String.Join("\n", histories);
        }

        // append value to operand variable
        private void appendOperand (int v)
        {
            // check operator is available
            if (op == operators.NIL)
            {
                appendOperandVariable(ref od1, v);
            } else
            {
                appendOperandVariable(ref od2, v);
            }

            updateResultField();
        }

        // append to operand (using c# pointer)
        private long appendOperandVariable (ref long od, int v)
        {
            string tmp = Convert.ToString(od);

            if (v == -1)
            {
                // remove
                if (tmp.Length > 1)
                {
                    tmp = tmp.Substring(0, tmp.Length - 1);
                } else
                {
                    tmp = "0";
                }
            } else
            {
                // length guard
                if (tmp.Length < LENGTH)
                {
                    // append
                    tmp += v;
                }
            }

            od = Convert.ToInt64(tmp);

            return od;
        }

        // set operator
        private void setOperator(operators v)
        {
            // update operator
            op = v;

            updateResultField();
        }

        /* event handlers */

        private void btn_1_Click(object sender, EventArgs e)
        {
            appendOperand(1);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            appendOperand(2);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            appendOperand(3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            appendOperand(4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            appendOperand(5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            appendOperand(6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            appendOperand(7);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            appendOperand(8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            appendOperand(9);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            appendOperand(0);
        }

        private void btn_bck_Click(object sender, EventArgs e)
        {
            if (op != operators.NIL && od2 == 0) {
                // remove operator
                setOperator(operators.NIL);
            } else
            {
                // remove operand
                appendOperand(-1);
            }
        }

        private void btn_cln_Click(object sender, EventArgs e)
        {
            // clear operands and operator data
            od2 = 0;
            od1 = 0;
            setOperator(operators.NIL);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            setOperator(operators.ADD);
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            setOperator(operators.SUB);
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            setOperator(operators.MUL);
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            setOperator(operators.DIV);
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case operators.ADD:
                    od1 += od2;
                    break;
                case operators.DIV:
                    od2 |= 1; // div 0 guard
                    od1 /= od2;
                    break;
                case operators.MUL:
                    od1 *= od2;
                    break;
                case operators.SUB:
                    od1 -= od2;
                    break;
                default:
                    // nil operator guard
                    return;
            }

            // update history field
            updateHistoryField(od1);

            // re-init
            od2 = 0;
            setOperator(operators.NIL);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // init result field
            resultField.Text = "0";
        }
    }
}
