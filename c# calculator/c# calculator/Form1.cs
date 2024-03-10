namespace c__calculator
{
    public partial class Cal : Form
    {
        double fstnum, secnum;
        string oper;
        public Cal()
        {
            InitializeComponent();
        }

        private void Cal_Load(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "7";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "8";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "9";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "4";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "5";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "6";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "6";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "1";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "2";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "3";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "3";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "0";
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + "0";
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            fstnum = double.Parse(txtdisplay.Text);
            oper = "+";
            txtdisplay.Text = "";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            fstnum = double.Parse(txtdisplay.Text);
            oper = "-";
            txtdisplay.Text = "";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            fstnum = double.Parse(txtdisplay.Text);
            oper = "*";
            txtdisplay.Text = "";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            fstnum = double.Parse(txtdisplay.Text);
            oper = "/";
            txtdisplay.Text = "";
        }

        private void btnpm_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtdisplay.Text);
            txtdisplay.Text = Convert.ToString(-1 * q);
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";

            string f, s;

            f = Convert.ToString(fstnum);
            s = Convert.ToString(secnum);
            f = "";
            s = "";
        }

        private void btnbackspace_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text.Length > 0)
            {
                txtdisplay.Text = txtdisplay.Text.Remove(txtdisplay.Text.Length - 1, 1);
            }

            if (txtdisplay.Text == "")
            {
                txtdisplay.Text = "0";
            }
        }

        private void btnequ_Click(object sender, EventArgs e)
        {
            secnum = double.Parse(txtdisplay.Text);
            switch(oper)
            {
                case "+":
                    txtdisplay.Text = (fstnum + secnum).ToString();
                    break;
                case "-":
                    txtdisplay.Text = (fstnum - secnum).ToString();
                    break;
                case "*":
                    txtdisplay.Text = (fstnum * secnum).ToString();
                    break;
                case "/":
                    txtdisplay.Text = (fstnum / secnum).ToString();
                    break;

                default:
                    break;
            }
        }
    }
}
