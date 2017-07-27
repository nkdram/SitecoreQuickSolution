using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace AppName.Core.Domain.Base
{
    public interface IPage
    {
        [SitecoreField(FieldName = "Page Banner", Setting = SitecoreFieldSettings.InferType)]
        IBanner PageBanner { get; set; }
        [SitecoreField(FieldName = "Navigation Title")]
        string NavigationTitle { get; set; }
        [SitecoreField(FieldName = "Exclude From Navigation")]
        bool ExcludeNavigation { get; set; }
        [SitecoreField(FieldName = "Exclude From SiteMap")]
        bool ExcludeSiteMap { get; set; }
    }
}
