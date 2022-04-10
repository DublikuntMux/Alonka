namespace Alonka
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.bsod = new System.Windows.Forms.Button();
            this.RegFuck = new System.Windows.Forms.Button();
            this.DelMBR = new System.Windows.Forms.Button();
            this.TrashDestop = new System.Windows.Forms.Button();
            this.CrabGame = new System.Windows.Forms.Button();
            this.GDIPyloads = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bsod
            // 
            this.bsod.Location = new System.Drawing.Point(12, 57);
            this.bsod.Name = "bsod";
            this.bsod.Size = new System.Drawing.Size(258, 64);
            this.bsod.TabIndex = 0;
            this.bsod.Text = "BSOD";
            this.bsod.UseVisualStyleBackColor = true;
            this.bsod.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegFuck
            // 
            this.RegFuck.Location = new System.Drawing.Point(12, 127);
            this.RegFuck.Name = "RegFuck";
            this.RegFuck.Size = new System.Drawing.Size(258, 64);
            this.RegFuck.TabIndex = 1;
            this.RegFuck.Text = "Deleting registry";
            this.RegFuck.UseVisualStyleBackColor = true;
            this.RegFuck.Click += new System.EventHandler(this.button2_Click);
            // 
            // DelMBR
            // 
            this.DelMBR.Location = new System.Drawing.Point(12, 197);
            this.DelMBR.Name = "DelMBR";
            this.DelMBR.Size = new System.Drawing.Size(258, 64);
            this.DelMBR.TabIndex = 2;
            this.DelMBR.Text = "Deleting MBR";
            this.DelMBR.UseVisualStyleBackColor = true;
            this.DelMBR.Click += new System.EventHandler(this.button3_Click);
            // 
            // TrashDestop
            // 
            this.TrashDestop.Location = new System.Drawing.Point(12, 267);
            this.TrashDestop.Name = "TrashDestop";
            this.TrashDestop.Size = new System.Drawing.Size(258, 64);
            this.TrashDestop.TabIndex = 3;
            this.TrashDestop.Text = "Trash destop";
            this.TrashDestop.UseVisualStyleBackColor = true;
            this.TrashDestop.Click += new System.EventHandler(this.button4_Click);
            // 
            // CrabGame
            // 
            this.CrabGame.Location = new System.Drawing.Point(12, 337);
            this.CrabGame.Name = "CrabGame";
            this.CrabGame.Size = new System.Drawing.Size(258, 64);
            this.CrabGame.TabIndex = 4;
            this.CrabGame.Text = "Crab game";
            this.CrabGame.UseVisualStyleBackColor = true;
            this.CrabGame.Click += new System.EventHandler(this.button5_Click);
            // 
            // GDIPyloads
            // 
            this.GDIPyloads.Location = new System.Drawing.Point(12, 407);
            this.GDIPyloads.Name = "GDIPyloads";
            this.GDIPyloads.Size = new System.Drawing.Size(258, 64);
            this.GDIPyloads.TabIndex = 5;
            this.GDIPyloads.Text = "Effects";
            this.GDIPyloads.UseVisualStyleBackColor = true;
            this.GDIPyloads.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 558);
            this.Controls.Add(this.GDIPyloads);
            this.Controls.Add(this.CrabGame);
            this.Controls.Add(this.TrashDestop);
            this.Controls.Add(this.DelMBR);
            this.Controls.Add(this.RegFuck);
            this.Controls.Add(this.bsod);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Alenka tool";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bsod;
        private System.Windows.Forms.Button RegFuck;
        private System.Windows.Forms.Button DelMBR;
        private System.Windows.Forms.Button TrashDestop;
        private System.Windows.Forms.Button CrabGame;
        private System.Windows.Forms.Button GDIPyloads;

        #endregion
    }
}