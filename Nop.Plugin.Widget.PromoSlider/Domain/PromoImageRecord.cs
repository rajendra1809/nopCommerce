using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nop.Plugin.Widget.PromoSlider.Models
{
    public class PromoImageRecord : BaseEntity
    {
        public virtual int PromoImageId { get; set; }
        public virtual int promoSliderId { get; set; }
        public virtual string Caption { get; set; }
        public PromoSliderRecord PromoSlider { get; set; }
    }
}