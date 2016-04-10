using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// PersistentVolumeSpec is the specification of a persistent volume.
  /// </summary>
  [DataContract]
  public class V1PersistentVolumeSpec {
    
    /// <summary>
    /// A description of the persistent volume's resources and capacity. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#capacity
    /// </summary>
    /// <value>A description of the persistent volume's resources and capacity. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#capacity</value>
    [DataMember(Name="capacity", EmitDefaultValue=false)]
    public Dictionary<string, string> Capacity { get; set; }

    
    /// <summary>
    /// GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. Provisioned by an admin. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#gcepersistentdisk
    /// </summary>
    /// <value>GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. Provisioned by an admin. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#gcepersistentdisk</value>
    [DataMember(Name="gcePersistentDisk", EmitDefaultValue=false)]
    public V1GCEPersistentDiskVolumeSource GcePersistentDisk { get; set; }

    
    /// <summary>
    /// AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#awselasticblockstore
    /// </summary>
    /// <value>AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#awselasticblockstore</value>
    [DataMember(Name="awsElasticBlockStore", EmitDefaultValue=false)]
    public V1AWSElasticBlockStoreVolumeSource AwsElasticBlockStore { get; set; }

    
    /// <summary>
    /// HostPath represents a directory on the host. Provisioned by a developer or tester. This is useful for single-node development and testing only! On-host storage is not supported in any way and WILL NOT WORK in a multi-node cluster. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#hostpath
    /// </summary>
    /// <value>HostPath represents a directory on the host. Provisioned by a developer or tester. This is useful for single-node development and testing only! On-host storage is not supported in any way and WILL NOT WORK in a multi-node cluster. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#hostpath</value>
    [DataMember(Name="hostPath", EmitDefaultValue=false)]
    public V1HostPathVolumeSource HostPath { get; set; }

    
    /// <summary>
    /// Glusterfs represents a Glusterfs volume that is attached to a host and exposed to the pod. Provisioned by an admin. More info: http://releases.k8s.io/HEAD/examples/glusterfs/README.md
    /// </summary>
    /// <value>Glusterfs represents a Glusterfs volume that is attached to a host and exposed to the pod. Provisioned by an admin. More info: http://releases.k8s.io/HEAD/examples/glusterfs/README.md</value>
    [DataMember(Name="glusterfs", EmitDefaultValue=false)]
    public V1GlusterfsVolumeSource Glusterfs { get; set; }

    
    /// <summary>
    /// NFS represents an NFS mount on the host. Provisioned by an admin. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#nfs
    /// </summary>
    /// <value>NFS represents an NFS mount on the host. Provisioned by an admin. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#nfs</value>
    [DataMember(Name="nfs", EmitDefaultValue=false)]
    public V1NFSVolumeSource Nfs { get; set; }

    
    /// <summary>
    /// RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md
    /// </summary>
    /// <value>RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md</value>
    [DataMember(Name="rbd", EmitDefaultValue=false)]
    public V1RBDVolumeSource Rbd { get; set; }

    
    /// <summary>
    /// ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. Provisioned by an admin.
    /// </summary>
    /// <value>ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. Provisioned by an admin.</value>
    [DataMember(Name="iscsi", EmitDefaultValue=false)]
    public V1ISCSIVolumeSource Iscsi { get; set; }

    
    /// <summary>
    /// Cinder represents a cinder volume attached and mounted on kubelets host machine More info: http://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
    /// </summary>
    /// <value>Cinder represents a cinder volume attached and mounted on kubelets host machine More info: http://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</value>
    [DataMember(Name="cinder", EmitDefaultValue=false)]
    public V1CinderVolumeSource Cinder { get; set; }

    
    /// <summary>
    /// CephFS represents a Ceph FS mount on the host that shares a pod's lifetime
    /// </summary>
    /// <value>CephFS represents a Ceph FS mount on the host that shares a pod's lifetime</value>
    [DataMember(Name="cephfs", EmitDefaultValue=false)]
    public V1CephFSVolumeSource Cephfs { get; set; }

    
    /// <summary>
    /// FC represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.
    /// </summary>
    /// <value>FC represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.</value>
    [DataMember(Name="fc", EmitDefaultValue=false)]
    public V1FCVolumeSource Fc { get; set; }

    
    /// <summary>
    /// Flocker represents a Flocker volume attached to a kubelet's host machine and exposed to the pod for its usage. This depends on the Flocker control service being running
    /// </summary>
    /// <value>Flocker represents a Flocker volume attached to a kubelet's host machine and exposed to the pod for its usage. This depends on the Flocker control service being running</value>
    [DataMember(Name="flocker", EmitDefaultValue=false)]
    public V1FlockerVolumeSource Flocker { get; set; }

    
    /// <summary>
    /// FlexVolume represents a generic volume resource that is provisioned/attached using a exec based plugin. This is an alpha feature and may change in future.
    /// </summary>
    /// <value>FlexVolume represents a generic volume resource that is provisioned/attached using a exec based plugin. This is an alpha feature and may change in future.</value>
    [DataMember(Name="flexVolume", EmitDefaultValue=false)]
    public V1FlexVolumeSource FlexVolume { get; set; }

    
    /// <summary>
    /// AzureFile represents an Azure File Service mount on the host and bind mount to the pod.
    /// </summary>
    /// <value>AzureFile represents an Azure File Service mount on the host and bind mount to the pod.</value>
    [DataMember(Name="azureFile", EmitDefaultValue=false)]
    public V1AzureFileVolumeSource AzureFile { get; set; }

    
    /// <summary>
    /// AccessModes contains all ways the volume can be mounted. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#access-modes
    /// </summary>
    /// <value>AccessModes contains all ways the volume can be mounted. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#access-modes</value>
    [DataMember(Name="accessModes", EmitDefaultValue=false)]
    public List<V1PersistentVolumeAccessMode> AccessModes { get; set; }

    
    /// <summary>
    /// ClaimRef is part of a bi-directional binding between PersistentVolume and PersistentVolumeClaim. Expected to be non-nil when bound. claim.VolumeName is the authoritative bind between PV and PVC. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#binding
    /// </summary>
    /// <value>ClaimRef is part of a bi-directional binding between PersistentVolume and PersistentVolumeClaim. Expected to be non-nil when bound. claim.VolumeName is the authoritative bind between PV and PVC. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#binding</value>
    [DataMember(Name="claimRef", EmitDefaultValue=false)]
    public V1ObjectReference ClaimRef { get; set; }

    
    /// <summary>
    /// What happens to a persistent volume when released from its claim. Valid options are Retain (default) and Recycle. Recyling must be supported by the volume plugin underlying this persistent volume. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#recycling-policy
    /// </summary>
    /// <value>What happens to a persistent volume when released from its claim. Valid options are Retain (default) and Recycle. Recyling must be supported by the volume plugin underlying this persistent volume. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#recycling-policy</value>
    [DataMember(Name="persistentVolumeReclaimPolicy", EmitDefaultValue=false)]
    public string PersistentVolumeReclaimPolicy { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1PersistentVolumeSpec {\n");
      
      sb.Append("  Capacity: ").Append(Capacity).Append("\n");
      
      sb.Append("  GcePersistentDisk: ").Append(GcePersistentDisk).Append("\n");
      
      sb.Append("  AwsElasticBlockStore: ").Append(AwsElasticBlockStore).Append("\n");
      
      sb.Append("  HostPath: ").Append(HostPath).Append("\n");
      
      sb.Append("  Glusterfs: ").Append(Glusterfs).Append("\n");
      
      sb.Append("  Nfs: ").Append(Nfs).Append("\n");
      
      sb.Append("  Rbd: ").Append(Rbd).Append("\n");
      
      sb.Append("  Iscsi: ").Append(Iscsi).Append("\n");
      
      sb.Append("  Cinder: ").Append(Cinder).Append("\n");
      
      sb.Append("  Cephfs: ").Append(Cephfs).Append("\n");
      
      sb.Append("  Fc: ").Append(Fc).Append("\n");
      
      sb.Append("  Flocker: ").Append(Flocker).Append("\n");
      
      sb.Append("  FlexVolume: ").Append(FlexVolume).Append("\n");
      
      sb.Append("  AzureFile: ").Append(AzureFile).Append("\n");
      
      sb.Append("  AccessModes: ").Append(AccessModes).Append("\n");
      
      sb.Append("  ClaimRef: ").Append(ClaimRef).Append("\n");
      
      sb.Append("  PersistentVolumeReclaimPolicy: ").Append(PersistentVolumeReclaimPolicy).Append("\n");
      
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
