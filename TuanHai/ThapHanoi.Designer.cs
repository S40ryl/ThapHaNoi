﻿
namespace TuanHai
{
    partial class ThapHanoi
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
            this.picTreeA = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picTreeB = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picTreeC = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.lblStep = new System.Windows.Forms.Label();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // picTreeA
            // 
            this.picTreeA.Image = global::TuanHai.Properties.Resources.tree;
            this.picTreeA.Location = new System.Drawing.Point(33, 299);
            this.picTreeA.Name = "picTreeA";
            this.picTreeA.Size = new System.Drawing.Size(300, 333);
            this.picTreeA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTreeA.TabIndex = 0;
            this.picTreeA.TabStop = false;
            this.picTreeA.Click += new System.EventHandler(this.picTreeA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 635);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            // 
            // picTreeB
            // 
            this.picTreeB.Image = global::TuanHai.Properties.Resources.tree;
            this.picTreeB.Location = new System.Drawing.Point(368, 299);
            this.picTreeB.Name = "picTreeB";
            this.picTreeB.Size = new System.Drawing.Size(300, 333);
            this.picTreeB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTreeB.TabIndex = 2;
            this.picTreeB.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(844, 635);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "C";
            // 
            // picTreeC
            // 
            this.picTreeC.Image = global::TuanHai.Properties.Resources.tree;
            this.picTreeC.Location = new System.Drawing.Point(713, 299);
            this.picTreeC.Name = "picTreeC";
            this.picTreeC.Size = new System.Drawing.Size(300, 333);
            this.picTreeC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTreeC.TabIndex = 4;
            this.picTreeC.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Image = global::TuanHai.Properties.Resources.pieace1;
            this.pic1.Location = new System.Drawing.Point(162, 584);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(42, 30);
            this.pic1.TabIndex = 6;
            this.pic1.TabStop = false;
            this.pic1.Tag = "1";
            this.pic1.Visible = false;
            this.pic1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pic2
            // 
            this.pic2.Image = global::TuanHai.Properties.Resources.pieace2;
            this.pic2.Location = new System.Drawing.Point(488, 584);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(58, 30);
            this.pic2.TabIndex = 7;
            this.pic2.TabStop = false;
            this.pic2.Tag = "2";
            this.pic2.Visible = false;
            // 
            // pic8
            // 
            this.pic8.Image = global::TuanHai.Properties.Resources.pieace7;
            this.pic8.Location = new System.Drawing.Point(713, 584);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(302, 30);
            this.pic8.TabIndex = 8;
            this.pic8.TabStop = false;
            this.pic8.Tag = "8";
            this.pic8.Visible = false;
            // 
            // pic7
            // 
            this.pic7.Image = global::TuanHai.Properties.Resources.pieace7;
            this.pic7.Location = new System.Drawing.Point(732, 556);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(263, 30);
            this.pic7.TabIndex = 9;
            this.pic7.TabStop = false;
            this.pic7.Tag = "7";
            this.pic7.Visible = false;
            // 
            // pic6
            // 
            this.pic6.Image = global::TuanHai.Properties.Resources.pieace6;
            this.pic6.Location = new System.Drawing.Point(758, 528);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(211, 30);
            this.pic6.TabIndex = 10;
            this.pic6.TabStop = false;
            this.pic6.Tag = "6";
            this.pic6.Visible = false;
            // 
            // pic5
            // 
            this.pic5.Image = global::TuanHai.Properties.Resources.pieace5;
            this.pic5.Location = new System.Drawing.Point(785, 499);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(157, 30);
            this.pic5.TabIndex = 11;
            this.pic5.TabStop = false;
            this.pic5.Tag = "5";
            this.pic5.Visible = false;
            // 
            // pic4
            // 
            this.pic4.Image = global::TuanHai.Properties.Resources.pieace4;
            this.pic4.Location = new System.Drawing.Point(802, 469);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(122, 30);
            this.pic4.TabIndex = 12;
            this.pic4.TabStop = false;
            this.pic4.Tag = "4";
            this.pic4.Visible = false;
            // 
            // pic3
            // 
            this.pic3.Image = global::TuanHai.Properties.Resources.pieace3;
            this.pic3.Location = new System.Drawing.Point(820, 439);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(86, 30);
            this.pic3.TabIndex = 13;
            this.pic3.TabStop = false;
            this.pic3.Tag = "3";
            this.pic3.Visible = false;
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep.Location = new System.Drawing.Point(536, 57);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(107, 25);
            this.lblStep.TabIndex = 14;
            this.lblStep.Text = "So buoc: 0";
            this.lblStep.Click += new System.EventHandler(this.lblStep_Click);
            // 
            // nudLevel
            // 
            this.nudLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevel.Location = new System.Drawing.Point(475, 52);
            this.nudLevel.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudLevel.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(40, 30);
            this.nudLevel.TabIndex = 15;
            this.nudLevel.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "So dia";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(394, 102);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 17;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThapHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1058, 669);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudLevel);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic8);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picTreeC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picTreeB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picTreeA);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ThapHanoi";
            this.Text = "Thap Ha Noi";
            this.Load += new System.EventHandler(this.ThapHanoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTreeA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTreeA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picTreeB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picTreeC;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRun;
    }
}

