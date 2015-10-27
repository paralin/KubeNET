using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// SubresourceReference contains enough information to let you inspect or modify the referred subresource.
  /// </summary>
  [DataContract]
  public class V1beta1SubresourceReference {
    
    /// <summary>
    /// Kind of the referent; More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds\"
    /// </summary>
    /// <value>Kind of the referent; More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds\"</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    public string Kind { get; set; }

    
    /// <summary>
    /// Namespace of the referent; More info: http://releases.k8s.io/HEAD/docs/user-guide/namespaces.md
    /// </summary>
    /// <value>Namespace of the referent; More info: http://releases.k8s.io/HEAD/docs/user-guide/namespaces.md</value>
    [DataMember(Name="namespace", EmitDefaultValue=false)]
    public string Namespace { get; set; }

    
    /// <summary>
    /// Name of the referent; More info: http://releases.k8s.io/HEAD/docs/user-guide/identifiers.md#names
    /// </summary>
    /// <value>Name of the referent; More info: http://releases.k8s.io/HEAD/docs/user-guide/identifiers.md#names</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// API version of the referent
    /// </summary>
    /// <value>API version of the referent</value>
    [DataMember(Name="apiVersion", EmitDefaultValue=false)]
    public string ApiVersion { get; set; }

    
    /// <summary>
    /// Subresource name of the referent
    /// </summary>
    /// <value>Subresource name of the referent</value>
    [DataMember(Name="subresource", EmitDefaultValue=false)]
    public string Subresource { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1beta1SubresourceReference {\n");
      
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      
      sb.Append("  Namespace: ").Append(Namespace).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
      
      sb.Append("  Subresource: ").Append(Subresource).Append("\n");
      
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
