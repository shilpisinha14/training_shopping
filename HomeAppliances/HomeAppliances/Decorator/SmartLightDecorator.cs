using HomeAppliances.HomeAppliance;
using System;

namespace HomeAppliances.Decorator
{
    internal class SmartLightDecorator : LightDecorator
    {
        public SmartLightDecorator(light Light):base(Light)
        {
        }
        public override float decoratedpowerrating()
        {
            return base.decoratedpowerrating() + 50;
        }
    }
}
