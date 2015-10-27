using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// ContainerStateWaiting is a waiting state of a container.
  /// </summary>
  [DataContract]
  public class V1ContainerStateWaiting {
    
    /// <summary>
    /// (brief) reason the container is not yet running.
    /// </summary>
    /// <value>(brief) reason the container is not yet running.</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    public string Reason { get; set; }

    
    /// <summary>
    /// Message regarding why the container is not yet running.
    /// </summary>
    /// <value>Message regarding why the container is not yet running.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1ContainerStateWaiting {\n");
      
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
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
