using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// GitRepoVolumeSource represents a volume that is pulled from git when the pod is created.
  /// </summary>
  [DataContract]
  public class V1GitRepoVolumeSource {
    
    /// <summary>
    /// Repository URL
    /// </summary>
    /// <value>Repository URL</value>
    [DataMember(Name="repository", EmitDefaultValue=false)]
    public string Repository { get; set; }

    
    /// <summary>
    /// Commit hash for the specified revision.
    /// </summary>
    /// <value>Commit hash for the specified revision.</value>
    [DataMember(Name="revision", EmitDefaultValue=false)]
    public string Revision { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1GitRepoVolumeSource {\n");
      
      sb.Append("  Repository: ").Append(Repository).Append("\n");
      
      sb.Append("  Revision: ").Append(Revision).Append("\n");
      
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
