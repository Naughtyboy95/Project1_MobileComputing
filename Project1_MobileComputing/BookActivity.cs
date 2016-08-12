
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Project1_MobileComputing
{
	[Activity(Label = "BookActivity")]
	public class BookActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Content);
			Button button = FindViewById<Button>(Resource.Id.book1);
			Button Secondbutton = FindViewById<Button>(Resource.Id.book2);
			Button Thirdbutton = FindViewById<Button>(Resource.Id.book3);
			Button Fourthbutton = FindViewById<Button>(Resource.Id.book4);
			Button Fifthbutton = FindViewById<Button>(Resource.Id.book5);

			button.Click += delegate
			{
				StartActivity(typeof(DetailActivity_1));
			};

			Secondbutton.Click += delegate
			{
				StartActivity(typeof(DetailActivity_2));
			};

			Thirdbutton.Click += delegate
			{
				StartActivity(typeof(DetailActivity_3));
			};

			Fourthbutton.Click += delegate
			{
				StartActivity(typeof(DetailActivity_4));
			};

			Fifthbutton.Click += delegate
			{
				StartActivity(typeof(DetailActivity_5));
			};
		}
	}
}