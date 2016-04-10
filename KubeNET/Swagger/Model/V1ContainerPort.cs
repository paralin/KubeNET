using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// ContainerPort represents a network port in a single container.
  /// </summary>
  [DataContract]
  public class V1ContainerPort {
    
    /// <summary>
    /// If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services.
    /// </summary>
    /// <value>If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Number of port to expose on the host. If specified, this must be a valid port number, 0 lt x lt 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this.
    /// </summary>
    /// <value>Number of port to expose on the host. If specified, this must be a valid port number, 0 lt x lt 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this.</value>
    [DataMember(Name="hostPort", EmitDefaultValue=false)]
    public int? HostPort { get; set; }

    
    /// <summary>
    /// Number of port to expose on the pod's IP address. This must be a valid port number, 0 lt x lt 65536.
    /// </summary>
    /// <value>Number of port to expose on the pod's IP address. This must be a valid port number, 0 lt x lt 65536.</value>
    [DataMember(Name="containerPort", EmitDefaultValue=false)]
    public int? ContainerPort { get; set; }

    
    /// <summary>
    /// Protocol for port. Must be UDP or TCP. Defaults to \"TCP\".
    /// </summary>
    /// <value>Protocol for port. Must be UDP or TCP. Defaults to \"TCP\".</value>
    [DataMember(Name="protocol", EmitDefaultValue=false)]
    public string Protocol { get; set; }

    
    /// <summary>
    /// What host IP to bind the external port to.
    /// </summary>
    /// <value>What host IP to bind the external port to.</value>
    [DataMember(Name="hostIP", EmitDefaultValue=false)]
    public string HostIP { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1ContainerPort {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  HostPort: ").Append(HostPort).Append("\n");
      
      sb.Append("  ContainerPort: ").Append(ContainerPort).Append("\n");
      
      sb.Append("  Protocol: ").Append(Protocol).Append("\n");
      
      sb.Append("  HostIP: ").Append(HostIP).Append("\n");
      
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
