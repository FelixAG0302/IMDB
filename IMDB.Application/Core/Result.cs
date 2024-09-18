using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Core
{
    public class Result
    {
        public Result(string message, bool isSuccess = true)
        {
            IsSuccess = isSuccess;
            Message = message;
        }

        public Result()
        {
            ErrorType = null;
            IsSuccess = true;
        }

        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public string ErrorType { get; set; }
    }

        public class Result<TData> 
            where TData : class
        {
            public Result()
            {
                ErrorType = null;
                IsSuccess = true;
            }

            public Result (string message, bool isSuccess = true)
            {
                IsSuccess = isSuccess;
                Message = message;
                Data = default;
            }

            public Result (string message, TData? data, bool isSuccess = true)
            {
                Message = message;
                IsSuccess = true;
                Data = data;
            }

            public Result (string message, TData? data)
            {
                Message = message;
                IsSuccess = true;
                Data = data;
            }


            public bool IsSuccess { get; set; }
            public string ErrorType { get; set; }
            public string Message { get; set; }
            public TData? Data { get; set; }

            public static implicit operator Result<TData>(Result result) => new(result.Message, result.IsSuccess)
            {
                ErrorType = result.ErrorType
            };

            public static implicit operator Result<TData>(TData data) => new("Operator completed was succesful!", data);

        }
    }
