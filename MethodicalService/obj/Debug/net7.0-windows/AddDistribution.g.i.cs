﻿#pragma checksum "..\..\..\AddDistribution.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F7B5C5D0812AC02939E8543784492A5B21FAF641"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MethodicalService;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace MethodicalService {
    
    
    /// <summary>
    /// AddDistribution
    /// </summary>
    public partial class AddDistribution : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\AddDistribution.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ID_Distribution;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\AddDistribution.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textNumberUPD;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\AddDistribution.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textStatus;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\AddDistribution.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textName;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\AddDistribution.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePick;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\AddDistribution.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboDevelop;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\AddDistribution.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textNote;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\AddDistribution.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDistribut;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\AddDistribution.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCancel;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\AddDistribution.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonEdit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MethodicalService;component/adddistribution.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddDistribution.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ID_Distribution = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.textNumberUPD = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.textStatus = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.textName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.datePick = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.comboDevelop = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.textNote = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.buttonDistribut = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\AddDistribution.xaml"
            this.buttonDistribut.Click += new System.Windows.RoutedEventHandler(this.ButtonDistribut_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonCancel = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.buttonEdit = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\AddDistribution.xaml"
            this.buttonEdit.Click += new System.Windows.RoutedEventHandler(this.ButtonEdit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

