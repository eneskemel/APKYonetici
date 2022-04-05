using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;

namespace APKYonetici
{
    public interface IExecuteMethod
    {
        /// <summary>
        /// Execute a command on the remote server.
        /// </summary>
        /// <param name="commandName">A remote command</param>
        /// <param name="parameters">Parameters to execute</param>
        /// <returns>The result</returns>
        Response Execute(string commandName, Dictionary<string, object> parameters);

        /// <summary>
        /// Execute a command on the remote server.
        /// </summary>
        /// <param name="driverCommand">A remote command</param>
        Response Execute(string driverCommand);
    }
}
