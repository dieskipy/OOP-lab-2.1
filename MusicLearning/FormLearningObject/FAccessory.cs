using MusicLearning.LearningObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MusicLearning.FormLearningObject
{
    public partial class FAccessory : FPersonalService
    {
        public FAccessory()
        {
            InitializeComponent();
            SetComboBoxes(cbLessonType, typeof(Lesson));
        }
        //веселуха с соответствием индекс списка - имя индекса
        public void SetLessonType(Lesson level)
        {

            cbLessonType.SelectedIndex = (int)level;
        }

        public Lesson GetLessonType()
        {

            Lesson level = (Lesson)cbLessonType.SelectedIndex;
            return level;
        }
    }
}
