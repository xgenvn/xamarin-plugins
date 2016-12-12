using Android.App;
using Android.Content;
using System.Threading;
using Android.Gms.Iid;
using PushNotification.Plugin.Abstractions;

namespace PushNotification.Plugin
{

    [Service(Exported = false)]
    [IntentFilter(new string[] { "com.google.android.gms.iid.InstanceID" })]
    public class PushNotificationInstanceIDListenerService : InstanceIDListenerService
    {
        const string Tag = "PushNotificationInstanceIDLS";
        /**
         * Called if InstanceID token is updated. This may occur if the security of
         * the previous token had been compromised. This call is initiated by the
         * InstanceID provider.
         */
        public override void OnTokenRefresh()
        {
 	       base.OnTokenRefresh();

            ThreadPool.QueueUserWorkItem(state =>
            {
                try
                {
                    Intent intent = new Intent(Android.App.Application.Context, typeof(PushNotificationRegistrationIntentService));
                    Android.App.Application.Context.StartService(intent);
                }
                catch (System.Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"{ex.Message} - Error : {Tag}");

                    CrossPushNotification.PushNotificationListener.OnError($"{ex.ToString()} - Register - {Tag}", DeviceType.Android);

                }

            });
        }
    }
}