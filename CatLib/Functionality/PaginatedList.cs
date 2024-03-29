﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Functionality
{
    public class PaginatedList<T>:List<T>
    { 
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }

        public bool HasPreviousPage => PageIndex > 1;

        public bool HasNextPage => PageIndex < TotalPages;

        public static PaginatedList<T> Create(IList<T> source, int pageIndex, int pageSize, string type)
        {
            var count = source.Count();
            if (type == "load") {

                var load = (pageIndex) * pageSize;
                var items = source.Take(load).ToList();
                return new PaginatedList<T>(items, count, pageIndex, pageSize);

            }
            else
            {
                var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                return new PaginatedList<T>(items, count, pageIndex, pageSize);

            }
          



        }

    }

}
