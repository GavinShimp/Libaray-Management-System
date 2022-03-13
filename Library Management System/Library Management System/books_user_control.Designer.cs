namespace Library_Management_System
{
    partial class books_user_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.search_books_button = new System.Windows.Forms.Button();
            this.book_id_label = new System.Windows.Forms.Label();
            this.book_id_input = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accession_number_label = new System.Windows.Forms.Label();
            this.accession_num_input = new System.Windows.Forms.TextBox();
            this.publisher_label = new System.Windows.Forms.Label();
            this.publisher_input = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.isbn_label = new System.Windows.Forms.Label();
            this.ibsn_input = new System.Windows.Forms.TextBox();
            this.author_label = new System.Windows.Forms.Label();
            this.author_input = new System.Windows.Forms.TextBox();
            this.add_new_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.department_id_label = new System.Windows.Forms.Label();
            this.department_id_input = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // search_books_button
            // 
            this.search_books_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(150)))));
            this.search_books_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.search_books_button.ForeColor = System.Drawing.Color.White;
            this.search_books_button.Location = new System.Drawing.Point(502, 92);
            this.search_books_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_books_button.Name = "search_books_button";
            this.search_books_button.Size = new System.Drawing.Size(252, 74);
            this.search_books_button.TabIndex = 7;
            this.search_books_button.Text = "Search Books";
            this.search_books_button.UseVisualStyleBackColor = false;
            this.search_books_button.Click += new System.EventHandler(this.search_books_button_Click);
            // 
            // book_id_label
            // 
            this.book_id_label.AutoSize = true;
            this.book_id_label.Location = new System.Drawing.Point(515, 51);
            this.book_id_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.book_id_label.Name = "book_id_label";
            this.book_id_label.Size = new System.Drawing.Size(71, 20);
            this.book_id_label.TabIndex = 6;
            this.book_id_label.Text = "Book ID:";
            // 
            // book_id_input
            // 
            this.book_id_input.Location = new System.Drawing.Point(594, 48);
            this.book_id_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.book_id_input.Name = "book_id_input";
            this.book_id_input.Size = new System.Drawing.Size(148, 26);
            this.book_id_input.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(104, 202);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 286);
            this.dataGridView1.TabIndex = 4;
            // 
            // accession_number_label
            // 
            this.accession_number_label.AutoSize = true;
            this.accession_number_label.Location = new System.Drawing.Point(380, 641);
            this.accession_number_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accession_number_label.Name = "accession_number_label";
            this.accession_number_label.Size = new System.Drawing.Size(64, 20);
            this.accession_number_label.TabIndex = 9;
            this.accession_number_label.Text = "Acc No:";
            this.accession_number_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // accession_num_input
            // 
            this.accession_num_input.Location = new System.Drawing.Point(452, 638);
            this.accession_num_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accession_num_input.Name = "accession_num_input";
            this.accession_num_input.Size = new System.Drawing.Size(148, 26);
            this.accession_num_input.TabIndex = 8;
            this.accession_num_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // publisher_label
            // 
            this.publisher_label.AutoSize = true;
            this.publisher_label.Location = new System.Drawing.Point(641, 705);
            this.publisher_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.publisher_label.Name = "publisher_label";
            this.publisher_label.Size = new System.Drawing.Size(78, 20);
            this.publisher_label.TabIndex = 11;
            this.publisher_label.Text = "Publisher:";
            // 
            // publisher_input
            // 
            this.publisher_input.Location = new System.Drawing.Point(727, 705);
            this.publisher_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.publisher_input.Name = "publisher_input";
            this.publisher_input.Size = new System.Drawing.Size(148, 26);
            this.publisher_input.TabIndex = 10;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(663, 641);
            this.name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(55, 20);
            this.name_label.TabIndex = 13;
            this.name_label.Text = "Name:";
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(727, 635);
            this.name_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(148, 26);
            this.name_input.TabIndex = 12;
            // 
            // isbn_label
            // 
            this.isbn_label.AutoSize = true;
            this.isbn_label.Location = new System.Drawing.Point(393, 711);
            this.isbn_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isbn_label.Name = "isbn_label";
            this.isbn_label.Size = new System.Drawing.Size(51, 20);
            this.isbn_label.TabIndex = 15;
            this.isbn_label.Text = "ISBN:";
            // 
            // ibsn_input
            // 
            this.ibsn_input.Location = new System.Drawing.Point(452, 705);
            this.ibsn_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ibsn_input.Name = "ibsn_input";
            this.ibsn_input.Size = new System.Drawing.Size(148, 26);
            this.ibsn_input.TabIndex = 14;
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.Location = new System.Drawing.Point(657, 771);
            this.author_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(61, 20);
            this.author_label.TabIndex = 17;
            this.author_label.Text = "Author:";
            // 
            // author_input
            // 
            this.author_input.Location = new System.Drawing.Point(727, 771);
            this.author_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.author_input.Name = "author_input";
            this.author_input.Size = new System.Drawing.Size(148, 26);
            this.author_input.TabIndex = 16;
            // 
            // add_new_button
            // 
            this.add_new_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(150)))));
            this.add_new_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.add_new_button.ForeColor = System.Drawing.Color.White;
            this.add_new_button.Location = new System.Drawing.Point(315, 515);
            this.add_new_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_new_button.Name = "add_new_button";
            this.add_new_button.Size = new System.Drawing.Size(186, 74);
            this.add_new_button.TabIndex = 19;
            this.add_new_button.Text = "Add New";
            this.add_new_button.UseVisualStyleBackColor = false;
            this.add_new_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(150)))));
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delete_button.ForeColor = System.Drawing.Color.White;
            this.delete_button.Location = new System.Drawing.Point(550, 515);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(186, 74);
            this.delete_button.TabIndex = 20;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(150)))));
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clear_button.ForeColor = System.Drawing.Color.White;
            this.clear_button.Location = new System.Drawing.Point(783, 515);
            this.clear_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(186, 74);
            this.clear_button.TabIndex = 21;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // department_id_label
            // 
            this.department_id_label.AutoSize = true;
            this.department_id_label.Location = new System.Drawing.Point(325, 774);
            this.department_id_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.department_id_label.Name = "department_id_label";
            this.department_id_label.Size = new System.Drawing.Size(119, 20);
            this.department_id_label.TabIndex = 23;
            this.department_id_label.Text = "Department ID:";
            this.department_id_label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // department_id_input
            // 
            this.department_id_input.Location = new System.Drawing.Point(452, 771);
            this.department_id_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.department_id_input.Name = "department_id_input";
            this.department_id_input.Size = new System.Drawing.Size(148, 26);
            this.department_id_input.TabIndex = 22;
            // 
            // books_user_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.department_id_label);
            this.Controls.Add(this.department_id_input);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_new_button);
            this.Controls.Add(this.author_label);
            this.Controls.Add(this.author_input);
            this.Controls.Add(this.isbn_label);
            this.Controls.Add(this.ibsn_input);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.publisher_label);
            this.Controls.Add(this.publisher_input);
            this.Controls.Add(this.accession_number_label);
            this.Controls.Add(this.accession_num_input);
            this.Controls.Add(this.search_books_button);
            this.Controls.Add(this.book_id_label);
            this.Controls.Add(this.book_id_input);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "books_user_control";
            this.Size = new System.Drawing.Size(1280, 868);
            this.Load += new System.EventHandler(this.books_user_control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_books_button;
        private System.Windows.Forms.Label book_id_label;
        private System.Windows.Forms.TextBox book_id_input;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label accession_number_label;
        private System.Windows.Forms.TextBox accession_num_input;
        private System.Windows.Forms.Label publisher_label;
        private System.Windows.Forms.TextBox publisher_input;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label isbn_label;
        private System.Windows.Forms.TextBox ibsn_input;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.TextBox author_input;
        private System.Windows.Forms.Button add_new_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label department_id_label;
        private System.Windows.Forms.TextBox department_id_input;
    }
}
