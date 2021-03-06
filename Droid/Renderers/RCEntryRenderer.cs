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
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using RoomiesCalc;
using RoomiesCalc.Droid.Renderer;

[assembly: ExportRenderer(typeof(Entry), typeof(RCEntryRenderer))]
namespace RoomiesCalc.Droid.Renderer
{
	public class RCEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if(Control!=null)
			{

				Control.SetBackgroundResource(Resource.Drawable.RCEntry);
				Control.SetBackgroundColor (global::Android.Graphics.Color.Transparent);
				Control.TextSize = 22;
				Control.SetHintTextColor (global::Android.Graphics.Color.White);

			}
		}
	}
}