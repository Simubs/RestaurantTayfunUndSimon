﻿#pragma checksum "..\..\RechnungAnsicht.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "475075BAE4A8654763632BD0DC62D3B0A34180828015329A5FF64A31BFFDE7AF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Restaurant.Constants;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Restaurant {
    
    
    /// <summary>
    /// RechnungAnsicht
    /// </summary>
    public partial class RechnungAnsicht : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\RechnungAnsicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Titel;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\RechnungAnsicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid OffeneBestellungenDataGrid;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\RechnungAnsicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AusgewaehlteBestellungenDataGrid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\RechnungAnsicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BezahlenButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\RechnungAnsicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TrinkgeldLabel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\RechnungAnsicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox zehnCheckBox1;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\RechnungAnsicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox fuenfzehnCheckBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\RechnungAnsicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox zwanzigCheckBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\RechnungAnsicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zurueckButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\RechnungAnsicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button elementhinzufuegen;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\RechnungAnsicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loeschen;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\RechnungAnsicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label BetragLabel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Restaurant;component/rechnungansicht.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RechnungAnsicht.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Titel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.OffeneBestellungenDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.AusgewaehlteBestellungenDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.BezahlenButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\RechnungAnsicht.xaml"
            this.BezahlenButton.Click += new System.Windows.RoutedEventHandler(this.BezahlenButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TrinkgeldLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.zehnCheckBox1 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 28 "..\..\RechnungAnsicht.xaml"
            this.zehnCheckBox1.Checked += new System.Windows.RoutedEventHandler(this.zehnCheckBox_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.fuenfzehnCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 29 "..\..\RechnungAnsicht.xaml"
            this.fuenfzehnCheckBox.Checked += new System.Windows.RoutedEventHandler(this.fuenfzehnCheckBox_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.zwanzigCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 30 "..\..\RechnungAnsicht.xaml"
            this.zwanzigCheckBox.Checked += new System.Windows.RoutedEventHandler(this.zwanzigCheckBox_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.zurueckButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\RechnungAnsicht.xaml"
            this.zurueckButton.Click += new System.Windows.RoutedEventHandler(this.zurueckButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.elementhinzufuegen = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\RechnungAnsicht.xaml"
            this.elementhinzufuegen.Click += new System.Windows.RoutedEventHandler(this.HinzufuegenButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.loeschen = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\RechnungAnsicht.xaml"
            this.loeschen.Click += new System.Windows.RoutedEventHandler(this.loeschenButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.BetragLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

