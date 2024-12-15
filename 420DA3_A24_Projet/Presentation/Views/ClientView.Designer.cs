namespace _420DA3_A24_Projet.Presentation.Views;

partial class ClientView {
    
    private System.ComponentModel.IContainer components = null;

    
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    
    private void InitialzeComponent() {
        this.lblClientName = new System.Windows.Forms.Label();
        this.lblContactEmail = new System.Windows.Forms.Label();
        this.lblContactFirstName = new System.Windows.Forms.Label();
        this.lblContactLastName = new System.Windows.Forms.Label();
        this.lblContactPhone = new System.Windows.Forms.Label();


        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.textBox3 = new System.Windows.Forms.TextBox();
        this.textBox4 = new System.Windows.Forms.TextBox();
        this.textBox5 = new System.Windows.Forms.TextBox();


        this.btnAdd = new System.Windows.Forms.Button();
        this.btnEdit = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.btnRefresh = new System.Windows.Forms.Button();

        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.comboBox1 = new System.Windows.Forms.ComboBox();

        this.SuspendLayout();

        this.lblClientName.AutoSize = true;
        this.lblClientName.Location = new System.Drawing.Point(50, 30);
        this.lblClientName.Name = "lblClientName";
        this.lblClientName.Size = new System.Drawing.Size(67, 13);
        this.lblClientName.Text = "Client Name";

        this.lblContactEmail.AutoSize = true;
        this.lblContactEmail.Location = new System.Drawing.Point(50, 70);
        this.lblContactEmail.Name = "lblContactEmail";
        this.lblContactEmail.Size = new System.Drawing.Size(72, 13);
        this.lblContactEmail.Text = "Contact Email";

        this.lblContactFirstName.AutoSize = true;
        this.lblContactFirstName.Location = new System.Drawing.Point(50, 110);
        this.lblContactFirstName.Name = "lblContactFirstName";
        this.lblContactFirstName.Size = new System.Drawing.Size(98, 13);
        this.lblContactFirstName.Text = "Contact First Name";


        this.lblContactLastName.AutoSize = true;
        this.lblContactLastName.Location = new System.Drawing.Point(50, 150);
        this.lblContactLastName.Name = "lblContactLastName";
        this.lblContactLastName.Size = new System.Drawing.Size(99, 13);
        this.lblContactLastName.Text = "Contact Last Name";

        this.lblContactPhone.AutoSize = true;
        this.lblContactPhone.Location = new System.Drawing.Point(50, 190);
        this.lblContactPhone.Name = "lblContactPhone";
        this.lblContactPhone.Size = new System.Drawing.Size(81, 13);
        this.lblContactPhone.Text = "Contact Phone";

        this.textBox1.Location = new System.Drawing.Point(150, 30);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(150, 20);

        this.textBox2.Location = new System.Drawing.Point(150, 70);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(150, 20);

        this.textBox3.Location = new System.Drawing.Point(150, 110);
        this.textBox3.Name = "textBox3";
        this.textBox3.Size = new System.Drawing.Size(150, 20);

        this.textBox4.Location = new System.Drawing.Point(150, 150);
        this.textBox4.Name = "textBox4";
        this.textBox4.Size = new System.Drawing.Size(150, 20);

        this.textBox5.Location = new System.Drawing.Point(150, 190);
        this.textBox5.Name = "textBox5";
        this.textBox5.Size = new System.Drawing.Size(150, 20);


        this.btnAdd.Location = new System.Drawing.Point(350, 30);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(75, 23);
        this.btnAdd.Text = "Add";
        this.btnAdd.UseVisualStyleBackColor = true;

        this.btnEdit.Location = new System.Drawing.Point(450, 30);
        this.btnEdit.Name = "btnEdit";
        this.btnEdit.Size = new System.Drawing.Size(75, 23);
        this.btnEdit.Text = "Edit";
        this.btnEdit.UseVisualStyleBackColor = true;

        this.btnDelete.Location = new System.Drawing.Point(400, 70);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(75, 23);
        this.btnDelete.Text = "Delete";
        this.btnDelete.UseVisualStyleBackColor = true;

        this.btnRefresh.Location = new System.Drawing.Point(400, 110);
        this.btnRefresh.Name = "btnRefresh";
        this.btnRefresh.Size = new System.Drawing.Size(75, 23);
        this.btnRefresh.Text = "Refresh";
        this.btnRefresh.UseVisualStyleBackColor = true;

        this.dataGridView1.Location = new System.Drawing.Point(50, 250);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.Size = new System.Drawing.Size(500, 150);

        this.comboBox1.Location = new System.Drawing.Point(150, 220);
        this.comboBox1.Name = "comboBox1";
        this.comboBox1.Size = new System.Drawing.Size(150, 21);
        this.ClientSize = new System.Drawing.Size(640, 450);
        this.Controls.Add(this.lblClientName);
        this.Controls.Add(this.lblContactEmail);
        this.Controls.Add(this.lblContactFirstName);
        this.Controls.Add(this.lblContactLastName);
        this.Controls.Add(this.lblContactPhone);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.textBox2);
        this.Controls.Add(this.textBox3);
        this.Controls.Add(this.textBox4);
        this.Controls.Add(this.textBox5);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.btnEdit);
        this.Controls.Add(this.btnDelete);
        this.Controls.Add(this.btnRefresh);
        this.Controls.Add(this.dataGridView1);
        this.Controls.Add(this.comboBox1);
        this.Name = "ClientView";
        this.Text = "ClientView";
        this.ResumeLayout(false); }
       
    private System.Windows.Forms.Label lblClientName;
    private System.Windows.Forms.Label lblContactEmail;
    private System.Windows.Forms.Label lblContactFirstName;
    private System.Windows.Forms.Label lblContactLastName;
    private System.Windows.Forms.Label lblContactPhone;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.ComboBox comboBox1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox textBox6;
    private TextBox textBox7;
    private TextBox textBox8;
    private TextBox textBox9;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Label label5;
}
    
