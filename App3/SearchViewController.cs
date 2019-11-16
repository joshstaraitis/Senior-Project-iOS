using Foundation;
using System;
using UIKit;
using System.Linq;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Collections;

namespace App3
{
    public partial class SearchViewController : UITableViewController, IUITableViewDelegate, IUITableViewDataSource, IUISearchResultsUpdating
    {
        public SearchViewController(IntPtr handle) : base(handle)
        {
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return searchResults == null ? location.Length : searchResults.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("locationcell");
            cell.TextLabel.Text = searchResults == null ? location[indexPath.Row] : searchResults[indexPath.Row];
            cell.DetailTextLabel.Text = "";
            return cell;
        }


        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            TableView.DeselectRow(indexPath, true);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            //dsc2 = DetailedSearchController2: rename when I get it to work properly? for clarity?
            var dsc2 = segue.DestinationViewController as DetailedSearchController2;
            var indexPath = TableView.IndexPathForCell(sender as UITableViewCell);
            var item = searchResults == null ? location[indexPath.Row] : searchResults[indexPath.Row];
            var item2 = searchResults == null ? address[indexPath.Row] : searchResults[indexPath.Row];
            var item3 = searchResults == null ? cuisine[indexPath.Row] : searchResults[indexPath.Row];
            var item4 = searchResults == null ? dress[indexPath.Row] : searchResults[indexPath.Row];
            var item5 = searchResults == null ? favDrink[indexPath.Row] : searchResults[indexPath.Row];
            var item6 = searchResults == null ? favFood[indexPath.Row] : searchResults[indexPath.Row];
            var item7 = searchResults == null ? hours[indexPath.Row] : searchResults[indexPath.Row];
            var item8 = searchResults == null ? review[indexPath.Row] : searchResults[indexPath.Row];
            var item9 = searchResults == null ? phone[indexPath.Row] : searchResults[indexPath.Row];
            var item10 = searchResults == null ? menu[indexPath.Row] : searchResults[indexPath.Row];
            var item11 = searchResults == null ? reservation[indexPath.Row] : searchResults[indexPath.Row];
            var item12 = searchResults == null ? review2[indexPath.Row] : searchResults[indexPath.Row];
            var item13 = searchResults == null ? lasttime[indexPath.Row] : searchResults[indexPath.Row];
            var item14 = searchResults == null ? specials[indexPath.Row] : searchResults[indexPath.Row];
            dsc2.SetTitle(item, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14);
        }

        string[] location = new string[]
            {
             "Cilantro Sushi",
             "Bricco" ,
             "R Shea Brewing",
             "The Merchant Tavern" ,
             "Cashmere Cricket",
             "Darby's on Fifty-Nine",
             "Burntwood Tavern",
             "Luigi's",
             "Crave",
             "Lock 15 Brewing Co",
             "Longhorn Steakhouse",
             "Olive Garden" ,
             "Tip Top Catering",
             "Altieri's Pizza" ,
             "Thai Gourmet",
             "Luca's New York Pizza",
             "Parasson's Italian Restaurant",
             "Lemongrsss Grill",
             "Red Lobster",
             "Pancho and Lefty's",
            };

        string[] phone = new string[]
            {
             "330-434-2879",
             "330-434-2879" ,
             "330-434-2879",
             "330-434-2879" ,
             "330-434-2879",
             "330-434-2879",
             "330-434-2879",
             "330-434-2879",
             "330-434-2879",
             "330-434-2879",
             "330-434-2879",
             "330-434-2879",
             "330-434-2879" ,
             "330-434-2879",
             "330-434-2879" ,
             "330-434-2879",
             "330-434-2879",
             "330-434-2879",
             "330-434-2879",
             "330-434-2879",
            };

        string[] address = new string[]
            {
             "326 King James, Akron, OH 44308",
             "1 W Exchange Street, Akron, OH 44308" ,
             "1662 Merriman Rd, Akron, OH 44313",
             "1842 Merriman Rd, Akron, OH 44313" ,
             "2235 Front Street, Cuyahoga Falls, OH 44221",
             "2764 Front Street, Silver Lake, OH 44224",
             "2291 Riverfront Pkwy, Cuyahoga Falls, OH 44221",
             "105 N Main Street, Akron, OH 44308",
             "57 E Market Street, Akron, OH 44308",
             "21 W North Street, Akron, OH 44304",
             "443 Howe Ave, Cuyahoga Falls, OH 44221",
             "480 Howe Ave, Cuyahoga Falls, OH 44221" ,
             "3428 Darrow Rd, Stow, OH 44224",
             "3291 Kent Rd, Stow, OH 44224" ,
             "3732 Darrow Rd, Stow, OH 44224",
             "3451 Darrow Rd, Stow, OH 44224",
             "3983 Darrow Rd, Stow, OH 44224",
             "20 N Main St, Munroe Falls, OH 44262",
             "480 Howe Ave, Cuyahoga Falls, OH 44221",
             "3254 Kent Rd, Stow, OH 44224",
            };

