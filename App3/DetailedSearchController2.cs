using Foundation;
using System;
using UIKit;
using System.Linq;

namespace App3
{
    public partial class DetailedSearchController2 : UIViewController
    {
        public override void ViewDidLoad()
        {
            NavigationItem.LargeTitleDisplayMode = UINavigationItemLargeTitleDisplayMode.Never;

        }

        public void SetTitle(string title, string address, string cuisine, string dress, 
            string favDrink, string favFood, string hours, string review,
            string phone, string menu, string reservation, string review2,
            string lasttime, string specials) 
        {
            Title = title;
            //label.Text = $"{title} is located at \n {address} \n";

            label2.Text = $"{title} is an {cuisine} style of restaurant, located at {address} " +
                $"with a {dress} atmosphere.\n\n" +
                $"Hours of operation:\n{hours}\n\n" +
                $"Phone Number:\n{phone}\n\n" +
                $"Menu:\n{menu}\n\n" +
                $"Specials:\n{specials}\n\n" +
                $"Reservations:\n{reservation}\n\n" +
                $"Your favorite menu items are: \n" +
                $"Drink: {favDrink}\n" +
                $"Food: {favFood}\n\n" +
                $"Last Visited:\n{lasttime}";


            reviewLabel.Text = $"Customers are saying:\n{review}\n\n{review2}";
        }



        public DetailedSearchController2(IntPtr handle) : base(handle)
        {
            label2 = new UILabel();
            label2.Frame = new CoreGraphics.CGRect(50, 100, View.Bounds.Width - 20, View.Bounds.Height / 2);
        }

    }
  
}