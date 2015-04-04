using System;
using System.Drawing;
using Xamarin.Themes;
using Xamarin.Themes.Core;
using Xamarin.Themes.TrackBeam;
using Foundation;
using UIKit;

namespace Mystro.iOS
{
	public partial class Mystro_iOSViewController : UIViewController
	{	

		public Mystro_iOSViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			EdgesForExtendedLayout = UIRectEdge.None;
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			ThemeManager.Current.Apply(View);
			ThemeManager.Current.Apply (logInBtn);
			ThemeManager.Current.Apply (stuRegisterBtn);
			ThemeManager.Current.Apply(profRegisterBtn);
			ThemeManager.Current.Apply(parentsRegisterBtn);


			base.ViewWillAppear (animated);
		}


	

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

