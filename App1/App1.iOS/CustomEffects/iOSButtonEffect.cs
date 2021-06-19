using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("ButtonEffect")]
[assembly: ExportEffect(typeof(App1.iOS.CustomEffects.iOSButtonEffect), "SpecialButtonEffect")]
namespace App1.iOS.CustomEffects
{

    class iOSButtonEffect: PlatformEffect
    {
        protected override void OnAttached()
        {
            (Control as UIButton).TouchUpOutside += OnTouchUpOutside;
        }

        protected override void OnDetached()
        {
            (Control as UIButton).TouchUpOutside -= OnTouchUpOutside;
        }

        private void OnTouchUpOutside(object sender, EventArgs e)
        {
            (Element as IButtonController).SendReleased();
        }
    }
}