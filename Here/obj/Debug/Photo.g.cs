﻿#pragma checksum "C:\Users\usanov_aa\Documents\GitHub\here\Here\Photo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EE97193D70500AE2B74211F4F832D9B5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Here {
    
    
    public partial class Photo : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.ProgressBar pread;
        
        internal Microsoft.Phone.Controls.WebBrowser FhotoView;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Here;component/Photo.xaml", System.UriKind.Relative));
            this.pread = ((System.Windows.Controls.ProgressBar)(this.FindName("pread")));
            this.FhotoView = ((Microsoft.Phone.Controls.WebBrowser)(this.FindName("FhotoView")));
        }
    }
}

