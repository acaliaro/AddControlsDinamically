using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using PropertyChanged;
namespace DynamicControls.ViewModels
{

	[ImplementPropertyChanged]
	public class DynamicControlsPageWithListViewModel
	{
		int labelCounter = 1;
		public ObservableCollection<MyModel> List { get; set; }

		public DynamicControlsPageWithListViewModel(){

			List = new ObservableCollection<MyModel>();

			this.ClickedCommand = new Command(() => {

				MyModel model = new MyModel() {Description = "", Selected = false, LabelDescription = "Label " + labelCounter++ };
				List.Add(model);
			});
		}

		public ICommand ClickedCommand { get; protected set; }
	}
}