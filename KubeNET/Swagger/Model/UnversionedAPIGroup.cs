using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// APIGroup contains the name, the supported versions, and the preferred version of a group.
  /// </summary>
  [DataContract]
  public class UnversionedAPIGroup {
    
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
    /// name is the name of the group.
    /// </summary>
    /// <value>name is the name of the group.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// versions are the versions supported in this group.
    /// </summary>
    /// <value>versions are the versions supported in this group.</value>
    [DataMember(Name="versions", EmitDefaultValue=false)]
    public List<UnversionedGroupVersionForDiscovery> Versions { get; set; }

    
    /// <summary>
    /// preferredVersion is the version preferred by the API server, which probably is the storage version.
    /// </summary>
    /// <value>preferredVersion is the version preferred by the API server, which probably is the storage version.</value>
    [DataMember(Name="preferredVersion", EmitDefaultValue=false)]
    public UnversionedGroupVersionForDiscovery PreferredVersion { get; set; }

    
    /// <summary>
    /// a map of client CIDR to server address that is serving this group. This is to help clients reach servers in the most network-efficient way possible. Clients can use the appropriate server address as per the CIDR that they match. In case of multiple matches, clients should use the longest matching CIDR. The server returns only those CIDRs that it thinks that the client can match. For example: the master will return an internal IP CIDR only, if the client reaches the server using an internal IP. Server looks at X-Forwarded-For header or X-Real-Ip header or request.RemoteAddr (in that order) to get the client IP.
    /// </summary>
    /// <value>a map of client CIDR to server address that is serving this group. This is to help clients reach servers in the most network-efficient way possible. Clients can use the appropriate server address as per the CIDR that they match. In case of multiple matches, clients should use the longest matching CIDR. The server returns only those CIDRs that it thinks that the client can match. For example: the master will return an internal IP CIDR only, if the client reaches the server using an internal IP. Server looks at X-Forwarded-For header or X-Real-Ip header or request.RemoteAddr (in that order) to get the client IP.</value>
    [DataMember(Name="serverAddressByClientCIDRs", EmitDefaultValue=false)]
    public List<UnversionedServerAddressByClientCIDR> ServerAddressByClientCIDRs { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UnversionedAPIGroup {\n");
      
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      
      sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Versions: ").Append(Versions).Append("\n");
      
      sb.Append("  PreferredVersion: ").Append(PreferredVersion).Append("\n");
      
      sb.Append("  ServerAddressByClientCIDRs: ").Append(ServerAddressByClientCIDRs).Append("\n");
      
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
