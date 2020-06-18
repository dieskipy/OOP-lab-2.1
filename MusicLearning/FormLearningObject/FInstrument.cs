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
    public partial class FInstrument : FPersonalService
    {
        public FInstrument()
        {
            InitializeComponent();
            SetComboBoxes(cbProffessionalLevel, typeof(ProfType));
        }
        //веселуха с соответствием индекс списка - имя индекса
        public void SetProffessionalLevel(ProfType level)
        {

            cbProffessionalLevel.SelectedIndex = (int)level;
        }

        public ProfType GetProffessionalLevel()
        {

            ProfType level = (ProfType)cbProffessionalLevel.SelectedIndex;
            return level;
        }

    }
}
