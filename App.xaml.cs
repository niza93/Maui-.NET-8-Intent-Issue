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
      do
      {
        if (activationState == null) break;

        var act = activationState.Context.Context;
        if (act is MainActivity)
        {
          if (MainPage == null)
            return new Window(new AppShell());
        }
        else if (act is ShareActivity)
        {
          var page = ServiceHelper.GetRequiredService<SharePage>();

          page.Parent ??= new Window(page);

          return page.Window;
        }
      }
      while (false);

      return base.CreateWindow(activationState);
    }
  }
}
