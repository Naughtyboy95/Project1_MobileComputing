
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
using Android.Media;

namespace Project1_MobileComputing
{
	[Activity(Label = "MenuActivity")]
	public class MenuActivity : Activity
	{
		MediaPlayer _player;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Menu);
			Button button = FindViewById<Button>(Resource.Id.BookPage);
			Button secondbutton = FindViewById<Button>(Resource.Id.LocationPage);
			Button thirdbutton = FindViewById<Button>(Resource.Id.MusicControl);
			Button fourthbutton = FindViewById<Button>(Resource.Id.MusicPause);
			_player = MediaPlayer.Create(this, Resource.Raw.Childhood_Memories);
			button.Click += delegate
			{
				StartActivity(typeof(MainActivity));
			};

			secondbutton.Click += delegate
			{
				StartActivity(typeof(MapActivity));
			};

			thirdbutton.Click += delegate
			{
				_player.Start();
			};

			fourthbutton.Click += delegate
			{
				_player.Pause();
			};
		}
	}
}

