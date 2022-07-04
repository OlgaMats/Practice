using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Bson;
using System.Windows.Forms;

namespace Practice
{
    public partial class FormMain : Form
    {
        MongoDB_Class _Obj = MongoDB_Class.GetObject();
        SBindingList<Abonent> doclist = new SBindingList<Abonent>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void абонентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbonent fal = new FormAbonent();
            fal.ShowDialog();
        }

        private void улицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStreet fsl = new FormStreet();
            fsl.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

