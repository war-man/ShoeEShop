﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogApi.ViewModels
{
    public class PaginatedItemsViewModel<TEntity> where TEntity : class
    {
        public int PageSize { get; private set; }
        public int PageIndex { get; private set; }
        public long Count { get; private set; }
        public IEnumerable<TEntity> Data { get; set; }
        public PaginatedItemsViewModel(int pageSize, int pageIndex, long count, IEnumerable<TEntity> data)
        {
            PageSize = pageSize;
            PageIndex = PageIndex;
            Count = count;
            Data = data;
        }
    }
}
