namespace MauiAppIntentTest
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();

      //MainPage = new AppShell();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
      var act = activationState.Context.Context;
      if (act is MainActivity)
      {
        var newPage = new MainPage();
        newPage.SetDemoText("demo text");
        return new Window(newPage);
      }
      else if (act is ShareActivity)
      {
        var newPage = new SharePage();
        return new Window(newPage);
      }
      else return base.CreateWindow(activationState);
    }
  }
}
