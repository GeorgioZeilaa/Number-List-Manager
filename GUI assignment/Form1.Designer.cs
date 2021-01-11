namespace GUI_assignment
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
            this.lstbox_30int = new System.Windows.Forms.ListBox();
            this.grpsort = new System.Windows.Forms.GroupBox();
            this.radUnsorted = new System.Windows.Forms.RadioButton();
            this.radSorted = new System.Windows.Forms.RadioButton();
            this.radLinear = new System.Windows.Forms.RadioButton();
            this.radBinary = new System.Windows.Forms.RadioButton();
            this.grpsearch = new System.Windows.Forms.GroupBox();
            this.btnInitialise = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblInsert = new System.Windows.Forms.Label();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtFirstValue = new System.Windows.Forms.TextBox();
            this.lblFirstValue = new System.Windows.Forms.Label();
            this.txtLastValue = new System.Windows.Forms.TextBox();
            this.lbLastValue = new System.Windows.Forms.Label();
            this.txtMinimum = new System.Windows.Forms.TextBox();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.txtMaximumValues = new System.Windows.Forms.TextBox();
            this.lblMaximumValues = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMaximumEnteries = new System.Windows.Forms.Label();
            this.txtMaxiumEnteries = new System.Windows.Forms.TextBox();
            this.picRecycle = new System.Windows.Forms.PictureBox();
            this.grpboxbuttons = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpboxStats = new System.Windows.Forms.GroupBox();
            this.grpboxSearch = new System.Windows.Forms.GroupBox();
            this.grpboxInsert = new System.Windows.Forms.GroupBox();
            this.grpsort.SuspendLayout();
            this.grpsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRecycle)).BeginInit();
            this.grpboxbuttons.SuspendLayout();
            this.grpboxStats.SuspendLayout();
            this.grpboxSearch.SuspendLayout();
            this.grpboxInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbox_30int
            // 
            this.lstbox_30int.FormattingEnabled = true;
            this.lstbox_30int.HorizontalScrollbar = true;
            this.lstbox_30int.Location = new System.Drawing.Point(277, 3);
            this.lstbox_30int.Name = "lstbox_30int";
            this.lstbox_30int.Size = new System.Drawing.Size(80, 303);
            this.lstbox_30int.TabIndex = 0;
            this.lstbox_30int.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstbox_30int_MouseDown);
            // 
            // grpsort
            // 
            this.grpsort.Controls.Add(this.radUnsorted);
            this.grpsort.Controls.Add(this.radSorted);
            this.grpsort.Location = new System.Drawing.Point(112, -2);
            this.grpsort.Name = "grpsort";
            this.grpsort.Size = new System.Drawing.Size(104, 55);
            this.grpsort.TabIndex = 1;
            this.grpsort.TabStop = false;
            // 
            // radUnsorted
            // 
            this.radUnsorted.AutoSize = true;
            this.radUnsorted.Location = new System.Drawing.Point(21, 13);
            this.radUnsorted.Name = "radUnsorted";
            this.radUnsorted.Size = new System.Drawing.Size(68, 17);
            this.radUnsorted.TabIndex = 1;
            this.radUnsorted.Text = "Unsorted";
            this.radUnsorted.UseVisualStyleBackColor = true;
            this.radUnsorted.Click += new System.EventHandler(this.radUnsorted_Click);
            // 
            // radSorted
            // 
            this.radSorted.AutoSize = true;
            this.radSorted.Location = new System.Drawing.Point(21, 32);
            this.radSorted.Name = "radSorted";
            this.radSorted.Size = new System.Drawing.Size(56, 17);
            this.radSorted.TabIndex = 0;
            this.radSorted.Text = "Sorted";
            this.radSorted.UseVisualStyleBackColor = true;
            this.radSorted.Click += new System.EventHandler(this.radSorted_Click);
            // 
            // radLinear
            // 
            this.radLinear.AutoSize = true;
            this.radLinear.Location = new System.Drawing.Point(25, 13);
            this.radLinear.Name = "radLinear";
            this.radLinear.Size = new System.Drawing.Size(54, 17);
            this.radLinear.TabIndex = 2;
            this.radLinear.Text = "Linear";
            this.radLinear.UseVisualStyleBackColor = true;
            // 
            // radBinary
            // 
            this.radBinary.AutoSize = true;
            this.radBinary.Location = new System.Drawing.Point(25, 32);
            this.radBinary.Name = "radBinary";
            this.radBinary.Size = new System.Drawing.Size(54, 17);
            this.radBinary.TabIndex = 3;
            this.radBinary.Text = "Binary";
            this.radBinary.UseVisualStyleBackColor = true;
            // 
            // grpsearch
            // 
            this.grpsearch.Controls.Add(this.radLinear);
            this.grpsearch.Controls.Add(this.radBinary);
            this.grpsearch.Location = new System.Drawing.Point(7, -2);
            this.grpsearch.Name = "grpsearch";
            this.grpsearch.Size = new System.Drawing.Size(99, 55);
            this.grpsearch.TabIndex = 4;
            this.grpsearch.TabStop = false;
            // 
            // btnInitialise
            // 
            this.btnInitialise.Location = new System.Drawing.Point(19, 9);
            this.btnInitialise.Name = "btnInitialise";
            this.btnInitialise.Size = new System.Drawing.Size(75, 23);
            this.btnInitialise.TabIndex = 5;
            this.btnInitialise.Text = "Initialise";
            this.btnInitialise.UseVisualStyleBackColor = true;
            this.btnInitialise.Click += new System.EventHandler(this.btnInitialise_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(19, 56);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(19, 32);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(75, 23);
            this.btnShuffle.TabIndex = 7;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(19, 81);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(56, 29);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(57, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(277, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 29);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(46, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(94, 20);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(2, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search:";
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.Location = new System.Drawing.Point(3, 11);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(36, 13);
            this.lblInsert.TabIndex = 15;
            this.lblInsert.Text = "Insert:";
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(45, 9);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(94, 20);
            this.txtInsert.TabIndex = 14;
            this.txtInsert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInsert_KeyDown);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(6, 32);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(120, 13);
            this.lblCount.TabIndex = 16;
            this.lblCount.Text = "Count Of Active Entries:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(158, 29);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(92, 20);
            this.txtCount.TabIndex = 17;
            // 
            // txtFirstValue
            // 
            this.txtFirstValue.Location = new System.Drawing.Point(158, 55);
            this.txtFirstValue.Name = "txtFirstValue";
            this.txtFirstValue.Size = new System.Drawing.Size(92, 20);
            this.txtFirstValue.TabIndex = 19;
            // 
            // lblFirstValue
            // 
            this.lblFirstValue.AutoSize = true;
            this.lblFirstValue.Location = new System.Drawing.Point(6, 58);
            this.lblFirstValue.Name = "lblFirstValue";
            this.lblFirstValue.Size = new System.Drawing.Size(120, 13);
            this.lblFirstValue.TabIndex = 18;
            this.lblFirstValue.Text = "First Value of First Entry:";
            // 
            // txtLastValue
            // 
            this.txtLastValue.Location = new System.Drawing.Point(158, 81);
            this.txtLastValue.Name = "txtLastValue";
            this.txtLastValue.Size = new System.Drawing.Size(92, 20);
            this.txtLastValue.TabIndex = 21;
            // 
            // lbLastValue
            // 
            this.lbLastValue.AutoSize = true;
            this.lbLastValue.Location = new System.Drawing.Point(6, 84);
            this.lbLastValue.Name = "lbLastValue";
            this.lbLastValue.Size = new System.Drawing.Size(122, 13);
            this.lbLastValue.TabIndex = 20;
            this.lbLastValue.Text = "Last Value of Last Entry:";
            // 
            // txtMinimum
            // 
            this.txtMinimum.Location = new System.Drawing.Point(158, 107);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.Size = new System.Drawing.Size(92, 20);
            this.txtMinimum.TabIndex = 23;
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(6, 113);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(104, 13);
            this.lblMinimum.TabIndex = 22;
            this.lblMinimum.Text = "Minimum of The List:";
            // 
            // txtMaximumValues
            // 
            this.txtMaximumValues.Location = new System.Drawing.Point(158, 133);
            this.txtMaximumValues.Name = "txtMaximumValues";
            this.txtMaximumValues.Size = new System.Drawing.Size(92, 20);
            this.txtMaximumValues.TabIndex = 25;
            // 
            // lblMaximumValues
            // 
            this.lblMaximumValues.AutoSize = true;
            this.lblMaximumValues.Location = new System.Drawing.Point(6, 136);
            this.lblMaximumValues.Name = "lblMaximumValues";
            this.lblMaximumValues.Size = new System.Drawing.Size(128, 13);
            this.lblMaximumValues.TabIndex = 24;
            this.lblMaximumValues.Text = "Maximum value of the list:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 28;
            // 
            // lblMaximumEnteries
            // 
            this.lblMaximumEnteries.AutoSize = true;
            this.lblMaximumEnteries.Location = new System.Drawing.Point(6, 162);
            this.lblMaximumEnteries.Name = "lblMaximumEnteries";
            this.lblMaximumEnteries.Size = new System.Drawing.Size(134, 13);
            this.lblMaximumEnteries.TabIndex = 29;
            this.lblMaximumEnteries.Text = "Maximum entries permitted:";
            // 
            // txtMaxiumEnteries
            // 
            this.txtMaxiumEnteries.Location = new System.Drawing.Point(158, 159);
            this.txtMaxiumEnteries.Name = "txtMaxiumEnteries";
            this.txtMaxiumEnteries.Size = new System.Drawing.Size(92, 20);
            this.txtMaxiumEnteries.TabIndex = 30;
            // 
            // picRecycle
            // 
            this.picRecycle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRecycle.Image = global::GUI_assignment.Properties.Resources.recyclebin;
            this.picRecycle.Location = new System.Drawing.Point(222, 4);
            this.picRecycle.Name = "picRecycle";
            this.picRecycle.Size = new System.Drawing.Size(49, 49);
            this.picRecycle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRecycle.TabIndex = 31;
            this.picRecycle.TabStop = false;
            this.picRecycle.DragDrop += new System.Windows.Forms.DragEventHandler(this.picRecycle_DragDrop);
            this.picRecycle.DragEnter += new System.Windows.Forms.DragEventHandler(this.picRecycle_DragEnter);
            // 
            // grpboxbuttons
            // 
            this.grpboxbuttons.Controls.Add(this.btnInitialise);
            this.grpboxbuttons.Controls.Add(this.btnShuffle);
            this.grpboxbuttons.Controls.Add(this.btnClear);
            this.grpboxbuttons.Controls.Add(this.btnDelete);
            this.grpboxbuttons.Location = new System.Drawing.Point(157, 53);
            this.grpboxbuttons.Name = "grpboxbuttons";
            this.grpboxbuttons.Size = new System.Drawing.Size(113, 107);
            this.grpboxbuttons.TabIndex = 32;
            this.grpboxbuttons.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Statistics:";
            // 
            // grpboxStats
            // 
            this.grpboxStats.Controls.Add(this.txtCount);
            this.grpboxStats.Controls.Add(this.label1);
            this.grpboxStats.Controls.Add(this.lblCount);
            this.grpboxStats.Controls.Add(this.lblFirstValue);
            this.grpboxStats.Controls.Add(this.txtFirstValue);
            this.grpboxStats.Controls.Add(this.txtMaxiumEnteries);
            this.grpboxStats.Controls.Add(this.lbLastValue);
            this.grpboxStats.Controls.Add(this.lblMaximumEnteries);
            this.grpboxStats.Controls.Add(this.txtLastValue);
            this.grpboxStats.Controls.Add(this.lblMinimum);
            this.grpboxStats.Controls.Add(this.txtMinimum);
            this.grpboxStats.Controls.Add(this.txtMaximumValues);
            this.grpboxStats.Controls.Add(this.lblMaximumValues);
            this.grpboxStats.Location = new System.Drawing.Point(7, 158);
            this.grpboxStats.Name = "grpboxStats";
            this.grpboxStats.Size = new System.Drawing.Size(264, 183);
            this.grpboxStats.TabIndex = 34;
            this.grpboxStats.TabStop = false;
            // 
            // grpboxSearch
            // 
            this.grpboxSearch.Controls.Add(this.txtSearch);
            this.grpboxSearch.Controls.Add(this.btnSearch);
            this.grpboxSearch.Controls.Add(this.lblSearch);
            this.grpboxSearch.Location = new System.Drawing.Point(7, 53);
            this.grpboxSearch.Name = "grpboxSearch";
            this.grpboxSearch.Size = new System.Drawing.Size(145, 54);
            this.grpboxSearch.TabIndex = 35;
            this.grpboxSearch.TabStop = false;
            // 
            // grpboxInsert
            // 
            this.grpboxInsert.Controls.Add(this.txtInsert);
            this.grpboxInsert.Controls.Add(this.btnInsert);
            this.grpboxInsert.Controls.Add(this.lblInsert);
            this.grpboxInsert.Location = new System.Drawing.Point(8, 106);
            this.grpboxInsert.Name = "grpboxInsert";
            this.grpboxInsert.Size = new System.Drawing.Size(144, 54);
            this.grpboxInsert.TabIndex = 36;
            this.grpboxInsert.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 346);
            this.Controls.Add(this.grpboxInsert);
            this.Controls.Add(this.grpboxSearch);
            this.Controls.Add(this.grpboxStats);
            this.Controls.Add(this.grpboxbuttons);
            this.Controls.Add(this.picRecycle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpsearch);
            this.Controls.Add(this.grpsort);
            this.Controls.Add(this.lstbox_30int);
            this.Name = "Form1";
            this.Text = "Number List Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpsort.ResumeLayout(false);
            this.grpsort.PerformLayout();
            this.grpsearch.ResumeLayout(false);
            this.grpsearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRecycle)).EndInit();
            this.grpboxbuttons.ResumeLayout(false);
            this.grpboxStats.ResumeLayout(false);
            this.grpboxStats.PerformLayout();
            this.grpboxSearch.ResumeLayout(false);
            this.grpboxSearch.PerformLayout();
            this.grpboxInsert.ResumeLayout(false);
            this.grpboxInsert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbox_30int;
        private System.Windows.Forms.GroupBox grpsort;
        private System.Windows.Forms.RadioButton radUnsorted;
        private System.Windows.Forms.RadioButton radSorted;
        private System.Windows.Forms.RadioButton radLinear;
        private System.Windows.Forms.RadioButton radBinary;
        private System.Windows.Forms.GroupBox grpsearch;
        private System.Windows.Forms.Button btnInitialise;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtFirstValue;
        private System.Windows.Forms.Label lblFirstValue;
        private System.Windows.Forms.TextBox txtLastValue;
        private System.Windows.Forms.Label lbLastValue;
        private System.Windows.Forms.TextBox txtMinimum;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.TextBox txtMaximumValues;
        private System.Windows.Forms.Label lblMaximumValues;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMaximumEnteries;
        private System.Windows.Forms.TextBox txtMaxiumEnteries;
        private System.Windows.Forms.PictureBox picRecycle;
        private System.Windows.Forms.GroupBox grpboxbuttons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpboxStats;
        private System.Windows.Forms.GroupBox grpboxSearch;
        private System.Windows.Forms.GroupBox grpboxInsert;
    }
}

