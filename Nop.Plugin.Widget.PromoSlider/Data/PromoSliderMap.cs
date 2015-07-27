using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace Nop.Plugin.Widget.PromoSlider.Data
{
    public class PromoSliderMap : EntityTypeConfiguration<PromoSliderREcord>
    {
        public PromoSliderMap()
        {
            ToTable("PromoSlider_PromoSliders");
        }
    }
}