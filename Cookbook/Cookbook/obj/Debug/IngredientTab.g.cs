﻿#pragma checksum "..\..\IngredientTab.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B1E18A394A265F9B98FA3BD7073BE47284E2BD66"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Cookbook;
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


namespace Cookbook {
    
    
    /// <summary>
    /// IngredientTab
    /// </summary>
    public partial class IngredientTab : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\IngredientTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button checkbox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\IngredientTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush checkboxImageBrush;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\IngredientTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox unitChanger;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\IngredientTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button unitChangerButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\IngredientTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox subChanger;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\IngredientTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button subChangerButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\IngredientTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock primaryText;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\IngredientTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock secondaryText;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\IngredientTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock specialUnitText;
        
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
            System.Uri resourceLocater = new System.Uri("/Cookbook;component/ingredienttab.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\IngredientTab.xaml"
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
            this.checkbox = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\IngredientTab.xaml"
            this.checkbox.Click += new System.Windows.RoutedEventHandler(this.Checkbox_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.checkboxImageBrush = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 3:
            this.unitChanger = ((System.Windows.Controls.ComboBox)(target));
            
            #line 27 "..\..\IngredientTab.xaml"
            this.unitChanger.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.unitChanger_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.unitChangerButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\IngredientTab.xaml"
            this.unitChangerButton.Click += new System.Windows.RoutedEventHandler(this.unitChangerButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.subChanger = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\IngredientTab.xaml"
            this.subChanger.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.subChanger_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.subChangerButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\IngredientTab.xaml"
            this.subChangerButton.Click += new System.Windows.RoutedEventHandler(this.subChangerButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.primaryText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.secondaryText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.specialUnitText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

