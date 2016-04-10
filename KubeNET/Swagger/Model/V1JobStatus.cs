using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// JobStatus represents the current state of a Job.
  /// </summary>
  [DataContract]
  public class V1JobStatus {
    
    /// <summary>
    /// Conditions represent the latest available observations of an object's current state. More info: http://releases.k8s.io/HEAD/docs/user-guide/jobs.md
    /// </summary>
    /// <value>Conditions represent the latest available observations of an object's current state. More info: http://releases.k8s.io/HEAD/docs/user-guide/jobs.md</value>
    [DataMember(Name="conditions", EmitDefaultValue=false)]
    public List<V1JobCondition> Conditions { get; set; }

    
    /// <summary>
    /// StartTime represents time when the job was acknowledged by the Job Manager. It is not guaranteed to be set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC.
    /// </summary>
    /// <value>StartTime represents time when the job was acknowledged by the Job Manager. It is not guaranteed to be set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC.</value>
    [DataMember(Name="startTime", EmitDefaultValue=false)]
    public string StartTime { get; set; }

    
    /// <summary>
    /// CompletionTime represents time when the job was completed. It is not guaranteed to be set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC.
    /// </summary>
    /// <value>CompletionTime represents time when the job was completed. It is not guaranteed to be set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC.</value>
    [DataMember(Name="completionTime", EmitDefaultValue=false)]
    public string CompletionTime { get; set; }

    
    /// <summary>
    /// Active is the number of actively running pods.
    /// </summary>
    /// <value>Active is the number of actively running pods.</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    public int? Active { get; set; }

    
    /// <summary>
    /// Succeeded is the number of pods which reached Phase Succeeded.
    /// </summary>
    /// <value>Succeeded is the number of pods which reached Phase Succeeded.</value>
    [DataMember(Name="succeeded", EmitDefaultValue=false)]
    public int? Succeeded { get; set; }

    
    /// <summary>
    /// Failed is the number of pods which reached Phase Failed.
    /// </summary>
    /// <value>Failed is the number of pods which reached Phase Failed.</value>
    [DataMember(Name="failed", EmitDefaultValue=false)]
    public int? Failed { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1JobStatus {\n");
      
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
      
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      
      sb.Append("  CompletionTime: ").Append(CompletionTime).Append("\n");
      
      sb.Append("  Active: ").Append(Active).Append("\n");
      
      sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
      
      sb.Append("  Failed: ").Append(Failed).Append("\n");
      
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
