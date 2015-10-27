using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// PodSpec is a description of a pod.
  /// </summary>
  [DataContract]
  public class V1PodSpec {
    
    /// <summary>
    /// List of volumes that can be mounted by containers belonging to the pod. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md
    /// </summary>
    /// <value>List of volumes that can be mounted by containers belonging to the pod. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md</value>
    [DataMember(Name="volumes", EmitDefaultValue=false)]
    public List<V1Volume> Volumes { get; set; }

    
    /// <summary>
    /// List of containers belonging to the pod. Containers cannot currently be added or removed. There must be at least one container in a Pod. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/containers.md
    /// </summary>
    /// <value>List of containers belonging to the pod. Containers cannot currently be added or removed. There must be at least one container in a Pod. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/containers.md</value>
    [DataMember(Name="containers", EmitDefaultValue=false)]
    public List<V1Container> Containers { get; set; }

    
    /// <summary>
    /// Restart policy for all containers within the pod. One of Always, OnFailure, Never. Default to Always. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#restartpolicy
    /// </summary>
    /// <value>Restart policy for all containers within the pod. One of Always, OnFailure, Never. Default to Always. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#restartpolicy</value>
    [DataMember(Name="restartPolicy", EmitDefaultValue=false)]
    public string RestartPolicy { get; set; }

    
    /// <summary>
    /// Optional duration in seconds the pod needs to terminate gracefully. May be decreased in delete request. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds.
    /// </summary>
    /// <value>Optional duration in seconds the pod needs to terminate gracefully. May be decreased in delete request. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds.</value>
    [DataMember(Name="terminationGracePeriodSeconds", EmitDefaultValue=false)]
    public int? TerminationGracePeriodSeconds { get; set; }

    
    /// <summary>
    /// Optional duration in seconds the pod may be active on the node relative to StartTime before the system will actively try to mark it failed and kill associated containers. Value must be a positive integer.
    /// </summary>
    /// <value>Optional duration in seconds the pod may be active on the node relative to StartTime before the system will actively try to mark it failed and kill associated containers. Value must be a positive integer.</value>
    [DataMember(Name="activeDeadlineSeconds", EmitDefaultValue=false)]
    public int? ActiveDeadlineSeconds { get; set; }

    
    /// <summary>
    /// Set DNS policy for containers within the pod. One of 'ClusterFirst' or 'Default'. Defaults to \"ClusterFirst\".
    /// </summary>
    /// <value>Set DNS policy for containers within the pod. One of 'ClusterFirst' or 'Default'. Defaults to \"ClusterFirst\".</value>
    [DataMember(Name="dnsPolicy", EmitDefaultValue=false)]
    public string DnsPolicy { get; set; }

    
    /// <summary>
    /// ServiceAccountName is the name of the ServiceAccount to use to run this pod. More info: http://releases.k8s.io/HEAD/docs/design/service_accounts.md
    /// </summary>
    /// <value>ServiceAccountName is the name of the ServiceAccount to use to run this pod. More info: http://releases.k8s.io/HEAD/docs/design/service_accounts.md</value>
    [DataMember(Name="serviceAccountName", EmitDefaultValue=false)]
    public string ServiceAccountName { get; set; }

    
    /// <summary>
    /// DeprecatedServiceAccount is a depreciated alias for ServiceAccountName. Deprecated: Use serviceAccountName instead.
    /// </summary>
    /// <value>DeprecatedServiceAccount is a depreciated alias for ServiceAccountName. Deprecated: Use serviceAccountName instead.</value>
    [DataMember(Name="serviceAccount", EmitDefaultValue=false)]
    public string ServiceAccount { get; set; }

    
    /// <summary>
    /// NodeName is a request to schedule this pod onto a specific node. If it is non-empty, the scheduler simply schedules this pod onto that node, assuming that it fits resource requirements.
    /// </summary>
    /// <value>NodeName is a request to schedule this pod onto a specific node. If it is non-empty, the scheduler simply schedules this pod onto that node, assuming that it fits resource requirements.</value>
    [DataMember(Name="nodeName", EmitDefaultValue=false)]
    public string NodeName { get; set; }

    
    /// <summary>
    /// Host networking requested for this pod. Use the host's network namespace. If this option is set, the ports that will be used must be specified. Default to false.
    /// </summary>
    /// <value>Host networking requested for this pod. Use the host's network namespace. If this option is set, the ports that will be used must be specified. Default to false.</value>
    [DataMember(Name="hostNetwork", EmitDefaultValue=false)]
    public bool? HostNetwork { get; set; }

    
    /// <summary>
    /// Use the host's pid namespace. Optional: Default to false.
    /// </summary>
    /// <value>Use the host's pid namespace. Optional: Default to false.</value>
    [DataMember(Name="hostPID", EmitDefaultValue=false)]
    public bool? HostPID { get; set; }

    
    /// <summary>
    /// Use the host's ipc namespace. Optional: Default to false.
    /// </summary>
    /// <value>Use the host's ipc namespace. Optional: Default to false.</value>
    [DataMember(Name="hostIPC", EmitDefaultValue=false)]
    public bool? HostIPC { get; set; }

    
    /// <summary>
    /// SecurityContext holds pod-level security attributes and common container settings. Optional: Defaults to empty.  See type description for default values of each field.
    /// </summary>
    /// <value>SecurityContext holds pod-level security attributes and common container settings. Optional: Defaults to empty.  See type description for default values of each field.</value>
    [DataMember(Name="securityContext", EmitDefaultValue=false)]
    public V1PodSecurityContext SecurityContext { get; set; }

    
    /// <summary>
    /// ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images used by this PodSpec. If specified, these secrets will be passed to individual puller implementations for them to use. For example, in the case of docker, only DockerConfig type secrets are honored. More info: http://releases.k8s.io/HEAD/docs/user-guide/images.md#specifying-imagepullsecrets-on-a-pod
    /// </summary>
    /// <value>ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images used by this PodSpec. If specified, these secrets will be passed to individual puller implementations for them to use. For example, in the case of docker, only DockerConfig type secrets are honored. More info: http://releases.k8s.io/HEAD/docs/user-guide/images.md#specifying-imagepullsecrets-on-a-pod</value>
    [DataMember(Name="imagePullSecrets", EmitDefaultValue=false)]
    public List<V1LocalObjectReference> ImagePullSecrets { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1PodSpec {\n");
      
      sb.Append("  Volumes: ").Append(Volumes).Append("\n");
      
      sb.Append("  Containers: ").Append(Containers).Append("\n");
      
      sb.Append("  RestartPolicy: ").Append(RestartPolicy).Append("\n");
      
      sb.Append("  TerminationGracePeriodSeconds: ").Append(TerminationGracePeriodSeconds).Append("\n");
      
      sb.Append("  ActiveDeadlineSeconds: ").Append(ActiveDeadlineSeconds).Append("\n");
      
      sb.Append("  DnsPolicy: ").Append(DnsPolicy).Append("\n");
      
      sb.Append("  ServiceAccountName: ").Append(ServiceAccountName).Append("\n");
      
      sb.Append("  ServiceAccount: ").Append(ServiceAccount).Append("\n");
      
      sb.Append("  NodeName: ").Append(NodeName).Append("\n");
      
      sb.Append("  HostNetwork: ").Append(HostNetwork).Append("\n");
      
      sb.Append("  HostPID: ").Append(HostPID).Append("\n");
      
      sb.Append("  HostIPC: ").Append(HostIPC).Append("\n");
      
      sb.Append("  SecurityContext: ").Append(SecurityContext).Append("\n");
      
      sb.Append("  ImagePullSecrets: ").Append(ImagePullSecrets).Append("\n");
      
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
