
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
using Android.Gms.Maps;

namespace maptest
{
	[Activity (Label = "MapViewActivity")]			
	public class MapViewActivity : Activity, IOnMapReadyCallback
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.a_bMapView);
			// Create your application here
			InitViews ();
		}

		void InitViews()
		{
			MapFragment mapFrag = (MapFragment) FragmentManager.FindFragmentById(Resource.Id.fEventMap);
			mapFrag.GetMapAsync (this);

		}

		public void OnMapReady (GoogleMap googleMap)
		{
			if (googleMap != null) {
				// The GoogleMap object is ready to go.
			}			
		}
	}
}

