namespace Library_Management_System
{
    partial class AppBody
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
            this.login_timer = new System.Windows.Forms.Timer(this.components);
            this.title_bar = new System.Windows.Forms.Panel();
            this.minimize_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.sliding_panel = new System.Windows.Forms.Panel();
            this.about_tab_button = new System.Windows.Forms.Button();
            this.transaction_tab_button = new System.Windows.Forms.Button();
            this.books_tab_button = new System.Windows.Forms.Button();
            this.borrowers_tab_button = new System.Windows.Forms.Button();
            this.sliding_panel_toggle = new System.Windows.Forms.Button();
            this.sliding_panel_timer = new System.Windows.Forms.Timer(this.components);
            this.content_panel = new System.Windows.Forms.Panel();
            this.title_bar.SuspendLayout();
            this.sliding_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_timer
            // 
            this.login_timer.Interval = 20;
            this.login_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // title_bar
            // 
            this.title_bar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.title_bar.Controls.Add(this.minimize_button);
            this.title_bar.Controls.Add(this.exit_button);
            this.title_bar.Controls.Add(this.logout_button);
            this.title_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_bar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.title_bar.Location = new System.Drawing.Point(0, 0);
            this.title_bar.Name = "title_bar";
            this.title_bar.Size = new System.Drawing.Size(1000, 36);
            this.title_bar.TabIndex = 0;
            this.title_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseDown);
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.minimize_button.BackgroundImage = global::Library_Management_System.Properties.Resources.minimize_icon;
            this.minimize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.minimize_button.Location = new System.Drawing.Point(924, 2);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(33, 32);
            this.minimize_button.TabIndex = 4;
            this.minimize_button.UseVisualStyleBackColor = false;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click_1);
            // 
            // exit_button
            // 
            this.exit_button.BackgroundImage = global::Library_Management_System.Properties.Resources.exit_icon;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit_button.Location = new System.Drawing.Point(964, 2);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(33, 32);
            this.exit_button.TabIndex = 3;
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.BackgroundImage = global::Library_Management_System.Properties.Resources.sign_out_icon;
            this.logout_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.logout_button.Location = new System.Drawing.Point(884, 3);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(29, 29);
            this.logout_button.TabIndex = 3;
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // sliding_panel
            // 
            this.sliding_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.sliding_panel.Controls.Add(this.about_tab_button);
            this.sliding_panel.Controls.Add(this.transaction_tab_button);
            this.sliding_panel.Controls.Add(this.books_tab_button);
            this.sliding_panel.Controls.Add(this.borrowers_tab_button);
            this.sliding_panel.Controls.Add(this.sliding_panel_toggle);
            this.sliding_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sliding_panel.Location = new System.Drawing.Point(0, 36);
            this.sliding_panel.Margin = new System.Windows.Forms.Padding(2);
            this.sliding_panel.Name = "sliding_panel";
            this.sliding_panel.Size = new System.Drawing.Size(150, 564);
            this.sliding_panel.TabIndex = 1;
            // 
            // about_tab_button
            // 
            this.about_tab_button.BackColor = System.Drawing.Color.Transparent;
            this.about_tab_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_tab_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.about_tab_button.Image = global::Library_Management_System.Properties.Resources.about_icon;
            this.about_tab_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.about_tab_button.Location = new System.Drawing.Point(0, 200);
            this.about_tab_button.Margin = new System.Windows.Forms.Padding(2);
            this.about_tab_button.Name = "about_tab_button";
            this.about_tab_button.Size = new System.Drawing.Size(150, 50);
            this.about_tab_button.TabIndex = 5;
            this.about_tab_button.Text = "ABOUT";
            this.about_tab_button.UseVisualStyleBackColor = false;
            this.about_tab_button.Click += new System.EventHandler(this.about_tab_button_Click);
            // 
            // transaction_tab_button
            // 
            this.transaction_tab_button.BackColor = System.Drawing.Color.Transparent;
            this.transaction_tab_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaction_tab_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.transaction_tab_button.Image = global::Library_Management_System.Properties.Resources.transactions_icon;
            this.transaction_tab_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transaction_tab_button.Location = new System.Drawing.Point(0, 150);
            this.transaction_tab_button.Margin = new System.Windows.Forms.Padding(2);
            this.transaction_tab_button.Name = "transaction_tab_button";
            this.transaction_tab_button.Size = new System.Drawing.Size(150, 50);
            this.transaction_tab_button.TabIndex = 4;
            this.transaction_tab_button.Text = "TRANSACTIONS";
            this.transaction_tab_button.UseVisualStyleBackColor = false;
            this.transaction_tab_button.Click += new System.EventHandler(this.transaction_tab_button_Click);
            // 
            // books_tab_button
            // 
            this.books_tab_button.BackColor = System.Drawing.Color.Transparent;
            this.books_tab_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.books_tab_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.books_tab_button.Image = global::Library_Management_System.Properties.Resources.book_icon;
            this.books_tab_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.books_tab_button.Location = new System.Drawing.Point(0, 50);
            this.books_tab_button.Margin = new System.Windows.Forms.Padding(2);
            this.books_tab_button.Name = "books_tab_button";
            this.books_tab_button.Size = new System.Drawing.Size(150, 50);
            this.books_tab_button.TabIndex = 3;
            this.books_tab_button.Text = "BOOKS";
            this.books_tab_button.UseVisualStyleBackColor = false;
            this.books_tab_button.Click += new System.EventHandler(this.books_tab_button_Click);
            // 
            // borrowers_tab_button
            // 
            this.borrowers_tab_button.BackColor = System.Drawing.Color.Transparent;
            this.borrowers_tab_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowers_tab_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.borrowers_tab_button.Image = global::Library_Management_System.Properties.Resources.borrowers_icon;
            this.borrowers_tab_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowers_tab_button.Location = new System.Drawing.Point(0, 100);
            this.borrowers_tab_button.Margin = new System.Windows.Forms.Padding(2);
            this.borrowers_tab_button.Name = "borrowers_tab_button";
            this.borrowers_tab_button.Size = new System.Drawing.Size(150, 50);
            this.borrowers_tab_button.TabIndex = 3;
            this.borrowers_tab_button.Text = "BORROWERS";
            this.borrowers_tab_button.UseVisualStyleBackColor = false;
            this.borrowers_tab_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // sliding_panel_toggle
            // 
            this.sliding_panel_toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sliding_panel_toggle.Image = global::Library_Management_System.Properties.Resources.arrows_left;
            this.sliding_panel_toggle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sliding_panel_toggle.Location = new System.Drawing.Point(0, 0);
            this.sliding_panel_toggle.Margin = new System.Windows.Forms.Padding(2);
            this.sliding_panel_toggle.Name = "sliding_panel_toggle";
            this.sliding_panel_toggle.Size = new System.Drawing.Size(150, 50);
            this.sliding_panel_toggle.TabIndex = 2;
            this.sliding_panel_toggle.UseVisualStyleBackColor = true;
            this.sliding_panel_toggle.Click += new System.EventHandler(this.sliding_panel_toggle_Click);
            // 
            // sliding_panel_timer
            // 
            this.sliding_panel_timer.Interval = 30;
            this.sliding_panel_timer.Tick += new System.EventHandler(this.sliding_panel_timer_Tick);
            // 
            // content_panel
            // 
            this.content_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.content_panel.Location = new System.Drawing.Point(145, 36);
            this.content_panel.Margin = new System.Windows.Forms.Padding(2);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(855, 564);
            this.content_panel.TabIndex = 2;
            this.content_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.content_panel_Paint);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.content_panel);
            this.Controls.Add(this.sliding_panel);
            this.Controls.Add(this.title_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.title_bar.ResumeLayout(false);
            this.sliding_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer login_timer;
        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Panel sliding_panel;
        private System.Windows.Forms.Button sliding_panel_toggle;
        private System.Windows.Forms.Timer sliding_panel_timer;
        private System.Windows.Forms.Button books_tab_button;
        private System.Windows.Forms.Button borrowers_tab_button;
        private System.Windows.Forms.Button transaction_tab_button;
        private System.Windows.Forms.Button about_tab_button;
        private System.Windows.Forms.Panel content_panel;
    }
}