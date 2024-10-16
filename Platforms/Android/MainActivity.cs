using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace MauiAppIntentTest
{
  [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, Exported = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
  public class MainActivity : MauiAppCompatActivity
  {
  }

  [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = false, Exported = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
  [IntentFilter([Intent.ActionSend], Categories = [Intent.CategoryDefault], DataMimeType = "application/json")]
  public class ShareActivity : MauiAppCompatActivity
  {
    protected override void OnCreate(Bundle? savedInstanceState)
    {
      var intent = Intent;
      base.OnCreate(savedInstanceState);
    }
    protected override void OnNewIntent(Intent? intent)
    {
      base.OnNewIntent(intent);
    }
  }
}
