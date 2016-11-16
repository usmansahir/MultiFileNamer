namespace MultiFileNamer
{
    partial class SelectorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectorForm));
            this.ReNameButton = new System.Windows.Forms.Button();
            this.FileTreeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.NumericChange = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.IncrementButton = new System.Windows.Forms.RadioButton();
            this.DecrementButton = new System.Windows.Forms.RadioButton();
            this.NewNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.RadioBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumericStartNumber = new System.Windows.Forms.NumericUpDown();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ListViewBox = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.NumericChange)).BeginInit();
            this.RadioBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStartNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReNameButton
            // 
            this.ReNameButton.Enabled = false;
            this.ReNameButton.Location = new System.Drawing.Point(217, 439);
            this.ReNameButton.Name = "ReNameButton";
            this.ReNameButton.Size = new System.Drawing.Size(238, 48);
            this.ReNameButton.TabIndex = 1;
            this.ReNameButton.Text = "Re-Name";
            this.ReNameButton.UseVisualStyleBackColor = true;
            this.ReNameButton.Click += new System.EventHandler(this.ReNameButton_Click);
            // 
            // FileTreeView
            // 
            this.FileTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileTreeView.ImageIndex = 0;
            this.FileTreeView.ImageList = this.imageList1;
            this.FileTreeView.Location = new System.Drawing.Point(0, 0);
            this.FileTreeView.Name = "FileTreeView";
            this.FileTreeView.SelectedImageIndex = 0;
            this.FileTreeView.Size = new System.Drawing.Size(203, 284);
            this.FileTreeView.TabIndex = 2;
            this.FileTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.FileTreeView_BeforeExpand);
            this.FileTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FileTreeView_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.gif");
            this.imageList1.Images.SetKeyName(1, "dir_file_pic.png");
            // 
            // NumericChange
            // 
            this.NumericChange.Location = new System.Drawing.Point(510, 350);
            this.NumericChange.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericChange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericChange.Name = "NumericChange";
            this.NumericChange.Size = new System.Drawing.Size(120, 22);
            this.NumericChange.TabIndex = 3;
            this.NumericChange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Change Number By:";
            // 
            // IncrementButton
            // 
            this.IncrementButton.AutoSize = true;
            this.IncrementButton.Checked = true;
            this.IncrementButton.Location = new System.Drawing.Point(27, 26);
            this.IncrementButton.Name = "IncrementButton";
            this.IncrementButton.Size = new System.Drawing.Size(91, 21);
            this.IncrementButton.TabIndex = 5;
            this.IncrementButton.TabStop = true;
            this.IncrementButton.Text = "Increment";
            this.IncrementButton.UseVisualStyleBackColor = true;
            // 
            // DecrementButton
            // 
            this.DecrementButton.AutoSize = true;
            this.DecrementButton.Location = new System.Drawing.Point(124, 26);
            this.DecrementButton.Name = "DecrementButton";
            this.DecrementButton.Size = new System.Drawing.Size(98, 21);
            this.DecrementButton.TabIndex = 6;
            this.DecrementButton.Text = "Decrement";
            this.DecrementButton.UseVisualStyleBackColor = true;
            // 
            // NewNameBox
            // 
            this.NewNameBox.Location = new System.Drawing.Point(132, 352);
            this.NewNameBox.Name = "NewNameBox";
            this.NewNameBox.Size = new System.Drawing.Size(195, 22);
            this.NewNameBox.TabIndex = 7;
            this.NewNameBox.TextChanged += new System.EventHandler(this.NewNameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Name:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(408, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Toggle All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RadioBox
            // 
            this.RadioBox.Controls.Add(this.DecrementButton);
            this.RadioBox.Controls.Add(this.IncrementButton);
            this.RadioBox.Location = new System.Drawing.Point(372, 378);
            this.RadioBox.Name = "RadioBox";
            this.RadioBox.Size = new System.Drawing.Size(256, 52);
            this.RadioBox.TabIndex = 10;
            this.RadioBox.TabStop = false;
            this.RadioBox.Text = "Number Change:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Starting Number:";
            // 
            // NumericStartNumber
            // 
            this.NumericStartNumber.Location = new System.Drawing.Point(132, 378);
            this.NumericStartNumber.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumericStartNumber.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.NumericStartNumber.Name = "NumericStartNumber";
            this.NumericStartNumber.Size = new System.Drawing.Size(195, 22);
            this.NumericStartNumber.TabIndex = 12;
            this.NumericStartNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(15, 25);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.FileTreeView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ListViewBox);
            this.splitContainer2.Size = new System.Drawing.Size(610, 284);
            this.splitContainer2.SplitterDistance = 203;
            this.splitContainer2.TabIndex = 14;
            // 
            // ListViewBox
            // 
            this.ListViewBox.CheckBoxes = true;
            this.ListViewBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ListViewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewBox.HideSelection = false;
            this.ListViewBox.Location = new System.Drawing.Point(0, 0);
            this.ListViewBox.Name = "ListViewBox";
            this.ListViewBox.Size = new System.Drawing.Size(403, 284);
            this.ListViewBox.SmallImageList = this.imageList1;
            this.ListViewBox.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListViewBox.TabIndex = 0;
            this.ListViewBox.UseCompatibleStateImageBehavior = false;
            this.ListViewBox.View = System.Windows.Forms.View.Details;
            this.ListViewBox.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListViewBox_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Files";
            this.columnHeader1.Width = 400;
            // 
            // SelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(642, 491);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.NumericStartNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RadioBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericChange);
            this.Controls.Add(this.ReNameButton);
            this.DoubleBuffered = true;
            this.Name = "SelectorForm";
            this.Text = "Select Files to Re-Name";
            ((System.ComponentModel.ISupportInitialize)(this.NumericChange)).EndInit();
            this.RadioBox.ResumeLayout(false);
            this.RadioBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStartNumber)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ReNameButton;
        private System.Windows.Forms.TreeView FileTreeView;
        private System.Windows.Forms.NumericUpDown NumericChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton IncrementButton;
        private System.Windows.Forms.RadioButton DecrementButton;
        private System.Windows.Forms.TextBox NewNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox RadioBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumericStartNumber;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView ListViewBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

