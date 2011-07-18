namespace FirstFlushPipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabDimension = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDiameter = new System.Windows.Forms.TabPage();
            this.tabLength = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textHouseLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textHouseWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textVolDiverted = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkDiameter = new System.Windows.Forms.LinkLabel();
            this.linkLength = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPipeDiameter = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textPipeLength = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPipeLength = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textPipeDiameter = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tab1.SuspendLayout();
            this.tabDimension.SuspendLayout();
            this.tabDiameter.SuspendLayout();
            this.tabLength.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabDimension);
            this.tab1.Controls.Add(this.tabDiameter);
            this.tab1.Controls.Add(this.tabLength);
            this.tab1.Location = new System.Drawing.Point(16, 15);
            this.tab1.Margin = new System.Windows.Forms.Padding(4);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(473, 308);
            this.tab1.TabIndex = 0;
            // 
            // tabDimension
            // 
            this.tabDimension.Controls.Add(this.buttonReset);
            this.tabDimension.Controls.Add(this.linkLength);
            this.tabDimension.Controls.Add(this.linkDiameter);
            this.tabDimension.Controls.Add(this.label7);
            this.tabDimension.Controls.Add(this.textVolDiverted);
            this.tabDimension.Controls.Add(this.label5);
            this.tabDimension.Controls.Add(this.label3);
            this.tabDimension.Controls.Add(this.textHouseWidth);
            this.tabDimension.Controls.Add(this.label4);
            this.tabDimension.Controls.Add(this.label2);
            this.tabDimension.Controls.Add(this.textHouseLength);
            this.tabDimension.Controls.Add(this.label1);
            this.tabDimension.Location = new System.Drawing.Point(4, 25);
            this.tabDimension.Margin = new System.Windows.Forms.Padding(4);
            this.tabDimension.Name = "tabDimension";
            this.tabDimension.Padding = new System.Windows.Forms.Padding(4);
            this.tabDimension.Size = new System.Drawing.Size(465, 279);
            this.tabDimension.TabIndex = 0;
            this.tabDimension.Text = "Dimension";
            this.tabDimension.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length of House";
            // 
            // tabDiameter
            // 
            this.tabDiameter.Controls.Add(this.label6);
            this.tabDiameter.Controls.Add(this.labelPipeDiameter);
            this.tabDiameter.Controls.Add(this.label9);
            this.tabDiameter.Controls.Add(this.label10);
            this.tabDiameter.Controls.Add(this.textPipeLength);
            this.tabDiameter.Controls.Add(this.label11);
            this.tabDiameter.Location = new System.Drawing.Point(4, 25);
            this.tabDiameter.Margin = new System.Windows.Forms.Padding(4);
            this.tabDiameter.Name = "tabDiameter";
            this.tabDiameter.Padding = new System.Windows.Forms.Padding(4);
            this.tabDiameter.Size = new System.Drawing.Size(465, 279);
            this.tabDiameter.TabIndex = 1;
            this.tabDiameter.Text = "Diameter";
            this.tabDiameter.UseVisualStyleBackColor = true;
            // 
            // tabLength
            // 
            this.tabLength.Controls.Add(this.label8);
            this.tabLength.Controls.Add(this.labelPipeLength);
            this.tabLength.Controls.Add(this.label13);
            this.tabLength.Controls.Add(this.label14);
            this.tabLength.Controls.Add(this.textPipeDiameter);
            this.tabLength.Controls.Add(this.label15);
            this.tabLength.Location = new System.Drawing.Point(4, 25);
            this.tabLength.Margin = new System.Windows.Forms.Padding(4);
            this.tabLength.Name = "tabLength";
            this.tabLength.Padding = new System.Windows.Forms.Padding(4);
            this.tabLength.Size = new System.Drawing.Size(465, 279);
            this.tabLength.TabIndex = 2;
            this.tabLength.Text = "Length";
            this.tabLength.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(16, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 97);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 85);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textHouseLength
            // 
            this.textHouseLength.Location = new System.Drawing.Point(180, 32);
            this.textHouseLength.Name = "textHouseLength";
            this.textHouseLength.Size = new System.Drawing.Size(100, 27);
            this.textHouseLength.TabIndex = 1;
            this.textHouseLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textHouseLength.TextChanged += new System.EventHandler(this.textHouseLength_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "meters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "meters";
            // 
            // textHouseWidth
            // 
            this.textHouseWidth.Location = new System.Drawing.Point(180, 74);
            this.textHouseWidth.Name = "textHouseWidth";
            this.textHouseWidth.Size = new System.Drawing.Size(100, 27);
            this.textHouseWidth.TabIndex = 4;
            this.textHouseWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textHouseWidth.TextChanged += new System.EventHandler(this.textHouseWidth_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Width of House";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Volume Diverted";
            // 
            // textVolDiverted
            // 
            this.textVolDiverted.AutoSize = true;
            this.textVolDiverted.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVolDiverted.Location = new System.Drawing.Point(180, 121);
            this.textVolDiverted.Name = "textVolDiverted";
            this.textVolDiverted.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textVolDiverted.Size = new System.Drawing.Size(48, 20);
            this.textVolDiverted.TabIndex = 7;
            this.textVolDiverted.Text = "0.00";
            this.textVolDiverted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(177, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "cubic meters (m3)";
            // 
            // linkDiameter
            // 
            this.linkDiameter.AutoSize = true;
            this.linkDiameter.Location = new System.Drawing.Point(33, 178);
            this.linkDiameter.Name = "linkDiameter";
            this.linkDiameter.Size = new System.Drawing.Size(294, 16);
            this.linkDiameter.TabIndex = 9;
            this.linkDiameter.TabStop = true;
            this.linkDiameter.Text = "Length of pipe known - what is the diameter?";
            this.linkDiameter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDiameter_LinkClicked);
            // 
            // linkLength
            // 
            this.linkLength.AutoSize = true;
            this.linkLength.Location = new System.Drawing.Point(33, 219);
            this.linkLength.Name = "linkLength";
            this.linkLength.Size = new System.Drawing.Size(293, 16);
            this.linkLength.TabIndex = 10;
            this.linkLength.TabStop = true;
            this.linkLength.Text = "Diameter of pipe known - what is the length?";
            this.linkLength.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLength_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "in milimeters (mm)";
            // 
            // labelPipeDiameter
            // 
            this.labelPipeDiameter.AutoSize = true;
            this.labelPipeDiameter.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPipeDiameter.Location = new System.Drawing.Point(255, 87);
            this.labelPipeDiameter.Name = "labelPipeDiameter";
            this.labelPipeDiameter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelPipeDiameter.Size = new System.Drawing.Size(48, 20);
            this.labelPipeDiameter.TabIndex = 13;
            this.labelPipeDiameter.Text = "0.00";
            this.labelPipeDiameter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Diameter of First Flush Pipe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(375, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "meters";
            // 
            // textPipeLength
            // 
            this.textPipeLength.Location = new System.Drawing.Point(255, 40);
            this.textPipeLength.Name = "textPipeLength";
            this.textPipeLength.Size = new System.Drawing.Size(100, 27);
            this.textPipeLength.TabIndex = 10;
            this.textPipeLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textPipeLength.TextChanged += new System.EventHandler(this.textPipeLength_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Length of Pipe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(240, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "in milimeters (mm)";
            // 
            // labelPipeLength
            // 
            this.labelPipeLength.AutoSize = true;
            this.labelPipeLength.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPipeLength.Location = new System.Drawing.Point(243, 83);
            this.labelPipeLength.Name = "labelPipeLength";
            this.labelPipeLength.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelPipeLength.Size = new System.Drawing.Size(48, 20);
            this.labelPipeLength.TabIndex = 19;
            this.labelPipeLength.Text = "0.00";
            this.labelPipeLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "Length of First Flush Pipe";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(343, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "milimeters (mm)";
            // 
            // textPipeDiameter
            // 
            this.textPipeDiameter.Location = new System.Drawing.Point(243, 36);
            this.textPipeDiameter.Name = "textPipeDiameter";
            this.textPipeDiameter.Size = new System.Drawing.Size(100, 27);
            this.textPipeDiameter.TabIndex = 16;
            this.textPipeDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textPipeDiameter.TextChanged += new System.EventHandler(this.textPipeDiameter_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Diameter of Pipe";
            // 
            // buttonReset
            // 
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset.Location = new System.Drawing.Point(387, 250);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(71, 22);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tab1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "First Flush Pipe Dimension Calculation - WSP, SOPAC, SPC";
            this.tab1.ResumeLayout(false);
            this.tabDimension.ResumeLayout(false);
            this.tabDimension.PerformLayout();
            this.tabDiameter.ResumeLayout(false);
            this.tabDiameter.PerformLayout();
            this.tabLength.ResumeLayout(false);
            this.tabLength.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabDimension;
        private System.Windows.Forms.TabPage tabDiameter;
        private System.Windows.Forms.TabPage tabLength;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label textVolDiverted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textHouseWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textHouseLength;
        private System.Windows.Forms.LinkLabel linkLength;
        private System.Windows.Forms.LinkLabel linkDiameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPipeDiameter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textPipeLength;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPipeLength;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textPipeDiameter;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonReset;
    }
}

