using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIapplication.Models
{
    public class ReturnDataListModel<T>
    {
        public int ReturnCode { get; set; }
        public bool Success { get; set; }
        public int TotalRecords { get; set; }
        public List<T> Rows { get; set; } = new List<T>();
    }

    public class ReturnDataModel<T>
    {
        public int ReturnCode { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
    }

    public class ResponseModel
    {
        public string Message { get; set; }
        public bool Success { get; set; }
    }

    public class ResponseStatusModel : ResponseModel
    {
        public int ReturnCode { get; set; }
    }
    public class ReturnStatusModel
    {
        public ReturnStatusModel()
        {
        }

        public ReturnStatusModel(bool isSuccess)
        {
            Message = isSuccess ? "Success" : "";
            IsSuccess = isSuccess;
            ReturnCode = isSuccess ? 200 : 500;
        }

        public ReturnStatusModel(string message, bool isSuccess = false, int returnCode = 0)
        {
            Message = message;
            IsSuccess = isSuccess;
            ReturnCode = isSuccess ? 200 : (returnCode > 0) ? returnCode : 500;
        }
        public int ReturnCode { get; set; }

        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
