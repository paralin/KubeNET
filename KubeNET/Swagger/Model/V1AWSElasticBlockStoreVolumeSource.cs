using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// Represents a persistent disk resource in AWS.\n\nAn Amazon Elastic Block Store (EBS) must already be created, formatted, and reside in the same AWS zone as the kubelet before it can be mounted. Note: Amazon EBS volumes can be mounted to only one instance at a time.
  /// </summary>
  [DataContract]
  public class V1AWSElasticBlockStoreVolumeSource {
    
    /// <summary>
    /// Unique ID of the persistent disk resource in AWS (Amazon EBS volume). More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#awselasticblockstore
    /// </summary>
    /// <value>Unique ID of the persistent disk resource in AWS (Amazon EBS volume). More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#awselasticblockstore</value>
    [DataMember(Name="volumeID", EmitDefaultValue=false)]
    public string VolumeID { get; set; }

    
    /// <summary>
    /// Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#awselasticblockstore
    /// </summary>
    /// <value>Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#awselasticblockstore</value>
    [DataMember(Name="fsType", EmitDefaultValue=false)]
    public string FsType { get; set; }

    
    /// <summary>
    /// The partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as \"1\". Similarly, the volume partition for /dev/sda is \"0\" (or you can leave the property empty).
    /// </summary>
    /// <value>The partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as \"1\". Similarly, the volume partition for /dev/sda is \"0\" (or you can leave the property empty).</value>
    [DataMember(Name="partition", EmitDefaultValue=false)]
    public int? Partition { get; set; }

    
    /// <summary>
    /// Specify \"true\" to force and set the ReadOnly property in VolumeMounts to \"true\". If omitted, the default is \"false\". More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#awselasticblockstore
    /// </summary>
    /// <value>Specify \"true\" to force and set the ReadOnly property in VolumeMounts to \"true\". If omitted, the default is \"false\". More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#awselasticblockstore</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    public bool? ReadOnly { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1AWSElasticBlockStoreVolumeSource {\n");
      
      sb.Append("  VolumeID: ").Append(VolumeID).Append("\n");
      
      sb.Append("  FsType: ").Append(FsType).Append("\n");
      
      sb.Append("  Partition: ").Append(Partition).Append("\n");
      
      sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
      
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
