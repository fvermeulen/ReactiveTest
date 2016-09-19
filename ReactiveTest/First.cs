using System;
using System.Reactive;
using System.Threading.Tasks;
using ReactiveUI;

namespace ReactiveTest
{
	public class First
	{
		public ReactiveCommand<Unit, Unit> TestCommand { set; get; }

		public ReactiveCommand<Unit, bool> TestBoolResult { set; get; }

		public First()
		{

			TestCommand = ReactiveCommand.CreateFromTask(async () => await WillBeExecuted());

			TestBoolResult = ReactiveCommand.CreateFromTask<bool>(async () => await WillReturnTrue());
		}

		public async Task WillBeExecuted()
		{
			var temp = "test";
		}

		public async Task<bool> WillReturnTrue()
		{
			return true;
		}
	}
}
