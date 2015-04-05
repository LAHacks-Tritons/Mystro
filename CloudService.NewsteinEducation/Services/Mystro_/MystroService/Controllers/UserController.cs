using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using MystroService.DataObjects;
using MystroService.Models;
namespace MystroService.Controllers
{
    public class UserController : TableController<User>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MystroContext context = new MystroContext();
            DomainManager = new EntityDomainManager<User>(context, Request, Services);
        }

        public UserController() { }

        public UserController(HttpControllerContext con, ApiServices svc)
        {
            base.Initialize(con);
            MystroContext context = new MystroContext();
            DomainManager = new EntityDomainManager<User>(context, Request, svc);
        }

        public IQueryable<User> GetAllUsers()
        {
            return Query();
        }

        public SingleResult<User> GetUser(string id)
        {
            return Lookup(id);
        }

        public Task<User> PatchUser(string id, Delta<User> patch)
        {
            return UpdateAsync(id, patch);
        }

        public async Task<IHttpActionResult> PostUser(User item)
        {
            User current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        public Task DeleteUser(string id)
        {
            return DeleteAsync(id);
        }
    }
}
