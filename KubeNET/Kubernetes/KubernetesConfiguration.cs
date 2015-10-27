using System;
using KubeNET.Swagger.Client;
using KubeNET.Exceptions;
using System.IO;

namespace KubeNET.Kubernetes
{
	/// <summary>
	/// Configure a API client using Kubernetes pod environment variables
	/// </summary>
	public static class KubernetesConfiguration
	{	
		/// <summary>
		/// Configure the API client, assuming we're running inside a pod
		/// </summary>
		public static void ConfigureWithPodEnvironment()
		{
			if (!File.Exists ("/var/run/secrets/kubernetes.io/serviceaccount/token")) {
				throw new NotKubernetesPodException ();
			}

			var token = File.ReadAllText ("/var/run/secrets/kubernetes.io/serviceaccount/token");
			Configuration.Username = "Bearer";
			Configuration.Password = token;
		}
	}
}