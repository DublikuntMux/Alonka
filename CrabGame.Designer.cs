using System.ComponentModel;

namespace Alonka;

partial class CrabGame
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.button5 = new System.Windows.Forms.Button();
        this.button6 = new System.Windows.Forms.Button();
        this.button3 = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.button1.Location = new System.Drawing.Point(4, 105);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(150, 150);
        this.button1.TabIndex = 0;
        this.button1.Text = "1";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.button2.Location = new System.Drawing.Point(160, 105);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(150, 150);
        this.button2.TabIndex = 1;
        this.button2.Text = "2";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // button5
        // 
        this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.button5.Location = new System.Drawing.Point(316, 105);
        this.button5.Name = "button5";
        this.button5.Size = new System.Drawing.Size(150, 150);
        this.button5.TabIndex = 2;
        this.button5.Text = "3";
        this.button5.UseVisualStyleBackColor = true;
        this.button5.Click += new System.EventHandler(this.button3_Click);
        // 
        // button6
        // 
        this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.button6.Location = new System.Drawing.Point(472, 105);
        this.button6.Name = "button6";
        this.button6.Size = new System.Drawing.Size(150, 150);
        this.button6.TabIndex = 3;
        this.button6.Text = "4";
        this.button6.UseVisualStyleBackColor = true;
        this.button6.Click += new System.EventHandler(this.button4_Click);
        // 
        // button3
        // 
        this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.button3.Location = new System.Drawing.Point(628, 105);
        this.button3.Name = "button3";
        this.button3.Size = new System.Drawing.Size(150, 150);
        this.button3.TabIndex = 4;
        this.button3.Text = "5";
        this.button3.UseVisualStyleBackColor = true;
        this.button3.Click += new System.EventHandler(this.button5_Click);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.label1.Location = new System.Drawing.Point(160, 26);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(444, 76);
        this.label1.TabIndex = 5;
        this.label1.Text = "Select Button";
        // 
        // CrabGame
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(782, 358);
        this.ControlBox = false;
        this.Controls.Add(this.label1);
        this.Controls.Add(this.button3);
        this.Controls.Add(this.button6);
        this.Controls.Add(this.button5);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "CrabGame";
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "CrabGame";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;

    #endregion
}