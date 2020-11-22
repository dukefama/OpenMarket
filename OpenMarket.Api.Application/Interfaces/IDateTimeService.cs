using System;
using System.Collections.Generic;
using System.Text;

namespace OpenMarket.Api.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
