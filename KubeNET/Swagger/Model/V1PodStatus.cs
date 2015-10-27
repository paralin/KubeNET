using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// PodStatus represents information about the status of a pod. Status may trail the actual state of a system.
  /// </summary>
  [DataContract]
  public class V1PodStatus {
    
    /// <summary>
    /// Current condition of the pod. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#pod-phase
    /// </summary>
    /// <value>Current condition of the pod. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#pod-phase</value>
    [DataMember(Name="phase", EmitDefaultValue=false)]
    public string Phase { get; set; }

    
    /// <summary>
    /// Current service state of pod. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#pod-conditions
    /// </summary>
    /// <value>Current service state of pod. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#pod-conditions</value>
    [DataMember(Name="conditions", EmitDefaultValue=false)]
    public List<V1PodCondition> Conditions { get; set; }

    
    /// <summary>
    /// A human readable message indicating details about why the pod is in this condition.
    /// </summary>
    /// <value>A human readable message indicating details about why the pod is in this condition.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    
    /// <summary>
    /// A brief CamelCase message indicating details about why the pod is in this state. e.g. 'OutOfDisk'
    /// </summary>
    /// <value>A brief CamelCase message indicating details about why the pod is in this state. e.g. 'OutOfDisk'</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    public string Reason { get; set; }

    
    /// <summary>
    /// IP address of the host to which the pod is assigned. Empty if not yet scheduled.
    /// </summary>
    /// <value>IP address of the host to which the pod is assigned. Empty if not yet scheduled.</value>
    [DataMember(Name="hostIP", EmitDefaultValue=false)]
    public string HostIP { get; set; }

    
    /// <summary>
    /// IP address allocated to the pod. Routable at least within the cluster. Empty if not yet allocated.
    /// </summary>
    /// <value>IP address allocated to the pod. Routable at least within the cluster. Empty if not yet allocated.</value>
    [DataMember(Name="podIP", EmitDefaultValue=false)]
    public string PodIP { get; set; }

    
    /// <summary>
    /// RFC 3339 date and time at which the object was acknowledged by the Kubelet. This is before the Kubelet pulled the container image(s) for the pod.
    /// </summary>
    /// <value>RFC 3339 date and time at which the object was acknowledged by the Kubelet. This is before the Kubelet pulled the container image(s) for the pod.</value>
    [DataMember(Name="startTime", EmitDefaultValue=false)]
    public string StartTime { get; set; }

    
    /// <summary>
    /// The list has one entry per container in the manifest. Each entry is currently the output of `docker inspect`. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#container-statuses
    /// </summary>
    /// <value>The list has one entry per container in the manifest. Each entry is currently the output of `docker inspect`. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#container-statuses</value>
    [DataMember(Name="containerStatuses", EmitDefaultValue=false)]
    public List<V1ContainerStatus> ContainerStatuses { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1PodStatus {\n");
      
      sb.Append("  Phase: ").Append(Phase).Append("\n");
      
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      
      sb.Append("  HostIP: ").Append(HostIP).Append("\n");
      
      sb.Append("  PodIP: ").Append(PodIP).Append("\n");
      
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      
      sb.Append("  ContainerStatuses: ").Append(ContainerStatuses).Append("\n");
      
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
