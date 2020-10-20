# Org.OpenAPITools.Api.WalletApi

All URIs are relative to *http://localhost/kabusapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WalletCashGet**](WalletApi.md#walletcashget) | **GET** /wallet/cash | 取引余力（現物）
[**WalletCashSymbolexchangeGet**](WalletApi.md#walletcashsymbolexchangeget) | **GET** /wallet/cash/{symbol}@{exchange} | 取引余力（現物）（銘柄指定）
[**WalletMarginGet**](WalletApi.md#walletmarginget) | **GET** /wallet/margin | 取引余力（信用）
[**WalletMarginSymbolexchangeGet**](WalletApi.md#walletmarginsymbolexchangeget) | **GET** /wallet/margin/{symbol}@{exchange} | 取引余力（信用）（銘柄指定）


<a name="walletcashget"></a>
# **WalletCashGet**
> WalletCashSuccess WalletCashGet (string X_API_KEY)

取引余力（現物）

口座の取引余力（現物）を取得します

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WalletCashGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/kabusapi";
            var apiInstance = new WalletApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列

            try
            {
                // 取引余力（現物）
                WalletCashSuccess result = apiInstance.WalletCashGet(X_API_KEY);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletCashGet: " + e.Message );
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

### Return type

[**WalletCashSuccess**](WalletCashSuccess.md)

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

<a name="walletcashsymbolexchangeget"></a>
# **WalletCashSymbolexchangeGet**
> WalletCashSuccess WalletCashSymbolexchangeGet (string X_API_KEY, string symbol, string exchange)

取引余力（現物）（銘柄指定）

指定した銘柄の取引余力（現物）を取得します

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WalletCashSymbolexchangeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/kabusapi";
            var apiInstance = new WalletApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var symbol = symbol_example;  // string | 銘柄コード
            var exchange = exchange_example;  // string | 市場コード |定義値|説明| |-|-| |1|東証| |3|名証| |5|福証| |6|札証|

            try
            {
                // 取引余力（現物）（銘柄指定）
                WalletCashSuccess result = apiInstance.WalletCashSymbolexchangeGet(X_API_KEY, symbol, exchange);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletCashSymbolexchangeGet: " + e.Message );
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

[**WalletCashSuccess**](WalletCashSuccess.md)

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

<a name="walletmarginget"></a>
# **WalletMarginGet**
> WalletMarginSuccess WalletMarginGet (string X_API_KEY)

取引余力（信用）

口座の取引余力（信用）を取得します

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WalletMarginGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/kabusapi";
            var apiInstance = new WalletApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列

            try
            {
                // 取引余力（信用）
                WalletMarginSuccess result = apiInstance.WalletMarginGet(X_API_KEY);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletMarginGet: " + e.Message );
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

### Return type

[**WalletMarginSuccess**](WalletMarginSuccess.md)

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

<a name="walletmarginsymbolexchangeget"></a>
# **WalletMarginSymbolexchangeGet**
> WalletMarginSuccess WalletMarginSymbolexchangeGet (string X_API_KEY, string symbol, string exchange)

取引余力（信用）（銘柄指定）

指定した銘柄の取引余力（信用）を取得します

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WalletMarginSymbolexchangeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/kabusapi";
            var apiInstance = new WalletApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var symbol = symbol_example;  // string | 銘柄コード
            var exchange = exchange_example;  // string | 市場コード |定義値|説明| |-|-| |1|東証| |3|名証| |5|福証| |6|札証|

            try
            {
                // 取引余力（信用）（銘柄指定）
                WalletMarginSuccess result = apiInstance.WalletMarginSymbolexchangeGet(X_API_KEY, symbol, exchange);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletMarginSymbolexchangeGet: " + e.Message );
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

[**WalletMarginSuccess**](WalletMarginSuccess.md)

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

