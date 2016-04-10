using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// Represents a host path mapped into a pod. Host path volumes do not support ownership management or SELinux relabeling.
  /// </summary>
  [DataContract]
  public class V1HostPathVolumeSource {
    
    /// <summary>
    /// Path of the directory on the host. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#hostpath
    /// </summary>
    /// <value>Path of the directory on the host. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#hostpath</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    public string Path { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1HostPathVolumeSource {\n");
      
      sb.Append("  Path: ").Append(Path).Append("\n");
      
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
