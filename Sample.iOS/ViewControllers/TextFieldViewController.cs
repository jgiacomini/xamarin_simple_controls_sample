using System;
using UIKit;

namespace Sample.iOS.ViewControllers
{
    public class TextFieldViewController : UIViewController
    {
        public TextFieldViewController()
        {
			Title = "TextField sample";

			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;
        }
    }
}
