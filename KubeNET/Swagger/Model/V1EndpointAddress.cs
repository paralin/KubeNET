using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// EndpointAddress is a tuple that describes single IP address.
  /// </summary>
  [DataContract]
  public class V1EndpointAddress {
    
    /// <summary>
    /// The IP of this endpoint. May not be loopback (127.0.0.0/8), link-local (169.254.0.0/16), or link-local multicast ((224.0.0.0/24).
    /// </summary>
    /// <value>The IP of this endpoint. May not be loopback (127.0.0.0/8), link-local (169.254.0.0/16), or link-local multicast ((224.0.0.0/24).</value>
    [DataMember(Name="ip", EmitDefaultValue=false)]
    public string Ip { get; set; }

    
    /// <summary>
    /// Reference to object providing the endpoint.
    /// </summary>
    /// <value>Reference to object providing the endpoint.</value>
    [DataMember(Name="targetRef", EmitDefaultValue=false)]
    public V1ObjectReference TargetRef { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1EndpointAddress {\n");
      
      sb.Append("  Ip: ").Append(Ip).Append("\n");
      
      sb.Append("  TargetRef: ").Append(TargetRef).Append("\n");
      
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
