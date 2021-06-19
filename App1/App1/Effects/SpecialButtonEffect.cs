using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace App1.Effects
{
    class SpecialButtonEffect: RoutingEffect
    {
            public SpecialButtonEffect() : base($"ButtonEffect.{nameof(SpecialButtonEffect)}")
            {
            }
        
    }
}
