using MusicLearning.Attributes;
using MusicLearning.InstrumentElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace MusicLearning.LearningObject.Instruments
{
    public enum WindType
    {
        [Description("Кларнет")]
        clarinet,
        [Description("Саксофон")]
        saxophone,
        [Description("Гобой")]
        oboe,
        [Description("Флейта")]
        fluet,
        [Description("Валторна")]
        frhorn,
        [Description("Труба")]
        trumpet,
        [Description("Туба")]
        tuba
    }

    //для связки класс - дисплей класса
    [ProductType("Духовые инструменты")]
    [Serializable]
    public class Wind:Instrument
    {
        //связанные значения для комбо бокса
        public WindType WindName { get; set; } = WindType.clarinet;

        public Wind()
        {
            //общение с тичер еще до открытия формы
            TeacherInfo = new Teacher("","");
        }
    }
}
