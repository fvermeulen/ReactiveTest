using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Threading.Tasks;
using ReactiveUI;
using Xamarin.Forms;

namespace ReactiveTest
{
	public partial class ReactiveTestPage : ContentPage
	{
		private ReactiveCommand<Unit, Unit> SecondClick { set; get; }

		public ReactiveTestPage()
		{
			InitializeComponent();

			TestButton.Command = ReactiveCommand.Create(() => {
				Debug.WriteLine("test");
				SecondClick.Execute();
			});

			SecondClick = ReactiveCommand.CreateFromTask(async () => {
				Debug.WriteLine("Second");
			});
		}
	}
}
