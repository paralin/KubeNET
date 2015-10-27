using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// NodeSystemInfo is a set of ids/uuids to uniquely identify the node.
  /// </summary>
  [DataContract]
  public class V1NodeSystemInfo {
    
    /// <summary>
    /// Machine ID reported by the node.
    /// </summary>
    /// <value>Machine ID reported by the node.</value>
    [DataMember(Name="machineID", EmitDefaultValue=false)]
    public string MachineID { get; set; }

    
    /// <summary>
    /// System UUID reported by the node.
    /// </summary>
    /// <value>System UUID reported by the node.</value>
    [DataMember(Name="systemUUID", EmitDefaultValue=false)]
    public string SystemUUID { get; set; }

    
    /// <summary>
    /// Boot ID reported by the node.
    /// </summary>
    /// <value>Boot ID reported by the node.</value>
    [DataMember(Name="bootID", EmitDefaultValue=false)]
    public string BootID { get; set; }

    
    /// <summary>
    /// Kernel Version reported by the node from 'uname -r' (e.g. 3.16.0-0.bpo.4-amd64).
    /// </summary>
    /// <value>Kernel Version reported by the node from 'uname -r' (e.g. 3.16.0-0.bpo.4-amd64).</value>
    [DataMember(Name="kernelVersion", EmitDefaultValue=false)]
    public string KernelVersion { get; set; }

    
    /// <summary>
    /// OS Image reported by the node from /etc/os-release (e.g. Debian GNU/Linux 7 (wheezy)).
    /// </summary>
    /// <value>OS Image reported by the node from /etc/os-release (e.g. Debian GNU/Linux 7 (wheezy)).</value>
    [DataMember(Name="osImage", EmitDefaultValue=false)]
    public string OsImage { get; set; }

    
    /// <summary>
    /// ContainerRuntime Version reported by the node through runtime remote API (e.g. docker://1.5.0).
    /// </summary>
    /// <value>ContainerRuntime Version reported by the node through runtime remote API (e.g. docker://1.5.0).</value>
    [DataMember(Name="containerRuntimeVersion", EmitDefaultValue=false)]
    public string ContainerRuntimeVersion { get; set; }

    
    /// <summary>
    /// Kubelet Version reported by the node.
    /// </summary>
    /// <value>Kubelet Version reported by the node.</value>
    [DataMember(Name="kubeletVersion", EmitDefaultValue=false)]
    public string KubeletVersion { get; set; }

    
    /// <summary>
    /// KubeProxy Version reported by the node.
    /// </summary>
    /// <value>KubeProxy Version reported by the node.</value>
    [DataMember(Name="kubeProxyVersion", EmitDefaultValue=false)]
    public string KubeProxyVersion { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1NodeSystemInfo {\n");
      
      sb.Append("  MachineID: ").Append(MachineID).Append("\n");
      
      sb.Append("  SystemUUID: ").Append(SystemUUID).Append("\n");
      
      sb.Append("  BootID: ").Append(BootID).Append("\n");
      
      sb.Append("  KernelVersion: ").Append(KernelVersion).Append("\n");
      
      sb.Append("  OsImage: ").Append(OsImage).Append("\n");
      
      sb.Append("  ContainerRuntimeVersion: ").Append(ContainerRuntimeVersion).Append("\n");
      
      sb.Append("  KubeletVersion: ").Append(KubeletVersion).Append("\n");
      
      sb.Append("  KubeProxyVersion: ").Append(KubeProxyVersion).Append("\n");
      
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
