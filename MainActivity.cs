using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace ConverterXamarinAndroid {
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity {
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            EditText phoneNumberText = FindViewById<EditText>(Resource.Id.edit_text);
            TextView translatedPhoneWord = FindViewById<TextView>(Resource.Id.text_converted);
            Button translateButton = FindViewById<Button>(Resource.Id.button_converter);

            translateButton.Click += (sender, e) => {
                string translatedNumber = Core.StringConverter.ToNumber(phoneNumberText.Text);
                translatedPhoneWord.Text = translatedNumber;
            };
        }
    }
}
