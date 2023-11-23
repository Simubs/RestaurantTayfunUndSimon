using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Restaurant.Constants
{
    public static class Constants
    {
        public static readonly Brush DEFAULT_BACKGROUND_COLOR = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF4545F5"));
        public static readonly string DEFAULT_BACKGROUND_COLOR_AS_STRING = "#FF4545F5";
        public const string RECHNUNG_DATEI_PFAD = @"..\..\Rechnungen\";
        public const string FALSCHE_EINGABEN_FEHLERMELDUNG = "Bitte überprüfen Sie Ihre Eingaben.";
    }
}
