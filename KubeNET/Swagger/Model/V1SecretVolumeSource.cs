using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// SecretVolumeSource adapts a Secret into a VolumeSource. More info: http://releases.k8s.io/HEAD/docs/design/secrets.md
  /// </summary>
  [DataContract]
  public class V1SecretVolumeSource {
    
    /// <summary>
    /// SecretName is the name of a secret in the pod's namespace. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#secrets
    /// </summary>
    /// <value>SecretName is the name of a secret in the pod's namespace. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#secrets</value>
    [DataMember(Name="secretName", EmitDefaultValue=false)]
    public string SecretName { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1SecretVolumeSource {\n");
      
      sb.Append("  SecretName: ").Append(SecretName).Append("\n");
      
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
