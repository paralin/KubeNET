using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// A Fibre Channel Disk can only be mounted as read/write once.
  /// </summary>
  [DataContract]
  public class V1FCVolumeSource {
    
    /// <summary>
    /// Required: FC target world wide names (WWNs)
    /// </summary>
    /// <value>Required: FC target world wide names (WWNs)</value>
    [DataMember(Name="targetWWNs", EmitDefaultValue=false)]
    public List<string> TargetWWNs { get; set; }

    
    /// <summary>
    /// Required: FC target lun number
    /// </summary>
    /// <value>Required: FC target lun number</value>
    [DataMember(Name="lun", EmitDefaultValue=false)]
    public int? Lun { get; set; }

    
    /// <summary>
    /// Required: Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\"
    /// </summary>
    /// <value>Required: Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\"</value>
    [DataMember(Name="fsType", EmitDefaultValue=false)]
    public string FsType { get; set; }

    
    /// <summary>
    /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
    /// </summary>
    /// <value>Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    public bool? ReadOnly { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1FCVolumeSource {\n");
      
      sb.Append("  TargetWWNs: ").Append(TargetWWNs).Append("\n");
      
      sb.Append("  Lun: ").Append(Lun).Append("\n");
      
      sb.Append("  FsType: ").Append(FsType).Append("\n");
      
      sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
      
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
