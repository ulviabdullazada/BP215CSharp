using BP215UniqloMVC.ViewModels.Product;

namespace BP215UniqloMVC.Models;
public class Product : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal CostPrice { get; set; }
    public decimal SellPrice { get; set; }
    public int Quantity { get; set; }
    public int Discount { get; set; }
    public string CoverImage { get; set; } = null!;
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }

    //public static implicit operator Product(ProductCreateVM vm)
    //{
    //    return new Product
    //    {
    //        CategoryId = vm.CategoryId,
    //        CostPrice = vm.CostPrice,
    //        Description = vm.Description,
    //        Discount = vm.Discount,
    //        Name = vm.Name,
    //        Quantity = vm.Quantity,
    //        SellPrice = vm.SellPrice
    //    };
    //}
}
