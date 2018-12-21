using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace WPFVariation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string labelText;

        public string LabelText 
        { 
            get { return labelText; } 
            set 
            {
                labelText = value;
                RaisePropertyChanged("LabelText");
            }             
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            LabelText = "255";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
		{
			ChangeInput(sender);
		}

		private void ChangeInput(object sender)
		{
			if (sender is Button b)
			{
				MessageBox.Show(b.Content.ToString());
				LabelText += b.Content.ToString();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void RaisePropertyChanged(string property)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(property));
			}
		}
	}
}
