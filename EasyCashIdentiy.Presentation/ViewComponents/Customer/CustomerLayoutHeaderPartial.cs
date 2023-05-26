using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentiy.Presentation.ViewComponents.Customer;

public class CustomerLayoutHeaderPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}