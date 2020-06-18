using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLearning.FormInstrumentElements
{
    public partial class FTeacher : Form
    {
        //буль для чтения-редактирования
        public bool ReadOnly = false;

        public void SetReadOnly()
        {
            foreach (var TextBox in Controls.OfType<TextBox>())
            {
                TextBox.Enabled = false;
            }
            btnSave.Hide();
        }

        public FTeacher()
        {
            InitializeComponent();
        }
        public void SetTeacherName(string name)
        {
            if (name!="")
            {
                tbTeacherName.Text = name;
            }
            else
            {
                tbTeacherName.Text = "Не указан";
            }
        }
        public string GetTeacherName()
        {
            return tbTeacherName.Text;
        }
        public void SetTeacherExpirience(string count)
        {
            if (count != "")
            {
                tbTeacherExpirience.Text = count;
            }
            else
            {
                tbTeacherExpirience.Text = "Не указан";
            }
        }
        public string GetTeacherExpirience()
        {
            return tbTeacherExpirience.Text;
        }

        //проверка на то что пользователь вводит числа
        public void checkDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbTeacherExpirience_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDigit(sender, e);
        }

        private void FTeacher_Shown(object sender, EventArgs e)
        {
            if (ReadOnly == true)
            {
                SetReadOnly();
            }
               
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
