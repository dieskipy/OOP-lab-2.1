using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLearning.Attributes
{
    //атрибут для удобства сопоставления конктретная форма - соотв ей класс
    class Suitable:Attribute
    {
        public Type[] SuitableType { get; set; }
        public Suitable(Type[] suitable)
        {
            SuitableType = suitable;
        }
        public bool CheckForAvailability(Type suitable)
        {
            for (int i = 0; i < SuitableType.Length; i++)
                if (SuitableType[i] == suitable)
                    return true;
            return false;
        }
    }
}
