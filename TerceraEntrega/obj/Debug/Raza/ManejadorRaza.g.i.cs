﻿#pragma checksum "..\..\..\Raza\ManejadorRaza.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F9157F054CBB43C7C54CEB10EBDD41FB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TerceraEntrega;


namespace TerceraEntrega {
    
    
    /// <summary>
    /// ManejadorRaza
    /// </summary>
    public partial class ManejadorRaza : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Raza\ManejadorRaza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NomTxt;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Raza\ManejadorRaza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DesTxt;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Raza\ManejadorRaza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListRaza;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Raza\ManejadorRaza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BonusTxt;
        
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
            System.Uri resourceLocater = new System.Uri("/TerceraEntrega;component/raza/manejadorraza.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Raza\ManejadorRaza.xaml"
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
            this.NomTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.DesTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ListRaza = ((System.Windows.Controls.ListView)(target));
            
            #line 16 "..\..\..\Raza\ManejadorRaza.xaml"
            this.ListRaza.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListClase_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 23 "..\..\..\Raza\ManejadorRaza.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btoCargar);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 24 "..\..\..\Raza\ManejadorRaza.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btoModificar);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 25 "..\..\..\Raza\ManejadorRaza.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btoEliminar);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 26 "..\..\..\Raza\ManejadorRaza.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btoVolver);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BonusTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

