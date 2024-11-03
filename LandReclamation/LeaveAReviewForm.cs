using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandReclamation
{
    public partial class LeaveAReviewForm : Form
    {
        public LeaveAReviewForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спасибо за отзыв!");
        }
    }
}
