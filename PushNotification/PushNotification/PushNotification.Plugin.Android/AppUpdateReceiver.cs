using Android.App;
using Android.Content;

namespace PushNotification.Plugin
{
    [BroadcastReceiver]
    [IntentFilter(new[] { "android.intent.action.MY_PACKAGE_REPLACED" })]
    public class AppUpdateReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            if (CrossPushNotification.IsInitialized)
                CrossPushNotification.Current.Register();
        }
    }
}