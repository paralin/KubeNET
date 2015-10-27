using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// Information about the condition of a component.
  /// </summary>
  [DataContract]
  public class V1ComponentCondition {
    
    /// <summary>
    /// Type of condition for a component. Valid value: \"Healthy\"
    /// </summary>
    /// <value>Type of condition for a component. Valid value: \"Healthy\"</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    /// <summary>
    /// Status of the condition for a component. Valid values for \"Healthy\": \"True\", \"False\", or \"Unknown\".
    /// </summary>
    /// <value>Status of the condition for a component. Valid values for \"Healthy\": \"True\", \"False\", or \"Unknown\".</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    public string Status { get; set; }

    
    /// <summary>
    /// Message about the condition for a component. For example, information about a health check.
    /// </summary>
    /// <value>Message about the condition for a component. For example, information about a health check.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    
    /// <summary>
    /// Condition error code for a component. For example, a health check error code.
    /// </summary>
    /// <value>Condition error code for a component. For example, a health check error code.</value>
    [DataMember(Name="error", EmitDefaultValue=false)]
    public string Error { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1ComponentCondition {\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
      sb.Append("  Error: ").Append(Error).Append("\n");
      
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
