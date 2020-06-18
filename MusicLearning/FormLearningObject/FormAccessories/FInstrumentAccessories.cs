using MusicLearning.Attributes;
using MusicLearning.InstrumentElements;
using MusicLearning.LearningObject.Accessories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MusicLearning.FormLearningObject.FormAccessories
{
    [Suitable((new Type[] { typeof(InstrumentAccessories) }))]

    public partial class FInstrumentAccessories : FAccessory
    {
        private InstrumentAccessories FinalAccessory = null;

        //три конструктора для создания, редактирования и просмотра
        public FInstrumentAccessories()
        {
            InitializeComponent();
            SetComboBoxes(cbInstrumentGroup, typeof(InstrGroup));
        }
        public FInstrumentAccessories(object myObject)
        {
            InitializeComponent();
            SetComboBoxes(cbInstrumentGroup, typeof(InstrGroup));
            SetInstrumentAccessories((InstrumentAccessories)myObject);
        }
        public FInstrumentAccessories(object myObject, bool readOnly)
        {
            InitializeComponent();
            SetComboBoxes(cbInstrumentGroup, typeof(InstrGroup));
            SetInstrumentAccessories((InstrumentAccessories)myObject);
            if (readOnly)
            {
                SetReadOnly();
                ReceivedTeacher.ReadOnly = true;
            }
        }
        //инициализация при просмотре-редактировании
        public void SetInstrumentAccessories(InstrumentAccessories instrument)
        {
            FinalAccessory = instrument;
            SetCourseName(instrument.CourseName);
            SetDate(instrument.Data);
            SetLessonType(instrument.LesType);
            //ставим инфу в teacher еще до того как открыли
            SetInstrumentGroup(instrument.Group);
            SetTeacherNameFunction(instrument.TeacherInfo.Name);
            SetTeacherExpirienceFunction(instrument.TeacherInfo.Experience);
        }
        //задание-обновление инфы объектов 
        public void GetInstrumentAccessories(InstrumentAccessories instrument)
        {
            instrument.CourseName = GetCourseName();
            instrument.Data = GetDate();
            instrument.LesType = GetLessonType();
            instrument.Group = GetInstrumentGroup();
            //достаем инфу из teacher после закрытия
            Teacher teacher = new Teacher(GetTeacherNameFunction(), GetTeacherExpirienceFunction());
            instrument.TeacherInfo = teacher;
        }

        //веселуха с соответствием индекс списка - имя индекса
        public void SetInstrumentGroup(InstrGroup level)
        {

            cbInstrumentGroup.SelectedIndex = (int)level;
        }
        
        public InstrGroup GetInstrumentGroup()
        {

            InstrGroup level = (InstrGroup)cbInstrumentGroup.SelectedIndex;
            return level;
        }

        //в зависимотсти от того существовал объект до этого или нет сохраняем разными способами
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FinalAccessory == null)
            {
                InstrumentAccessories instr = new InstrumentAccessories();
                GetInstrumentAccessories(instr);
                MainForm.AddObject(instr);
            }
            else
                GetInstrumentAccessories(FinalAccessory);
            Close();
        }
    }
}
