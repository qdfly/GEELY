﻿#pragma checksum "..\..\..\Dialogs\BatchAddCartWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "901612C5E1FD0848EBDAEEF064BE569F2F6A5825"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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


namespace GeelyPTL.Dialogs {
    
    
    /// <summary>
    /// BatchAddCartWindow
    /// </summary>
    public partial class BatchAddCartWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Dialogs\BatchAddCartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxFrom;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Dialogs\BatchAddCartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxCount;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Dialogs\BatchAddCartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxTo;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Dialogs\BatchAddCartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonOK;
        
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
            System.Uri resourceLocater = new System.Uri("/服务控制台;component/dialogs/batchaddcartwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dialogs\BatchAddCartWindow.xaml"
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
            
            #line 9 "..\..\..\Dialogs\BatchAddCartWindow.xaml"
            ((GeelyPTL.Dialogs.BatchAddCartWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBoxFrom = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\Dialogs\BatchAddCartWindow.xaml"
            this.textBoxFrom.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBoxFrom_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textBoxCount = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\Dialogs\BatchAddCartWindow.xaml"
            this.textBoxCount.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBoxCount_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBoxTo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.buttonOK = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Dialogs\BatchAddCartWindow.xaml"
            this.buttonOK.Click += new System.Windows.RoutedEventHandler(this.buttonOK_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

