using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// PodCondition contains details for the current condition of this pod.
  /// </summary>
  [DataContract]
  public class V1PodCondition {
    
    /// <summary>
    /// Type is the type of the condition. Currently only Ready. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#pod-conditions
    /// </summary>
    /// <value>Type is the type of the condition. Currently only Ready. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#pod-conditions</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    /// <summary>
    /// Status is the status of the condition. Can be True, False, Unknown. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#pod-conditions
    /// </summary>
    /// <value>Status is the status of the condition. Can be True, False, Unknown. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#pod-conditions</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    public string Status { get; set; }

    
    /// <summary>
    /// Last time we probed the condition.
    /// </summary>
    /// <value>Last time we probed the condition.</value>
    [DataMember(Name="lastProbeTime", EmitDefaultValue=false)]
    public string LastProbeTime { get; set; }

    
    /// <summary>
    /// Last time the condition transitioned from one status to another.
    /// </summary>
    /// <value>Last time the condition transitioned from one status to another.</value>
    [DataMember(Name="lastTransitionTime", EmitDefaultValue=false)]
    public string LastTransitionTime { get; set; }

    
    /// <summary>
    /// Unique, one-word, CamelCase reason for the condition's last transition.
    /// </summary>
    /// <value>Unique, one-word, CamelCase reason for the condition's last transition.</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    public string Reason { get; set; }

    
    /// <summary>
    /// Human-readable message indicating details about last transition.
    /// </summary>
    /// <value>Human-readable message indicating details about last transition.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1PodCondition {\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  LastProbeTime: ").Append(LastProbeTime).Append("\n");
      
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
