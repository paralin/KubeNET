using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// Represents a cinder volume resource in Openstack. A Cinder volume must exist before mounting to a container. The volume must also be in the same region as the kubelet. Cinder volumes support ownership management and SELinux relabeling.
  /// </summary>
  [DataContract]
  public class V1CinderVolumeSource {
    
    /// <summary>
    /// volume id used to identify the volume in cinder More info: http://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
    /// </summary>
    /// <value>volume id used to identify the volume in cinder More info: http://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</value>
    [DataMember(Name="volumeID", EmitDefaultValue=false)]
    public string VolumeID { get; set; }

    
    /// <summary>
    /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. More info: http://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
    /// </summary>
    /// <value>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. More info: http://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</value>
    [DataMember(Name="fsType", EmitDefaultValue=false)]
    public string FsType { get; set; }

    
    /// <summary>
    /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: http://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
    /// </summary>
    /// <value>Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: http://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    public bool? ReadOnly { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1CinderVolumeSource {\n");
      
      sb.Append("  VolumeID: ").Append(VolumeID).Append("\n");
      
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
