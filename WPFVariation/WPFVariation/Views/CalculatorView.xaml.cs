using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPFVariation;

namespace WPFVariation.Views
{
	/// <summary>
	/// Interaction logic for CalculatorView.xaml
	/// </summary>
	public partial class CalculatorView : UserControl
	{
		public CalculatorView()
		{
			InitializeComponent();
			DataContext = new ViewModel.ButtonViewModel();
		}

	}
}
