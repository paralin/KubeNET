using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// ResourceQuotaSpec defines the desired hard limits to enforce for Quota.
  /// </summary>
  [DataContract]
  public class V1ResourceQuotaSpec {
    
    /// <summary>
    /// Hard is the set of desired hard limits for each named resource. More info: http://releases.k8s.io/HEAD/docs/design/admission_control_resource_quota.md#admissioncontrol-plugin-resourcequota
    /// </summary>
    /// <value>Hard is the set of desired hard limits for each named resource. More info: http://releases.k8s.io/HEAD/docs/design/admission_control_resource_quota.md#admissioncontrol-plugin-resourcequota</value>
    [DataMember(Name="hard", EmitDefaultValue=false)]
    public Dictionary<string, string> Hard { get; set; }

    
    /// <summary>
    /// A collection of filters that must match each object tracked by a quota. If not specified, the quota matches all objects.
    /// </summary>
    /// <value>A collection of filters that must match each object tracked by a quota. If not specified, the quota matches all objects.</value>
    [DataMember(Name="scopes", EmitDefaultValue=false)]
    public List<V1ResourceQuotaScope> Scopes { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1ResourceQuotaSpec {\n");
      
      sb.Append("  Hard: ").Append(Hard).Append("\n");
      
      sb.Append("  Scopes: ").Append(Scopes).Append("\n");
      
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
