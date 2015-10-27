using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// PersistentVolumeClaimVolumeSource references the user&#39;s PVC in the same namespace. This volume finds the bound PV and mounts that volume for the pod. A PersistentVolumeClaimVolumeSource is, essentially, a wrapper around another type of volume that is owned by someone else (the system).
  /// </summary>
  [DataContract]
  public class V1PersistentVolumeClaimVolumeSource {
    
    /// <summary>
    /// ClaimName is the name of a PersistentVolumeClaim in the same namespace as the pod using this volume. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#persistentvolumeclaims
    /// </summary>
    /// <value>ClaimName is the name of a PersistentVolumeClaim in the same namespace as the pod using this volume. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#persistentvolumeclaims</value>
    [DataMember(Name="claimName", EmitDefaultValue=false)]
    public string ClaimName { get; set; }

    
    /// <summary>
    /// Will force the ReadOnly setting in VolumeMounts. Default false.
    /// </summary>
    /// <value>Will force the ReadOnly setting in VolumeMounts. Default false.</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    public bool? ReadOnly { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1PersistentVolumeClaimVolumeSource {\n");
      
      sb.Append("  ClaimName: ").Append(ClaimName).Append("\n");
      
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
