using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// ObjectReference contains enough information to let you inspect or modify the referred object.
  /// </summary>
  [DataContract]
  public class V1ObjectReference {
    
    /// <summary>
    /// Kind of the referent. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds
    /// </summary>
    /// <value>Kind of the referent. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    public string Kind { get; set; }

    
    /// <summary>
    /// Namespace of the referent. More info: http://releases.k8s.io/HEAD/docs/user-guide/namespaces.md
    /// </summary>
    /// <value>Namespace of the referent. More info: http://releases.k8s.io/HEAD/docs/user-guide/namespaces.md</value>
    [DataMember(Name="namespace", EmitDefaultValue=false)]
    public string Namespace { get; set; }

    
    /// <summary>
    /// Name of the referent. More info: http://releases.k8s.io/HEAD/docs/user-guide/identifiers.md#names
    /// </summary>
    /// <value>Name of the referent. More info: http://releases.k8s.io/HEAD/docs/user-guide/identifiers.md#names</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// UID of the referent. More info: http://releases.k8s.io/HEAD/docs/user-guide/identifiers.md#uids
    /// </summary>
    /// <value>UID of the referent. More info: http://releases.k8s.io/HEAD/docs/user-guide/identifiers.md#uids</value>
    [DataMember(Name="uid", EmitDefaultValue=false)]
    public string Uid { get; set; }

    
    /// <summary>
    /// API version of the referent.
    /// </summary>
    /// <value>API version of the referent.</value>
    [DataMember(Name="apiVersion", EmitDefaultValue=false)]
    public string ApiVersion { get; set; }

    
    /// <summary>
    /// Specific resourceVersion to which this reference is made, if any. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#concurrency-control-and-consistency
    /// </summary>
    /// <value>Specific resourceVersion to which this reference is made, if any. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#concurrency-control-and-consistency</value>
    [DataMember(Name="resourceVersion", EmitDefaultValue=false)]
    public string ResourceVersion { get; set; }

    
    /// <summary>
    /// If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: \"spec.containers{name}\" (where \"name\" refers to the name of the container that triggered the event) or if no container name is specified \"spec.containers[2]\" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object.
    /// </summary>
    /// <value>If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: \"spec.containers{name}\" (where \"name\" refers to the name of the container that triggered the event) or if no container name is specified \"spec.containers[2]\" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object.</value>
    [DataMember(Name="fieldPath", EmitDefaultValue=false)]
    public string FieldPath { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1ObjectReference {\n");
      
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      
      sb.Append("  Namespace: ").Append(Namespace).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Uid: ").Append(Uid).Append("\n");
      
      sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
      
      sb.Append("  ResourceVersion: ").Append(ResourceVersion).Append("\n");
      
      sb.Append("  FieldPath: ").Append(FieldPath).Append("\n");
      
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
