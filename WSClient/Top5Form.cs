using Bai2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WSClient
{
    public partial class Top5Form : Form
    {
        public Top5Form()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            WebService1 client = new WebService1();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(client.Get_Top5Students(tbMaHK.Text));
            DataSet ds = new DataSet();
            XmlNodeReader xmlreader = new XmlNodeReader(xmlDoc);
            ds.ReadXml(xmlDoc);
            dtgv_Top5.DataSource = ds;
            dtgv_Top5.Refresh();
        }
    }
}
