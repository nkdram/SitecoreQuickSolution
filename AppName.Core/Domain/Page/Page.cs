using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using AppName.Core.Domain.Base;

namespace AppName.Core.Domain
{
    public class Page : BaseEntity, IPage
    {
        [SitecoreField(FieldName = "Page Banner", Setting = SitecoreFieldSettings.InferType)]
        public IBanner PageBanner { get; set; }
        [SitecoreField(FieldName = "Navigation Title")]
        public string NavigationTitle { get; set; }
        [SitecoreField(FieldName = "Exclude From Navigation")]
        public bool ExcludeNavigation { get; set; }
        [SitecoreField(FieldName = "Exclude From SiteMap")]
        public bool ExcludeSiteMap { get; set; }
    }
}
