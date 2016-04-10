using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// EnvVarSource represents a source for the value of an EnvVar.
  /// </summary>
  [DataContract]
  public class V1EnvVarSource {
    
    /// <summary>
    /// Selects a field of the pod; only name and namespace are supported.
    /// </summary>
    /// <value>Selects a field of the pod; only name and namespace are supported.</value>
    [DataMember(Name="fieldRef", EmitDefaultValue=false)]
    public V1ObjectFieldSelector FieldRef { get; set; }

    
    /// <summary>
    /// Selects a key of a ConfigMap.
    /// </summary>
    /// <value>Selects a key of a ConfigMap.</value>
    [DataMember(Name="configMapKeyRef", EmitDefaultValue=false)]
    public V1ConfigMapKeySelector ConfigMapKeyRef { get; set; }

    
    /// <summary>
    /// Selects a key of a secret in the pod's namespace
    /// </summary>
    /// <value>Selects a key of a secret in the pod's namespace</value>
    [DataMember(Name="secretKeyRef", EmitDefaultValue=false)]
    public V1SecretKeySelector SecretKeyRef { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1EnvVarSource {\n");
      
      sb.Append("  FieldRef: ").Append(FieldRef).Append("\n");
      
      sb.Append("  ConfigMapKeyRef: ").Append(ConfigMapKeyRef).Append("\n");
      
      sb.Append("  SecretKeyRef: ").Append(SecretKeyRef).Append("\n");
      
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
