namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void total_price()
        {
            decimal sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
            }
            decimal taxRate = 0.12m;
            decimal taxAmount = sum * taxRate;
            decimal totalAmount = sum + taxAmount;

            lblTax.Text = "" + taxAmount.ToString();
            lblTotal.Text = "" + totalAmount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 150;
            decimal b = numq.Value;

            decimal price;
            price = a * b;
            dataGridView1.Rows.Add(b, "T-Shirt (S)", price);
            total_price();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 200;
            decimal b = numq.Value;

            decimal price;
            price = a * b;
            dataGridView1.Rows.Add(b, "T-Shirt (M)", price);
            total_price();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 250;
            decimal b = numq.Value;

            decimal price;
            price = a * b;
            dataGridView1.Rows.Add(b, "T-Shirt (L)", price);
            total_price();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cname = dataGridView1.Columns[e.ColumnIndex].Name;
            if (cname == "Dlt")
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);
                total_price();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ResetSystem();
        }

        private void ResetSystem()
        {
            dataGridView1.Rows.Clear();
            lblTotal.Text = "";
            lblTax.Text = "";
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            
            {
                ResetSystem();
            }
        }
    }
}

