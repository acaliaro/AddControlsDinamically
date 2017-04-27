using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace DynamicControls.ViewModels
{
	public class MyPageViewModel
	{

		public MyPageViewModel() {

			this.Clicked1Command = new Command(async () => {
				await Application.Current.MainPage.Navigation.PushAsync(new DynamicControlsPage());
			});

			this.Clicked2Command = new Command(async () => {
				await Application.Current.MainPage.Navigation.PushAsync(new DynamicControlsPageWithListView());
			});
		}


		public ICommand Clicked1Command { get; protected set; }
		public ICommand Clicked2Command { get; protected set; }
	}
}