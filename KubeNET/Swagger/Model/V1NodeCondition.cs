using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// NodeCondition contains condition infromation for a node.
  /// </summary>
  [DataContract]
  public class V1NodeCondition {
    
    /// <summary>
    /// Type of node condition, currently only Ready.
    /// </summary>
    /// <value>Type of node condition, currently only Ready.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    /// <summary>
    /// Status of the condition, one of True, False, Unknown.
    /// </summary>
    /// <value>Status of the condition, one of True, False, Unknown.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    public string Status { get; set; }

    
    /// <summary>
    /// Last time we got an update on a given condition.
    /// </summary>
    /// <value>Last time we got an update on a given condition.</value>
    [DataMember(Name="lastHeartbeatTime", EmitDefaultValue=false)]
    public string LastHeartbeatTime { get; set; }

    
    /// <summary>
    /// Last time the condition transit from one status to another.
    /// </summary>
    /// <value>Last time the condition transit from one status to another.</value>
    [DataMember(Name="lastTransitionTime", EmitDefaultValue=false)]
    public string LastTransitionTime { get; set; }

    
    /// <summary>
    /// (brief) reason for the condition's last transition.
    /// </summary>
    /// <value>(brief) reason for the condition's last transition.</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    public string Reason { get; set; }

    
    /// <summary>
    /// Human readable message indicating details about last transition.
    /// </summary>
    /// <value>Human readable message indicating details about last transition.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1NodeCondition {\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  LastHeartbeatTime: ").Append(LastHeartbeatTime).Append("\n");
      
      sb.Append("  LastTransitionTime: ").Append(LastTransitionTime).Append("\n");
      
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
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
