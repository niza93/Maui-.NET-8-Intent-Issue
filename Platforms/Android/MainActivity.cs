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
      base.OnCreate(savedInstanceState);

      do
      {
        if (Intent == null) break;
        if (Intent.ClipData == null) break;
        if (Intent.Action != Intent.ActionSend) break;
        if (Intent.Type != "application/json") break;

        var filePath = Intent.ClipData.GetItemAt(0);

        if (filePath == null) break;
        if (filePath.Uri == null) break;
        if (base.ContentResolver == null) break;

        using var inputStream = base.ContentResolver.OpenInputStream(filePath.Uri);

        if (inputStream == null) break;

        using var reader = new StreamReader(inputStream);

        var content = reader.ReadToEnd();
        
        var sharePage = ServiceHelper.GetRequiredService<SharePage>();
        sharePage.SetLabelText(content);
      }
      while (false);
    }
  }
}
