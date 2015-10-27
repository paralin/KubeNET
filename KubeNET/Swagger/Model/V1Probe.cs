using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// Probe describes a liveness probe to be examined to the container.
  /// </summary>
  [DataContract]
  public class V1Probe {
    
    /// <summary>
    /// One and only one of the following should be specified. Exec specifies the action to take.
    /// </summary>
    /// <value>One and only one of the following should be specified. Exec specifies the action to take.</value>
    [DataMember(Name="exec", EmitDefaultValue=false)]
    public V1ExecAction Exec { get; set; }

    
    /// <summary>
    /// HTTPGet specifies the http request to perform.
    /// </summary>
    /// <value>HTTPGet specifies the http request to perform.</value>
    [DataMember(Name="httpGet", EmitDefaultValue=false)]
    public V1HTTPGetAction HttpGet { get; set; }

    
    /// <summary>
    /// TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported
    /// </summary>
    /// <value>TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported</value>
    [DataMember(Name="tcpSocket", EmitDefaultValue=false)]
    public V1TCPSocketAction TcpSocket { get; set; }

    
    /// <summary>
    /// Number of seconds after the container has started before liveness probes are initiated. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#container-probes
    /// </summary>
    /// <value>Number of seconds after the container has started before liveness probes are initiated. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#container-probes</value>
    [DataMember(Name="initialDelaySeconds", EmitDefaultValue=false)]
    public int? InitialDelaySeconds { get; set; }

    
    /// <summary>
    /// Number of seconds after which liveness probes timeout. Defaults to 1 second. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#container-probes
    /// </summary>
    /// <value>Number of seconds after which liveness probes timeout. Defaults to 1 second. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#container-probes</value>
    [DataMember(Name="timeoutSeconds", EmitDefaultValue=false)]
    public int? TimeoutSeconds { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1Probe {\n");
      
      sb.Append("  Exec: ").Append(Exec).Append("\n");
      
      sb.Append("  HttpGet: ").Append(HttpGet).Append("\n");
      
      sb.Append("  TcpSocket: ").Append(TcpSocket).Append("\n");
      
      sb.Append("  InitialDelaySeconds: ").Append(InitialDelaySeconds).Append("\n");
      
      sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
      
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
