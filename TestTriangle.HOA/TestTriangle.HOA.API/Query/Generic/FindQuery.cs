using System;
using System.Collections.Generic;
using System.Text;

namespace TestTriangle.HOA.API.Query.Generic
{
    public class FindQuery<T> where T : class
    {
        public int Id { get; set; }
    }
}
