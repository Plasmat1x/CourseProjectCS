namespace CourseProject
{
    partial class MainForm
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
            this.tablegrid = new System.Windows.Forms.DataGridView();
            this.sort = new System.Windows.Forms.GroupBox();
            this.rbDescening = new System.Windows.Forms.RadioButton();
            this.rbAscending = new System.Windows.Forms.RadioButton();
            this.showBT = new System.Windows.Forms.Button();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.output = new System.Windows.Forms.GroupBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.cbMakers = new System.Windows.Forms.CheckedListBox();
            this.PriceRangeBox = new System.Windows.Forms.GroupBox();
            this.priceFrom = new System.Windows.Forms.NumericUpDown();
            this.priceTo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.CheckedListBox();
            this.weightRange = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weightTo = new System.Windows.Forms.NumericUpDown();
            this.wheightFrom = new System.Windows.Forms.NumericUpDown();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.dateRange = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tablegrid)).BeginInit();
            this.sort.SuspendLayout();
            this.output.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.PriceRangeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTo)).BeginInit();
            this.weightRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheightFrom)).BeginInit();
            this.dateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablegrid
            // 
            this.tablegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablegrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablegrid.Location = new System.Drawing.Point(0, 0);
            this.tablegrid.Name = "tablegrid";
            this.tablegrid.Size = new System.Drawing.Size(1042, 681);
            this.tablegrid.TabIndex = 0;
            // 
            // sort
            // 
            this.sort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sort.Controls.Add(this.rbDescening);
            this.sort.Controls.Add(this.rbAscending);
            this.sort.Location = new System.Drawing.Point(6, 48);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(196, 76);
            this.sort.TabIndex = 1;
            this.sort.TabStop = false;
            this.sort.Text = "Order by";
            // 
            // rbDescening
            // 
            this.rbDescening.AutoSize = true;
            this.rbDescening.Location = new System.Drawing.Point(6, 42);
            this.rbDescening.Name = "rbDescening";
            this.rbDescening.Size = new System.Drawing.Size(80, 17);
            this.rbDescening.TabIndex = 1;
            this.rbDescening.Text = "descending";
            this.rbDescening.UseVisualStyleBackColor = true;
            // 
            // rbAscending
            // 
            this.rbAscending.AutoSize = true;
            this.rbAscending.Checked = true;
            this.rbAscending.Location = new System.Drawing.Point(6, 19);
            this.rbAscending.Name = "rbAscending";
            this.rbAscending.Size = new System.Drawing.Size(74, 17);
            this.rbAscending.TabIndex = 0;
            this.rbAscending.TabStop = true;
            this.rbAscending.Text = "ascengind";
            this.rbAscending.UseVisualStyleBackColor = true;
            // 
            // showBT
            // 
            this.showBT.Location = new System.Drawing.Point(6, 653);
            this.showBT.Name = "showBT";
            this.showBT.Size = new System.Drawing.Size(212, 23);
            this.showBT.TabIndex = 2;
            this.showBT.Text = "Show";
            this.showBT.UseVisualStyleBackColor = true;
            // 
            // categoryCB
            // 
            this.categoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(6, 19);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(196, 21);
            this.categoryCB.TabIndex = 3;
            // 
            // output
            // 
            this.output.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.output.Controls.Add(this.categoryCB);
            this.output.Controls.Add(this.sort);
            this.output.Location = new System.Drawing.Point(6, 472);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(212, 130);
            this.output.TabIndex = 4;
            this.output.TabStop = false;
            this.output.Text = "Output";
            // 
            // ControlPanel
            // 
            this.ControlPanel.AutoScroll = true;
            this.ControlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlPanel.Controls.Add(this.SearchField);
            this.ControlPanel.Controls.Add(this.dateRange);
            this.ControlPanel.Controls.Add(this.weightRange);
            this.ControlPanel.Controls.Add(this.PriceRangeBox);
            this.ControlPanel.Controls.Add(this.cbType);
            this.ControlPanel.Controls.Add(this.cbMakers);
            this.ControlPanel.Controls.Add(this.showBT);
            this.ControlPanel.Controls.Add(this.output);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlPanel.Location = new System.Drawing.Point(1041, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(223, 681);
            this.ControlPanel.TabIndex = 5;
            // 
            // cbMakers
            // 
            this.cbMakers.FormattingEnabled = true;
            this.cbMakers.Location = new System.Drawing.Point(6, 141);
            this.cbMakers.Name = "cbMakers";
            this.cbMakers.Size = new System.Drawing.Size(212, 94);
            this.cbMakers.TabIndex = 5;
            // 
            // PriceRangeBox
            // 
            this.PriceRangeBox.Controls.Add(this.label2);
            this.PriceRangeBox.Controls.Add(this.label1);
            this.PriceRangeBox.Controls.Add(this.priceTo);
            this.PriceRangeBox.Controls.Add(this.priceFrom);
            this.PriceRangeBox.Location = new System.Drawing.Point(6, 241);
            this.PriceRangeBox.Name = "PriceRangeBox";
            this.PriceRangeBox.Size = new System.Drawing.Size(212, 71);
            this.PriceRangeBox.TabIndex = 6;
            this.PriceRangeBox.TabStop = false;
            this.PriceRangeBox.Text = "Price range";
            // 
            // priceFrom
            // 
            this.priceFrom.DecimalPlaces = 2;
            this.priceFrom.Location = new System.Drawing.Point(82, 19);
            this.priceFrom.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.priceFrom.Name = "priceFrom";
            this.priceFrom.Size = new System.Drawing.Size(120, 20);
            this.priceFrom.TabIndex = 0;
            // 
            // priceTo
            // 
            this.priceTo.DecimalPlaces = 2;
            this.priceTo.Location = new System.Drawing.Point(82, 45);
            this.priceTo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.priceTo.Name = "priceTo";
            this.priceTo.Size = new System.Drawing.Size(120, 20);
            this.priceTo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(6, 41);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(212, 94);
            this.cbType.TabIndex = 5;
            // 
            // weightRange
            // 
            this.weightRange.Controls.Add(this.label3);
            this.weightRange.Controls.Add(this.label4);
            this.weightRange.Controls.Add(this.weightTo);
            this.weightRange.Controls.Add(this.wheightFrom);
            this.weightRange.Location = new System.Drawing.Point(6, 318);
            this.weightRange.Name = "weightRange";
            this.weightRange.Size = new System.Drawing.Size(212, 71);
            this.weightRange.TabIndex = 6;
            this.weightRange.TabStop = false;
            this.weightRange.Text = "Weight range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "From";
            // 
            // weightTo
            // 
            this.weightTo.Location = new System.Drawing.Point(82, 45);
            this.weightTo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.weightTo.Name = "weightTo";
            this.weightTo.Size = new System.Drawing.Size(120, 20);
            this.weightTo.TabIndex = 0;
            // 
            // wheightFrom
            // 
            this.wheightFrom.Location = new System.Drawing.Point(82, 19);
            this.wheightFrom.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.wheightFrom.Name = "wheightFrom";
            this.wheightFrom.Size = new System.Drawing.Size(120, 20);
            this.wheightFrom.TabIndex = 0;
            // 
            // SearchField
            // 
            this.SearchField.Location = new System.Drawing.Point(6, 11);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(212, 20);
            this.SearchField.TabIndex = 7;
            // 
            // dateRange
            // 
            this.dateRange.Controls.Add(this.dateFrom);
            this.dateRange.Controls.Add(this.dateTo);
            this.dateRange.Controls.Add(this.label5);
            this.dateRange.Controls.Add(this.label6);
            this.dateRange.Location = new System.Drawing.Point(6, 395);
            this.dateRange.Name = "dateRange";
            this.dateRange.Size = new System.Drawing.Size(212, 71);
            this.dateRange.TabIndex = 6;
            this.dateRange.TabStop = false;
            this.dateRange.Text = "Date range";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "From";
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(82, 45);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(120, 20);
            this.dateTo.TabIndex = 3;
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(82, 18);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(120, 20);
            this.dateFrom.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.tablegrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.tablegrid)).EndInit();
            this.sort.ResumeLayout(false);
            this.sort.PerformLayout();
            this.output.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.PriceRangeBox.ResumeLayout(false);
            this.PriceRangeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTo)).EndInit();
            this.weightRange.ResumeLayout(false);
            this.weightRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheightFrom)).EndInit();
            this.dateRange.ResumeLayout(false);
            this.dateRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablegrid;
        private System.Windows.Forms.GroupBox sort;
        private System.Windows.Forms.RadioButton rbDescening;
        private System.Windows.Forms.RadioButton rbAscending;
        private System.Windows.Forms.Button showBT;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.GroupBox output;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.GroupBox PriceRangeBox;
        private System.Windows.Forms.NumericUpDown priceTo;
        private System.Windows.Forms.NumericUpDown priceFrom;
        private System.Windows.Forms.CheckedListBox cbMakers;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.GroupBox dateRange;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox weightRange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown weightTo;
        private System.Windows.Forms.NumericUpDown wheightFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox cbType;
    }
}

