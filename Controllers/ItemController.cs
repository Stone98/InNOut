using InNOut.Data;
using InNOut.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InNOut.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }
        /// <summary>
        /// Gets all of the borrowed items
        /// </summary>
        /// <returns>Index view</returns>
        [HttpGet("Index")]
        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }
        /// <summary>
        /// Get Create View
        /// </summary>
        /// <returns>View</returns>
        //GET-Create
        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }
        //POST-Create
        /// <summary>
        /// Creates the new item
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Index view</returns>
        [HttpPost("Create")]
        //[ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] Item obj)
        {
            _db.Items.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
