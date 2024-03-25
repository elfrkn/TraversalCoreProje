using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            List<Announcement> announcements = _announcementService.TGetList();
            List<AnnouncementListViewModel> model = new List<AnnouncementListViewModel>();
            foreach (var item in announcements)
            {
                AnnouncementListViewModel announcementListViewModel = new AnnouncementListViewModel();
                announcementListViewModel.ID = item.AnnouncementID;
                announcementListViewModel.Title = item.Title;
                announcementListViewModel.Content = item.Content;

                model.Add(announcementListViewModel);

            }
            return View(model);
        }

        [HttpGet]
        public IActionResult AddAnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnouncement(string p)
        {
            return View();
        }
    }
}
