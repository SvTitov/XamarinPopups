using System;
using iOS.Popup.Views;
using UIKit;

namespace iOS.Popup
{
    public partial class ViewController : UIViewController
    {

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            if (_openPopup != null)
                _openPopup.TouchUpInside += _openPopup_TouchUpInside;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        void _openPopup_TouchUpInside(object sender, EventArgs e)
        {
            this.PresentModalViewController(new PopupViewController() , true);
        }
    }
}
