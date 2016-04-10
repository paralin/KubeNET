using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// VolumeMount describes a mounting of a Volume within a container.
  /// </summary>
  [DataContract]
  public class V1VolumeMount {
    
    /// <summary>
    /// This must match the Name of a Volume.
    /// </summary>
    /// <value>This must match the Name of a Volume.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false.
    /// </summary>
    /// <value>Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false.</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    public bool? ReadOnly { get; set; }

    
    /// <summary>
    /// Path within the container at which the volume should be mounted.  Must not contain ':'.
    /// </summary>
    /// <value>Path within the container at which the volume should be mounted.  Must not contain ':'.</value>
    [DataMember(Name="mountPath", EmitDefaultValue=false)]
    public string MountPath { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1VolumeMount {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
      
      sb.Append("  MountPath: ").Append(MountPath).Append("\n");
      
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
