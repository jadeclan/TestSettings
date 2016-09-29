using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace TestSettings
{
    [Activity(Label = "Test Settings", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button clickMe;
        private TextView messageTextView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView (Resource.Layout.Main);
            FindViews();
            HandleEvents();
        }
        public void FindViews()
        {
            clickMe = FindViewById<Button>(Resource.Id.button1);
            messageTextView = FindViewById<TextView>(Resource.Id.messageTextView);
        }
        public void HandleEvents()
        {
            clickMe.Click += ClickMe_Click;
        }

        private void ClickMe_Click(object sender, System.EventArgs e)
        {
            clickMe.Visibility = ViewStates.Gone;
            messageTextView.Visibility = ViewStates.Visible;
        }
    }
}

