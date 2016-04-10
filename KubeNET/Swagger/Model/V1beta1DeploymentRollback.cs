using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// DeploymentRollback stores the information required to rollback a deployment.
  /// </summary>
  [DataContract]
  public class V1beta1DeploymentRollback {
    
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
    /// Required: This must match the Name of a deployment.
    /// </summary>
    /// <value>Required: This must match the Name of a deployment.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// The annotations to be updated to a deployment
    /// </summary>
    /// <value>The annotations to be updated to a deployment</value>
    [DataMember(Name="updatedAnnotations", EmitDefaultValue=false)]
    public Dictionary<string, string> UpdatedAnnotations { get; set; }

    
    /// <summary>
    /// The config of this deployment rollback.
    /// </summary>
    /// <value>The config of this deployment rollback.</value>
    [DataMember(Name="rollbackTo", EmitDefaultValue=false)]
    public V1beta1RollbackConfig RollbackTo { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1beta1DeploymentRollback {\n");
      
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      
      sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  UpdatedAnnotations: ").Append(UpdatedAnnotations).Append("\n");
      
      sb.Append("  RollbackTo: ").Append(RollbackTo).Append("\n");
      
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
