using _420DA3_A24_Projet.Business.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_A24_Projet.Presentation.Views;
public partial class WarehouseView : Form {
    public WarehouseView() {
        InitializeComponent();
    }

    private void InitializeComponent() {
        this.label1 = new Label();
        this.label2 = new Label();
        this.label3 = new Label();
        this.textBox1 = new TextBox();
        this.textBox2 = new TextBox();
        this.textBox3 = new TextBox();
        this.button1 = new Button();
        this.button2 = new Button();
        this.button3 = new Button();
        this.button4 = new Button();
        this.dataGridView1 = new DataGridView();
        ((ISupportInitialize) this.dataGridView1).BeginInit();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(51, 44);
        this.label1.Name = "label1";
        this.label1.Size = new Size(147, 25);
        this.label1.TabIndex = 0;
        this.label1.Text = "WarehouseName";
        this.label1.Click += this.label1_Click;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(87, 96);
        this.label2.Name = "label2";
        this.label2.Size = new Size(77, 25);
        this.label2.TabIndex = 1;
        this.label2.Text = "Address";
        this.label2.Click += this.label2_Click;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new Point(87, 154);
        this.label3.Name = "label3";
        this.label3.Size = new Size(42, 25);
        this.label3.TabIndex = 2;
        this.label3.Text = "City";
        this.label3.Click += this.label3_Click;
        // 
        // textBox1
        // 
        this.textBox1.Location = new Point(204, 44);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new Size(150, 31);
        this.textBox1.TabIndex = 3;
        this.textBox1.TextChanged += this.textBox1_TextChanged;
        // 
        // textBox2
        // 
        this.textBox2.Location = new Point(204, 96);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new Size(150, 31);
        this.textBox2.TabIndex = 4;
        this.textBox2.TextChanged += this.textBox2_TextChanged;
        // 
        // textBox3
        // 
        this.textBox3.Location = new Point(204, 148);
        this.textBox3.Name = "textBox3";
        this.textBox3.Size = new Size(150, 31);
        this.textBox3.TabIndex = 5;
        this.textBox3.TextChanged += this.textBox3_TextChanged;
        // 
        // button1
        // 
        this.button1.Location = new Point(440, 52);
        this.button1.Name = "button1";
        this.button1.Size = new Size(112, 34);
        this.button1.TabIndex = 6;
        this.button1.Text = "Add";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += this.button1_Click;
        // 
        // button2
        // 
        this.button2.Location = new Point(579, 52);
        this.button2.Name = "button2";
        this.button2.Size = new Size(112, 34);
        this.button2.TabIndex = 7;
        this.button2.Text = "Edit";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += this.button2_Click;
        // 
        // button3
        // 
        this.button3.Location = new Point(440, 117);
        this.button3.Name = "button3";
        this.button3.Size = new Size(112, 34);
        this.button3.TabIndex = 8;
        this.button3.Text = "Delete";
        this.button3.UseVisualStyleBackColor = true;
        this.button3.Click += this.button3_Click;
        // 
        // button4
        // 
        this.button4.Location = new Point(579, 117);
        this.button4.Name = "button4";
        this.button4.Size = new Size(112, 34);
        this.button4.TabIndex = 9;
        this.button4.Text = "Refresh";
        this.button4.UseVisualStyleBackColor = true;
        this.button4.Click += this.button4_Click;
        // 
        // dataGridView1
        // 
        this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Location = new Point(440, 212);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.RowHeadersWidth = 62;
        this.dataGridView1.RowTemplate.Height = 33;
        this.dataGridView1.Size = new Size(231, 142);
        this.dataGridView1.TabIndex = 10;
        this.dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
        // 
        // WarehouseView
        // 
        this.ClientSize = new Size(748, 381);
        this.Controls.Add(this.dataGridView1);
        this.Controls.Add(this.button4);
        this.Controls.Add(this.button3);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.textBox3);
        this.Controls.Add(this.textBox2);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "WarehouseView";
        ((ISupportInitialize) this.dataGridView1).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private void button1_Click(object sender, EventArgs e) {
        Warehouse.Add(new Warehouse {
            WarehouseName = textBox1.Text,

            City = textBox3.Text
        });

        MessageBox.Show("Warehouse added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        LoadData();
        ClearFields();
    }

    private void LoadData() {
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = Warehouse.GetAll();
    }

    private void ClearFields() {
        throw new NotImplementedException();
    }

    private void label1_Click(object sender, EventArgs e) {
        MessageBox.Show("Label1 clicked!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void label2_Click(object sender, EventArgs e) {
        MessageBox.Show("Label2 clicked!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void textBox2_TextChanged(object sender, EventArgs e) {
        string inputText = textBox2.Text;
        MessageBox.Show("Vous avez saisi : " + inputText, "Texte modifié");

        if (string.IsNullOrWhiteSpace(inputText)) {
            MessageBox.Show("Le champ ne peut pas être vide.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void label3_Click(object sender, EventArgs e) {
        MessageBox.Show("Label3 clicked!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void textBox1_TextChanged(object sender, EventArgs e) {
        label3.Text = textBox1.Text;
    }

    private void textBox3_TextChanged(object sender, EventArgs e) {
        textBox1.Text = textBox3.Text;
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            MessageBox.Show("Cell Value: " + cell.Value.ToString(), "Cell Clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string rowData = "";
            foreach (DataGridViewCell rowCell in row.Cells) {
                rowData += rowCell.Value + " ";
            }
            Console.WriteLine("Row Data: " + rowData);
        }
    }

    private void button2_Click(object sender, EventArgs e) {

    }

    private void button3_Click(object sender, EventArgs e) {

    }

    private void button4_Click(object sender, EventArgs e) {

    }
}
