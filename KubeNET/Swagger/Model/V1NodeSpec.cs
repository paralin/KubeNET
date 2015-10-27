using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// NodeSpec describes the attributes that a node is created with.
  /// </summary>
  [DataContract]
  public class V1NodeSpec {
    
    /// <summary>
    /// PodCIDR represents the pod IP range assigned to the node.
    /// </summary>
    /// <value>PodCIDR represents the pod IP range assigned to the node.</value>
    [DataMember(Name="podCIDR", EmitDefaultValue=false)]
    public string PodCIDR { get; set; }

    
    /// <summary>
    /// External ID of the node assigned by some machine database (e.g. a cloud provider). Deprecated.
    /// </summary>
    /// <value>External ID of the node assigned by some machine database (e.g. a cloud provider). Deprecated.</value>
    [DataMember(Name="externalID", EmitDefaultValue=false)]
    public string ExternalID { get; set; }

    
    /// <summary>
    /// ID of the node assigned by the cloud provider in the format: <ProviderName>://<ProviderSpecificNodeID>
    /// </summary>
    /// <value>ID of the node assigned by the cloud provider in the format: <ProviderName>://<ProviderSpecificNodeID></value>
    [DataMember(Name="providerID", EmitDefaultValue=false)]
    public string ProviderID { get; set; }

    
    /// <summary>
    /// Unschedulable controls node schedulability of new pods. By default, node is schedulable. More info: http://releases.k8s.io/HEAD/docs/admin/node.md#manual-node-administration\"`
    /// </summary>
    /// <value>Unschedulable controls node schedulability of new pods. By default, node is schedulable. More info: http://releases.k8s.io/HEAD/docs/admin/node.md#manual-node-administration\"`</value>
    [DataMember(Name="unschedulable", EmitDefaultValue=false)]
    public bool? Unschedulable { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1NodeSpec {\n");
      
      sb.Append("  PodCIDR: ").Append(PodCIDR).Append("\n");
      
      sb.Append("  ExternalID: ").Append(ExternalID).Append("\n");
      
      sb.Append("  ProviderID: ").Append(ProviderID).Append("\n");
      
      sb.Append("  Unschedulable: ").Append(Unschedulable).Append("\n");
      
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
