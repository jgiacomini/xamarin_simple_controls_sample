using System;
using UIKit;

namespace Sample.iOS.ViewControllers
{
    public class SliderViewController : UIViewController
    {
        public SliderViewController()
        {
			Title = "Slider sample";

			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;
        }
    }
}
