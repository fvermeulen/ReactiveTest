using System.Reactive.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using ReactiveTest;
using ReactiveUI;

namespace NUnit
{
	[TestFixture]
	public class MyClass
	{
		[Test]
		public void ShouldBeTrue()
		{
			Assert.IsTrue(false);
		}

		[Test]
		public void ShouldBeTrue2()
		{
			Assert.IsTrue(true);
		}

		[Test]
		public async Task CommandWillBeExecuted()
		{
			var first = new First();

			var temp = await first.WillReturnTrue();

			Assert.IsTrue(temp);
		}

		[Test]
		public async Task LocalCommandWillBeExecuted()
		{
			var test = ReactiveCommand.CreateFromTask<bool, bool>(async (arg) =>
			{
				return true;
			});

			var temp = await test.Execute();

			Assert.IsTrue(temp);
		}
	}
}
