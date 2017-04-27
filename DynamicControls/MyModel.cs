using System;
using PropertyChanged;

namespace DynamicControls
{

	[ImplementPropertyChanged]
	public class MyModel
	{
		public string LabelDescription { get; set; }
		public string Description { get; set; }
		public bool Selected { get; set; }

		public MyModel()
		{
		}
	}
}
