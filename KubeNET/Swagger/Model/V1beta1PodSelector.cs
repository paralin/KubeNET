using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// A pod selector is a label query over a set of pods. The result of matchLabels and matchExpressions are ANDed. An empty pod selector matches all objects. A null pod selector matches no objects.
  /// </summary>
  [DataContract]
  public class V1beta1PodSelector {
    
    /// <summary>
    /// matchExpressions is a list of pod selector requirements. The requirements are ANDed.
    /// </summary>
    /// <value>matchExpressions is a list of pod selector requirements. The requirements are ANDed.</value>
    [DataMember(Name="matchExpressions", EmitDefaultValue=false)]
    public List<V1beta1PodSelectorRequirement> MatchExpressions { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1beta1PodSelector {\n");
      
      sb.Append("  MatchExpressions: ").Append(MatchExpressions).Append("\n");
      
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
