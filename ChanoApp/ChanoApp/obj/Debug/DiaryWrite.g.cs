﻿#pragma checksum "..\..\DiaryWrite.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4C2BD87786DA7DF79B605737F50367CE9AF8BF790C619407C16ADF6E782743F3"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using ChanoApp;
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


namespace ChanoApp {
    
    
    /// <summary>
    /// DiaryWrite
    /// </summary>
    public partial class DiaryWrite : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\DiaryWrite.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox diaryText;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\DiaryWrite.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox titleText;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\DiaryWrite.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newFileBtn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\DiaryWrite.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newTabBtn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\DiaryWrite.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveBtn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\DiaryWrite.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label WorkLog;
        
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
            System.Uri resourceLocater = new System.Uri("/ChanoApp;component/diarywrite.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DiaryWrite.xaml"
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
            this.diaryText = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\DiaryWrite.xaml"
            this.diaryText.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.diaryText_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.titleText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.newFileBtn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\DiaryWrite.xaml"
            this.newFileBtn.Click += new System.Windows.RoutedEventHandler(this.NewFileBtnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.newTabBtn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\DiaryWrite.xaml"
            this.newTabBtn.Click += new System.Windows.RoutedEventHandler(this.NewTabBtnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.saveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\DiaryWrite.xaml"
            this.saveBtn.Click += new System.Windows.RoutedEventHandler(this.SaveBtnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.WorkLog = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

