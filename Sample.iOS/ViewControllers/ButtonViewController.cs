using System;
using CoreGraphics;
using UIKit;

namespace Sample.iOS.ViewControllers
{
    public class ButtonViewController : UIViewController
    {
        UIButton _monBouton, _monBoutonDesactive;

        public ButtonViewController()
        {
            Title = "Afficher un bouton";
			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;

            _monBouton = UIButton.FromType(UIButtonType.System);
			_monBouton.Frame = new CGRect(10, 10, View.Bounds.Width - 20, 40);
			_monBouton.SetTitle("Le texte", UIControlState.Normal);
            _monBouton.TouchUpInside += _monBouton_TouchUpInside;;

			_monBouton.SetTitle("Le texte bouton état 'normal'", UIControlState.Normal);
            _monBouton.SetTitle("Le texte bouton état enfoncé", UIControlState.Highlighted);
			_monBouton.SetTitle("Le texte bouton état désactivé", UIControlState.Disabled);
            _monBouton.BackgroundColor = UIColor.Green;

            _monBoutonDesactive = UIButton.FromType(UIButtonType.ContactAdd);
			_monBoutonDesactive.Frame = new CGRect(10, 60, View.Bounds.Width - 20, 40);
			_monBoutonDesactive.SetTitle("Le texte", UIControlState.Normal);
            _monBoutonDesactive.SetTitle("Le texte (désactivé)", UIControlState.Disabled);
			_monBoutonDesactive.SetTitleColor(UIColor.Red, UIControlState.Disabled);
            _monBoutonDesactive.Enabled = false;
			_monBoutonDesactive.BackgroundColor = UIColor.Green;

			View.AddSubviews(_monBouton, _monBoutonDesactive);
		}

        void _monBouton_TouchUpInside(object sender, EventArgs e)
        {
            Console.WriteLine("Bouton clické");
        }
    }
}
