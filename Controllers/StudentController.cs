using _06_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace _06_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private static readonly string[] names = new[]
        {
            "Tizio", "Caio", "Sempronio"
        };

        private static readonly string[] classes = new[]
        {
            "A1", "A2", "A3", "A4", "A5"
        };

        private static readonly string[] bodyFeatures = new[]
        {
            "tall", "short", "fat", "thin"
        };

        private static readonly List<Student> students = new()
        {
            new Student
                    {
                        Name = names[Random.Shared.Next(names.Length)],
                        Class = classes[Random.Shared.Next(classes.Length)],
                        BodyFeature = bodyFeatures[Random.Shared.Next(bodyFeatures.Length)]
                    },
            new Student
                    {
                        Name = names[Random.Shared.Next(names.Length)],
                        Class = classes[Random.Shared.Next(classes.Length)],
                        BodyFeature = bodyFeatures[Random.Shared.Next(bodyFeatures.Length)]
                    },
            new Student
                    {
                        Name = names[Random.Shared.Next(names.Length)],
                        Class = classes[Random.Shared.Next(classes.Length)],
                        BodyFeature = bodyFeatures[Random.Shared.Next(bodyFeatures.Length)]
                    },
            new Student
                    {
                        Name = names[Random.Shared.Next(names.Length)],
                        Class = classes[Random.Shared.Next(classes.Length)],
                        BodyFeature = bodyFeatures[Random.Shared.Next(bodyFeatures.Length)]
                    }
        };

        //private readonly ILogger<StudentController> _logger;

        //public StudentController(ILogger<StudentController> logger)
        //{
        //    _logger = logger;
        //}

        [HttpGet(Name = "GetAllStudents")]
        public List<Student> Get() => students;

        [HttpGet("/{num}")]
        public Student Get(int num) => students[num];

        [HttpPost]
        public string Post([FromBody] Student student)
        {
            var req = Request.Body;
            students.Add(student);
            return "Insertion correctly completed";
        }

        [HttpDelete("/{num}")]
        public StatusCodeResult Delete(int num)
        {
            if (num > 0 && num <= students.Count)
            {
                students.Remove(Get(num));
                //return "Student removed";
            }
            //return "Not a valid number";
            return StatusCode(404);
        }

        


    }
}