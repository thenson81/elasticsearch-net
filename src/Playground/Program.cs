﻿using System;
using System.Threading.Tasks;
using Elastic.Transport;
using Nest;

namespace Playground
{
	internal class Program
    {
	    private static async Task Main(string[] args)
	    {
		    var client = new ElasticClient(new Uri("http://localhost:9600"));

		    var request = new ClusterHealthRequest("test")
		    {
			    Level = Level.Cluster
		    };

		    var response = await client.Cluster.HealthAsync(request);

		    if (response.IsValid)
		    {
			    Console.WriteLine(response.ClusterName);
			    Console.WriteLine(response.ActivePrimaryShards);
			}
	    }
    }
}
