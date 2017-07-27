using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using AppName.Core.Domain.Base;
using System;
using System.Collections.Generic;

namespace AppName.Core.Domain.Component
{
    public class Footer : BaseEntity
    {
        public Image Logo { get; set; }
        public virtual string Description { get; set; }
        [SitecoreField(FieldName = "Copyrights Text", Setting = SitecoreFieldSettings.InferType)]
        public virtual string Copyrights { get; set; }
        [SitecoreField(FieldName = "Site Links", Setting = SitecoreFieldSettings.InferType)]
        public virtual IEnumerable<Page> SiteLinks { get; set; }

        public string Title { get; set; }
        public Guid Id { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
    }
}
