using System;
using Xamarin.Forms;

namespace DynamicControls
{
	public partial class DynamicControlsPage : ContentPage
	{
		public DynamicControlsPage()
		{
			InitializeComponent();

			StackLayout sl = new StackLayout();

			for (int ii = 0; ii <= 3; ii++) {

				Entry entry = new Entry { Placeholder = "Entry n° " + ii};
				entry.Completed += async (object sender, System.EventArgs e) => {

					try
					{
						string text = ((Entry)sender).Text;
						await DisplayAlert("Entry", "Completed " + text, "Ok");
					}
					catch (Exception ex) {
						await DisplayAlert("Entry", ex.Message, "Ok");
					}
				};
				sl.Children.Add(entry);

				Button b = new Button() { Text = "Button n° " + ii };
				b.Clicked += async (object sender, System.EventArgs e) => { 

					try {
						string text = ((Button)sender).Text;
						await DisplayAlert("Entry", "Completed " + text, "Ok");
					}
					catch (Exception ex) {
						await DisplayAlert("Entry", ex.Message, "Ok");
					}
				};
				sl.Children.Add(b);
			}

			this.Content = sl;
		}
	}
}
