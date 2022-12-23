using NLayer.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.Wrappers
{
    public class Response<T>
    {
        public T Data { get; set; }

        public int StatusCode { get; set; }


        public List<string> Errors { get; set; }

        public static Response<T> Success(int statusCode, T data)
        {
            return new Response<T> { Data = data, StatusCode = statusCode };
        }
        public static Response<T> Success(int statusCode)
        {
            return new Response<T> { StatusCode = statusCode };
        }

        public static Response<T> Fail(int statusCode, List<string> errors)
        {
            return new Response<T> { StatusCode = statusCode, Errors = errors };
        }

        public static Response<T> Fail(int statusCode, string error)
        {
            return new Response<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }
    }
}
