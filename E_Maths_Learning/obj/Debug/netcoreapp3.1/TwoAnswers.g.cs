#pragma checksum "..\..\..\TwoAnswers.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "451F654CEB0B57EB969F5A9157B47FC6AD1F5DE7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using E_Maths_Learning;
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


namespace E_Maths_Learning {
    
    
    /// <summary>
    /// TwoAnswers
    /// </summary>
    public partial class TwoAnswers : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\TwoAnswers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox value1TxtBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\TwoAnswers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox value2TxtBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\TwoAnswers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label value1Label;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\TwoAnswers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label value2Label;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/E_Maths_Learning;component/twoanswers.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TwoAnswers.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.value1TxtBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\TwoAnswers.xaml"
            this.value1TxtBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.value1TxtBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.value2TxtBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\TwoAnswers.xaml"
            this.value2TxtBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.value2TxtBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.value1Label = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.value2Label = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

