﻿namespace _420DA3_A24_Projet;

partial class PasswordHasherWindow {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.clearPasswordTextBox = new TextBox();
        this.convertButton = new Button();
        this.phHashTextBox = new TextBox();
        this.quitButton = new Button();
        this.SuspendLayout();
        // 
        // clearPasswordTextBox
        // 
        this.clearPasswordTextBox.Location = new Point(35, 63);
        this.clearPasswordTextBox.Name = "clearPasswordTextBox";
        this.clearPasswordTextBox.PlaceholderText = "Mot de passe à encrypter";
        this.clearPasswordTextBox.Size = new Size(210, 25);
        this.clearPasswordTextBox.TabIndex = 0;
        this.clearPasswordTextBox.TextChanged += this.clearPasswordTextBox_TextChanged;
        // 
        // convertButton
        // 
        this.convertButton.Location = new Point(35, 96);
        this.convertButton.Name = "convertButton";
        this.convertButton.Size = new Size(210, 26);
        this.convertButton.TabIndex = 1;
        this.convertButton.Text = "Hash!";
        this.convertButton.UseVisualStyleBackColor = true;
        this.convertButton.Click += this.ConvertButton_Click;
        // 
        // phHashTextBox
        // 
        this.phHashTextBox.Location = new Point(35, 165);
        this.phHashTextBox.Name = "phHashTextBox";
        this.phHashTextBox.PlaceholderText = "Mot de passe encrypté";
        this.phHashTextBox.ReadOnly = true;
        this.phHashTextBox.Size = new Size(210, 25);
        this.phHashTextBox.TabIndex = 2;
        // 
        // quitButton
        // 
        this.quitButton.Location = new Point(35, 235);
        this.quitButton.Name = "quitButton";
        this.quitButton.Size = new Size(210, 26);
        this.quitButton.TabIndex = 3;
        this.quitButton.Text = "Quitter";
        this.quitButton.UseVisualStyleBackColor = true;
        this.quitButton.Click += this.QuitButton_Click;
        // 
        // PasswordHasherWindow
        // 
        this.AutoScaleDimensions = new SizeF(7F, 17F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(284, 296);
        this.Controls.Add(this.quitButton);
        this.Controls.Add(this.phHashTextBox);
        this.Controls.Add(this.convertButton);
        this.Controls.Add(this.clearPasswordTextBox);
        this.Name = "PasswordHasherWindow";
        this.Text = "Form1";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private TextBox clearPasswordTextBox;
    private Button convertButton;
    private TextBox phHashTextBox;
    private Button quitButton;
}
