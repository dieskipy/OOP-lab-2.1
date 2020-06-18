using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicLearning.Attributes;
using MusicLearning.FormLearningObject.FormAccessories;
using MusicLearning.FormLearningObjects.FormInstruments;
using MusicLearning.LearningObject;
using MusicLearning.LearningObject.Accessories;
using MusicLearning.LearningObject.Instruments;
using MusicLearning.Serializers;

namespace MusicLearning
{
    public partial class MainForm : Form
    {
        //листы для хранения классов для форм, самих форм, объектов-которые-строки
        private readonly List<Type> ServicesList = new List<Type>();
        private readonly List<Form> FormsList = new List<Form>();
        private static readonly List<object> ObjectList = new List<object>();
        private readonly List<Type> SerializerList = new List<Type>();
        public MainForm()
        {
            InitializeComponent();
            FillServicesList();
            FillFormsList();
            FillSerializersList();
            FillComboBoxes();
            cbChooseService.SelectedIndex = 0;
            cbSerializer.SelectedIndex = 0;
        }

        //заполняем листы классами под формы
        private void FillServicesList()
        {
            ServicesList.Add(typeof(Keyboard));
            ServicesList.Add(typeof(Strings));
            ServicesList.Add(typeof(Wind));
            ServicesList.Add(typeof(InstrumentAccessories));
        }
        //заполняем листы формами
        private void FillFormsList()
        {
            FormsList.Add(new FKeyboard());
            FormsList.Add(new FStrings());
            FormsList.Add(new FWind());
            FormsList.Add(new FInstrumentAccessories());
        }
        private void FillSerializersList()
        {
            SerializerList.Add(typeof(BINARY));
            SerializerList.Add(typeof(JSON));
            SerializerList.Add(typeof(TXT));
        }

        //заполняем комбо боксы в мейне
        private void FillComboBoxes()
        {
            cbChooseService.Items.Clear();
            for (int i=0; i< ServicesList.Count;i++)
            {
                Type objectType = ServicesList[i];
                //полное описание атрибута для конкретного класса
                var attributeValue = Attribute.GetCustomAttribute(objectType, typeof(ProductType)) as ProductType;
                cbChooseService.Items.Add(attributeValue.TypeName);
            }
            cbSerializer.Items.Clear();
            for (int i = 0; i < SerializerList.Count; i++)
            {
                Type objectType = SerializerList[i];
                //полное описание атрибута для конкретного класса
                var attributeValue = Attribute.GetCustomAttribute(objectType, typeof(SerializerType)) as SerializerType;
                cbSerializer.Items.Add(attributeValue.TypeName);
            }
        }

        //перерисовка при работе с ObjectList
        private void Redraw()
        {
            lvService.Items.Clear();
            int i = 1;
            string[] str = new string[3];
            foreach (PersonalService service in ObjectList)
            {
                Type type = service.GetType();
                str[0] = i.ToString();
                i++;
                if (Attribute.IsDefined(type, typeof(ProductType)))
                {
                    var attributeValue = Attribute.GetCustomAttribute(type, typeof(ProductType)) as ProductType;
                    str[2] = attributeValue.TypeName;
                }
                else
                    str[2] = "";

                str[1] = service.CourseName;
                ListViewItem item = new ListViewItem(str);
                lvService.Items.Add(item);
            }

        }

        //универсальный метод для вызова в другие формы
        public static void AddObject(object myObject)
        {
            ObjectList.Add(myObject);
        }

