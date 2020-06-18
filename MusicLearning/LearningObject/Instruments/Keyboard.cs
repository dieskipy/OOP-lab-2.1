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
    public enum KeyboardType
    {
        [Description("Рояль")]
        grpiano,
        [Description("Пианино")]
        piano,
        [Description("Синтезатор")]
        synthesizer,
        [Description("Цифровое пианино")]
        digpiano
    }

    //для связки класс - дисплей класса
    [ProductType("Клавишные инструменты")]
    [Serializable]
    public class Keyboard:Instrument
    {
        //связанные значения для комбо бокса
        public KeyboardType KeyboardName { get; set; } = KeyboardType.grpiano;
        public Keyboard()
        {
            //общение с тичер еще до открытия формы
            TeacherInfo = new Teacher("", "");
        }
    }
}
