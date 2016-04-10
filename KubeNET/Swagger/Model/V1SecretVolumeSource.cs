using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// Adapts a Secret into a volume.\n\nThe contents of the target Secret&#39;s Data field will be presented in a volume as files using the keys in the Data field as the file names. Secret volumes support ownership management and SELinux relabeling.
  /// </summary>
  [DataContract]
  public class V1SecretVolumeSource {
    
    /// <summary>
    /// Name of the secret in the pod's namespace to use. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#secrets
    /// </summary>
    /// <value>Name of the secret in the pod's namespace to use. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#secrets</value>
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
