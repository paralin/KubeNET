using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// PersistentVolume (PV) is a storage resource provisioned by an administrator. It is analogous to a node. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md
  /// </summary>
  [DataContract]
  public class V1PersistentVolume {
    
    /// <summary>
    /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds
    /// </summary>
    /// <value>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    public string Kind { get; set; }

    
    /// <summary>
    /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources
    /// </summary>
    /// <value>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources</value>
    [DataMember(Name="apiVersion", EmitDefaultValue=false)]
    public string ApiVersion { get; set; }

    
    /// <summary>
    /// Standard object's metadata. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#metadata
    /// </summary>
    /// <value>Standard object's metadata. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#metadata</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    public V1ObjectMeta Metadata { get; set; }

    
    /// <summary>
    /// Spec defines a specification of a persistent volume owned by the cluster. Provisioned by an administrator. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#persistent-volumes
    /// </summary>
    /// <value>Spec defines a specification of a persistent volume owned by the cluster. Provisioned by an administrator. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#persistent-volumes</value>
    [DataMember(Name="spec", EmitDefaultValue=false)]
    public V1PersistentVolumeSpec Spec { get; set; }

    
    /// <summary>
    /// Status represents the current information/status for the persistent volume. Populated by the system. Read-only. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#persistent-volumes
    /// </summary>
    /// <value>Status represents the current information/status for the persistent volume. Populated by the system. Read-only. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#persistent-volumes</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    public V1PersistentVolumeStatus Status { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1PersistentVolume {\n");
      
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      
      sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
      
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
      
      sb.Append("  Spec: ").Append(Spec).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
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
