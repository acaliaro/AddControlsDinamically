using System;
using System.Collections.Generic;
using DynamicControls.ViewModels;
using Xamarin.Forms;

namespace DynamicControls
{
	public partial class MyPage : ContentPage
	{
		public MyPage()
		{
			InitializeComponent();
			this.BindingContext = new MyPageViewModel();
		}
	}
}
