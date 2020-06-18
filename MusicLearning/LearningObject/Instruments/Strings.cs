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
    public enum StringsType
    {
        [Description("Скрипка")]
        violin,
        [Description("Альт")]
        viola,
        [Description("Виолончель")]
        cello,
        [Description("Контрабас")]
        contrabass,
        [Description("Гитара")]
        guitar,
        [Description("Укулеле")]
        ukulele,
        [Description("Арфа")]
        harp
    }

    //для связки класс - дисплей класса
    [ProductType("Струнные инструменты")]
    [Serializable]
    public class Strings:Instrument
    {
        //связанные значения для комбо бокса
        public StringsType StringsName { get; set; } = StringsType.violin;
        public Strings()
        {
            //общение с тичер еще до открытия формы
            TeacherInfo = new Teacher("", "");
        }
    }
}
