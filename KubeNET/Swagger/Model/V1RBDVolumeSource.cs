using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// Represents a Rados Block Device mount that lasts the lifetime of a pod. RBD volumes support ownership management and SELinux relabeling.
  /// </summary>
  [DataContract]
  public class V1RBDVolumeSource {
    
    /// <summary>
    /// A collection of Ceph monitors. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md#how-to-use-it
    /// </summary>
    /// <value>A collection of Ceph monitors. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md#how-to-use-it</value>
    [DataMember(Name="monitors", EmitDefaultValue=false)]
    public List<string> Monitors { get; set; }

    
    /// <summary>
    /// The rados image name. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md#how-to-use-it
    /// </summary>
    /// <value>The rados image name. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md#how-to-use-it</value>
    [DataMember(Name="image", EmitDefaultValue=false)]
    public string Image { get; set; }

    
    /// <summary>
    /// Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#rbd
    /// </summary>
    /// <value>Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#rbd</value>
    [DataMember(Name="fsType", EmitDefaultValue=false)]
    public string FsType { get; set; }

    
    /// <summary>
    /// The rados pool name. Default is rbd. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md#how-to-use-it.
    /// </summary>
    /// <value>The rados pool name. Default is rbd. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md#how-to-use-it.</value>
    [DataMember(Name="pool", EmitDefaultValue=false)]
    public string Pool { get; set; }

    
    /// <summary>
    /// The rados user name. Default is admin. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md#how-to-use-it
    /// </summary>
    /// <value>The rados user name. Default is admin. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md#how-to-use-it</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    public string User { get; set; }

    
    /// <summary>
    /// Keyring is the path to key ring for RBDUser. Default is /etc/ceph/keyring. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md#how-to-use-it
    /// </summary>
    /// <value>Keyring is the path to key ring for RBDUser. Default is /etc/ceph/keyring. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md#how-to-use-it</value>
    [DataMember(Name="keyring", EmitDefaultValue=false)]
    public string Keyring { get; set; }

    
    /// <summary>
    /// SecretRef is name of the authentication secret for RBDUser. If provided overrides keyring. Default is empty. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md#how-to-use-it
    /// </summary>
    /// <value>SecretRef is name of the authentication secret for RBDUser. If provided overrides keyring. Default is empty. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md#how-to-use-it</value>
    [DataMember(Name="secretRef", EmitDefaultValue=false)]
    public V1LocalObjectReference SecretRef { get; set; }

    
    /// <summary>
    /// ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md#how-to-use-it
    /// </summary>
    /// <value>ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md#how-to-use-it</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    public bool? ReadOnly { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1RBDVolumeSource {\n");
      
      sb.Append("  Monitors: ").Append(Monitors).Append("\n");
      
      sb.Append("  Image: ").Append(Image).Append("\n");
      
      sb.Append("  FsType: ").Append(FsType).Append("\n");
      
      sb.Append("  Pool: ").Append(Pool).Append("\n");
      
      sb.Append("  User: ").Append(User).Append("\n");
      
      sb.Append("  Keyring: ").Append(Keyring).Append("\n");
      
      sb.Append("  SecretRef: ").Append(SecretRef).Append("\n");
      
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
