using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// Represents a volume that is populated with the contents of a git repository. Git repo volumes do not support ownership management. Git repo volumes support SELinux relabeling.
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
    /// Target directory name. Must not contain or start with '..'.  If '.' is supplied, the volume directory will be the git repository.  Otherwise, if specified, the volume will contain the git repository in the subdirectory with the given name.
    /// </summary>
    /// <value>Target directory name. Must not contain or start with '..'.  If '.' is supplied, the volume directory will be the git repository.  Otherwise, if specified, the volume will contain the git repository in the subdirectory with the given name.</value>
    [DataMember(Name="directory", EmitDefaultValue=false)]
    public string Directory { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1GitRepoVolumeSource {\n");
      
      sb.Append("  Repository: ").Append(Repository).Append("\n");
      
      sb.Append("  Revision: ").Append(Revision).Append("\n");
      
      sb.Append("  Directory: ").Append(Directory).Append("\n");
      
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
