using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// A single application container that you want to run within a pod.
  /// </summary>
  [DataContract]
  public class V1Container {
    
    /// <summary>
    /// Name of the container specified as a DNS_LABEL. Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated.
    /// </summary>
    /// <value>Name of the container specified as a DNS_LABEL. Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Docker image name. More info: http://releases.k8s.io/HEAD/docs/user-guide/images.md
    /// </summary>
    /// <value>Docker image name. More info: http://releases.k8s.io/HEAD/docs/user-guide/images.md</value>
    [DataMember(Name="image", EmitDefaultValue=false)]
    public string Image { get; set; }

    
    /// <summary>
    /// Entrypoint array. Not executed within a shell. The docker image's entrypoint is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/containers.md#containers-and-commands
    /// </summary>
    /// <value>Entrypoint array. Not executed within a shell. The docker image's entrypoint is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/containers.md#containers-and-commands</value>
    [DataMember(Name="command", EmitDefaultValue=false)]
    public List<string> Command { get; set; }

    
    /// <summary>
    /// Arguments to the entrypoint. The docker image's cmd is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/containers.md#containers-and-commands
    /// </summary>
    /// <value>Arguments to the entrypoint. The docker image's cmd is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/containers.md#containers-and-commands</value>
    [DataMember(Name="args", EmitDefaultValue=false)]
    public List<string> Args { get; set; }

    
    /// <summary>
    /// Container's working directory. Defaults to Docker's default. D efaults to image's default. Cannot be updated.
    /// </summary>
    /// <value>Container's working directory. Defaults to Docker's default. D efaults to image's default. Cannot be updated.</value>
    [DataMember(Name="workingDir", EmitDefaultValue=false)]
    public string WorkingDir { get; set; }

    
    /// <summary>
    /// List of ports to expose from the container. Cannot be updated.
    /// </summary>
    /// <value>List of ports to expose from the container. Cannot be updated.</value>
    [DataMember(Name="ports", EmitDefaultValue=false)]
    public List<V1ContainerPort> Ports { get; set; }

    
    /// <summary>
    /// List of environment variables to set in the container. Cannot be updated.
    /// </summary>
    /// <value>List of environment variables to set in the container. Cannot be updated.</value>
    [DataMember(Name="env", EmitDefaultValue=false)]
    public List<V1EnvVar> Env { get; set; }

    
    /// <summary>
    /// Compute Resources required by this container. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#resources
    /// </summary>
    /// <value>Compute Resources required by this container. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/persistent-volumes.md#resources</value>
    [DataMember(Name="resources", EmitDefaultValue=false)]
    public V1ResourceRequirements Resources { get; set; }

    
    /// <summary>
    /// Pod volumes to mount into the container's filesyste. Cannot be updated.
    /// </summary>
    /// <value>Pod volumes to mount into the container's filesyste. Cannot be updated.</value>
    [DataMember(Name="volumeMounts", EmitDefaultValue=false)]
    public List<V1VolumeMount> VolumeMounts { get; set; }

    
    /// <summary>
    /// Periodic probe of container liveness. Container will be restarted if the probe fails. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#container-probes
    /// </summary>
    /// <value>Periodic probe of container liveness. Container will be restarted if the probe fails. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#container-probes</value>
    [DataMember(Name="livenessProbe", EmitDefaultValue=false)]
    public V1Probe LivenessProbe { get; set; }

    
    /// <summary>
    /// Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#container-probes
    /// </summary>
    /// <value>Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/pod-states.md#container-probes</value>
    [DataMember(Name="readinessProbe", EmitDefaultValue=false)]
    public V1Probe ReadinessProbe { get; set; }

    
    /// <summary>
    /// Actions that the management system should take in response to container lifecycle events. Cannot be updated.
    /// </summary>
    /// <value>Actions that the management system should take in response to container lifecycle events. Cannot be updated.</value>
    [DataMember(Name="lifecycle", EmitDefaultValue=false)]
    public V1Lifecycle Lifecycle { get; set; }

    
    /// <summary>
    /// Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Defaults to /dev/termination-log. Cannot be updated.
    /// </summary>
    /// <value>Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Defaults to /dev/termination-log. Cannot be updated.</value>
    [DataMember(Name="terminationMessagePath", EmitDefaultValue=false)]
    public string TerminationMessagePath { get; set; }

    
    /// <summary>
    /// Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/images.md#updating-images
    /// </summary>
    /// <value>Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/images.md#updating-images</value>
    [DataMember(Name="imagePullPolicy", EmitDefaultValue=false)]
    public string ImagePullPolicy { get; set; }

    
    /// <summary>
    /// Security options the pod should run with. More info: http://releases.k8s.io/HEAD/docs/design/security_context.md
    /// </summary>
    /// <value>Security options the pod should run with. More info: http://releases.k8s.io/HEAD/docs/design/security_context.md</value>
    [DataMember(Name="securityContext", EmitDefaultValue=false)]
    public V1SecurityContext SecurityContext { get; set; }

    
    /// <summary>
    /// Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false.
    /// </summary>
    /// <value>Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false.</value>
    [DataMember(Name="stdin", EmitDefaultValue=false)]
    public bool? Stdin { get; set; }

    
    /// <summary>
    /// Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false
    /// </summary>
    /// <value>Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false</value>
    [DataMember(Name="stdinOnce", EmitDefaultValue=false)]
    public bool? StdinOnce { get; set; }

    
    /// <summary>
    /// Whether this container should allocate a TTY for itself, also requires 'stdin' to be true. Default is false.
    /// </summary>
    /// <value>Whether this container should allocate a TTY for itself, also requires 'stdin' to be true. Default is false.</value>
    [DataMember(Name="tty", EmitDefaultValue=false)]
    public bool? Tty { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1Container {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Image: ").Append(Image).Append("\n");
      
      sb.Append("  Command: ").Append(Command).Append("\n");
      
      sb.Append("  Args: ").Append(Args).Append("\n");
      
      sb.Append("  WorkingDir: ").Append(WorkingDir).Append("\n");
      
      sb.Append("  Ports: ").Append(Ports).Append("\n");
      
      sb.Append("  Env: ").Append(Env).Append("\n");
      
      sb.Append("  Resources: ").Append(Resources).Append("\n");
      
      sb.Append("  VolumeMounts: ").Append(VolumeMounts).Append("\n");
      
      sb.Append("  LivenessProbe: ").Append(LivenessProbe).Append("\n");
      
      sb.Append("  ReadinessProbe: ").Append(ReadinessProbe).Append("\n");
      
      sb.Append("  Lifecycle: ").Append(Lifecycle).Append("\n");
      
      sb.Append("  TerminationMessagePath: ").Append(TerminationMessagePath).Append("\n");
      
      sb.Append("  ImagePullPolicy: ").Append(ImagePullPolicy).Append("\n");
      
      sb.Append("  SecurityContext: ").Append(SecurityContext).Append("\n");
      
      sb.Append("  Stdin: ").Append(Stdin).Append("\n");
      
      sb.Append("  StdinOnce: ").Append(StdinOnce).Append("\n");
      
      sb.Append("  Tty: ").Append(Tty).Append("\n");
      
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
