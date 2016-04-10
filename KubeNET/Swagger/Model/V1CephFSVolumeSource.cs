using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// Represents a Ceph Filesystem mount that lasts the lifetime of a pod Cephfs volumes do not support ownership management or SELinux relabeling.
  /// </summary>
  [DataContract]
  public class V1CephFSVolumeSource {
    
    /// <summary>
    /// Required: Monitors is a collection of Ceph monitors More info: http://releases.k8s.io/HEAD/examples/cephfs/README.md#how-to-use-it
    /// </summary>
    /// <value>Required: Monitors is a collection of Ceph monitors More info: http://releases.k8s.io/HEAD/examples/cephfs/README.md#how-to-use-it</value>
    [DataMember(Name="monitors", EmitDefaultValue=false)]
    public List<string> Monitors { get; set; }

    
    /// <summary>
    /// Optional: Used as the mounted root, rather than the full Ceph tree, default is /
    /// </summary>
    /// <value>Optional: Used as the mounted root, rather than the full Ceph tree, default is /</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    public string Path { get; set; }

    
    /// <summary>
    /// Optional: User is the rados user name, default is admin More info: http://releases.k8s.io/HEAD/examples/cephfs/README.md#how-to-use-it
    /// </summary>
    /// <value>Optional: User is the rados user name, default is admin More info: http://releases.k8s.io/HEAD/examples/cephfs/README.md#how-to-use-it</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    public string User { get; set; }

    
    /// <summary>
    /// Optional: SecretFile is the path to key ring for User, default is /etc/ceph/user.secret More info: http://releases.k8s.io/HEAD/examples/cephfs/README.md#how-to-use-it
    /// </summary>
    /// <value>Optional: SecretFile is the path to key ring for User, default is /etc/ceph/user.secret More info: http://releases.k8s.io/HEAD/examples/cephfs/README.md#how-to-use-it</value>
    [DataMember(Name="secretFile", EmitDefaultValue=false)]
    public string SecretFile { get; set; }

    
    /// <summary>
    /// Optional: SecretRef is reference to the authentication secret for User, default is empty. More info: http://releases.k8s.io/HEAD/examples/cephfs/README.md#how-to-use-it
    /// </summary>
    /// <value>Optional: SecretRef is reference to the authentication secret for User, default is empty. More info: http://releases.k8s.io/HEAD/examples/cephfs/README.md#how-to-use-it</value>
    [DataMember(Name="secretRef", EmitDefaultValue=false)]
    public V1LocalObjectReference SecretRef { get; set; }

    
    /// <summary>
    /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: http://releases.k8s.io/HEAD/examples/cephfs/README.md#how-to-use-it
    /// </summary>
    /// <value>Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: http://releases.k8s.io/HEAD/examples/cephfs/README.md#how-to-use-it</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    public bool? ReadOnly { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1CephFSVolumeSource {\n");
      
      sb.Append("  Monitors: ").Append(Monitors).Append("\n");
      
      sb.Append("  Path: ").Append(Path).Append("\n");
      
      sb.Append("  User: ").Append(User).Append("\n");
      
      sb.Append("  SecretFile: ").Append(SecretFile).Append("\n");
      
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
