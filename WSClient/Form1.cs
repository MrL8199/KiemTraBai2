using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDsSvNC_Click(object sender, EventArgs e)
        {
            ListStudentsForm listStudentsForm = new ListStudentsForm();
            listStudentsForm.ShowDialog();
        }

        private void btnTop5sv_Click(object sender, EventArgs e)
        {
            Top5Form top5Form = new Top5Form();
            top5Form.ShowDialog();
        }
    }
}
