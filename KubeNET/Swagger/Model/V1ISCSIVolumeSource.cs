using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// ISCSIVolumeSource describes an ISCSI Disk can only be mounted as read/write once.
  /// </summary>
  [DataContract]
  public class V1ISCSIVolumeSource {
    
    /// <summary>
    /// iSCSI target portal. The portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).
    /// </summary>
    /// <value>iSCSI target portal. The portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).</value>
    [DataMember(Name="targetPortal", EmitDefaultValue=false)]
    public string TargetPortal { get; set; }

    
    /// <summary>
    /// Target iSCSI Qualified Name.
    /// </summary>
    /// <value>Target iSCSI Qualified Name.</value>
    [DataMember(Name="iqn", EmitDefaultValue=false)]
    public string Iqn { get; set; }

    
    /// <summary>
    /// iSCSI target lun number.
    /// </summary>
    /// <value>iSCSI target lun number.</value>
    [DataMember(Name="lun", EmitDefaultValue=false)]
    public int? Lun { get; set; }

    
    /// <summary>
    /// Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#iscsi
    /// </summary>
    /// <value>Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#iscsi</value>
    [DataMember(Name="fsType", EmitDefaultValue=false)]
    public string FsType { get; set; }

    
    /// <summary>
    /// ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false.
    /// </summary>
    /// <value>ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false.</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    public bool? ReadOnly { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1ISCSIVolumeSource {\n");
      
      sb.Append("  TargetPortal: ").Append(TargetPortal).Append("\n");
      
      sb.Append("  Iqn: ").Append(Iqn).Append("\n");
      
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
