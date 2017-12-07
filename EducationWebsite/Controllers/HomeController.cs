using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationWebsite.Controllers
{
    public class HomeController : Controller
    {
        const string ACTIVE_CLASS = "active open";
        const string ACTIVE_SUB = "active";
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Index = ACTIVE_CLASS;
            return View();
        }
        public ActionResult MailBox()
        {
            ViewBag.MailBox = ACTIVE_CLASS;
            ViewBag.Inbox = ACTIVE_SUB;
            return View();
        }
        public ActionResult Event()
        {
            ViewBag.Event = ACTIVE_CLASS;
            return View();
        }
        public ActionResult Teacher()
        {
            ViewBag.Teacher = ACTIVE_CLASS;
            ViewBag.AllTeacher = ACTIVE_SUB;
            return View();
        }
        public ActionResult AddTeacher()
        {
            ViewBag.Teacher = ACTIVE_CLASS;
            ViewBag.AddTeacher = ACTIVE_SUB;
            return View();
        }
        public ActionResult ProfileTeacher()
        {
            ViewBag.Teacher = ACTIVE_CLASS;
            ViewBag.ProTeacher = ACTIVE_SUB;
            return View();
        }
        public ActionResult Student()
        {
            ViewBag.Student = ACTIVE_CLASS;
            ViewBag.AllStudent = ACTIVE_SUB;
            return View();
        }
        public ActionResult AddStudent()
        {
            ViewBag.Student = ACTIVE_CLASS;
            ViewBag.AddStudent = ACTIVE_SUB;
            return View();
        }
        public ActionResult ProfileStudent()
        {
            ViewBag.Student = ACTIVE_CLASS;
            ViewBag.ProStudent = ACTIVE_SUB;
            return View();
        }
        public ActionResult StudentInvoice()
        {
            ViewBag.Student = ACTIVE_CLASS;
            ViewBag.InvoiceStudent = ACTIVE_SUB;
            return View();
        }
        public ActionResult Courses()
        {
            ViewBag.Course = ACTIVE_CLASS;
            ViewBag.AllCourse = ACTIVE_SUB;
            return View();
        }
        public ActionResult AddCourses()
        {
            ViewBag.Course = ACTIVE_CLASS;
            ViewBag.AddCourse = ACTIVE_SUB;
            return View();
        }
        public ActionResult CourseInfo()
        {
            ViewBag.Course = ACTIVE_CLASS;
            ViewBag.InfoCourse = ACTIVE_SUB;
            return View();
        }
        public ActionResult Library()
        {
            ViewBag.Library = ACTIVE_CLASS;
            ViewBag.AllLibrary = ACTIVE_SUB;
            return View();
        }
        public ActionResult AddLibrary()
        {
            ViewBag.Library = ACTIVE_CLASS;
            ViewBag.AddLibrary = ACTIVE_SUB;
            return View();
        }
        public ActionResult Department()
        {
            ViewBag.Dep = ACTIVE_CLASS;
            ViewBag.AllDep = ACTIVE_SUB;
            return View();
        }
        public ActionResult AddDepartment()
        {
            ViewBag.Dep = ACTIVE_CLASS;
            ViewBag.AddDep = ACTIVE_SUB;
            return View();
        }
        public ActionResult Staff()
        {
            ViewBag.Staff = ACTIVE_CLASS;
            ViewBag.AllStaff = ACTIVE_SUB;
            return View();
        }
        public ActionResult AddStaff()
        {
            ViewBag.Staff = ACTIVE_CLASS;
            ViewBag.AddStaff = ACTIVE_SUB;
            return View();
        }
        public ActionResult StaffInfo()
        {
            ViewBag.Staff = ACTIVE_CLASS;
            ViewBag.InfoStaff = ACTIVE_SUB;
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        public ActionResult Forgot()
        {
            return View();
        }


    }
}