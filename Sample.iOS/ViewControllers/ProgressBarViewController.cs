using System;
using UIKit;

namespace Sample.iOS.ViewControllers
{
    public class ProgressBarViewController : UIViewController
    {
        public ProgressBarViewController()
        {
			Title = "ProgressBar sample";

			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;
        }
    }
}
