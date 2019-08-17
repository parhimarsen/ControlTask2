using System;
using ControlTask2.Models;

namespace ControlTask2.Interfaces
{
    public interface IQueriesManager : IDisposable
    {
        void CreateQuery(ApplicationQuery query);
    }
}
