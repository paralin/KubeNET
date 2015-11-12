using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// PersistentVolumeClaimStatus is the current status of a persistent volume claim.
  /// </summary>
  [DataContract]
  public class V1PersistentVolumeClaimStatus {
    
    /// <summary>
    /// Phase represents the current phase of PersistentVolumeClaim.
    /// </summary>
    /// <value>Phase represents the current phase of PersistentVolumeClaim.</value>
    [DataMember(Name="phase", EmitDefaultValue=false)]
    public string Phase { get; set; }

    
    /// <summary>
    /// AccessModes contains the actual access modes the volume backing the PVC has. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#access-modes-1
    /// </summary>
    /// <value>AccessModes contains the actual access modes the volume backing the PVC has. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#access-modes-1</value>
    [DataMember(Name="accessModes", EmitDefaultValue=false)]
    public List<V1PersistentVolumeAccessMode> AccessModes { get; set; }

    
    /// <summary>
    /// Represents the actual resources of the underlying volume.
    /// </summary>
    /// <value>Represents the actual resources of the underlying volume.</value>
    [DataMember(Name="capacity", EmitDefaultValue=false)]
    public Dictionary<string, string> Capacity { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1PersistentVolumeClaimStatus {\n");
      
      sb.Append("  Phase: ").Append(Phase).Append("\n");
      
      sb.Append("  AccessModes: ").Append(AccessModes).Append("\n");
      
      sb.Append("  Capacity: ").Append(Capacity).Append("\n");
      
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
