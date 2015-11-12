using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// ResourceRequirements describes the compute resource requirements.
  /// </summary>
  [DataContract]
  public class V1ResourceRequirements {
    
    /// <summary>
    /// Limits describes the maximum amount of compute resources allowed. More info: http://releases.k8s.io/HEAD/docs/design/resources.md#resource-specifications
    /// </summary>
    /// <value>Limits describes the maximum amount of compute resources allowed. More info: http://releases.k8s.io/HEAD/docs/design/resources.md#resource-specifications</value>
    [DataMember(Name="limits", EmitDefaultValue=false)]
    public Dictionary<string, string> Limits { get; set; }

    
    /// <summary>
    /// Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: http://releases.k8s.io/HEAD/docs/design/resources.md#resource-specifications
    /// </summary>
    /// <value>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: http://releases.k8s.io/HEAD/docs/design/resources.md#resource-specifications</value>
    [DataMember(Name="requests", EmitDefaultValue=false)]
    public Dictionary<string, string> Requests { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1ResourceRequirements {\n");
      
      sb.Append("  Limits: ").Append(Limits).Append("\n");
      
      sb.Append("  Requests: ").Append(Requests).Append("\n");
      
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
