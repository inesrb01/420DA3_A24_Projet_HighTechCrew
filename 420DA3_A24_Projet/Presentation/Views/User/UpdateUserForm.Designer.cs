namespace _420DA3_A24_Projet.Presentation.Views.Forms.User;

partial class UpdateUserForm {
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
        this.buttonUpdateUser = new Button();
        this.listViewRole = new ListView();
        this.cmbWarehouseList = new ComboBox();
        this.textBoxPassword = new TextBox();
        this.textBoxUserName = new TextBox();
        this.label5 = new Label();
        this.label4 = new Label();
        this.label2 = new Label();
        this.label1 = new Label();
        this.panel2 = new Panel();
        this.label7 = new Label();
        this.textBoxOldRoles = new TextBox();
        this.label6 = new Label();
        this.textBoxUserId = new TextBox();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.panel1.Controls.Add(this.buttonUpdateUser);
        this.panel1.Controls.Add(this.listViewRole);
        this.panel1.Controls.Add(this.cmbWarehouseList);
        this.panel1.Controls.Add(this.textBoxPassword);
        this.panel1.Controls.Add(this.textBoxUserName);
        this.panel1.Controls.Add(this.label5);
        this.panel1.Controls.Add(this.label4);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Location = new Point(70, 125);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(616, 406);
        this.panel1.TabIndex = 1;
        // 
        // buttonUpdateUser
        // 
        this.buttonUpdateUser.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.buttonUpdateUser.Location = new Point(215, 348);
        this.buttonUpdateUser.Name = "buttonUpdateUser";
        this.buttonUpdateUser.Size = new Size(271, 37);
        this.buttonUpdateUser.TabIndex = 10;
        this.buttonUpdateUser.Text = "Update";
        this.buttonUpdateUser.UseVisualStyleBackColor = true;
        this.buttonUpdateUser.Click += this.ButtonUpdateUser_Click;
        // 
        // listViewRole
        // 
        this.listViewRole.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.listViewRole.Location = new Point(220, 204);
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
        this.cmbWarehouseList.Location = new Point(220, 148);
        this.cmbWarehouseList.Name = "cmbWarehouseList";
        this.cmbWarehouseList.Size = new Size(266, 23);
        this.cmbWarehouseList.TabIndex = 8;
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
        this.label5.Location = new Point(63, 204);
        this.label5.Name = "label5";
        this.label5.Size = new Size(44, 15);
        this.label5.TabIndex = 4;
        this.label5.Text = "Roles : ";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new Point(63, 156);
        this.label4.Name = "label4";
        this.label4.Size = new Size(72, 15);
        this.label4.TabIndex = 3;
        this.label4.Text = "Warehouse :";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(63, 98);
        this.label2.Name = "label2";
        this.label2.Size = new Size(90, 15);
        this.label2.TabIndex = 1;
        this.label2.Text = "New Password :";
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
        // panel2
        // 
        this.panel2.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.panel2.Controls.Add(this.label7);
        this.panel2.Controls.Add(this.textBoxOldRoles);
        this.panel2.Controls.Add(this.label6);
        this.panel2.Controls.Add(this.textBoxUserId);
        this.panel2.Location = new Point(70, 12);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(616, 89);
        this.panel2.TabIndex = 2;
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new Point(128, 50);
        this.label7.Name = "label7";
        this.label7.Size = new Size(44, 15);
        this.label7.TabIndex = 3;
        this.label7.Text = "Roles : ";
        // 
        // textBoxOldRoles
        // 
        this.textBoxOldRoles.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.textBoxOldRoles.Location = new Point(215, 42);
        this.textBoxOldRoles.Name = "textBoxOldRoles";
        this.textBoxOldRoles.ReadOnly = true;
        this.textBoxOldRoles.Size = new Size(271, 23);
        this.textBoxOldRoles.TabIndex = 2;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new Point(128, 21);
        this.label6.Name = "label6";
        this.label6.Size = new Size(52, 15);
        this.label6.TabIndex = 1;
        this.label6.Text = "User Id : ";
        // 
        // textBoxUserId
        // 
        this.textBoxUserId.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.textBoxUserId.Location = new Point(215, 13);
        this.textBoxUserId.Name = "textBoxUserId";
        this.textBoxUserId.ReadOnly = true;
        this.textBoxUserId.Size = new Size(271, 23);
        this.textBoxUserId.TabIndex = 0;
        // 
        // UpdateUserForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(754, 561);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.panel1);
        this.MinimizeBox = false;
        this.Name = "UpdateUserForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Update User - Form";
        this.Load += this.UpdateUserForm_Load;
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Button buttonUpdateUser;
    private ListView listViewRole;
    private ComboBox cmbWarehouseList;
    private TextBox textBoxPassword;
    private TextBox textBoxUserName;
    private Label label5;
    private Label label4;
    private Label label2;
    private Label label1;
    private Panel panel2;
    private Label label6;
    private TextBox textBoxUserId;
    private Label label7;
    private TextBox textBoxOldRoles;
}