using System;
using System.Collections.Generic;

namespace Subscriber
{   
    public class Subscriber_
    {
        public uint id { get; set; }
        public int numberPhone { get; set; }
        public string name { get; set; }
        public int year { get; set; }  
        public string address { get; set; }

        public Subscriber_(uint id_, int numberPhone_, string name_, int year_, string address_)
        {
            this.id = id_;
            this.name = name_;
            this.year = year_;
            this.numberPhone = numberPhone_;
            this.address = address_;
        }
        //private void InfoSubscriberForm_Loaded(object sender, RoutedEventArgs e)
        //{
        //    selSubscriberGroupBox.Visibility = Visibility.Hidden;
        //    DataConnection = new DataAccess();

        //    // Передача колекції рейсів у DataGrid. FlightListDG.ItemsSource = DataConnection.flist;
        //    SubscriberListDG.ItemSource = DataConnection.fList;

        //    // Поля визначення міста для вибору рейсів не видимі. flightGroupBox.Visibility = Visibility.Hidden;
        //    subscriberGroupBox.Visibility = Visibility.Hidden;

        //    // Зміна розмірів форми.
        //    this.SizeToContent = SizeToContent.Manual;
        //    SubscriberListDG.Height = 420;
        //    this.Width = SubscriberListDG.Margin.Left + SubscriberListDG.RenderSize.Width + 90;
        //    this.Height = SubscriberListDG.Margin.Top + SubscriberListDG.RenderSize.Height + 90;
        //    // Організація інтерфейсу Customer.
        //    // Пунк головного меню Рейси — Редагувати є невидимий.
        //    SubscriberMenuItem.Visibility = Visibility.Hidden;
        //    SubscriberMenuItem.Width = 0;
        //}
    }
}