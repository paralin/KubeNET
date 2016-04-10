using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// DaemonSetStatus represents the current status of a daemon set.
  /// </summary>
  [DataContract]
  public class V1beta1DaemonSetStatus {
    
    /// <summary>
    /// CurrentNumberScheduled is the number of nodes that are running at least 1 daemon pod and are supposed to run the daemon pod. More info: http://releases.k8s.io/HEAD/docs/admin/daemons.md
    /// </summary>
    /// <value>CurrentNumberScheduled is the number of nodes that are running at least 1 daemon pod and are supposed to run the daemon pod. More info: http://releases.k8s.io/HEAD/docs/admin/daemons.md</value>
    [DataMember(Name="currentNumberScheduled", EmitDefaultValue=false)]
    public int? CurrentNumberScheduled { get; set; }

    
    /// <summary>
    /// NumberMisscheduled is the number of nodes that are running the daemon pod, but are not supposed to run the daemon pod. More info: http://releases.k8s.io/HEAD/docs/admin/daemons.md
    /// </summary>
    /// <value>NumberMisscheduled is the number of nodes that are running the daemon pod, but are not supposed to run the daemon pod. More info: http://releases.k8s.io/HEAD/docs/admin/daemons.md</value>
    [DataMember(Name="numberMisscheduled", EmitDefaultValue=false)]
    public int? NumberMisscheduled { get; set; }

    
    /// <summary>
    /// DesiredNumberScheduled is the total number of nodes that should be running the daemon pod (including nodes correctly running the daemon pod). More info: http://releases.k8s.io/HEAD/docs/admin/daemons.md
    /// </summary>
    /// <value>DesiredNumberScheduled is the total number of nodes that should be running the daemon pod (including nodes correctly running the daemon pod). More info: http://releases.k8s.io/HEAD/docs/admin/daemons.md</value>
    [DataMember(Name="desiredNumberScheduled", EmitDefaultValue=false)]
    public int? DesiredNumberScheduled { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1beta1DaemonSetStatus {\n");
      
      sb.Append("  CurrentNumberScheduled: ").Append(CurrentNumberScheduled).Append("\n");
      
      sb.Append("  NumberMisscheduled: ").Append(NumberMisscheduled).Append("\n");
      
      sb.Append("  DesiredNumberScheduled: ").Append(DesiredNumberScheduled).Append("\n");
      
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
