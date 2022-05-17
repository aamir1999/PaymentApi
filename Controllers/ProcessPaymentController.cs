using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Configuration;
using System.Net.Http.Headers;
using LINQtoCSV;
using System.Threading;
using Microsoft.AspNetCore.SignalR.Protocol;
using System.Text;
using System.IO;
using System.Security.Permissions;
using System.Security;
using CsvHelper;
using System.Globalization;
using System.Diagnostics;

namespace Payment.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessPaymentController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(ProcessPaymentController));
         

        [HttpGet]
        public int ProcessPayment(string creditNo,int creditlimit,int totalcharge) {
            int balanceamt = 0;
            if (creditlimit >= totalcharge)
            {
                balanceamt = creditlimit - totalcharge;
            }
            else {
                balanceamt = -1;
            }
            return balanceamt;
        }

        
    }
}




/*
       [HttpPost]
       public dynamic ProcessPayment(CardDetails det)
       {

           _log4net.Info("Payment initiated");
           var payment = _context.ProcessPayment(det);
           return Ok(payment);

       }
       */
