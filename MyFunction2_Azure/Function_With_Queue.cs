using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace MyFunction2_Azure
{
    public class Function_With_Queue
    {
        [FunctionName("Function_With_Queue")]
        public void Run([QueueTrigger("learningqueue", Connection = "DefaultEndpointsProtocol=https;AccountName=learningqueuestorage;AccountKey=yaOw85i+gvP6+V+Vx4MogHkoZbYrSO4zpFCIoEeaaKflATo0pJ1Vd:sB3gDTXvboa4id2zxG+q8l+AStuEaOBw==;EndpointSuffix=core.windows.net")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {DateTime.Now}");
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
