using System.Windows.Input;

namespace View
{
	public static class MyRoutedComands
	{
		public static RoutedCommand First { get; }
			= new RoutedUICommand("Первый", nameof(First), typeof(MyRoutedComands));

		public static RoutedCommand Second { get; }
			= new RoutedUICommand("Второй", nameof(Second), typeof(MyRoutedComands));
	}
}
