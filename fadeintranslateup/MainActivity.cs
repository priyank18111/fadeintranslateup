using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace fadeintranslateup
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
       
            Button animate;
            ImageView image;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            animate = FindViewById<Button>(Resource.Id.Animate);
            image = FindViewById<ImageView>(Resource.Id.imageView);
            animate.Click += Animate_Click;
        }

        private void Animate_Click(object sender, System.EventArgs e)
        {
            var animation = AnimationUtils.LoadAnimation(this, Resource.Animation.fadeintranslateup);
            image.StartAnimation(animation);

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}