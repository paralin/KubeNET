using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// StatusDetails is a set of additional properties that MAY be set by the server to provide additional information about a response. The Reason field of a Status object defines what attributes will be set. Clients must ignore fields that do not match the defined type of each attribute, and should assume that any attribute may be empty, invalid, or under defined.
  /// </summary>
  [DataContract]
  public class UnversionedStatusDetails {
    
    /// <summary>
    /// The name attribute of the resource associated with the status StatusReason (when there is a single name which can be described).
    /// </summary>
    /// <value>The name attribute of the resource associated with the status StatusReason (when there is a single name which can be described).</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// The group attribute of the resource associated with the status StatusReason.
    /// </summary>
    /// <value>The group attribute of the resource associated with the status StatusReason.</value>
    [DataMember(Name="group", EmitDefaultValue=false)]
    public string Group { get; set; }

    
    /// <summary>
    /// The kind attribute of the resource associated with the status StatusReason. On some operations may differ from the requested resource Kind. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds
    /// </summary>
    /// <value>The kind attribute of the resource associated with the status StatusReason. On some operations may differ from the requested resource Kind. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    public string Kind { get; set; }

    
    /// <summary>
    /// The Causes array includes more details associated with the StatusReason failure. Not all StatusReasons may provide detailed causes.
    /// </summary>
    /// <value>The Causes array includes more details associated with the StatusReason failure. Not all StatusReasons may provide detailed causes.</value>
    [DataMember(Name="causes", EmitDefaultValue=false)]
    public List<UnversionedStatusCause> Causes { get; set; }

    
    /// <summary>
    /// If specified, the time in seconds before the operation should be retried.
    /// </summary>
    /// <value>If specified, the time in seconds before the operation should be retried.</value>
    [DataMember(Name="retryAfterSeconds", EmitDefaultValue=false)]
    public int? RetryAfterSeconds { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UnversionedStatusDetails {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Group: ").Append(Group).Append("\n");
      
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      
      sb.Append("  Causes: ").Append(Causes).Append("\n");
      
      sb.Append("  RetryAfterSeconds: ").Append(RetryAfterSeconds).Append("\n");
      
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
