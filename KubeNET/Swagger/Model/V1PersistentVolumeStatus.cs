using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// PersistentVolumeStatus is the current status of a persistent volume.
  /// </summary>
  [DataContract]
  public class V1PersistentVolumeStatus {
    
    /// <summary>
    /// Phase indicates if a volume is available, bound to a claim, or released by a claim. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#phase
    /// </summary>
    /// <value>Phase indicates if a volume is available, bound to a claim, or released by a claim. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#phase</value>
    [DataMember(Name="phase", EmitDefaultValue=false)]
    public string Phase { get; set; }

    
    /// <summary>
    /// A human-readable message indicating details about why the volume is in this state.
    /// </summary>
    /// <value>A human-readable message indicating details about why the volume is in this state.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    
    /// <summary>
    /// Reason is a brief CamelCase string that describes any failure and is meant for machine parsing and tidy display in the CLI.
    /// </summary>
    /// <value>Reason is a brief CamelCase string that describes any failure and is meant for machine parsing and tidy display in the CLI.</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    public string Reason { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1PersistentVolumeStatus {\n");
      
      sb.Append("  Phase: ").Append(Phase).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      
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
