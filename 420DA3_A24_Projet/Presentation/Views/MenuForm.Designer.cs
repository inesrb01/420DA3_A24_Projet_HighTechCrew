namespace _420DA3_A24_Projet.Presentation.Views.Forms;

partial class MenuForm {
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
        this.menuStrip1 = new MenuStrip();
        this.userManageToolStripMenuItem = new ToolStripMenuItem();
        this.listUsersToolStripMenuItem = new ToolStripMenuItem();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // menuStrip1
        // 
        this.menuStrip1.ImageScalingSize = new Size(19, 19);
        this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.userManageToolStripMenuItem });
        this.menuStrip1.Location = new Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Padding = new Padding(7, 3, 0, 3);
        this.menuStrip1.Size = new Size(914, 30);
        this.menuStrip1.TabIndex = 1;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // userManageToolStripMenuItem
        // 
        this.userManageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.listUsersToolStripMenuItem });
        this.userManageToolStripMenuItem.Name = "userManageToolStripMenuItem";
        this.userManageToolStripMenuItem.Size = new Size(110, 24);
        this.userManageToolStripMenuItem.Text = "User Manage";
        // 
        // listUsersToolStripMenuItem
        // 
        this.listUsersToolStripMenuItem.Name = "listUsersToolStripMenuItem";
        this.listUsersToolStripMenuItem.Size = new Size(152, 26);
        this.listUsersToolStripMenuItem.Text = "List Users";
        this.listUsersToolStripMenuItem.Click += this.listUsersToolStripMenuItem_Click;
        // 
        // MenuForm
        // 
        this.AutoScaleDimensions = new SizeF(8F, 19F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(914, 570);
        this.Controls.Add(this.menuStrip1);
        this.IsMdiContainer = true;
        this.MainMenuStrip = this.menuStrip1;
        this.Margin = new Padding(3, 4, 3, 4);
        this.Name = "MenuForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Menu - Form";
        this.WindowState = FormWindowState.Maximized;
        this.Load += this.MenuForm_Load;
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem userManageToolStripMenuItem;
    private ToolStripMenuItem listUsersToolStripMenuItem;
}