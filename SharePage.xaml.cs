namespace MauiAppIntentTest;

public partial class SharePage : ContentPage
{
  public SharePage()
  {
    InitializeComponent();
  }
  public void SetLabelText(string text)
  {
    testLabel.Text = text;
  }

  private void Button_Clicked(object sender, EventArgs e)
  {
    var wnd = GetParentWindow();
    App.Current!.CloseWindow(wnd);
  }
}