﻿#pragma checksum "..\..\BestellFenster.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EF2FA322E1A35AA5B1463809B579A747C6548F8348DDB6EE8228AE8C760FECF3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Restaurant;
using Restaurant.Entitys;
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
    /// BestellFenster
    /// </summary>
    public partial class BestellFenster : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\BestellFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zurueck;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\BestellFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TischWechselnButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\BestellFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BestellungAbschickenButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\BestellFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hinweiseTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\BestellFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AbrechnenButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\BestellFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid KartenElementeGridView;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\BestellFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid BestellungenDataGrid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\BestellFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn BestellungDataGrid;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\BestellFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button elementhinzufuegen;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\BestellFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loeschen;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\BestellFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ElementArtAuswahlComboBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Restaurant;component/bestellfenster.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BestellFenster.xaml"
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
            this.zurueck = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\BestellFenster.xaml"
            this.zurueck.Click += new System.Windows.RoutedEventHandler(this.zurueck_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TischWechselnButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\BestellFenster.xaml"
            this.TischWechselnButton.Click += new System.Windows.RoutedEventHandler(this.TischWechselnButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BestellungAbschickenButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\BestellFenster.xaml"
            this.BestellungAbschickenButton.Click += new System.Windows.RoutedEventHandler(this.BestellungAbschicken_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.hinweiseTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AbrechnenButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\BestellFenster.xaml"
            this.AbrechnenButton.Click += new System.Windows.RoutedEventHandler(this.AbrechnenButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.KartenElementeGridView = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.BestellungenDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.BestellungDataGrid = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 9:
            this.elementhinzufuegen = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\BestellFenster.xaml"
            this.elementhinzufuegen.Click += new System.Windows.RoutedEventHandler(this.HinzufuegenButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.loeschen = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\BestellFenster.xaml"
            this.loeschen.Click += new System.Windows.RoutedEventHandler(this.loeschenButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ElementArtAuswahlComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\BestellFenster.xaml"
            this.ElementArtAuswahlComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.KartenElementArtGeändert);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

