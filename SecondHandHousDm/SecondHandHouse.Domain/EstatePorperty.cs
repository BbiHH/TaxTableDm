using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecondHandHouse.Domain
{
    public enum EstatePorperty
    {
        /// <summary>
        /// 普通住房
        /// </summary>
        Normal = 0,

        /// <summary>
        /// 非普通住房
        /// </summary>
        NonNormal = 1,

        /// <summary>
        /// 经济适用房
        /// </summary>
        Affordable = 2
    }
}