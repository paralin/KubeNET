using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// specification of a horizontal pod autoscaler.
  /// </summary>
  [DataContract]
  public class V1HorizontalPodAutoscalerSpec {
    
    /// <summary>
    /// reference to scaled resource; horizontal pod autoscaler will learn the current resource consumption and will set the desired number of pods by using its Scale subresource.
    /// </summary>
    /// <value>reference to scaled resource; horizontal pod autoscaler will learn the current resource consumption and will set the desired number of pods by using its Scale subresource.</value>
    [DataMember(Name="scaleTargetRef", EmitDefaultValue=false)]
    public V1CrossVersionObjectReference ScaleTargetRef { get; set; }

    
    /// <summary>
    /// lower limit for the number of pods that can be set by the autoscaler, default 1.
    /// </summary>
    /// <value>lower limit for the number of pods that can be set by the autoscaler, default 1.</value>
    [DataMember(Name="minReplicas", EmitDefaultValue=false)]
    public int? MinReplicas { get; set; }

    
    /// <summary>
    /// upper limit for the number of pods that can be set by the autoscaler; cannot be smaller than MinReplicas.
    /// </summary>
    /// <value>upper limit for the number of pods that can be set by the autoscaler; cannot be smaller than MinReplicas.</value>
    [DataMember(Name="maxReplicas", EmitDefaultValue=false)]
    public int? MaxReplicas { get; set; }

    
    /// <summary>
    /// target average CPU utilization (represented as a percentage of requested CPU) over all the pods; if not specified the default autoscaling policy will be used.
    /// </summary>
    /// <value>target average CPU utilization (represented as a percentage of requested CPU) over all the pods; if not specified the default autoscaling policy will be used.</value>
    [DataMember(Name="targetCPUUtilizationPercentage", EmitDefaultValue=false)]
    public int? TargetCPUUtilizationPercentage { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1HorizontalPodAutoscalerSpec {\n");
      
      sb.Append("  ScaleTargetRef: ").Append(ScaleTargetRef).Append("\n");
      
      sb.Append("  MinReplicas: ").Append(MinReplicas).Append("\n");
      
      sb.Append("  MaxReplicas: ").Append(MaxReplicas).Append("\n");
      
      sb.Append("  TargetCPUUtilizationPercentage: ").Append(TargetCPUUtilizationPercentage).Append("\n");
      
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
