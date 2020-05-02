using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Interface
{
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();

        }
        
        public void But_Conf_Click(object sender, RoutedEventArgs e)
        {
            if (Text_Log.Text == "")    //Проверяем на ошибки введенные данные
                Label_Err.Content = "Введите логин!";
            else if (Text_Pass.Password != Text_PassConf.Password)
                Label_Err.Content = "Пароли не совпадают!";
            else if (Text_Pass.Password == Text_PassConf.Password)  //Если все хорошо, передаем данные о пользователе (логин + пароль)
            {                                                       //на хранение в лист и переходим в окно Авторизации для входа
                Authentification Auth = new Authentification();
                Auth.UsersInfo.Add(Text_Log.Text);
                Auth.UsersInfo.Add(Text_Pass.Password);
                Label_Err.Content = null;
                this.Hide();
                Auth.ShowDialog();
            }
        }

        private void But_Auth_Click(object sender, RoutedEventArgs e)   //В случае мисклика просто переходим в окно Авторизации
        {
            this.Hide();
            Authentification Auth = new Authentification();
            Auth.ShowDialog();
        }
    }
}
