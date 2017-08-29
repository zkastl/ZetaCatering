using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZetaCatering.Model;

namespace ZetaCatering.Controllers
{
    [Produces("application/json")]
    [Route("api/Login")]
    public class LoginController : Controller
    {
        private EventPlanner currentUser = new EventPlanner();
        [HttpPost]
        public HttpResponse AuthenticateUser(EventPlanner user)
        {            
            try
            {
                Authenticate(user.Username, user.Password);
            }
            catch(Exception e)
            {
                return null;
            }

            return null;
        }

        private void Authenticate(string username, string password)
        {
            currentUser = new EventPlanner();
        }

        private string issueToken(string username)
        {
            return string.Empty;
        }
    }
}