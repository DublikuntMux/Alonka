﻿using System.ComponentModel;

namespace Alonka;

partial class Popup
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
        this.timer1 = new System.Timers.Timer();
        ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
        this.SuspendLayout();
        // 
        // timer1
        // 
        this.timer1.Enabled = true;
        this.timer1.SynchronizingObject = this;
        this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Tick);
        // 
        // Popup
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(266, 142);
        this.ControlBox = false;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "Popup";
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.Text = "Popup";
        ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Timers.Timer timer1;

    #endregion
}