        string[] cuisine = new string[]
            {
             "Asian",
             "American" ,
             "Brewery",
             "American" ,
             "Bar",
             "Gastropup",
             "American",
             "Italian",
             "American",
             "Brewery",
             "Steak House",
             "Italian" ,
             "American",
             "Italian" ,
             "Thai",
             "Italian",
             "Italian",
             "Thai",
             "American",
             "Mexican",
            };

        string[] dress = new string[]
            {
             "casual",
             "casual" ,
             "casual",
             "casual" ,
             "casual",
             "professional",
             "casual",
             "casual",
             "professional",
             "casual",
             "casual",
             "casual" ,
             "casual",
             "casual" ,
             "casual",
             "casual",
             "casual",
             "casual",
             "casual",
             "casual",
            };

        string[] favDrink = new string[]
            {
             "Mango Bellini",
             "Espresso Martini" ,
             "Blonde Stout",
             "Peach Martini" ,
             "Black Cat",
             "Dirty Martini",
             "Blueberry Mule",
             "None",
             "Espresso Martini",
             "Blonde Stout",
             "Blonde Stout",
             "Moscato" ,
             "None",
             "Blonde Stout" ,
             "Geisha Martini",
             "Blonde Stout",
             "Merlot",
             "Lychee Martini",
             "Merlot",
             "Peach Martini",
            };

        string[] favFood = new string[]
            {
             "California Roll",
             "Chicken Nachos",
             "Pesto Chicken Wrap",
             "Bacon Cheeseburger",
             "Charcuterie Board",
             "Buffalo Cauliflower",
             "Apple Walnut Salad",
             "Cheese Pizza",
             "Pistachio Salmon",
             "Beer Pretzel",
             "Beer Pretzel",
             "Chicken Parm" ,
             "None",
             "Deluxe Pizza" ,
             "Red Curry",
             "Deluxe Pizza",
             "Chicken Parm",
             "Red Curry",
             "Shrimp Scampi",
             "Chicken Tacos",
            };

        string[] hours = new string[]
            {
             "Monday - Sunday: 11AM - 9:30PM",
             "Monday - Sunday: 11AM - 11:30PM" ,
             "Wednesday - Sunday: 11AM - 9:30PM",
             "Monday - Sunday: 11AM - 12AM" ,
             "Tuesday - Sunday: 4PM - 2:30AM",
             "Monday - Sunday: 11AM - 9:30PM",
             "Monday - Sunday: 11AM - 9:30PM",
             "Monday - Sunday: 11AM - 9:30PM",
             "Monday - Sunday: 11AM - 9:30PM",
             "Tuesday - Sunday: 11AM - 9:30PM",
             "Monday - Sunday: 11AM - 9:30PM",
             "Monday - Sunday: 11AM - 9:30PM" ,
             "Monday - Sunday: 11AM - 9:30PM",
             "Monday - Sunday: 11AM - 9:30PM" ,
             "Monday - Sunday: 11AM - 9:30PM",
             "Monday - Sunday: 11AM - 9:30PM",
             "Monday - Sunday: 11AM - 9:30PM",
             "Monday - Sunday: 11AM - 9:30PM",
             "Monday - Sunday: 11AM - 9:30PM",
             "Monday - Sunday: 11AM - 9:30PM",
            };

        string[] review = new string[]
            {
             "A Thai-Japanese hybrid offering beer, wine & specialty cocktails in a contemporary room, with 4.5 star rating.",
             "Stylish, contemporary pizzeria with creative pies & a selection of over 240 beers & wines, with 4.3 star rating." ,
             "Brewery, with 4.8 star rating.",
             "Laid-back hangout serving upmarket American standards & craft beer in a vintage-inspired space, with 4.5 star rating." ,
             "Craft cocktails & upscale bar bites presented in a comfy, stylish lounge with front & back patios, with 4.5 star rating.",
             "Hip nook for seasonal American pub grub, such as sliders & flatbreads, plus craft beer & cocktails, with 4.6 star rating.",
             "Classy local tavern chain with a menu of New American fare & pub grub, plus craft beers & cocktails, with 4.2 star rating.",
             "Down-home institution offering hearty pies & other classic Italian eats in a comfortable atmosphere, with 4.6 star rating.",
             "A diverse menu with global influences is presented in a colorful, contemporary, art-filled setting, with 4.4 star rating.",
             "Brewery, with 4.4 star rating.",
             "Casual steakhouse chain known for grilled beef & other American dishes in a ranch-style space.",
             "Lively, family-friendly chain featuring Italian standards such as pastas & salads, with a full bar." ,
             "Veteran eatery with a throwback feel, offering American comfort food for breakfast, lunch & dinner.",
             "Iconic pizzeria, known for quirky housemade pies & Buffalo wings, that dishes up a mix of crusts." ,
             "Hopping Thai place serving vegetarian dishes & familiar Chinese chow in a casual strip-mall setup.",
             "Down-home institution offering hearty pies & other classic Italian eats in a comfortable atmosphere, with 4.6 star rating.",
             "Local Italian chain serving pizza, pasta & subs, plus beer & wine, in a casual, old-school space.",
             "A Thai-Japanese hybrid offering beer, wine & specialty cocktails in a contemporary room, with 4.5 star rating.",
             "Lively chain restaurant serving American seafood standards amid New England-themed decor.",
             "The best Mexican restaurant run by white folks I ever ate at!",
            };

