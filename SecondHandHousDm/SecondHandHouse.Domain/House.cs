using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecondHandHouse.Domain
{
    public class House
    {
        public House(double area, double unitPrice, bool isMoreThenFiveYears, EstatePorperty porperty)
        {
            Area = area;
            this.UnitPrice = unitPrice;
            this.isMoreThenFiveYears = isMoreThenFiveYears;
            this.Property = porperty;
        }

        /// <summary>
        /// 房屋面积
        /// </summary>
        public double Area
        {
            get;
        }

        /// <summary>
        /// 面积单价
        /// </summary>
        public double UnitPrice
        {
            get;
        }

        /// <summary>
        /// 是否满5年
        /// </summary>
        public bool isMoreThenFiveYears
        {
            get;
        }

        /// <summary>
        /// 房屋性质：普通、非普通、经济适用房
        /// </summary>
        public EstatePorperty Property
        {
            get;
        }

        /// <summary>
        /// 房屋大小：小/中/大
        /// </summary>
        public AreaSize Size
        {
            get
            {
                AreaSize size = AreaSize.Large;
                if (Area < 90)
                {
                    size = AreaSize.Small;
                }
                else if (Area < 144)
                {
                    size = AreaSize.Mediu;
                }
                else
                {
                    size = AreaSize.Large;
                }
                return size;
            }
        }

        /// <summary>
        /// 房屋总价
        /// </summary>
        public double TotalPrice
        {
            get
            {
                return Area * UnitPrice;
            }
        }
    }
}