using System;
using UIKit;

namespace Sample.iOS.ViewControllers
{
    public class LabelViewController : UIViewController
    {
        public LabelViewController()
        {
			Title = "Label sample";

			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;
        }
    }
}