        string[] review2 = new string[]
            {
             "Good food , gluten-free options, nice staff, busy busy place!",
             "Stylish, contemporary pizzeria with creative pies & a selection of over 240 beers & wines, with 4.3 star rating." ,
             "R.Shea had fairly priced drinks, a full menu, and an awesome atmosphere.",
             "Excellent options for happy hour and dinner, great selection of beer & wine.",
             "It's a great space, with a bar & tables as well as some comfy couch seating.",
             "Great place, great food in incredibly large servings, and an awesome staff!",
             "Good food, friendly service, great beer, wine, mixed drinks selection.",
             "Server was rude, food was undercooked, and all this after over an hour wait.",
             "The staff and owners are super friendly and service is fantastic.",
             "The staff and owners are super friendly and service is fantastic.",
             "Portions seemed a bit small, service was a little slow but the food tasted great",
             "This location features a brand new parking lot and a completed redone interior." ,
             "Great food for a reasonable price, nice family atmosphere, super friendly staff.",
             "Pepperoni and mushrooms were underneath the cheese .The sauce has good flavor." ,
             "Wonderful atmosphere, pleasant staff, their tofu is like the best thing ever.",
             "Great food, great service, and a great price for the amount of food you get.",
             "Cheap prices and good food make our family regular customers for get togethers.",
             "Absolutely excellent food, service, portions and prices.",
             "Went in with 9 people and recieved amazing food and service!",
             "Great food, great price, tasty margaritas and wonderful and friendly staff.",
            };

        string[] menu = new string[]
            {
             "https://www.cilantrothai.com/",
             "https://www.briccokent.com/" ,
             "https://rsheabrewing.com/",
             "https://www.themerchanttavern.com/" ,
             "https://www.cashmerecricket.com/",
             "http://darbyson59.com/",
             "https://www.burntwoodtavern.com/",
             "https://luigisrestaurant.com/",
             "https://www.eatdrinkcrave.com/",
             "https://www.lock15brewing.com/",
             "longhornsteakhouse.com",
             "olivegarden.com" ,
             "tiptopstow.com",
             "none" ,
             "none",
             "lucasnypizza.com",
             "none",
             "none",
             "redlobster.com",
             "none",
            };

        string[] reservation = new string[]
        {
             "Yes, opentable.com",
             "Yes, opentable.com" ,
             "No",
             "Yes, opentable.com" ,
             "No",
             "Yes, opentable.com",
             "Yes, opentable.com",
             "No",
             "Yes, opentable.com",
             "No",
             "Yes, opentable.com",
             "Yes, opentable.com" ,
             "Yes, opentable.com",
             "Yes, opentable.com" ,
             "Yes, opentable.com",
             "Yes, opentable.com",
             "Yes, opentable.com",
             "Yes, opentable.com",
             "Yes, opentable.com",
             "Yes, opentable.com",
        };

        string[] lasttime = new string[] // last time here
        {
             "Saturday, April 6, 2019",
             "Saturday, April 6, 2019" ,
             "Saturday, April 6, 2019",
             "Saturday, April 6, 2019" ,
             "Saturday, April 6, 2019",
             "Saturday, April 6, 2019",
             "Saturday, April 6, 2019",
             "Saturday, April 6, 2019",
             "Saturday, April 6, 2019",
             "Saturday, April 6, 2019",
             "Saturday, April 6, 2019",
             "Saturday, April 6, 2019" ,
             "Saturday, April 6, 2019",
             "Saturday, April 6, 2019" ,
             "Saturday, April 6, 2019",
             "Saturday, April 6, 2019",
             "Saturday, April 6, 2019",
             "Saturday, April 6, 2019",
             "Saturday, April 6, 2019",
             "Saturday, April 6, 2019",
        };

        string[] specials = new string[] // specials
        {
             "Happy Hour: 4pm - 6pm, Monday through Thursday",
             "Happy Hour: 4pm - 6pm, Monday through Thursday",
             "Happy Hour: 4pm - 6pm, Monday through Thursday",
             "Happy Hour: 4pm - 6pm, Monday through Thursday",
             "Happy Hour: 4pm - 6pm, Monday through Thursday",
             "Happy Hour: 4pm - 6pm, Monday through Thursday",
             "Happy Hour: 4pm - 6pm, Monday through Thursday",
             "None",
             "Happy Hour: 4pm - 6pm, Monday through Thursday",
             "Happy Hour: 4pm - 6pm, Monday through Thursday",
             "Happy Hour: 4pm - 6pm, Monday through Thursday",
             "Happy Hour: 4pm - 6pm, Monday through Thursday",
             "None",
             "None",
             "Happy Hour: 4pm - 6pm, Monday through Thursday",
             "None",
             "None",
             "Happy Hour: 4pm - 6pm, Monday through Thursday",
             "Happy Hour: 4pm - 6pm, Monday through Thursday",
             "Happy Hour: 4pm - 6pm, Monday through Thursday",
        };
    }
}




