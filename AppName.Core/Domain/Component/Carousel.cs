using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using AppName.Core.Domain.Base;
using System.Collections.Generic;

namespace AppName.Core.Domain.Component
{
    public class Carousel : BaseEntity
    {
        [SitecoreField(FieldName = "Items", Setting = SitecoreFieldSettings.InferType)]
        public virtual IEnumerable<IBanner> CarouselItems { get; set; }
        [SitecoreField(FieldName = "Auto Play", Setting = SitecoreFieldSettings.InferType)]
        public virtual bool AutoPlay { get; set; }
        [SitecoreField(FieldName = "Autoplay Speed", Setting = SitecoreFieldSettings.InferType)]
        public virtual int AutoplaySpeed { get; set; }
        [SitecoreField(FieldName = "Include Dots", Setting = SitecoreFieldSettings.InferType)]
        public virtual bool IncludeDots { get; set; }
    }
}
