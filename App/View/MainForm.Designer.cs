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
            this.sort = new System.Windows.Forms.GroupBox();
            this.radioDescening = new System.Windows.Forms.RadioButton();
            this.radioAscending = new System.Windows.Forms.RadioButton();
            this.buttonShowResults = new System.Windows.Forms.Button();
            this.combFieldName = new System.Windows.Forms.ComboBox();
            this.output = new System.Windows.Forms.GroupBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.buttonTest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkTypesGroup = new System.Windows.Forms.CheckBox();
            this.checksType = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkMakersGroup = new System.Windows.Forms.CheckBox();
            this.checksMakers = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonInspectItem = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dateRange = new System.Windows.Forms.GroupBox();
            this.checkDateGroup = new System.Windows.Forms.CheckBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.weightRange = new System.Windows.Forms.GroupBox();
            this.checkWeightGroup = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weightTo = new System.Windows.Forms.NumericUpDown();
            this.weightFrom = new System.Windows.Forms.NumericUpDown();
            this.PriceRangeBox = new System.Windows.Forms.GroupBox();
            this.checkPriceGroup = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.priceTo = new System.Windows.Forms.NumericUpDown();
            this.priceFrom = new System.Windows.Forms.NumericUpDown();
            this.ItemPanel = new System.Windows.Forms.Panel();
            this.ItemsGrid = new System.Windows.Forms.DataGridView();
            this.sort.SuspendLayout();
            this.output.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.dateRange.SuspendLayout();
            this.weightRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightFrom)).BeginInit();
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
            this.sort.Controls.Add(this.radioDescening);
            this.sort.Controls.Add(this.radioAscending);
            this.sort.Location = new System.Drawing.Point(6, 48);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(196, 76);
            this.sort.TabIndex = 1;
            this.sort.TabStop = false;
            this.sort.Text = "Order by";
            // 
            // radioDescening
            // 
            this.radioDescening.AutoSize = true;
            this.radioDescening.Location = new System.Drawing.Point(6, 42);
            this.radioDescening.Name = "radioDescening";
            this.radioDescening.Size = new System.Drawing.Size(80, 17);
            this.radioDescening.TabIndex = 1;
            this.radioDescening.Text = "descending";
            this.radioDescening.UseVisualStyleBackColor = true;
            // 
            // radioAscending
            // 
            this.radioAscending.AutoSize = true;
            this.radioAscending.Checked = true;
            this.radioAscending.Location = new System.Drawing.Point(6, 19);
            this.radioAscending.Name = "radioAscending";
            this.radioAscending.Size = new System.Drawing.Size(74, 17);
            this.radioAscending.TabIndex = 0;
            this.radioAscending.TabStop = true;
            this.radioAscending.Text = "ascengind";
            this.radioAscending.UseVisualStyleBackColor = true;
            // 
            // buttonShowResults
            // 
            this.buttonShowResults.Location = new System.Drawing.Point(6, 687);
            this.buttonShowResults.Name = "buttonShowResults";
            this.buttonShowResults.Size = new System.Drawing.Size(212, 23);
            this.buttonShowResults.TabIndex = 2;
            this.buttonShowResults.Text = "Show";
            this.buttonShowResults.UseVisualStyleBackColor = true;
            // 
            // combFieldName
            // 
            this.combFieldName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combFieldName.FormattingEnabled = true;
            this.combFieldName.Location = new System.Drawing.Point(5, 19);
            this.combFieldName.Name = "combFieldName";
            this.combFieldName.Size = new System.Drawing.Size(197, 21);
            this.combFieldName.TabIndex = 3;
            // 
            // output
            // 
            this.output.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.output.Controls.Add(this.combFieldName);
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
            this.ControlPanel.Controls.Add(this.groupBox2);
            this.ControlPanel.Controls.Add(this.groupBox1);
            this.ControlPanel.Controls.Add(this.label7);
            this.ControlPanel.Controls.Add(this.buttonInspectItem);
            this.ControlPanel.Controls.Add(this.buttonAddItem);
            this.ControlPanel.Controls.Add(this.nameTextBox);
            this.ControlPanel.Controls.Add(this.dateRange);
            this.ControlPanel.Controls.Add(this.weightRange);
            this.ControlPanel.Controls.Add(this.PriceRangeBox);
            this.ControlPanel.Controls.Add(this.buttonShowResults);
            this.ControlPanel.Controls.Add(this.output);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlPanel.Location = new System.Drawing.Point(1006, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(252, 681);
            this.ControlPanel.TabIndex = 5;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(12, 646);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 13;
            this.buttonTest.Text = "button1";
            this.buttonTest.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkTypesGroup);
            this.groupBox2.Controls.Add(this.checksType);
            this.groupBox2.Location = new System.Drawing.Point(6, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 124);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Types";
            // 
            // checkTypesGroup
            // 
            this.checkTypesGroup.AutoSize = true;
            this.checkTypesGroup.Location = new System.Drawing.Point(7, 19);
            this.checkTypesGroup.Name = "checkTypesGroup";
            this.checkTypesGroup.Size = new System.Drawing.Size(15, 14);
            this.checkTypesGroup.TabIndex = 6;
            this.checkTypesGroup.UseVisualStyleBackColor = true;
            // 
            // checksType
            // 
            this.checksType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checksType.FormattingEnabled = true;
            this.checksType.Items.AddRange(new object[] {
            "Monitor",
            "Console",
            "Smartphone",
            "Printer"});
            this.checksType.Location = new System.Drawing.Point(36, 19);
            this.checksType.Name = "checksType";
            this.checksType.Size = new System.Drawing.Size(166, 94);
            this.checksType.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkMakersGroup);
            this.groupBox1.Controls.Add(this.checksMakers);
            this.groupBox1.Location = new System.Drawing.Point(6, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 124);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Makers";
            // 
            // checkMakersGroup
            // 
            this.checkMakersGroup.AutoSize = true;
            this.checkMakersGroup.Location = new System.Drawing.Point(6, 19);
            this.checkMakersGroup.Name = "checkMakersGroup";
            this.checkMakersGroup.Size = new System.Drawing.Size(15, 14);
            this.checkMakersGroup.TabIndex = 6;
            this.checkMakersGroup.UseVisualStyleBackColor = true;
            // 
            // checksMakers
            // 
            this.checksMakers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checksMakers.FormattingEnabled = true;
            this.checksMakers.Items.AddRange(new object[] {
            "Samsung",
            "Canon",
            "HP",
            "Sony"});
            this.checksMakers.Location = new System.Drawing.Point(36, 19);
            this.checksMakers.Name = "checksMakers";
            this.checksMakers.Size = new System.Drawing.Size(166, 94);
            this.checksMakers.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Name";
            // 
            // buttonInspectItem
            // 
            this.buttonInspectItem.Location = new System.Drawing.Point(5, 716);
            this.buttonInspectItem.Name = "buttonInspectItem";
            this.buttonInspectItem.Size = new System.Drawing.Size(95, 23);
            this.buttonInspectItem.TabIndex = 9;
            this.buttonInspectItem.Text = "Incpect / modify";
            this.buttonInspectItem.UseVisualStyleBackColor = true;
            this.buttonInspectItem.Click += new System.EventHandler(this.btInspectItem_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(123, 717);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(95, 23);
            this.buttonAddItem.TabIndex = 8;
            this.buttonAddItem.Text = "Add new item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(42, 11);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(176, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // dateRange
            // 
            this.dateRange.Controls.Add(this.checkDateGroup);
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
            // checkDateGroup
            // 
            this.checkDateGroup.AutoSize = true;
            this.checkDateGroup.Location = new System.Drawing.Point(6, 18);
            this.checkDateGroup.Name = "checkDateGroup";
            this.checkDateGroup.Size = new System.Drawing.Size(15, 14);
            this.checkDateGroup.TabIndex = 6;
            this.checkDateGroup.UseVisualStyleBackColor = true;
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
            this.weightRange.Controls.Add(this.checkWeightGroup);
            this.weightRange.Controls.Add(this.label3);
            this.weightRange.Controls.Add(this.label4);
            this.weightRange.Controls.Add(this.weightTo);
            this.weightRange.Controls.Add(this.weightFrom);
            this.weightRange.Location = new System.Drawing.Point(7, 374);
            this.weightRange.Name = "weightRange";
            this.weightRange.Size = new System.Drawing.Size(212, 71);
            this.weightRange.TabIndex = 6;
            this.weightRange.TabStop = false;
            this.weightRange.Text = "Weight range";
            // 
            // checkWeightGroup
            // 
            this.checkWeightGroup.AutoSize = true;
            this.checkWeightGroup.Location = new System.Drawing.Point(5, 19);
            this.checkWeightGroup.Name = "checkWeightGroup";
            this.checkWeightGroup.Size = new System.Drawing.Size(15, 14);
            this.checkWeightGroup.TabIndex = 6;
            this.checkWeightGroup.UseVisualStyleBackColor = true;
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
            // weightFrom
            // 
            this.weightFrom.Location = new System.Drawing.Point(82, 19);
            this.weightFrom.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.weightFrom.Name = "weightFrom";
            this.weightFrom.Size = new System.Drawing.Size(120, 20);
            this.weightFrom.TabIndex = 0;
            // 
            // PriceRangeBox
            // 
            this.PriceRangeBox.Controls.Add(this.checkPriceGroup);
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
            // checkPriceGroup
            // 
            this.checkPriceGroup.AutoSize = true;
            this.checkPriceGroup.Location = new System.Drawing.Point(6, 19);
            this.checkPriceGroup.Name = "checkPriceGroup";
            this.checkPriceGroup.Size = new System.Drawing.Size(15, 14);
            this.checkPriceGroup.TabIndex = 6;
            this.checkPriceGroup.UseVisualStyleBackColor = true;
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
            this.ItemPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Size = new System.Drawing.Size(1006, 569);
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
            this.ItemsGrid.Size = new System.Drawing.Size(1004, 567);
            this.ItemsGrid.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 681);
            this.Controls.Add(this.buttonTest);
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
            ((System.ComponentModel.ISupportInitialize)(this.weightFrom)).EndInit();
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
        private System.Windows.Forms.RadioButton radioDescening;
        private System.Windows.Forms.RadioButton radioAscending;
        private System.Windows.Forms.Button buttonShowResults;
        private System.Windows.Forms.ComboBox combFieldName;
        private System.Windows.Forms.GroupBox output;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.GroupBox PriceRangeBox;
        private System.Windows.Forms.NumericUpDown priceTo;
        private System.Windows.Forms.NumericUpDown priceFrom;
        private System.Windows.Forms.CheckedListBox checksMakers;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox dateRange;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox weightRange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown weightTo;
        private System.Windows.Forms.NumericUpDown weightFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checksType;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonInspectItem;
        private System.Windows.Forms.Panel ItemPanel;
        private System.Windows.Forms.DataGridView ItemsGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkTypesGroup;
        private System.Windows.Forms.CheckBox checkMakersGroup;
        private System.Windows.Forms.CheckBox checkDateGroup;
        private System.Windows.Forms.CheckBox checkWeightGroup;
        private System.Windows.Forms.CheckBox checkPriceGroup;
        private System.Windows.Forms.Button buttonTest;
    }
}

