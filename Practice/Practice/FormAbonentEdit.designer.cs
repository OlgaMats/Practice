
namespace Practice
{
    partial class FormAbonentEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxStreetId = new System.Windows.Forms.ComboBox();
            this.streetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.numericUpDownHouse = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFlat = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.streetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО абонента:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Улица:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер дома:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Номер квартиы:";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(466, 285);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(113, 49);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(347, 285);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(113, 49);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxStreetId
            // 
            this.comboBoxStreetId.DataSource = this.streetBindingSource;
            this.comboBoxStreetId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStreetId.FormattingEnabled = true;
            this.comboBoxStreetId.Location = new System.Drawing.Point(12, 199);
            this.comboBoxStreetId.Name = "comboBoxStreetId";
            this.comboBoxStreetId.Size = new System.Drawing.Size(287, 24);
            this.comboBoxStreetId.TabIndex = 12;
            // 
            // streetBindingSource
            // 
            this.streetBindingSource.DataSource = typeof(Practice.Street);
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(12, 141);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(287, 22);
            this.textBoxFIO.TabIndex = 14;
            this.textBoxFIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFIO_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Лицевой счёт:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(12, 90);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(287, 22);
            this.textBoxId.TabIndex = 3;
            // 
            // numericUpDownHouse
            // 
            this.numericUpDownHouse.Location = new System.Drawing.Point(398, 40);
            this.numericUpDownHouse.Name = "numericUpDownHouse";
            this.numericUpDownHouse.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHouse.TabIndex = 15;
            // 
            // numericUpDownFlat
            // 
            this.numericUpDownFlat.Location = new System.Drawing.Point(398, 91);
            this.numericUpDownFlat.Name = "numericUpDownFlat";
            this.numericUpDownFlat.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownFlat.TabIndex = 16;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(398, 150);
            this.maskedTextBoxPhone.Mask = "00-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(145, 22);
            this.maskedTextBoxPhone.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Номер телефона:";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(12, 39);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(287, 22);
            this.textBox_Id.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Id:";
            // 
            // FormAbonentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 368);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.numericUpDownFlat);
            this.Controls.Add(this.numericUpDownHouse);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.comboBoxStreetId);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(630, 415);
            this.Name = "FormAbonentEdit";
            this.Text = "Редактирование данных об абоненте";
            this.Load += new System.EventHandler(this.FormAbonentEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.streetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.NumericUpDown numericUpDownHouse;
        private System.Windows.Forms.NumericUpDown numericUpDownFlat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStreetId;
        private System.Windows.Forms.BindingSource streetBindingSource;
    }
}