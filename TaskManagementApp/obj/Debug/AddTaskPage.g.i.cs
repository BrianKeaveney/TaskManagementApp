﻿#pragma checksum "..\..\AddTaskPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C54280EC2D755C6756A7A1BFBD3A2B05044A016F"
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
using TaskManagementApp;


namespace TaskManagementApp {
    
    
    /// <summary>
    /// AddTaskPage
    /// </summary>
    public partial class AddTaskPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\AddTaskPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxTitle;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AddTaskPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxDescription;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AddTaskPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxCategory;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddTaskPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker tbxDueDate;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AddTaskPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxPriority;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AddTaskPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxLabels;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AddTaskPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxResponsibility;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AddTaskPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddUser;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\AddTaskPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFinish;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\AddTaskPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/TaskManagementApp;component/addtaskpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddTaskPage.xaml"
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
            
            #line 11 "..\..\AddTaskPage.xaml"
            ((TaskManagementApp.AddTaskPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbxTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbxDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cbxCategory = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.tbxDueDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.cbxPriority = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.tbxLabels = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.cbxResponsibility = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.btnAddUser = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\AddTaskPage.xaml"
            this.btnAddUser.Click += new System.Windows.RoutedEventHandler(this.btnAddUser_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnFinish = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\AddTaskPage.xaml"
            this.btnFinish.Click += new System.Windows.RoutedEventHandler(this.btnFinish_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\AddTaskPage.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

