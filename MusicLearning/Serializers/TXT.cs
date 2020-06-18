using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using MusicLearning.LearningObject;
using MusicLearning.Attributes;
using MusicLearning.LearningObject.Instruments;

namespace MusicLearning.Serializers
{
    [SerializerType("TXT")]
    public class TXT : InterfaceS
    {
        public string FileExtension { get; } = ".txt|*.txt";
        private string ObjectSerializer(object obj)
        {
            string result = "";
            //свойства ака все поля объекта
            PropertyInfo[] properties = obj.GetType().GetProperties();

            for (int i = 0; i < properties.Length; i++)
            {
                Type propertyValueType = properties[i].GetValue(obj).GetType();
                //проверка на класс, если класс - рекурсия, не класс - пишем в файл
                if ((propertyValueType.IsClass) && (propertyValueType.Namespace != "System"))
                    result += ObjectSerializer(properties[i].GetValue(obj));
                else
                    result += Convert.ToString(properties[i].GetValue(obj)) + '~';
            }
            return result;
        }
        //главный се ри а ли за тор
        public void Serialize(object myObject, string filePath)
        {
            using (StreamWriter fileStream = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                string result = myObject.GetType().FullName + "~";
                result += ObjectSerializer(myObject);
                fileStream.WriteLine(result);
            }
        }
        //парсит слово в строке по номеру слова
        private string GetWord(string line, ref int posInLine)
        {
            string[] strings = line.Split('~');
            string result = strings[posInLine];
            posInLine++;
            return result;
        }

        private object ObjectDeserializer(Type valueType, string line, ref int posInLine)
        {
            object obj = Activator.CreateInstance(valueType);
            PropertyInfo[] properties;
            //все свойства ака все поля
            properties = obj.GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                object trans = properties[i].GetValue(obj);
                Type propertyValueType = trans.GetType();
                //проверка на класс, если класс - рекурсия, не класс - обновляем инфу в obj
                if ((propertyValueType.IsClass) && (propertyValueType.Namespace != "System"))
                    properties[i].SetValue(obj, ObjectDeserializer(propertyValueType, line, ref posInLine));
                else
                    SetValueInObject(obj, properties[i], GetWord(line, ref posInLine));
            }
            return obj;
        }


        //обновляем инфу в объекте из дефолтной в ту что надо
        public void SetValueInObject(Object myObject, PropertyInfo propertyInfo, string value)
        {
            object obj;
            Type valueType = propertyInfo.GetValue(myObject).GetType();
            if (valueType.IsEnum)
                obj = Enum.Parse(valueType, value);
            else
                obj = Convert.ChangeType(value, valueType);
            propertyInfo.SetValue(myObject, obj);
        }

        //главный де се ри а ли за тор
        public object Deserialize(string filePath)
        {
            int posInLine = 0;
            string line;
            object myObject = new PersonalService[1];
            using (StreamReader fileStream = new StreamReader(filePath, Encoding.UTF8))
            {
                line = fileStream.ReadLine();
                //определяем главный класс (keyboard|strings|wind|instumentaccessories) и кидаем его в парсер по полям
                Type objType = Type.GetType(GetWord(line, ref posInLine));
                myObject = ObjectDeserializer(objType, line, ref posInLine);
            }
            return myObject;
        }
    }
}
