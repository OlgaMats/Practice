using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Bson;
using System.Windows.Forms;

namespace Practice
{
    public partial class FormStreetEdit : Form
    {
        Street s;

        public FormStreetEdit(Street _s)
        {
            InitializeComponent();
            s = _s;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void objectToData()
        {
            textBoxId.Text = s.Id.ToString();
            textBoxStreet.Text =s.StreetName;

        }
        private bool dataToObject()
        {
            InputError ie = new InputError();
            if (textBoxStreet.Text.ToString() != "")
            {
                s.StreetName = textBoxStreet.Text;
            }
            else
            {
                ie.inputErrorTextBox(textBoxStreet);
                return false;
            }
            ;
            return true;
        }

        private void FormStreetEdit_Load(object sender, EventArgs e)
        {
            objectToData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataToObject())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Не все поля заполнены корректно!");
        }

        private void textBoxStreet_KeyPress(object sender, KeyPressEventArgs e)
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
