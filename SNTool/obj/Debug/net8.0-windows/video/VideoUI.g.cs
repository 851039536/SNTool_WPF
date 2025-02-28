﻿#pragma checksum "..\..\..\..\video\VideoUI.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A44DC729BAFB87EFBD7F139659F32EE909F9CE7F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Expression.Media;
using HandyControl.Expression.Shapes;
using HandyControl.Interactivity;
using HandyControl.Media.Animation;
using HandyControl.Media.Effects;
using HandyControl.Properties.Langs;
using HandyControl.Themes;
using HandyControl.Tools;
using HandyControl.Tools.Converter;
using HandyControl.Tools.Extension;
using SNTool.video;
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


namespace SNTool.video {
    
    
    /// <summary>
    /// VideoUI
    /// </summary>
    public partial class VideoUI : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\video\VideoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox myListBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\video\VideoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement me;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\video\VideoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider posSlider;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\video\VideoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTime;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\video\VideoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider volumeSlider;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\video\VideoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openBtn;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\video\VideoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playBtn;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\video\VideoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stopBtn;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\video\VideoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\video\VideoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button forwardBtn;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\video\VideoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openBtn1;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\video\VideoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTime1;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\video\VideoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playBtn1;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\video\VideoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTime2;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\video\VideoUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cut;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SNTool;component/video/videoui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\video\VideoUI.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 26 "..\..\..\..\video\VideoUI.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DelVideo);
            
            #line default
            #line hidden
            return;
            case 2:
            this.myListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.me = ((System.Windows.Controls.MediaElement)(target));
            
            #line 49 "..\..\..\..\video\VideoUI.xaml"
            this.me.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Me_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\..\video\VideoUI.xaml"
            this.me.MediaOpened += new System.Windows.RoutedEventHandler(this.Me_MediaOpened);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\..\video\VideoUI.xaml"
            this.me.MediaEnded += new System.Windows.RoutedEventHandler(this.Me_MediaEnded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.posSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 55 "..\..\..\..\video\VideoUI.xaml"
            this.posSlider.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.PosSlider_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblTime = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.volumeSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 7:
            this.openBtn = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\video\VideoUI.xaml"
            this.openBtn.Click += new System.Windows.RoutedEventHandler(this.OpenBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.playBtn = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\video\VideoUI.xaml"
            this.playBtn.Click += new System.Windows.RoutedEventHandler(this.PlayBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.stopBtn = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\video\VideoUI.xaml"
            this.stopBtn.Click += new System.Windows.RoutedEventHandler(this.StopBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\video\VideoUI.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.forwardBtn = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\..\video\VideoUI.xaml"
            this.forwardBtn.Click += new System.Windows.RoutedEventHandler(this.ForwardBtn_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.openBtn1 = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\video\VideoUI.xaml"
            this.openBtn1.Click += new System.Windows.RoutedEventHandler(this.HeadLocation);
            
            #line default
            #line hidden
            return;
            case 13:
            this.lblTime1 = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.playBtn1 = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\video\VideoUI.xaml"
            this.playBtn1.Click += new System.Windows.RoutedEventHandler(this.BackLocation);
            
            #line default
            #line hidden
            return;
            case 15:
            this.lblTime2 = ((System.Windows.Controls.Label)(target));
            return;
            case 16:
            this.cut = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\..\video\VideoUI.xaml"
            this.cut.Click += new System.Windows.RoutedEventHandler(this.CutVideo);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 83 "..\..\..\..\video\VideoUI.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Merge);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 86 "..\..\..\..\video\VideoUI.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CutVideoPath);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 87 "..\..\..\..\video\VideoUI.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MergePath);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

