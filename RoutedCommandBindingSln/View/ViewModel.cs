using System.Windows;
using System.Windows.Input;

namespace View
{
	public class ViewModel
	{
		public ICommand Command { get; } = new RelayCommand
		(
			p => MessageBox.Show((string)p),
			p => !string.IsNullOrWhiteSpace(p as string)
		);

		public string Text { get; set; } = "Свойство";
	}
}
