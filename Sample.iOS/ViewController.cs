using CoreGraphics;
using System;

using UIKit;

namespace Sample.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
            var customLabel = new UILabel(new CGRect(0, 0, 300, 30));
            customLabel.Text = "Affiche un texte";
            customLabel.TextColor = UIColor.Blue;

            // Ajoute le label à la vue principale
            View.AddSubview(customLabel);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}