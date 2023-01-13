using CatLib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Functionality
{
    public class FiltrationList
    {

        private readonly CatLibContext _context;
        private List<Cat> cats = new List<Cat>();
        public FiltrationList(CatLibContext context)
        {
            _context = context;
        }


        public List<Cat> Filtration(string activity, string size, string playfulness, string coat)
        {
            cats = _context.Cats.ToList();
            if (!String.IsNullOrEmpty(activity))
            {
                var act = System.Convert.ToInt32(activity);

                if (act >= 70)
                {
                    cats = cats.FindAll(a => System.Convert.ToInt32(a.Activity) >= act).ToList();
                }

                if (act <= 30)
                {
                    cats = cats.FindAll(a => System.Convert.ToInt32(a.Activity) <= act).ToList();
                }

                if (act >= 40 && act <= 60)
                {
                    cats = cats.FindAll(a => System.Convert.ToInt32(a.Activity) >= 40 && 60<= System.Convert.ToInt32(a.Activity)).ToList();
                }

            }

            if (!String.IsNullOrEmpty(size))
            {
                cats = cats.Where(a => a.Size.Contains(size)).ToList();
            }

            if (!String.IsNullOrEmpty(playfulness))
            {
                cats = cats.Where(a => a.Playfulness.Contains(playfulness)).ToList();
            }
            if (!String.IsNullOrEmpty(coat))
            {
                cats = cats.Where(a => a.Coat.Contains(coat)).ToList();
            }

            //cats = _context.Cats.Include(f => f.FilterSpecification).Where(s => res.Contains(s.FilterSpecification)).ToList();

            return cats;
        }
    }
}
