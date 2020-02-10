﻿namespace DAQ_Simulator
{
    partial class DAQ_Simulator
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLogging = new System.Windows.Forms.Button();
            this.txtLoggingTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSampling = new System.Windows.Forms.Button();
            this.txtSamplingTime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSensorValues = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLogging);
            this.groupBox2.Controls.Add(this.txtLoggingTime);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(53, 185);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(411, 160);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logging";
            // 
            // btnLogging
            // 
            this.btnLogging.Location = new System.Drawing.Point(88, 97);
            this.btnLogging.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogging.Name = "btnLogging";
            this.btnLogging.Size = new System.Drawing.Size(128, 34);
            this.btnLogging.TabIndex = 4;
            this.btnLogging.Text = "Logging on File";
            this.btnLogging.UseVisualStyleBackColor = true;
            this.btnLogging.Click += new System.EventHandler(this.btnLogging_Click);
            // 
            // txtLoggingTime
            // 
            this.txtLoggingTime.Location = new System.Drawing.Point(145, 36);
            this.txtLoggingTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoggingTime.Name = "txtLoggingTime";
            this.txtLoggingTime.ReadOnly = true;
            this.txtLoggingTime.Size = new System.Drawing.Size(169, 22);
            this.txtLoggingTime.TabIndex = 2;
            this.txtLoggingTime.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Next Logging Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Next Sampling Time";
            // 
            // btnSampling
            // 
            this.btnSampling.Location = new System.Drawing.Point(88, 92);
            this.btnSampling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSampling.Name = "btnSampling";
            this.btnSampling.Size = new System.Drawing.Size(128, 37);
            this.btnSampling.TabIndex = 3;
            this.btnSampling.Text = "Sampling";
            this.btnSampling.UseVisualStyleBackColor = true;
            this.btnSampling.Click += new System.EventHandler(this.btnSampling_Click);
            // 
            // txtSamplingTime
            // 
            this.txtSamplingTime.Location = new System.Drawing.Point(145, 46);
            this.txtSamplingTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSamplingTime.Name = "txtSamplingTime";
            this.txtSamplingTime.ReadOnly = true;
            this.txtSamplingTime.Size = new System.Drawing.Size(169, 22);
            this.txtSamplingTime.TabIndex = 1;
            this.txtSamplingTime.TextChanged += new System.EventHandler(this.txtSamplingTime_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSamplingTime);
            this.groupBox1.Controls.Add(this.btnSampling);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(53, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(411, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sampling";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSensorValues);
            this.groupBox3.Location = new System.Drawing.Point(472, 44);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(251, 302);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sensor Values";
            // 
            // txtSensorValues
            // 
            this.txtSensorValues.Location = new System.Drawing.Point(3, 18);
            this.txtSensorValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSensorValues.Multiline = true;
            this.txtSensorValues.Name = "txtSensorValues";
            this.txtSensorValues.ReadOnly = true;
            this.txtSensorValues.Size = new System.Drawing.Size(229, 277);
            this.txtSensorValues.TabIndex = 0;
            this.txtSensorValues.TextChanged += new System.EventHandler(this.txtSensorValues_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.operationsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(737, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // DAQ_Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 363);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DAQ_Simulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAQ_Simulator";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoggingTime;
        private System.Windows.Forms.Button btnLogging;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSampling;
        private System.Windows.Forms.TextBox txtSamplingTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSensorValues;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}