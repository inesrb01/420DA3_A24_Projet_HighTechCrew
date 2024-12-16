using System;
using System.Drawing;
using System.Windows.Forms;
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
    public WarehouseView() 
    {
        InitializeComponent();
        ConfigureLabels();
    }
    private void ConfigureLabels() {
        label1.Text = "WarehouseName";
        label1.Location = new System.Drawing.Point(30, 50);

        label2.Text = "Address";
        label2.Location = new System.Drawing.Point(30, 100);

        label3.Text = "City";
        label3.Location = new System.Drawing.Point(30, 150);
    }
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private DataGridView dataGridView1;
}       