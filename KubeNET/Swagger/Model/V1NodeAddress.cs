using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// NodeAddress contains information for the node&#39;s address.
  /// </summary>
  [DataContract]
  public class V1NodeAddress {
    
    /// <summary>
    /// Node address type, one of Hostname, ExternalIP or InternalIP.
    /// </summary>
    /// <value>Node address type, one of Hostname, ExternalIP or InternalIP.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    /// <summary>
    /// The node address.
    /// </summary>
    /// <value>The node address.</value>
    [DataMember(Name="address", EmitDefaultValue=false)]
    public string Address { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1NodeAddress {\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Address: ").Append(Address).Append("\n");
      
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
