using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class JsonWatchEvent {
    
    /// <summary>
    /// the type of watch event; may be ADDED, MODIFIED, DELETED, or ERROR
    /// </summary>
    /// <value>the type of watch event; may be ADDED, MODIFIED, DELETED, or ERROR</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    /// <summary>
    /// the object being watched; will match the type of the resource endpoint or be a Status object if the type is ERROR
    /// </summary>
    /// <value>the object being watched; will match the type of the resource endpoint or be a Status object if the type is ERROR</value>
    [DataMember(Name="object", EmitDefaultValue=false)]
    public string Object { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JsonWatchEvent {\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Object: ").Append(Object).Append("\n");
      
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
