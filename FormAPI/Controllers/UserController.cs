using Microsoft.AspNetCore.Mvc;
using FormAPI.Model;
using FormAPI.Data;

namespace FormAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly dataUser _context;

        public UserController(dataUser context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult PostForm([FromBody] User data)
        {
            var user = new User
            {
                firstName = data.firstName,
                lastName = data.lastName,
                number = data.number,
                email = data.email,
                gender= data.gender,
                date= data.date,

            };
            _context.Table_MyForm.Add(user);     
            _context.SaveChanges();
            return Ok(new { user });

            return RedirectToAction("ShowForm", new { email = user.email });
        }
        [HttpGet]
        public IActionResult GetUserByEmail(string email)
        {
            var user = _context.Table_MyForm.FirstOrDefault(u => u.email == email);
            if (user == null)
                return NotFound(); 
            return Ok(user);
        }
    }
}