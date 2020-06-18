using MusicLearning.Attributes;
using MusicLearning.FormLearningObject;
using MusicLearning.InstrumentElements;
using MusicLearning.LearningObject.Instruments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MusicLearning.FormLearningObjects.FormInstruments
{
    [Suitable((new Type[] { typeof(Keyboard) }))]
    public partial class FKeyboard : FInstrument

    {
        private Keyboard FinalKeyboard = null;
        //три конструктора для создания, редактирования и просмотра
        public FKeyboard()
        {
            InitializeComponent();
            SetComboBoxes(cbInstrument, typeof(KeyboardType));
        }
        public FKeyboard(object myObject)
        {
            InitializeComponent();
            SetComboBoxes(cbInstrument, typeof(KeyboardType));
            SetKeyboard((Keyboard)myObject);
        }
        public FKeyboard(object myObject, bool readOnly)
        {
            InitializeComponent();
            SetComboBoxes(cbInstrument, typeof(KeyboardType));
            SetKeyboard((Keyboard)myObject);
            if (readOnly)
            {
                SetReadOnly();
                ReceivedTeacher.ReadOnly = true;
            }
        }
        //инициализация при просмотре-редактировании
        public void SetKeyboard(Keyboard instrument)
        {
            FinalKeyboard = instrument;
            SetCourseName(instrument.CourseName);
            SetDate(instrument.Data);
            SetProffessionalLevel(instrument.ProfLevel);
            SetLessonType(instrument.KeyboardName);
            //ставим инфу в teacher еще до того как открыли
            SetTeacherNameFunction(instrument.TeacherInfo.Name);
            SetTeacherExpirienceFunction(instrument.TeacherInfo.Experience);
        }
        //задание-обновление инфы объектов 
        public void GetKeyboard(Keyboard instrument)
        {
            instrument.CourseName = GetCourseName();
            instrument.Data = GetDate();
            instrument.ProfLevel = GetProffessionalLevel();
            instrument.KeyboardName = GetLessonType();
            //достаем инфу из teacher после закрытия
            Teacher teacher = new Teacher(GetTeacherNameFunction(), GetTeacherExpirienceFunction());
            instrument.TeacherInfo = teacher;
        }
        //веселуха с соответствием индекс списка - имя индекса
        public void SetLessonType(KeyboardType level)
        {

            cbInstrument.SelectedIndex = (int)level;
        }

        public KeyboardType GetLessonType()
        {
            KeyboardType level = (KeyboardType)cbInstrument.SelectedIndex;
            return level;
        }
        //в зависимотсти от того существовал объект до этого или нет сохраняем разными способами
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FinalKeyboard == null)
            {
                Keyboard instr = new Keyboard();
                GetKeyboard(instr);
                MainForm.AddObject(instr);
            }
            else
                GetKeyboard(FinalKeyboard);
            Close();
        }
    }
}
