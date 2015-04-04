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
	[Register ("Mystro_iOSViewController")]
	partial class Mystro_iOSViewController
	{
		[Outlet]
		UIKit.UIButton logInBtn { get; set; }

		[Outlet]
		UIKit.UIButton parentsRegisterBtn { get; set; }

		[Outlet]
		UIKit.UIButton profRegisterBtn { get; set; }

		[Outlet]
		UIKit.UIButton stuRegisterBtn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (logInBtn != null) {
				logInBtn.Dispose ();
				logInBtn = null;
			}

			if (parentsRegisterBtn != null) {
				parentsRegisterBtn.Dispose ();
				parentsRegisterBtn = null;
			}

			if (profRegisterBtn != null) {
				profRegisterBtn.Dispose ();
				profRegisterBtn = null;
			}

			if (stuRegisterBtn != null) {
				stuRegisterBtn.Dispose ();
				stuRegisterBtn = null;
			}
		}
	}
}
