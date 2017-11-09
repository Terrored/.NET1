using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET1
{
    class Order
    {
        public List<Dish> OrderList;
        public double ToPay;
        public bool CanGetSwiezak;

        public Order()
        {
            OrderList = new List<Dish>();
        }

        public void CalculateToPay()
        {
            
            foreach (var dish in OrderList)
            {
                ToPay += dish.Price;

            }
        }

        public void SetPromotionSwiezak()
        {

            if (ToPay >= 500)
            {
                CanGetSwiezak = true;
            }
            else CanGetSwiezak = false;
        }
    }
}
