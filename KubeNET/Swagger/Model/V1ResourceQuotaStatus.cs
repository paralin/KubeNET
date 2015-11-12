using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// ResourceQuotaStatus defines the enforced hard limits and observed use.
  /// </summary>
  [DataContract]
  public class V1ResourceQuotaStatus {
    
    /// <summary>
    /// Hard is the set of enforced hard limits for each named resource. More info: http://releases.k8s.io/HEAD/docs/design/admission_control_resource_quota.md#admissioncontrol-plugin-resourcequota
    /// </summary>
    /// <value>Hard is the set of enforced hard limits for each named resource. More info: http://releases.k8s.io/HEAD/docs/design/admission_control_resource_quota.md#admissioncontrol-plugin-resourcequota</value>
    [DataMember(Name="hard", EmitDefaultValue=false)]
    public Dictionary<string, string> Hard { get; set; }

    
    /// <summary>
    /// Used is the current observed total usage of the resource in the namespace.
    /// </summary>
    /// <value>Used is the current observed total usage of the resource in the namespace.</value>
    [DataMember(Name="used", EmitDefaultValue=false)]
    public Dictionary<string, string> Used { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1ResourceQuotaStatus {\n");
      
      sb.Append("  Hard: ").Append(Hard).Append("\n");
      
      sb.Append("  Used: ").Append(Used).Append("\n");
      
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
