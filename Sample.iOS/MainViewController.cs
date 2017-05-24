using CoreGraphics;
using System;

using UIKit;
using Sample.iOS.ViewControllers;

namespace Sample.iOS
{
	public class MainViewController : UIViewController
	{

		private UIButton _labelButton;
		private UIButton _textFieldButton;
		private UIButton _buttonButton;
		private UIButton _checkBoxButton;
        private UIButton _sliderButton;
		private UIButton _progressBarButton;
		private UIButton _alertButton;


		public MainViewController()
		{
			Title = "Menu";
			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;
		}
		public override void ViewDidLoad()
		{
			_labelButton = UIButton.FromType(UIButtonType.System);
			_labelButton.SetTitle("Label", UIControlState.Normal);
			_labelButton.TouchUpInside += _labelButton_TouchUpInside;
			_labelButton.Frame = new CGRect(10, 10, View.Bounds.Width - 20, 40);

			_textFieldButton = UIButton.FromType(UIButtonType.System);
			_textFieldButton.SetTitle("Champs de saisie", UIControlState.Normal);
			_textFieldButton.TouchUpInside += _textField_TouchUpInside;
			_textFieldButton.Frame = new CGRect(10, 60, View.Bounds.Width - 20, 40);


			_buttonButton = UIButton.FromType(UIButtonType.System);
			_buttonButton.SetTitle("Boutons", UIControlState.Normal);
			_buttonButton.TouchUpInside += _button_TouchUpInside;
			_buttonButton.Frame = new CGRect(10, 110, View.Bounds.Width - 20, 40);


			_checkBoxButton = UIButton.FromType(UIButtonType.System);
			_checkBoxButton.SetTitle("Case à cocher", UIControlState.Normal);
			_checkBoxButton.TouchUpInside += _checkBox_TouchUpInside;
			_checkBoxButton.Frame = new CGRect(10, 160, View.Bounds.Width - 20, 40);

			_sliderButton = UIButton.FromType(UIButtonType.System);
			_sliderButton.SetTitle("Réglette", UIControlState.Normal);
			_sliderButton.TouchUpInside += _slider_TouchUpInside;
			_sliderButton.Frame = new CGRect(10, 210, View.Bounds.Width - 20, 40);


			_progressBarButton = UIButton.FromType(UIButtonType.System);
			_progressBarButton.SetTitle("Barre de progression", UIControlState.Normal);
			_progressBarButton.TouchUpInside += _progressBarButton_TouchUpInside;
			_progressBarButton.Frame = new CGRect(10, 260, View.Bounds.Width - 20, 40);

			_alertButton = UIButton.FromType(UIButtonType.System);
			_alertButton.SetTitle("Afficher des alertes", UIControlState.Normal);
            _alertButton.TouchUpInside += _alertButton_TouchUpInside;
			_alertButton.Frame = new CGRect(10, 310, View.Bounds.Width - 20, 40);

			View.AddSubviews(_labelButton,
                             _textFieldButton,
                             _buttonButton,
                             _checkBoxButton,
                             _sliderButton,
                             _progressBarButton,
                             _alertButton);
		}

		void _labelButton_TouchUpInside(object sender, EventArgs e)
		{
            var controller = new LabelViewController();
            this.NavigationController.PushViewController(new LabelViewController(), true);
		}

		void _textField_TouchUpInside(object sender, EventArgs e)
		{
			this.NavigationController.PushViewController(new TextFieldViewController(), true);
		}

		void _button_TouchUpInside(object sender, EventArgs e)
		{
			this.NavigationController.PushViewController(new ButtonViewController(), true);
		}

		void _checkBox_TouchUpInside(object sender, EventArgs e)
		{
			this.NavigationController.PushViewController(new CheckBoxViewController(), true);
		}

		void _slider_TouchUpInside(object sender, EventArgs e)
		{
			this.NavigationController.PushViewController(new SliderViewController(), true);
		}

		void _progressBarButton_TouchUpInside(object sender, EventArgs e)
		{
            this.NavigationController.PushViewController(new ProgressBarViewController(), true);
		}

		void _alertButton_TouchUpInside(object sender, EventArgs e)
		{
            this.NavigationController.PushViewController(new AlertViewController(), true);
		}
	}
}