using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Library_Management_System
{
    public partial class AppBody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public AppBody()
        {
            InitializeComponent();
            isSlidingPanelExpanded = true;
            expandSlidingPanelGUI();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity <= 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                login_timer.Stop();
            }
        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            login_timer.Start();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void expandSlidingPanelGUI()
        {
            books_tab_button.Text = "BOOKS";
            borrowers_tab_button.Text = "BORROWERS";
            transaction_tab_button.Text = "TRANSACTIONS";
            about_tab_button.Text = "ABOUT";
            sliding_panel_toggle.Image = Properties.Resources.arrows_left;
            sliding_panel_toggle.ImageAlign = ContentAlignment.MiddleCenter;
            books_tab_button.Image = null;
            borrowers_tab_button.Image = null;
            transaction_tab_button.Image = null;
            about_tab_button.Image = null;
        }

        public void retractSlidingPanelGUI()
        {
            books_tab_button.Text = "";
            borrowers_tab_button.Text = "";
            transaction_tab_button.Text = "";
            about_tab_button.Text = "";
            sliding_panel_toggle.Image = Properties.Resources.arrows_right;
            sliding_panel_toggle.ImageAlign = ContentAlignment.MiddleLeft;
            books_tab_button.Image = Properties.Resources.book_icon;
            borrowers_tab_button.Image = Properties.Resources.borrowers_icon;
            transaction_tab_button.Image = Properties.Resources.transactions_icon;
            about_tab_button.Image = Properties.Resources.about_icon;
        }

        private void minimize_button_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool isSlidingPanelExpanded = true;
        const int maxSliderWidth = 150;
        const int minSliderWidth = 50;
        private void sliding_panel_toggle_Click(object sender, EventArgs e)
        {
            if(isSlidingPanelExpanded)
            {
                //retractSlidingPanelGUI();
            }
            sliding_panel_timer.Start();
        }

        private void sliding_panel_timer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                sliding_panel.Width -= 25;
                if(sliding_panel.Width <= minSliderWidth)
                {
                    isSlidingPanelExpanded = false;
                    sliding_panel_timer.Stop();
                    retractSlidingPanelGUI();
                    this.Refresh();
                }
            }
            else
            {
                sliding_panel.Width += 25;
                if (sliding_panel.Width >= maxSliderWidth)
                {
                    isSlidingPanelExpanded = true;
                    sliding_panel_timer.Stop();
                    expandSlidingPanelGUI();

                    this.Refresh();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!content_panel.Controls.Contains(borrowers_user_control.Instance))
            {
                content_panel.Controls.Add(borrowers_user_control.Instance);
                borrowers_user_control.Instance.Dock = DockStyle.Fill;
                borrowers_user_control.Instance.BringToFront();
            }
            else
            {
                borrowers_user_control.Instance.BringToFront();
            }
        }

        private void books_tab_button_Click(object sender, EventArgs e)
        {
            if(! content_panel.Controls.Contains(books_user_control.Instance))
            {
                content_panel.Controls.Add(books_user_control.Instance);
                books_user_control.Instance.Dock = DockStyle.Fill;
                books_user_control.Instance.BringToFront();
            }
            else
            {
                books_user_control.Instance.BringToFront();
            }
        }

        private void transaction_tab_button_Click(object sender, EventArgs e)
        {
            if (!content_panel.Controls.Contains(transaction_user_control.Instance))
            {
                content_panel.Controls.Add(transaction_user_control.Instance);
                transaction_user_control.Instance.Dock = DockStyle.Fill;
                transaction_user_control.Instance.BringToFront();
            }
            else
            {
                transaction_user_control.Instance.BringToFront();
            }
        }

        private void about_tab_button_Click(object sender, EventArgs e)
        {
            if (!content_panel.Controls.Contains(about_user_control.Instance))
            {
                content_panel.Controls.Add(about_user_control.Instance);
                about_user_control.Instance.Dock = DockStyle.Fill;
                about_user_control.Instance.BringToFront();
            }
            else
            {
                about_user_control.Instance.BringToFront();
            }
        }

        private void content_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void add_new_button_Click(object sender, EventArgs e)
        {

        }

        private void books_user_control1_Load(object sender, EventArgs e)
        {

        }
    }
}
