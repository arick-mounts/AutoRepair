namespace Project_5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.oilChange = new System.Windows.Forms.CheckBox();
            this.lubeJob = new System.Windows.Forms.CheckBox();
            this.transmissionFlush = new System.Windows.Forms.CheckBox();
            this.radiatorFlush = new System.Windows.Forms.CheckBox();
            this.tireRotation = new System.Windows.Forms.CheckBox();
            this.inspection = new System.Windows.Forms.CheckBox();
            this.replaceMuffler = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SandLText = new System.Windows.Forms.TextBox();
            this.partsText = new System.Windows.Forms.TextBox();
            this.TaxText = new System.Windows.Forms.TextBox();
            this.feesText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.partsNum = new System.Windows.Forms.NumericUpDown();
            this.laborNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborNum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lubeJob);
            this.groupBox1.Controls.Add(this.oilChange);
            this.groupBox1.Location = new System.Drawing.Point(69, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.transmissionFlush);
            this.groupBox2.Controls.Add(this.radiatorFlush);
            this.groupBox2.Location = new System.Drawing.Point(314, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.replaceMuffler);
            this.groupBox3.Controls.Add(this.tireRotation);
            this.groupBox3.Controls.Add(this.inspection);
            this.groupBox3.Location = new System.Drawing.Point(69, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 136);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.laborNum);
            this.groupBox4.Controls.Add(this.partsNum);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(314, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 136);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.feesText);
            this.groupBox5.Controls.Add(this.TaxText);
            this.groupBox5.Controls.Add(this.partsText);
            this.groupBox5.Controls.Add(this.SandLText);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(69, 321);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(452, 166);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // oilChange
            // 
            this.oilChange.AutoSize = true;
            this.oilChange.Location = new System.Drawing.Point(34, 43);
            this.oilChange.Name = "oilChange";
            this.oilChange.Size = new System.Drawing.Size(120, 17);
            this.oilChange.TabIndex = 0;
            this.oilChange.Text = "Oil Change ($26.00)";
            this.oilChange.UseVisualStyleBackColor = true;
            // 
            // lubeJob
            // 
            this.lubeJob.AutoSize = true;
            this.lubeJob.Location = new System.Drawing.Point(34, 81);
            this.lubeJob.Name = "lubeJob";
            this.lubeJob.Size = new System.Drawing.Size(112, 17);
            this.lubeJob.TabIndex = 1;
            this.lubeJob.Text = "Lube Job ($18.00)";
            this.lubeJob.UseVisualStyleBackColor = true;
            this.lubeJob.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // transmissionFlush
            // 
            this.transmissionFlush.AutoSize = true;
            this.transmissionFlush.Location = new System.Drawing.Point(44, 79);
            this.transmissionFlush.Name = "transmissionFlush";
            this.transmissionFlush.Size = new System.Drawing.Size(157, 17);
            this.transmissionFlush.TabIndex = 3;
            this.transmissionFlush.Text = "Transmission Flush ($80.00)";
            this.transmissionFlush.UseVisualStyleBackColor = true;
            // 
            // radiatorFlush
            // 
            this.radiatorFlush.AutoSize = true;
            this.radiatorFlush.Location = new System.Drawing.Point(44, 41);
            this.radiatorFlush.Name = "radiatorFlush";
            this.radiatorFlush.Size = new System.Drawing.Size(133, 17);
            this.radiatorFlush.TabIndex = 2;
            this.radiatorFlush.Text = "Radiator Flush($30.00)";
            this.radiatorFlush.UseVisualStyleBackColor = true;
            // 
            // tireRotation
            // 
            this.tireRotation.AutoSize = true;
            this.tireRotation.Location = new System.Drawing.Point(42, 87);
            this.tireRotation.Name = "tireRotation";
            this.tireRotation.Size = new System.Drawing.Size(129, 17);
            this.tireRotation.TabIndex = 3;
            this.tireRotation.Text = "Tire Rotation ($20.00)";
            this.tireRotation.UseVisualStyleBackColor = true;
            this.tireRotation.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // inspection
            // 
            this.inspection.AutoSize = true;
            this.inspection.Location = new System.Drawing.Point(42, 41);
            this.inspection.Name = "inspection";
            this.inspection.Size = new System.Drawing.Size(114, 17);
            this.inspection.TabIndex = 2;
            this.inspection.Text = "Inspection($15.00)";
            this.inspection.UseVisualStyleBackColor = true;
            // 
            // replaceMuffler
            // 
            this.replaceMuffler.AutoSize = true;
            this.replaceMuffler.Location = new System.Drawing.Point(42, 64);
            this.replaceMuffler.Name = "replaceMuffler";
            this.replaceMuffler.Size = new System.Drawing.Size(149, 17);
            this.replaceMuffler.TabIndex = 4;
            this.replaceMuffler.Text = "Replace Muffler ($100.00)";
            this.replaceMuffler.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Labor ($)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Service and Labor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tax (on parts)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Fees";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SandLText
            // 
            this.SandLText.Location = new System.Drawing.Point(149, 30);
            this.SandLText.Name = "SandLText";
            this.SandLText.ReadOnly = true;
            this.SandLText.Size = new System.Drawing.Size(134, 20);
            this.SandLText.TabIndex = 4;
            this.SandLText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // partsText
            // 
            this.partsText.Location = new System.Drawing.Point(149, 59);
            this.partsText.Name = "partsText";
            this.partsText.ReadOnly = true;
            this.partsText.Size = new System.Drawing.Size(134, 20);
            this.partsText.TabIndex = 5;
            this.partsText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // TaxText
            // 
            this.TaxText.Location = new System.Drawing.Point(149, 86);
            this.TaxText.Name = "TaxText";
            this.TaxText.ReadOnly = true;
            this.TaxText.Size = new System.Drawing.Size(134, 20);
            this.TaxText.TabIndex = 6;
            this.TaxText.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // feesText
            // 
            this.feesText.Location = new System.Drawing.Point(149, 112);
            this.feesText.Name = "feesText";
            this.feesText.ReadOnly = true;
            this.feesText.Size = new System.Drawing.Size(134, 20);
            this.feesText.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 524);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 524);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // partsNum
            // 
            this.partsNum.DecimalPlaces = 2;
            this.partsNum.Location = new System.Drawing.Point(111, 39);
            this.partsNum.Name = "partsNum";
            this.partsNum.Size = new System.Drawing.Size(66, 20);
            this.partsNum.TabIndex = 5;
            this.partsNum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // laborNum
            // 
            this.laborNum.DecimalPlaces = 2;
            this.laborNum.Location = new System.Drawing.Point(111, 84);
            this.laborNum.Name = "laborNum";
            this.laborNum.Size = new System.Drawing.Size(66, 20);
            this.laborNum.TabIndex = 6;
            this.laborNum.ValueChanged += new System.EventHandler(this.laborNum_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 591);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox lubeJob;
        private System.Windows.Forms.CheckBox oilChange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox transmissionFlush;
        private System.Windows.Forms.CheckBox radiatorFlush;
        private System.Windows.Forms.CheckBox replaceMuffler;
        private System.Windows.Forms.CheckBox tireRotation;
        private System.Windows.Forms.CheckBox inspection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox partsText;
        private System.Windows.Forms.TextBox SandLText;
        private System.Windows.Forms.TextBox feesText;
        private System.Windows.Forms.TextBox TaxText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown laborNum;
        private System.Windows.Forms.NumericUpDown partsNum;
    }
}

