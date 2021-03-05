namespace SimBTB
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnMagic = new System.Windows.Forms.Button();
            this.lText1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelSelectTrace = new System.Windows.Forms.Label();
            this.labelSetArchitecture = new System.Windows.Forms.Label();
            this.labelSetBTBSize = new System.Windows.Forms.Label();
            this.labelSetBits = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPredictionBits = new System.Windows.Forms.ComboBox();
            this.cbBTBSize = new System.Windows.Forms.ComboBox();
            this.cbTrace = new System.Windows.Forms.ComboBox();
            this.cbArchitecture = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWrongPred = new System.Windows.Forms.TextBox();
            this.tbWrongAddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbTaken = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMagic
            // 
            this.btnMagic.Location = new System.Drawing.Point(640, 284);
            this.btnMagic.Name = "btnMagic";
            this.btnMagic.Size = new System.Drawing.Size(75, 23);
            this.btnMagic.TabIndex = 1;
            this.btnMagic.Text = "Start";
            this.btnMagic.UseVisualStyleBackColor = true;
            this.btnMagic.Click += new System.EventHandler(this.btnMagic_Click);
            // 
            // lText1
            // 
            this.lText1.AutoSize = true;
            this.lText1.Location = new System.Drawing.Point(13, 174);
            this.lText1.Name = "lText1";
            this.lText1.Size = new System.Drawing.Size(87, 13);
            this.lText1.TabIndex = 2;
            this.lText1.Text = "Predictii Corecte:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 3;
            // 
            // labelSelectTrace
            // 
            this.labelSelectTrace.AutoSize = true;
            this.labelSelectTrace.Location = new System.Drawing.Point(6, 30);
            this.labelSelectTrace.Name = "labelSelectTrace";
            this.labelSelectTrace.Size = new System.Drawing.Size(46, 13);
            this.labelSelectTrace.TabIndex = 4;
            this.labelSelectTrace.Text = "TRACE:";
            // 
            // labelSetArchitecture
            // 
            this.labelSetArchitecture.AutoSize = true;
            this.labelSetArchitecture.Location = new System.Drawing.Point(6, 59);
            this.labelSetArchitecture.Name = "labelSetArchitecture";
            this.labelSetArchitecture.Size = new System.Drawing.Size(94, 13);
            this.labelSetArchitecture.TabIndex = 5;
            this.labelSetArchitecture.Text = "ARCHITECTURE:";
            // 
            // labelSetBTBSize
            // 
            this.labelSetBTBSize.AutoSize = true;
            this.labelSetBTBSize.Location = new System.Drawing.Point(6, 90);
            this.labelSetBTBSize.Name = "labelSetBTBSize";
            this.labelSetBTBSize.Size = new System.Drawing.Size(58, 13);
            this.labelSetBTBSize.TabIndex = 6;
            this.labelSetBTBSize.Text = "BTB SIZE:";
            // 
            // labelSetBits
            // 
            this.labelSetBits.AutoSize = true;
            this.labelSetBits.Location = new System.Drawing.Point(6, 113);
            this.labelSetBits.Name = "labelSetBits";
            this.labelSetBits.Size = new System.Drawing.Size(103, 13);
            this.labelSetBits.TabIndex = 7;
            this.labelSetBits.Text = "PREDICTION BITS:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPredictionBits);
            this.groupBox1.Controls.Add(this.cbBTBSize);
            this.groupBox1.Controls.Add(this.cbTrace);
            this.groupBox1.Controls.Add(this.cbArchitecture);
            this.groupBox1.Controls.Add(this.labelSetBits);
            this.groupBox1.Controls.Add(this.labelSelectTrace);
            this.groupBox1.Controls.Add(this.labelSetArchitecture);
            this.groupBox1.Controls.Add(this.labelSetBTBSize);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 146);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONFIG";
            // 
            // cbPredictionBits
            // 
            this.cbPredictionBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPredictionBits.FormattingEnabled = true;
            this.cbPredictionBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbPredictionBits.Location = new System.Drawing.Point(111, 110);
            this.cbPredictionBits.Name = "cbPredictionBits";
            this.cbPredictionBits.Size = new System.Drawing.Size(173, 21);
            this.cbPredictionBits.TabIndex = 11;
            // 
            // cbBTBSize
            // 
            this.cbBTBSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBTBSize.FormattingEnabled = true;
            this.cbBTBSize.Items.AddRange(new object[] {
            "8",
            "16",
            "32",
            "64",
            "128",
            "256"});
            this.cbBTBSize.Location = new System.Drawing.Point(111, 82);
            this.cbBTBSize.Name = "cbBTBSize";
            this.cbBTBSize.Size = new System.Drawing.Size(173, 21);
            this.cbBTBSize.TabIndex = 10;
            // 
            // cbTrace
            // 
            this.cbTrace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrace.FormattingEnabled = true;
            this.cbTrace.Items.AddRange(new object[] {
            "FBUBBLE",
            "FMATRIX",
            "FPERM",
            "FPUZZLE",
            "FQUEENS",
            "FSORT",
            "FTOWER",
            "FTREE"});
            this.cbTrace.Location = new System.Drawing.Point(111, 22);
            this.cbTrace.Name = "cbTrace";
            this.cbTrace.Size = new System.Drawing.Size(173, 21);
            this.cbTrace.TabIndex = 9;
            // 
            // cbArchitecture
            // 
            this.cbArchitecture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArchitecture.FormattingEnabled = true;
            this.cbArchitecture.Items.AddRange(new object[] {
            "DIRECT MAPPED",
            "FULLY ASSOCIATIVE"});
            this.cbArchitecture.Location = new System.Drawing.Point(111, 51);
            this.cbArchitecture.Name = "cbArchitecture";
            this.cbArchitecture.Size = new System.Drawing.Size(173, 21);
            this.cbArchitecture.TabIndex = 8;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(308, 25);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(407, 253);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Predictii Gresite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adrese Gresite:";
            // 
            // tbWrongPred
            // 
            this.tbWrongPred.Location = new System.Drawing.Point(106, 197);
            this.tbWrongPred.Name = "tbWrongPred";
            this.tbWrongPred.ReadOnly = true;
            this.tbWrongPred.Size = new System.Drawing.Size(43, 20);
            this.tbWrongPred.TabIndex = 12;
            // 
            // tbWrongAddr
            // 
            this.tbWrongAddr.Location = new System.Drawing.Point(106, 223);
            this.tbWrongAddr.Name = "tbWrongAddr";
            this.tbWrongAddr.ReadOnly = true;
            this.tbWrongAddr.Size = new System.Drawing.Size(43, 20);
            this.tbWrongAddr.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total Instructiuni:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Instructiuni Executate:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(131, 262);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(72, 20);
            this.tbTotal.TabIndex = 16;
            // 
            // tbTaken
            // 
            this.tbTaken.Location = new System.Drawing.Point(131, 289);
            this.tbTaken.Name = "tbTaken";
            this.tbTaken.ReadOnly = true;
            this.tbTaken.Size = new System.Drawing.Size(72, 20);
            this.tbTaken.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(736, 319);
            this.Controls.Add(this.tbTaken);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbWrongAddr);
            this.Controls.Add(this.tbWrongPred);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lText1);
            this.Controls.Add(this.btnMagic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMagic;
        private System.Windows.Forms.Label lText1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelSelectTrace;
        private System.Windows.Forms.Label labelSetArchitecture;
        private System.Windows.Forms.Label labelSetBTBSize;
        private System.Windows.Forms.Label labelSetBits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbArchitecture;
        private System.Windows.Forms.ComboBox cbTrace;
        private System.Windows.Forms.ComboBox cbBTBSize;
        private System.Windows.Forms.ComboBox cbPredictionBits;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWrongPred;
        private System.Windows.Forms.TextBox tbWrongAddr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbTaken;
    }
}

