// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iOS.Popup.Views
{
    [Register ("PopupViewController")]
    partial class PopupViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton agree { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WebKit.WKWebView webview { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (agree != null) {
                agree.Dispose ();
                agree = null;
            }

            if (webview != null) {
                webview.Dispose ();
                webview = null;
            }
        }
    }
}