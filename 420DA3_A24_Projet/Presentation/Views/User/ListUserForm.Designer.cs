namespace _420DA3_A24_Projet.Presentation.Views.Forms.User;

partial class ListUserForm {
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
        this.dgvUsers = new DataGridView();
        this.buttonClose = new Button();
        this.buttonNewUser = new Button();
        this.buttonEditUser = new Button();
        this.panel1 = new Panel();
        this.buttonSearch = new Button();
        this.textBoxSearchUserName = new TextBox();
        this.label1 = new Label();
        this.buttonDeleteUser = new Button();
        ((System.ComponentModel.ISupportInitialize) this.dgvUsers).BeginInit();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // dgvUsers
        // 
        this.dgvUsers.AllowUserToAddRows = false;
        this.dgvUsers.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvUsers.Location = new Point(40, 120);
        this.dgvUsers.MultiSelect = false;
        this.dgvUsers.Name = "dgvUsers";
        this.dgvUsers.ReadOnly = true;
        this.dgvUsers.Size = new Size(758, 320);
        this.dgvUsers.TabIndex = 0;
        // 
        // buttonClose
        // 
        this.buttonClose.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.buttonClose.Location = new Point(723, 474);
        this.buttonClose.Name = "buttonClose";
        this.buttonClose.Size = new Size(75, 23);
        this.buttonClose.TabIndex = 1;
        this.buttonClose.Text = "Close";
        this.buttonClose.UseVisualStyleBackColor = true;
        this.buttonClose.Click += this.ButtonClose_Click;
        // 
        // buttonNewUser
        // 
        this.buttonNewUser.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
        this.buttonNewUser.Location = new Point(40, 474);
        this.buttonNewUser.Name = "buttonNewUser";
        this.buttonNewUser.Size = new Size(75, 23);
        this.buttonNewUser.TabIndex = 2;
        this.buttonNewUser.Text = "New User";
        this.buttonNewUser.UseVisualStyleBackColor = true;
        this.buttonNewUser.Click += this.ButtonNewUser_Click;
        // 
        // buttonEditUser
        // 
        this.buttonEditUser.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
        this.buttonEditUser.Location = new Point(138, 474);
        this.buttonEditUser.Name = "buttonEditUser";
        this.buttonEditUser.Size = new Size(162, 23);
        this.buttonEditUser.TabIndex = 3;
        this.buttonEditUser.Text = "Edit/Roles Selected User";
        this.buttonEditUser.UseVisualStyleBackColor = true;
        this.buttonEditUser.Click += this.ButtonEditUser_Click;
        // 
        // panel1
        // 
        this.panel1.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.panel1.Controls.Add(this.buttonSearch);
        this.panel1.Controls.Add(this.textBoxSearchUserName);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Location = new Point(41, 12);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(757, 76);
        this.panel1.TabIndex = 4;
        // 
        // buttonSearch
        // 
        this.buttonSearch.Location = new Point(524, 23);
        this.buttonSearch.Name = "buttonSearch";
        this.buttonSearch.Size = new Size(117, 24);
        this.buttonSearch.TabIndex = 2;
        this.buttonSearch.Text = "Search";
        this.buttonSearch.UseVisualStyleBackColor = true;
        this.buttonSearch.Click += this.ButtonSearch_Click;
        // 
        // textBoxSearchUserName
        // 
        this.textBoxSearchUserName.Location = new Point(190, 24);
        this.textBoxSearchUserName.Name = "textBoxSearchUserName";
        this.textBoxSearchUserName.Size = new Size(316, 23);
        this.textBoxSearchUserName.TabIndex = 1;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(22, 26);
        this.label1.Name = "label1";
        this.label1.Size = new Size(125, 15);
        this.label1.TabIndex = 0;
        this.label1.Text = "Search By UserName : ";
        // 
        // buttonDeleteUser
        // 
        this.buttonDeleteUser.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
        this.buttonDeleteUser.Location = new Point(318, 474);
        this.buttonDeleteUser.Name = "buttonDeleteUser";
        this.buttonDeleteUser.Size = new Size(156, 23);
        this.buttonDeleteUser.TabIndex = 5;
        this.buttonDeleteUser.Text = "Delete Selected User";
        this.buttonDeleteUser.UseVisualStyleBackColor = true;
        this.buttonDeleteUser.Click += this.ButtonDeleteUser_Click;
        // 
        // ListUserForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(841, 518);
        this.Controls.Add(this.buttonDeleteUser);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.buttonEditUser);
        this.Controls.Add(this.buttonNewUser);
        this.Controls.Add(this.buttonClose);
        this.Controls.Add(this.dgvUsers);
        this.Name = "ListUserForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "List Users - Form";
        this.WindowState = FormWindowState.Maximized;
        this.Load += this.ListUserForm_Load;
        ((System.ComponentModel.ISupportInitialize) this.dgvUsers).EndInit();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private DataGridView dgvUsers;
    private Button buttonClose;
    private Button buttonNewUser;
    private Button buttonEditUser;
    private Panel panel1;
    private Button buttonSearch;
    private TextBox textBoxSearchUserName;
    private Label label1;
    private Button buttonDeleteUser;
}