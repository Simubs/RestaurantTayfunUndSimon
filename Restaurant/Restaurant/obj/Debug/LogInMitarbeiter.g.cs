﻿#pragma checksum "..\..\LogInMitarbeiter.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4D9EA857C57092A32B04CA083F0F72C346FA32387A75AD8D46ACB54B3D5B747C"
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
    /// LogInMitarbeiter
    /// </summary>
    public partial class LogInMitarbeiter : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\LogInMitarbeiter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\LogInMitarbeiter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextboxMitarbeiternummer;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\LogInMitarbeiter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswortBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\LogInMitarbeiter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonZurueck;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\LogInMitarbeiter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonLogIn;
        
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
            System.Uri resourceLocater = new System.Uri("/Restaurant;component/loginmitarbeiter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LogInMitarbeiter.xaml"
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
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.TextboxMitarbeiternummer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.PasswortBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.ButtonZurueck = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\LogInMitarbeiter.xaml"
            this.ButtonZurueck.Click += new System.Windows.RoutedEventHandler(this.clickZurueckButton);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonLogIn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\LogInMitarbeiter.xaml"
            this.ButtonLogIn.Click += new System.Windows.RoutedEventHandler(this.clickLogInButton);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

