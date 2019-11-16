using Foundation;
using System;
using UIKit;

namespace App3
{
    public partial class NavigationController : UINavigationController
    {
        public NavigationController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad() 
        {
            base.ViewDidLoad();
            NavigationBar.PrefersLargeTitles = true;
        }
    }
}