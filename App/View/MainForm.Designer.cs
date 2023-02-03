﻿namespace CourseProject
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
            this.sort = new System.Windows.Forms.GroupBox();
            this.rbDescening = new System.Windows.Forms.RadioButton();
            this.rbAscending = new System.Windows.Forms.RadioButton();
            this.showBT = new System.Windows.Forms.Button();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.output = new System.Windows.Forms.GroupBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTypesGroup = new System.Windows.Forms.CheckBox();
            this.cbType = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMakersGroup = new System.Windows.Forms.CheckBox();
            this.cbMakers = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btInspectItem = new System.Windows.Forms.Button();
            this.btAddItem = new System.Windows.Forms.Button();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.dateRange = new System.Windows.Forms.GroupBox();
            this.cbDateGroup = new System.Windows.Forms.CheckBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.weightRange = new System.Windows.Forms.GroupBox();
            this.cbWeightGroup = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weightTo = new System.Windows.Forms.NumericUpDown();
            this.wheightFrom = new System.Windows.Forms.NumericUpDown();
            this.PriceRangeBox = new System.Windows.Forms.GroupBox();
            this.cbPriceGroup = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.priceTo = new System.Windows.Forms.NumericUpDown();
            this.priceFrom = new System.Windows.Forms.NumericUpDown();
            this.ItemPanel = new System.Windows.Forms.Panel();
            this.ItemsGrid = new System.Windows.Forms.DataGridView();
            this.test = new System.Windows.Forms.Button();
            this.sort.SuspendLayout();
            this.output.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.dateRange.SuspendLayout();
            this.weightRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheightFrom)).BeginInit();
            this.PriceRangeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceFrom)).BeginInit();
            this.ItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).BeginInit();
            this.SuspendLayout();
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
            this.showBT.Location = new System.Drawing.Point(6, 687);
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
            this.output.Location = new System.Drawing.Point(7, 528);
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
            this.ControlPanel.Controls.Add(this.test);
            this.ControlPanel.Controls.Add(this.groupBox2);
            this.ControlPanel.Controls.Add(this.groupBox1);
            this.ControlPanel.Controls.Add(this.label7);
            this.ControlPanel.Controls.Add(this.btInspectItem);
            this.ControlPanel.Controls.Add(this.btAddItem);
            this.ControlPanel.Controls.Add(this.SearchField);
            this.ControlPanel.Controls.Add(this.dateRange);
            this.ControlPanel.Controls.Add(this.weightRange);
            this.ControlPanel.Controls.Add(this.PriceRangeBox);
            this.ControlPanel.Controls.Add(this.showBT);
            this.ControlPanel.Controls.Add(this.output);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlPanel.Location = new System.Drawing.Point(1006, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(252, 681);
            this.ControlPanel.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTypesGroup);
            this.groupBox2.Controls.Add(this.cbType);
            this.groupBox2.Location = new System.Drawing.Point(6, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 124);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Types";
            // 
            // cbTypesGroup
            // 
            this.cbTypesGroup.AutoSize = true;
            this.cbTypesGroup.Location = new System.Drawing.Point(7, 19);
            this.cbTypesGroup.Name = "cbTypesGroup";
            this.cbTypesGroup.Size = new System.Drawing.Size(15, 14);
            this.cbTypesGroup.TabIndex = 6;
            this.cbTypesGroup.UseVisualStyleBackColor = true;
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(36, 19);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(166, 94);
            this.cbType.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMakersGroup);
            this.groupBox1.Controls.Add(this.cbMakers);
            this.groupBox1.Location = new System.Drawing.Point(6, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 124);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Makers";
            // 
            // cbMakersGroup
            // 
            this.cbMakersGroup.AutoSize = true;
            this.cbMakersGroup.Location = new System.Drawing.Point(6, 19);
            this.cbMakersGroup.Name = "cbMakersGroup";
            this.cbMakersGroup.Size = new System.Drawing.Size(15, 14);
            this.cbMakersGroup.TabIndex = 6;
            this.cbMakersGroup.UseVisualStyleBackColor = true;
            // 
            // cbMakers
            // 
            this.cbMakers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMakers.FormattingEnabled = true;
            this.cbMakers.Location = new System.Drawing.Point(36, 19);
            this.cbMakers.Name = "cbMakers";
            this.cbMakers.Size = new System.Drawing.Size(166, 94);
            this.cbMakers.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "name";
            // 
            // btInspectItem
            // 
            this.btInspectItem.Location = new System.Drawing.Point(5, 716);
            this.btInspectItem.Name = "btInspectItem";
            this.btInspectItem.Size = new System.Drawing.Size(95, 23);
            this.btInspectItem.TabIndex = 9;
            this.btInspectItem.Text = "Incpect / modify";
            this.btInspectItem.UseVisualStyleBackColor = true;
            this.btInspectItem.Click += new System.EventHandler(this.btInspectItem_Click);
            // 
            // btAddItem
            // 
            this.btAddItem.Location = new System.Drawing.Point(123, 717);
            this.btAddItem.Name = "btAddItem";
            this.btAddItem.Size = new System.Drawing.Size(95, 23);
            this.btAddItem.TabIndex = 8;
            this.btAddItem.Text = "Add new item";
            this.btAddItem.UseVisualStyleBackColor = true;
            // 
            // SearchField
            // 
            this.SearchField.Location = new System.Drawing.Point(42, 11);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(176, 20);
            this.SearchField.TabIndex = 7;
            // 
            // dateRange
            // 
            this.dateRange.Controls.Add(this.cbDateGroup);
            this.dateRange.Controls.Add(this.dateFrom);
            this.dateRange.Controls.Add(this.dateTo);
            this.dateRange.Controls.Add(this.label5);
            this.dateRange.Controls.Add(this.label6);
            this.dateRange.Location = new System.Drawing.Point(6, 451);
            this.dateRange.Name = "dateRange";
            this.dateRange.Size = new System.Drawing.Size(212, 71);
            this.dateRange.TabIndex = 6;
            this.dateRange.TabStop = false;
            this.dateRange.Text = "Date range";
            // 
            // cbDateGroup
            // 
            this.cbDateGroup.AutoSize = true;
            this.cbDateGroup.Location = new System.Drawing.Point(6, 18);
            this.cbDateGroup.Name = "cbDateGroup";
            this.cbDateGroup.Size = new System.Drawing.Size(15, 14);
            this.cbDateGroup.TabIndex = 6;
            this.cbDateGroup.UseVisualStyleBackColor = true;
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(82, 18);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(120, 20);
            this.dateFrom.TabIndex = 3;
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(82, 45);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(120, 20);
            this.dateTo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "From";
            // 
            // weightRange
            // 
            this.weightRange.Controls.Add(this.cbWeightGroup);
            this.weightRange.Controls.Add(this.label3);
            this.weightRange.Controls.Add(this.label4);
            this.weightRange.Controls.Add(this.weightTo);
            this.weightRange.Controls.Add(this.wheightFrom);
            this.weightRange.Location = new System.Drawing.Point(7, 374);
            this.weightRange.Name = "weightRange";
            this.weightRange.Size = new System.Drawing.Size(212, 71);
            this.weightRange.TabIndex = 6;
            this.weightRange.TabStop = false;
            this.weightRange.Text = "Weight range";
            // 
            // cbWeightGroup
            // 
            this.cbWeightGroup.AutoSize = true;
            this.cbWeightGroup.Location = new System.Drawing.Point(5, 19);
            this.cbWeightGroup.Name = "cbWeightGroup";
            this.cbWeightGroup.Size = new System.Drawing.Size(15, 14);
            this.cbWeightGroup.TabIndex = 6;
            this.cbWeightGroup.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 26);
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
            // PriceRangeBox
            // 
            this.PriceRangeBox.Controls.Add(this.cbPriceGroup);
            this.PriceRangeBox.Controls.Add(this.label2);
            this.PriceRangeBox.Controls.Add(this.label1);
            this.PriceRangeBox.Controls.Add(this.priceTo);
            this.PriceRangeBox.Controls.Add(this.priceFrom);
            this.PriceRangeBox.Location = new System.Drawing.Point(6, 297);
            this.PriceRangeBox.Name = "PriceRangeBox";
            this.PriceRangeBox.Size = new System.Drawing.Size(212, 71);
            this.PriceRangeBox.TabIndex = 6;
            this.PriceRangeBox.TabStop = false;
            this.PriceRangeBox.Text = "Price range";
            // 
            // cbPriceGroup
            // 
            this.cbPriceGroup.AutoSize = true;
            this.cbPriceGroup.Location = new System.Drawing.Point(6, 19);
            this.cbPriceGroup.Name = "cbPriceGroup";
            this.cbPriceGroup.Size = new System.Drawing.Size(15, 14);
            this.cbPriceGroup.TabIndex = 6;
            this.cbPriceGroup.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
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
            // ItemPanel
            // 
            this.ItemPanel.AutoScroll = true;
            this.ItemPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ItemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemPanel.Controls.Add(this.ItemsGrid);
            this.ItemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Size = new System.Drawing.Size(1006, 681);
            this.ItemPanel.TabIndex = 6;
            // 
            // ItemsGrid
            // 
            this.ItemsGrid.AllowUserToAddRows = false;
            this.ItemsGrid.AllowUserToDeleteRows = false;
            this.ItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGrid.Location = new System.Drawing.Point(0, 0);
            this.ItemsGrid.MultiSelect = false;
            this.ItemsGrid.Name = "ItemsGrid";
            this.ItemsGrid.Size = new System.Drawing.Size(1004, 679);
            this.ItemsGrid.TabIndex = 0;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(5, 658);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 13;
            this.test.Text = "button1";
            this.test.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 681);
            this.Controls.Add(this.ItemPanel);
            this.Controls.Add(this.ControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MainForm";
            this.sort.ResumeLayout(false);
            this.sort.PerformLayout();
            this.output.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dateRange.ResumeLayout(false);
            this.dateRange.PerformLayout();
            this.weightRange.ResumeLayout(false);
            this.weightRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheightFrom)).EndInit();
            this.PriceRangeBox.ResumeLayout(false);
            this.PriceRangeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceFrom)).EndInit();
            this.ItemPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button btAddItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btInspectItem;
        private System.Windows.Forms.Panel ItemPanel;
        private System.Windows.Forms.DataGridView ItemsGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTypesGroup;
        private System.Windows.Forms.CheckBox cbMakersGroup;
        private System.Windows.Forms.CheckBox cbDateGroup;
        private System.Windows.Forms.CheckBox cbWeightGroup;
        private System.Windows.Forms.CheckBox cbPriceGroup;
        private System.Windows.Forms.Button test;
    }
}

