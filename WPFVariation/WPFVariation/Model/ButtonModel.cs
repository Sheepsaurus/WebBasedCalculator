using System.ComponentModel;

namespace WPFVariation.Model
{
	class ButtonModel : INotifyPropertyChanged
	{
		public ButtonModel(int column, int row, string backgroundcolour, string content, int rowspan)
		{
			Column = column;
			Row = row;
			Backgroundcolour = backgroundcolour;
			Content = content;
			Rowspan = rowspan;
		}

		public ButtonModel(int column, int row, string backgroundcolour, string content)
		{
			Column = column;
			Row = row;
			Backgroundcolour = backgroundcolour;
			Content = content;
		}

		private int column;
		private int row;
		private int rowspan;
		private string backgroundcolor;
		private string content;

		public int Column {
			get { return column; }
			set
			{
				column = value;
				RaisePropertyChanged("Column");
			}
		}
		public int Row
		{
			get { return row; }
			set
			{
				row = value;
				RaisePropertyChanged("Row");
			}
		}
		public int Rowspan
		{
			get { return rowspan; }
			set
			{
				rowspan = value;
				RaisePropertyChanged("Rowspan");
			}
		}
		public string Backgroundcolour
		{
			get { return backgroundcolor; }
			set
			{
				backgroundcolor = value;
				RaisePropertyChanged("Backgroundcolour");
			}
		}
		public string Content
		{
			get { return content; }
			set
			{
				content = value;
				RaisePropertyChanged("Content");
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
