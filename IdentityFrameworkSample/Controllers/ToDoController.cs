using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityFrameworkSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdentityFrameworkSample.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IdentityDBContext _identityDBContext;
        private string id;
        public ToDoController(IdentityDBContext identityDBContext)
        {
            _identityDBContext = identityDBContext;            
        }
        public IActionResult Index()
        {
            // get the logged in user id
            id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            // get the todo list for the loggedin user
            var todoList = _identityDBContext.Todo.Where(x => x.UserId == id).ToList();
            // send for display
            return View(todoList);
        }
        [HttpGet]
        public IActionResult AddTodo()
        {
            return View(id);
        }

        [HttpPost]
        public IActionResult AddTodo(Todo todoItem)
        {
            todoItem.UserId= User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (ModelState.IsValid)
            {
                _identityDBContext.Todo.Add(todoItem);
                _identityDBContext.SaveChanges();
            }
            return RedirectToAction("Index");            
        }

        public IActionResult DeleteToDo(int id)
        {
            var delTodo = _identityDBContext.Todo.Find(id);
            if (delTodo != null)
            {
                //remove the Todo item from the database
                _identityDBContext.Todo.Remove(delTodo);
                _identityDBContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatus(int id, bool status)
        {
            var updateTodo = _identityDBContext.Todo.Find(id);
            if (updateTodo != null)
            {
                //update the Todo item in the database
                updateTodo.Complete = !status;
                //creates a log of changes for this entry. A way to tracking our work
                _identityDBContext.Entry(updateTodo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _identityDBContext.Update(updateTodo);
                _identityDBContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        //public  IActionResult Cancel()
        //{
        //    //ModelState.Remove("TodoDesc");
        //    //ModelState.Remove("DueDate");
        //    //ModelState.Clear();
            
        //    return RedirectToAction("Index");
        //}
    }
}