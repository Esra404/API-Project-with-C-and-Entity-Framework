using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUI.ViewComponents
{
    public class _NavbarDefaultComponentDefault : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}