﻿#pragma checksum "..\..\ex2 - Копировать.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1124E59EDBFDEE38582CA44E4AB2BCD786F19C2AA24522F1A7CC6F512C77761E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// ex2
    /// </summary>
    public partial class ex2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\ex2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ex2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Canvas;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ex2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Canvas2;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ex2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frame1;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ex2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox1;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\ex2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Checkboxx;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\ex2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\ex2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\ex2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b1;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\ex2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b2;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\ex2 - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/ex2%20-%20%d0%9a%d0%be%d0%bf%d0%b8%d1%80%d0%be%d0%b2%d0%b0%d1%" +
                    "82%d1%8c.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ex2 - Копировать.xaml"
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
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Canvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 26 "..\..\ex2 - Копировать.xaml"
            this.Canvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.Canvas_MouseMove);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 28 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Canvas2 = ((System.Windows.Controls.Canvas)(target));
            return;
            case 5:
            this.frame1 = ((System.Windows.Controls.Frame)(target));
            return;
            case 6:
            this.textBox1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 38 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_5);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 43 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 48 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_15);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 53 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Checkboxx = ((System.Windows.Controls.CheckBox)(target));
            
            #line 58 "..\..\ex2 - Копировать.xaml"
            this.Checkboxx.Checked += new System.Windows.RoutedEventHandler(this.Checkboxx_Checked);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 59 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 13:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            
            #line 66 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenPages);
            
            #line default
            #line hidden
            return;
            case 16:
            this.b1 = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\ex2 - Копировать.xaml"
            this.b1.Click += new System.Windows.RoutedEventHandler(this.Button_Click_7);
            
            #line default
            #line hidden
            return;
            case 17:
            this.b2 = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\ex2 - Копировать.xaml"
            this.b2.Click += new System.Windows.RoutedEventHandler(this.Button_Click_8);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 81 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_13);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 87 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 20:
            this.tb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 21:
            
            #line 106 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 114 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 125 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 136 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 147 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 158 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 169 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 180 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 191 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 202 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 31:
            
            #line 213 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 32:
            
            #line 224 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 33:
            
            #line 235 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Result_click);
            
            #line default
            #line hidden
            return;
            case 34:
            
            #line 246 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 35:
            
            #line 257 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Del_Click);
            
            #line default
            #line hidden
            return;
            case 36:
            
            #line 268 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.R_Erase);
            
            #line default
            #line hidden
            return;
            case 37:
            
            #line 321 "..\..\ex2 - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Info);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

