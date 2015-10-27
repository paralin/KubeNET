using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// A pod selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
  /// </summary>
  [DataContract]
  public class V1beta1PodSelectorRequirement {
    
    /// <summary>
    /// key is the label key that the selector applies to.
    /// </summary>
    /// <value>key is the label key that the selector applies to.</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    public string Key { get; set; }

    
    /// <summary>
    /// operator represents a key's relationship to a set of values. Valid operators ard In, NotIn, Exists and DoesNotExist.
    /// </summary>
    /// <value>operator represents a key's relationship to a set of values. Valid operators ard In, NotIn, Exists and DoesNotExist.</value>
    [DataMember(Name="operator", EmitDefaultValue=false)]
    public string Operator { get; set; }

    
    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.
    /// </summary>
    /// <value>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</value>
    [DataMember(Name="values", EmitDefaultValue=false)]
    public List<string> Values { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1beta1PodSelectorRequirement {\n");
      
      sb.Append("  Key: ").Append(Key).Append("\n");
      
      sb.Append("  Operator: ").Append(Operator).Append("\n");
      
      sb.Append("  Values: ").Append(Values).Append("\n");
      
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
