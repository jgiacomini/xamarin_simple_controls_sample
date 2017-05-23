using System;
using CoreGraphics;
using UIKit;

namespace Sample.iOS.ViewControllers
{
	public class CheckBoxViewController : UIViewController
	{

        UISwitch _switch;

		public CheckBoxViewController()
		{
			Title = "Switch sample";
			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;


            _switch = new UISwitch();
			_switch.Frame = new CGRect(10, 10, View.Bounds.Width - 20, 40);
			_switch.On = true;

			_switch.ValueChanged += _switch_ValueChanged;

			// Style
			_switch.OnTintColor = UIColor.Yellow;
            _switch.TintColor = UIColor.Purple;
            _switch.ThumbTintColor = UIColor.Red;

            //_switch.OnImage
            //_switch.OffImage
            View.AddSubviews(_switch);
        }

        async void _switch_ValueChanged(object sender, EventArgs arg)
        {
            Console.WriteLine($"La valeur de la case à cocher a changé {_switch.On}");

            await System.Threading.Tasks.Task.Delay(1000);
            _switch.SetState(!_switch.On,true);
        }
	}
}
