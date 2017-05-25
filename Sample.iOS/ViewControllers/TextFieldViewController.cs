using System;
using System.Text.RegularExpressions;
using CoreGraphics;
using UIKit;

namespace Sample.iOS.ViewControllers
{
    public class TextFieldViewController : UIViewController
    {

        UITextField _textField;
		UITextField _passwordField;
        UIStepper _stepper;
        UILabel _labelStepper;

        public TextFieldViewController()
        {
			Title = "TSaisir un texte, un nombre";

			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;

            _textField = new UITextField();
			_textField.Frame = new CGRect(10, 10, View.Bounds.Width - 20, 40);
            _textField.BorderStyle = UITextBorderStyle.Line;
            //_textField.Placeholder = "Saisir un email";

			//_textField.Layer.BorderWidth = 1;
			//_textField.Layer.BorderColor = UIColor.Black.CGColor;

            _textField.ClearButtonMode = UITextFieldViewMode.WhileEditing;
			_textField.SpellCheckingType = UITextSpellCheckingType.Yes;
			_textField.AutocorrectionType = UITextAutocorrectionType.Yes;
            _textField.KeyboardType = UIKeyboardType.NumberPad;
            _textField.ValueChanged += _textField_ValueChanged;

            _textField.AutocapitalizationType = UITextAutocapitalizationType.Sentences;

            _textField.EditingDidEnd += _textField_EditingDidEnd;

            _textField.ReturnKeyType = UIReturnKeyType.Continue;
            _textField.ShouldReturn = TextFieldShouldReturn;
            _textField.Tag = 0;

			_passwordField = new UITextField();
			_passwordField.Frame = new CGRect(10, 60, View.Bounds.Width - 20, 40);
            _passwordField.BorderStyle = UITextBorderStyle.RoundedRect;

			_passwordField.ShouldReturn = TextFieldShouldReturn;
            _passwordField.Tag = 1;
            _passwordField.SecureTextEntry = true;

            var width = 80;
            _stepper = new UIStepper();
            _stepper.Frame = new CGRect(View.Bounds.Width - 20 - width, 110, width, 40);
            _stepper.Value = 42;
            _stepper.ValueChanged += _stepper_ValueChanged;;
            _stepper.StepValue = 1f;
            _stepper.MinimumValue = 40;
            _stepper.MaximumValue = 50;
            _stepper.Wraps = true;
            _stepper.AutoRepeat = true;

            _labelStepper = new UILabel();
			_labelStepper.Frame = new CGRect(10, 110, View.Bounds.Width - 20, 40);
			_labelStepper.Text = _stepper.Value.ToString();


            View.AddSubviews(_textField, _passwordField,_stepper, _labelStepper);
        }

        void _textField_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"Le texte du champs de saisie réglette a changé {_textField.Text}");
        }

        void _textField_EditingDidEnd(object sender, EventArgs e)
        {
            if (Regex.Match(_textField.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
            {
				Console.WriteLine("champs valide");
            }
            else
            {
                Console.WriteLine("champs invalide");
            }
        }

        void _stepper_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(_stepper.Value);
            _labelStepper.Text = _stepper.Value.ToString();
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
