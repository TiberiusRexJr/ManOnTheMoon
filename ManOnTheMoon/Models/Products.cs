using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Web;

namespace ManOnTheMoon.Models
{
    [Table(Name ="Products")]
    public class Products
    {

        [Column(IsPrimaryKey =true)]
        int Id { get; set; }
        [Column]
        string Name { get; set; } 
        [Column]
        string Description { get; set; }
        [Column]
        int Upc { get; set; }
        [Column]
        string Brand { get; set; }
        [Column]
        float Length { get; set; }
        [Column]
        float Width { get; set; }
        [Column]
        float Height { get; set; }
        [Column]
        float Weight { get; set; }
        [Column]
        Decimal Cost { get; set; }
        [Column]
        Decimal Retail_Price { get; set; }
        [Column]
        Decimal Sale_Price { get; set; }
        [Column]
        int Stock_Quantity { get; set; }
        [Column]
        string Category { get; set; }
        [Column]
        string Sub_Category { get; set; }
        [Column]
        Boolean On_Sale_Status { get; set; }



    }
}