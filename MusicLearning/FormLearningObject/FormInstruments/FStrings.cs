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
    [Suitable((new Type[] { typeof(Strings) }))]
    public partial class FStrings : FInstrument
    {
        private Strings FinalStrings = null;
        //три конструктора для создания, редактирования и просмотра
        public FStrings()
        {
            InitializeComponent();
            SetComboBoxes(cbInstrument, typeof(StringsType));
        }

        public FStrings(object myObject)
        {
            InitializeComponent();
            SetComboBoxes(cbInstrument, typeof(StringsType));
            SetStrings((Strings)myObject);
        }
        public FStrings(object myObject, bool readOnly)
        {
            InitializeComponent();
            SetComboBoxes(cbInstrument, typeof(StringsType));
            SetStrings((Strings)myObject);
            if (readOnly)
            {
                SetReadOnly();
                ReceivedTeacher.ReadOnly = true;
            }
        }
        //инициализация при просмотре-редактировании
        public void SetStrings(Strings instrument)
        {
            FinalStrings = instrument;
            SetCourseName(instrument.CourseName);
            SetDate(instrument.Data);
            SetProffessionalLevel(instrument.ProfLevel);
            SetLessonType(instrument.StringsName);
            //ставим инфу в teacher еще до того как открыли
            SetTeacherNameFunction(instrument.TeacherInfo.Name);
            SetTeacherExpirienceFunction(instrument.TeacherInfo.Experience);
        }
        //задание-обновление инфы объектов 
        public void GetStrings(Strings instrument)
        {
            instrument.CourseName = GetCourseName();
            instrument.Data = GetDate();
            instrument.ProfLevel = GetProffessionalLevel();
            instrument.StringsName = GetLessonType();
            //достаем инфу из teacher после закрытия
            Teacher teacher = new Teacher(GetTeacherNameFunction(), GetTeacherExpirienceFunction());
            instrument.TeacherInfo = teacher;
        }
        //веселуха с соответствием индекс списка - имя индекса
        public void SetLessonType(StringsType level)
        {

            cbInstrument.SelectedIndex = (int)level;
        }

        public StringsType GetLessonType()
        {
            StringsType level = (StringsType)cbInstrument.SelectedIndex;
            return level;
        }
        //в зависимотсти от того существовал объект до этого или нет сохраняем разными способами
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FinalStrings == null)
            {
                Strings instr = new Strings();
                GetStrings(instr);
                MainForm.AddObject(instr);
            }
            else
                GetStrings(FinalStrings);
            Close();
        }
    }
}
