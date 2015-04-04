// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Mystro.iOS
{
	[Register ("LogInViewController")]
	partial class LogInViewController
	{
		[Outlet]
		UIKit.UITextField emailLogInBox { get; set; }

		[Outlet]
		UIKit.UIButton logInButton { get; set; }

		[Outlet]
		UIKit.UITextField passLogInBox { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (emailLogInBox != null) {
				emailLogInBox.Dispose ();
				emailLogInBox = null;
			}

			if (passLogInBox != null) {
				passLogInBox.Dispose ();
				passLogInBox = null;
			}

			if (logInButton != null) {
				logInButton.Dispose ();
				logInButton = null;
			}
		}
	}
}
