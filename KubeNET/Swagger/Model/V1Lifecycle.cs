using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// Lifecycle describes actions that the management system should take in response to container lifecycle events. For the PostStart and PreStop lifecycle handlers, management of the container blocks until the action is complete, unless the container process fails, in which case the handler is aborted.
  /// </summary>
  [DataContract]
  public class V1Lifecycle {
    
    /// <summary>
    /// PostStart is called immediately after a container is created. If the handler fails, the container is terminated and restarted according to its restart policy. Other management of the container blocks until the hook completes. More info: http://releases.k8s.io/HEAD/docs/user-guide/container-environment.md#hook-details
    /// </summary>
    /// <value>PostStart is called immediately after a container is created. If the handler fails, the container is terminated and restarted according to its restart policy. Other management of the container blocks until the hook completes. More info: http://releases.k8s.io/HEAD/docs/user-guide/container-environment.md#hook-details</value>
    [DataMember(Name="postStart", EmitDefaultValue=false)]
    public V1Handler PostStart { get; set; }

    
    /// <summary>
    /// PreStop is called immediately before a container is terminated. The container is terminated after the handler completes. The reason for termination is passed to the handler. Regardless of the outcome of the handler, the container is eventually terminated. Other management of the container blocks until the hook completes. More info: http://releases.k8s.io/HEAD/docs/user-guide/container-environment.md#hook-details
    /// </summary>
    /// <value>PreStop is called immediately before a container is terminated. The container is terminated after the handler completes. The reason for termination is passed to the handler. Regardless of the outcome of the handler, the container is eventually terminated. Other management of the container blocks until the hook completes. More info: http://releases.k8s.io/HEAD/docs/user-guide/container-environment.md#hook-details</value>
    [DataMember(Name="preStop", EmitDefaultValue=false)]
    public V1Handler PreStop { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1Lifecycle {\n");
      
      sb.Append("  PostStart: ").Append(PostStart).Append("\n");
      
      sb.Append("  PreStop: ").Append(PreStop).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
