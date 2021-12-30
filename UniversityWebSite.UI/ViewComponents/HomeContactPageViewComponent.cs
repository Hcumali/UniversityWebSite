using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Business.Abstract;

namespace UniversityWebSite.UI.ViewComponents
{
    public class HomeContactPageViewComponent : ViewComponent
    {
        IContactService _contactService;

        public HomeContactPageViewComponent(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var contact = _contactService.GetAllContact();
            return View(contact);
        }
    }
}
