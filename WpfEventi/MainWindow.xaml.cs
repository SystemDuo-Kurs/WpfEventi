using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfEventi
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		ObservableCollection<string> kolekcija = new();
		
		public MainWindow()
		{
			InitializeComponent();
			dugme.Click += Ping;
			kolekcija.CollectionChanged += Foo;
			kolekcija.Add("asdasd");
			this.Closing += Bar;
		}
		public void Bar(object o, CancelEventArgs e)
		{
			MessageBox.Show("Poyyyyy!");
		}

		public void Foo(object o, NotifyCollectionChangedEventArgs a)
		{
			MessageBox.Show("Promenaaaa!");
		}

		public void Ping(object o, RoutedEventArgs e)
		{
			MessageBox.Show("Ping");
			dugme.Click -= Ping;
			dugme.Click += Pong;
		}

		public void Pong(object o, RoutedEventArgs e)
		{
			MessageBox.Show("Pong");
			dugme.Click -= Pong;
			dugme.Click += Ping;
		}
	}
}
