﻿#pragma checksum "..\..\WindowAdd.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A529AD7D8116B7C67772BC7323A3226582B13418C3909C8FBB15886143E64ABC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Lab3;
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


namespace Lab3 {
    
    
    /// <summary>
    /// WindowAdd
    /// </summary>
    public partial class WindowAdd : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\WindowAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_add_item;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\WindowAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_name;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\WindowAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_count;
        
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
            System.Uri resourceLocater = new System.Uri("/Lab3;component/windowadd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowAdd.xaml"
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
            this.button_add_item = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\WindowAdd.xaml"
            this.button_add_item.Click += new System.Windows.RoutedEventHandler(this.button_add_item_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textbox_name = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\WindowAdd.xaml"
            this.textbox_name.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NameTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textbox_count = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\WindowAdd.xaml"
            this.textbox_count.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.CountTextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

