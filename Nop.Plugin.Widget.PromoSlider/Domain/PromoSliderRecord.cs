using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nop.Plugin.Widget.PromoSlider.Models
{
    public class PromoSliderRecord : BaseEntity
    {
        public PromoSliderRecord() 
        {
            Images = new List<PromoSliderRecord>();
        }

        public virtual int PromosliderId { get; set; }
        public virtual string PromoSliderName { get; set; }
        public virtual List<PromoImageRecord> Images { get; set; }        
    }
}