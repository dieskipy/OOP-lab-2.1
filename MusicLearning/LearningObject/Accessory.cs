using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MusicLearning.LearningObject
{
    public enum Lesson
    {
        [Description("Консультация")]
        consultation,
        [Description("Обучение")]
        training
    }

    [Serializable]
    abstract public class Accessory: PersonalService
    {
        //связанные значения для комбо бокса
        public Lesson LesType { get; set; } = Lesson.consultation;
    }
}
