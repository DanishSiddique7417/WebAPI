using System;
using System.Text.Json;
using Azure.Storage.Queues;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace MyFunction2_Azure
{
    public class Function_TImer
    {
        //[FunctionName("Function_TImer")]
        //public void Run([TimerTrigger("5,8,10 * * * * *")]TimerInfo myTimer, ILogger log)
        //{
            
           
        //    Console.WriteLine($"C# Timer trigger function executed at: {DateTime.Now}");
        //    var connectionString = "DefaultEndpointsProtocol=https;AccountName=learningqueuestorage;AccountKey=yaOw85i+gvP6+V+Vx4MogHkoZbYrSO4zpFCIoEeaaKflATo0pJ1Vd/sB3gDTXvboa4id2zxG+q8l+AStuEaOBw==;EndpointSuffix=core.windows.net";
        //    var queuename = "learningqueue";
        //    var Queclint = new QueueClient(connectionString, queuename);
        //    var message = $"Message added in the queue at {DateTime.Now}";
        //    var serializemessage = JsonSerializer.Serialize(message);
        //    Queclint.SendMessageAsync(serializemessage);
        //}
    }
}
