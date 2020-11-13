using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManOnTheMoon.Models
{
    public class Brands
    {
        [Association(Name = "FK_Orders_Customers", Storage = "_Customer", ThisKey = "CustomerID", IsForeignKey = true)]
    }
}