using ClassLibrary1.ViewModels;
using MvvmCross.ViewModels;

namespace ClassLibrary1
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			base.Initialize();
			RegisterAppStart<MainViewModel>();
		}
	}
}
