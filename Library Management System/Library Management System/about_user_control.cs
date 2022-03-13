using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class about_user_control : UserControl
    {
        private static about_user_control _instance;

        public static about_user_control Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new about_user_control();
                }
                return _instance;
            }
        }
        public about_user_control()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
