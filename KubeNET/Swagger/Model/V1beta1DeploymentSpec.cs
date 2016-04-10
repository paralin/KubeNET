using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// DeploymentSpec is the specification of the desired behavior of the Deployment.
  /// </summary>
  [DataContract]
  public class V1beta1DeploymentSpec {
    
    /// <summary>
    /// Number of desired pods. This is a pointer to distinguish between explicit zero and not specified. Defaults to 1.
    /// </summary>
    /// <value>Number of desired pods. This is a pointer to distinguish between explicit zero and not specified. Defaults to 1.</value>
    [DataMember(Name="replicas", EmitDefaultValue=false)]
    public int? Replicas { get; set; }

    
    /// <summary>
    /// Label selector for pods. Existing ReplicaSets whose pods are selected by this will be the ones affected by this deployment.
    /// </summary>
    /// <value>Label selector for pods. Existing ReplicaSets whose pods are selected by this will be the ones affected by this deployment.</value>
    [DataMember(Name="selector", EmitDefaultValue=false)]
    public V1beta1LabelSelector Selector { get; set; }

    
    /// <summary>
    /// Template describes the pods that will be created.
    /// </summary>
    /// <value>Template describes the pods that will be created.</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    public V1PodTemplateSpec Template { get; set; }

    
    /// <summary>
    /// The deployment strategy to use to replace existing pods with new ones.
    /// </summary>
    /// <value>The deployment strategy to use to replace existing pods with new ones.</value>
    [DataMember(Name="strategy", EmitDefaultValue=false)]
    public V1beta1DeploymentStrategy Strategy { get; set; }

    
    /// <summary>
    /// Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)
    /// </summary>
    /// <value>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)</value>
    [DataMember(Name="minReadySeconds", EmitDefaultValue=false)]
    public int? MinReadySeconds { get; set; }

    
    /// <summary>
    /// The number of old ReplicaSets to retain to allow rollback. This is a pointer to distinguish between explicit zero and not specified.
    /// </summary>
    /// <value>The number of old ReplicaSets to retain to allow rollback. This is a pointer to distinguish between explicit zero and not specified.</value>
    [DataMember(Name="revisionHistoryLimit", EmitDefaultValue=false)]
    public int? RevisionHistoryLimit { get; set; }

    
    /// <summary>
    /// Indicates that the deployment is paused and will not be processed by the deployment controller.
    /// </summary>
    /// <value>Indicates that the deployment is paused and will not be processed by the deployment controller.</value>
    [DataMember(Name="paused", EmitDefaultValue=false)]
    public bool? Paused { get; set; }

    
    /// <summary>
    /// The config this deployment is rolling back to. Will be cleared after rollback is done.
    /// </summary>
    /// <value>The config this deployment is rolling back to. Will be cleared after rollback is done.</value>
    [DataMember(Name="rollbackTo", EmitDefaultValue=false)]
    public V1beta1RollbackConfig RollbackTo { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1beta1DeploymentSpec {\n");
      
      sb.Append("  Replicas: ").Append(Replicas).Append("\n");
      
      sb.Append("  Selector: ").Append(Selector).Append("\n");
      
      sb.Append("  Template: ").Append(Template).Append("\n");
      
      sb.Append("  Strategy: ").Append(Strategy).Append("\n");
      
      sb.Append("  MinReadySeconds: ").Append(MinReadySeconds).Append("\n");
      
      sb.Append("  RevisionHistoryLimit: ").Append(RevisionHistoryLimit).Append("\n");
      
      sb.Append("  Paused: ").Append(Paused).Append("\n");
      
      sb.Append("  RollbackTo: ").Append(RollbackTo).Append("\n");
      
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