        //добавление
        private void CreateForAdd(Type myType)
        {
            Form form = null;
            foreach (Form tmpForm in FormsList)
            {
                Type type = tmpForm.GetType();
                //проверка наличия атрибута в каждой форме
                if (Attribute.IsDefined(type, typeof(Suitable)))
                {
                    //достаем атрибут и сопоставляем конкретной форме
                    var attributeValue = Attribute.GetCustomAttribute(type, typeof(Suitable)) as Suitable;
                    if (attributeValue.CheckForAvailability(myType))
                        form = (Form)Activator.CreateInstance(type);
                }
            }
            if (form != null)
            {
                form.ShowDialog();
            }
        }
        //просмотр
        private void CreateForView(Object myObject)
        {
            Form form = null;
            foreach (Form tmpForm in FormsList)
            {
                Type type = tmpForm.GetType();
                //проверка наличия атрибута в каждой форме
                if (Attribute.IsDefined(type, typeof(Suitable)))
                {
                    //достаем атрибут и сопоставляем конкретной форме с булем который отрубает редактирование
                    var attributeValue = Attribute.GetCustomAttribute(type, typeof(Suitable)) as Suitable;
                    if (attributeValue.CheckForAvailability(myObject.GetType()))
                        form = (Form)Activator.CreateInstance(type, myObject, true);
                }
            }
            if (form != null)
            {
                form.ShowDialog();
            }
        }
        //редактирование
        private void CreateForEdit(Object myObject)
        {
            Form form = null;
            foreach (Form tmpForm in FormsList)
            {
                Type type = tmpForm.GetType();
                //проверка наличия атрибута в каждой форме
                if (Attribute.IsDefined(type, typeof(Suitable)))
                {
                    //достаем атрибут и сопоставляем конкретной форме под редактирование
                    var attributeValue = Attribute.GetCustomAttribute(type, typeof(Suitable)) as Suitable;
                    if (attributeValue.CheckForAvailability(myObject.GetType()))
                        form = (Form)Activator.CreateInstance(type, myObject);
                }
            }
            if (form != null)
            {
                form.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateForAdd(ServicesList[cbChooseService.SelectedIndex]);
            Redraw();
        }

        //вызов списка смотреть-редачить-удалить по правой кнопке мыши
        private void lvService_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvService.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvService.SelectedItems.Count == 1)
            {
                CreateForView(ObjectList[lvService.SelectedIndices[0]]);
                Redraw();
            }
            else
            {
                MessageBox.Show("Вы ничего не выбрали");
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvService.SelectedItems.Count == 1)
            {
                CreateForEdit(ObjectList[lvService.SelectedIndices[0]]);
                Redraw();
            }
            else
            {
                MessageBox.Show("Вы ничего не выбрали");
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvService.SelectedItems.Count == 1)
            {
                ObjectList.RemoveAt(lvService.SelectedIndices[0]);
                Redraw();
            }
            else
            {
                MessageBox.Show("Вы ничего не выбрали");
            }
        }

        private void btnSaveS_Click(object sender, EventArgs e)
        {
             if (lvService.SelectedItems.Count == 0)
                    return;
            //создаем объект и помещаем туда выбранный из списка
            object selectedObj = new object();
            selectedObj = ObjectList[lvService.SelectedIndices[0]];

            InterfaceS serializer = (InterfaceS)Activator.CreateInstance(SerializerList[cbSerializer.SelectedIndex]);
            saveDialog.Filter = serializer.FileExtension;
            if (saveDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filePath = saveDialog.FileName;
            serializer.Serialize(selectedObj, filePath);
        }

        private InterfaceS GetSerializer(string filepath)
        {
            InterfaceS serializer = null;
            bool flag = false;
            //ищем нужный сериализатор
            foreach (Type ser in SerializerList)
            {
                serializer = (InterfaceS)Activator.CreateInstance(ser);
                //проверяем, то ли расширение файла
                if ((serializer.FileExtension).IndexOf(Path.GetExtension(filepath)) != -1)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                return serializer;
            else
                return null;
        }

        private void btnUploadS_Click(object sender, EventArgs e)
        {
            object loadObject;
            if (openDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filePath = openDialog.FileName;
            try
            {
                InterfaceS serializer = GetSerializer(filePath);
                if (serializer == null)
                {
                    MessageBox.Show("Десериализация не удалась!");
                    return;
                }
                //десериализуем и кидаем в лист объектов
                loadObject = serializer.Deserialize(filePath);
                ObjectList.Add(loadObject);
                Redraw();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
