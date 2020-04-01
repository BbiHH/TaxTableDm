using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecondHandHouse.Domain
{
    public enum AreaSize
    {
        /// <summary>
        /// 小于90平方
        /// </summary>
        Small = 0,
        /// <summary>
        /// 大于90小于144 平方
        /// </summary>
        Mediu = 1,
        /// <summary>
        /// 大于144平方
        /// </summary>
        Large = 2
    }
}