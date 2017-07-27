using System;

namespace AppName.Core.Domain.Base
{
    public class BaseEntity
    {
        Guid Id { get; set; }
        string Url { get; set; }
        string Title { get; set; }
    }
}
