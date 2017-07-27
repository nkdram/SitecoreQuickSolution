using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using AppName.Core.Domain.Base;
using System.Collections.Generic;

namespace AppName.Core.Domain.Component
{
    public class Header : BaseEntity
    {
        public Image Logo { get; set; }
        [SitecoreField(FieldName = "Top Nav", Setting = SitecoreFieldSettings.InferType)]
        public virtual IEnumerable<Page> TopNav { get; set; }
        [SitecoreField(FieldName = "Main Nav", Setting = SitecoreFieldSettings.InferType)]
        public virtual IEnumerable<Page> MainNav { get; set; }
    }
}
