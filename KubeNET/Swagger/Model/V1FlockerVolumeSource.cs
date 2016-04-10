using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// Represents a Flocker volume mounted by the Flocker agent. Flocker volumes do not support ownership management or SELinux relabeling.
  /// </summary>
  [DataContract]
  public class V1FlockerVolumeSource {
    
    /// <summary>
    /// Required: the volume name. This is going to be store on metadata -> name on the payload for Flocker
    /// </summary>
    /// <value>Required: the volume name. This is going to be store on metadata -> name on the payload for Flocker</value>
    [DataMember(Name="datasetName", EmitDefaultValue=false)]
    public string DatasetName { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1FlockerVolumeSource {\n");
      
      sb.Append("  DatasetName: ").Append(DatasetName).Append("\n");
      
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
