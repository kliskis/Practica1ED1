using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ClassRoom _classRoom = new ClassRoom(); 
        // GET: StudentController
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Index()
        {
            return Ok(_classRoom.Students);
        }
        // GET: StudentController/Id
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("/student/{id}")]
        public ActionResult Get(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return Ok(_classRoom.Students.FirstOrDefault(x => x.StudentId.Equals(id)));
            }
            else
            {
                return Ok(_classRoom.Students);
            }
        }


        // GET: StudentController/
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult Index(Student student)
        {
            _classRoom.Students.Add(student);
            return Created("Student",  student.GetInfo());
        }

        // POST: StudentController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: StudentController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: StudentController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: StudentController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: StudentController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
