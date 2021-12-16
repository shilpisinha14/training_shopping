using HomeAppliances.HomeAppliance;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAppliances.Decorator
{
    internal class LightDecorator : light
    {
        protected readonly light _light;

        public LightDecorator(light Light):base(Light._powerrating, Light._switchstatus)
        {
            _light = Light;
        }

        public override void printwhoiam()
        {
            _light.printwhoiam();
        }

        public virtual float decoratedpowerrating()
        {
            return _light._powerrating;
        }
    }
}
