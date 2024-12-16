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
public partial class ClientView : Form {
    public ClientView(Business.Services.WsysApplication parentApp) {
        InitializeComponent();
    }

    private void InitializeComponent() {
        this.label1 = new Label();
        this.label2 = new Label();
        this.label3 = new Label();
        this.label4 = new Label();
        this.textBox6 = new TextBox();
        this.textBox7 = new TextBox();
        this.textBox8 = new TextBox();
        this.textBox9 = new TextBox();
        this.button1 = new Button();
        this.button2 = new Button();
        this.button3 = new Button();
        this.button4 = new Button();
        this.comboBox1 = new ComboBox();
        this.dataGridView1 = new DataGridView();
        this.label5 = new Label();
        this.textBox1 = new TextBox();
        ((ISupportInitialize) this.dataGridView1).BeginInit();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(64, 52);
        this.label1.Name = "label1";
        this.label1.Size = new Size(103, 25);
        this.label1.TabIndex = 0;
        this.label1.Text = "ClientName";
        this.label1.Click += this.label1_Click;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(64, 101);
        this.label2.Name = "label2";
        this.label2.Size = new Size(115, 25);
        this.label2.TabIndex = 1;
        this.label2.Text = "ContactEmail";
        this.label2.Click += this.label2_Click;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new Point(64, 150);
        this.label3.Name = "label3";
        this.label3.Size = new Size(153, 25);
        this.label3.TabIndex = 2;
        this.label3.Text = "ContactFirstName";
        this.label3.Click += this.label3_Click;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new Point(64, 205);
        this.label4.Name = "label4";
        this.label4.Size = new Size(151, 25);
        this.label4.TabIndex = 3;
        this.label4.Text = "ContactLastName";
        this.label4.Click += this.label4_Click;
        // 
        // textBox6
        // 
        this.textBox6.Location = new Point(223, 52);
        this.textBox6.Name = "textBox6";
        this.textBox6.Size = new Size(150, 31);
        this.textBox6.TabIndex = 4;
        this.textBox6.TextChanged += this.textBox6_TextChanged;
        // 
        // textBox7
        // 
        this.textBox7.Location = new Point(221, 101);
        this.textBox7.Name = "textBox7";
        this.textBox7.Size = new Size(150, 31);
        this.textBox7.TabIndex = 5;
        this.textBox7.TextChanged += this.textBox7_TextChanged;
        // 
        // textBox8
        // 
        this.textBox8.Location = new Point(223, 150);
        this.textBox8.Name = "textBox8";
        this.textBox8.Size = new Size(150, 31);
        this.textBox8.TabIndex = 6;
        this.textBox8.TextChanged += this.textBox8_TextChanged;
        // 
        // textBox9
        // 
        this.textBox9.Location = new Point(221, 205);
        this.textBox9.Name = "textBox9";
        this.textBox9.Size = new Size(150, 31);
        this.textBox9.TabIndex = 7;
        this.textBox9.TextChanged += this.textBox9_TextChanged;
        // 
        // button1
        // 
        this.button1.Location = new Point(436, 57);
        this.button1.Name = "button1";
        this.button1.Size = new Size(112, 34);
        this.button1.TabIndex = 8;
        this.button1.Text = "Add";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += this.button1_Click;
        // 
        // button2
        // 
        this.button2.Location = new Point(584, 57);
        this.button2.Name = "button2";
        this.button2.Size = new Size(112, 34);
        this.button2.TabIndex = 9;
        this.button2.Text = "Edit";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += this.button2_Click;
        // 
        // button3
        // 
        this.button3.Location = new Point(511, 116);
        this.button3.Name = "button3";
        this.button3.Size = new Size(112, 34);
        this.button3.TabIndex = 10;
        this.button3.Text = "Delete";
        this.button3.UseVisualStyleBackColor = true;
        this.button3.Click += this.button3_Click;
        // 
        // button4
        // 
        this.button4.Location = new Point(511, 173);
        this.button4.Name = "button4";
        this.button4.Size = new Size(112, 34);
        this.button4.TabIndex = 11;
        this.button4.Text = "Refresh";
        this.button4.UseVisualStyleBackColor = true;
        this.button4.Click += this.button4_Click;
        // 
        // comboBox1
        // 
        this.comboBox1.FormattingEnabled = true;
        this.comboBox1.Location = new Point(92, 338);
        this.comboBox1.Name = "comboBox1";
        this.comboBox1.Size = new Size(182, 33);
        this.comboBox1.TabIndex = 12;
        this.comboBox1.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
        // 
        // dataGridView1
        // 
        this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Location = new Point(447, 224);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.RowHeadersWidth = 62;
        this.dataGridView1.RowTemplate.Height = 33;
        this.dataGridView1.Size = new Size(274, 157);
        this.dataGridView1.TabIndex = 13;
        this.dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new Point(65, 261);
        this.label5.Name = "label5";
        this.label5.Size = new Size(123, 25);
        this.label5.TabIndex = 14;
        this.label5.Text = "ContactPhone";
        this.label5.Click += this.label5_Click;
        // 
        // textBox1
        // 
        this.textBox1.Location = new Point(221, 261);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new Size(150, 31);
        this.textBox1.TabIndex = 15;
        this.textBox1.TextChanged += this.textBox1_TextChanged;
        // 
        // ClientView
        // 
        this.ClientSize = new Size(758, 411);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.dataGridView1);
        this.Controls.Add(this.comboBox1);
        this.Controls.Add(this.button4);
        this.Controls.Add(this.button3);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.textBox9);
        this.Controls.Add(this.textBox8);
        this.Controls.Add(this.textBox7);
        this.Controls.Add(this.textBox6);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "ClientView";
        ((ISupportInitialize) this.dataGridView1).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private void label1_Click(object sender, EventArgs e) {
        try {
            string clientName = "John Doe"; // Replace with dynamic data
            MessageBox.Show($"You clicked on the ClientName label. Current client name is: {clientName}",
                            "Client Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } catch (Exception ex) {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void label2_Click(object sender, EventArgs e) {
        try {
            string contactEmail = "example@email.com"; // Replace with dynamic data
            MessageBox.Show($"You clicked on the ContactEmail label. Current email is: {contactEmail}",
                            "Contact Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } catch (Exception ex) {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void label3_Click(object sender, EventArgs e) {
        try {
            string contactFirstName = "John"; // Replace with dynamic data
            MessageBox.Show($"You clicked on the ContactFirstName label. Current first name is: {contactFirstName}",
                            "Contact First Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } catch (Exception ex) {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void label4_Click(object sender, EventArgs e) {
        try {
            string contactLastName = "Smith"; // Replace with dynamic data
            MessageBox.Show($"You clicked on the ContactLastName label. Current last name is: {contactLastName}",
                            "Contact Last Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } catch (Exception ex) {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void label5_Click(object sender, EventArgs e) {
        try {
            string contactPhone = "+1-555-123-4567"; // Replace with dynamic data
            MessageBox.Show($"You clicked on the ContactPhone label. Current phone number is: {contactPhone}",
                            "Contact Phone", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } catch (Exception ex) {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void textBox6_TextChanged(object sender, EventArgs e) {
        try {
            TextBox textBox = sender as TextBox;

            if (textBox != null) {
                string currentText = textBox.Text;

                Console.WriteLine($"Text in TextBox1 changed: {currentText}");

                if (string.IsNullOrWhiteSpace(currentText)) {
                    MessageBox.Show("The text cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        } catch (Exception ex) {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void textBox7_TextChanged(object sender, EventArgs e) {
        try {
            // Cast sender to TextBox to get the current input
            TextBox textBox = sender as TextBox;
            if (textBox != null) {
                string currentText = textBox.Text;
                // Example: Update a label or log the current text
                Console.WriteLine($"ContactEmail updated to: {currentText}");
            }
        } catch (Exception ex) {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void button1_Click(object sender, EventArgs e) {
        MessageBox.Show("Add Client logic goes here.");
    }

    private void button2_Click(object sender, EventArgs e) {
        MessageBox.Show("Edit Client logic goes here.");
    }

    private void button3_Click(object sender, EventArgs e) {
        MessageBox.Show("Delete Client logic goes here.");
    }

    private void button4_Click(object sender, EventArgs e) {
        MessageBox.Show("Refresh Clients logic goes here.");
    }

    private void textBox8_TextChanged(object sender, EventArgs e) {

    }

    private void textBox9_TextChanged(object sender, EventArgs e) {

    }

    private void textBox1_TextChanged(object sender, EventArgs e) {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
        try {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null) {
                string selectedItem = comboBox.SelectedItem.ToString();

                MessageBox.Show($"You selected: {selectedItem}",
                                "Selection Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                switch (selectedItem) {
                    case "Option1":
                        Console.WriteLine("Option1 was selected");
                        break;

                    case "Option2":
                        Console.WriteLine("Option2 was selected");
                        break;

                    default:
                        Console.WriteLine($"Other option selected: {selectedItem}");
                        break;
                }
            }
        } catch (Exception ex) {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}