using System;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Plugin.CurrentActivity;

namespace MahechaBJJ.Droid
{
    //You can specify additional application information in this attribute
#if DEBUG
    [Application(Debuggable = true)]
#else
[Application(Debuggable = false)]
#endif
    public class MainApplication : Application, Application.IActivityLifecycleCallbacks
    {
        internal static Context ActivityContext { get; private set; }

        public MainApplication(IntPtr handle, JniHandleOwnership transer)
          :base(handle, transer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            RegisterActivityLifecycleCallbacks(this);
            //A great place to initialize Xamarin.Insights and Dependency Services!
        }

        public override void OnTerminate()
        {
            base.OnTerminate();
            UnregisterActivityLifecycleCallbacks(this);
        }

        public void OnActivityCreated(Activity activity, Bundle savedInstanceState)
        {
            ActivityContext = activity;
            CrossCurrentActivity.Current.Activity = activity;
        }

        public void OnActivityDestroyed(Activity activity)
        {
        }

        public void OnActivityPaused(Activity activity)
        {
        }

        public void OnActivityResumed(Activity activity)
        {
            ActivityContext = activity;
            CrossCurrentActivity.Current.Activity = activity;
        }

        public void OnActivitySaveInstanceState(Activity activity, Bundle outState)
        {
        }

        public void OnActivityStarted(Activity activity)
        {
            ActivityContext = activity;
            CrossCurrentActivity.Current.Activity = activity;
        }

        public void OnActivityStopped(Activity activity)
        {
        }
    }
}