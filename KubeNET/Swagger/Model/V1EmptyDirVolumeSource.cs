using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// Represents an empty directory for a pod. Empty directory volumes support ownership management and SELinux relabeling.
  /// </summary>
  [DataContract]
  public class V1EmptyDirVolumeSource {
    
    /// <summary>
    /// What type of storage medium should back this directory. The default is \"\" which means to use the node's default medium. Must be an empty string (default) or Memory. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#emptydir
    /// </summary>
    /// <value>What type of storage medium should back this directory. The default is \"\" which means to use the node's default medium. Must be an empty string (default) or Memory. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#emptydir</value>
    [DataMember(Name="medium", EmitDefaultValue=false)]
    public string Medium { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1EmptyDirVolumeSource {\n");
      
      sb.Append("  Medium: ").Append(Medium).Append("\n");
      
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
