using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// ReplicaSetSpec is the specification of a ReplicaSet.
  /// </summary>
  [DataContract]
  public class V1beta1ReplicaSetSpec {
    
    /// <summary>
    /// Replicas is the number of desired replicas. This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: http://releases.k8s.io/HEAD/docs/user-guide/replication-controller.md#what-is-a-replication-controller
    /// </summary>
    /// <value>Replicas is the number of desired replicas. This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: http://releases.k8s.io/HEAD/docs/user-guide/replication-controller.md#what-is-a-replication-controller</value>
    [DataMember(Name="replicas", EmitDefaultValue=false)]
    public int? Replicas { get; set; }

    
    /// <summary>
    /// Selector is a label query over pods that should match the replica count. If the selector is empty, it is defaulted to the labels present on the pod template. Label keys and values that must match in order to be controlled by this replica set. More info: http://releases.k8s.io/HEAD/docs/user-guide/labels.md#label-selectors
    /// </summary>
    /// <value>Selector is a label query over pods that should match the replica count. If the selector is empty, it is defaulted to the labels present on the pod template. Label keys and values that must match in order to be controlled by this replica set. More info: http://releases.k8s.io/HEAD/docs/user-guide/labels.md#label-selectors</value>
    [DataMember(Name="selector", EmitDefaultValue=false)]
    public V1beta1LabelSelector Selector { get; set; }

    
    /// <summary>
    /// Template is the object that describes the pod that will be created if insufficient replicas are detected. More info: http://releases.k8s.io/HEAD/docs/user-guide/replication-controller.md#pod-template
    /// </summary>
    /// <value>Template is the object that describes the pod that will be created if insufficient replicas are detected. More info: http://releases.k8s.io/HEAD/docs/user-guide/replication-controller.md#pod-template</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    public V1PodTemplateSpec Template { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1beta1ReplicaSetSpec {\n");
      
      sb.Append("  Replicas: ").Append(Replicas).Append("\n");
      
      sb.Append("  Selector: ").Append(Selector).Append("\n");
      
      sb.Append("  Template: ").Append(Template).Append("\n");
      
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
