using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Practice
{
    public partial class FormAbonent : Form
    {
        MongoDB_Class _Obj = MongoDB_Class.GetObject();
        SBindingList<Abonent> doclist = new SBindingList<Abonent>();
        public FormAbonent()
        {
            InitializeComponent();

        }
        private void FormAbonent_Load(object sender, EventArgs e)
        {
            doclist = _Obj.Load_Abonent();
            abonentBindingSource.DataSource = doclist;
            dataGridViewAbonent.DataSource = abonentBindingSource;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Street s;
            Abonent a = new Abonent()
            {
                HouseNo = 1,
                FlatNo = 1,
            };
            FormAbonentEdit fae = new FormAbonentEdit(a, _Obj);
            fae.ShowDialog();
            if (fae.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                _Obj.Insert_Abonent_Information(a);
                abonentBindingSource.DataSource = a;
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            Abonent a;
            if (abonentBindingSource.Current != null)
            {
                a = (Abonent)abonentBindingSource.Current;
                FormAbonentEdit fae = new FormAbonentEdit(a, _Obj);
                fae.ShowDialog();
                if (fae.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    abonentBindingSource.ResetCurrentItem();
                    _Obj.Update_Abonent_Information(a);
                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Abonent a;
            if (abonentBindingSource.Current != null)
            {
                a = (Abonent)abonentBindingSource.Current;
                DialogResult dr = MessageBox.Show($"Удалить '{ a.FIO}' ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    abonentBindingSource.Remove(a);
                    _Obj.Update_Abonent_Information(a);
                }
            }
        }
    }
}
