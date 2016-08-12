
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using Android.Locations;
using Android.Util;
namespace Project1_MobileComputing
{
	[Activity(Label = "MapActivity")]
	public class MapActivity : Activity, ILocationListener
	{
		TextView addressText;
		TextView locationText;
		TextView distanceText;
		Location currentLocation;
		LocationManager locationManager;
		string locationProvider;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Search);
			addressText = FindViewById<TextView>(Resource.Id.addressText);
			locationText = FindViewById<TextView>(Resource.Id.gpsLocationText);
			distanceText = FindViewById<TextView>(Resource.Id.distanceText);
			locationManager = (LocationManager)GetSystemService(LocationService);

			Criteria locationServiceCriteria = new Criteria
			{
				Accuracy = Accuracy.Coarse,
				PowerRequirement = Power.Medium
			};

			IList<string> acceptablelocationProviders = locationManager.GetProviders(locationServiceCriteria, true);

			if (acceptablelocationProviders.Any())
				locationProvider = acceptablelocationProviders.First();
			else
				locationProvider = string.Empty;
		}

		protected override void OnResume()
		{
			base.OnResume();
			locationManager.RequestLocationUpdates(locationProvider, 0, 0, this);
		}

		protected override void OnPause()
		{
			base.OnPause();
			locationManager.RemoveUpdates(this);
		}

		public void OnLocationChanged(Location location)
		{
			try
			{
				currentLocation = location;
				if (currentLocation == null)
					locationText.Text = "Location not found";
				else
				{
					locationText.Text = string.Format("{0},{1}", currentLocation.Latitude, currentLocation.Longitude);

					Android.Locations.Geocoder geocoder = new Geocoder(this);
					IList<Address> addressList = geocoder.GetFromLocation(currentLocation.Latitude, currentLocation.Longitude, 5);

					Address address = addressList.FirstOrDefault();

					double lat1 = currentLocation.Latitude;
					double theta = currentLocation.Longitude - (-0.13);
					double distance = Math.Sin(Math.PI / 180.0 * (lat1))
										  * Math.Sin(Math.PI / 180.0 * (51.50)) +
										  Math.Cos(Math.PI / 180.0 * (lat1)) *
										  Math.Cos(Math.PI / 180.0 * (51.50)) *
										  Math.Cos(Math.PI / 180.0 * (theta));
					distance = Math.Acos(distance);
					distance = distance / Math.PI * 180.0;
					distance = distance * 60 * 1.15;

					distanceText.Text = "Distance: " + distance.ToString() + " miles";

					if (address != null)
					{
						StringBuilder deviceAddress = new StringBuilder();
						for (int i = 0; i < address.MaxAddressLineIndex; i++)
						{
							deviceAddress.Append(address.GetAddressLine(i)).AppendLine(",");
						}
						addressText.Text = deviceAddress.ToString();
					}
					else addressText.Text = "address not found";

				}
			}
			catch
			{
				addressText.Text = "address not found";
			}
		}

		public void OnStatusChanged(string provider, Availability status, Bundle extras)
		{

		}

		public void OnProviderDisabled(string provider)
		{
		}

		public void OnProviderEnabled(string provider)
		{
		}




	}
}