using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecondHandHouse.Domain
{
    public class Transaction
    {
        public Transaction(Seller seller, Buyer buyer)
        {
            this.Seller = seller;
            this.Buyer = buyer;
        }

        /// <summary>
        /// 卖家
        /// </summary>
        public Seller Seller
        {
            get;
        }

        /// <summary>
        /// 买家
        /// </summary>
        public Buyer Buyer
        {
            get;
        }

        /// <summary>
        /// 地契税
        /// </summary>
        public double DeedTax
        {
            get
            {
                var tax = 4.0;
                if (Buyer.IsFirstHouse == true) //购买首套房
                {
                    if (Seller.House.Size == AreaSize.Small)
                    {
                        tax = 1.0;
                    }
                    if (Seller.House.Size == AreaSize.Mediu)
                    {
                        tax = 2.0;
                    }
                    if (Seller.House.Size == AreaSize.Large)
                    {
                        tax = 4.0;
                    }
                }
                else
                {
                    tax = 4.0;
                }
                return Seller.House.TotalPrice * tax / 100.0;
            }
        }

        /// <summary>
        /// 出售税
        /// </summary>
        public double SalesTax
        {
            get
            {
                var tax = 5.6;
                if (Seller.House.isMoreThenFiveYears)
                {
                    if (Seller.House.Property == EstatePorperty.Normal) // 普通住房免征
                    {
                        tax = 0.0;
                    }
                    else //非普通住房
                    {
                        tax = 5.6;
                    }
                }
                else
                {
                    tax = 5.6;
                }
                return Seller.House.TotalPrice * tax / 100.0;
            }
        }

        /// <summary>
        /// 个人所得税
        /// </summary>
        public double PersonalIncomeTax
        {
            get
            {
                var tax = 3.0;
                if (Seller.House.isMoreThenFiveYears == true)
                {
                    if (Seller.IsOnlyHouse == true)
                    {
                        tax = 0.0;
                    }
                    else
                    {
                        tax = 3.0;
                    }
                }
                else
                {
                    tax = 3.0;
                }
                return Seller.House.TotalPrice * tax / 100.0;
            }
        }

        /// <summary>
        /// 印花税
        /// </summary>
        public double StampTax
        {
            get;
        } = 0.0;

        /// <summary>
        /// 工本税
        /// </summary>
        public double CostTax
        {
            get;
        } = 5.0;

        /// <summary>
        /// 综合税
        /// </summary>
        public double SyntheyicalLandTax
        {
            get
            {
                var tax = 0.0;
                if (Seller.House.Property == EstatePorperty.Affordable)
                {
                    if (Seller.House.isMoreThenFiveYears)
                    {
                        tax = 10.0;
                    }
                    else
                    {
                        throw new Exception("经济适用房未满5年不可交易");
                    }
                }
                return Seller.House.TotalPrice * tax / 100.0;
            }
        }

        /// <summary>
        /// 税务和
        /// </summary>
        public double TotalTax
        {
            get
            {
                return DeedTax + PersonalIncomeTax + SalesTax + StampTax + CostTax + SyntheyicalLandTax;
            }
        }
    }
}