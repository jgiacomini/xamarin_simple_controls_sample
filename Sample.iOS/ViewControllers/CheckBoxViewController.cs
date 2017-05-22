using System;
using UIKit;

namespace Sample.iOS.ViewControllers
{
	public class CheckBoxViewController : UIViewController
	{
		public CheckBoxViewController()
		{
			Title = "Switch sample";
			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;
		}
	}
}
