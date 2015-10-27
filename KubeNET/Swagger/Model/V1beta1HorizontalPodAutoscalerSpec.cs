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
  public class V1beta1HorizontalPodAutoscalerSpec {
    
    /// <summary>
    /// reference to Scale subresource; horizontal pod autoscaler will learn the current resource consumption from its status, and will set the desired number of pods by modifying its spec.
    /// </summary>
    /// <value>reference to Scale subresource; horizontal pod autoscaler will learn the current resource consumption from its status, and will set the desired number of pods by modifying its spec.</value>
    [DataMember(Name="scaleRef", EmitDefaultValue=false)]
    public V1beta1SubresourceReference ScaleRef { get; set; }

    
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
    /// target average CPU utilization (represented as a percentage of requested CPU) over all the pods; if not specified it defaults to the target CPU utilization at 80% of the requested resources.
    /// </summary>
    /// <value>target average CPU utilization (represented as a percentage of requested CPU) over all the pods; if not specified it defaults to the target CPU utilization at 80% of the requested resources.</value>
    [DataMember(Name="cpuUtilization", EmitDefaultValue=false)]
    public V1beta1CPUTargetUtilization CpuUtilization { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1beta1HorizontalPodAutoscalerSpec {\n");
      
      sb.Append("  ScaleRef: ").Append(ScaleRef).Append("\n");
      
      sb.Append("  MinReplicas: ").Append(MinReplicas).Append("\n");
      
      sb.Append("  MaxReplicas: ").Append(MaxReplicas).Append("\n");
      
      sb.Append("  CpuUtilization: ").Append(CpuUtilization).Append("\n");
      
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
