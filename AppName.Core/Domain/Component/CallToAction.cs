using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using AppName.Core.Domain.Base;
using System;

namespace AppName.Core.Domain.Component
{
    public class CallToAction : BaseEntity
    {
        public string Content { get; set; }
        public Guid Id { get; set; }
        public string Url { get; set; }

        [SitecoreField(FieldName = "Description")]
        public virtual string Description { get; set; }
        [SitecoreField(FieldName = "Backdrop Image")]
        public virtual Image BackdropImage { get; set; }
        [SitecoreField(FieldName = "Title")]
        public virtual string Title { get; set; }
    }
}
