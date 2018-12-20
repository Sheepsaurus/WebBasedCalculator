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
                OnPropertyChanged();
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
            if (sender is Button b)
            {
                MessageBox.Show(b.Content.ToString());
                LabelText += b.Content.ToString();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }

        protected void OnPropertyChanged(
        [System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
    }
}
