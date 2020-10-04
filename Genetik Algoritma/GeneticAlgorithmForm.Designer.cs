namespace Genetik_Algoritma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.elitismNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mutationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.crossNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.populationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.jenerationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elitismNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jenerationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.elitismNumericUpDown);
            this.groupBox1.Controls.Add(this.mutationNumericUpDown);
            this.groupBox1.Controls.Add(this.crossNumericUpDown);
            this.groupBox1.Controls.Add(this.populationNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(199, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seçkinlik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mutasyon Oranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Çaprazlama Boyutu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Populasyon Boyutu";
            // 
            // elitismNumericUpDown
            // 
            this.elitismNumericUpDown.Location = new System.Drawing.Point(118, 95);
            this.elitismNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.elitismNumericUpDown.Name = "elitismNumericUpDown";
            this.elitismNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.elitismNumericUpDown.TabIndex = 3;
            this.elitismNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // mutationNumericUpDown
            // 
            this.mutationNumericUpDown.DecimalPlaces = 4;
            this.mutationNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            262144});
            this.mutationNumericUpDown.Location = new System.Drawing.Point(118, 69);
            this.mutationNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mutationNumericUpDown.Name = "mutationNumericUpDown";
            this.mutationNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.mutationNumericUpDown.TabIndex = 2;
            this.mutationNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            262144});
            // 
            // crossNumericUpDown
            // 
            this.crossNumericUpDown.DecimalPlaces = 2;
            this.crossNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.crossNumericUpDown.Location = new System.Drawing.Point(118, 43);
            this.crossNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.crossNumericUpDown.Name = "crossNumericUpDown";
            this.crossNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.crossNumericUpDown.TabIndex = 1;
            this.crossNumericUpDown.Value = new decimal(new int[] {
            70,
            0,
            0,
            131072});
            // 
            // populationNumericUpDown
            // 
            this.populationNumericUpDown.Location = new System.Drawing.Point(118, 17);
            this.populationNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.populationNumericUpDown.Name = "populationNumericUpDown";
            this.populationNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.populationNumericUpDown.TabIndex = 0;
            this.populationNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.jenerationNumericUpDown);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(461, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 49);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // jenerationNumericUpDown
            // 
            this.jenerationNumericUpDown.Location = new System.Drawing.Point(118, 19);
            this.jenerationNumericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.jenerationNumericUpDown.Name = "jenerationNumericUpDown";
            this.jenerationNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.jenerationNumericUpDown.TabIndex = 3;
            this.jenerationNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Jenerasyon Sayısı";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 137);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Rosenbrock Function";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(856, 308);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(3, 786);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(856, 46);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "BAŞLA";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 473);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(856, 307);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(870, 835);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genetik Algoritma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elitismNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jenerationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown elitismNumericUpDown;
        private System.Windows.Forms.NumericUpDown mutationNumericUpDown;
        private System.Windows.Forms.NumericUpDown crossNumericUpDown;
        private System.Windows.Forms.NumericUpDown populationNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown jenerationNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

