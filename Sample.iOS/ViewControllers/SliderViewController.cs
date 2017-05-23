using System;
using CoreGraphics;
using UIKit;

namespace Sample.iOS.ViewControllers
{
    public class SliderViewController : UIViewController
    {
        private UISlider _slider;

        public SliderViewController()
        {
			Title = "Slider sample";

			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;

			_slider = new UISlider();
			_slider.Frame = new CGRect(10, 10, View.Bounds.Width - 20, 40);
            _slider.Value = 7.0f;

            _slider.MinValue = 1.0f;
            _slider.MaxValue = 12f;


			_slider.ValueChanged += _slider_ValueChanged;
			_slider.Continuous = true;


			//Style
			_slider.MinimumTrackTintColor = UIColor.Purple;
            _slider.MaximumTrackTintColor = UIColor.Yellow;
			_slider.ThumbTintColor = UIColor.Red;

			this.View.AddSubviews(_slider);
        }


		void _slider_ValueChanged(object sender, EventArgs e)
		{
            Console.WriteLine($"La valeur de réglette a changé à {_slider.Value}");
		}
    }
}
