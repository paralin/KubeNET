using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// IngressRule represents the rules mapping the paths under a specified host to the related backend services. Incoming requests are first evaluated for a host match, then routed to the backend associated with the matching IngressRuleValue.
  /// </summary>
  [DataContract]
  public class V1beta1IngressRule {
    
    /// <summary>
    /// Host is the fully qualified domain name of a network host, as defined by RFC 3986. Note the following deviations from the \"host\" part of the URI as defined in the RFC: 1. IPs are not allowed. Currently an IngressRuleValue can only apply to the\n	  IP in the Spec of the parent Ingress.\n2. The `:` delimiter is not respected because ports are not allowed.\n	  Currently the port of an Ingress is implicitly :80 for http and\n	  :443 for https.\nBoth these may change in the future. Incoming requests are matched against the host before the IngressRuleValue. If the host is unspecified, the Ingress routes all traffic based on the specified IngressRuleValue.
    /// </summary>
    /// <value>Host is the fully qualified domain name of a network host, as defined by RFC 3986. Note the following deviations from the \"host\" part of the URI as defined in the RFC: 1. IPs are not allowed. Currently an IngressRuleValue can only apply to the\n	  IP in the Spec of the parent Ingress.\n2. The `:` delimiter is not respected because ports are not allowed.\n	  Currently the port of an Ingress is implicitly :80 for http and\n	  :443 for https.\nBoth these may change in the future. Incoming requests are matched against the host before the IngressRuleValue. If the host is unspecified, the Ingress routes all traffic based on the specified IngressRuleValue.</value>
    [DataMember(Name="host", EmitDefaultValue=false)]
    public string Host { get; set; }

    
    /// <summary>
    /// Gets or Sets Http
    /// </summary>
    [DataMember(Name="http", EmitDefaultValue=false)]
    public V1beta1HTTPIngressRuleValue Http { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1beta1IngressRule {\n");
      
      sb.Append("  Host: ").Append(Host).Append("\n");
      
      sb.Append("  Http: ").Append(Http).Append("\n");
      
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
