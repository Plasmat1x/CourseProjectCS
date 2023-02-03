namespace CourseProject.View
{
    partial class ItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combMaker = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combType = new System.Windows.Forms.ComboBox();
            this.RealeaseDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.ToMakeForm = new System.Windows.Forms.LinkLabel();
            this.ToTypeForm = new System.Windows.Forms.LinkLabel();
            this.btAddItem = new System.Windows.Forms.Button();
            this.btDeleteItem = new System.Windows.Forms.Button();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(64, 6);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(121, 20);
            this.tbId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(64, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(64, 58);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(121, 20);
            this.tbModel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Maker";
            // 
            // combMaker
            // 
            this.combMaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combMaker.FormattingEnabled = true;
            this.combMaker.Location = new System.Drawing.Point(64, 84);
            this.combMaker.Name = "combMaker";
            this.combMaker.Size = new System.Drawing.Size(121, 21);
            this.combMaker.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Type";
            // 
            // combType
            // 
            this.combType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combType.FormattingEnabled = true;
            this.combType.Location = new System.Drawing.Point(64, 111);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(121, 21);
            this.combType.TabIndex = 4;
            // 
            // RealeaseDate
            // 
            this.RealeaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RealeaseDate.Location = new System.Drawing.Point(64, 138);
            this.RealeaseDate.Name = "RealeaseDate";
            this.RealeaseDate.Size = new System.Drawing.Size(121, 20);
            this.RealeaseDate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Release";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Weight";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Price";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(65, 190);
            this.numPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 20);
            this.numPrice.TabIndex = 9;
            // 
            // ToMakeForm
            // 
            this.ToMakeForm.AutoSize = true;
            this.ToMakeForm.Location = new System.Drawing.Point(191, 87);
            this.ToMakeForm.Name = "ToMakeForm";
            this.ToMakeForm.Size = new System.Drawing.Size(81, 13);
            this.ToMakeForm.TabIndex = 10;
            this.ToMakeForm.TabStop = true;
            this.ToMakeForm.Text = "Add new maker";
            this.ToMakeForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ToMakerForm_LinkClicked);
            // 
            // ToTypeForm
            // 
            this.ToTypeForm.AutoSize = true;
            this.ToTypeForm.Location = new System.Drawing.Point(191, 114);
            this.ToTypeForm.Name = "ToTypeForm";
            this.ToTypeForm.Size = new System.Drawing.Size(72, 13);
            this.ToTypeForm.TabIndex = 10;
            this.ToTypeForm.TabStop = true;
            this.ToTypeForm.Text = "Add new type";
            this.ToTypeForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ToTypeForm_LinkClicked);
            // 
            // btAddItem
            // 
            this.btAddItem.Location = new System.Drawing.Point(15, 216);
            this.btAddItem.Name = "btAddItem";
            this.btAddItem.Size = new System.Drawing.Size(75, 23);
            this.btAddItem.TabIndex = 11;
            this.btAddItem.Text = "Add";
            this.btAddItem.UseVisualStyleBackColor = true;
            this.btAddItem.Click += new System.EventHandler(this.btAddItem_Click);
            // 
            // btDeleteItem
            // 
            this.btDeleteItem.Location = new System.Drawing.Point(96, 216);
            this.btDeleteItem.Name = "btDeleteItem";
            this.btDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.btDeleteItem.TabIndex = 12;
            this.btDeleteItem.Text = "Delete";
            this.btDeleteItem.UseVisualStyleBackColor = true;
            this.btDeleteItem.Click += new System.EventHandler(this.btDeleteItem_Click);
            // 
            // numWeight
            // 
            this.numWeight.Location = new System.Drawing.Point(65, 164);
            this.numWeight.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(120, 20);
            this.numWeight.TabIndex = 13;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 243);
            this.Controls.Add(this.numWeight);
            this.Controls.Add(this.btDeleteItem);
            this.Controls.Add(this.btAddItem);
            this.Controls.Add(this.ToTypeForm);
            this.Controls.Add(this.ToMakeForm);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RealeaseDate);
            this.Controls.Add(this.combType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combMaker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemForm";
            this.Text = "NewItem";
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combMaker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.DateTimePicker RealeaseDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.LinkLabel ToMakeForm;
        private System.Windows.Forms.LinkLabel ToTypeForm;
        private System.Windows.Forms.Button btAddItem;
        private System.Windows.Forms.Button btDeleteItem;
        private System.Windows.Forms.NumericUpDown numWeight;
    }
}