using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Interface
{
    public partial class Authentification : Window
    {
        public Authentification()
        {
            InitializeComponent();
        }

        public List<string> UsersInfo = new List<string>(); //Лист хранения данных пользователей (логин + пароль)
        Registration reg = new Registration();  //Создаем поле для перехода на окно Регистрации

        public void But_Conf_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < UsersInfo.Count;)   //Сравниваем данные пользователей с введенными
            {
                if (UsersInfo[i] == Text_Log.Text && UsersInfo[i + 1] == Text_Pass.Password)
                    Label_Err.Content = "Вы вошли!";
                else
                    Label_Err.Content = "Введите данные заново";
                i += 2;
            }
            if (Label_Err.Content.ToString() == "")
                Label_Err.Content = "Вас не существует!";
        }

        public void But_Reg_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();    //Открываем окно Регистрации
            reg.Show();
        }
    }
}
