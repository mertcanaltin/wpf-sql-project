﻿#pragma checksum "..\..\bilgiEkrani.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90EAB556D95D822704B305F68ACA0160B55AAF32"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using ryProje02;


namespace ryProje02 {
    
    
    /// <summary>
    /// bilgiEkrani
    /// </summary>
    public partial class bilgiEkrani : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\bilgiEkrani.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ryProje02.bilgiEkrani bildirimEkrani;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\bilgiEkrani.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label bilgiEkraniIcerik;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\bilgiEkrani.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bilgiEkraniKapat;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\bilgiEkrani.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image olumluResim;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\bilgiEkrani.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image olumsuzResim;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\bilgiEkrani.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse olumluMesaj;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\bilgiEkrani.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border mesajBaslik;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\bilgiEkrani.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse olumsuzMesaj;
        
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
            System.Uri resourceLocater = new System.Uri("/ryProje02;component/bilgiekrani.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\bilgiEkrani.xaml"
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
            this.bildirimEkrani = ((ryProje02.bilgiEkrani)(target));
            
            #line 9 "..\..\bilgiEkrani.xaml"
            this.bildirimEkrani.Loaded += new System.Windows.RoutedEventHandler(this.bilgiEkrani_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bilgiEkraniIcerik = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.bilgiEkraniKapat = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\bilgiEkrani.xaml"
            this.bilgiEkraniKapat.Click += new System.Windows.RoutedEventHandler(this.bilgiEkraniKapat_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.olumluResim = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.olumsuzResim = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.olumluMesaj = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 7:
            this.mesajBaslik = ((System.Windows.Controls.Border)(target));
            return;
            case 8:
            this.olumsuzMesaj = ((System.Windows.Shapes.Ellipse)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

