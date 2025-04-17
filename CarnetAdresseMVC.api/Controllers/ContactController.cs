using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarnetAdresseMVC.api.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }

        // GET: ContactController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: ContactController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: ContactController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }        
    }
}
