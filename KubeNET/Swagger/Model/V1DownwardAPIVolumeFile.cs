using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// DownwardAPIVolumeFile represents information to create the file containing the pod field
  /// </summary>
  [DataContract]
  public class V1DownwardAPIVolumeFile {
    
    /// <summary>
    /// Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'
    /// </summary>
    /// <value>Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    public string Path { get; set; }

    
    /// <summary>
    /// Required: Selects a field of the pod: only annotations, labels, name and namespace are supported.
    /// </summary>
    /// <value>Required: Selects a field of the pod: only annotations, labels, name and namespace are supported.</value>
    [DataMember(Name="fieldRef", EmitDefaultValue=false)]
    public V1ObjectFieldSelector FieldRef { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1DownwardAPIVolumeFile {\n");
      
      sb.Append("  Path: ").Append(Path).Append("\n");
      
      sb.Append("  FieldRef: ").Append(FieldRef).Append("\n");
      
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
