using System;
using System.Threading.Tasks;
using CoreGraphics;
using UIKit;

namespace Sample.iOS.ViewControllers
{
    public class ProgressBarViewController : UIViewController
    {
        UIProgressView _progressView;

        UIActivityIndicatorView _activityView;
        public ProgressBarViewController()
        {
			Title = "Afficher un chargement";

			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _progressView = new UIProgressView();
            _progressView.Style = UIProgressViewStyle.Bar;
			_progressView.Frame = new CGRect(10, 10, View.Bounds.Width - 20, 40);

            _activityView = new UIActivityIndicatorView();
            _activityView.ActivityIndicatorViewStyle = UIActivityIndicatorViewStyle.Gray;
			_activityView.Frame = new CGRect(10, 60, View.Bounds.Width - 20, 40);
            _activityView.HidesWhenStopped = true;

			View.AddSubviews(_progressView, _activityView);

            RunProgress();
            SimulateActivity();

		}

        async void RunProgress()
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(100);
                _progressView.SetProgress(i, true);
            }
        }

        async void SimulateActivity()
        {
            _activityView.StartAnimating();
            await Task.Delay(5000);
            _activityView.StopAnimating();
        }
    }
}
