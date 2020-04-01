using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecondHandHouse.Domain
{
    public class Seller
    {
        public Seller(House house, bool isOnlyHouse)
        {
            this.House = house;
            this.IsOnlyHouse = isOnlyHouse;
        }

        public House House
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// 是否唯一住房
        /// </summary>
        public bool IsOnlyHouse
        {
            get => default;
            set
            {
            }
        }
    }
}