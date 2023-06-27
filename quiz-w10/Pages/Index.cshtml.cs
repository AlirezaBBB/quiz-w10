using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using quiz_w10.Repository;

namespace quiz_w10.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IUserRepository _user;

        public IndexModel(IUserRepository user)
        {
            _user = user;
        }

        public void OnGet()
        {

        }
    }
}