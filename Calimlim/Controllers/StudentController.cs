using Microsoft.AspNetCore.Mvc;
using Calimlim.Models;
using Calimlim.Models;

namespace Calimlim.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    StudentId= 1,
                    StudentFirstName = "Carlos Miguel",
                    StudentLastName = "Calimlim",
                    Course = Course.BSIT,
                    AdmissionDate = DateTime.Parse("2021-08-20"),
                    GPA = 1.6,
                    Email = "carlosmiguelcalimlim@gmail.com"
                },
                new Student()
                {
                    StudentId= 2,StudentFirstName = "Jose Paolo",
                    StudentLastName = "Santos",
                    Course = Course.BSIS,
                    AdmissionDate = DateTime.Parse("2021-05-01"),
                    GPA = 1.6,
                    Email = "josepaolo@gmail.com"
                },
                new Student()
                {
                    StudentId= 3,
                    StudentFirstName = "Isaac Clyde",
                    StudentLastName = "Bernal",
                    Course = Course.BSCS,
                    AdmissionDate = DateTime.Parse("2021-02-23"),
                    GPA = 1.6,
                    Email = "isaacclyde@gmail.com"
                }
            };
        public IActionResult Index()
        {

            return View(StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }
        [HttpGet]
        public IActionResult AddStudent()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            StudentList.Add(newStudent);
            return View("Index", StudentList);
        }

        public IActionResult UpdateStudent()
        {
            return View();
        }
    }
}
