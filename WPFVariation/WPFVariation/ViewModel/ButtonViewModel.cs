using System.Collections.ObjectModel;
using WPFVariation.Model;

namespace WPFVariation.ViewModel
{
	class ButtonViewModel
	{
		public ButtonViewModel()
		{
			LoadButtons();
		}

		public ObservableCollection<ButtonModel> Buttons {
			get; 
			set; 
		}

		public void LoadButtons ()
		{
			Buttons = new ObservableCollection<ButtonModel>
			{
				new ButtonModel(0, 0, "AliceBlue", "?"),
				new ButtonModel(1, 0, "AliceBlue", "?"),
				new ButtonModel(2, 0, "AliceBlue", "+/-"),
				new ButtonModel(3, 0, "AliceBlue", "/"),

				new ButtonModel(0, 1, "LightYellow", "7"),
				new ButtonModel(1, 1, "LightYellow", "8"),
				new ButtonModel(2, 1, "LightYellow", "9"),
				new ButtonModel(3, 1, "AliceBlue", "*"),

				new ButtonModel(0, 2, "LightYellow", "4"),
				new ButtonModel(1, 2, "LightYellow", "5"),
				new ButtonModel(2, 2, "LightYellow", "6"),
				new ButtonModel(3, 2, "AliceBlue", "-"),

				new ButtonModel(0, 3, "LightYellow", "1"),
				new ButtonModel(1, 3, "LightYellow", "2"),
				new ButtonModel(2, 3, "LightYellow", "3"),
				new ButtonModel(3, 3, "AliceBlue", "+", 2),

				new ButtonModel(0, 4, "LightYellow", "0"),
				new ButtonModel(1, 4, "AliceBlue", "."),
				new ButtonModel(2, 4, "AliceBlue", "=")
			};
		}
	}
}
