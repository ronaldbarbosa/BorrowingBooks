using BorrowingBooks.Data;
using BorrowingBooks.Models;
using Microsoft.AspNetCore.Mvc;

namespace BorrowingBooks.Controllers
{
    public class BorrowController : Controller
    {
        readonly private ApplicationDbContext _db;
        public BorrowController(ApplicationDbContext db) 
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<BorrowModel> borrowList = _db.Borrowings;
            return View(borrowList);
        }
    }
}
