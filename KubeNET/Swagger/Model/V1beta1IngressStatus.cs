using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// IngressStatus describe the current state of the Ingress.
  /// </summary>
  [DataContract]
  public class V1beta1IngressStatus {
    
    /// <summary>
    /// LoadBalancer contains the current status of the load-balancer.
    /// </summary>
    /// <value>LoadBalancer contains the current status of the load-balancer.</value>
    [DataMember(Name="loadBalancer", EmitDefaultValue=false)]
    public V1LoadBalancerStatus LoadBalancer { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1beta1IngressStatus {\n");
      
      sb.Append("  LoadBalancer: ").Append(LoadBalancer).Append("\n");
      
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
