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
    /// Completions specifies the desired number of successfully finished pods the job should be run with.  Setting to nil means that the success of any pod signals the success of all pods, and allows parallelism to have any positive value.  Setting to 1 means that parallelism is limited to 1 and the success of that pod signals the success of the job. More info: http://releases.k8s.io/HEAD/docs/user-guide/jobs.md
    /// </summary>
    /// <value>Completions specifies the desired number of successfully finished pods the job should be run with.  Setting to nil means that the success of any pod signals the success of all pods, and allows parallelism to have any positive value.  Setting to 1 means that parallelism is limited to 1 and the success of that pod signals the success of the job. More info: http://releases.k8s.io/HEAD/docs/user-guide/jobs.md</value>
    [DataMember(Name="completions", EmitDefaultValue=false)]
    public int? Completions { get; set; }

    
    /// <summary>
    /// Optional duration in seconds relative to the startTime that the job may be active before the system tries to terminate it; value must be positive integer
    /// </summary>
    /// <value>Optional duration in seconds relative to the startTime that the job may be active before the system tries to terminate it; value must be positive integer</value>
    [DataMember(Name="activeDeadlineSeconds", EmitDefaultValue=false)]
    public int? ActiveDeadlineSeconds { get; set; }

    
    /// <summary>
    /// Selector is a label query over pods that should match the pod count. Normally, the system sets this field for you. More info: http://releases.k8s.io/HEAD/docs/user-guide/labels.md#label-selectors
    /// </summary>
    /// <value>Selector is a label query over pods that should match the pod count. Normally, the system sets this field for you. More info: http://releases.k8s.io/HEAD/docs/user-guide/labels.md#label-selectors</value>
    [DataMember(Name="selector", EmitDefaultValue=false)]
    public V1beta1LabelSelector Selector { get; set; }

    
    /// <summary>
    /// AutoSelector controls generation of pod labels and pod selectors. It was not present in the original extensions/v1beta1 Job definition, but exists to allow conversion from batch/v1 Jobs, where it corresponds to, but has the opposite meaning as, ManualSelector. More info: http://releases.k8s.io/HEAD/docs/design/selector-generation.md
    /// </summary>
    /// <value>AutoSelector controls generation of pod labels and pod selectors. It was not present in the original extensions/v1beta1 Job definition, but exists to allow conversion from batch/v1 Jobs, where it corresponds to, but has the opposite meaning as, ManualSelector. More info: http://releases.k8s.io/HEAD/docs/design/selector-generation.md</value>
    [DataMember(Name="autoSelector", EmitDefaultValue=false)]
    public bool? AutoSelector { get; set; }

    
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
      
      sb.Append("  ActiveDeadlineSeconds: ").Append(ActiveDeadlineSeconds).Append("\n");
      
      sb.Append("  Selector: ").Append(Selector).Append("\n");
      
      sb.Append("  AutoSelector: ").Append(AutoSelector).Append("\n");
      
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
