﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "137429BFF26A5413CF97B75395CD4752DF17FF1AD2F7FAF99CB792C551204E8B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DoAn1;
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


namespace DoAn1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 107 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock abc;
        
        #line default
        #line hidden
        
        
        #line 385 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TenUser;
        
        #line default
        #line hidden
        
        
        #line 391 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Error;
        
        #line default
        #line hidden
        
        
        #line 394 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton easy;
        
        #line default
        #line hidden
        
        
        #line 395 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton hard;
        
        #line default
        #line hidden
        
        
        #line 396 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image phaichonmode;
        
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
            System.Uri resourceLocater = new System.Uri("/Game Doan So;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 18 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.DockPanel)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DockPanel_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 22 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Image)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_PreviewMouseDown_1);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 36 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Image)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 66 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseDown_Imotal);
            
            #line default
            #line hidden
            
            #line 67 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Image_MouseEnter_Imotal);
            
            #line default
            #line hidden
            return;
            case 5:
            this.abc = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            
            #line 154 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseDown_Rule);
            
            #line default
            #line hidden
            
            #line 155 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Image_MouseEnter_Imotal);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 242 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseDown_Score);
            
            #line default
            #line hidden
            
            #line 243 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Image_MouseEnter_Imotal);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 363 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 365 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseDown_1);
            
            #line default
            #line hidden
            return;
            case 10:
            this.TenUser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 387 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseDown_2);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 389 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseDown_3);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Error = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.easy = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 15:
            this.hard = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 16:
            this.phaichonmode = ((System.Windows.Controls.Image)(target));
            return;
            case 17:
            
            #line 416 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseDown_4);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

