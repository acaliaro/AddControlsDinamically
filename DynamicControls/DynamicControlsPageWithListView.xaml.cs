using System;
using System.Collections.Generic;
using DynamicControls.ViewModels;
using Xamarin.Forms;

namespace DynamicControls
{
	public partial class DynamicControlsPageWithListView : ContentPage
	{
		public DynamicControlsPageWithListView()
		{
			InitializeComponent();
			this.BindingContext = new DynamicControlsPageWithListViewModel();
		}
	}
}
