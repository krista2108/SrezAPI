using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using LoginAPi.Entities;
using LoginAPi.Models;

namespace LoginAPi.Controllers
{
    public class AccountsController : ApiController
    {
        private ApiSrezDBEntities2 db = new ApiSrezDBEntities2();

        // GET: api/Accounts
        public IHttpActionResult GetAccount()
        {
            List<Account> account = db.Account.ToList();
            List<ResponseAccounts> list = new List<ResponseAccounts>();

            foreach (Account acc in account)
            {
                list.Add(new ResponseAccounts(acc));
            }
            return Json(list);
        }

        // GET: api/Accounts?Email=superilya@yandex.ru&Password=da
        public IHttpActionResult GetLogin(string Email, string Password)
        {
            Account account = db.Account.SingleOrDefault(x => x.Emaill == Email && x.Password == Password);

            if(account == null)
            {
                return NotFound();
            }
            return Ok(account);
        }

        // GET: api/Accounts?Email=superilya@yandex.ru
        public IHttpActionResult GetUser(string Email)
        {
            Account account = db.Account.SingleOrDefault(x => x.Emaill == Email);

            if (account == null)
            {
                return NotFound();
            }
            return Ok(account);
        }

        // GET: api/Accounts/5
        [ResponseType(typeof(Account))]
        public IHttpActionResult GetAccount(int id)
        {
            Account account = db.Account.Find(id);
            if (account == null)
            {
                return NotFound();
            }
            return Json(new ResponseAccounts(account));
        }
        // POST: api/Accounts
        [ResponseType(typeof(Account))]
        public IHttpActionResult PostAccount(Account account)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Account.Add(account);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = account.UserID }, account);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AccountExists(int id)
        {
            return db.Account.Count(e => e.UserID == id) > 0;
        }
    }
}