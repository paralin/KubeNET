using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class V1beta1CPUTargetUtilization {
    
    /// <summary>
    /// fraction of the requested CPU that should be utilized/used, e.g. 70 means that 70% of the requested CPU should be in use.
    /// </summary>
    /// <value>fraction of the requested CPU that should be utilized/used, e.g. 70 means that 70% of the requested CPU should be in use.</value>
    [DataMember(Name="targetPercentage", EmitDefaultValue=false)]
    public int? TargetPercentage { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1beta1CPUTargetUtilization {\n");
      
      sb.Append("  TargetPercentage: ").Append(TargetPercentage).Append("\n");
      
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
