using System.Data.Entity;
using System.Runtime.Remoting.Messaging;

namespace Group_Lib2.Models
{
    public static class DbContextFactory
    {
        public static DbContext Create()
        {
            DbContext dbContext = (DbContext)CallContext.GetData("dbContext");
            if (dbContext == null)
            {
                dbContext = new BookManagerSystemEntities();
                CallContext.SetData("dbContext", dbContext);
            }
            return dbContext;
        }
    }
}