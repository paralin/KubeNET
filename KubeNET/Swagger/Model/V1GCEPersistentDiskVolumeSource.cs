using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// GCEPersistentDiskVolumeSource represents a Persistent Disk resource in Google Compute Engine.\n\nA GCE PD must exist and be formatted before mounting to a container. The disk must also be in the same GCE project and zone as the kubelet. A GCE PD can only be mounted as read/write once.
  /// </summary>
  [DataContract]
  public class V1GCEPersistentDiskVolumeSource {
    
    /// <summary>
    /// Unique name of the PD resource in GCE. Used to identify the disk in GCE. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#gcepersistentdisk
    /// </summary>
    /// <value>Unique name of the PD resource in GCE. Used to identify the disk in GCE. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#gcepersistentdisk</value>
    [DataMember(Name="pdName", EmitDefaultValue=false)]
    public string PdName { get; set; }

    
    /// <summary>
    /// Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#gcepersistentdisk
    /// </summary>
    /// <value>Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#gcepersistentdisk</value>
    [DataMember(Name="fsType", EmitDefaultValue=false)]
    public string FsType { get; set; }

    
    /// <summary>
    /// The partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as \"1\". Similarly, the volume partition for /dev/sda is \"0\" (or you can leave the property empty). More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#gcepersistentdisk
    /// </summary>
    /// <value>The partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as \"1\". Similarly, the volume partition for /dev/sda is \"0\" (or you can leave the property empty). More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#gcepersistentdisk</value>
    [DataMember(Name="partition", EmitDefaultValue=false)]
    public int? Partition { get; set; }

    
    /// <summary>
    /// ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#gcepersistentdisk
    /// </summary>
    /// <value>ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#gcepersistentdisk</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    public bool? ReadOnly { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1GCEPersistentDiskVolumeSource {\n");
      
      sb.Append("  PdName: ").Append(PdName).Append("\n");
      
      sb.Append("  FsType: ").Append(FsType).Append("\n");
      
      sb.Append("  Partition: ").Append(Partition).Append("\n");
      
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
