﻿#pragma checksum "..\..\Sample Input.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BC80B6D037DF8645649403DE2B4C3B76"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using PerceptronTrainer;
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


namespace PerceptronTrainer {
    
    
    /// <summary>
    /// Sample_Input
    /// </summary>
    public partial class Sample_Input : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\Sample Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newSampleTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Sample Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewTrainSampleButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Sample Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock sampleInputsMatTextBlock;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Sample Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button confirmButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Sample Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearButton;
        
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
            System.Uri resourceLocater = new System.Uri("/PerceptronTrainer;component/sample%20input.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Sample Input.xaml"
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
            this.newSampleTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\Sample Input.xaml"
            this.newSampleTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.newSampleTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddNewTrainSampleButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Sample Input.xaml"
            this.AddNewTrainSampleButton.Click += new System.Windows.RoutedEventHandler(this.addNewTrainSampleButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.sampleInputsMatTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.confirmButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.ClearButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\Sample Input.xaml"
            this.ClearButton.Click += new System.Windows.RoutedEventHandler(this.ClearButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

