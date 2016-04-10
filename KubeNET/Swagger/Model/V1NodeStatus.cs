using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// NodeStatus is information about the current status of a node.
  /// </summary>
  [DataContract]
  public class V1NodeStatus {
    
    /// <summary>
    /// Capacity represents the total resources of a node. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#capacity for more details.
    /// </summary>
    /// <value>Capacity represents the total resources of a node. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#capacity for more details.</value>
    [DataMember(Name="capacity", EmitDefaultValue=false)]
    public Dictionary<string, string> Capacity { get; set; }

    
    /// <summary>
    /// Allocatable represents the resources of a node that are available for scheduling. Defaults to Capacity.
    /// </summary>
    /// <value>Allocatable represents the resources of a node that are available for scheduling. Defaults to Capacity.</value>
    [DataMember(Name="allocatable", EmitDefaultValue=false)]
    public Dictionary<string, string> Allocatable { get; set; }

    
    /// <summary>
    /// NodePhase is the recently observed lifecycle phase of the node. More info: http://releases.k8s.io/HEAD/docs/admin/node.md#node-phase
    /// </summary>
    /// <value>NodePhase is the recently observed lifecycle phase of the node. More info: http://releases.k8s.io/HEAD/docs/admin/node.md#node-phase</value>
    [DataMember(Name="phase", EmitDefaultValue=false)]
    public string Phase { get; set; }

    
    /// <summary>
    /// Conditions is an array of current observed node conditions. More info: http://releases.k8s.io/HEAD/docs/admin/node.md#node-condition
    /// </summary>
    /// <value>Conditions is an array of current observed node conditions. More info: http://releases.k8s.io/HEAD/docs/admin/node.md#node-condition</value>
    [DataMember(Name="conditions", EmitDefaultValue=false)]
    public List<V1NodeCondition> Conditions { get; set; }

    
    /// <summary>
    /// List of addresses reachable to the node. Queried from cloud provider, if available. More info: http://releases.k8s.io/HEAD/docs/admin/node.md#node-addresses
    /// </summary>
    /// <value>List of addresses reachable to the node. Queried from cloud provider, if available. More info: http://releases.k8s.io/HEAD/docs/admin/node.md#node-addresses</value>
    [DataMember(Name="addresses", EmitDefaultValue=false)]
    public List<V1NodeAddress> Addresses { get; set; }

    
    /// <summary>
    /// Endpoints of daemons running on the Node.
    /// </summary>
    /// <value>Endpoints of daemons running on the Node.</value>
    [DataMember(Name="daemonEndpoints", EmitDefaultValue=false)]
    public V1NodeDaemonEndpoints DaemonEndpoints { get; set; }

    
    /// <summary>
    /// Set of ids/uuids to uniquely identify the node. More info: http://releases.k8s.io/HEAD/docs/admin/node.md#node-info
    /// </summary>
    /// <value>Set of ids/uuids to uniquely identify the node. More info: http://releases.k8s.io/HEAD/docs/admin/node.md#node-info</value>
    [DataMember(Name="nodeInfo", EmitDefaultValue=false)]
    public V1NodeSystemInfo NodeInfo { get; set; }

    
    /// <summary>
    /// List of container images on this node
    /// </summary>
    /// <value>List of container images on this node</value>
    [DataMember(Name="images", EmitDefaultValue=false)]
    public List<V1ContainerImage> Images { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1NodeStatus {\n");
      
      sb.Append("  Capacity: ").Append(Capacity).Append("\n");
      
      sb.Append("  Allocatable: ").Append(Allocatable).Append("\n");
      
      sb.Append("  Phase: ").Append(Phase).Append("\n");
      
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
      
      sb.Append("  Addresses: ").Append(Addresses).Append("\n");
      
      sb.Append("  DaemonEndpoints: ").Append(DaemonEndpoints).Append("\n");
      
      sb.Append("  NodeInfo: ").Append(NodeInfo).Append("\n");
      
      sb.Append("  Images: ").Append(Images).Append("\n");
      
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
