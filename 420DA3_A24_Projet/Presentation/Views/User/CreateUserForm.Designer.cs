namespace _420DA3_A24_Projet.Presentation.Views.Forms.User;

partial class CreateUserForm {
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
        this.panel1 = new Panel();
        this.buttonCreateUser = new Button();
        this.listViewRole = new ListView();
        this.cmbWarehouseList = new ComboBox();
        this.textBoxConfirmPassword = new TextBox();
        this.textBoxPassword = new TextBox();
        this.textBoxUserName = new TextBox();
        this.label5 = new Label();
        this.label4 = new Label();
        this.label3 = new Label();
        this.label2 = new Label();
        this.label1 = new Label();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.panel1.Controls.Add(this.buttonCreateUser);
        this.panel1.Controls.Add(this.listViewRole);
        this.panel1.Controls.Add(this.cmbWarehouseList);
        this.panel1.Controls.Add(this.textBoxConfirmPassword);
        this.panel1.Controls.Add(this.textBoxPassword);
        this.panel1.Controls.Add(this.textBoxUserName);
        this.panel1.Controls.Add(this.label5);
        this.panel1.Controls.Add(this.label4);
        this.panel1.Controls.Add(this.label3);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Location = new Point(100, 71);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(616, 486);
        this.panel1.TabIndex = 0;
        // 
        // buttonCreateUser
        // 
        this.buttonCreateUser.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.buttonCreateUser.Location = new Point(215, 386);
        this.buttonCreateUser.Name = "buttonCreateUser";
        this.buttonCreateUser.Size = new Size(271, 37);
        this.buttonCreateUser.TabIndex = 10;
        this.buttonCreateUser.Text = "Create";
        this.buttonCreateUser.UseVisualStyleBackColor = true;
        this.buttonCreateUser.Click += this.ButtonCreateUser_Click;
        // 
        // listViewRole
        // 
        this.listViewRole.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.listViewRole.Location = new Point(220, 242);
        this.listViewRole.Name = "listViewRole";
        this.listViewRole.Size = new Size(266, 110);
        this.listViewRole.TabIndex = 9;
        this.listViewRole.UseCompatibleStateImageBehavior = false;
        this.listViewRole.View = View.List;
        // 
        // cmbWarehouseList
        // 
        this.cmbWarehouseList.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.cmbWarehouseList.AutoCompleteCustomSource.AddRange(new string[] { "WereHouse 1", "WereHouse 2", "WereHouse 3", "WereHouse 4" });
        this.cmbWarehouseList.FormattingEnabled = true;
        this.cmbWarehouseList.Location = new Point(220, 186);
        this.cmbWarehouseList.Name = "cmbWarehouseList";
        this.cmbWarehouseList.Size = new Size(266, 23);
        this.cmbWarehouseList.TabIndex = 8;
        // 
        // textBoxConfirmPassword
        // 
        this.textBoxConfirmPassword.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.textBoxConfirmPassword.Location = new Point(220, 143);
        this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
        this.textBoxConfirmPassword.Size = new Size(266, 23);
        this.textBoxConfirmPassword.TabIndex = 7;
        // 
        // textBoxPassword
        // 
        this.textBoxPassword.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.textBoxPassword.Location = new Point(220, 95);
        this.textBoxPassword.Name = "textBoxPassword";
        this.textBoxPassword.Size = new Size(266, 23);
        this.textBoxPassword.TabIndex = 6;
        // 
        // textBoxUserName
        // 
        this.textBoxUserName.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.textBoxUserName.Location = new Point(220, 43);
        this.textBoxUserName.Name = "textBoxUserName";
        this.textBoxUserName.Size = new Size(266, 23);
        this.textBoxUserName.TabIndex = 5;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new Point(63, 242);
        this.label5.Name = "label5";
        this.label5.Size = new Size(44, 15);
        this.label5.TabIndex = 4;
        this.label5.Text = "Roles : ";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new Point(63, 194);
        this.label4.Name = "label4";
        this.label4.Size = new Size(72, 15);
        this.label4.TabIndex = 3;
        this.label4.Text = "Warehouse :";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new Point(63, 146);
        this.label3.Name = "label3";
        this.label3.Size = new Size(116, 15);
        this.label3.TabIndex = 2;
        this.label3.Text = "Confirme Password :";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(63, 98);
        this.label2.Name = "label2";
        this.label2.Size = new Size(63, 15);
        this.label2.TabIndex = 1;
        this.label2.Text = "Password :";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(63, 50);
        this.label1.Name = "label1";
        this.label1.Size = new Size(68, 15);
        this.label1.TabIndex = 0;
        this.label1.Text = "UserName :";
        // 
        // CreateUserForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(828, 646);
        this.Controls.Add(this.panel1);
        this.MinimizeBox = false;
        this.Name = "CreateUserForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Create User";
        this.Load += this.CreateUserForm_Load;
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private Button buttonCreateUser;
    private ListView listViewRole;
    private ComboBox cmbWarehouseList;
    private TextBox textBoxConfirmPassword;
    private TextBox textBoxPassword;
    private TextBox textBoxUserName;
    private Label label5;
}