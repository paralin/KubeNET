using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// Event is a report of an event somewhere in the cluster.
  /// </summary>
  [DataContract]
  public class V1Event {
    
    /// <summary>
    /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds
    /// </summary>
    /// <value>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    public string Kind { get; set; }

    
    /// <summary>
    /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources
    /// </summary>
    /// <value>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources</value>
    [DataMember(Name="apiVersion", EmitDefaultValue=false)]
    public string ApiVersion { get; set; }

    
    /// <summary>
    /// Standard object's metadata. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#metadata
    /// </summary>
    /// <value>Standard object's metadata. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#metadata</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    public V1ObjectMeta Metadata { get; set; }

    
    /// <summary>
    /// The object that this event is about.
    /// </summary>
    /// <value>The object that this event is about.</value>
    [DataMember(Name="involvedObject", EmitDefaultValue=false)]
    public V1ObjectReference InvolvedObject { get; set; }

    
    /// <summary>
    /// This should be a short, machine understandable string that gives the reason for the transition into the object's current status.
    /// </summary>
    /// <value>This should be a short, machine understandable string that gives the reason for the transition into the object's current status.</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    public string Reason { get; set; }

    
    /// <summary>
    /// A human-readable description of the status of this operation.
    /// </summary>
    /// <value>A human-readable description of the status of this operation.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    
    /// <summary>
    /// The component reporting this event. Should be a short machine understandable string.
    /// </summary>
    /// <value>The component reporting this event. Should be a short machine understandable string.</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    public V1EventSource Source { get; set; }

    
    /// <summary>
    /// The time at which the event was first recorded. (Time of server receipt is in TypeMeta.)
    /// </summary>
    /// <value>The time at which the event was first recorded. (Time of server receipt is in TypeMeta.)</value>
    [DataMember(Name="firstTimestamp", EmitDefaultValue=false)]
    public string FirstTimestamp { get; set; }

    
    /// <summary>
    /// The time at which the most recent occurrence of this event was recorded.
    /// </summary>
    /// <value>The time at which the most recent occurrence of this event was recorded.</value>
    [DataMember(Name="lastTimestamp", EmitDefaultValue=false)]
    public string LastTimestamp { get; set; }

    
    /// <summary>
    /// The number of times this event has occurred.
    /// </summary>
    /// <value>The number of times this event has occurred.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    public int? Count { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1Event {\n");
      
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      
      sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
      
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
      
      sb.Append("  InvolvedObject: ").Append(InvolvedObject).Append("\n");
      
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  FirstTimestamp: ").Append(FirstTimestamp).Append("\n");
      
      sb.Append("  LastTimestamp: ").Append(LastTimestamp).Append("\n");
      
      sb.Append("  Count: ").Append(Count).Append("\n");
      
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
