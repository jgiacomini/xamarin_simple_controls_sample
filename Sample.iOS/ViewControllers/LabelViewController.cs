using System;
using CoreGraphics;
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

            var monLabel = new UILabel();
            monLabel.Frame = new CGRect(10, 10, View.Bounds.Width - 20, 40);
			monLabel.Text = "Affiche un texte simple";
			monLabel.TextColor = UIColor.Blue;

			// Ajoute le label à la vue principale
			View.AddSubview(monLabel);

		}
    }
}
