using System;
using UIKit;

namespace Sample.iOS.ViewControllers
{
    public class AlertViewController : UIViewController
    {
        public AlertViewController()
        {
            Title = "Alert sample";
			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;
        }
    }
}
