﻿#pragma checksum "..\..\WAddPlayer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3584B2E03C6259A2C2D296098B70C1DFDA155DC1D439ED87F02BACA306203363"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using JDR;
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


namespace JDR {
    
    
    /// <summary>
    /// WAddPlayer
    /// </summary>
    public partial class WAddPlayer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\WAddPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bntReturnPlayer;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\WAddPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bntAddPlayer;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WAddPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPlayerName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\WAddPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPlayerName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\WAddPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bntPlayerInventory;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\WAddPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bntPlayerCapacity;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\WAddPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bntPlayerLife;
        
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
            System.Uri resourceLocater = new System.Uri("/JDR;component/waddplayer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WAddPlayer.xaml"
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
            this.bntReturnPlayer = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\WAddPlayer.xaml"
            this.bntReturnPlayer.Click += new System.Windows.RoutedEventHandler(this.bntReturnPlayer_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bntAddPlayer = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\WAddPlayer.xaml"
            this.bntAddPlayer.Click += new System.Windows.RoutedEventHandler(this.bntAddPlayer_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblPlayerName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtPlayerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.bntPlayerInventory = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\WAddPlayer.xaml"
            this.bntPlayerInventory.Click += new System.Windows.RoutedEventHandler(this.bntPlayerInventory_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.bntPlayerCapacity = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\WAddPlayer.xaml"
            this.bntPlayerCapacity.Click += new System.Windows.RoutedEventHandler(this.bntPlayerCapacity_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.bntPlayerLife = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\WAddPlayer.xaml"
            this.bntPlayerLife.Click += new System.Windows.RoutedEventHandler(this.bntPlayerLife_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

