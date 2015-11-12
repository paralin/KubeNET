using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// ServiceSpec describes the attributes that a user creates on a service.
  /// </summary>
  [DataContract]
  public class V1ServiceSpec {
    
    /// <summary>
    /// The list of ports that are exposed by this service. More info: http://releases.k8s.io/HEAD/docs/user-guide/services.md#virtual-ips-and-service-proxies
    /// </summary>
    /// <value>The list of ports that are exposed by this service. More info: http://releases.k8s.io/HEAD/docs/user-guide/services.md#virtual-ips-and-service-proxies</value>
    [DataMember(Name="ports", EmitDefaultValue=false)]
    public List<V1ServicePort> Ports { get; set; }

    
    /// <summary>
    /// This service will route traffic to pods having labels matching this selector. Label keys and values that must match in order to receive traffic for this service. If empty, all pods are selected, if not specified, endpoints must be manually specified. More info: http://releases.k8s.io/HEAD/docs/user-guide/services.md#overview
    /// </summary>
    /// <value>This service will route traffic to pods having labels matching this selector. Label keys and values that must match in order to receive traffic for this service. If empty, all pods are selected, if not specified, endpoints must be manually specified. More info: http://releases.k8s.io/HEAD/docs/user-guide/services.md#overview</value>
    [DataMember(Name="selector", EmitDefaultValue=false)]
    public Dictionary<string, string> Selector { get; set; }

    
    /// <summary>
    /// ClusterIP is usually assigned by the master and is the IP address of the service. If specified, it will be allocated to the service if it is unused or else creation of the service will fail. Valid values are None, empty string (\"\"), or a valid IP address. 'None' can be specified for a headless service when proxying is not required. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/services.md#virtual-ips-and-service-proxies
    /// </summary>
    /// <value>ClusterIP is usually assigned by the master and is the IP address of the service. If specified, it will be allocated to the service if it is unused or else creation of the service will fail. Valid values are None, empty string (\"\"), or a valid IP address. 'None' can be specified for a headless service when proxying is not required. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/services.md#virtual-ips-and-service-proxies</value>
    [DataMember(Name="clusterIP", EmitDefaultValue=false)]
    public string ClusterIP { get; set; }

    
    /// <summary>
    /// Type of exposed service. Must be ClusterIP, NodePort, or LoadBalancer. Defaults to ClusterIP. More info: http://releases.k8s.io/HEAD/docs/user-guide/services.md#external-services
    /// </summary>
    /// <value>Type of exposed service. Must be ClusterIP, NodePort, or LoadBalancer. Defaults to ClusterIP. More info: http://releases.k8s.io/HEAD/docs/user-guide/services.md#external-services</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    /// <summary>
    /// externalIPs is a list of IP addresses for which nodes in the cluster will also accept traffic for this service.  These IPs are not managed by Kubernetes.  The user is responsible for ensuring that traffic arrives at a node with this IP.  A common example is external load-balancers that are not part of the Kubernetes system.  A previous form of this functionality exists as the deprecatedPublicIPs field.  When using this field, callers should also clear the deprecatedPublicIPs field.
    /// </summary>
    /// <value>externalIPs is a list of IP addresses for which nodes in the cluster will also accept traffic for this service.  These IPs are not managed by Kubernetes.  The user is responsible for ensuring that traffic arrives at a node with this IP.  A common example is external load-balancers that are not part of the Kubernetes system.  A previous form of this functionality exists as the deprecatedPublicIPs field.  When using this field, callers should also clear the deprecatedPublicIPs field.</value>
    [DataMember(Name="externalIPs", EmitDefaultValue=false)]
    public List<string> ExternalIPs { get; set; }

    
    /// <summary>
    /// deprecatedPublicIPs is deprecated and replaced by the externalIPs field with almost the exact same semantics.  This field is retained in the v1 API for compatibility until at least 8/20/2016.  It will be removed from any new API revisions.  If both deprecatedPublicIPs *and* externalIPs are set, deprecatedPublicIPs is used.
    /// </summary>
    /// <value>deprecatedPublicIPs is deprecated and replaced by the externalIPs field with almost the exact same semantics.  This field is retained in the v1 API for compatibility until at least 8/20/2016.  It will be removed from any new API revisions.  If both deprecatedPublicIPs *and* externalIPs are set, deprecatedPublicIPs is used.</value>
    [DataMember(Name="deprecatedPublicIPs", EmitDefaultValue=false)]
    public List<string> DeprecatedPublicIPs { get; set; }

    
    /// <summary>
    /// Supports \"ClientIP\" and \"None\". Used to maintain session affinity. Enable client IP based session affinity. Must be ClientIP or None. Defaults to None. More info: http://releases.k8s.io/HEAD/docs/user-guide/services.md#virtual-ips-and-service-proxies
    /// </summary>
    /// <value>Supports \"ClientIP\" and \"None\". Used to maintain session affinity. Enable client IP based session affinity. Must be ClientIP or None. Defaults to None. More info: http://releases.k8s.io/HEAD/docs/user-guide/services.md#virtual-ips-and-service-proxies</value>
    [DataMember(Name="sessionAffinity", EmitDefaultValue=false)]
    public string SessionAffinity { get; set; }

    
    /// <summary>
    /// Only applies to Service Type: LoadBalancer LoadBalancer will get created with the IP specified in this field. This feature depends on whether the underlying cloud-provider supports specifying the loadBalancerIP when a load balancer is created. This field will be ignored if the cloud-provider does not support the feature.
    /// </summary>
    /// <value>Only applies to Service Type: LoadBalancer LoadBalancer will get created with the IP specified in this field. This feature depends on whether the underlying cloud-provider supports specifying the loadBalancerIP when a load balancer is created. This field will be ignored if the cloud-provider does not support the feature.</value>
    [DataMember(Name="loadBalancerIP", EmitDefaultValue=false)]
    public string LoadBalancerIP { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1ServiceSpec {\n");
      
      sb.Append("  Ports: ").Append(Ports).Append("\n");
      
      sb.Append("  Selector: ").Append(Selector).Append("\n");
      
      sb.Append("  ClusterIP: ").Append(ClusterIP).Append("\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  ExternalIPs: ").Append(ExternalIPs).Append("\n");
      
      sb.Append("  DeprecatedPublicIPs: ").Append(DeprecatedPublicIPs).Append("\n");
      
      sb.Append("  SessionAffinity: ").Append(SessionAffinity).Append("\n");
      
      sb.Append("  LoadBalancerIP: ").Append(LoadBalancerIP).Append("\n");
      
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
