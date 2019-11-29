using System;
using System.Collections.Generic;
using System.Text;

namespace TestTriangle.HOA.API.Command.Generic
{
    public class UpdateCommand<T> where T : class
    {
        public T Data { get; set; }
        public int Id { get; set; }
    }
}
