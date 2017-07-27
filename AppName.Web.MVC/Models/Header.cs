using AppName.Core.Base;
using AppName.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppName.Web.MVC.Models
{
    public class Header : BaseEntity
    {
        public string Title { get; set; }
    }
}