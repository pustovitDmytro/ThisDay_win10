﻿#pragma checksum "C:\Users\pusti\OneDrive\code\C#\windows_10\Цей день\MenuPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "86953B5C7D5198B4280BF965B8ED865C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Цей_день
{
    partial class MenuPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Setup_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 21 "..\..\..\MenuPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Setup_Button).Click += this.Setup_Button_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.Today_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\MenuPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Today_Button).Click += this.Today_Button_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.Search_box = (global::Windows.UI.Xaml.Controls.SearchBox)(target);
                    #line 23 "..\..\..\MenuPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.SearchBox)this.Search_box).QuerySubmitted += this.Search_box_QuerySubmitted;
                    #line default
                }
                break;
            case 4:
                {
                    this.select_date = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                    #line 24 "..\..\..\MenuPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CalendarDatePicker)this.select_date).DateChanged += this.select_date_DateChanged;
                    #line default
                }
                break;
            case 5:
                {
                    this.About_button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 25 "..\..\..\MenuPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.About_button).Click += this.About_button_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
