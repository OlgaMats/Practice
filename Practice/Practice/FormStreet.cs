using System;
using System.Windows.Forms;

namespace Practice
{
    public partial class FormStreet : Form
    {
        MongoDB_Class _Obj = MongoDB_Class.GetObject();
        SBindingList<Street> doclist = new SBindingList<Street>();
        public FormStreet()
        {
            InitializeComponent();
        }

        private void FormStreet_Load(object sender, EventArgs e)
        {
            doclist = _Obj.Load_Street();
            streetBindingSource.DataSource = doclist;
            dataGridViewStreet.DataSource = streetBindingSource;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Street s = new Street();
            FormStreetEdit fse = new FormStreetEdit(s);
            fse.ShowDialog();
            if (fse.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                _Obj.Insert_Street_Information(s);
                streetBindingSource.DataSource = s;
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            Street s;
            if (streetBindingSource.Current != null)
            {
                s = (Street)streetBindingSource.Current;
                FormStreetEdit fse = new FormStreetEdit(s);
                fse.ShowDialog();
                if (fse.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    streetBindingSource.ResetCurrentItem();
                    _Obj.Update_Street_Information(s);
                }
            }
        }
    }
}
