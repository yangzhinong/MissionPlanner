﻿namespace MissionPlanner.Swarm.SRB
{
    partial class Control
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
            this.but_start = new MissionPlanner.Controls.MyButton();
            this.but_z = new MissionPlanner.Controls.MyButton();
            this.but_land = new MissionPlanner.Controls.MyButton();
            this.but_stop = new MissionPlanner.Controls.MyButton();
            this.num_TakeOffAlt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_minoffset = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.num_maxoffset = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_TakeOffAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_minoffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_maxoffset)).BeginInit();
            this.SuspendLayout();
            // 
            // but_start
            // 
            this.but_start.Location = new System.Drawing.Point(13, 13);
            this.but_start.Name = "but_start";
            this.but_start.Size = new System.Drawing.Size(75, 23);
            this.but_start.TabIndex = 0;
            this.but_start.Text = "Start";
            this.but_start.UseVisualStyleBackColor = true;
            this.but_start.Click += new System.EventHandler(this.but_start_Click);
            // 
            // but_z
            // 
            this.but_z.Location = new System.Drawing.Point(94, 13);
            this.but_z.Name = "but_z";
            this.but_z.Size = new System.Drawing.Size(75, 23);
            this.but_z.TabIndex = 1;
            this.but_z.Text = "Start Z";
            this.but_z.UseVisualStyleBackColor = true;
            this.but_z.Click += new System.EventHandler(this.but_z_Click);
            // 
            // but_land
            // 
            this.but_land.Location = new System.Drawing.Point(175, 13);
            this.but_land.Name = "but_land";
            this.but_land.Size = new System.Drawing.Size(75, 23);
            this.but_land.TabIndex = 2;
            this.but_land.Text = "Start Land";
            this.but_land.UseVisualStyleBackColor = true;
            this.but_land.Click += new System.EventHandler(this.but_land_Click);
            // 
            // but_stop
            // 
            this.but_stop.Location = new System.Drawing.Point(13, 42);
            this.but_stop.Name = "but_stop";
            this.but_stop.Size = new System.Drawing.Size(75, 23);
            this.but_stop.TabIndex = 3;
            this.but_stop.Text = "Stop";
            this.but_stop.UseVisualStyleBackColor = true;
            this.but_stop.Click += new System.EventHandler(this.but_stop_Click);
            // 
            // num_TakeOffAlt
            // 
            this.num_TakeOffAlt.Location = new System.Drawing.Point(94, 88);
            this.num_TakeOffAlt.Name = "num_TakeOffAlt";
            this.num_TakeOffAlt.Size = new System.Drawing.Size(60, 20);
            this.num_TakeOffAlt.TabIndex = 4;
            this.num_TakeOffAlt.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TakeOffAlt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "MinOffset";
            // 
            // num_minoffset
            // 
            this.num_minoffset.Location = new System.Drawing.Point(94, 114);
            this.num_minoffset.Name = "num_minoffset";
            this.num_minoffset.Size = new System.Drawing.Size(60, 20);
            this.num_minoffset.TabIndex = 6;
            this.num_minoffset.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "MaxOffset";
            // 
            // num_maxoffset
            // 
            this.num_maxoffset.Location = new System.Drawing.Point(94, 140);
            this.num_maxoffset.Name = "num_maxoffset";
            this.num_maxoffset.Size = new System.Drawing.Size(60, 20);
            this.num_maxoffset.TabIndex = 8;
            this.num_maxoffset.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_maxoffset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_minoffset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_TakeOffAlt);
            this.Controls.Add(this.but_stop);
            this.Controls.Add(this.but_land);
            this.Controls.Add(this.but_z);
            this.Controls.Add(this.but_start);
            this.Name = "Control";
            this.Text = "Control";
            ((System.ComponentModel.ISupportInitialize)(this.num_TakeOffAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_minoffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_maxoffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MyButton but_start;
        private Controls.MyButton but_z;
        private Controls.MyButton but_land;
        private Controls.MyButton but_stop;
        private System.Windows.Forms.NumericUpDown num_TakeOffAlt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_minoffset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_maxoffset;
    }
}