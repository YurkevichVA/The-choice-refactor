﻿#pragma checksum "..\..\..\..\..\Pages\MainPages\MetalPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "010A9D3C5462EAA507B7F0E23A5D682141BB6AE3"
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
using The_Choice_Refactor.Pages.MainPages;


namespace The_Choice_Refactor.Pages.MainPages {
    
    
    /// <summary>
    /// MetalPage
    /// </summary>
    public partial class MetalPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\..\..\Pages\MainPages\MetalPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_TxtBlck;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\Pages\MainPages\MetalPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox favoriteMode_ChBx;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\..\Pages\MainPages\MetalPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame ListBoxFrame_Frm;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/The-Choice-Refactor;component/pages/mainpages/metalpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\MainPages\MetalPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.search_TxtBlck = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\..\..\Pages\MainPages\MetalPage.xaml"
            this.search_TxtBlck.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.search_TxtBlck_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.favoriteMode_ChBx = ((System.Windows.Controls.CheckBox)(target));
            
            #line 58 "..\..\..\..\..\Pages\MainPages\MetalPage.xaml"
            this.favoriteMode_ChBx.Checked += new System.Windows.RoutedEventHandler(this.favoriteMode_ChBx_Checked);
            
            #line default
            #line hidden
            
            #line 59 "..\..\..\..\..\Pages\MainPages\MetalPage.xaml"
            this.favoriteMode_ChBx.Unchecked += new System.Windows.RoutedEventHandler(this.favoriteMode_ChBx_Unchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListBoxFrame_Frm = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

