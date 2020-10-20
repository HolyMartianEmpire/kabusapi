# Org.OpenAPITools.Api.AuthApi

All URIs are relative to *http://localhost/kabusapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TokenPost**](AuthApi.md#tokenpost) | **POST** /token | トークン発行


<a name="tokenpost"></a>
# **TokenPost**
> TokenSuccess TokenPost (RequestToken req)

トークン発行

APIトークンを発行します。<br> 発行したトークンは有効である限り使用することができ、リクエストごとに発行する必要はありません。<br> 発行されたAPIトークンは以下のタイミングで無効となります。<br> ・kabuステーションを終了した時<br> ・kabuステーションからログアウトした時<br> ・別のトークンが新たに発行された時<br> ※kabuステーションは早朝、強制的にログアウトいたしますのでご留意ください。<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/kabusapi";
            var apiInstance = new AuthApi(config);
            var req = new RequestToken(); // RequestToken | 

            try
            {
                // トークン発行
                TokenSuccess result = apiInstance.TokenPost(req);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.TokenPost: " + e.Message );
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
 **req** | [**RequestToken**](RequestToken.md)|  | 

### Return type

[**TokenSuccess**](TokenSuccess.md)

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
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | NotFound |  -  |
| **405** | MethodNotAllowed |  -  |
| **413** | RequestEntityTooLarge |  -  |
| **415** | UnsupportedMediaType |  -  |
| **429** | TooManyRequests |  -  |
| **500** | InternalServerError |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

