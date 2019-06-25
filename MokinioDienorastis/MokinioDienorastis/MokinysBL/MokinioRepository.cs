using System;
using System.Collections.Generic;
using System.Text;
using MokinysBL;

namespace MokinysBL
{
   public  class MokinioRepository
    {
        
        private List<Mokinys> mokiniai = new List<Mokinys>();

        public MokinioRepository()
        {
            mokiniai.Add(new Mokinys(1, "Dalia", false));
            mokiniai.Add(new Mokinys(2, "Rūta", false));
            mokiniai.Add(new Mokinys(3, "Marius", false));
            mokiniai.Add(new Mokinys(4, "Mindaugas", false));
            mokiniai.Add(new Mokinys(5, "Mangirdas", true));
        }

        public List<Mokinys> Retrieve()
        {
            return mokiniai;
        }

        public Mokinys Retrieve (int id)
        {
            foreach (var mokinys in mokiniai)
            {
                if (mokinys.Id == id)
                {
                    return mokinys;
                }
            }
            return null;
        }

    }
   
}


