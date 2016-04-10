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
  public class V1beta1RollbackConfig {
    
    /// <summary>
    /// The revision to rollback to. If set to 0, rollbck to the last revision.
    /// </summary>
    /// <value>The revision to rollback to. If set to 0, rollbck to the last revision.</value>
    [DataMember(Name="revision", EmitDefaultValue=false)]
    public int? Revision { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1beta1RollbackConfig {\n");
      
      sb.Append("  Revision: ").Append(Revision).Append("\n");
      
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
