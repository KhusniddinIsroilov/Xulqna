﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xulqna.Domain.Configuration
{
    public class PaginationMetaData
    {
        public PaginationMetaData(int totalCount, PaginationParams @params)
        {
            CurrentPage = @params.PageIndex;
            TotalCount = totalCount;
            TolalPages = (int)Math.Ceiling(totalCount/(double)@params.PageSize);
        }


        public int CurrentPage { get; private  set; }
        public int TotalCount { get; private set; }
        public int TolalPages { get; private set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TolalPages;
    }
}
