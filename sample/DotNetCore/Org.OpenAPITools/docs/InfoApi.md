# Org.OpenAPITools.Api.InfoApi

All URIs are relative to *http://localhost/kabusapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BoardSymbolexchangeGet**](InfoApi.md#boardsymbolexchangeget) | **GET** /board/{symbol}@{exchange} | 時価情報・板情報
[**OrdersGet**](InfoApi.md#ordersget) | **GET** /orders | 注文約定照会
[**PositionsGet**](InfoApi.md#positionsget) | **GET** /positions | 残高照会
[**SymbolSymbolexchangeGet**](InfoApi.md#symbolsymbolexchangeget) | **GET** /symbol/{symbol}@{exchange} | 銘柄情報
[**SymbolnameFutureGet**](InfoApi.md#symbolnamefutureget) | **GET** /symbolname/future | 先物銘柄コード取得
[**SymbolnameOptionGet**](InfoApi.md#symbolnameoptionget) | **GET** /symbolname/option | オプション銘柄コード取得


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
            var exchange = exchange_example;  // string | 市場コード |定義値|説明| |-|-| |1|東証| |3|名証| |5|福証| |6|札証| |2|日通し| |23|日中| |24|夜間|

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
 **exchange** | **string**| 市場コード |定義値|説明| |-|-| |1|東証| |3|名証| |5|福証| |6|札証| |2|日通し| |23|日中| |24|夜間| | 

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
| **401** | Unauthorized |  -  |
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
            var product = product_example;  // string | 取得する商品 |定義値|説明| |-|-| |0|すべて| |1|現物| |2|信用| |3|先物| |4|OP| (optional) 

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
 **product** | **string**| 取得する商品 |定義値|説明| |-|-| |0|すべて| |1|現物| |2|信用| |3|先物| |4|OP| | [optional] 

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
| **401** | Unauthorized |  -  |
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
            var product = product_example;  // string | 取得する商品 |定義値|説明| |-|-| |0|すべて| |1|現物| |2|信用| |3|先物| |4|OP| (optional) 

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
 **product** | **string**| 取得する商品 |定義値|説明| |-|-| |0|すべて| |1|現物| |2|信用| |3|先物| |4|OP| | [optional] 

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
| **401** | Unauthorized |  -  |
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
            var exchange = exchange_example;  // string | 市場コード |定義値|説明| |-|-| |1|東証| |3|名証| |5|福証| |6|札証| |2|日通し| |23|日中| |24|夜間|

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
 **exchange** | **string**| 市場コード |定義値|説明| |-|-| |1|東証| |3|名証| |5|福証| |6|札証| |2|日通し| |23|日中| |24|夜間| | 

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
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | NotFound |  -  |
| **405** | MethodNotAllowed |  -  |
| **413** | RequestEntityTooLarge |  -  |
| **415** | UnsupportedMediaType |  -  |
| **429** | TooManyRequests |  -  |
| **500** | InternalServerError |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="symbolnamefutureget"></a>
# **SymbolnameFutureGet**
> SymbolNameSuccess SymbolnameFutureGet (string X_API_KEY, string futureCode, int derivMonth)

先物銘柄コード取得

先物銘柄コード取得

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SymbolnameFutureGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var futureCode = futureCode_example;  // string | 先物コード<br>※大文字小文字は区別しません。 |定義値|説明| |-|-| |NK225|日経平均先物| |NK225mini|日経225mini先物| |TOPIX|TOPIX先物| |TOPIXmini|ミニTOPIX先物| |MOTHERS|東証マザーズ先物| |JPX400|JPX日経400先物| |DOW|NYダウ先物| |VI|日経平均VI先物| |Core30|TOPIX Core30先物| |REIT|東証REIT指数先物|
            var derivMonth = 56;  // int | 限月<br>※限月はyyyyMM形式で指定します。0を指定した場合、直近限月となります。

            try
            {
                // 先物銘柄コード取得
                SymbolNameSuccess result = apiInstance.SymbolnameFutureGet(X_API_KEY, futureCode, derivMonth);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.SymbolnameFutureGet: " + e.Message );
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
 **futureCode** | **string**| 先物コード&lt;br&gt;※大文字小文字は区別しません。 |定義値|説明| |-|-| |NK225|日経平均先物| |NK225mini|日経225mini先物| |TOPIX|TOPIX先物| |TOPIXmini|ミニTOPIX先物| |MOTHERS|東証マザーズ先物| |JPX400|JPX日経400先物| |DOW|NYダウ先物| |VI|日経平均VI先物| |Core30|TOPIX Core30先物| |REIT|東証REIT指数先物| | 
 **derivMonth** | **int**| 限月&lt;br&gt;※限月はyyyyMM形式で指定します。0を指定した場合、直近限月となります。 | 

### Return type

[**SymbolNameSuccess**](SymbolNameSuccess.md)

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
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | NotFound |  -  |
| **405** | MethodNotAllowed |  -  |
| **413** | RequestEntityTooLarge |  -  |
| **415** | UnsupportedMediaType |  -  |
| **429** | TooManyRequests |  -  |
| **500** | InternalServerError |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="symbolnameoptionget"></a>
# **SymbolnameOptionGet**
> SymbolNameSuccess SymbolnameOptionGet (string X_API_KEY, int derivMonth, string putOrCall, int strikePrice)

オプション銘柄コード取得

オプション銘柄コード取得

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SymbolnameOptionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var derivMonth = 56;  // int | 限月<br>※限月はyyyyMM形式で指定します。0を指定した場合、直近限月となります。
            var putOrCall = putOrCall_example;  // string | コール or プット<br>※大文字小文字は区別しません。 |定義値|説明| |-|-| |P|PUT| |C|CALL|
            var strikePrice = 56;  // int | 権利行使価格<br>※0を指定した場合、APIを実行した時点でのATMとなります。

            try
            {
                // オプション銘柄コード取得
                SymbolNameSuccess result = apiInstance.SymbolnameOptionGet(X_API_KEY, derivMonth, putOrCall, strikePrice);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.SymbolnameOptionGet: " + e.Message );
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
 **derivMonth** | **int**| 限月&lt;br&gt;※限月はyyyyMM形式で指定します。0を指定した場合、直近限月となります。 | 
 **putOrCall** | **string**| コール or プット&lt;br&gt;※大文字小文字は区別しません。 |定義値|説明| |-|-| |P|PUT| |C|CALL| | 
 **strikePrice** | **int**| 権利行使価格&lt;br&gt;※0を指定した場合、APIを実行した時点でのATMとなります。 | 

### Return type

[**SymbolNameSuccess**](SymbolNameSuccess.md)

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
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | NotFound |  -  |
| **405** | MethodNotAllowed |  -  |
| **413** | RequestEntityTooLarge |  -  |
| **415** | UnsupportedMediaType |  -  |
| **429** | TooManyRequests |  -  |
| **500** | InternalServerError |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

