namespace CourseProject.View
{
    partial class abForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAvg = new System.Windows.Forms.Button();
            this.comboByType = new System.Windows.Forms.ComboBox();
            this.buttonLow = new System.Windows.Forms.Button();
            this.buttonHigh = new System.Windows.Forms.Button();
            this.PriceGroup = new System.Windows.Forms.GroupBox();
            this.SellingsGroup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateFromSellings = new System.Windows.Forms.DateTimePicker();
            this.dateToSellings = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateToPrice = new System.Windows.Forms.DateTimePicker();
            this.dateFromPrice = new System.Windows.Forms.DateTimePicker();
            this.buttonAvgPrice = new System.Windows.Forms.Button();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLowPrice = new System.Windows.Forms.Button();
            this.CombMaker = new System.Windows.Forms.ComboBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PriceGroup.SuspendLayout();
            this.SellingsGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonTest);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.SellingsGroup);
            this.panel1.Controls.Add(this.PriceGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 681);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(369, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 681);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(877, 671);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAvg
            // 
            this.buttonAvg.Location = new System.Drawing.Point(72, 46);
            this.buttonAvg.Name = "buttonAvg";
            this.buttonAvg.Size = new System.Drawing.Size(60, 23);
            this.buttonAvg.TabIndex = 0;
            this.buttonAvg.Text = "avg";
            this.buttonAvg.UseVisualStyleBackColor = true;
            // 
            // comboByType
            // 
            this.comboByType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboByType.FormattingEnabled = true;
            this.comboByType.Location = new System.Drawing.Point(6, 19);
            this.comboByType.Name = "comboByType";
            this.comboByType.Size = new System.Drawing.Size(192, 21);
            this.comboByType.TabIndex = 1;
            // 
            // buttonLow
            // 
            this.buttonLow.Location = new System.Drawing.Point(6, 46);
            this.buttonLow.Name = "buttonLow";
            this.buttonLow.Size = new System.Drawing.Size(60, 23);
            this.buttonLow.TabIndex = 0;
            this.buttonLow.Text = "low";
            this.buttonLow.UseVisualStyleBackColor = true;
            // 
            // buttonHigh
            // 
            this.buttonHigh.Location = new System.Drawing.Point(138, 46);
            this.buttonHigh.Name = "buttonHigh";
            this.buttonHigh.Size = new System.Drawing.Size(60, 23);
            this.buttonHigh.TabIndex = 0;
            this.buttonHigh.Text = "high";
            this.buttonHigh.UseVisualStyleBackColor = true;
            // 
            // PriceGroup
            // 
            this.PriceGroup.Controls.Add(this.comboByType);
            this.PriceGroup.Controls.Add(this.buttonHigh);
            this.PriceGroup.Controls.Add(this.buttonLow);
            this.PriceGroup.Controls.Add(this.buttonAvg);
            this.PriceGroup.Location = new System.Drawing.Point(154, 10);
            this.PriceGroup.Name = "PriceGroup";
            this.PriceGroup.Size = new System.Drawing.Size(207, 79);
            this.PriceGroup.TabIndex = 2;
            this.PriceGroup.TabStop = false;
            this.PriceGroup.Text = "Price by type";
            // 
            // SellingsGroup
            // 
            this.SellingsGroup.Controls.Add(this.label2);
            this.SellingsGroup.Controls.Add(this.label1);
            this.SellingsGroup.Controls.Add(this.dateToSellings);
            this.SellingsGroup.Controls.Add(this.dateFromSellings);
            this.SellingsGroup.Controls.Add(this.button2);
            this.SellingsGroup.Controls.Add(this.button1);
            this.SellingsGroup.Location = new System.Drawing.Point(10, 95);
            this.SellingsGroup.Name = "SellingsGroup";
            this.SellingsGroup.Size = new System.Drawing.Size(351, 102);
            this.SellingsGroup.TabIndex = 3;
            this.SellingsGroup.TabStop = false;
            this.SellingsGroup.Text = "Sellings";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Most popular type";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "selling at range";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dateFromSellings
            // 
            this.dateFromSellings.Location = new System.Drawing.Point(87, 48);
            this.dateFromSellings.Name = "dateFromSellings";
            this.dateFromSellings.Size = new System.Drawing.Size(200, 20);
            this.dateFromSellings.TabIndex = 2;
            // 
            // dateToSellings
            // 
            this.dateToSellings.Location = new System.Drawing.Point(87, 74);
            this.dateToSellings.Name = "dateToSellings";
            this.dateToSellings.Size = new System.Drawing.Size(200, 20);
            this.dateToSellings.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CombMaker);
            this.groupBox1.Controls.Add(this.buttonLowPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateToPrice);
            this.groupBox1.Controls.Add(this.dateFromPrice);
            this.groupBox1.Controls.Add(this.buttonAvgPrice);
            this.groupBox1.Location = new System.Drawing.Point(11, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 141);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "From";
            // 
            // dateToPrice
            // 
            this.dateToPrice.Location = new System.Drawing.Point(87, 45);
            this.dateToPrice.Name = "dateToPrice";
            this.dateToPrice.Size = new System.Drawing.Size(200, 20);
            this.dateToPrice.TabIndex = 2;
            // 
            // dateFromPrice
            // 
            this.dateFromPrice.Location = new System.Drawing.Point(87, 19);
            this.dateFromPrice.Name = "dateFromPrice";
            this.dateFromPrice.Size = new System.Drawing.Size(200, 20);
            this.dateFromPrice.TabIndex = 2;
            // 
            // buttonAvgPrice
            // 
            this.buttonAvgPrice.Location = new System.Drawing.Point(6, 19);
            this.buttonAvgPrice.Name = "buttonAvgPrice";
            this.buttonAvgPrice.Size = new System.Drawing.Size(75, 45);
            this.buttonAvgPrice.TabIndex = 1;
            this.buttonAvgPrice.Text = "avg price at range";
            this.buttonAvgPrice.UseVisualStyleBackColor = true;
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(87, 80);
            this.numPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 20);
            this.numPrice.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "price";
            // 
            // buttonLowPrice
            // 
            this.buttonLowPrice.Location = new System.Drawing.Point(6, 80);
            this.buttonLowPrice.Name = "buttonLowPrice";
            this.buttonLowPrice.Size = new System.Drawing.Size(75, 46);
            this.buttonLowPrice.TabIndex = 7;
            this.buttonLowPrice.Text = "price lower avg";
            this.buttonLowPrice.UseVisualStyleBackColor = true;
            // 
            // CombMaker
            // 
            this.CombMaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombMaker.FormattingEnabled = true;
            this.CombMaker.Location = new System.Drawing.Point(87, 106);
            this.CombMaker.Name = "CombMaker";
            this.CombMaker.Size = new System.Drawing.Size(121, 21);
            this.CombMaker.TabIndex = 8;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(11, 644);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 4;
            this.buttonTest.Text = "button3";
            this.buttonTest.UseVisualStyleBackColor = true;
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StorageForm";
            this.Text = "Storage";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PriceGroup.ResumeLayout(false);
            this.SellingsGroup.ResumeLayout(false);
            this.SellingsGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CombMaker;
        private System.Windows.Forms.Button buttonLowPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateToPrice;
        private System.Windows.Forms.DateTimePicker dateFromPrice;
        private System.Windows.Forms.Button buttonAvgPrice;
        private System.Windows.Forms.GroupBox SellingsGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateToSellings;
        private System.Windows.Forms.DateTimePicker dateFromSellings;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox PriceGroup;
        private System.Windows.Forms.ComboBox comboByType;
        private System.Windows.Forms.Button buttonHigh;
        private System.Windows.Forms.Button buttonLow;
        private System.Windows.Forms.Button buttonAvg;
        private System.Windows.Forms.Button buttonTest;
    }
}