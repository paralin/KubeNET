using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// LimitRangeItem defines a min/max usage limit for any resource that matches on kind.
  /// </summary>
  [DataContract]
  public class V1LimitRangeItem {
    
    /// <summary>
    /// Type of resource that this limit applies to.
    /// </summary>
    /// <value>Type of resource that this limit applies to.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    /// <summary>
    /// Max usage constraints on this kind by resource name.
    /// </summary>
    /// <value>Max usage constraints on this kind by resource name.</value>
    [DataMember(Name="max", EmitDefaultValue=false)]
    public Dictionary<string, string> Max { get; set; }

    
    /// <summary>
    /// Min usage constraints on this kind by resource name.
    /// </summary>
    /// <value>Min usage constraints on this kind by resource name.</value>
    [DataMember(Name="min", EmitDefaultValue=false)]
    public Dictionary<string, string> Min { get; set; }

    
    /// <summary>
    /// Default resource requirement limit value by resource name if resource limit is omitted.
    /// </summary>
    /// <value>Default resource requirement limit value by resource name if resource limit is omitted.</value>
    [DataMember(Name="default", EmitDefaultValue=false)]
    public Dictionary<string, string> Default { get; set; }

    
    /// <summary>
    /// DefaultRequest is the default resource requirement request value by resource name if resource request is omitted.
    /// </summary>
    /// <value>DefaultRequest is the default resource requirement request value by resource name if resource request is omitted.</value>
    [DataMember(Name="defaultRequest", EmitDefaultValue=false)]
    public Dictionary<string, string> DefaultRequest { get; set; }

    
    /// <summary>
    /// MaxLimitRequestRatio if specified, the named resource must have a request and limit that are both non-zero where limit divided by request is less than or equal to the enumerated value; this represents the max burst for the named resource.
    /// </summary>
    /// <value>MaxLimitRequestRatio if specified, the named resource must have a request and limit that are both non-zero where limit divided by request is less than or equal to the enumerated value; this represents the max burst for the named resource.</value>
    [DataMember(Name="maxLimitRequestRatio", EmitDefaultValue=false)]
    public Dictionary<string, string> MaxLimitRequestRatio { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1LimitRangeItem {\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Max: ").Append(Max).Append("\n");
      
      sb.Append("  Min: ").Append(Min).Append("\n");
      
      sb.Append("  Default: ").Append(Default).Append("\n");
      
      sb.Append("  DefaultRequest: ").Append(DefaultRequest).Append("\n");
      
      sb.Append("  MaxLimitRequestRatio: ").Append(MaxLimitRequestRatio).Append("\n");
      
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
