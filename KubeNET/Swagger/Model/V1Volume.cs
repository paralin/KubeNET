using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// Volume represents a named volume in a pod that may be accessed by any container in the pod.
  /// </summary>
  [DataContract]
  public class V1Volume {
    
    /// <summary>
    /// Volume's name. Must be a DNS_LABEL and unique within the pod. More info: http://releases.k8s.io/HEAD/docs/user-guide/identifiers.md#names
    /// </summary>
    /// <value>Volume's name. Must be a DNS_LABEL and unique within the pod. More info: http://releases.k8s.io/HEAD/docs/user-guide/identifiers.md#names</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// HostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container. This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#hostpath
    /// </summary>
    /// <value>HostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container. This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#hostpath</value>
    [DataMember(Name="hostPath", EmitDefaultValue=false)]
    public V1HostPathVolumeSource HostPath { get; set; }

    
    /// <summary>
    /// EmptyDir represents a temporary directory that shares a pod's lifetime. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#emptydir
    /// </summary>
    /// <value>EmptyDir represents a temporary directory that shares a pod's lifetime. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#emptydir</value>
    [DataMember(Name="emptyDir", EmitDefaultValue=false)]
    public V1EmptyDirVolumeSource EmptyDir { get; set; }

    
    /// <summary>
    /// GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#gcepersistentdisk
    /// </summary>
    /// <value>GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#gcepersistentdisk</value>
    [DataMember(Name="gcePersistentDisk", EmitDefaultValue=false)]
    public V1GCEPersistentDiskVolumeSource GcePersistentDisk { get; set; }

    
    /// <summary>
    /// AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#awselasticblockstore
    /// </summary>
    /// <value>AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#awselasticblockstore</value>
    [DataMember(Name="awsElasticBlockStore", EmitDefaultValue=false)]
    public V1AWSElasticBlockStoreVolumeSource AwsElasticBlockStore { get; set; }

    
    /// <summary>
    /// GitRepo represents a git repository at a particular revision.
    /// </summary>
    /// <value>GitRepo represents a git repository at a particular revision.</value>
    [DataMember(Name="gitRepo", EmitDefaultValue=false)]
    public V1GitRepoVolumeSource GitRepo { get; set; }

    
    /// <summary>
    /// Secret represents a secret that should populate this volume. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#secrets
    /// </summary>
    /// <value>Secret represents a secret that should populate this volume. More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#secrets</value>
    [DataMember(Name="secret", EmitDefaultValue=false)]
    public V1SecretVolumeSource Secret { get; set; }

    
    /// <summary>
    /// NFS represents an NFS mount on the host that shares a pod's lifetime More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#nfs
    /// </summary>
    /// <value>NFS represents an NFS mount on the host that shares a pod's lifetime More info: http://releases.k8s.io/HEAD/docs/user-guide/volumes.md#nfs</value>
    [DataMember(Name="nfs", EmitDefaultValue=false)]
    public V1NFSVolumeSource Nfs { get; set; }

    
    /// <summary>
    /// ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: http://releases.k8s.io/HEAD/examples/iscsi/README.md
    /// </summary>
    /// <value>ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: http://releases.k8s.io/HEAD/examples/iscsi/README.md</value>
    [DataMember(Name="iscsi", EmitDefaultValue=false)]
    public V1ISCSIVolumeSource Iscsi { get; set; }

    
    /// <summary>
    /// Glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. More info: http://releases.k8s.io/HEAD/examples/glusterfs/README.md
    /// </summary>
    /// <value>Glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. More info: http://releases.k8s.io/HEAD/examples/glusterfs/README.md</value>
    [DataMember(Name="glusterfs", EmitDefaultValue=false)]
    public V1GlusterfsVolumeSource Glusterfs { get; set; }

    
    /// <summary>
    /// PersistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#persistentvolumeclaims
    /// </summary>
    /// <value>PersistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#persistentvolumeclaims</value>
    [DataMember(Name="persistentVolumeClaim", EmitDefaultValue=false)]
    public V1PersistentVolumeClaimVolumeSource PersistentVolumeClaim { get; set; }

    
    /// <summary>
    /// RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md
    /// </summary>
    /// <value>RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: http://releases.k8s.io/HEAD/examples/rbd/README.md</value>
    [DataMember(Name="rbd", EmitDefaultValue=false)]
    public V1RBDVolumeSource Rbd { get; set; }

    
    /// <summary>
    /// FlexVolume represents a generic volume resource that is provisioned/attached using a exec based plugin. This is an alpha feature and may change in future.
    /// </summary>
    /// <value>FlexVolume represents a generic volume resource that is provisioned/attached using a exec based plugin. This is an alpha feature and may change in future.</value>
    [DataMember(Name="flexVolume", EmitDefaultValue=false)]
    public V1FlexVolumeSource FlexVolume { get; set; }

    
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
    /// Flocker represents a Flocker volume attached to a kubelet's host machine. This depends on the Flocker control service being running
    /// </summary>
    /// <value>Flocker represents a Flocker volume attached to a kubelet's host machine. This depends on the Flocker control service being running</value>
    [DataMember(Name="flocker", EmitDefaultValue=false)]
    public V1FlockerVolumeSource Flocker { get; set; }

    
    /// <summary>
    /// DownwardAPI represents downward API about the pod that should populate this volume
    /// </summary>
    /// <value>DownwardAPI represents downward API about the pod that should populate this volume</value>
    [DataMember(Name="downwardAPI", EmitDefaultValue=false)]
    public V1DownwardAPIVolumeSource DownwardAPI { get; set; }

    
    /// <summary>
    /// FC represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.
    /// </summary>
    /// <value>FC represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.</value>
    [DataMember(Name="fc", EmitDefaultValue=false)]
    public V1FCVolumeSource Fc { get; set; }

    
    /// <summary>
    /// AzureFile represents an Azure File Service mount on the host and bind mount to the pod.
    /// </summary>
    /// <value>AzureFile represents an Azure File Service mount on the host and bind mount to the pod.</value>
    [DataMember(Name="azureFile", EmitDefaultValue=false)]
    public V1AzureFileVolumeSource AzureFile { get; set; }

    
    /// <summary>
    /// ConfigMap represents a configMap that should populate this volume
    /// </summary>
    /// <value>ConfigMap represents a configMap that should populate this volume</value>
    [DataMember(Name="configMap", EmitDefaultValue=false)]
    public V1ConfigMapVolumeSource ConfigMap { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1Volume {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  HostPath: ").Append(HostPath).Append("\n");
      
      sb.Append("  EmptyDir: ").Append(EmptyDir).Append("\n");
      
      sb.Append("  GcePersistentDisk: ").Append(GcePersistentDisk).Append("\n");
      
      sb.Append("  AwsElasticBlockStore: ").Append(AwsElasticBlockStore).Append("\n");
      
      sb.Append("  GitRepo: ").Append(GitRepo).Append("\n");
      
      sb.Append("  Secret: ").Append(Secret).Append("\n");
      
      sb.Append("  Nfs: ").Append(Nfs).Append("\n");
      
      sb.Append("  Iscsi: ").Append(Iscsi).Append("\n");
      
      sb.Append("  Glusterfs: ").Append(Glusterfs).Append("\n");
      
      sb.Append("  PersistentVolumeClaim: ").Append(PersistentVolumeClaim).Append("\n");
      
      sb.Append("  Rbd: ").Append(Rbd).Append("\n");
      
      sb.Append("  FlexVolume: ").Append(FlexVolume).Append("\n");
      
      sb.Append("  Cinder: ").Append(Cinder).Append("\n");
      
      sb.Append("  Cephfs: ").Append(Cephfs).Append("\n");
      
      sb.Append("  Flocker: ").Append(Flocker).Append("\n");
      
      sb.Append("  DownwardAPI: ").Append(DownwardAPI).Append("\n");
      
      sb.Append("  Fc: ").Append(Fc).Append("\n");
      
      sb.Append("  AzureFile: ").Append(AzureFile).Append("\n");
      
      sb.Append("  ConfigMap: ").Append(ConfigMap).Append("\n");
      
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
