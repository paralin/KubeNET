using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// ContainerStateRunning is a running state of a container.
  /// </summary>
  [DataContract]
  public class V1ContainerStateRunning {
    
    /// <summary>
    /// Time at which the container was last (re-)started
    /// </summary>
    /// <value>Time at which the container was last (re-)started</value>
    [DataMember(Name="startedAt", EmitDefaultValue=false)]
    public string StartedAt { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1ContainerStateRunning {\n");
      
      sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
      
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
