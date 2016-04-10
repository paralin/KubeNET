using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// HTTPGetAction describes an action based on HTTP Get requests.
  /// </summary>
  [DataContract]
  public class V1HTTPGetAction {
    
    /// <summary>
    /// Path to access on the HTTP server.
    /// </summary>
    /// <value>Path to access on the HTTP server.</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    public string Path { get; set; }

    
    /// <summary>
    /// Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
    /// </summary>
    /// <value>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</value>
    [DataMember(Name="port", EmitDefaultValue=false)]
    public string Port { get; set; }

    
    /// <summary>
    /// Host name to connect to, defaults to the pod IP. You probably want to set \"Host\" in httpHeaders instead.
    /// </summary>
    /// <value>Host name to connect to, defaults to the pod IP. You probably want to set \"Host\" in httpHeaders instead.</value>
    [DataMember(Name="host", EmitDefaultValue=false)]
    public string Host { get; set; }

    
    /// <summary>
    /// Scheme to use for connecting to the host. Defaults to HTTP.
    /// </summary>
    /// <value>Scheme to use for connecting to the host. Defaults to HTTP.</value>
    [DataMember(Name="scheme", EmitDefaultValue=false)]
    public string Scheme { get; set; }

    
    /// <summary>
    /// Custom headers to set in the request. HTTP allows repeated headers.
    /// </summary>
    /// <value>Custom headers to set in the request. HTTP allows repeated headers.</value>
    [DataMember(Name="httpHeaders", EmitDefaultValue=false)]
    public List<V1HTTPHeader> HttpHeaders { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1HTTPGetAction {\n");
      
      sb.Append("  Path: ").Append(Path).Append("\n");
      
      sb.Append("  Port: ").Append(Port).Append("\n");
      
      sb.Append("  Host: ").Append(Host).Append("\n");
      
      sb.Append("  Scheme: ").Append(Scheme).Append("\n");
      
      sb.Append("  HttpHeaders: ").Append(HttpHeaders).Append("\n");
      
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
