using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MusicLearning.LearningObject
{
    public enum ProfType
    {
        [Description("Новичок")]
        beginner,
        [Description("Любитель")]
        amateur,
        [Description("Продвинутый")]
        advanced,
        [Description("Профессионал")]
        professional
    }

    [Serializable]
    abstract public class Instrument: PersonalService
    {
        //связанные значения для комбо бокса
        public ProfType ProfLevel { get; set; } = ProfType.beginner;
    }
}
