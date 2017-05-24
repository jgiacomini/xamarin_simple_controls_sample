using System;
using CoreGraphics;
using UIKit;

namespace Sample.iOS.ViewControllers
{
    public class AlertViewController : UIViewController
    {
        UIButton _displaySimpleAlertButton;

		UIButton _displayComplexAlertButton;

		UIButton _displayActionSheetButton;

		UIButton _displayLogOutButton;

        public AlertViewController()
        {
            Title = "Alert sample";
			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


			_displaySimpleAlertButton = UIButton.FromType(UIButtonType.System);
			_displaySimpleAlertButton.Frame = new CGRect(10, 10, View.Bounds.Width - 20, 40);
			_displaySimpleAlertButton.SetTitle("Alerte simple", UIControlState.Normal);
			_displaySimpleAlertButton.TouchUpInside += _displaySimpleAlertButton_TouchUpInside;


			_displayComplexAlertButton = UIButton.FromType(UIButtonType.System);
			_displayComplexAlertButton.Frame = new CGRect(10, 60, View.Bounds.Width - 20, 40);
			_displayComplexAlertButton.SetTitle("Alerte complexe", UIControlState.Normal);
			_displayComplexAlertButton.TouchUpInside += _displayComplexAlertButton_TouchUpInside;


			_displayActionSheetButton = UIButton.FromType(UIButtonType.System);
			_displayActionSheetButton.Frame = new CGRect(10, 110, View.Bounds.Width - 20, 40);
			_displayActionSheetButton.SetTitle("Action Sheet", UIControlState.Normal);
            _displayActionSheetButton.TouchUpInside += _displayActionSheetButton_TouchUpInside;


            _displayLogOutButton = UIButton.FromType(UIButtonType.System);
            _displayLogOutButton.SetTitleColor(UIColor.Red, UIControlState.Normal);
            _displayLogOutButton.Frame = new CGRect(10, 160, View.Bounds.Width - 20, 40);
            _displayLogOutButton.SetTitle("Déconnexion", UIControlState.Normal);
            _displayLogOutButton.TouchUpInside += _displayLogOutButton_TouchUpInside;

            this.View.AddSubviews(_displaySimpleAlertButton, _displayComplexAlertButton, _displayActionSheetButton, _displayLogOutButton);
		}

		async void _displaySimpleAlertButton_TouchUpInside(object sender, EventArgs e)
		{
            UIAlertController alert = UIAlertController.Create("Titre", "Message", UIAlertControllerStyle.Alert);

			// Ajout des différentes actions
			alert.AddAction(UIAlertAction.Create("Option 42", UIAlertActionStyle.Default, (action) => Console.WriteLine("Option '42' selectionnée")));

			alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Destructive, (action) => Console.WriteLine("Option 'OK' selectionnée")));

			alert.AddAction(UIAlertAction.Create("Annuler", UIAlertActionStyle.Cancel, (action) => Console.WriteLine("Option 'Annuler' selectionnée.")));

			// Affiche l'alerte
			await this.PresentViewControllerAsync(alert, true);
		}


		async void _displayComplexAlertButton_TouchUpInside(object sender, EventArgs e)
		{
			UIAlertController alert = UIAlertController.Create("Titre", "Message", UIAlertControllerStyle.Alert);


            alert.AddTextField((textField) => { });

			// Ajout des différentes actions
			alert.AddAction(UIAlertAction.Create("Option 42", UIAlertActionStyle.Default, (action) => Console.WriteLine("Option '42' selectionnée")));

			alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Destructive, (action) => Console.WriteLine("Option 'OK' selectionnée")));

			alert.AddAction(UIAlertAction.Create("Annuler", UIAlertActionStyle.Cancel, (action) => Console.WriteLine("Option 'Annuler' selectionnée.")));

			// Affiche l'alerte
            await this.PresentViewControllerAsync(alert, true);


		}

        async void _displayActionSheetButton_TouchUpInside(object sender, EventArgs e)
        {
            UIAlertController actionSheetAlert = UIAlertController.Create("Titre", "Message", UIAlertControllerStyle.ActionSheet);

			// Ajout des différentes actions
			actionSheetAlert.AddAction(UIAlertAction.Create("Option 1", UIAlertActionStyle.Default, (action) => Console.WriteLine("Option '42' selectionnée")));

            actionSheetAlert.AddAction(UIAlertAction.Create("Option 42", UIAlertActionStyle.Destructive, (action) => Console.WriteLine("Option 'OK' selectionnée")));

			actionSheetAlert.AddAction(UIAlertAction.Create("Annuler", UIAlertActionStyle.Cancel, (action) => Console.WriteLine("Option 'Annuler' selectionnée.")));

            // Affiche l'alerte
            await this.PresentViewControllerAsync(actionSheetAlert, true);
        }

		async void _displayLogOutButton_TouchUpInside(object sender, EventArgs e)
		{
			UIAlertController actionSheetAlert = UIAlertController.Create(null, "Souhaitez-vous vraiment vous déconnecter ?", UIAlertControllerStyle.ActionSheet);

			// Ajout des différentes actions
			actionSheetAlert.AddAction(UIAlertAction.Create("Déconnexion", UIAlertActionStyle.Destructive, (action) => Console.WriteLine("Option 'OK' selectionnée")));

			actionSheetAlert.AddAction(UIAlertAction.Create("Annuler", UIAlertActionStyle.Cancel, (action) => Console.WriteLine("Option 'Annuler' selectionnée.")));

			// Affiche l'alerte
            await this.PresentViewControllerAsync(actionSheetAlert, true);
		}
    }
}
