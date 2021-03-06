﻿using System;using System.IO;
using Microsoft.Azure.WebJobs;

namespace exchange2crm.WebJob
{
    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        public static void ProcessQueueMessage([QueueTrigger("queue")] String message, TextWriter log)
        {
            log.WriteLine(message);
        }
    }
}
