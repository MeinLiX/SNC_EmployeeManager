using SNC_WCFService.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace SNC_WCFService.Services
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        Response<IEnumerable<EmployeeModel>> GetEmpoyes();

        [OperationContract]
        Response<string> AddEmpoyee(EmployeeModel employee);

        [OperationContract]
        Response<string> UpdateEmpoyee(EmployeeModel employee);

        [OperationContract]
        Response<string> DeleteEmpoyee(Guid id);
    }

    [DataContract]
    public class Response<T>
    {
        [DataMember]
        public T Data { get; private set; } = default;

        [DataMember]
        public bool Success { get; private set; } = true;

        [DataMember]
        public Exception Exception { get; private set; } = null;

        public Response(Exception exception) {
            Exception = exception;
            Success = false;
        }

        public Response(T data)
        {
            Data = data;
        }
    }
}
