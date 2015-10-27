using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// LoadBalancerIngress represents the status of a load-balancer ingress point: traffic intended for the service should be sent to an ingress point.
  /// </summary>
  [DataContract]
  public class V1LoadBalancerIngress {
    
    /// <summary>
    /// IP is set for load-balancer ingress points that are IP based (typically GCE or OpenStack load-balancers)
    /// </summary>
    /// <value>IP is set for load-balancer ingress points that are IP based (typically GCE or OpenStack load-balancers)</value>
    [DataMember(Name="ip", EmitDefaultValue=false)]
    public string Ip { get; set; }

    
    /// <summary>
    /// Hostname is set for load-balancer ingress points that are DNS based (typically AWS load-balancers)
    /// </summary>
    /// <value>Hostname is set for load-balancer ingress points that are DNS based (typically AWS load-balancers)</value>
    [DataMember(Name="hostname", EmitDefaultValue=false)]
    public string Hostname { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1LoadBalancerIngress {\n");
      
      sb.Append("  Ip: ").Append(Ip).Append("\n");
      
      sb.Append("  Hostname: ").Append(Hostname).Append("\n");
      
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
