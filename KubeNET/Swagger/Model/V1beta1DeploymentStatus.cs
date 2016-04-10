using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// DeploymentStatus is the most recently observed status of the Deployment.
  /// </summary>
  [DataContract]
  public class V1beta1DeploymentStatus {
    
    /// <summary>
    /// The generation observed by the deployment controller.
    /// </summary>
    /// <value>The generation observed by the deployment controller.</value>
    [DataMember(Name="observedGeneration", EmitDefaultValue=false)]
    public int? ObservedGeneration { get; set; }

    
    /// <summary>
    /// Total number of non-terminated pods targeted by this deployment (their labels match the selector).
    /// </summary>
    /// <value>Total number of non-terminated pods targeted by this deployment (their labels match the selector).</value>
    [DataMember(Name="replicas", EmitDefaultValue=false)]
    public int? Replicas { get; set; }

    
    /// <summary>
    /// Total number of non-terminated pods targeted by this deployment that have the desired template spec.
    /// </summary>
    /// <value>Total number of non-terminated pods targeted by this deployment that have the desired template spec.</value>
    [DataMember(Name="updatedReplicas", EmitDefaultValue=false)]
    public int? UpdatedReplicas { get; set; }

    
    /// <summary>
    /// Total number of available pods (ready for at least minReadySeconds) targeted by this deployment.
    /// </summary>
    /// <value>Total number of available pods (ready for at least minReadySeconds) targeted by this deployment.</value>
    [DataMember(Name="availableReplicas", EmitDefaultValue=false)]
    public int? AvailableReplicas { get; set; }

    
    /// <summary>
    /// Total number of unavailable pods targeted by this deployment.
    /// </summary>
    /// <value>Total number of unavailable pods targeted by this deployment.</value>
    [DataMember(Name="unavailableReplicas", EmitDefaultValue=false)]
    public int? UnavailableReplicas { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1beta1DeploymentStatus {\n");
      
      sb.Append("  ObservedGeneration: ").Append(ObservedGeneration).Append("\n");
      
      sb.Append("  Replicas: ").Append(Replicas).Append("\n");
      
      sb.Append("  UpdatedReplicas: ").Append(UpdatedReplicas).Append("\n");
      
      sb.Append("  AvailableReplicas: ").Append(AvailableReplicas).Append("\n");
      
      sb.Append("  UnavailableReplicas: ").Append(UnavailableReplicas).Append("\n");
      
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
