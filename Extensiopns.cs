using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppCF
{
   public static class Extensiopns
    {
        public static void Update<T>(this DbSet<T> ts,DbContext t,T @object) where T:class
        {
            t.Entry(@object).State = System.Data.Entity.EntityState.Modified;
            t.SaveChanges();
        }
    }
}
