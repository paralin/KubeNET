using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// Represents an NFS mount that lasts the lifetime of a pod. NFS volumes do not support ownership management or SELinux relabeling.
  /// </summary>
  [DataContract]
  public class V1NFSVolumeSource {
    
    /// <summary>
    /// Server is the hostname or IP address of the NFS server. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#nfs
    /// </summary>
    /// <value>Server is the hostname or IP address of the NFS server. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#nfs</value>
    [DataMember(Name="server", EmitDefaultValue=false)]
    public string Server { get; set; }

    
    /// <summary>
    /// Path that is exported by the NFS server. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#nfs
    /// </summary>
    /// <value>Path that is exported by the NFS server. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#nfs</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    public string Path { get; set; }

    
    /// <summary>
    /// ReadOnly here will force the NFS export to be mounted with read-only permissions. Defaults to false. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#nfs
    /// </summary>
    /// <value>ReadOnly here will force the NFS export to be mounted with read-only permissions. Defaults to false. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#nfs</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    public bool? ReadOnly { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1NFSVolumeSource {\n");
      
      sb.Append("  Server: ").Append(Server).Append("\n");
      
      sb.Append("  Path: ").Append(Path).Append("\n");
      
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
