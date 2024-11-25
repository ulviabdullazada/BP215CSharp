using BP215UniqloMVC.ViewModels.Product;
using BP215UniqloMVC.ViewModels.Slider;

namespace BP215UniqloMVC.ViewModels.Common;

public class HomeVM
{
    public IEnumerable<SliderItemVM> Sliders { get; set; }
    public IEnumerable<ProductItemVM> Products { get; set; }
}
