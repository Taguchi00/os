namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            numq = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            qtty = new DataGridViewTextBoxColumn();
            item = new DataGridViewTextBoxColumn();
            Prc = new DataGridViewTextBoxColumn();
            Dlt = new DataGridViewImageColumn();
            label5 = new Label();
            lblTotal = new Label();
            label6 = new Label();
            panel1 = new Panel();
            lblTax = new Label();
            label8 = new Label();
            btnConfirm = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Maroon;
            pictureBox1.Image = Properties.Resources.S2df984d7c89c44bf974747938ef7fd458;
            pictureBox1.Location = new Point(11, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Firebrick;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 44);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 1;
            label1.Text = "Grasya";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(11, 322);
            button1.Name = "button1";
            button1.Size = new Size(48, 43);
            button1.TabIndex = 2;
            button1.Text = "S";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(65, 322);
            button2.Name = "button2";
            button2.Size = new Size(48, 43);
            button2.TabIndex = 3;
            button2.Text = "M";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(119, 322);
            button3.Name = "button3";
            button3.Size = new Size(46, 43);
            button3.TabIndex = 4;
            button3.Text = "L";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // numq
            // 
            numq.Location = new Point(171, 334);
            numq.Name = "numq";
            numq.Size = new Size(42, 23);
            numq.TabIndex = 5;
            numq.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 366);
            label3.Name = "label3";
            label3.Size = new Size(29, 17);
            label3.TabIndex = 7;
            label3.Text = "200";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 366);
            label4.Name = "label4";
            label4.Size = new Size(27, 17);
            label4.TabIndex = 8;
            label4.Text = "150";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(128, 368);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 9;
            label2.Text = "250";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { qtty, item, Prc, Dlt });
            dataGridView1.Location = new Point(230, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(444, 331);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // qtty
            // 
            qtty.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            qtty.HeaderText = "Quantity";
            qtty.Name = "qtty";
            qtty.Resizable = DataGridViewTriState.True;
            qtty.Width = 78;
            // 
            // item
            // 
            item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item.HeaderText = "Item";
            item.Name = "item";
            // 
            // Prc
            // 
            Prc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Prc.HeaderText = "Price";
            Prc.Name = "Prc";
            Prc.Width = 58;
            // 
            // Dlt
            // 
            Dlt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Dlt.HeaderText = "";
            Dlt.Name = "Dlt";
            Dlt.Resizable = DataGridViewTriState.True;
            Dlt.Width = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 61);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 11;
            label5.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.White;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(217, 61);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 25);
            lblTotal.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Firebrick;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(11, 288);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 13;
            label6.Text = "Order here";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTax);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblTotal);
            panel1.Location = new Point(693, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 325);
            panel1.TabIndex = 14;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.BackColor = Color.White;
            lblTax.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTax.Location = new Point(217, 101);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(0, 25);
            lblTax.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 101);
            label8.Name = "label8";
            label8.Size = new Size(47, 25);
            label8.TabIndex = 16;
            label8.Text = "Tax:";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(0, 192, 0);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(88, 250);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(174, 51);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(125, 16);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 12;
            label7.Text = "Receipt";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(1038, 450);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numq);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "TINDAHAN NI ALING JENAH";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numq).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private NumericUpDown numq;
        private Label label3;
        private Label label4;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label5;
        private Label lblTotal;
        private Label label6;
        private DataGridViewTextBoxColumn qtty;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn Prc;
        private DataGridViewImageColumn Dlt;
        private Panel panel1;
        private Label label7;
        private Button btnConfirm;
        private Label lblTax;
        private Label label8;
    }
}
