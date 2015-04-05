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
	[Register ("Dashboardview")]
	partial class Dashboardview
	{
		[Outlet]
		UIKit.UIButton classStngBtn { get; set; }

		[Outlet]
		UIKit.UIButton commBtn { get; set; }

		[Outlet]
		UIKit.UILabel dashLabel { get; set; }

		[Outlet]
		UIKit.UIButton profTipsBtn { get; set; }

		[Outlet]
		UIKit.UIButton scheduleBtn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (classStngBtn != null) {
				classStngBtn.Dispose ();
				classStngBtn = null;
			}

			if (commBtn != null) {
				commBtn.Dispose ();
				commBtn = null;
			}

			if (profTipsBtn != null) {
				profTipsBtn.Dispose ();
				profTipsBtn = null;
			}

			if (scheduleBtn != null) {
				scheduleBtn.Dispose ();
				scheduleBtn = null;
			}

			if (dashLabel != null) {
				dashLabel.Dispose ();
				dashLabel = null;
			}
		}
	}
}
