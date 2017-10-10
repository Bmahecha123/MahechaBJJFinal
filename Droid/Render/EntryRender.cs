using System;
using MahechaBJJ.Droid.Render;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(Entry), typeof(EntryRender))]
namespace MahechaBJJ.Droid.Render
{
	using Android.Views.InputMethods;
	using Xamarin.Forms.Platform.Android;

	public class EntryRender : EntryRenderer
	{

		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
            {
				Control.ImeOptions = (ImeAction)ImeFlags.NoExtractUi;
			}
		}
	}
}
