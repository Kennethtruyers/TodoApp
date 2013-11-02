using TodoApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebMatrix.WebData;

namespace TodoApp.Code
{
    public class Db
    {

        private TodoItemContext db;
        public Db()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetFullPath(@"..\..\..\TodoApp\App_Data"));
           db = new TodoItemContext();
        }
        public void DeleteAll()
        {
            var objCtx = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)db).ObjectContext;
            objCtx.ExecuteStoreCommand("DELETE FROM TodoItems");
            objCtx.ExecuteStoreCommand("DELETE FROM UserProfile");
            objCtx.ExecuteStoreCommand("DELETE FROM TodoLists");
            objCtx.ExecuteStoreCommand("DELETE FROM webpages_Membership");
            objCtx.ExecuteStoreCommand("DELETE FROM webpages_OAuthMembership");
            objCtx.ExecuteStoreCommand("DELETE FROM webpages_Roles");
            objCtx.ExecuteStoreCommand("DELETE FROM webpages_UsersInRoles");
            db.SaveChanges();
        }
    }
}