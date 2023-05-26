using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentiy.Presentation.ViewComponents.Customer;

public class CustomerLayoutSidebarPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}