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
            this.SortGB = new System.Windows.Forms.GroupBox();
            this.rbDescening = new System.Windows.Forms.RadioButton();
            this.rbAscending = new System.Windows.Forms.RadioButton();
            this.showBT = new System.Windows.Forms.Button();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.ShowGB = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tablegrid)).BeginInit();
            this.SortGB.SuspendLayout();
            this.ShowGB.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // SortGB
            // 
            this.SortGB.AutoSize = true;
            this.SortGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SortGB.Controls.Add(this.rbDescening);
            this.SortGB.Controls.Add(this.rbAscending);
            this.SortGB.Location = new System.Drawing.Point(6, 48);
            this.SortGB.Name = "SortGB";
            this.SortGB.Size = new System.Drawing.Size(104, 78);
            this.SortGB.TabIndex = 1;
            this.SortGB.TabStop = false;
            this.SortGB.Text = "Сортировка по";
            // 
            // rbDescening
            // 
            this.rbDescening.AutoSize = true;
            this.rbDescening.Location = new System.Drawing.Point(6, 42);
            this.rbDescening.Name = "rbDescening";
            this.rbDescening.Size = new System.Drawing.Size(76, 17);
            this.rbDescening.TabIndex = 1;
            this.rbDescening.Text = "убыванию";
            this.rbDescening.UseVisualStyleBackColor = true;
            // 
            // rbAscending
            // 
            this.rbAscending.AutoSize = true;
            this.rbAscending.Checked = true;
            this.rbAscending.Location = new System.Drawing.Point(6, 19);
            this.rbAscending.Name = "rbAscending";
            this.rbAscending.Size = new System.Drawing.Size(92, 17);
            this.rbAscending.TabIndex = 0;
            this.rbAscending.TabStop = true;
            this.rbAscending.Text = "возростанию";
            this.rbAscending.UseVisualStyleBackColor = true;
            // 
            // showBT
            // 
            this.showBT.Location = new System.Drawing.Point(133, 19);
            this.showBT.Name = "showBT";
            this.showBT.Size = new System.Drawing.Size(75, 23);
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
            this.categoryCB.Size = new System.Drawing.Size(121, 21);
            this.categoryCB.TabIndex = 3;
            // 
            // ShowGB
            // 
            this.ShowGB.AutoSize = true;
            this.ShowGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowGB.Controls.Add(this.categoryCB);
            this.ShowGB.Controls.Add(this.SortGB);
            this.ShowGB.Controls.Add(this.showBT);
            this.ShowGB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShowGB.Location = new System.Drawing.Point(0, 534);
            this.ShowGB.Name = "ShowGB";
            this.ShowGB.Size = new System.Drawing.Size(221, 145);
            this.ShowGB.TabIndex = 4;
            this.ShowGB.TabStop = false;
            this.ShowGB.Text = "Вывод";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ShowGB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1041, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 681);
            this.panel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tablegrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.tablegrid)).EndInit();
            this.SortGB.ResumeLayout(false);
            this.SortGB.PerformLayout();
            this.ShowGB.ResumeLayout(false);
            this.ShowGB.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablegrid;
        private System.Windows.Forms.GroupBox SortGB;
        private System.Windows.Forms.RadioButton rbDescening;
        private System.Windows.Forms.RadioButton rbAscending;
        private System.Windows.Forms.Button showBT;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.GroupBox ShowGB;
        private System.Windows.Forms.Panel panel1;
    }
}

