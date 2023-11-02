using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RestaurantFixedView.Entities
{
    public class Karten_Element : INotifyPropertyChanged
    {
        public int K_Elem_Nr {  get; set; }
        public double Preis {  get; set; }
        public int Element_Art_Nr { get; set; }
        public String Elem_Name {  get; set; }

        private int _anzahlBestellt;
        public int AnzahlBestellt
        {
            get => _anzahlBestellt;
            set
            {
                _anzahlBestellt = value;
                OnPropertyChanged(nameof(AnzahlBestellt));
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Button AnzahlErhoehenButton { get; set; }
        public Button AnzahlVerringernButton { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
