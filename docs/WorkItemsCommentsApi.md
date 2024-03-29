# TestGear.Client.Api.WorkItemsCommentsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2WorkItemsCommentsCommentIdDelete**](WorkItemsCommentsApi.md#apiv2workitemscommentscommentiddelete) | **DELETE** /api/v2/workItems/comments/{commentId} | Delete WorkItem comment |
| [**ApiV2WorkItemsCommentsPost**](WorkItemsCommentsApi.md#apiv2workitemscommentspost) | **POST** /api/v2/workItems/comments | Create WorkItem comment |
| [**ApiV2WorkItemsCommentsPut**](WorkItemsCommentsApi.md#apiv2workitemscommentsput) | **PUT** /api/v2/workItems/comments | Update work item comment |
| [**ApiV2WorkItemsIdCommentsGet**](WorkItemsCommentsApi.md#apiv2workitemsidcommentsget) | **GET** /api/v2/workItems/{id}/comments | Get work item comments |

<a name="apiv2workitemscommentscommentiddelete"></a>
# **ApiV2WorkItemsCommentsCommentIdDelete**
> void ApiV2WorkItemsCommentsCommentIdDelete (Guid commentId)

Delete WorkItem comment

<br>Use case  <br>User sets comment identifier  <br>User runs method execution  <br>System delete comment   <br>System returns success status code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestGear.Client.Api;
using TestGear.Client.Client;
using TestGear.Client.Model;

namespace Example
{
    public class ApiV2WorkItemsCommentsCommentIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkItemsCommentsApi(httpClient, config, httpClientHandler);
            var commentId = "commentId_example";  // Guid | 

            try
            {
                // Delete WorkItem comment
                apiInstance.ApiV2WorkItemsCommentsCommentIdDelete(commentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsCommentsApi.ApiV2WorkItemsCommentsCommentIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsCommentsCommentIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete WorkItem comment
    apiInstance.ApiV2WorkItemsCommentsCommentIdDeleteWithHttpInfo(commentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsCommentsApi.ApiV2WorkItemsCommentsCommentIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **commentId** | **Guid** |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful operation |  -  |
| **401** | Unauthorized |  -  |
| **403** | System admin permission required |  -  |
| **400** | Bad Request |  -  |
| **404** | WorkItem is not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2workitemscommentspost"></a>
# **ApiV2WorkItemsCommentsPost**
> WorkItemCommentModel ApiV2WorkItemsCommentsPost (WorkItemCommentPostModel workItemCommentPostModel = null)

Create WorkItem comment

<br>Use case  <br>User sets comment properties (listed in request parameters)  <br>User runs method execution  <br>System creates comment   <br>System returns comment model (listed in response parameters)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestGear.Client.Api;
using TestGear.Client.Client;
using TestGear.Client.Model;

namespace Example
{
    public class ApiV2WorkItemsCommentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkItemsCommentsApi(httpClient, config, httpClientHandler);
            var workItemCommentPostModel = new WorkItemCommentPostModel(); // WorkItemCommentPostModel |  (optional) 

            try
            {
                // Create WorkItem comment
                WorkItemCommentModel result = apiInstance.ApiV2WorkItemsCommentsPost(workItemCommentPostModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsCommentsApi.ApiV2WorkItemsCommentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsCommentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create WorkItem comment
    ApiResponse<WorkItemCommentModel> response = apiInstance.ApiV2WorkItemsCommentsPostWithHttpInfo(workItemCommentPostModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsCommentsApi.ApiV2WorkItemsCommentsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workItemCommentPostModel** | [**WorkItemCommentPostModel**](WorkItemCommentPostModel.md) |  | [optional]  |

### Return type

[**WorkItemCommentModel**](WorkItemCommentModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | WorkItem is not found |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test library required |  -  |
| **400** | Bad Request |  -  |
| **201** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2workitemscommentsput"></a>
# **ApiV2WorkItemsCommentsPut**
> void ApiV2WorkItemsCommentsPut (WorkItemCommentPutModel workItemCommentPutModel = null)

Update work item comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestGear.Client.Api;
using TestGear.Client.Client;
using TestGear.Client.Model;

namespace Example
{
    public class ApiV2WorkItemsCommentsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkItemsCommentsApi(httpClient, config, httpClientHandler);
            var workItemCommentPutModel = new WorkItemCommentPutModel(); // WorkItemCommentPutModel |  (optional) 

            try
            {
                // Update work item comment
                apiInstance.ApiV2WorkItemsCommentsPut(workItemCommentPutModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsCommentsApi.ApiV2WorkItemsCommentsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsCommentsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update work item comment
    apiInstance.ApiV2WorkItemsCommentsPutWithHttpInfo(workItemCommentPutModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsCommentsApi.ApiV2WorkItemsCommentsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workItemCommentPutModel** | [**WorkItemCommentPutModel**](WorkItemCommentPutModel.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | System administrator role is required |  -  |
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2workitemsidcommentsget"></a>
# **ApiV2WorkItemsIdCommentsGet**
> List&lt;WorkItemCommentModel&gt; ApiV2WorkItemsIdCommentsGet (string id)

Get work item comments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestGear.Client.Api;
using TestGear.Client.Client;
using TestGear.Client.Model;

namespace Example
{
    public class ApiV2WorkItemsIdCommentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkItemsCommentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Unique or global ID of the work item

            try
            {
                // Get work item comments
                List<WorkItemCommentModel> result = apiInstance.ApiV2WorkItemsIdCommentsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsCommentsApi.ApiV2WorkItemsIdCommentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsIdCommentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get work item comments
    ApiResponse<List<WorkItemCommentModel>> response = apiInstance.ApiV2WorkItemsIdCommentsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsCommentsApi.ApiV2WorkItemsIdCommentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Unique or global ID of the work item |  |

### Return type

[**List&lt;WorkItemCommentModel&gt;**](WorkItemCommentModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Read permission for test library is required |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

