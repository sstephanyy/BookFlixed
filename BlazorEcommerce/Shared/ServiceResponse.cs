using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared
{
    public class ServiceResponse<T> //<T> is a generic type parameter. Can work with different data types without specifying the actual data type until the class or method is used.For example, you can use ServiceResponse<int> to create an instance where T represents integers, or ServiceResponse<string> where T represents strings
    {
        public T? Data { get; set; } // the '?' indicates that can hold a value of type T or it can be null

        public bool Success { get; set; } = true;

        public string Message { get; set; } = string.Empty;
    }
}
