using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// PersistentVolumeClaimSpec describes the common attributes of storage devices and allows a Source for provider-specific attributes
  /// </summary>
  [DataContract]
  public class V1PersistentVolumeClaimSpec {
    
    /// <summary>
    /// AccessModes contains the desired access modes the volume should have. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#access-modes-1
    /// </summary>
    /// <value>AccessModes contains the desired access modes the volume should have. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#access-modes-1</value>
    [DataMember(Name="accessModes", EmitDefaultValue=false)]
    public List<V1PersistentVolumeAccessMode> AccessModes { get; set; }

    
    /// <summary>
    /// Resources represents the minimum resources the volume should have. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#resources
    /// </summary>
    /// <value>Resources represents the minimum resources the volume should have. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#resources</value>
    [DataMember(Name="resources", EmitDefaultValue=false)]
    public V1ResourceRequirements Resources { get; set; }

    
    /// <summary>
    /// VolumeName is the binding reference to the PersistentVolume backing this claim.
    /// </summary>
    /// <value>VolumeName is the binding reference to the PersistentVolume backing this claim.</value>
    [DataMember(Name="volumeName", EmitDefaultValue=false)]
    public string VolumeName { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1PersistentVolumeClaimSpec {\n");
      
      sb.Append("  AccessModes: ").Append(AccessModes).Append("\n");
      
      sb.Append("  Resources: ").Append(Resources).Append("\n");
      
      sb.Append("  VolumeName: ").Append(VolumeName).Append("\n");
      
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
