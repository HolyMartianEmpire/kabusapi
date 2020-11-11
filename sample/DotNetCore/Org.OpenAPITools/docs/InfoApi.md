# Org.OpenAPITools.Api.InfoApi

All URIs are relative to *http://localhost/kabusapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BoardSymbolexchangeGet**](InfoApi.md#boardsymbolexchangeget) | **GET** /board/{symbol}@{exchange} | 時価情報・板情報
[**OrdersGet**](InfoApi.md#ordersget) | **GET** /orders | 注文約定照会
[**PositionsGet**](InfoApi.md#positionsget) | **GET** /positions | 残高照会
[**SymbolSymbolexchangeGet**](InfoApi.md#symbolsymbolexchangeget) | **GET** /symbol/{symbol}@{exchange} | 銘柄情報


<a name="boardsymbolexchangeget"></a>
# **BoardSymbolexchangeGet**
> BoardSuccess BoardSymbolexchangeGet (string X_API_KEY, string symbol, string exchange)

時価情報・板情報

指定した銘柄の時価情報・板情報を取得します

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BoardSymbolexchangeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var symbol = symbol_example;  // string | 銘柄コード
            var exchange = exchange_example;  // string | 市場コード |定義値|説明| |-|-| |1|東証| |3|名証| |5|福証| |6|札証|

            try
            {
                // 時価情報・板情報
                BoardSuccess result = apiInstance.BoardSymbolexchangeGet(X_API_KEY, symbol, exchange);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.BoardSymbolexchangeGet: " + e.Message );
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
 **symbol** | **string**| 銘柄コード | 
 **exchange** | **string**| 市場コード |定義値|説明| |-|-| |1|東証| |3|名証| |5|福証| |6|札証| | 

### Return type

[**BoardSuccess**](BoardSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
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

<a name="ordersget"></a>
# **OrdersGet**
> OrdersSuccess OrdersGet (string X_API_KEY, string product = null)

注文約定照会

注文一覧を取得します

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrdersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var product = product_example;  // string | 取得する商品 |定義値|説明| |-|-| |0|すべて| |1|現物| |2|信用| (optional) 

            try
            {
                // 注文約定照会
                OrdersSuccess result = apiInstance.OrdersGet(X_API_KEY, product);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.OrdersGet: " + e.Message );
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
 **product** | **string**| 取得する商品 |定義値|説明| |-|-| |0|すべて| |1|現物| |2|信用| | [optional] 

### Return type

[**OrdersSuccess**](OrdersSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
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

<a name="positionsget"></a>
# **PositionsGet**
> PositionsSuccess PositionsGet (string X_API_KEY, string product = null)

残高照会

残高一覧を取得します

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PositionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var product = product_example;  // string | 取得する商品 |定義値|説明| |-|-| |0|すべて| |1|現物| |2|信用| (optional) 

            try
            {
                // 残高照会
                PositionsSuccess result = apiInstance.PositionsGet(X_API_KEY, product);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.PositionsGet: " + e.Message );
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
 **product** | **string**| 取得する商品 |定義値|説明| |-|-| |0|すべて| |1|現物| |2|信用| | [optional] 

### Return type

[**PositionsSuccess**](PositionsSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
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

<a name="symbolsymbolexchangeget"></a>
# **SymbolSymbolexchangeGet**
> SymbolSuccess SymbolSymbolexchangeGet (string X_API_KEY, string symbol, string exchange)

銘柄情報

指定した銘柄情報を取得します

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SymbolSymbolexchangeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var symbol = symbol_example;  // string | 銘柄コード
            var exchange = exchange_example;  // string | 市場コード |定義値|説明| |-|-| |1|東証| |3|名証| |5|福証| |6|札証|

            try
            {
                // 銘柄情報
                SymbolSuccess result = apiInstance.SymbolSymbolexchangeGet(X_API_KEY, symbol, exchange);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.SymbolSymbolexchangeGet: " + e.Message );
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
 **symbol** | **string**| 銘柄コード | 
 **exchange** | **string**| 市場コード |定義値|説明| |-|-| |1|東証| |3|名証| |5|福証| |6|札証| | 

### Return type

[**SymbolSuccess**](SymbolSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
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

