using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Counting21._01._24
{
    public partial class Counting : Form
    {
        public Counting()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisibleNumbers.Items.Add("2");
            cmbDivisibleNumbers.Items.Add("4");
            cmbDivisibleNumbers.Items.Add("5");
            cmbDivisibleNumbers.Items.Add("7");
            cmbDivisibleNumbers.Items.Add("10");
            //cmbDivisibleNumbers.SelectedItem = "2";

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int start = 0; 
        int to = 0;
        int divisibleNum = 1;
        string nums = "";
        int lineControl = 1;

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (textBoxStartsFrom.Text== "" || textBoxTo.Text == "")
            {
                MessageBox.Show("input needed!");
            }else if (cmbDivisibleNumbers.SelectedIndex == -1)
            {
                MessageBox.Show("input needed in divider!");

            }
            else { 
            start = int.Parse(textBoxStartsFrom.Text);
            to = int.Parse(textBoxTo.Text);
            
            for (int i = start ; i< to+1; i++)
            {
                if (i % divisibleNum == 0)
                {
                    nums += i.ToString()+" ";
                    if (lineControl%10==0)
                    {
                        nums+= Environment.NewLine;
                    }
                        lineControl++;
                }
            }
           
            //MessageBox.Show("start:  "+start + " to " + to + nums);
            allNumsOutcome.Text = nums;



        }
    }

    private void cmbDivisibleNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //divisibleNum = int.Parse(cmbDivisibleNumbers.SelectedItem); // Does not work with this kind of parse. (Needs "Convert.Int32")
            divisibleNum = Convert.ToInt32(cmbDivisibleNumbers.SelectedItem);
            MessageBox.Show(""+divisibleNum);
        }

        private void textBoxStartsFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') // '\b' is the backspace key// optional

            // Check if the pressed key is a digit or a control character (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not a digit or backspace, suppress the key press event
                e.Handled = true;
            }
        }

        private void textBoxTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control character (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not a digit or backspace, suppress the key press event
                e.Handled = true;
            }
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbBlack.Checked)
            //{
            //    rbBlue.Checked = false;
            //    rbRed.Checked = false;
            //    rbGreen.Checked = false;

            //}

            allNumsOutcome.ForeColor = Color.Black;

        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            allNumsOutcome.ForeColor = Color.Blue;

        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            allNumsOutcome.ForeColor = Color.Red;

        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            allNumsOutcome.ForeColor = Color.Green;

        }

        private void bold_Click(object sender, EventArgs e)
        {
            if (allNumsOutcome.Font != null && allNumsOutcome.Font.Style == FontStyle.Bold)
            {
                //allNumsOutcome.Font = new Font(allNumsOutcome.Font, FontStyle.Regular);
                allNumsOutcome.Font = new Font(allNumsOutcome.Font.FontFamily, allNumsOutcome.Font.Size, FontStyle.Regular);

            }
            else
            {
                allNumsOutcome.Font = new Font(allNumsOutcome.Font.FontFamily, allNumsOutcome.Font.Size, FontStyle.Bold);
            }

        }

        private void italic_Click(object sender, EventArgs e)
        {
            if (allNumsOutcome.Font != null && allNumsOutcome.Font.Style == FontStyle.Italic)
            {
                allNumsOutcome.Font = new Font(allNumsOutcome.Font.FontFamily, allNumsOutcome.Font.Size, FontStyle.Regular);
            }
            else
            {
                allNumsOutcome.Font = new Font(allNumsOutcome.Font.FontFamily, allNumsOutcome.Font.Size, FontStyle.Italic);
            }
        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBold.Checked)
            {
                allNumsOutcome.Font = new Font(allNumsOutcome.Font.FontFamily, allNumsOutcome.Font.Size, FontStyle.Bold);
            }
            else
            {
                allNumsOutcome.Font = new Font(allNumsOutcome.Font.FontFamily, allNumsOutcome.Font.Size, FontStyle.Regular);
            }
        }

        private void cbItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (cbItalic.Checked)
            {
                allNumsOutcome.Font = new Font(allNumsOutcome.Font.FontFamily, allNumsOutcome.Font.Size, FontStyle.Italic);
            }
            else
            {
                allNumsOutcome.Font = new Font(allNumsOutcome.Font.FontFamily, allNumsOutcome.Font.Size, FontStyle.Regular);
            }
        }
    }
}
