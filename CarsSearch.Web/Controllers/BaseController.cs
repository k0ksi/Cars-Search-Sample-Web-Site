namespace CarsSearch.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Routing;
    using CarsSearch.Models;
    using Data.UnitOfWork;

    public abstract class BaseController : Controller
    {
        protected BaseController(ICarsSearchData data)
        {
            this.Data = data;
        }

        protected BaseController(ICarsSearchData data, User userProfile)
            : this(data)
        {
            this.UserProfile = userProfile;
        }

        public User UserProfile { get; set; }

        public ICarsSearchData Data { get; set; }

        public bool IsAdmin()
        {
            var isAdmin = false;
            if (this.UserProfile != null)
            {
                isAdmin = (this.UserProfile.Id != null && this.User.IsInRole("Admin"));
            }

            return isAdmin;
        }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            if (requestContext.HttpContext.User.Identity.IsAuthenticated)
            {
                var username = requestContext.HttpContext.User.Identity.Name;
                var user = this.Data.Users.All()
                    .FirstOrDefault(x => x.UserName == username);
                this.UserProfile = user;
            }
            return base.BeginExecute(requestContext, callback, state);
        }
    }
}