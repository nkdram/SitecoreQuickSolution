using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace AppName.Core.Domain.Base
{
    public interface IBanner 
    {
        [SitecoreField(FieldName = "Image")]
        Image BannerImage { get; set; }
        [SitecoreField(FieldName = "Header Content")]
        string HeaderContent { get; set; }
        [SitecoreField(FieldName = "Supporting Content")]
        string SupportingContent { get; set; }
    }
}
