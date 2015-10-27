using System;

namespace KubeNET.Exceptions
{
	/// <summary>
	/// Thrown when we're not inside a Kubernetes pod, but expect to be
	/// </summary>
	public class NotKubernetesPodException : Exception
	{
		public NotKubernetesPodException ()
		{
		}
	}
}

