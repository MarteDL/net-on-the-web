using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using net_on_the_web.Models;

namespace net_on_the_web.Pages
{
    public class ClassModel : PageModel
    {
        public Class Class { get; set; }
        
        public void OnGet()
        {
            var marte = new Student(1, "Marte", 1);
            var kai = new Student(2, "Kai", 1);

            var students = new List<Student> {marte, kai};

            var sicco = new Teacher(1, "Sicco", 1, ".NET");

            Class = new Class(1, students, sicco);
        }
    }
}