using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Bson;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Practice
{
    public partial class FormAbonentEdit : Form
    {
        MongoDB_Class mdb;
        Abonent a;
        public FormAbonentEdit(Abonent _a, MongoDB_Class _mdb)
        {
            a = _a;
            mdb = _mdb;
            InitializeComponent();
        }
        private void objectToData()
        {
            textBox_Id.Text = a._id.ToString();
            textBoxId.Text = a.Id;
            textBoxFIO.Text = a.FIO;
            comboBoxStreetId.Text =a.StreetId;
            numericUpDownHouse.Value = a.HouseNo;
            numericUpDownFlat.Value = a.FlatNo;
            maskedTextBoxPhone.Text = a.Phone;
        }
        private bool dataToObject()
        {
            InputError ie = new InputError();

            if (textBoxFIO.Text.ToString() != "")
            {
                a.FIO = textBoxFIO.Text;
            }
            else
            {
                ie.inputErrorTextBox(textBoxFIO);
                return false;
            }
            ;
            if (a.StreetId != null)
                a.StreetId = comboBoxStreetId.SelectedItem.ToString();
            if (maskedTextBoxPhone.Text.Length == 18)
            {
                    a.Phone = maskedTextBoxPhone.Text;
            }
            else
            {
                ie.inputErrorMaskedTextBox(maskedTextBoxPhone);
                return false;

            }
            a.HouseNo = Convert.ToInt32(numericUpDownHouse.Value);
            a.FlatNo = Convert.ToInt32(numericUpDownFlat.Value);
            return true;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(dataToObject())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Не все поля заполнены корректно!");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void FormAbonentEdit_Load(object sender, EventArgs e)
        {
            streetBindingSource.DataSource = mdb.Load_Street();
            objectToData();
        }

        private void textBoxFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
