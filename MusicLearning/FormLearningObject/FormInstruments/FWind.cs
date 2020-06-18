using MusicLearning.Attributes;
using MusicLearning.FormLearningObject;
using MusicLearning.InstrumentElements;
using MusicLearning.FormInstrumentElements;
using MusicLearning.LearningObject.Instruments;
using MusicLearning;
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
    [Suitable((new Type[] { typeof(Wind) }))]
    public partial class FWind : FInstrument
    {
        private Wind FinalWind = null;
        //три конструктора для создания, редактирования и просмотра
        public FWind()
        {
            InitializeComponent();
            SetComboBoxes(cbInstrument, typeof(WindType));
        }

        public FWind(object myObject)
        {
            InitializeComponent();
            SetComboBoxes(cbInstrument, typeof(WindType));
            SetWind((Wind)myObject);
        }
        public FWind(object myObject, bool readOnly)
        {
            InitializeComponent();
            SetComboBoxes(cbInstrument, typeof(WindType));
            SetWind((Wind)myObject);
            if (readOnly)
            {
                SetReadOnly();
                ReceivedTeacher.ReadOnly = true;
            }
        }

        //инициализация при просмотре-редактировании
        public void SetWind(Wind instrument)
        {
            FinalWind = instrument;
            SetCourseName(instrument.CourseName);
            SetDate(instrument.Data);
            SetProffessionalLevel(instrument.ProfLevel);
            SetLessonType(instrument.WindName);
            //ставим инфу в teacher еще до того как открыли
            SetTeacherNameFunction(instrument.TeacherInfo.Name);
            SetTeacherExpirienceFunction(instrument.TeacherInfo.Experience);
        }
        //задание-обновление инфы объектов 
        public void GetWind(Wind instrument)
        {
            instrument.CourseName = GetCourseName();
            instrument.Data = GetDate();
            instrument.ProfLevel = GetProffessionalLevel();
            instrument.WindName = GetLessonType();
            //достаем инфу из teacher после закрытия
            Teacher teacher = new Teacher(GetTeacherNameFunction(), GetTeacherExpirienceFunction());
            instrument.TeacherInfo = teacher;
        }
        //веселуха с соответствием индекс списка - имя индекса
        public void SetLessonType(WindType level)
        {

            cbInstrument.SelectedIndex = (int)level;
        }

        public WindType GetLessonType()
        {
            WindType level = (WindType)cbInstrument.SelectedIndex;
            return level;
        }
        //в зависимотсти от того существовал объект до этого или нет сохраняем разными способами
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FinalWind == null)
            {
                Wind instr = new Wind();
                GetWind(instr);
                MainForm.AddObject(instr);
            }
            else
                GetWind(FinalWind);
            Close();
        }
    }
}
