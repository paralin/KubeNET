using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// SecretKeySelector selects a key of a Secret.
  /// </summary>
  [DataContract]
  public class V1SecretKeySelector {
    
    /// <summary>
    /// Name of the referent. More info: http://releases.k8s.io/HEAD/docs/user-guide/identifiers.md#names
    /// </summary>
    /// <value>Name of the referent. More info: http://releases.k8s.io/HEAD/docs/user-guide/identifiers.md#names</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// The key of the secret to select from.  Must be a valid secret key.
    /// </summary>
    /// <value>The key of the secret to select from.  Must be a valid secret key.</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    public string Key { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1SecretKeySelector {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Key: ").Append(Key).Append("\n");
      
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
