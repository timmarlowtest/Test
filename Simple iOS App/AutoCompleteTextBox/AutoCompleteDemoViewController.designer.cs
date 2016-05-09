// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using UIKit;

namespace AutoCompleteDemo
{
	[Register ("AutoCompleteDemoViewController")]
	partial class AutoCompleteDemoViewController
	{
		[Outlet]
		UITextField textInput { get; set; }

		[Outlet]
		UILabel labelSelection { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (textInput != null) {
				textInput.Dispose ();
				textInput = null;
			}

			if (labelSelection != null) {
				labelSelection.Dispose ();
				labelSelection = null;
			}
		}
	}
}
