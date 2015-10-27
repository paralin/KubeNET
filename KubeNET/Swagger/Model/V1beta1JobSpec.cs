using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// JobSpec describes how the job execution will look like.
  /// </summary>
  [DataContract]
  public class V1beta1JobSpec {
    
    /// <summary>
    /// Parallelism specifies the maximum desired number of pods the job should run at any given time. The actual number of pods running in steady state will be less than this number when ((.spec.completions - .status.successful) < .spec.parallelism), i.e. when the work left to do is less than max parallelism. More info: http://releases.k8s.io/HEAD/docs/user-guide/jobs.md
    /// </summary>
    /// <value>Parallelism specifies the maximum desired number of pods the job should run at any given time. The actual number of pods running in steady state will be less than this number when ((.spec.completions - .status.successful) < .spec.parallelism), i.e. when the work left to do is less than max parallelism. More info: http://releases.k8s.io/HEAD/docs/user-guide/jobs.md</value>
    [DataMember(Name="parallelism", EmitDefaultValue=false)]
    public int? Parallelism { get; set; }

    
    /// <summary>
    /// Completions specifies the desired number of successfully finished pods the job should be run with. Defaults to 1. More info: http://releases.k8s.io/HEAD/docs/user-guide/jobs.md
    /// </summary>
    /// <value>Completions specifies the desired number of successfully finished pods the job should be run with. Defaults to 1. More info: http://releases.k8s.io/HEAD/docs/user-guide/jobs.md</value>
    [DataMember(Name="completions", EmitDefaultValue=false)]
    public int? Completions { get; set; }

    
    /// <summary>
    /// Selector is a label query over pods that should match the pod count. More info: http://releases.k8s.io/HEAD/docs/user-guide/labels.md#label-selectors
    /// </summary>
    /// <value>Selector is a label query over pods that should match the pod count. More info: http://releases.k8s.io/HEAD/docs/user-guide/labels.md#label-selectors</value>
    [DataMember(Name="selector", EmitDefaultValue=false)]
    public V1beta1PodSelector Selector { get; set; }

    
    /// <summary>
    /// Template is the object that describes the pod that will be created when executing a job. More info: http://releases.k8s.io/HEAD/docs/user-guide/jobs.md
    /// </summary>
    /// <value>Template is the object that describes the pod that will be created when executing a job. More info: http://releases.k8s.io/HEAD/docs/user-guide/jobs.md</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    public V1PodTemplateSpec Template { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1beta1JobSpec {\n");
      
      sb.Append("  Parallelism: ").Append(Parallelism).Append("\n");
      
      sb.Append("  Completions: ").Append(Completions).Append("\n");
      
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
