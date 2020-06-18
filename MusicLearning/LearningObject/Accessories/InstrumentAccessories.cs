using MusicLearning.Attributes;
using MusicLearning.InstrumentElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace MusicLearning.LearningObject.Accessories
{        
    public enum InstrGroup
    {
        [Description("Духовые")]
        wind,
        [Description("Струнные")]
        strings,
        [Description("Клавишные")]
        keyboard
    }
    //для связки класс - дисплей класса
    [ProductType("Инструментальные аксессуары")]
    [Serializable]
    public class InstrumentAccessories:Accessory
    {
        //связанные значения для комбо бокса
        public InstrGroup Group { get; set; } = InstrGroup.wind;
        public InstrumentAccessories()
        {
            //общение с тичер еще до открытия формы
            TeacherInfo = new Teacher("", "");
        }
    }
}
