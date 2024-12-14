namespace _420DA3_A24_Projet.Presentation.Views;

partial class ClientView {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.label1 = new Label();
        this.label2 = new Label();
        this.label3 = new Label();
        this.label4 = new Label();
        this.label5 = new Label();
        this.textBox1 = new TextBox();
        this.textBox2 = new TextBox();
        this.textBox3 = new TextBox();
        this.textBox4 = new TextBox();
        this.textBox5 = new TextBox();
        this.comboBox1 = new ComboBox();
        this.button1 = new Button();
        this.button2 = new Button();
        this.button3 = new Button();
        this.button4 = new Button();
        this.dataGridView1 = new DataGridView();
        ((System.ComponentModel.ISupportInitialize) this.dataGridView1).BeginInit();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(63, 37);
        this.label1.Name = "label1";
        this.label1.Size = new Size(103, 25);
        this.label1.TabIndex = 0;
        this.label1.Text = "ClientName";
        this.label1.Click += this.label1_Click;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(63, 82);
        this.label2.Name = "label2";
        this.label2.Size = new Size(115, 25);
        this.label2.TabIndex = 1;
        this.label2.Text = "ContactEmail";
        this.label2.Click += this.label2_Click;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new Point(63, 132);
        this.label3.Name = "label3";
        this.label3.Size = new Size(153, 25);
        this.label3.TabIndex = 2;
        this.label3.Text = "ContactFirstName";
        this.label3.Click += this.label3_Click;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new Point(63, 180);
        this.label4.Name = "label4";
        this.label4.Size = new Size(151, 25);
        this.label4.TabIndex = 3;
        this.label4.Text = "ContactLastName";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new Point(63, 233);
        this.label5.Name = "label5";
        this.label5.Size = new Size(123, 25);
        this.label5.TabIndex = 4;
        this.label5.Text = "ContactPhone";
        // 
        // textBox1
        // 
        this.textBox1.Location = new Point(283, 39);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new Size(150, 31);
        this.textBox1.TabIndex = 5;
        // 
        // textBox2
        // 
        this.textBox2.Location = new Point(283, 82);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new Size(150, 31);
        this.textBox2.TabIndex = 6;
        this.textBox2.TextChanged += this.textBox2_TextChanged;
        // 
        // textBox3
        // 
        this.textBox3.Location = new Point(283, 132);
        this.textBox3.Name = "textBox3";
        this.textBox3.Size = new Size(150, 31);
        this.textBox3.TabIndex = 7;
        // 
        // textBox4
        // 
        this.textBox4.Location = new Point(283, 180);
        this.textBox4.Name = "textBox4";
        this.textBox4.Size = new Size(150, 31);
        this.textBox4.TabIndex = 8;
        // 
        // textBox5
        // 
        this.textBox5.Location = new Point(283, 230);
        this.textBox5.Name = "textBox5";
        this.textBox5.Size = new Size(150, 31);
        this.textBox5.TabIndex = 9;
        // 
        // comboBox1
        // 
        this.comboBox1.FormattingEnabled = true;
        this.comboBox1.Location = new Point(158, 348);
        this.comboBox1.Name = "comboBox1";
        this.comboBox1.Size = new Size(182, 33);
        this.comboBox1.TabIndex = 10;
        // 
        // button1
        // 
        this.button1.Location = new Point(642, 37);
        this.button1.Name = "button1";
        this.button1.Size = new Size(112, 34);
        this.button1.TabIndex = 11;
        this.button1.Text = "Add";
        this.button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        this.button2.Location = new Point(813, 36);
        this.button2.Name = "button2";
        this.button2.Size = new Size(112, 34);
        this.button2.TabIndex = 12;
        this.button2.Text = "Edit";
        this.button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        this.button3.Location = new Point(744, 98);
        this.button3.Name = "button3";
        this.button3.Size = new Size(112, 34);
        this.button3.TabIndex = 13;
        this.button3.Text = "Delete";
        this.button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        this.button4.Location = new Point(744, 152);
        this.button4.Name = "button4";
        this.button4.Size = new Size(112, 34);
        this.button4.TabIndex = 14;
        this.button4.Text = "Refresh";
        this.button4.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Location = new Point(686, 263);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.RowHeadersWidth = 62;
        this.dataGridView1.RowTemplate.Height = 33;
        this.dataGridView1.Size = new Size(239, 166);
        this.dataGridView1.TabIndex = 15;
        // 
        // ClientView
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(979, 437);
        this.Controls.Add(this.dataGridView1);
        this.Controls.Add(this.button4);
        this.Controls.Add(this.button3);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.comboBox1);
        this.Controls.Add(this.textBox5);
        this.Controls.Add(this.textBox4);
        this.Controls.Add(this.textBox3);
        this.Controls.Add(this.textBox2);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "ClientView";
        this.Text = "ClientView";
        ((System.ComponentModel.ISupportInitialize) this.dataGridView1).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private TextBox textBox5;
    private ComboBox comboBox1;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private DataGridView dataGridView1;
}