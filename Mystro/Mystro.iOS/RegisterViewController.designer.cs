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
	[Register ("RegisterViewController")]
	partial class RegisterViewController
	{
		[Outlet]
		UIKit.UITextField confirmpassRegBox { get; set; }

		[Outlet]
		UIKit.UITextField emailRegBox { get; set; }

		[Outlet]
		UIKit.UITextField nameRegBox { get; set; }

		[Outlet]
		UIKit.UITextField passRegBox { get; set; }

		[Outlet]
		UIKit.UIButton regButton { get; set; }

		[Outlet]
		UIKit.UITextField schoolRegBox { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (confirmpassRegBox != null) {
				confirmpassRegBox.Dispose ();
				confirmpassRegBox = null;
			}

			if (emailRegBox != null) {
				emailRegBox.Dispose ();
				emailRegBox = null;
			}

			if (nameRegBox != null) {
				nameRegBox.Dispose ();
				nameRegBox = null;
			}

			if (passRegBox != null) {
				passRegBox.Dispose ();
				passRegBox = null;
			}

			if (schoolRegBox != null) {
				schoolRegBox.Dispose ();
				schoolRegBox = null;
			}

			if (regButton != null) {
				regButton.Dispose ();
				regButton = null;
			}
		}
	}
}
