using System;
using System.Collections.Generic;
using System.Text;

namespace Afsanay.Core.Enums
{

    public enum CategoryType
    {
        Men = 0,
        Women,
        Children
    };

    public enum DiscountType
    {
        Summer = 3,
        Winter,
        Spring,
        Autumn
    }

    public enum OrderStatus{
        initiated = 7,
        confirmed,
        supplying,
        delivered
    }

    public enum Size
    {
        Small = 11,
        Medium,
        Large,
        XLarge
    }
}
