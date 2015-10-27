using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// ReplicationControllerStatus represents the current status of a replication controller.
  /// </summary>
  [DataContract]
  public class V1ReplicationControllerStatus {
    
    /// <summary>
    /// Replicas is the most recently oberved number of replicas. More info: http://releases.k8s.io/HEAD/docs/user-guide/replication-controller.md#what-is-a-replication-controller
    /// </summary>
    /// <value>Replicas is the most recently oberved number of replicas. More info: http://releases.k8s.io/HEAD/docs/user-guide/replication-controller.md#what-is-a-replication-controller</value>
    [DataMember(Name="replicas", EmitDefaultValue=false)]
    public int? Replicas { get; set; }

    
    /// <summary>
    /// ObservedGeneration reflects the generation of the most recently observed replication controller.
    /// </summary>
    /// <value>ObservedGeneration reflects the generation of the most recently observed replication controller.</value>
    [DataMember(Name="observedGeneration", EmitDefaultValue=false)]
    public int? ObservedGeneration { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1ReplicationControllerStatus {\n");
      
      sb.Append("  Replicas: ").Append(Replicas).Append("\n");
      
      sb.Append("  ObservedGeneration: ").Append(ObservedGeneration).Append("\n");
      
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
