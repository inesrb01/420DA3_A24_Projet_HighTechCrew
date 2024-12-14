namespace _420DA3_A24_Projet.Presentation.Views;

partial class WarehouseView {
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
        this.textBox1 = new TextBox();
        this.textBox2 = new TextBox();
        this.label3 = new Label();
        this.textBox3 = new TextBox();
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
        this.label1.Location = new Point(32, 49);
        this.label1.Name = "label1";
        this.label1.Size = new Size(147, 25);
        this.label1.TabIndex = 0;
        this.label1.Text = "WarehouseName";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(73, 188);
        this.label2.Name = "label2";
        this.label2.Size = new Size(42, 25);
        this.label2.TabIndex = 1;
        this.label2.Text = "City";
        // 
        // textBox1
        // 
        this.textBox1.Location = new Point(202, 49);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new Size(150, 31);
        this.textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        this.textBox2.Location = new Point(202, 112);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new Size(150, 31);
        this.textBox2.TabIndex = 3;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new Point(57, 112);
        this.label3.Name = "label3";
        this.label3.Size = new Size(77, 25);
        this.label3.TabIndex = 4;
        this.label3.Text = "Address";
        // 
        // textBox3
        // 
        this.textBox3.Location = new Point(202, 182);
        this.textBox3.Name = "textBox3";
        this.textBox3.Size = new Size(150, 31);
        this.textBox3.TabIndex = 5;
        // 
        // button1
        // 
        this.button1.Location = new Point(526, 44);
        this.button1.Name = "button1";
        this.button1.Size = new Size(112, 34);
        this.button1.TabIndex = 6;
        this.button1.Text = "Add";
        this.button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        this.button2.Location = new Point(677, 44);
        this.button2.Name = "button2";
        this.button2.Size = new Size(112, 34);
        this.button2.TabIndex = 7;
        this.button2.Text = "Edit";
        this.button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        this.button3.Location = new Point(526, 112);
        this.button3.Name = "button3";
        this.button3.Size = new Size(112, 34);
        this.button3.TabIndex = 8;
        this.button3.Text = "Delete";
        this.button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        this.button4.Location = new Point(677, 112);
        this.button4.Name = "button4";
        this.button4.Size = new Size(112, 34);
        this.button4.TabIndex = 9;
        this.button4.Text = "Refresh";
        this.button4.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Location = new Point(502, 218);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.RowHeadersWidth = 62;
        this.dataGridView1.RowTemplate.Height = 33;
        this.dataGridView1.Size = new Size(336, 202);
        this.dataGridView1.TabIndex = 10;
        // 
        // WarehouseView
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(873, 450);
        this.Controls.Add(this.dataGridView1);
        this.Controls.Add(this.button4);
        this.Controls.Add(this.button3);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.textBox3);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.textBox2);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "WarehouseView";
        ((System.ComponentModel.ISupportInitialize) this.dataGridView1).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox textBox1;
    private TextBox textBox2;
    private Label label3;
    private TextBox textBox3;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private DataGridView dataGridView1;
}