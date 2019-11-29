using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestTriangle.HOA.Data.Models
{
    public class BaseResponse<T>
    {
        public bool Success { get; set; }
        public IQueryable<T> Data { get; set; }
        public int TotalCount { get; set; }
        public string[] Errors { get; set; }

    }
}
