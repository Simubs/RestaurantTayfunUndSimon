﻿#pragma checksum "..\..\UmsatzuebersichtFenster.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CCD1816A0B1BC556880A78B3C98859B4DA5460540CD528A6E1926C254233C33C"
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
    /// UmsatzuebersichtFenster
    /// </summary>
    public partial class UmsatzuebersichtFenster : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\UmsatzuebersichtFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UmsatzTextBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\UmsatzuebersichtFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatumPicker;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\UmsatzuebersichtFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView TrinkgeldListView;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\UmsatzuebersichtFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ZurueckButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\UmsatzuebersichtFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AktualisierenButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\UmsatzuebersichtFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ProzentualeVeraenderungTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Restaurant;component/umsatzuebersichtfenster.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UmsatzuebersichtFenster.xaml"
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
            this.UmsatzTextBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.DatumPicker = ((System.Windows.Controls.DatePicker)(target));
            
            #line 14 "..\..\UmsatzuebersichtFenster.xaml"
            this.DatumPicker.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DatumGeaendert);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TrinkgeldListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.ZurueckButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\UmsatzuebersichtFenster.xaml"
            this.ZurueckButton.Click += new System.Windows.RoutedEventHandler(this.ZurueckButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AktualisierenButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\UmsatzuebersichtFenster.xaml"
            this.AktualisierenButton.Click += new System.Windows.RoutedEventHandler(this.AktualisierenButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ProzentualeVeraenderungTextBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

