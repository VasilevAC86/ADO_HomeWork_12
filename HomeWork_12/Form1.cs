using Service;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HomeWork_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!FSWork.IsFileExist("AutoService.db")) MakeStore();
            else // Если ДБ существует, то делаем элементы для добавления нового мастера активными
            {
                lblAddMaster.Enabled = true;
                tBAddMaster.Enabled = true;
                lblNumberMaster.Enabled = true;
                tBNumberMaster.Enabled = true;
                lblAvatar.Enabled = true;
            }
            FillMechanicsName();            
        }
        private void MakeStore()
        {
            if (DBWork.MakeDB())
            {
                MessageBox.Show($"База данных существует");
            };
        }
        private void FillMechanicsName()
        {
            foreach (string name in DBWork.GetMechanics())
            {
                cmbMechanic.Items.Add(name);
            }
            DBWork.GetMechanics();
        }
        private void picBoxAvatar_Click(object sender, EventArgs e)
        {
            if (cmbMechanic.SelectedItem != null) // Если в списке мы выбрали механика
            {
                byte[] _image = FSWork.GetImage();
                string _name = cmbMechanic.SelectedItem.ToString();
                DBWork.AddAvatar(_name, _image);
            }
        }
        private void SetImagePicterBox()
        {
            string _name = cmbMechanic.SelectedItem.ToString();
            MemoryStream ms = DBWork.GetAvatar(_name);
            if (ms != null)
            {
                picBoxAvatar.Image = Image.FromStream(DBWork.GetAvatar(_name));                
            }
            else
            {
                picBoxAvatar.BackColor = Color.Black;
                picBoxAvatar.Image = null;
            }
        }
        // Когда изменилось значение в combobox
        private void cmbMechanic_SelectedValueChanged(object sender, EventArgs e)
        {
            SetImagePicterBox();
            // Если мы кого-то выбрали, то появляется возможность удалить или отредактировать его
            if (cmbMechanic.Text != string.Empty)
            {
                btnDeleteMaster.Enabled = true;
                lblEditMaster.Enabled = true;
                btnEditMaster.Enabled = true;
                tBEditMaster.Enabled = true;
                tBEditMaster.Text = cmbMechanic.Text;
                //tBCoefficient.Text = DBWork.GetCoefficient(cmbMechanic.Text);
            }
        }
        private void btnAddMaster_Click(object sender, EventArgs e)
        {
            // sql-запрос на добавление записи в таблицу
            DataChanged("INSERT INTO Mechanic (number, name) VALUES " +                        
                        $"('{tBNumberMaster.Text}', '{tBAddMaster.Text}');");
        }
        // Метод проверки заполненности обязательных полей при добавлении нового мастера
        private void TextChanged(object sender, EventArgs e)
        {
            if (tBNumberMaster.Text != string.Empty && tBAddMaster.Text != string.Empty) 
                btnAddMaster.Enabled = true;            
        }
        private void btnDeleteMaster_Click(object sender, EventArgs e)
        {            
            DataChanged("DELETE FROM Mechanic WHERE NAME = " +                        
                        $"'{cmbMechanic.Text}';"); // sql-запрос на удаление записи из таблицы
        }

        private void btnEditMaster_Click(object sender, EventArgs e)
        {
            if (tBEditMaster.Text != string.Empty ) // Если в строке редактирования что-то есть, то
            {                
                DataChanged("UPDATE Mechanic SET NAME = " +
                            $"'{tBEditMaster.Text}' WHERE NAME = " +
                            $"'{cmbMechanic.Text}';"); // sql-запрос на изменение записи в таблице
            }
        }

        private void DataChanged(string querry) // Общий код для кнопок "Добавить", "Удалить", "Редактировать"
        {
            string path = $"Data Source=AutoService.db;"; // Путь к базе данных
            SQLiteConnection conn = new SQLiteConnection(path); // Конструируем новое соединение с БД
            SQLiteCommand cmd01 = conn.CreateCommand(); // Инициализируем команду
            cmd01.CommandText = querry;
            conn.Open(); // Открываем соединение с БД
            cmd01.ExecuteNonQuery(); // Выполняем команду
            conn.Close(); // Закрываем соединение с БД
            cmbMechanic.Text = string.Empty; // Чистим строку в checkbox
            cmbMechanic.Items.Clear(); // Чистим список checkbox
            FillMechanicsName(); // Обновляем данные в checkbox
        }
    }
}
