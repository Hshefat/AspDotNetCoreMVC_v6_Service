using CRUD_v6_1.Context;
using CRUD_v6_1.Models;
using CRUD_v6_1.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_v6_1.Controllers
{
    public class SubjectController : Controller
    {
        ISubjectServices iss;

        public SubjectController(ISubjectServices _iss)
        {
            iss = _iss;
        }
        public IActionResult Index()
        {
            
            return View(iss.GetAllSubjects());
        }

        public IActionResult Delete(int id)
        { 
                iss.DeleteASubject(id);
                return RedirectToAction("Index");
            
           
        }
    }
}
