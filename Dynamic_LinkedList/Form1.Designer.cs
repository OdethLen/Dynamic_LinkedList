namespace Dynamic_LinkedList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNumber = new TextBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnCount = new Button();
            lstvNumbers = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 98);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Number";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(129, 90);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 1;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(72, 136);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(88, 32);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(72, 174);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 32);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(176, 136);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 32);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(176, 174);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(88, 32);
            btnCount.TabIndex = 5;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // lstvNumbers
            // 
            lstvNumbers.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstvNumbers.ForeColor = Color.Black;
            lstvNumbers.FormattingEnabled = true;
            lstvNumbers.ItemHeight = 20;
            lstvNumbers.Location = new Point(321, 71);
            lstvNumbers.Name = "lstvNumbers";
            lstvNumbers.ScrollAlwaysVisible = true;
            lstvNumbers.Size = new Size(270, 144);
            lstvNumbers.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 266);
            Controls.Add(lstvNumbers);
            Controls.Add(btnCount);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(txtNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumber;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnCount;
        private ListBox lstvNumbers;
    }
}
