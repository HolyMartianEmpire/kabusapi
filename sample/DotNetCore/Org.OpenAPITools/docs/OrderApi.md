# Org.OpenAPITools.Api.OrderApi

All URIs are relative to *http://localhost/kabusapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelorderPut**](OrderApi.md#cancelorderput) | **PUT** /cancelorder | 注文取消
[**SendorderPost**](OrderApi.md#sendorderpost) | **POST** /sendorder | 注文発注


<a name="cancelorderput"></a>
# **CancelorderPut**
> OrderSuccess CancelorderPut (string X_API_KEY, RequestCancelOrder req)

注文取消

注文を取消します

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CancelorderPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/kabusapi";
            var apiInstance = new OrderApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var req = new RequestCancelOrder(); // RequestCancelOrder | 

            try
            {
                // 注文取消
                OrderSuccess result = apiInstance.CancelorderPut(X_API_KEY, req);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CancelorderPut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **X_API_KEY** | **string**| トークン発行メソッドで取得した文字列 | 
 **req** | [**RequestCancelOrder**](RequestCancelOrder.md)|  | 

### Return type

[**OrderSuccess**](OrderSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | BadRequest |  -  |
| **403** | Forbidden |  -  |
| **404** | NotFound |  -  |
| **405** | MethodNotAllowed |  -  |
| **413** | RequestEntityTooLarge |  -  |
| **415** | UnsupportedMediaType |  -  |
| **429** | TooManyRequests |  -  |
| **500** | InternalServerError |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendorderpost"></a>
# **SendorderPost**
> OrderSuccess SendorderPost (string X_API_KEY, RequestSendOrder req)

注文発注

注文を発注します。<br> 同一の銘柄に対しての注文は同時に5件ほどを上限としてご利用ください。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SendorderPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/kabusapi";
            var apiInstance = new OrderApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var req = new RequestSendOrder(); // RequestSendOrder | 

            try
            {
                // 注文発注
                OrderSuccess result = apiInstance.SendorderPost(X_API_KEY, req);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.SendorderPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **X_API_KEY** | **string**| トークン発行メソッドで取得した文字列 | 
 **req** | [**RequestSendOrder**](RequestSendOrder.md)|  | 

### Return type

[**OrderSuccess**](OrderSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | BadRequest |  -  |
| **403** | Forbidden |  -  |
| **404** | NotFound |  -  |
| **405** | MethodNotAllowed |  -  |
| **413** | RequestEntityTooLarge |  -  |
| **415** | UnsupportedMediaType |  -  |
| **429** | TooManyRequests |  -  |
| **500** | InternalServerError |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

