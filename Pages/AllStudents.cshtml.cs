using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using net_on_the_web.Models;

namespace net_on_the_web.Pages
{
    public class AllStudentsModel : PageModel
    {
        public List<Student> Students;
        
        public void OnGet()
        {
            var id = 1;
            
            var marte = new Student(id++, "Marte", 1);
            var kai = new Student(id++, "Kai", 1);
            var paul = new Student(id++, "Paul", 1);
            var micha = new Student(id++, "Micha", 1);
            var peter = new Student(id++, "Peter", 1);

            Students = new List<Student> {marte, kai, paul, micha, peter};
        }
    }
}
