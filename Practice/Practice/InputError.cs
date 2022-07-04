using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practice
{
    class InputError
    {
        public void inputErrorTextBox(TextBox textboxname)
        {
            textboxname.SelectionStart = 0;
            textboxname.SelectionLength = textboxname.Text.Length;
            textboxname.Focus();
        }
        public void inputErrorMaskedTextBox(MaskedTextBox maskedtextboxname)
        {
            maskedtextboxname.SelectionStart = 0;
            maskedtextboxname.SelectionLength = maskedtextboxname.Text.Length;
            maskedtextboxname.Focus();
        }
    }
}
