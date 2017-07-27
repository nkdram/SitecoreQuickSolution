using Glass.Mapper.Sc.Configuration.Attributes;
using AppName.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppName.Core.Domain.Component
{
    public class LightBox : CallToAction, IVideo
    {
        [SitecoreField(FieldName = "VideoId")]
        public string VideoId { get; set; }

    }
}
