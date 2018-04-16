using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace iOS.Popup.Views
{
    public partial class PopupViewController : UIViewController
    {
        public PopupViewController() : base("PopupViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.


            var url = NSBundle.MainBundle.GetUrlForResource("hh", "html");

            webview.LoadRequest(new NSUrlRequest(url));
            this.NavigationItem.LeftBarButtonItem = new UIBarButtonItem("Back", UIBarButtonItemStyle.Done, (sender, e) => { });
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

