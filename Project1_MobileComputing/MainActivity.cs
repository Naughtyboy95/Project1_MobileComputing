
using System;
using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Views;

using Android.Content;
using Android.Runtime;
using Android.Locations;
using Android.Util;


namespace Project1_MobileComputing
{
	[Activity(Label = "Project1_MobileComputing", MainLauncher = true, Icon = "@mipmap/image3")]
	public class MainActivity : Activity
	{
		private List<string> mItems;
		private ListView mListView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.OpenMenuPage);
			mListView = FindViewById<ListView>(Resource.Id.myListView);

			mItems = new List<string>();
			mItems.Add("Luckiest Girl Alive");
			mItems.Add("Paper Towns");
			mItems.Add("The Dust That Falls from Dreams");
			mItems.Add("Live Well on Less");
			mItems.Add("Eat Real Food");

			ArrayAdapter<string> ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
			mListView.Adapter = ListAdapter;
			mListView.ItemClick += mListView_ItemClick;

			button.Click += delegate
			{
				StartActivity(typeof(MenuActivity));
			};

		}

		void mListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			StartActivity(typeof(BookActivity));
		}



	}
}






