using System;
using CoreGraphics;
using UIKit;

namespace Sample.iOS.ViewControllers
{
    public class TextFieldViewController : UIViewController
    {

        UITextField _textField;


		UITextField _passwordField;

        public TextFieldViewController()
        {
			Title = "TextField sample";

			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;

            _textField = new UITextField();
			_textField.Frame = new CGRect(10, 10, View.Bounds.Width - 20, 40);


			_textField.Placeholder = "Saisir un email";
			_textField.Layer.BorderWidth = 1;
			_textField.Layer.BorderColor = UIColor.Black.CGColor;

            _textField.ClearButtonMode = UITextFieldViewMode.WhileEditing;
                
			_textField.SpellCheckingType = UITextSpellCheckingType.Yes;
			_textField.AutocorrectionType = UITextAutocorrectionType.Yes;
			_textField.KeyboardType = UIKeyboardType.EmailAddress;
			_textField.AutocapitalizationType = UITextAutocapitalizationType.AllCharacters;
			_textField.ReturnKeyType = UIReturnKeyType.Continue;
            _textField.ShouldReturn = TextFieldShouldReturn;
            _textField.Tag = 0;

			_passwordField = new UITextField();
			_passwordField.Layer.BorderWidth = 1;
			_passwordField.Layer.BorderColor = UIColor.Black.CGColor;
            _passwordField.ShouldReturn = TextFieldShouldReturn;
            _passwordField.Tag = 1;

			_passwordField.Frame = new CGRect(10, 60, View.Bounds.Width - 20, 40);
            _passwordField.SecureTextEntry = true;

            View.AddSubviews(_textField, _passwordField);
        }

		private bool TextFieldShouldReturn(UITextField textfield)
		{
            nint nextTag = textfield.Tag + (nint)1;
			UIResponder nextResponder = this.View.ViewWithTag(nextTag);
			if (nextResponder != null)
			{
				nextResponder.BecomeFirstResponder();
			}
			else
			{
                // Aucun autre text field trouvé on désactive le clavier
                textfield.ResignFirstResponder();
			}
			return false;
		}
    }
}
