using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// APIResource specifies the name of a resource and whether it is namespaced.
  /// </summary>
  [DataContract]
  public class UnversionedAPIResource {
    
    /// <summary>
    /// name is the name of the resource.
    /// </summary>
    /// <value>name is the name of the resource.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// namespaced indicates if a resource is namespaced or not.
    /// </summary>
    /// <value>namespaced indicates if a resource is namespaced or not.</value>
    [DataMember(Name="namespaced", EmitDefaultValue=false)]
    public bool? Namespaced { get; set; }

    
    /// <summary>
    /// kind is the kind for the resource (e.g. 'Foo' is the kind for a resource 'foo')
    /// </summary>
    /// <value>kind is the kind for the resource (e.g. 'Foo' is the kind for a resource 'foo')</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    public string Kind { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UnversionedAPIResource {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Namespaced: ").Append(Namespaced).Append("\n");
      
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      
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
