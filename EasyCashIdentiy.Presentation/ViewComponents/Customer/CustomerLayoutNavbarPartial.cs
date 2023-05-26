using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentiy.Presentation.ViewComponents.Customer;

public class CustomerLayoutNavbarPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View
            ();
    }
}