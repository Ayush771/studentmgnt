using System.Linq;
using Microsoft.AspNetCore.Mvc;
using studentmgmt.Data;
using Studentmgmt.Models;

namespace StudentMgmt.Controllers{
    public class StudentController:Controller{
        private ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context){
            _context =context;
        }
        public IActionResult Index(){
              var students = _context.Students.ToList();
            return View(students);
        
        }
        public IActionResult detail(){
            return View();       
             }
             public IActionResult New()
             {
                 return View();
             }
        public IActionResult Category(){
            return View();
        }
        
        public IActionResult Employee(){
            return View();
}
        [HttpPost]
        public IActionResult New(Student student){
            if(!ModelState.IsValid)
                return View(student);    
        
            _context.Students.Add(student);
            _context.SaveChanges();
            
            return RedirectToAction("Index");

        }  
    }
}
