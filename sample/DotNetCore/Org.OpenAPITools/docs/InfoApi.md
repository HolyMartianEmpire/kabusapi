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
> OrdersSuccess OrdersGet (string X_API_KEY, string product = null, string id = null, string updtime = null, string details = null, string symbol = null, string state = null, string side = null, string cashmargin = null)

注文約定照会

注文一覧を取得します。<br>※下記Queryパラメータは任意設定となります。

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
            var id = id_example;  // string | 注文番号<br>※指定された注文番号と一致する注文のみレスポンスします。<br>※指定された注文番号との比較では大文字小文字を区別しません。<br>※複数の注文番号を指定することはできません。 (optional) 
            var updtime = updtime_example;  // string | 更新日時<br>※形式：yyyyMMddHHmmss （例：20201201123456）<br>※指定された更新日時以降（指定日時含む）に更新された注文のみレスポンスします。<br>※複数の更新日時を指定することはできません。 (optional) 
            var details = details_example;  // string | 注文詳細抑止 |定義値|説明| |-|-| |true|注文詳細を出力する（デフォルト）| |false|注文詳細の出力しない| (optional) 
            var symbol = symbol_example;  // string | 銘柄コード<br>※指定された銘柄コードと一致する注文のみレスポンスします。<br>※複数の銘柄コードを指定することができません。 (optional) 
            var state = state_example;  // string | 状態 <br>※指定された状態と一致する注文のみレスポンスします。<br>※フィルタには数字の入力のみ受け付けます。<br>※複数の状態を指定することはできません。 |定義値|説明| |-|-| |1|待機（発注待機）| |2|処理中（発注送信中）| |3|処理済（発注済・訂正済）| |4|訂正取消送信中| |5|終了（発注エラー・取消済・全約定・失効・期限切れ）| (optional) 
            var side = side_example;  // string | 売買区分 <br>※指定された売買区分と一致する注文のみレスポンスします。<br>※フィルタには数字の入力のみ受け付けます。<br>※複数の売買区分を指定することができません。 |定義値|説明| |-|-| |1|売| |2|買| (optional) 
            var cashmargin = cashmargin_example;  // string | 取引区分 <br>※指定された取引区分と一致する注文のみレスポンスします。<br>※フィルタには数字の入力のみ受け付けます。<br>※複数の取引区分を指定することができません。 |定義値|説明| |-|-| |2|新規| |3|返済| (optional) 

            try
            {
                // 注文約定照会
                OrdersSuccess result = apiInstance.OrdersGet(X_API_KEY, product, id, updtime, details, symbol, state, side, cashmargin);
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
 **id** | **string**| 注文番号&lt;br&gt;※指定された注文番号と一致する注文のみレスポンスします。&lt;br&gt;※指定された注文番号との比較では大文字小文字を区別しません。&lt;br&gt;※複数の注文番号を指定することはできません。 | [optional] 
 **updtime** | **string**| 更新日時&lt;br&gt;※形式：yyyyMMddHHmmss （例：20201201123456）&lt;br&gt;※指定された更新日時以降（指定日時含む）に更新された注文のみレスポンスします。&lt;br&gt;※複数の更新日時を指定することはできません。 | [optional] 
 **details** | **string**| 注文詳細抑止 |定義値|説明| |-|-| |true|注文詳細を出力する（デフォルト）| |false|注文詳細の出力しない| | [optional] 
 **symbol** | **string**| 銘柄コード&lt;br&gt;※指定された銘柄コードと一致する注文のみレスポンスします。&lt;br&gt;※複数の銘柄コードを指定することができません。 | [optional] 
 **state** | **string**| 状態 &lt;br&gt;※指定された状態と一致する注文のみレスポンスします。&lt;br&gt;※フィルタには数字の入力のみ受け付けます。&lt;br&gt;※複数の状態を指定することはできません。 |定義値|説明| |-|-| |1|待機（発注待機）| |2|処理中（発注送信中）| |3|処理済（発注済・訂正済）| |4|訂正取消送信中| |5|終了（発注エラー・取消済・全約定・失効・期限切れ）| | [optional] 
 **side** | **string**| 売買区分 &lt;br&gt;※指定された売買区分と一致する注文のみレスポンスします。&lt;br&gt;※フィルタには数字の入力のみ受け付けます。&lt;br&gt;※複数の売買区分を指定することができません。 |定義値|説明| |-|-| |1|売| |2|買| | [optional] 
 **cashmargin** | **string**| 取引区分 &lt;br&gt;※指定された取引区分と一致する注文のみレスポンスします。&lt;br&gt;※フィルタには数字の入力のみ受け付けます。&lt;br&gt;※複数の取引区分を指定することができません。 |定義値|説明| |-|-| |2|新規| |3|返済| | [optional] 

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
> PositionsSuccess PositionsGet (string X_API_KEY, string product = null, string symbol = null)

残高照会

残高一覧を取得します。<br>※下記Queryパラメータは任意設定となります。

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
            var symbol = symbol_example;  // string | 銘柄コード<br>※指定された銘柄コードと一致するポジションのみレスポンスします。<br>※複数の銘柄コードを指定することはできません。 (optional) 

            try
            {
                // 残高照会
                PositionsSuccess result = apiInstance.PositionsGet(X_API_KEY, product, symbol);
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
 **symbol** | **string**| 銘柄コード&lt;br&gt;※指定された銘柄コードと一致するポジションのみレスポンスします。&lt;br&gt;※複数の銘柄コードを指定することはできません。 | [optional] 

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
            var derivMonth = 56;  // int | 限月<br>※限月はyyyyMM形式で指定します。0を指定した場合、直近限月となります。<br>※取引最終日に「0」（直近限月）を指定した場合、日中・夜間の時間帯に関わらず、取引最終日を迎える限月の銘柄コードを返します。取引最終日を迎える銘柄の取引は日中取引をもって終了となりますので、ご注意ください。

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
 **derivMonth** | **int**| 限月&lt;br&gt;※限月はyyyyMM形式で指定します。0を指定した場合、直近限月となります。&lt;br&gt;※取引最終日に「0」（直近限月）を指定した場合、日中・夜間の時間帯に関わらず、取引最終日を迎える限月の銘柄コードを返します。取引最終日を迎える銘柄の取引は日中取引をもって終了となりますので、ご注意ください。 | 

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
            var derivMonth = 56;  // int | 限月<br>※限月はyyyyMM形式で指定します。0を指定した場合、直近限月となります。<br>※取引最終日に「0」（直近限月）を指定した場合、日中・夜間の時間帯に関わらず、取引最終日を迎える限月の銘柄コードを返します。取引最終日を迎える銘柄の取引は日中取引をもって終了となりますので、ご注意ください。
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
 **derivMonth** | **int**| 限月&lt;br&gt;※限月はyyyyMM形式で指定します。0を指定した場合、直近限月となります。&lt;br&gt;※取引最終日に「0」（直近限月）を指定した場合、日中・夜間の時間帯に関わらず、取引最終日を迎える限月の銘柄コードを返します。取引最終日を迎える銘柄の取引は日中取引をもって終了となりますので、ご注意ください。 | 
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

