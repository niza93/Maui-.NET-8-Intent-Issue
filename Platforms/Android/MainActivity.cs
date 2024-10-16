using Android.App;
using Android.Content;
using Android.Content.PM;

namespace MauiAppIntentTest
{
  [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
  [IntentFilter([Intent.ActionSend], Categories = [Intent.CategoryDefault], DataMimeType = "application/json")]
  public class MainActivity : MauiAppCompatActivity
  {
    protected override void OnNewIntent(Intent? intent)
    {
      base.OnNewIntent(intent);
    }
  }
}
