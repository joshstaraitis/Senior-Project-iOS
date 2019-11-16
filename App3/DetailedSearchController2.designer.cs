// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace App3
{
    [Register ("DetailedSearchController2")]
    partial class DetailedSearchController2
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel label2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel reviewLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (label2 != null) {
                label2.Dispose ();
                label2 = null;
            }

            if (reviewLabel != null) {
                reviewLabel.Dispose ();
                reviewLabel = null;
            }
        }
    }
}