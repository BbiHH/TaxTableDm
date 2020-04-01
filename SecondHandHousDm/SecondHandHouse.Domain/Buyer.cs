using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecondHandHouse.Domain
{
    public class Buyer
    {
        public Buyer(bool isFirstHouse)
        {
            this.IsFirstHouse = isFirstHouse;
        }

        /// <summary>
        /// 是否为购入首套房
        /// </summary>
        public bool IsFirstHouse
        {
            get;
        }
    }
}