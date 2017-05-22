using System;
using UIKit;

namespace Sample.iOS.ViewControllers
{
    public class ButtonViewController : UIViewController
    {
        public ButtonViewController()
        {
            Title = "Button sample";
			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;
        }
    }
}
