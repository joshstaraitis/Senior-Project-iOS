using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit;
using SQLite;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace App3
{
    public partial class SearchViewController : UITableViewController, IUITableViewDelegate, IUITableViewDataSource, IUISearchResultsUpdating
    {
        
        string[] searchResults;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var search = new UISearchController(searchResultsController: null)
            {
                DimsBackgroundDuringPresentation = false
            };

            search.SearchResultsUpdater = this;
            DefinesPresentationContext = true;
            NavigationItem.SearchController = search;
        }

        public void UpdateSearchResultsForSearchController(UISearchController searchController)
        {
            var find = searchController.SearchBar.Text;
            if (!String.IsNullOrEmpty(find))
            {
                searchResults = location.Where(t => t.ToLower().Contains(find.ToLower())).Select(p => p).ToArray();
            }
            else
            {
                searchResults = null;
            }
            TableView.ReloadData();
        }
    }
}