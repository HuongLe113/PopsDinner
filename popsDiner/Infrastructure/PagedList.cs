using System.Collections.Generic;
using System;

namespace popsDiner.Infrastructure
{
    public class PagedList<T>:List<T>
    {
        public PagedList(IEnumerable<T> items,int count,int pagesize,int pageindex)
        {
            this.AddRange(items);
            Pageindex=pageindex;
            totalpage=(int)Math.Ceiling(count/(double)pagesize);
        }
        public int Pageindex{get;}
        public int totalpage{get;}
        public bool Hasprev{get =>Pageindex>1;}
        public bool Hasnext{get =>Pageindex<totalpage;}
    }
}