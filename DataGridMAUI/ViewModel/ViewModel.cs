using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DataGridMAUI
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<OrderInfo> orderInfo;
        private ICommand buttonCommand;
        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderInfo; }
            set { this.orderInfo = value; RaisePropertyChanged("OrderInfoCollection"); }
        }

        public string HeaderText { get; set; }
        public ICommand ButtonCommand
        {
            get { return buttonCommand; }
            set { buttonCommand = value; }
        }

        public ViewModel()
        {
            this.HeaderText = "OrderID";
            this.OrderInfoCollection = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        public void GenerateOrders()
        {
            this.OrderInfoCollection.Add(new OrderInfo(1001, "Ana Trujillo", "Mexico", "ANATR"));
            this.OrderInfoCollection.Add(new OrderInfo(1002, "Ant Fuller", "Mexico", "ANTON"));
            this.OrderInfoCollection.Add(new OrderInfo(1003, "Thomas Hardy", "UK", "AROUT"));
            this.OrderInfoCollection.Add(new OrderInfo(1004, "Tim Adams", "Sweden", "BERGS"));
            this.OrderInfoCollection.Add(new OrderInfo(1005, "Hanna Moos", "Germany", "BLAUS"));
            this.OrderInfoCollection.Add(new OrderInfo(1006, "Andrew Fuller", "France", "BLONP"));
            this.OrderInfoCollection.Add(new OrderInfo(1007, "Martin King", "Spain", "BOLID"));
            this.OrderInfoCollection.Add(new OrderInfo(1008, "Lenny Lin", "France", "BONAP"));
            this.OrderInfoCollection.Add(new OrderInfo(1009, "John Carter", "Canada", "BOTTM"));
            this.OrderInfoCollection.Add(new OrderInfo(1010, "Laura King", "UK", "AROUT"));
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
