using JasonsBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JasonsBlog.Repository
{
    public class IRepository
    {
        public MedContext db;

        public IRepository(MedContext db)
        {
            this.db = db;
        }
        
        public int Count()
        {
            return db.Medication.Count();
        }

        public void Create(Medication medication)
        {

        }
    }
}
