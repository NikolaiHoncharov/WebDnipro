using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDnipro.Models;

namespace WebDnipro.Handlers
{
    public class ServicesContainer
    {
        public  List<Services> services { get; set; }
        public List<OtherServices> otherServices { get; set; }
        public User user { get; set; }
        public Role role { get; set; }
        public UserContext db;

        public ServicesContainer()
        {
            db = new UserContext();
            services = db.Services.ToList();
            otherServices = db.OtherServices.ToList();
            user = db.Users.FirstOrDefault();

        }

        public Services GetDetails(int id)
        {
            return db.Services.FirstOrDefault(s=>id==s.ServicesId);
        }

        public void AddMessageDb(MessageFrmUser messageFrmUser)
        {
            db.MessageFrmUsers.Add(messageFrmUser);
            db.SaveChanges();
        }
    }
}