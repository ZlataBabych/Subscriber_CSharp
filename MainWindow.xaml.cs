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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using Subscriber;

namespace Subscriber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        public static DataAccess DataConnection;
        public static Subscriber_ editedSubscriber_;
        public static Authorization logedUser = new Authorization();


        public MainWindow()
        {
            InitializeComponent();
        }
        //public MainWindow()
        //{
        //    InitializeComponent();
        //}
        //public class Subscriber { }



        private void InfoSubscriber_Form_Loaded(object sender, RoutedEventArgs e)
        {

            selSubscriber_GroupBox.Visibility = Visibility.Hidden;
            DataConnection = new DataAccess();
            Subscriber_ListDG.ItemsSource = DataConnection.fList;

            //subscriber_GroupBox.Visibility = Visibility.Hidden;
            //Subscriber_ListDG.Visibility = Visibility.Hidden;

            // Зміна розмірів форми.
            this.SizeToContent = SizeToContent.Manual;
            Subscriber_ListDG.Height = 420;
            this.Width = Subscriber_ListDG.Margin.Left + Subscriber_ListDG.RenderSize.Width + 90;
            this.Height = Subscriber_ListDG.Margin.Top + Subscriber_ListDG.RenderSize.Height + 90;
            // Організація інтерфейсу Customer.
            // Пунк головного меню Рейси — Редагувати є невидимий.
            Subscriber_MenuItem.Visibility = Visibility.Hidden;
            Subscriber_MenuItem.Width = 0;
        }

        private void SaveDataMenuItem_Click(object sender, RoutedEventArgs e)
        {
            //if ((selSubscriber_GroupBox.Visibility == Visibility.Visible) && (selXY.selectedNameList.Count > 0))
            //{
            //    selXY.WriteData(selXY.selectedNameList, selXY.selectedYearList);
            //}
            //if (subscriber_GroupBox.Visibility == Visibility.Visible)
            //{
            //    if ((Subscriber_ListDG.SelectedIndex < 0) && (!editedSubscriber_.subscriber_Add))
            //    {
            //        MessageBox.Show("Оберіть у списку абонент для редагування", "Увага!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            //    }
            //    else
            //    {
            //        ChangeSubscriber_ListData(editedSubscriber_.subscriber_Num);
            //        editedSubscriber_.ChangeDBSubscriber_();
            //    }
            //}
        }

        private void AuthMenuItem_Click(object sender, RoutedEventArgs e)
        {
            LoginForm lowWnd = new LoginForm();
            lowWnd.Show();
            this.Visibility = Visibility.Collapsed;
        }
    }
}
