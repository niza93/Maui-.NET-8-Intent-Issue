using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppIntentTest
{
  public static class ServiceHelper
  {
    public static T GetRequiredService<T>() where T : notnull => Services.GetRequiredService<T>();

    public static IServiceProvider Services =>
#if WINDOWS10_0_17763_0_OR_GREATER
			MauiWinUIApplication.Current.Services;
#elif ANDROID
            IPlatformApplication.Current!.Services;
#elif IOS || MACCATALYST
			MauiUIApplicationDelegate.Current.Services;
#else
			null;
#endif
  }
}
