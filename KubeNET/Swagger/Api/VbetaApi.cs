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
        /// <returns>UnversionedAPIResourceList</returns>
        UnversionedAPIResourceList GetAPIResources ();
  
        /// <summary>
        /// get available resources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>UnversionedAPIResourceList</returns>
        System.Threading.Tasks.Task<UnversionedAPIResourceList> GetAPIResourcesAsync ();
        
        /// <summary>
        /// list or watch objects of kind DaemonSet
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
        /// <returns>V1beta1DaemonSetList</returns>
        V1beta1DaemonSetList ListNamespacedDaemonSet (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// list or watch objects of kind DaemonSet
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
        /// <returns>V1beta1DaemonSetList</returns>
        System.Threading.Tasks.Task<V1beta1DaemonSetList> ListNamespacedDaemonSetAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// list or watch objects of kind Deployment
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
        /// <returns>V1beta1DeploymentList</returns>
        V1beta1DeploymentList ListNamespacedDeployment (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// list or watch objects of kind Deployment
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
        /// <returns>V1beta1DeploymentList</returns>
        System.Threading.Tasks.Task<V1beta1DeploymentList> ListNamespacedDeploymentAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
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
        V1beta1HorizontalPodAutoscalerList ListNamespacedHorizontalPodAutoscaler (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
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
        System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscalerList> ListNamespacedHorizontalPodAutoscalerAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
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
        V1beta1IngressList ListNamespacedIngress (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
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
        System.Threading.Tasks.Task<V1beta1IngressList> ListNamespacedIngressAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
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
        V1beta1JobList ListNamespacedJob (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
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
        System.Threading.Tasks.Task<V1beta1JobList> ListNamespacedJobAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// list or watch objects of kind DaemonSet
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
        /// <returns>V1beta1DaemonSetList</returns>
        V1beta1DaemonSetList ListNamespacedDaemonSet_1 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// list or watch objects of kind DaemonSet
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
        /// <returns>V1beta1DaemonSetList</returns>
        System.Threading.Tasks.Task<V1beta1DaemonSetList> ListNamespacedDaemonSet_1Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// create a DaemonSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1DaemonSet</returns>
        V1beta1DaemonSet CreateNamespacedDaemonSet (V1beta1DaemonSet body, string _namespace, string pretty);
  
        /// <summary>
        /// create a DaemonSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1DaemonSet</returns>
        System.Threading.Tasks.Task<V1beta1DaemonSet> CreateNamespacedDaemonSetAsync (V1beta1DaemonSet body, string _namespace, string pretty);
        
        /// <summary>
        /// delete collection of DaemonSet
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
        /// <returns>UnversionedStatus</returns>
        UnversionedStatus DeletecollectionNamespacedDaemonSet (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// delete collection of DaemonSet
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
        /// <returns>UnversionedStatus</returns>
        System.Threading.Tasks.Task<UnversionedStatus> DeletecollectionNamespacedDaemonSetAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// read the specified DaemonSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1DaemonSet</returns>
        V1beta1DaemonSet ReadNamespacedDaemonSet (string _namespace, string name, string pretty, bool? export, bool? exact);
  
        /// <summary>
        /// read the specified DaemonSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1DaemonSet</returns>
        System.Threading.Tasks.Task<V1beta1DaemonSet> ReadNamespacedDaemonSetAsync (string _namespace, string name, string pretty, bool? export, bool? exact);
        
        /// <summary>
        /// replace the specified DaemonSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1DaemonSet</returns>
        V1beta1DaemonSet ReplaceNamespacedDaemonSet (V1beta1DaemonSet body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// replace the specified DaemonSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1DaemonSet</returns>
        System.Threading.Tasks.Task<V1beta1DaemonSet> ReplaceNamespacedDaemonSetAsync (V1beta1DaemonSet body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// delete a DaemonSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        UnversionedStatus DeleteNamespacedDaemonSet (V1DeleteOptions body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// delete a DaemonSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        System.Threading.Tasks.Task<UnversionedStatus> DeleteNamespacedDaemonSetAsync (V1DeleteOptions body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// partially update the specified DaemonSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1DaemonSet</returns>
        V1beta1DaemonSet PatchNamespacedDaemonSet (UnversionedPatch body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// partially update the specified DaemonSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1DaemonSet</returns>
        System.Threading.Tasks.Task<V1beta1DaemonSet> PatchNamespacedDaemonSetAsync (UnversionedPatch body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// replace status of the specified DaemonSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1DaemonSet</returns>
        V1beta1DaemonSet ReplaceNamespacedDaemonSetStatus (V1beta1DaemonSet body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// replace status of the specified DaemonSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1DaemonSet</returns>
        System.Threading.Tasks.Task<V1beta1DaemonSet> ReplaceNamespacedDaemonSetStatusAsync (V1beta1DaemonSet body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// list or watch objects of kind Deployment
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
        /// <returns>V1beta1DeploymentList</returns>
        V1beta1DeploymentList ListNamespacedDeployment_2 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// list or watch objects of kind Deployment
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
        /// <returns>V1beta1DeploymentList</returns>
        System.Threading.Tasks.Task<V1beta1DeploymentList> ListNamespacedDeployment_2Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// create a Deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Deployment</returns>
        V1beta1Deployment CreateNamespacedDeployment (V1beta1Deployment body, string _namespace, string pretty);
  
        /// <summary>
        /// create a Deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Deployment</returns>
        System.Threading.Tasks.Task<V1beta1Deployment> CreateNamespacedDeploymentAsync (V1beta1Deployment body, string _namespace, string pretty);
        
        /// <summary>
        /// delete collection of Deployment
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
        /// <returns>UnversionedStatus</returns>
        UnversionedStatus DeletecollectionNamespacedDeployment (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// delete collection of Deployment
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
        /// <returns>UnversionedStatus</returns>
        System.Threading.Tasks.Task<UnversionedStatus> DeletecollectionNamespacedDeploymentAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// read the specified Deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1Deployment</returns>
        V1beta1Deployment ReadNamespacedDeployment (string _namespace, string name, string pretty, bool? export, bool? exact);
  
        /// <summary>
        /// read the specified Deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1Deployment</returns>
        System.Threading.Tasks.Task<V1beta1Deployment> ReadNamespacedDeploymentAsync (string _namespace, string name, string pretty, bool? export, bool? exact);
        
        /// <summary>
        /// replace the specified Deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Deployment</returns>
        V1beta1Deployment ReplaceNamespacedDeployment (V1beta1Deployment body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// replace the specified Deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Deployment</returns>
        System.Threading.Tasks.Task<V1beta1Deployment> ReplaceNamespacedDeploymentAsync (V1beta1Deployment body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// delete a Deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        UnversionedStatus DeleteNamespacedDeployment (V1DeleteOptions body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// delete a Deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        System.Threading.Tasks.Task<UnversionedStatus> DeleteNamespacedDeploymentAsync (V1DeleteOptions body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// partially update the specified Deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Deployment</returns>
        V1beta1Deployment PatchNamespacedDeployment (UnversionedPatch body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// partially update the specified Deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Deployment</returns>
        System.Threading.Tasks.Task<V1beta1Deployment> PatchNamespacedDeploymentAsync (UnversionedPatch body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// create rollback of a DeploymentRollback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DeploymentRollback</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1DeploymentRollback</returns>
        V1beta1DeploymentRollback CreateNamespacedDeploymentRollbackRollback (V1beta1DeploymentRollback body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// create rollback of a DeploymentRollback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DeploymentRollback</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1DeploymentRollback</returns>
        System.Threading.Tasks.Task<V1beta1DeploymentRollback> CreateNamespacedDeploymentRollbackRollbackAsync (V1beta1DeploymentRollback body, string _namespace, string name, string pretty);
        
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
        /// replace status of the specified Deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Deployment</returns>
        V1beta1Deployment ReplaceNamespacedDeploymentStatus (V1beta1Deployment body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// replace status of the specified Deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Deployment</returns>
        System.Threading.Tasks.Task<V1beta1Deployment> ReplaceNamespacedDeploymentStatusAsync (V1beta1Deployment body, string _namespace, string name, string pretty);
        
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
        V1beta1HorizontalPodAutoscalerList ListNamespacedHorizontalPodAutoscaler_3 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
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
        System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscalerList> ListNamespacedHorizontalPodAutoscaler_3Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
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
        /// delete collection of HorizontalPodAutoscaler
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
        /// <returns>UnversionedStatus</returns>
        UnversionedStatus DeletecollectionNamespacedHorizontalPodAutoscaler (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// delete collection of HorizontalPodAutoscaler
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
        /// <returns>UnversionedStatus</returns>
        System.Threading.Tasks.Task<UnversionedStatus> DeletecollectionNamespacedHorizontalPodAutoscalerAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// read the specified HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        V1beta1HorizontalPodAutoscaler ReadNamespacedHorizontalPodAutoscaler (string _namespace, string name, string pretty, bool? export, bool? exact);
  
        /// <summary>
        /// read the specified HorizontalPodAutoscaler
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the HorizontalPodAutoscaler</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscaler> ReadNamespacedHorizontalPodAutoscalerAsync (string _namespace, string name, string pretty, bool? export, bool? exact);
        
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
        V1beta1IngressList ListNamespacedIngress_4 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
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
        System.Threading.Tasks.Task<V1beta1IngressList> ListNamespacedIngress_4Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
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
        /// delete collection of Ingress
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
        /// <returns>UnversionedStatus</returns>
        UnversionedStatus DeletecollectionNamespacedIngress (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// delete collection of Ingress
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
        /// <returns>UnversionedStatus</returns>
        System.Threading.Tasks.Task<UnversionedStatus> DeletecollectionNamespacedIngressAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// read the specified Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1Ingress</returns>
        V1beta1Ingress ReadNamespacedIngress (string _namespace, string name, string pretty, bool? export, bool? exact);
  
        /// <summary>
        /// read the specified Ingress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Ingress</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1Ingress</returns>
        System.Threading.Tasks.Task<V1beta1Ingress> ReadNamespacedIngressAsync (string _namespace, string name, string pretty, bool? export, bool? exact);
        
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
        V1beta1JobList ListNamespacedJob_5 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
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
        System.Threading.Tasks.Task<V1beta1JobList> ListNamespacedJob_5Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
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
        /// delete collection of Job
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
        /// <returns>UnversionedStatus</returns>
        UnversionedStatus DeletecollectionNamespacedJob (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// delete collection of Job
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
        /// <returns>UnversionedStatus</returns>
        System.Threading.Tasks.Task<UnversionedStatus> DeletecollectionNamespacedJobAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// read the specified Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1Job</returns>
        V1beta1Job ReadNamespacedJob (string _namespace, string name, string pretty, bool? export, bool? exact);
  
        /// <summary>
        /// read the specified Job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Job</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1Job</returns>
        System.Threading.Tasks.Task<V1beta1Job> ReadNamespacedJobAsync (string _namespace, string name, string pretty, bool? export, bool? exact);
        
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
        /// list or watch objects of kind ReplicaSet
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
        /// <returns>V1beta1ReplicaSetList</returns>
        V1beta1ReplicaSetList ListNamespacedReplicaSet (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// list or watch objects of kind ReplicaSet
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
        /// <returns>V1beta1ReplicaSetList</returns>
        System.Threading.Tasks.Task<V1beta1ReplicaSetList> ListNamespacedReplicaSetAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// create a ReplicaSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ReplicaSet</returns>
        V1beta1ReplicaSet CreateNamespacedReplicaSet (V1beta1ReplicaSet body, string _namespace, string pretty);
  
        /// <summary>
        /// create a ReplicaSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ReplicaSet</returns>
        System.Threading.Tasks.Task<V1beta1ReplicaSet> CreateNamespacedReplicaSetAsync (V1beta1ReplicaSet body, string _namespace, string pretty);
        
        /// <summary>
        /// delete collection of ReplicaSet
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
        /// <returns>UnversionedStatus</returns>
        UnversionedStatus DeletecollectionNamespacedReplicaSet (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// delete collection of ReplicaSet
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
        /// <returns>UnversionedStatus</returns>
        System.Threading.Tasks.Task<UnversionedStatus> DeletecollectionNamespacedReplicaSetAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// read the specified ReplicaSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1ReplicaSet</returns>
        V1beta1ReplicaSet ReadNamespacedReplicaSet (string _namespace, string name, string pretty, bool? export, bool? exact);
  
        /// <summary>
        /// read the specified ReplicaSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1ReplicaSet</returns>
        System.Threading.Tasks.Task<V1beta1ReplicaSet> ReadNamespacedReplicaSetAsync (string _namespace, string name, string pretty, bool? export, bool? exact);
        
        /// <summary>
        /// replace the specified ReplicaSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ReplicaSet</returns>
        V1beta1ReplicaSet ReplaceNamespacedReplicaSet (V1beta1ReplicaSet body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// replace the specified ReplicaSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ReplicaSet</returns>
        System.Threading.Tasks.Task<V1beta1ReplicaSet> ReplaceNamespacedReplicaSetAsync (V1beta1ReplicaSet body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// delete a ReplicaSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        UnversionedStatus DeleteNamespacedReplicaSet (V1DeleteOptions body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// delete a ReplicaSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        System.Threading.Tasks.Task<UnversionedStatus> DeleteNamespacedReplicaSetAsync (V1DeleteOptions body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// partially update the specified ReplicaSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ReplicaSet</returns>
        V1beta1ReplicaSet PatchNamespacedReplicaSet (UnversionedPatch body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// partially update the specified ReplicaSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ReplicaSet</returns>
        System.Threading.Tasks.Task<V1beta1ReplicaSet> PatchNamespacedReplicaSetAsync (UnversionedPatch body, string _namespace, string name, string pretty);
        
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
        V1beta1Scale ReadNamespacedScaleScale_6 (string _namespace, string name, string pretty);
  
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
        System.Threading.Tasks.Task<V1beta1Scale> ReadNamespacedScaleScale_6Async (string _namespace, string name, string pretty);
        
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
        V1beta1Scale ReplaceNamespacedScaleScale_7 (V1beta1Scale body, string _namespace, string name, string pretty);
  
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
        System.Threading.Tasks.Task<V1beta1Scale> ReplaceNamespacedScaleScale_7Async (V1beta1Scale body, string _namespace, string name, string pretty);
        
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
        V1beta1Scale PatchNamespacedScaleScale_8 (UnversionedPatch body, string _namespace, string name, string pretty);
  
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
        System.Threading.Tasks.Task<V1beta1Scale> PatchNamespacedScaleScale_8Async (UnversionedPatch body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// replace status of the specified ReplicaSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ReplicaSet</returns>
        V1beta1ReplicaSet ReplaceNamespacedReplicaSetStatus (V1beta1ReplicaSet body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// replace status of the specified ReplicaSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ReplicaSet</returns>
        System.Threading.Tasks.Task<V1beta1ReplicaSet> ReplaceNamespacedReplicaSetStatusAsync (V1beta1ReplicaSet body, string _namespace, string name, string pretty);
        
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
        V1beta1Scale ReadNamespacedScaleScale_9 (string _namespace, string name, string pretty);
  
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
        System.Threading.Tasks.Task<V1beta1Scale> ReadNamespacedScaleScale_9Async (string _namespace, string name, string pretty);
        
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
        V1beta1Scale ReplaceNamespacedScaleScale_10 (V1beta1Scale body, string _namespace, string name, string pretty);
  
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
        System.Threading.Tasks.Task<V1beta1Scale> ReplaceNamespacedScaleScale_10Async (V1beta1Scale body, string _namespace, string name, string pretty);
        
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
        V1beta1Scale PatchNamespacedScaleScale_11 (UnversionedPatch body, string _namespace, string name, string pretty);
  
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
        System.Threading.Tasks.Task<V1beta1Scale> PatchNamespacedScaleScale_11Async (UnversionedPatch body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// list or watch objects of kind ThirdPartyResource
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
        /// <returns>V1beta1ThirdPartyResourceList</returns>
        V1beta1ThirdPartyResourceList ListNamespacedThirdPartyResource (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// list or watch objects of kind ThirdPartyResource
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
        /// <returns>V1beta1ThirdPartyResourceList</returns>
        System.Threading.Tasks.Task<V1beta1ThirdPartyResourceList> ListNamespacedThirdPartyResourceAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// create a ThirdPartyResource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ThirdPartyResource</returns>
        V1beta1ThirdPartyResource CreateNamespacedThirdPartyResource (V1beta1ThirdPartyResource body, string _namespace, string pretty);
  
        /// <summary>
        /// create a ThirdPartyResource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ThirdPartyResource</returns>
        System.Threading.Tasks.Task<V1beta1ThirdPartyResource> CreateNamespacedThirdPartyResourceAsync (V1beta1ThirdPartyResource body, string _namespace, string pretty);
        
        /// <summary>
        /// delete collection of ThirdPartyResource
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
        /// <returns>UnversionedStatus</returns>
        UnversionedStatus DeletecollectionNamespacedThirdPartyResource (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// delete collection of ThirdPartyResource
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
        /// <returns>UnversionedStatus</returns>
        System.Threading.Tasks.Task<UnversionedStatus> DeletecollectionNamespacedThirdPartyResourceAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// read the specified ThirdPartyResource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1ThirdPartyResource</returns>
        V1beta1ThirdPartyResource ReadNamespacedThirdPartyResource (string _namespace, string name, string pretty, bool? export, bool? exact);
  
        /// <summary>
        /// read the specified ThirdPartyResource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1ThirdPartyResource</returns>
        System.Threading.Tasks.Task<V1beta1ThirdPartyResource> ReadNamespacedThirdPartyResourceAsync (string _namespace, string name, string pretty, bool? export, bool? exact);
        
        /// <summary>
        /// replace the specified ThirdPartyResource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ThirdPartyResource</returns>
        V1beta1ThirdPartyResource ReplaceNamespacedThirdPartyResource (V1beta1ThirdPartyResource body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// replace the specified ThirdPartyResource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ThirdPartyResource</returns>
        System.Threading.Tasks.Task<V1beta1ThirdPartyResource> ReplaceNamespacedThirdPartyResourceAsync (V1beta1ThirdPartyResource body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// delete a ThirdPartyResource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        UnversionedStatus DeleteNamespacedThirdPartyResource (V1DeleteOptions body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// delete a ThirdPartyResource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        System.Threading.Tasks.Task<UnversionedStatus> DeleteNamespacedThirdPartyResourceAsync (V1DeleteOptions body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// partially update the specified ThirdPartyResource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ThirdPartyResource</returns>
        V1beta1ThirdPartyResource PatchNamespacedThirdPartyResource (UnversionedPatch body, string _namespace, string name, string pretty);
  
        /// <summary>
        /// partially update the specified ThirdPartyResource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ThirdPartyResource</returns>
        System.Threading.Tasks.Task<V1beta1ThirdPartyResource> PatchNamespacedThirdPartyResourceAsync (UnversionedPatch body, string _namespace, string name, string pretty);
        
        /// <summary>
        /// list or watch objects of kind ReplicaSet
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
        /// <returns>V1beta1ReplicaSetList</returns>
        V1beta1ReplicaSetList ListNamespacedReplicaSet_12 (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// list or watch objects of kind ReplicaSet
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
        /// <returns>V1beta1ReplicaSetList</returns>
        System.Threading.Tasks.Task<V1beta1ReplicaSetList> ListNamespacedReplicaSet_12Async (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// list or watch objects of kind ThirdPartyResource
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
        /// <returns>V1beta1ThirdPartyResourceList</returns>
        V1beta1ThirdPartyResourceList ListNamespacedThirdPartyResource_13 (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// list or watch objects of kind ThirdPartyResource
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
        /// <returns>V1beta1ThirdPartyResourceList</returns>
        System.Threading.Tasks.Task<V1beta1ThirdPartyResourceList> ListNamespacedThirdPartyResource_13Async (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// watch individual changes to a list of DaemonSet
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
        JsonWatchEvent WatchNamespacedDaemonSetList (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// watch individual changes to a list of DaemonSet
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedDaemonSetListAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// watch individual changes to a list of Deployment
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
        JsonWatchEvent WatchNamespacedDeploymentList (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// watch individual changes to a list of Deployment
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedDeploymentListAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
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
        JsonWatchEvent WatchNamespacedHorizontalPodAutoscalerList (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedHorizontalPodAutoscalerListAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
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
        JsonWatchEvent WatchNamespacedIngressList (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedIngressListAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
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
        JsonWatchEvent WatchNamespacedJobList (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedJobListAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// watch individual changes to a list of DaemonSet
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
        JsonWatchEvent WatchNamespacedDaemonSetList_14 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// watch individual changes to a list of DaemonSet
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedDaemonSetList_14Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// watch changes to an object of kind DaemonSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        JsonWatchEvent WatchNamespacedDaemonSet (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// watch changes to an object of kind DaemonSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedDaemonSetAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// watch individual changes to a list of Deployment
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
        JsonWatchEvent WatchNamespacedDeploymentList_15 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// watch individual changes to a list of Deployment
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedDeploymentList_15Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// watch changes to an object of kind Deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        JsonWatchEvent WatchNamespacedDeployment (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// watch changes to an object of kind Deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedDeploymentAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
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
        JsonWatchEvent WatchNamespacedHorizontalPodAutoscalerList_16 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedHorizontalPodAutoscalerList_16Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
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
        JsonWatchEvent WatchNamespacedHorizontalPodAutoscaler (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedHorizontalPodAutoscalerAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
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
        JsonWatchEvent WatchNamespacedIngressList_17 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedIngressList_17Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
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
        JsonWatchEvent WatchNamespacedIngress (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedIngressAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
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
        JsonWatchEvent WatchNamespacedJobList_18 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedJobList_18Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
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
        JsonWatchEvent WatchNamespacedJob (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedJobAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// watch individual changes to a list of ReplicaSet
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
        JsonWatchEvent WatchNamespacedReplicaSetList (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// watch individual changes to a list of ReplicaSet
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedReplicaSetListAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// watch changes to an object of kind ReplicaSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        JsonWatchEvent WatchNamespacedReplicaSet (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// watch changes to an object of kind ReplicaSet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedReplicaSetAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// watch individual changes to a list of ThirdPartyResource
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
        JsonWatchEvent WatchNamespacedThirdPartyResourceList (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// watch individual changes to a list of ThirdPartyResource
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedThirdPartyResourceListAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// watch changes to an object of kind ThirdPartyResource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        JsonWatchEvent WatchNamespacedThirdPartyResource (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// watch changes to an object of kind ThirdPartyResource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedThirdPartyResourceAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// watch individual changes to a list of ReplicaSet
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
        JsonWatchEvent WatchNamespacedReplicaSetList_19 (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// watch individual changes to a list of ReplicaSet
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedReplicaSetList_19Async (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
        /// <summary>
        /// watch individual changes to a list of ThirdPartyResource
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
        JsonWatchEvent WatchNamespacedThirdPartyResourceList_20 (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
  
        /// <summary>
        /// watch individual changes to a list of ThirdPartyResource
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
        System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedThirdPartyResourceList_20Async (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds);
        
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
        /// <returns>UnversionedAPIResourceList</returns>            
        public UnversionedAPIResourceList GetAPIResources ()
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
                "application/json", "application/yaml"
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
    
            return (UnversionedAPIResourceList) ApiClient.Deserialize(response, typeof(UnversionedAPIResourceList));
        }
    
        /// <summary>
        /// get available resources 
        /// </summary>
        /// <returns>UnversionedAPIResourceList</returns>
        public async System.Threading.Tasks.Task<UnversionedAPIResourceList> GetAPIResourcesAsync ()
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
                "application/json", "application/yaml"
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

            return (UnversionedAPIResourceList) ApiClient.Deserialize(response, typeof(UnversionedAPIResourceList));
        }
        
        /// <summary>
        /// list or watch objects of kind DaemonSet 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>V1beta1DaemonSetList</returns>            
        public V1beta1DaemonSetList ListNamespacedDaemonSet (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/daemonsets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedDaemonSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedDaemonSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1DaemonSetList) ApiClient.Deserialize(response, typeof(V1beta1DaemonSetList));
        }
    
        /// <summary>
        /// list or watch objects of kind DaemonSet 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1DaemonSetList</returns>
        public async System.Threading.Tasks.Task<V1beta1DaemonSetList> ListNamespacedDaemonSetAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/daemonsets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedDaemonSet: " + response.Content, response.Content);

            return (V1beta1DaemonSetList) ApiClient.Deserialize(response, typeof(V1beta1DaemonSetList));
        }
        
        /// <summary>
        /// list or watch objects of kind Deployment 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>V1beta1DeploymentList</returns>            
        public V1beta1DeploymentList ListNamespacedDeployment (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/deployments";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1DeploymentList) ApiClient.Deserialize(response, typeof(V1beta1DeploymentList));
        }
    
        /// <summary>
        /// list or watch objects of kind Deployment 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1DeploymentList</returns>
        public async System.Threading.Tasks.Task<V1beta1DeploymentList> ListNamespacedDeploymentAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/deployments";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedDeployment: " + response.Content, response.Content);

            return (V1beta1DeploymentList) ApiClient.Deserialize(response, typeof(V1beta1DeploymentList));
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
        public V1beta1HorizontalPodAutoscalerList ListNamespacedHorizontalPodAutoscaler (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedHorizontalPodAutoscaler: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscalerList> ListNamespacedHorizontalPodAutoscalerAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);

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
        public V1beta1IngressList ListNamespacedIngress (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<V1beta1IngressList> ListNamespacedIngressAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedIngress: " + response.Content, response.Content);

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
        public V1beta1JobList ListNamespacedJob (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedJob: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<V1beta1JobList> ListNamespacedJobAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedJob: " + response.Content, response.Content);

            return (V1beta1JobList) ApiClient.Deserialize(response, typeof(V1beta1JobList));
        }
        
        /// <summary>
        /// list or watch objects of kind DaemonSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>V1beta1DaemonSetList</returns>            
        public V1beta1DaemonSetList ListNamespacedDaemonSet_1 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedDaemonSet_1");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedDaemonSet_1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedDaemonSet_1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1DaemonSetList) ApiClient.Deserialize(response, typeof(V1beta1DaemonSetList));
        }
    
        /// <summary>
        /// list or watch objects of kind DaemonSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1DaemonSetList</returns>
        public async System.Threading.Tasks.Task<V1beta1DaemonSetList> ListNamespacedDaemonSet_1Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedDaemonSet_1");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedDaemonSet_1: " + response.Content, response.Content);

            return (V1beta1DaemonSetList) ApiClient.Deserialize(response, typeof(V1beta1DaemonSetList));
        }
        
        /// <summary>
        /// create a DaemonSet 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1DaemonSet</returns>            
        public V1beta1DaemonSet CreateNamespacedDaemonSet (V1beta1DaemonSet body, string _namespace, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNamespacedDaemonSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateNamespacedDaemonSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedDaemonSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedDaemonSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1DaemonSet) ApiClient.Deserialize(response, typeof(V1beta1DaemonSet));
        }
    
        /// <summary>
        /// create a DaemonSet 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1DaemonSet</returns>
        public async System.Threading.Tasks.Task<V1beta1DaemonSet> CreateNamespacedDaemonSetAsync (V1beta1DaemonSet body, string _namespace, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNamespacedDaemonSet");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateNamespacedDaemonSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedDaemonSet: " + response.Content, response.Content);

            return (V1beta1DaemonSet) ApiClient.Deserialize(response, typeof(V1beta1DaemonSet));
        }
        
        /// <summary>
        /// delete collection of DaemonSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>UnversionedStatus</returns>            
        public UnversionedStatus DeletecollectionNamespacedDaemonSet (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeletecollectionNamespacedDaemonSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedDaemonSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedDaemonSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
    
        /// <summary>
        /// delete collection of DaemonSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>UnversionedStatus</returns>
        public async System.Threading.Tasks.Task<UnversionedStatus> DeletecollectionNamespacedDaemonSetAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeletecollectionNamespacedDaemonSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedDaemonSet: " + response.Content, response.Content);

            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
        
        /// <summary>
        /// read the specified DaemonSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the DaemonSet</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param> 
        /// <returns>V1beta1DaemonSet</returns>            
        public V1beta1DaemonSet ReadNamespacedDaemonSet (string _namespace, string name, string pretty, bool? export, bool? exact)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedDaemonSet");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedDaemonSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
            if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedDaemonSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedDaemonSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1DaemonSet) ApiClient.Deserialize(response, typeof(V1beta1DaemonSet));
        }
    
        /// <summary>
        /// read the specified DaemonSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1DaemonSet</returns>
        public async System.Threading.Tasks.Task<V1beta1DaemonSet> ReadNamespacedDaemonSetAsync (string _namespace, string name, string pretty, bool? export, bool? exact)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedDaemonSet");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedDaemonSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
            if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedDaemonSet: " + response.Content, response.Content);

            return (V1beta1DaemonSet) ApiClient.Deserialize(response, typeof(V1beta1DaemonSet));
        }
        
        /// <summary>
        /// replace the specified DaemonSet 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the DaemonSet</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1DaemonSet</returns>            
        public V1beta1DaemonSet ReplaceNamespacedDaemonSet (V1beta1DaemonSet body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedDaemonSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedDaemonSet");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedDaemonSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedDaemonSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedDaemonSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1DaemonSet) ApiClient.Deserialize(response, typeof(V1beta1DaemonSet));
        }
    
        /// <summary>
        /// replace the specified DaemonSet 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1DaemonSet</returns>
        public async System.Threading.Tasks.Task<V1beta1DaemonSet> ReplaceNamespacedDaemonSetAsync (V1beta1DaemonSet body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedDaemonSet");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedDaemonSet");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedDaemonSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedDaemonSet: " + response.Content, response.Content);

            return (V1beta1DaemonSet) ApiClient.Deserialize(response, typeof(V1beta1DaemonSet));
        }
        
        /// <summary>
        /// delete a DaemonSet 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the DaemonSet</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>UnversionedStatus</returns>            
        public UnversionedStatus DeleteNamespacedDaemonSet (V1DeleteOptions body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteNamespacedDaemonSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteNamespacedDaemonSet");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNamespacedDaemonSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedDaemonSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedDaemonSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
    
        /// <summary>
        /// delete a DaemonSet 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        public async System.Threading.Tasks.Task<UnversionedStatus> DeleteNamespacedDaemonSetAsync (V1DeleteOptions body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteNamespacedDaemonSet");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteNamespacedDaemonSet");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNamespacedDaemonSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedDaemonSet: " + response.Content, response.Content);

            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
        
        /// <summary>
        /// partially update the specified DaemonSet 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the DaemonSet</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1DaemonSet</returns>            
        public V1beta1DaemonSet PatchNamespacedDaemonSet (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedDaemonSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedDaemonSet");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedDaemonSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedDaemonSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedDaemonSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1DaemonSet) ApiClient.Deserialize(response, typeof(V1beta1DaemonSet));
        }
    
        /// <summary>
        /// partially update the specified DaemonSet 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1DaemonSet</returns>
        public async System.Threading.Tasks.Task<V1beta1DaemonSet> PatchNamespacedDaemonSetAsync (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedDaemonSet");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedDaemonSet");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedDaemonSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedDaemonSet: " + response.Content, response.Content);

            return (V1beta1DaemonSet) ApiClient.Deserialize(response, typeof(V1beta1DaemonSet));
        }
        
        /// <summary>
        /// replace status of the specified DaemonSet 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the DaemonSet</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1DaemonSet</returns>            
        public V1beta1DaemonSet ReplaceNamespacedDaemonSetStatus (V1beta1DaemonSet body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedDaemonSetStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedDaemonSetStatus");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedDaemonSetStatus");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedDaemonSetStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedDaemonSetStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1DaemonSet) ApiClient.Deserialize(response, typeof(V1beta1DaemonSet));
        }
    
        /// <summary>
        /// replace status of the specified DaemonSet 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1DaemonSet</returns>
        public async System.Threading.Tasks.Task<V1beta1DaemonSet> ReplaceNamespacedDaemonSetStatusAsync (V1beta1DaemonSet body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedDaemonSetStatus");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedDaemonSetStatus");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedDaemonSetStatus");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedDaemonSetStatus: " + response.Content, response.Content);

            return (V1beta1DaemonSet) ApiClient.Deserialize(response, typeof(V1beta1DaemonSet));
        }
        
        /// <summary>
        /// list or watch objects of kind Deployment 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>V1beta1DeploymentList</returns>            
        public V1beta1DeploymentList ListNamespacedDeployment_2 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedDeployment_2");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedDeployment_2: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedDeployment_2: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1DeploymentList) ApiClient.Deserialize(response, typeof(V1beta1DeploymentList));
        }
    
        /// <summary>
        /// list or watch objects of kind Deployment 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1DeploymentList</returns>
        public async System.Threading.Tasks.Task<V1beta1DeploymentList> ListNamespacedDeployment_2Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedDeployment_2");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedDeployment_2: " + response.Content, response.Content);

            return (V1beta1DeploymentList) ApiClient.Deserialize(response, typeof(V1beta1DeploymentList));
        }
        
        /// <summary>
        /// create a Deployment 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Deployment</returns>            
        public V1beta1Deployment CreateNamespacedDeployment (V1beta1Deployment body, string _namespace, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNamespacedDeployment");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateNamespacedDeployment");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Deployment) ApiClient.Deserialize(response, typeof(V1beta1Deployment));
        }
    
        /// <summary>
        /// create a Deployment 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Deployment</returns>
        public async System.Threading.Tasks.Task<V1beta1Deployment> CreateNamespacedDeploymentAsync (V1beta1Deployment body, string _namespace, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNamespacedDeployment");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateNamespacedDeployment");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedDeployment: " + response.Content, response.Content);

            return (V1beta1Deployment) ApiClient.Deserialize(response, typeof(V1beta1Deployment));
        }
        
        /// <summary>
        /// delete collection of Deployment 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>UnversionedStatus</returns>            
        public UnversionedStatus DeletecollectionNamespacedDeployment (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeletecollectionNamespacedDeployment");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
    
        /// <summary>
        /// delete collection of Deployment 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>UnversionedStatus</returns>
        public async System.Threading.Tasks.Task<UnversionedStatus> DeletecollectionNamespacedDeploymentAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeletecollectionNamespacedDeployment");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedDeployment: " + response.Content, response.Content);

            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
        
        /// <summary>
        /// read the specified Deployment 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Deployment</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param> 
        /// <returns>V1beta1Deployment</returns>            
        public V1beta1Deployment ReadNamespacedDeployment (string _namespace, string name, string pretty, bool? export, bool? exact)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedDeployment");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedDeployment");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
            if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Deployment) ApiClient.Deserialize(response, typeof(V1beta1Deployment));
        }
    
        /// <summary>
        /// read the specified Deployment 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1Deployment</returns>
        public async System.Threading.Tasks.Task<V1beta1Deployment> ReadNamespacedDeploymentAsync (string _namespace, string name, string pretty, bool? export, bool? exact)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedDeployment");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedDeployment");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
            if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedDeployment: " + response.Content, response.Content);

            return (V1beta1Deployment) ApiClient.Deserialize(response, typeof(V1beta1Deployment));
        }
        
        /// <summary>
        /// replace the specified Deployment 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Deployment</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Deployment</returns>            
        public V1beta1Deployment ReplaceNamespacedDeployment (V1beta1Deployment body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedDeployment");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedDeployment");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedDeployment");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Deployment) ApiClient.Deserialize(response, typeof(V1beta1Deployment));
        }
    
        /// <summary>
        /// replace the specified Deployment 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Deployment</returns>
        public async System.Threading.Tasks.Task<V1beta1Deployment> ReplaceNamespacedDeploymentAsync (V1beta1Deployment body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedDeployment");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedDeployment");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedDeployment");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedDeployment: " + response.Content, response.Content);

            return (V1beta1Deployment) ApiClient.Deserialize(response, typeof(V1beta1Deployment));
        }
        
        /// <summary>
        /// delete a Deployment 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Deployment</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>UnversionedStatus</returns>            
        public UnversionedStatus DeleteNamespacedDeployment (V1DeleteOptions body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteNamespacedDeployment");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteNamespacedDeployment");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNamespacedDeployment");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
    
        /// <summary>
        /// delete a Deployment 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        public async System.Threading.Tasks.Task<UnversionedStatus> DeleteNamespacedDeploymentAsync (V1DeleteOptions body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteNamespacedDeployment");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteNamespacedDeployment");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNamespacedDeployment");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedDeployment: " + response.Content, response.Content);

            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
        
        /// <summary>
        /// partially update the specified Deployment 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Deployment</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Deployment</returns>            
        public V1beta1Deployment PatchNamespacedDeployment (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedDeployment");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedDeployment");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedDeployment");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Deployment) ApiClient.Deserialize(response, typeof(V1beta1Deployment));
        }
    
        /// <summary>
        /// partially update the specified Deployment 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Deployment</returns>
        public async System.Threading.Tasks.Task<V1beta1Deployment> PatchNamespacedDeploymentAsync (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedDeployment");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedDeployment");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedDeployment");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedDeployment: " + response.Content, response.Content);

            return (V1beta1Deployment) ApiClient.Deserialize(response, typeof(V1beta1Deployment));
        }
        
        /// <summary>
        /// create rollback of a DeploymentRollback 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the DeploymentRollback</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1DeploymentRollback</returns>            
        public V1beta1DeploymentRollback CreateNamespacedDeploymentRollbackRollback (V1beta1DeploymentRollback body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNamespacedDeploymentRollbackRollback");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateNamespacedDeploymentRollbackRollback");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling CreateNamespacedDeploymentRollbackRollback");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/rollback";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedDeploymentRollbackRollback: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedDeploymentRollbackRollback: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1DeploymentRollback) ApiClient.Deserialize(response, typeof(V1beta1DeploymentRollback));
        }
    
        /// <summary>
        /// create rollback of a DeploymentRollback 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DeploymentRollback</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1DeploymentRollback</returns>
        public async System.Threading.Tasks.Task<V1beta1DeploymentRollback> CreateNamespacedDeploymentRollbackRollbackAsync (V1beta1DeploymentRollback body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNamespacedDeploymentRollbackRollback");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateNamespacedDeploymentRollbackRollback");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling CreateNamespacedDeploymentRollbackRollback");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/rollback";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedDeploymentRollbackRollback: " + response.Content, response.Content);

            return (V1beta1DeploymentRollback) ApiClient.Deserialize(response, typeof(V1beta1DeploymentRollback));
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
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
        /// replace status of the specified Deployment 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Deployment</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Deployment</returns>            
        public V1beta1Deployment ReplaceNamespacedDeploymentStatus (V1beta1Deployment body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedDeploymentStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedDeploymentStatus");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedDeploymentStatus");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedDeploymentStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedDeploymentStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Deployment) ApiClient.Deserialize(response, typeof(V1beta1Deployment));
        }
    
        /// <summary>
        /// replace status of the specified Deployment 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Deployment</returns>
        public async System.Threading.Tasks.Task<V1beta1Deployment> ReplaceNamespacedDeploymentStatusAsync (V1beta1Deployment body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedDeploymentStatus");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedDeploymentStatus");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedDeploymentStatus");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedDeploymentStatus: " + response.Content, response.Content);

            return (V1beta1Deployment) ApiClient.Deserialize(response, typeof(V1beta1Deployment));
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
        public V1beta1HorizontalPodAutoscalerList ListNamespacedHorizontalPodAutoscaler_3 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedHorizontalPodAutoscaler_3");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedHorizontalPodAutoscaler_3: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedHorizontalPodAutoscaler_3: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscalerList> ListNamespacedHorizontalPodAutoscaler_3Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedHorizontalPodAutoscaler_3");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedHorizontalPodAutoscaler_3: " + response.Content, response.Content);

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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
        /// delete collection of HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>UnversionedStatus</returns>            
        public UnversionedStatus DeletecollectionNamespacedHorizontalPodAutoscaler (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeletecollectionNamespacedHorizontalPodAutoscaler");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedHorizontalPodAutoscaler: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
    
        /// <summary>
        /// delete collection of HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>UnversionedStatus</returns>
        public async System.Threading.Tasks.Task<UnversionedStatus> DeletecollectionNamespacedHorizontalPodAutoscalerAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeletecollectionNamespacedHorizontalPodAutoscaler");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/horizontalpodautoscalers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedHorizontalPodAutoscaler: " + response.Content, response.Content);

            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
        
        /// <summary>
        /// read the specified HorizontalPodAutoscaler 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the HorizontalPodAutoscaler</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param> 
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>            
        public V1beta1HorizontalPodAutoscaler ReadNamespacedHorizontalPodAutoscaler (string _namespace, string name, string pretty, bool? export, bool? exact)
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
                "application/json", "application/yaml"
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
            if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
            if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
            
            
            
            
    
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
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1HorizontalPodAutoscaler</returns>
        public async System.Threading.Tasks.Task<V1beta1HorizontalPodAutoscaler> ReadNamespacedHorizontalPodAutoscalerAsync (string _namespace, string name, string pretty, bool? export, bool? exact)
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
                "application/json", "application/yaml"
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
            if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
            if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
            
            
            
            
    
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
        public V1beta1IngressList ListNamespacedIngress_4 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedIngress_4");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedIngress_4: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedIngress_4: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<V1beta1IngressList> ListNamespacedIngress_4Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedIngress_4");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedIngress_4: " + response.Content, response.Content);

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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
        /// delete collection of Ingress 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>UnversionedStatus</returns>            
        public UnversionedStatus DeletecollectionNamespacedIngress (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeletecollectionNamespacedIngress");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
    
        /// <summary>
        /// delete collection of Ingress 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>UnversionedStatus</returns>
        public async System.Threading.Tasks.Task<UnversionedStatus> DeletecollectionNamespacedIngressAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeletecollectionNamespacedIngress");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedIngress: " + response.Content, response.Content);

            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
        
        /// <summary>
        /// read the specified Ingress 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Ingress</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param> 
        /// <returns>V1beta1Ingress</returns>            
        public V1beta1Ingress ReadNamespacedIngress (string _namespace, string name, string pretty, bool? export, bool? exact)
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
                "application/json", "application/yaml"
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
            if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
            if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
            
            
            
            
    
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
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1Ingress</returns>
        public async System.Threading.Tasks.Task<V1beta1Ingress> ReadNamespacedIngressAsync (string _namespace, string name, string pretty, bool? export, bool? exact)
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
                "application/json", "application/yaml"
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
            if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
            if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
            
            
            
            
    
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
        public V1beta1JobList ListNamespacedJob_5 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedJob_5");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedJob_5: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedJob_5: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<V1beta1JobList> ListNamespacedJob_5Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedJob_5");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedJob_5: " + response.Content, response.Content);

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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
        /// delete collection of Job 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>UnversionedStatus</returns>            
        public UnversionedStatus DeletecollectionNamespacedJob (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeletecollectionNamespacedJob");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
    
        /// <summary>
        /// delete collection of Job 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>UnversionedStatus</returns>
        public async System.Threading.Tasks.Task<UnversionedStatus> DeletecollectionNamespacedJobAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeletecollectionNamespacedJob");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/jobs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedJob: " + response.Content, response.Content);

            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
        
        /// <summary>
        /// read the specified Job 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Job</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param> 
        /// <returns>V1beta1Job</returns>            
        public V1beta1Job ReadNamespacedJob (string _namespace, string name, string pretty, bool? export, bool? exact)
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
                "application/json", "application/yaml"
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
            if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
            if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
            
            
            
            
    
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
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1Job</returns>
        public async System.Threading.Tasks.Task<V1beta1Job> ReadNamespacedJobAsync (string _namespace, string name, string pretty, bool? export, bool? exact)
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
                "application/json", "application/yaml"
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
            if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
            if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
            
            
            
            
    
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
                "application/json", "application/yaml"
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
        /// list or watch objects of kind ReplicaSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>V1beta1ReplicaSetList</returns>            
        public V1beta1ReplicaSetList ListNamespacedReplicaSet (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedReplicaSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedReplicaSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedReplicaSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1ReplicaSetList) ApiClient.Deserialize(response, typeof(V1beta1ReplicaSetList));
        }
    
        /// <summary>
        /// list or watch objects of kind ReplicaSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1ReplicaSetList</returns>
        public async System.Threading.Tasks.Task<V1beta1ReplicaSetList> ListNamespacedReplicaSetAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedReplicaSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedReplicaSet: " + response.Content, response.Content);

            return (V1beta1ReplicaSetList) ApiClient.Deserialize(response, typeof(V1beta1ReplicaSetList));
        }
        
        /// <summary>
        /// create a ReplicaSet 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1ReplicaSet</returns>            
        public V1beta1ReplicaSet CreateNamespacedReplicaSet (V1beta1ReplicaSet body, string _namespace, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNamespacedReplicaSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateNamespacedReplicaSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedReplicaSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedReplicaSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1ReplicaSet) ApiClient.Deserialize(response, typeof(V1beta1ReplicaSet));
        }
    
        /// <summary>
        /// create a ReplicaSet 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ReplicaSet</returns>
        public async System.Threading.Tasks.Task<V1beta1ReplicaSet> CreateNamespacedReplicaSetAsync (V1beta1ReplicaSet body, string _namespace, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNamespacedReplicaSet");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateNamespacedReplicaSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedReplicaSet: " + response.Content, response.Content);

            return (V1beta1ReplicaSet) ApiClient.Deserialize(response, typeof(V1beta1ReplicaSet));
        }
        
        /// <summary>
        /// delete collection of ReplicaSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>UnversionedStatus</returns>            
        public UnversionedStatus DeletecollectionNamespacedReplicaSet (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeletecollectionNamespacedReplicaSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedReplicaSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedReplicaSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
    
        /// <summary>
        /// delete collection of ReplicaSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>UnversionedStatus</returns>
        public async System.Threading.Tasks.Task<UnversionedStatus> DeletecollectionNamespacedReplicaSetAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeletecollectionNamespacedReplicaSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedReplicaSet: " + response.Content, response.Content);

            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
        
        /// <summary>
        /// read the specified ReplicaSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the ReplicaSet</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param> 
        /// <returns>V1beta1ReplicaSet</returns>            
        public V1beta1ReplicaSet ReadNamespacedReplicaSet (string _namespace, string name, string pretty, bool? export, bool? exact)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedReplicaSet");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedReplicaSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
            if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedReplicaSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedReplicaSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1ReplicaSet) ApiClient.Deserialize(response, typeof(V1beta1ReplicaSet));
        }
    
        /// <summary>
        /// read the specified ReplicaSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1ReplicaSet</returns>
        public async System.Threading.Tasks.Task<V1beta1ReplicaSet> ReadNamespacedReplicaSetAsync (string _namespace, string name, string pretty, bool? export, bool? exact)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedReplicaSet");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedReplicaSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
            if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedReplicaSet: " + response.Content, response.Content);

            return (V1beta1ReplicaSet) ApiClient.Deserialize(response, typeof(V1beta1ReplicaSet));
        }
        
        /// <summary>
        /// replace the specified ReplicaSet 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the ReplicaSet</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1ReplicaSet</returns>            
        public V1beta1ReplicaSet ReplaceNamespacedReplicaSet (V1beta1ReplicaSet body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedReplicaSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedReplicaSet");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedReplicaSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedReplicaSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedReplicaSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1ReplicaSet) ApiClient.Deserialize(response, typeof(V1beta1ReplicaSet));
        }
    
        /// <summary>
        /// replace the specified ReplicaSet 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ReplicaSet</returns>
        public async System.Threading.Tasks.Task<V1beta1ReplicaSet> ReplaceNamespacedReplicaSetAsync (V1beta1ReplicaSet body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedReplicaSet");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedReplicaSet");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedReplicaSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedReplicaSet: " + response.Content, response.Content);

            return (V1beta1ReplicaSet) ApiClient.Deserialize(response, typeof(V1beta1ReplicaSet));
        }
        
        /// <summary>
        /// delete a ReplicaSet 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the ReplicaSet</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>UnversionedStatus</returns>            
        public UnversionedStatus DeleteNamespacedReplicaSet (V1DeleteOptions body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteNamespacedReplicaSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteNamespacedReplicaSet");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNamespacedReplicaSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedReplicaSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedReplicaSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
    
        /// <summary>
        /// delete a ReplicaSet 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        public async System.Threading.Tasks.Task<UnversionedStatus> DeleteNamespacedReplicaSetAsync (V1DeleteOptions body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteNamespacedReplicaSet");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteNamespacedReplicaSet");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNamespacedReplicaSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedReplicaSet: " + response.Content, response.Content);

            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
        
        /// <summary>
        /// partially update the specified ReplicaSet 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the ReplicaSet</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1ReplicaSet</returns>            
        public V1beta1ReplicaSet PatchNamespacedReplicaSet (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedReplicaSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedReplicaSet");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedReplicaSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedReplicaSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedReplicaSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1ReplicaSet) ApiClient.Deserialize(response, typeof(V1beta1ReplicaSet));
        }
    
        /// <summary>
        /// partially update the specified ReplicaSet 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ReplicaSet</returns>
        public async System.Threading.Tasks.Task<V1beta1ReplicaSet> PatchNamespacedReplicaSetAsync (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedReplicaSet");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedReplicaSet");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedReplicaSet");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedReplicaSet: " + response.Content, response.Content);

            return (V1beta1ReplicaSet) ApiClient.Deserialize(response, typeof(V1beta1ReplicaSet));
        }
        
        /// <summary>
        /// read scale of the specified Scale 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Scale</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Scale</returns>            
        public V1beta1Scale ReadNamespacedScaleScale_6 (string _namespace, string name, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedScaleScale_6");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedScaleScale_6");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedScaleScale_6: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedScaleScale_6: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Scale) ApiClient.Deserialize(response, typeof(V1beta1Scale));
        }
    
        /// <summary>
        /// read scale of the specified Scale 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Scale</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Scale</returns>
        public async System.Threading.Tasks.Task<V1beta1Scale> ReadNamespacedScaleScale_6Async (string _namespace, string name, string pretty)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedScaleScale_6");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedScaleScale_6");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedScaleScale_6: " + response.Content, response.Content);

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
        public V1beta1Scale ReplaceNamespacedScaleScale_7 (V1beta1Scale body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedScaleScale_7");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedScaleScale_7");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedScaleScale_7");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedScaleScale_7: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedScaleScale_7: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<V1beta1Scale> ReplaceNamespacedScaleScale_7Async (V1beta1Scale body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedScaleScale_7");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedScaleScale_7");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedScaleScale_7");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedScaleScale_7: " + response.Content, response.Content);

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
        public V1beta1Scale PatchNamespacedScaleScale_8 (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedScaleScale_8");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedScaleScale_8");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedScaleScale_8");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedScaleScale_8: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedScaleScale_8: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<V1beta1Scale> PatchNamespacedScaleScale_8Async (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedScaleScale_8");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedScaleScale_8");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedScaleScale_8");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedScaleScale_8: " + response.Content, response.Content);

            return (V1beta1Scale) ApiClient.Deserialize(response, typeof(V1beta1Scale));
        }
        
        /// <summary>
        /// replace status of the specified ReplicaSet 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the ReplicaSet</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1ReplicaSet</returns>            
        public V1beta1ReplicaSet ReplaceNamespacedReplicaSetStatus (V1beta1ReplicaSet body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedReplicaSetStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedReplicaSetStatus");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedReplicaSetStatus");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedReplicaSetStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedReplicaSetStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1ReplicaSet) ApiClient.Deserialize(response, typeof(V1beta1ReplicaSet));
        }
    
        /// <summary>
        /// replace status of the specified ReplicaSet 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ReplicaSet</returns>
        public async System.Threading.Tasks.Task<V1beta1ReplicaSet> ReplaceNamespacedReplicaSetStatusAsync (V1beta1ReplicaSet body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedReplicaSetStatus");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedReplicaSetStatus");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedReplicaSetStatus");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedReplicaSetStatus: " + response.Content, response.Content);

            return (V1beta1ReplicaSet) ApiClient.Deserialize(response, typeof(V1beta1ReplicaSet));
        }
        
        /// <summary>
        /// read scale of the specified Scale 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Scale</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1Scale</returns>            
        public V1beta1Scale ReadNamespacedScaleScale_9 (string _namespace, string name, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedScaleScale_9");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedScaleScale_9");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedScaleScale_9: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedScaleScale_9: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1Scale) ApiClient.Deserialize(response, typeof(V1beta1Scale));
        }
    
        /// <summary>
        /// read scale of the specified Scale 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Scale</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1Scale</returns>
        public async System.Threading.Tasks.Task<V1beta1Scale> ReadNamespacedScaleScale_9Async (string _namespace, string name, string pretty)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedScaleScale_9");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedScaleScale_9");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedScaleScale_9: " + response.Content, response.Content);

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
        public V1beta1Scale ReplaceNamespacedScaleScale_10 (V1beta1Scale body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedScaleScale_10");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedScaleScale_10");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedScaleScale_10");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedScaleScale_10: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedScaleScale_10: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<V1beta1Scale> ReplaceNamespacedScaleScale_10Async (V1beta1Scale body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedScaleScale_10");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedScaleScale_10");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedScaleScale_10");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedScaleScale_10: " + response.Content, response.Content);

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
        public V1beta1Scale PatchNamespacedScaleScale_11 (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedScaleScale_11");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedScaleScale_11");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedScaleScale_11");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedScaleScale_11: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedScaleScale_11: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<V1beta1Scale> PatchNamespacedScaleScale_11Async (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedScaleScale_11");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedScaleScale_11");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedScaleScale_11");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedScaleScale_11: " + response.Content, response.Content);

            return (V1beta1Scale) ApiClient.Deserialize(response, typeof(V1beta1Scale));
        }
        
        /// <summary>
        /// list or watch objects of kind ThirdPartyResource 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>V1beta1ThirdPartyResourceList</returns>            
        public V1beta1ThirdPartyResourceList ListNamespacedThirdPartyResource (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedThirdPartyResource");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/thirdpartyresources";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedThirdPartyResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedThirdPartyResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1ThirdPartyResourceList) ApiClient.Deserialize(response, typeof(V1beta1ThirdPartyResourceList));
        }
    
        /// <summary>
        /// list or watch objects of kind ThirdPartyResource 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1ThirdPartyResourceList</returns>
        public async System.Threading.Tasks.Task<V1beta1ThirdPartyResourceList> ListNamespacedThirdPartyResourceAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListNamespacedThirdPartyResource");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/thirdpartyresources";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedThirdPartyResource: " + response.Content, response.Content);

            return (V1beta1ThirdPartyResourceList) ApiClient.Deserialize(response, typeof(V1beta1ThirdPartyResourceList));
        }
        
        /// <summary>
        /// create a ThirdPartyResource 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1ThirdPartyResource</returns>            
        public V1beta1ThirdPartyResource CreateNamespacedThirdPartyResource (V1beta1ThirdPartyResource body, string _namespace, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNamespacedThirdPartyResource");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateNamespacedThirdPartyResource");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/thirdpartyresources";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedThirdPartyResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedThirdPartyResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1ThirdPartyResource) ApiClient.Deserialize(response, typeof(V1beta1ThirdPartyResource));
        }
    
        /// <summary>
        /// create a ThirdPartyResource 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ThirdPartyResource</returns>
        public async System.Threading.Tasks.Task<V1beta1ThirdPartyResource> CreateNamespacedThirdPartyResourceAsync (V1beta1ThirdPartyResource body, string _namespace, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateNamespacedThirdPartyResource");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateNamespacedThirdPartyResource");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/thirdpartyresources";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNamespacedThirdPartyResource: " + response.Content, response.Content);

            return (V1beta1ThirdPartyResource) ApiClient.Deserialize(response, typeof(V1beta1ThirdPartyResource));
        }
        
        /// <summary>
        /// delete collection of ThirdPartyResource 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>UnversionedStatus</returns>            
        public UnversionedStatus DeletecollectionNamespacedThirdPartyResource (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeletecollectionNamespacedThirdPartyResource");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/thirdpartyresources";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedThirdPartyResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedThirdPartyResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
    
        /// <summary>
        /// delete collection of ThirdPartyResource 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>UnversionedStatus</returns>
        public async System.Threading.Tasks.Task<UnversionedStatus> DeletecollectionNamespacedThirdPartyResourceAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeletecollectionNamespacedThirdPartyResource");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/thirdpartyresources";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletecollectionNamespacedThirdPartyResource: " + response.Content, response.Content);

            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
        
        /// <summary>
        /// read the specified ThirdPartyResource 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the ThirdPartyResource</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param> 
        /// <returns>V1beta1ThirdPartyResource</returns>            
        public V1beta1ThirdPartyResource ReadNamespacedThirdPartyResource (string _namespace, string name, string pretty, bool? export, bool? exact)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedThirdPartyResource");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedThirdPartyResource");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/thirdpartyresources/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
            if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedThirdPartyResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedThirdPartyResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1ThirdPartyResource) ApiClient.Deserialize(response, typeof(V1beta1ThirdPartyResource));
        }
    
        /// <summary>
        /// read the specified ThirdPartyResource 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;</param>
        /// <returns>V1beta1ThirdPartyResource</returns>
        public async System.Threading.Tasks.Task<V1beta1ThirdPartyResource> ReadNamespacedThirdPartyResourceAsync (string _namespace, string name, string pretty, bool? export, bool? exact)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadNamespacedThirdPartyResource");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadNamespacedThirdPartyResource");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/thirdpartyresources/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
            if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
            if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadNamespacedThirdPartyResource: " + response.Content, response.Content);

            return (V1beta1ThirdPartyResource) ApiClient.Deserialize(response, typeof(V1beta1ThirdPartyResource));
        }
        
        /// <summary>
        /// replace the specified ThirdPartyResource 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the ThirdPartyResource</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1ThirdPartyResource</returns>            
        public V1beta1ThirdPartyResource ReplaceNamespacedThirdPartyResource (V1beta1ThirdPartyResource body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedThirdPartyResource");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedThirdPartyResource");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedThirdPartyResource");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/thirdpartyresources/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedThirdPartyResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedThirdPartyResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1ThirdPartyResource) ApiClient.Deserialize(response, typeof(V1beta1ThirdPartyResource));
        }
    
        /// <summary>
        /// replace the specified ThirdPartyResource 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ThirdPartyResource</returns>
        public async System.Threading.Tasks.Task<V1beta1ThirdPartyResource> ReplaceNamespacedThirdPartyResourceAsync (V1beta1ThirdPartyResource body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceNamespacedThirdPartyResource");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceNamespacedThirdPartyResource");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceNamespacedThirdPartyResource");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/thirdpartyresources/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceNamespacedThirdPartyResource: " + response.Content, response.Content);

            return (V1beta1ThirdPartyResource) ApiClient.Deserialize(response, typeof(V1beta1ThirdPartyResource));
        }
        
        /// <summary>
        /// delete a ThirdPartyResource 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the ThirdPartyResource</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>UnversionedStatus</returns>            
        public UnversionedStatus DeleteNamespacedThirdPartyResource (V1DeleteOptions body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteNamespacedThirdPartyResource");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteNamespacedThirdPartyResource");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNamespacedThirdPartyResource");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/thirdpartyresources/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedThirdPartyResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedThirdPartyResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
    
        /// <summary>
        /// delete a ThirdPartyResource 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>UnversionedStatus</returns>
        public async System.Threading.Tasks.Task<UnversionedStatus> DeleteNamespacedThirdPartyResourceAsync (V1DeleteOptions body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteNamespacedThirdPartyResource");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteNamespacedThirdPartyResource");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNamespacedThirdPartyResource");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/thirdpartyresources/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNamespacedThirdPartyResource: " + response.Content, response.Content);

            return (UnversionedStatus) ApiClient.Deserialize(response, typeof(UnversionedStatus));
        }
        
        /// <summary>
        /// partially update the specified ThirdPartyResource 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the ThirdPartyResource</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>V1beta1ThirdPartyResource</returns>            
        public V1beta1ThirdPartyResource PatchNamespacedThirdPartyResource (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedThirdPartyResource");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedThirdPartyResource");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedThirdPartyResource");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/thirdpartyresources/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedThirdPartyResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedThirdPartyResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1ThirdPartyResource) ApiClient.Deserialize(response, typeof(V1beta1ThirdPartyResource));
        }
    
        /// <summary>
        /// partially update the specified ThirdPartyResource 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>V1beta1ThirdPartyResource</returns>
        public async System.Threading.Tasks.Task<V1beta1ThirdPartyResource> PatchNamespacedThirdPartyResourceAsync (UnversionedPatch body, string _namespace, string name, string pretty)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchNamespacedThirdPartyResource");
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchNamespacedThirdPartyResource");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchNamespacedThirdPartyResource");
            
    
            var path_ = "/apis/extensions/v1beta1/namespaces/{namespace}/thirdpartyresources/{name}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchNamespacedThirdPartyResource: " + response.Content, response.Content);

            return (V1beta1ThirdPartyResource) ApiClient.Deserialize(response, typeof(V1beta1ThirdPartyResource));
        }
        
        /// <summary>
        /// list or watch objects of kind ReplicaSet 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>V1beta1ReplicaSetList</returns>            
        public V1beta1ReplicaSetList ListNamespacedReplicaSet_12 (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/replicasets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedReplicaSet_12: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedReplicaSet_12: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1ReplicaSetList) ApiClient.Deserialize(response, typeof(V1beta1ReplicaSetList));
        }
    
        /// <summary>
        /// list or watch objects of kind ReplicaSet 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1ReplicaSetList</returns>
        public async System.Threading.Tasks.Task<V1beta1ReplicaSetList> ListNamespacedReplicaSet_12Async (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/replicasets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedReplicaSet_12: " + response.Content, response.Content);

            return (V1beta1ReplicaSetList) ApiClient.Deserialize(response, typeof(V1beta1ReplicaSetList));
        }
        
        /// <summary>
        /// list or watch objects of kind ThirdPartyResource 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>V1beta1ThirdPartyResourceList</returns>            
        public V1beta1ThirdPartyResourceList ListNamespacedThirdPartyResource_13 (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/thirdpartyresources";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedThirdPartyResource_13: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedThirdPartyResource_13: " + response.ErrorMessage, response.ErrorMessage);
    
            return (V1beta1ThirdPartyResourceList) ApiClient.Deserialize(response, typeof(V1beta1ThirdPartyResourceList));
        }
    
        /// <summary>
        /// list or watch objects of kind ThirdPartyResource 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>V1beta1ThirdPartyResourceList</returns>
        public async System.Threading.Tasks.Task<V1beta1ThirdPartyResourceList> ListNamespacedThirdPartyResource_13Async (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/thirdpartyresources";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/yaml"
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListNamespacedThirdPartyResource_13: " + response.Content, response.Content);

            return (V1beta1ThirdPartyResourceList) ApiClient.Deserialize(response, typeof(V1beta1ThirdPartyResourceList));
        }
        
        /// <summary>
        /// watch individual changes to a list of DaemonSet 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedDaemonSetList (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/watch/daemonsets";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDaemonSetList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDaemonSetList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch individual changes to a list of DaemonSet 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedDaemonSetListAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/watch/daemonsets";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDaemonSetList: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch individual changes to a list of Deployment 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedDeploymentList (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/watch/deployments";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDeploymentList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDeploymentList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch individual changes to a list of Deployment 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedDeploymentListAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/watch/deployments";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDeploymentList: " + response.Content, response.Content);

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
        public JsonWatchEvent WatchNamespacedHorizontalPodAutoscalerList (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedHorizontalPodAutoscalerList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedHorizontalPodAutoscalerList: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedHorizontalPodAutoscalerListAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedHorizontalPodAutoscalerList: " + response.Content, response.Content);

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
        public JsonWatchEvent WatchNamespacedIngressList (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedIngressList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedIngressList: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedIngressListAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedIngressList: " + response.Content, response.Content);

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
        public JsonWatchEvent WatchNamespacedJobList (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedJobList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedJobList: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedJobListAsync (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedJobList: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch individual changes to a list of DaemonSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedDaemonSetList_14 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedDaemonSetList_14");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/daemonsets";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDaemonSetList_14: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDaemonSetList_14: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch individual changes to a list of DaemonSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedDaemonSetList_14Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedDaemonSetList_14");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/daemonsets";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDaemonSetList_14: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch changes to an object of kind DaemonSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the DaemonSet</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedDaemonSet (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedDaemonSet");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchNamespacedDaemonSet");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/daemonsets/{name}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDaemonSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDaemonSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch changes to an object of kind DaemonSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedDaemonSetAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedDaemonSet");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchNamespacedDaemonSet");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/daemonsets/{name}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDaemonSet: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch individual changes to a list of Deployment 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedDeploymentList_15 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedDeploymentList_15");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/deployments";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDeploymentList_15: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDeploymentList_15: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch individual changes to a list of Deployment 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedDeploymentList_15Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedDeploymentList_15");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/deployments";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDeploymentList_15: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch changes to an object of kind Deployment 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the Deployment</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedDeployment (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedDeployment");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchNamespacedDeployment");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/deployments/{name}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch changes to an object of kind Deployment 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the Deployment</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedDeploymentAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedDeployment");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchNamespacedDeployment");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/deployments/{name}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedDeployment: " + response.Content, response.Content);

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
        public JsonWatchEvent WatchNamespacedHorizontalPodAutoscalerList_16 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedHorizontalPodAutoscalerList_16");
            
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedHorizontalPodAutoscalerList_16: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedHorizontalPodAutoscalerList_16: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedHorizontalPodAutoscalerList_16Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedHorizontalPodAutoscalerList_16");
            
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedHorizontalPodAutoscalerList_16: " + response.Content, response.Content);

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
        public JsonWatchEvent WatchNamespacedHorizontalPodAutoscaler (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedHorizontalPodAutoscalerAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
        public JsonWatchEvent WatchNamespacedIngressList_17 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedIngressList_17");
            
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedIngressList_17: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedIngressList_17: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedIngressList_17Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedIngressList_17");
            
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedIngressList_17: " + response.Content, response.Content);

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
        public JsonWatchEvent WatchNamespacedIngress (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedIngressAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
        public JsonWatchEvent WatchNamespacedJobList_18 (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedJobList_18");
            
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedJobList_18: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedJobList_18: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedJobList_18Async (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedJobList_18");
            
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedJobList_18: " + response.Content, response.Content);

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
        public JsonWatchEvent WatchNamespacedJob (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedJobAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
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
        
        /// <summary>
        /// watch individual changes to a list of ReplicaSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedReplicaSetList (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedReplicaSetList");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/replicasets";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedReplicaSetList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedReplicaSetList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch individual changes to a list of ReplicaSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedReplicaSetListAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedReplicaSetList");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/replicasets";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedReplicaSetList: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch changes to an object of kind ReplicaSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the ReplicaSet</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedReplicaSet (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedReplicaSet");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchNamespacedReplicaSet");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/replicasets/{name}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedReplicaSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedReplicaSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch changes to an object of kind ReplicaSet 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedReplicaSetAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedReplicaSet");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchNamespacedReplicaSet");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/replicasets/{name}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedReplicaSet: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch individual changes to a list of ThirdPartyResource 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedThirdPartyResourceList (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedThirdPartyResourceList");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/thirdpartyresources";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedThirdPartyResourceList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedThirdPartyResourceList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch individual changes to a list of ThirdPartyResource 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedThirdPartyResourceListAsync (string _namespace, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedThirdPartyResourceList");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/thirdpartyresources";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedThirdPartyResourceList: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch changes to an object of kind ThirdPartyResource 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="name">name of the ThirdPartyResource</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedThirdPartyResource (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedThirdPartyResource");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchNamespacedThirdPartyResource");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/thirdpartyresources/{name}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedThirdPartyResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedThirdPartyResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch changes to an object of kind ThirdPartyResource 
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedThirdPartyResourceAsync (string _namespace, string name, string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchNamespacedThirdPartyResource");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchNamespacedThirdPartyResource");
            
    
            var path_ = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/thirdpartyresources/{name}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedThirdPartyResource: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch individual changes to a list of ReplicaSet 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedReplicaSetList_19 (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/watch/replicasets";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedReplicaSetList_19: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedReplicaSetList_19: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch individual changes to a list of ReplicaSet 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedReplicaSetList_19Async (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/watch/replicasets";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedReplicaSetList_19: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
        /// <summary>
        /// watch individual changes to a list of ThirdPartyResource 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <returns>JsonWatchEvent</returns>            
        public JsonWatchEvent WatchNamespacedThirdPartyResourceList_20 (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/watch/thirdpartyresources";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedThirdPartyResourceList_20: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedThirdPartyResourceList_20: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
    
        /// <summary>
        /// watch individual changes to a list of ThirdPartyResource 
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <returns>JsonWatchEvent</returns>
        public async System.Threading.Tasks.Task<JsonWatchEvent> WatchNamespacedThirdPartyResourceList_20Async (string pretty, string labelSelector, string fieldSelector, bool? watch, string resourceVersion, int? timeoutSeconds)
        {
            
    
            var path_ = "/apis/extensions/v1beta1/watch/thirdpartyresources";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchNamespacedThirdPartyResourceList_20: " + response.Content, response.Content);

            return (JsonWatchEvent) ApiClient.Deserialize(response, typeof(JsonWatchEvent));
        }
        
    }
    
}
