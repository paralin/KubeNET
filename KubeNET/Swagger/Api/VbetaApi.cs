using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using KubeNET.Swagger.Client;
using KubeNET.Swagger.Model;

namespace KubeNET.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVbetaApi
    {
        
        /// <summary>
        /// get available resources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        void GetAPIResources ();
  
        /// <summary>
        /// get available resources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        System.Threading.Tasks.Task GetAPIResourcesAsync ();
        
        /// <summary>
        /// list or watch objects of kind HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1HorizontalPodAutoscalerList</returns>
        V1beta1HorizontalPodAutoscalerList ListHorizontalPodAutoscaler (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
  
        /// <summary>
        /// list or watch objects of kind HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1HorizontalPodAutoscalerList</returns>
        System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscalerList> ListHorizontalPodAutoscalerAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
        
        /// <summary>
        /// list or watch objects of kind Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1IngressList</returns>
        V1beta1IngressList ListIngress (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
  
        /// <summary>
        /// list or watch objects of kind Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1IngressList</returns>
        System.Threading.Tasks.Task<V1beta1IngressList> ListIngressAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
        
        /// <summary>
        /// list or watch objects of kind Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1JobList</returns>
        V1beta1JobList ListJob (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
  
        /// <summary>
        /// list or watch objects of kind Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1JobList</returns>
        System.Threading.Tasks.Task<V1beta1JobList> ListJobAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
        
        /// <summary>
        /// list or watch objects of kind HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1HorizontalPodAutoscalerList</returns>
        V1beta1HorizontalPodAutoscalerList ListNamespacedHorizontalPodAutoscaler (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
  
        /// <summary>
        /// list or watch objects of kind HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1HorizontalPodAutoscalerList</returns>
        System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscalerList> ListNamespacedHorizontalPodAutoscalerAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
        
        /// <summary>
        /// create a HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        V1beta1HorizontalPodAutoscaler CreateNamespacedHorizontalPodAutoscaler (V1beta1HorizontalPodAutoscaler body, string _namespace, string pretty);
  
        /// <summary>
        /// create a HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscaler> CreateNamespacedHorizontalPodAutoscalerAsync (V1beta1HorizontalPodAutoscaler body, string _namespace, string pretty);
        
        /// <summary>
        /// read the specified HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        V1beta1HorizontalPodAutoscaler ReadNamespacedHorizontalPodAutoscaler (string _namespace, string name, string pretty);
  
        /// <summary>
        /// read the specified HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscaler> ReadNamespacedHorizontalPodAutoscalerAsync (string _namespace, string name, string pretty);
        
        /// <summary>
        /// replace the specified HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        V1beta1HorizontalPodAutoscaler ReplaceNamespacedHorizontalPodAutoscaler (V1beta1HorizontalPodAutoscaler body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// replace the specified HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscaler> ReplaceNamespacedHorizontalPodAutoscalerAsync (V1beta1HorizontalPodAutoscaler body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// delete a HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        UnversionedStatus DeleteNamespacedHorizontalPodAutoscaler (V1DeleteOptions body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// delete a HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        System.Threading.Tasks.Task<UnversionedStatus> DeleteNamespacedHorizontalPodAutoscalerAsync (V1DeleteOptions body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// partially update the specified HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        V1beta1HorizontalPodAutoscaler PatchNamespacedHorizontalPodAutoscaler (UnversionedPatch body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// partially update the specified HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscaler> PatchNamespacedHorizontalPodAutoscalerAsync (UnversionedPatch body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// replace status of the specified HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        V1beta1HorizontalPodAutoscaler ReplaceNamespacedHorizontalPodAutoscalerStatus (V1beta1HorizontalPodAutoscaler body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// replace status of the specified HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscaler> ReplaceNamespacedHorizontalPodAutoscalerStatusAsync (V1beta1HorizontalPodAutoscaler body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// list or watch objects of kind Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1IngressList</returns>
        V1beta1IngressList ListNamespacedIngress (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
  
        /// <summary>
        /// list or watch objects of kind Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1IngressList</returns>
        System.Threading.Tasks.Task<V1beta1IngressList> ListNamespacedIngressAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
        
        /// <summary>
        /// create a Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Ingress</returns>
        V1beta1Ingress CreateNamespacedIngress (V1beta1Ingress body, string _namespace, string pretty);
  
        /// <summary>
        /// create a Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Ingress</returns>
        System.Threading.Tasks.Task<V1beta1Ingress> CreateNamespacedIngressAsync (V1beta1Ingress body, string _namespace, string pretty);
        
        /// <summary>
        /// read the specified Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Ingress</returns>
        V1beta1Ingress ReadNamespacedIngress (string _namespace, string name, string pretty);
  
        /// <summary>
        /// read the specified Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Ingress</returns>
        System.Threading.Tasks.Task<V1beta1Ingress> ReadNamespacedIngressAsync (string _namespace, string name, string pretty);
        
        /// <summary>
        /// replace the specified Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Ingress</returns>
        V1beta1Ingress ReplaceNamespacedIngress (V1beta1Ingress body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// replace the specified Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Ingress</returns>
        System.Threading.Tasks.Task<V1beta1Ingress> ReplaceNamespacedIngressAsync (V1beta1Ingress body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// delete a Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        UnversionedStatus DeleteNamespacedIngress (V1DeleteOptions body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// delete a Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        System.Threading.Tasks.Task<UnversionedStatus> DeleteNamespacedIngressAsync (V1DeleteOptions body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// partially update the specified Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Ingress</returns>
        V1beta1Ingress PatchNamespacedIngress (UnversionedPatch body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// partially update the specified Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Ingress</returns>
        System.Threading.Tasks.Task<V1beta1Ingress> PatchNamespacedIngressAsync (UnversionedPatch body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// replace status of the specified Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Ingress</returns>
        V1beta1Ingress ReplaceNamespacedIngressStatus (V1beta1Ingress body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// replace status of the specified Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Ingress</returns>
        System.Threading.Tasks.Task<V1beta1Ingress> ReplaceNamespacedIngressStatusAsync (V1beta1Ingress body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// list or watch objects of kind Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1JobList</returns>
        V1beta1JobList ListNamespacedJob (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
  
        /// <summary>
        /// list or watch objects of kind Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1JobList</returns>
        System.Threading.Tasks.Task<V1beta1JobList> ListNamespacedJobAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
        
        /// <summary>
        /// create a Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Job</returns>
        V1beta1Job CreateNamespacedJob (V1beta1Job body, string _namespace, string pretty);
  
        /// <summary>
        /// create a Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Job</returns>
        System.Threading.Tasks.Task<V1beta1Job> CreateNamespacedJobAsync (V1beta1Job body, string _namespace, string pretty);
        
        /// <summary>
        /// read the specified Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Job</returns>
        V1beta1Job ReadNamespacedJob (string _namespace, string name, string pretty);
  
        /// <summary>
        /// read the specified Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Job</returns>
        System.Threading.Tasks.Task<V1beta1Job> ReadNamespacedJobAsync (string _namespace, string name, string pretty);
        
        /// <summary>
        /// replace the specified Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Job</returns>
        V1beta1Job ReplaceNamespacedJob (V1beta1Job body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// replace the specified Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Job</returns>
        System.Threading.Tasks.Task<V1beta1Job> ReplaceNamespacedJobAsync (V1beta1Job body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// delete a Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        UnversionedStatus DeleteNamespacedJob (V1DeleteOptions body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// delete a Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        System.Threading.Tasks.Task<UnversionedStatus> DeleteNamespacedJobAsync (V1DeleteOptions body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// partially update the specified Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Job</returns>
        V1beta1Job PatchNamespacedJob (UnversionedPatch body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// partially update the specified Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Job</returns>
        System.Threading.Tasks.Task<V1beta1Job> PatchNamespacedJobAsync (UnversionedPatch body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// replace status of the specified Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Job</returns>
        V1beta1Job ReplaceNamespacedJobStatus (V1beta1Job body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// replace status of the specified Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Job</returns>
        System.Threading.Tasks.Task<V1beta1Job> ReplaceNamespacedJobStatusAsync (V1beta1Job body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// read scale of the specified Scale
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Scale</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Scale</returns>
        V1beta1Scale ReadNamespacedScaleScale (string _namespace, string name, string pretty);
  
        /// <summary>
        /// read scale of the specified Scale
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Scale</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Scale</returns>
        System.Threading.Tasks.Task<V1beta1Scale> ReadNamespacedScaleScaleAsync (string _namespace, string name, string pretty);
        
        /// <summary>
        /// replace scale of the specified Scale
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Scale</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Scale</returns>
        V1beta1Scale ReplaceNamespacedScaleScale (V1beta1Scale body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// replace scale of the specified Scale
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Scale</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Scale</returns>
        System.Threading.Tasks.Task<V1beta1Scale> ReplaceNamespacedScaleScaleAsync (V1beta1Scale body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// partially update scale of the specified Scale
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Scale</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Scale</returns>
        V1beta1Scale PatchNamespacedScaleScale (UnversionedPatch body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// partially update scale of the specified Scale
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Scale</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Scale</returns>
        System.Threading.Tasks.Task<V1beta1Scale> PatchNamespacedScaleScaleAsync (UnversionedPatch body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// watch individual changes to a list of HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        JsonWatchEvent WatchHorizontalPodAutoscalerList (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
  
        /// <summary>
        /// watch individual changes to a list of HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        System.Threading.Tasks.Task<JsonWatchEvent> WatchHorizontalPodAutoscalerListAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
        
        /// <summary>
        /// watch individual changes to a list of Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        JsonWatchEvent WatchIngressList (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
  
        /// <summary>
        /// watch individual changes to a list of Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        System.Threading.Tasks.Task<JsonWatchEvent> WatchIngressListAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
        
        /// <summary>
        /// watch individual changes to a list of Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        JsonWatchEvent WatchJobList (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
  
        /// <summary>
        /// watch individual changes to a list of Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        System.Threading.Tasks.Task<JsonWatchEvent> WatchJobListAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
        
        /// <summary>
        /// watch individual changes to a list of HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        JsonWatchEvent WatchNamespacedHorizontalPodAutoscalerList (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
  
        /// <summary>
        /// watch individual changes to a list of HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedHorizontalPodAutoscalerListAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
        
        /// <summary>
        /// watch changes to an object of kind HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        JsonWatchEvent WatchNamespacedHorizontalPodAutoscaler (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
  
        /// <summary>
        /// watch changes to an object of kind HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedHorizontalPodAutoscalerAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
        
        /// <summary>
        /// watch individual changes to a list of Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        JsonWatchEvent WatchNamespacedIngressList (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
  
        /// <summary>
        /// watch individual changes to a list of Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedIngressListAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
        
        /// <summary>
        /// watch changes to an object of kind Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        JsonWatchEvent WatchNamespacedIngress (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
  
        /// <summary>
        /// watch changes to an object of kind Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedIngressAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
        
        /// <summary>
        /// watch individual changes to a list of Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        JsonWatchEvent WatchNamespacedJobList (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
  
        /// <summary>
        /// watch individual changes to a list of Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedJobListAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
        
        /// <summary>
        /// watch changes to an object of kind Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        JsonWatchEvent WatchNamespacedJob (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
  
        /// <summary>
        /// watch changes to an object of kind Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedJobAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VbetaApi : IVbetaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VbetaApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VbetaApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VbetaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VbetaApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// get available resources 
        /// </summary>
        /// <returns></returns>            
        public void GetAPIResources ()
        {
            
    
            var path_ = "/apis/extensions/v1beta1";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAPIResources: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAPIResources: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// get available resources 
        /// </summary>
        /// <returns></returns>
        public async System.Threading.Tasks.Task GetAPIResourcesAsync ()
        {
            
    
            var path_ = "/apis/extensions/v1beta1";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAPIResources: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// list or watch objects of kind HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>V1beta1HorizontalPodAutoscalerList</returns>            
        public V1beta1HorizontalPodAutoscalerList ListHorizontalPodAutoscaler (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/horizontalpodautoscalers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListHorizontalPodAutoscaler: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListHorizontalPodAutoscaler: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1HorizontalPodAutoscalerList) ApiClient.Deserialize(response, typeof(V1beta1HorizontalPodAutoscalerList));
        }
    
        /// <summary>
        /// list or watch objects of kind HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1HorizontalPodAutoscalerList</returns>
        public async System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscalerList> ListHorizontalPodAutoscalerAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/horizontalpodautoscalers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListHorizontalPodAutoscaler: " + response.Content, response.Content);

            return (V1beta1HorizontalPodAutoscalerList) ApiClient.Deserialize(response, typeof(V1beta1HorizontalPodAutoscalerList));
        }
        
        /// <summary>
        /// list or watch objects of kind Ingress 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>V1beta1IngressList</returns>            
        public V1beta1IngressList ListIngress (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/ingresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1IngressList) ApiClient.Deserialize(response, typeof(V1beta1IngressList));
        }
    
        /// <summary>
        /// list or watch objects of kind Ingress 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1IngressList</returns>
        public async System.Threading.Tasks.Task<V1beta1IngressList> ListIngressAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/ingresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListIngress: " + response.Content, response.Content);

            return (V1beta1IngressList) ApiClient.Deserialize(response, typeof(V1beta1IngressList));
        }
        
        /// <summary>
        /// list or watch objects of kind Job 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>V1beta1JobList</returns>            
        public V1beta1JobList ListJob (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/jobs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1JobList) ApiClient.Deserialize(response, typeof(V1beta1JobList));
        }
    
        /// <summary>
        /// list or watch objects of kind Job 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1JobList</returns>
        public async System.Threading.Tasks.Task<V1beta1JobList> ListJobAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/jobs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListJob: " + response.Content, response.Content);

            return (V1beta1JobList) ApiClient.Deserialize(response, typeof(V1beta1JobList));
        }
        
        /// <summary>
        /// list or watch objects of kind HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>V1beta1HorizontalPodAutoscalerList</returns>            
        public V1beta1HorizontalPodAutoscalerList ListNamespacedHorizontalPodAutoscaler (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedHorizontalPodAutoscaler");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedHorizontalPodAutoscaler: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1HorizontalPodAutoscalerList) ApiClient.Deserialize(response, typeof(V1beta1HorizontalPodAutoscalerList));
        }
    
        /// <summary>
        /// list or watch objects of kind HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1HorizontalPodAutoscalerList</returns>
        public async System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscalerList> ListNamespacedHorizontalPodAutoscalerAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedHorizontalPodAutoscaler");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);

            return (V1beta1HorizontalPodAutoscalerList) ApiClient.Deserialize(response, typeof(V1beta1HorizontalPodAutoscalerList));
        }
        
        /// <summary>
        /// create a HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>            
        public V1beta1HorizontalPodAutoscaler CreateNamespacedHorizontalPodAutoscaler (V1beta1HorizontalPodAutoscaler body, string _namespace, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNamespacedHorizontalPodAutoscaler");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateNamespacedHorizontalPodAutoscaler");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedHorizontalPodAutoscaler: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1HorizontalPodAutoscaler) ApiClient.Deserialize(response, typeof(V1beta1HorizontalPodAutoscaler));
        }
    
        /// <summary>
        /// create a HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        public async System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscaler> CreateNamespacedHorizontalPodAutoscalerAsync (V1beta1HorizontalPodAutoscaler body, string _namespace, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNamespacedHorizontalPodAutoscaler");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateNamespacedHorizontalPodAutoscaler");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);

            return (V1beta1HorizontalPodAutoscaler) ApiClient.Deserialize(response, typeof(V1beta1HorizontalPodAutoscaler));
        }
        
        /// <summary>
        /// read the specified HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the HorizontalPodAutoscaler</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>            
        public V1beta1HorizontalPodAutoscaler ReadNamespacedHorizontalPodAutoscaler (string _namespace, string name, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedHorizontalPodAutoscaler");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedHorizontalPodAutoscaler");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedHorizontalPodAutoscaler: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1HorizontalPodAutoscaler) ApiClient.Deserialize(response, typeof(V1beta1HorizontalPodAutoscaler));
        }
    
        /// <summary>
        /// read the specified HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        public async System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscaler> ReadNamespacedHorizontalPodAutoscalerAsync (string _namespace, string name, string pretty)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedHorizontalPodAutoscaler");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedHorizontalPodAutoscaler");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);

            return (V1beta1HorizontalPodAutoscaler) ApiClient.Deserialize(response, typeof(V1beta1HorizontalPodAutoscaler));
        }
        
        /// <summary>
        /// replace the specified HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the HorizontalPodAutoscaler</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>            
        public V1beta1HorizontalPodAutoscaler ReplaceNamespacedHorizontalPodAutoscaler (V1beta1HorizontalPodAutoscaler body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedHorizontalPodAutoscaler");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedHorizontalPodAutoscaler");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedHorizontalPodAutoscaler");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedHorizontalPodAutoscaler: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1HorizontalPodAutoscaler) ApiClient.Deserialize(response, typeof(V1beta1HorizontalPodAutoscaler));
        }
    
        /// <summary>
        /// replace the specified HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        public async System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscaler> ReplaceNamespacedHorizontalPodAutoscalerAsync (V1beta1HorizontalPodAutoscaler body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedHorizontalPodAutoscaler");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedHorizontalPodAutoscaler");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedHorizontalPodAutoscaler");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);

            return (V1beta1HorizontalPodAutoscaler) ApiClient.Deserialize(response, typeof(V1beta1HorizontalPodAutoscaler));
        }
        
        /// <summary>
        /// delete a HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the HorizontalPodAutoscaler</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>UnversionedStatus</returns>            
        public UnversionedStatus DeleteNamespacedHorizontalPodAutoscaler (V1DeleteOptions body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteNamespacedHorizontalPodAutoscaler");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteNamespacedHorizontalPodAutoscaler");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNamespacedHorizontalPodAutoscaler");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedHorizontalPodAutoscaler: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
    
        /// <summary>
        /// delete a HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        public async System.Threading.Tasks.Task<UnversionedStatus> DeleteNamespacedHorizontalPodAutoscalerAsync (V1DeleteOptions body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteNamespacedHorizontalPodAutoscaler");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteNamespacedHorizontalPodAutoscaler");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNamespacedHorizontalPodAutoscaler");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);

            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
        
        /// <summary>
        /// partially update the specified HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the HorizontalPodAutoscaler</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>            
        public V1beta1HorizontalPodAutoscaler PatchNamespacedHorizontalPodAutoscaler (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedHorizontalPodAutoscaler");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedHorizontalPodAutoscaler");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedHorizontalPodAutoscaler");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedHorizontalPodAutoscaler: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1HorizontalPodAutoscaler) ApiClient.Deserialize(response, typeof(V1beta1HorizontalPodAutoscaler));
        }
    
        /// <summary>
        /// partially update the specified HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        public async System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscaler> PatchNamespacedHorizontalPodAutoscalerAsync (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedHorizontalPodAutoscaler");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedHorizontalPodAutoscaler");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedHorizontalPodAutoscaler");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);

            return (V1beta1HorizontalPodAutoscaler) ApiClient.Deserialize(response, typeof(V1beta1HorizontalPodAutoscaler));
        }
        
        /// <summary>
        /// replace status of the specified HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the HorizontalPodAutoscaler</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>            
        public V1beta1HorizontalPodAutoscaler ReplaceNamespacedHorizontalPodAutoscalerStatus (V1beta1HorizontalPodAutoscaler body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedHorizontalPodAutoscalerStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedHorizontalPodAutoscalerStatus");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedHorizontalPodAutoscalerStatus");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers/{name}/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedHorizontalPodAutoscalerStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedHorizontalPodAutoscalerStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1HorizontalPodAutoscaler) ApiClient.Deserialize(response, typeof(V1beta1HorizontalPodAutoscaler));
        }
    
        /// <summary>
        /// replace status of the specified HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        public async System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscaler> ReplaceNamespacedHorizontalPodAutoscalerStatusAsync (V1beta1HorizontalPodAutoscaler body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedHorizontalPodAutoscalerStatus");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedHorizontalPodAutoscalerStatus");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedHorizontalPodAutoscalerStatus");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers/{name}/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedHorizontalPodAutoscalerStatus: " + response.Content, response.Content);

            return (V1beta1HorizontalPodAutoscaler) ApiClient.Deserialize(response, typeof(V1beta1HorizontalPodAutoscaler));
        }
        
        /// <summary>
        /// list or watch objects of kind Ingress 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>V1beta1IngressList</returns>            
        public V1beta1IngressList ListNamespacedIngress (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedIngress");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1IngressList) ApiClient.Deserialize(response, typeof(V1beta1IngressList));
        }
    
        /// <summary>
        /// list or watch objects of kind Ingress 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1IngressList</returns>
        public async System.Threading.Tasks.Task<V1beta1IngressList> ListNamespacedIngressAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedIngress");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedIngress: " + response.Content, response.Content);

            return (V1beta1IngressList) ApiClient.Deserialize(response, typeof(V1beta1IngressList));
        }
        
        /// <summary>
        /// create a Ingress 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Ingress</returns>            
        public V1beta1Ingress CreateNamespacedIngress (V1beta1Ingress body, string _namespace, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNamespacedIngress");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateNamespacedIngress");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Ingress) ApiClient.Deserialize(response, typeof(V1beta1Ingress));
        }
    
        /// <summary>
        /// create a Ingress 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Ingress</returns>
        public async System.Threading.Tasks.Task<V1beta1Ingress> CreateNamespacedIngressAsync (V1beta1Ingress body, string _namespace, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNamespacedIngress");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateNamespacedIngress");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedIngress: " + response.Content, response.Content);

            return (V1beta1Ingress) ApiClient.Deserialize(response, typeof(V1beta1Ingress));
        }
        
        /// <summary>
        /// read the specified Ingress 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Ingress</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Ingress</returns>            
        public V1beta1Ingress ReadNamespacedIngress (string _namespace, string name, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedIngress");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedIngress");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Ingress) ApiClient.Deserialize(response, typeof(V1beta1Ingress));
        }
    
        /// <summary>
        /// read the specified Ingress 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Ingress</returns>
        public async System.Threading.Tasks.Task<V1beta1Ingress> ReadNamespacedIngressAsync (string _namespace, string name, string pretty)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedIngress");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedIngress");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedIngress: " + response.Content, response.Content);

            return (V1beta1Ingress) ApiClient.Deserialize(response, typeof(V1beta1Ingress));
        }
        
        /// <summary>
        /// replace the specified Ingress 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Ingress</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Ingress</returns>            
        public V1beta1Ingress ReplaceNamespacedIngress (V1beta1Ingress body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedIngress");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedIngress");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedIngress");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Ingress) ApiClient.Deserialize(response, typeof(V1beta1Ingress));
        }
    
        /// <summary>
        /// replace the specified Ingress 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Ingress</returns>
        public async System.Threading.Tasks.Task<V1beta1Ingress> ReplaceNamespacedIngressAsync (V1beta1Ingress body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedIngress");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedIngress");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedIngress");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedIngress: " + response.Content, response.Content);

            return (V1beta1Ingress) ApiClient.Deserialize(response, typeof(V1beta1Ingress));
        }
        
        /// <summary>
        /// delete a Ingress 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Ingress</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>UnversionedStatus</returns>            
        public UnversionedStatus DeleteNamespacedIngress (V1DeleteOptions body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteNamespacedIngress");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteNamespacedIngress");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNamespacedIngress");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
    
        /// <summary>
        /// delete a Ingress 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        public async System.Threading.Tasks.Task<UnversionedStatus> DeleteNamespacedIngressAsync (V1DeleteOptions body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteNamespacedIngress");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteNamespacedIngress");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNamespacedIngress");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedIngress: " + response.Content, response.Content);

            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
        
        /// <summary>
        /// partially update the specified Ingress 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Ingress</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Ingress</returns>            
        public V1beta1Ingress PatchNamespacedIngress (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedIngress");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedIngress");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedIngress");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Ingress) ApiClient.Deserialize(response, typeof(V1beta1Ingress));
        }
    
        /// <summary>
        /// partially update the specified Ingress 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Ingress</returns>
        public async System.Threading.Tasks.Task<V1beta1Ingress> PatchNamespacedIngressAsync (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedIngress");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedIngress");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedIngress");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedIngress: " + response.Content, response.Content);

            return (V1beta1Ingress) ApiClient.Deserialize(response, typeof(V1beta1Ingress));
        }
        
        /// <summary>
        /// replace status of the specified Ingress 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Ingress</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Ingress</returns>            
        public V1beta1Ingress ReplaceNamespacedIngressStatus (V1beta1Ingress body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedIngressStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedIngressStatus");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedIngressStatus");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedIngressStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedIngressStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Ingress) ApiClient.Deserialize(response, typeof(V1beta1Ingress));
        }
    
        /// <summary>
        /// replace status of the specified Ingress 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Ingress</returns>
        public async System.Threading.Tasks.Task<V1beta1Ingress> ReplaceNamespacedIngressStatusAsync (V1beta1Ingress body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedIngressStatus");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedIngressStatus");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedIngressStatus");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedIngressStatus: " + response.Content, response.Content);

            return (V1beta1Ingress) ApiClient.Deserialize(response, typeof(V1beta1Ingress));
        }
        
        /// <summary>
        /// list or watch objects of kind Job 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>V1beta1JobList</returns>            
        public V1beta1JobList ListNamespacedJob (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedJob");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1JobList) ApiClient.Deserialize(response, typeof(V1beta1JobList));
        }
    
        /// <summary>
        /// list or watch objects of kind Job 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1JobList</returns>
        public async System.Threading.Tasks.Task<V1beta1JobList> ListNamespacedJobAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedJob");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedJob: " + response.Content, response.Content);

            return (V1beta1JobList) ApiClient.Deserialize(response, typeof(V1beta1JobList));
        }
        
        /// <summary>
        /// create a Job 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Job</returns>            
        public V1beta1Job CreateNamespacedJob (V1beta1Job body, string _namespace, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNamespacedJob");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateNamespacedJob");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Job) ApiClient.Deserialize(response, typeof(V1beta1Job));
        }
    
        /// <summary>
        /// create a Job 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Job</returns>
        public async System.Threading.Tasks.Task<V1beta1Job> CreateNamespacedJobAsync (V1beta1Job body, string _namespace, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNamespacedJob");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateNamespacedJob");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedJob: " + response.Content, response.Content);

            return (V1beta1Job) ApiClient.Deserialize(response, typeof(V1beta1Job));
        }
        
        /// <summary>
        /// read the specified Job 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Job</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Job</returns>            
        public V1beta1Job ReadNamespacedJob (string _namespace, string name, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedJob");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedJob");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Job) ApiClient.Deserialize(response, typeof(V1beta1Job));
        }
    
        /// <summary>
        /// read the specified Job 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Job</returns>
        public async System.Threading.Tasks.Task<V1beta1Job> ReadNamespacedJobAsync (string _namespace, string name, string pretty)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedJob");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedJob");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedJob: " + response.Content, response.Content);

            return (V1beta1Job) ApiClient.Deserialize(response, typeof(V1beta1Job));
        }
        
        /// <summary>
        /// replace the specified Job 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Job</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Job</returns>            
        public V1beta1Job ReplaceNamespacedJob (V1beta1Job body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedJob");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedJob");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedJob");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Job) ApiClient.Deserialize(response, typeof(V1beta1Job));
        }
    
        /// <summary>
        /// replace the specified Job 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Job</returns>
        public async System.Threading.Tasks.Task<V1beta1Job> ReplaceNamespacedJobAsync (V1beta1Job body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedJob");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedJob");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedJob");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedJob: " + response.Content, response.Content);

            return (V1beta1Job) ApiClient.Deserialize(response, typeof(V1beta1Job));
        }
        
        /// <summary>
        /// delete a Job 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Job</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>UnversionedStatus</returns>            
        public UnversionedStatus DeleteNamespacedJob (V1DeleteOptions body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteNamespacedJob");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteNamespacedJob");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNamespacedJob");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
    
        /// <summary>
        /// delete a Job 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        public async System.Threading.Tasks.Task<UnversionedStatus> DeleteNamespacedJobAsync (V1DeleteOptions body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteNamespacedJob");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteNamespacedJob");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNamespacedJob");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedJob: " + response.Content, response.Content);

            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
        
        /// <summary>
        /// partially update the specified Job 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Job</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Job</returns>            
        public V1beta1Job PatchNamespacedJob (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedJob");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedJob");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedJob");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Job) ApiClient.Deserialize(response, typeof(V1beta1Job));
        }
    
        /// <summary>
        /// partially update the specified Job 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Job</returns>
        public async System.Threading.Tasks.Task<V1beta1Job> PatchNamespacedJobAsync (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedJob");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedJob");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedJob");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedJob: " + response.Content, response.Content);

            return (V1beta1Job) ApiClient.Deserialize(response, typeof(V1beta1Job));
        }
        
        /// <summary>
        /// replace status of the specified Job 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Job</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Job</returns>            
        public V1beta1Job ReplaceNamespacedJobStatus (V1beta1Job body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedJobStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedJobStatus");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedJobStatus");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs/{name}/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedJobStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedJobStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Job) ApiClient.Deserialize(response, typeof(V1beta1Job));
        }
    
        /// <summary>
        /// replace status of the specified Job 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Job</returns>
        public async System.Threading.Tasks.Task<V1beta1Job> ReplaceNamespacedJobStatusAsync (V1beta1Job body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedJobStatus");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedJobStatus");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedJobStatus");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs/{name}/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedJobStatus: " + response.Content, response.Content);

            return (V1beta1Job) ApiClient.Deserialize(response, typeof(V1beta1Job));
        }
        
        /// <summary>
        /// read scale of the specified Scale 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Scale</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Scale</returns>            
        public V1beta1Scale ReadNamespacedScaleScale (string _namespace, string name, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedScaleScale");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedScaleScale");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedScaleScale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedScaleScale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Scale) ApiClient.Deserialize(response, typeof(V1beta1Scale));
        }
    
        /// <summary>
        /// read scale of the specified Scale 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Scale</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Scale</returns>
        public async System.Threading.Tasks.Task<V1beta1Scale> ReadNamespacedScaleScaleAsync (string _namespace, string name, string pretty)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedScaleScale");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedScaleScale");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedScaleScale: " + response.Content, response.Content);

            return (V1beta1Scale) ApiClient.Deserialize(response, typeof(V1beta1Scale));
        }
        
        /// <summary>
        /// replace scale of the specified Scale 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Scale</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Scale</returns>            
        public V1beta1Scale ReplaceNamespacedScaleScale (V1beta1Scale body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedScaleScale");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedScaleScale");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedScaleScale");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedScaleScale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedScaleScale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Scale) ApiClient.Deserialize(response, typeof(V1beta1Scale));
        }
    
        /// <summary>
        /// replace scale of the specified Scale 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Scale</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Scale</returns>
        public async System.Threading.Tasks.Task<V1beta1Scale> ReplaceNamespacedScaleScaleAsync (V1beta1Scale body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedScaleScale");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedScaleScale");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedScaleScale");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedScaleScale: " + response.Content, response.Content);

            return (V1beta1Scale) ApiClient.Deserialize(response, typeof(V1beta1Scale));
        }
        
        /// <summary>
        /// partially update scale of the specified Scale 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Scale</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Scale</returns>            
        public V1beta1Scale PatchNamespacedScaleScale (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedScaleScale");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedScaleScale");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedScaleScale");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedScaleScale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedScaleScale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Scale) ApiClient.Deserialize(response, typeof(V1beta1Scale));
        }
    
        /// <summary>
        /// partially update scale of the specified Scale 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Scale</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Scale</returns>
        public async System.Threading.Tasks.Task<V1beta1Scale> PatchNamespacedScaleScaleAsync (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedScaleScale");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedScaleScale");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedScaleScale");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedScaleScale: " + response.Content, response.Content);

            return (V1beta1Scale) ApiClient.Deserialize(response, typeof(V1beta1Scale));
        }
        
        /// <summary>
        /// watch individual changes to a list of HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchHorizontalPodAutoscalerList (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/watch/horizontalpodautoscalers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchHorizontalPodAutoscalerList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchHorizontalPodAutoscalerList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch individual changes to a list of HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchHorizontalPodAutoscalerListAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/watch/horizontalpodautoscalers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchHorizontalPodAutoscalerList: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch individual changes to a list of Ingress 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchIngressList (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/watch/ingresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchIngressList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchIngressList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch individual changes to a list of Ingress 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchIngressListAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/watch/ingresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchIngressList: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch individual changes to a list of Job 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchJobList (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/watch/jobs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchJobList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchJobList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch individual changes to a list of Job 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchJobListAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/watch/jobs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchJobList: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch individual changes to a list of HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedHorizontalPodAutoscalerList (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedHorizontalPodAutoscalerList");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/horizontalpodautoscalers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedHorizontalPodAutoscalerList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedHorizontalPodAutoscalerList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch individual changes to a list of HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedHorizontalPodAutoscalerListAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedHorizontalPodAutoscalerList");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/horizontalpodautoscalers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedHorizontalPodAutoscalerList: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch changes to an object of kind HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the HorizontalPodAutoscaler</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedHorizontalPodAutoscaler (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedHorizontalPodAutoscaler");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchNamespacedHorizontalPodAutoscaler");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/horizontalpodautoscalers/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedHorizontalPodAutoscaler: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch changes to an object of kind HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedHorizontalPodAutoscalerAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedHorizontalPodAutoscaler");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchNamespacedHorizontalPodAutoscaler");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/horizontalpodautoscalers/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch individual changes to a list of Ingress 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedIngressList (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedIngressList");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/ingresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedIngressList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedIngressList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch individual changes to a list of Ingress 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedIngressListAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedIngressList");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/ingresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedIngressList: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch changes to an object of kind Ingress 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Ingress</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedIngress (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedIngress");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchNamespacedIngress");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/ingresses/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch changes to an object of kind Ingress 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedIngressAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedIngress");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchNamespacedIngress");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/ingresses/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedIngress: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch individual changes to a list of Job 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedJobList (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedJobList");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/jobs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedJobList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedJobList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch individual changes to a list of Job 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedJobListAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedJobList");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/jobs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedJobList: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch changes to an object of kind Job 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Job</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedJob (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedJob");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchNamespacedJob");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/jobs/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch changes to an object of kind Job 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedJobAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, string timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedJob");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchNamespacedJob");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/jobs/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (_namespace != null) pathParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // path parameter
            if (name != null) pathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            
            if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
            if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
            if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
            if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
            if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
            if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedJob: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
    }
    
}
