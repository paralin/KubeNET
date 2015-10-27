using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// IngressSpec describes the Ingress the user wishes to exist.
  /// </summary>
  [DataContract]
  public class V1beta1IngressSpec {
    
    /// <summary>
    /// A default backend capable of servicing requests that don't match any rule. At least one of 'backend' or 'rules' must be specified. This field is optional to allow the loadbalancer controller or defaulting logic to specify a global default.
    /// </summary>
    /// <value>A default backend capable of servicing requests that don't match any rule. At least one of 'backend' or 'rules' must be specified. This field is optional to allow the loadbalancer controller or defaulting logic to specify a global default.</value>
    [DataMember(Name="backend", EmitDefaultValue=false)]
    public V1beta1IngressBackend Backend { get; set; }

    
    /// <summary>
    /// A list of host rules used to configure the Ingress. If unspecified, or no rule matches, all traffic is sent to the default backend.
    /// </summary>
    /// <value>A list of host rules used to configure the Ingress. If unspecified, or no rule matches, all traffic is sent to the default backend.</value>
    [DataMember(Name="rules", EmitDefaultValue=false)]
    public List<V1beta1IngressRule> Rules { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1beta1IngressSpec {\n");
      
      sb.Append("  Backend: ").Append(Backend).Append("\n");
      
      sb.Append("  Rules: ").Append(Rules).Append("\n");
      
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
