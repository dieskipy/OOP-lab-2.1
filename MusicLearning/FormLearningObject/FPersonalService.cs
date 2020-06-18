using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using MusicLearning.FormInstrumentElements;

namespace MusicLearning.FormLearningObject
{
    public partial class FPersonalService : Form
    {
        public FTeacher ReceivedTeacher;
        public FPersonalService()
        {
            InitializeComponent();
            ReceivedTeacher = new FTeacher();
            
        }

        private void BtnShowTeacher_Click(object sender, EventArgs e)
        {
            ReceivedTeacher.ShowDialog();
        }
        public void SetCourseName(string name)
        {
            if (name != "")
            {
                tbCourseName.Text = name;
            }
            else
            {
                tbCourseName.Text = "";
            }

        }
        public string GetCourseName()
        {
            return tbCourseName.Text;
        }

        public void SetDate(DateTime date)
        {
            if (date.Ticks != 0)
            {
                dateTimePicker1.Value = date;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
            }

        }
        public DateTime GetDate()
        {
            return dateTimePicker1.Value;
        }

        //метод для всех комбобоксов с enum под разные конечные классы
        public void SetComboBoxes(ComboBox cb, Type type)
        {
            if (!type.IsEnum)
            {
                throw new ArgumentException("Only Enum types can be set");
            }
            //список ключ-значение из коллекшн систем где ключ - строка
            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
            //чекаем что там в атрибутах такого написано в каждом enum
            foreach (int i in Enum.GetValues(type))
            {
                string name = Enum.GetName(type, i); 
                //конкретное значение на англ не циферкой
                string desc = name;
                FieldInfo fi = type.GetField(name);
                //задаем имя на русском для текущего enum и закидываем с значение-цифрой-которое-на-самом-деле-будет-ключ в список
                DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes.Length > 0)
                {
                    string s = attributes[0].Description;
                    if (!string.IsNullOrEmpty(s))
                    {
                        desc = s;
                    }
                }
                list.Add(new KeyValuePair<string, int>(desc, i));
            }
            //меняем чтобы ключ-который-строка показывался, а цифра-которая-значение был значением
            cb.DisplayMember = "Key";
            cb.ValueMember = "Value";
            cb.DataSource = list;
        }

        //настройка под просмотр
        public void SetReadOnly()
        {
            foreach (var TextBox in Controls.OfType<TextBox>())
            {
                TextBox.Enabled = false;
            }
            foreach (var ComboBox in Controls.OfType<ComboBox>())
            {
                ComboBox.Enabled = false;
            }
            foreach (var Button in Controls.OfType<Button>())
            {
                if (Button.Name.Equals("btnSave"))
                {
                    Button.Hide();
                }
            }
            foreach (var DateTimePicker in Controls.OfType<DateTimePicker>())
            {
                DateTimePicker.Enabled = false;
            }

        }

        //работа с функциями ассоциации-тичера до ее открытия/после ее закрытия
        public void SetTeacherNameFunction(string name)
        {
            ReceivedTeacher.SetTeacherName(name);
        }

        public string GetTeacherNameFunction()
        {
            return ReceivedTeacher.GetTeacherName();
        }

        public void SetTeacherExpirienceFunction(string count)
        {
            ReceivedTeacher.SetTeacherExpirience(count);
        }

        public string GetTeacherExpirienceFunction()
        {
            return ReceivedTeacher.GetTeacherExpirience();
        }
    }
}
