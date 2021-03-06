# Org.OpenAPITools.Api.InfoApi

All URIs are relative to *http://localhost:18080/kabusapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApisoftlimitGet**](InfoApi.md#apisoftlimitget) | **GET** /apisoftlimit | ソフトリミット
[**BoardGet**](InfoApi.md#boardget) | **GET** /board/{symbol} | 時価情報・板情報
[**ExchangeGet**](InfoApi.md#exchangeget) | **GET** /exchange/{symbol} | 為替情報
[**OrdersGet**](InfoApi.md#ordersget) | **GET** /orders | 注文約定照会
[**PositionsGet**](InfoApi.md#positionsget) | **GET** /positions | 残高照会
[**PrimaryExchangeGet**](InfoApi.md#primaryexchangeget) | **GET** /primaryexchange/{symbol} | 優先市場
[**RankingGet**](InfoApi.md#rankingget) | **GET** /ranking | 詳細ランキング
[**RegulationsGet**](InfoApi.md#regulationsget) | **GET** /regulations/{symbol} | 規制情報
[**SymbolGet**](InfoApi.md#symbolget) | **GET** /symbol/{symbol} | 銘柄情報
[**SymbolnameFutureGet**](InfoApi.md#symbolnamefutureget) | **GET** /symbolname/future | 先物銘柄コード取得
[**SymbolnameOptionGet**](InfoApi.md#symbolnameoptionget) | **GET** /symbolname/option | オプション銘柄コード取得


<a name="apisoftlimitget"></a>
# **ApisoftlimitGet**
> ApiSoftLimitResponse ApisoftlimitGet (string X_API_KEY)

ソフトリミット

kabuステーションAPIのソフトリミット値を取得する

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApisoftlimitGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:18080/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列

            try
            {
                // ソフトリミット
                ApiSoftLimitResponse result = apiInstance.ApisoftlimitGet(X_API_KEY);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ApisoftlimitGet: " + e.Message );
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

[**ApiSoftLimitResponse**](ApiSoftLimitResponse.md)

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

<a name="boardget"></a>
# **BoardGet**
> BoardSuccess BoardGet (string X_API_KEY, string symbol)

時価情報・板情報

指定した銘柄の時価情報・板情報を取得します<br> レスポンスの一部にnullが発生した場合、該当銘柄を銘柄登録をしてから、 <br>再度時価情報・板情報APIを実行してください。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BoardGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:18080/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var symbol = symbol_example;  // string | 銘柄コード <br> ※次の形式で入力してください。<br> [銘柄コード]@[市場コード]<br> ※市場コードは下記の定義値から選択してください。 <b>市場コード</b> <table>   <thead>       <tr>           <th>定義値</th>           <th>説明</th>       </tr>   </thead>   <tbody>       <tr>           <td>1</td>           <td>東証</td>       </tr>       <tr>           <td>3</td>           <td>名証</td>       </tr>       <tr>           <td>5</td>           <td>福証</td>       </tr>       <tr>           <td>6</td>           <td>札証</td>       </tr>       <tr>           <td>2</td>           <td>日通し</td>       </tr>       <tr>           <td>23</td>           <td>日中</td>       </tr>       <tr>           <td>24</td>           <td>夜間</td>       </tr>   </tbody> </table>

            try
            {
                // 時価情報・板情報
                BoardSuccess result = apiInstance.BoardGet(X_API_KEY, symbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.BoardGet: " + e.Message );
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
 **symbol** | **string**| 銘柄コード &lt;br&gt; ※次の形式で入力してください。&lt;br&gt; [銘柄コード]@[市場コード]&lt;br&gt; ※市場コードは下記の定義値から選択してください。 &lt;b&gt;市場コード&lt;/b&gt; &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;説明&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;1&lt;/td&gt;           &lt;td&gt;東証&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;3&lt;/td&gt;           &lt;td&gt;名証&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;5&lt;/td&gt;           &lt;td&gt;福証&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;6&lt;/td&gt;           &lt;td&gt;札証&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;2&lt;/td&gt;           &lt;td&gt;日通し&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;23&lt;/td&gt;           &lt;td&gt;日中&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;24&lt;/td&gt;           &lt;td&gt;夜間&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | 

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

<a name="exchangeget"></a>
# **ExchangeGet**
> ExchangeResponse ExchangeGet (string X_API_KEY, string symbol)

為替情報

マネービューの情報を取得する

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ExchangeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:18080/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var symbol = symbol_example;  // string | 通貨 <table>   <thead>     <tr>       <th>定義値</th>       <th>内容</th>     </tr>   </thead>   <tbody>     <tr>       <td>usdjpy</td>       <td>USD/JPY</td>     </tr>     <tr>       <td>eurjpy</td>       <td>EUR/JPY</td>     </tr>     <tr>       <td>gbpjpy</td>       <td>GBP/JPY</td>     </tr>     <tr>       <td>audjpy</td>       <td>AUD/JPY</td>     </tr>     <tr>       <td>chfjpy</td>       <td>CHF/JPY</td>     </tr>     <tr>       <td>cadjpy</td>       <td>CAD/JPY</td>     </tr>     <tr>       <td>nzdjpy</td>       <td>NZD/JPY</td>     </tr>     <tr>       <td>zarjpy</td>       <td>ZAR/JPY</td>     </tr>     <tr>       <td>eurusd</td>       <td>EUR/USD</td>     </tr>     <tr>       <td>gbpusd</td>       <td>GBP/USD</td>     </tr>     <tr>       <td>audusd</td>       <td>AUD/USD</td>     </tr>   </tbody> </table>

            try
            {
                // 為替情報
                ExchangeResponse result = apiInstance.ExchangeGet(X_API_KEY, symbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.ExchangeGet: " + e.Message );
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
 **symbol** | **string**| 通貨 &lt;table&gt;   &lt;thead&gt;     &lt;tr&gt;       &lt;th&gt;定義値&lt;/th&gt;       &lt;th&gt;内容&lt;/th&gt;     &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;     &lt;tr&gt;       &lt;td&gt;usdjpy&lt;/td&gt;       &lt;td&gt;USD/JPY&lt;/td&gt;     &lt;/tr&gt;     &lt;tr&gt;       &lt;td&gt;eurjpy&lt;/td&gt;       &lt;td&gt;EUR/JPY&lt;/td&gt;     &lt;/tr&gt;     &lt;tr&gt;       &lt;td&gt;gbpjpy&lt;/td&gt;       &lt;td&gt;GBP/JPY&lt;/td&gt;     &lt;/tr&gt;     &lt;tr&gt;       &lt;td&gt;audjpy&lt;/td&gt;       &lt;td&gt;AUD/JPY&lt;/td&gt;     &lt;/tr&gt;     &lt;tr&gt;       &lt;td&gt;chfjpy&lt;/td&gt;       &lt;td&gt;CHF/JPY&lt;/td&gt;     &lt;/tr&gt;     &lt;tr&gt;       &lt;td&gt;cadjpy&lt;/td&gt;       &lt;td&gt;CAD/JPY&lt;/td&gt;     &lt;/tr&gt;     &lt;tr&gt;       &lt;td&gt;nzdjpy&lt;/td&gt;       &lt;td&gt;NZD/JPY&lt;/td&gt;     &lt;/tr&gt;     &lt;tr&gt;       &lt;td&gt;zarjpy&lt;/td&gt;       &lt;td&gt;ZAR/JPY&lt;/td&gt;     &lt;/tr&gt;     &lt;tr&gt;       &lt;td&gt;eurusd&lt;/td&gt;       &lt;td&gt;EUR/USD&lt;/td&gt;     &lt;/tr&gt;     &lt;tr&gt;       &lt;td&gt;gbpusd&lt;/td&gt;       &lt;td&gt;GBP/USD&lt;/td&gt;     &lt;/tr&gt;     &lt;tr&gt;       &lt;td&gt;audusd&lt;/td&gt;       &lt;td&gt;AUD/USD&lt;/td&gt;     &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | 

### Return type

[**ExchangeResponse**](ExchangeResponse.md)

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
> List&lt;OrdersSuccess&gt; OrdersGet (string X_API_KEY, string product = null, string id = null, string updtime = null, string details = null, string symbol = null, string state = null, string side = null, string cashmargin = null)

注文約定照会

注文一覧を取得します。<br> ※下記Queryパラメータは任意設定となります。

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
            config.BasePath = "http://localhost:18080/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var product = product_example;  // string | 取得する商品 <table>   <thead>       <tr>           <th>定義値</th>           <th>説明</th>       </tr>   </thead>   <tbody>       <tr>           <td>0</td>           <td>すべて </td>       </tr>       <tr>           <td>1</td>           <td>現物</td>       </tr>       <tr>           <td>2</td>           <td>信用</td>       </tr>       <tr>           <td>3</td>           <td>先物</td>       </tr>       <tr>           <td>4</td>           <td>OP</td>       </tr>   </tbody> </table> (optional) 
            var id = id_example;  // string | 注文番号<br> ※指定された注文番号と一致する注文のみレスポンスします。<br> ※指定された注文番号との比較では大文字小文字を区別しません。<br> ※複数の注文番号を指定することはできません。 (optional) 
            var updtime = updtime_example;  // string | 更新日時<br> ※形式：yyyyMMddHHmmss （例：20201201123456）<br> ※指定された更新日時以降（指定日時含む）に更新された注文のみレスポンスします。<br> ※複数の更新日時を指定することはできません。 (optional) 
            var details = details_example;  // string | 注文詳細抑止 <table>   <thead>       <tr>           <th>定義値</th>           <th>説明</th>       </tr>   </thead>   <tbody>       <tr>           <td>true</td>           <td>注文詳細を出力する（デフォルト）</td>       </tr>       <tr>           <td>false</td>           <td>注文詳細の出力しない</td>       </tr>   </tbody> </table> (optional) 
            var symbol = symbol_example;  // string | 銘柄コード<br>※指定された銘柄コードと一致する注文のみレスポンスします。<br>※複数の銘柄コードを指定することができません。 (optional) 
            var state = state_example;  // string | 状態<br> ※指定された状態と一致する注文のみレスポンスします。<br> ※フィルタには数字の入力のみ受け付けます。<br> ※複数の状態を指定することはできません。 <table>   <thead>       <tr>           <th>定義値</th>           <th>説明</th>       </tr>   </thead>   <tbody>       <tr>           <td>1</td>           <td>待機（発注待機）</td>       </tr>       <tr>           <td>2</td>           <td>処理中（発注送信中）</td>       </tr>       <tr>           <td>3</td>           <td>処理済（発注済・訂正済）</td>       </tr>       <tr>           <td>4</td>           <td>訂正取消送信中</td>       </tr>       <tr>           <td>5</td>           <td>終了（発注エラー・取消済・全約定・失効・期限切れ）</td>       </tr>   </tbody> </table> (optional) 
            var side = side_example;  // string | 売買区分<br> ※指定された売買区分と一致する注文のみレスポンスします。<br> ※フィルタには数字の入力のみ受け付けます。<br> ※複数の売買区分を指定することができません。 <table>   <thead>       <tr>           <th>定義値</th>           <th>説明</th>       </tr>   </thead>   <tbody>       <tr>           <td>1</td>           <td>売</td>       </tr>       <tr>           <td>2</td>           <td>買</td>       </tr>   </tbody> </table> (optional) 
            var cashmargin = cashmargin_example;  // string | 取引区分<br> ※指定された取引区分と一致する注文のみレスポンスします。<br> ※フィルタには数字の入力のみ受け付けます。<br> ※複数の取引区分を指定することができません。 <table>   <thead>       <tr>           <th>定義値</th>           <th>説明</th>       </tr>   </thead>   <tbody>       <tr>           <td>2</td>           <td>新規</td>       </tr>       <tr>           <td>3</td>           <td>返済</td>       </tr>   </tbody> </table> (optional) 

            try
            {
                // 注文約定照会
                List<OrdersSuccess> result = apiInstance.OrdersGet(X_API_KEY, product, id, updtime, details, symbol, state, side, cashmargin);
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
 **product** | **string**| 取得する商品 &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;説明&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;0&lt;/td&gt;           &lt;td&gt;すべて &lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;1&lt;/td&gt;           &lt;td&gt;現物&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;2&lt;/td&gt;           &lt;td&gt;信用&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;3&lt;/td&gt;           &lt;td&gt;先物&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;4&lt;/td&gt;           &lt;td&gt;OP&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | [optional] 
 **id** | **string**| 注文番号&lt;br&gt; ※指定された注文番号と一致する注文のみレスポンスします。&lt;br&gt; ※指定された注文番号との比較では大文字小文字を区別しません。&lt;br&gt; ※複数の注文番号を指定することはできません。 | [optional] 
 **updtime** | **string**| 更新日時&lt;br&gt; ※形式：yyyyMMddHHmmss （例：20201201123456）&lt;br&gt; ※指定された更新日時以降（指定日時含む）に更新された注文のみレスポンスします。&lt;br&gt; ※複数の更新日時を指定することはできません。 | [optional] 
 **details** | **string**| 注文詳細抑止 &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;説明&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;true&lt;/td&gt;           &lt;td&gt;注文詳細を出力する（デフォルト）&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;false&lt;/td&gt;           &lt;td&gt;注文詳細の出力しない&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | [optional] 
 **symbol** | **string**| 銘柄コード&lt;br&gt;※指定された銘柄コードと一致する注文のみレスポンスします。&lt;br&gt;※複数の銘柄コードを指定することができません。 | [optional] 
 **state** | **string**| 状態&lt;br&gt; ※指定された状態と一致する注文のみレスポンスします。&lt;br&gt; ※フィルタには数字の入力のみ受け付けます。&lt;br&gt; ※複数の状態を指定することはできません。 &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;説明&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;1&lt;/td&gt;           &lt;td&gt;待機（発注待機）&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;2&lt;/td&gt;           &lt;td&gt;処理中（発注送信中）&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;3&lt;/td&gt;           &lt;td&gt;処理済（発注済・訂正済）&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;4&lt;/td&gt;           &lt;td&gt;訂正取消送信中&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;5&lt;/td&gt;           &lt;td&gt;終了（発注エラー・取消済・全約定・失効・期限切れ）&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | [optional] 
 **side** | **string**| 売買区分&lt;br&gt; ※指定された売買区分と一致する注文のみレスポンスします。&lt;br&gt; ※フィルタには数字の入力のみ受け付けます。&lt;br&gt; ※複数の売買区分を指定することができません。 &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;説明&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;1&lt;/td&gt;           &lt;td&gt;売&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;2&lt;/td&gt;           &lt;td&gt;買&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | [optional] 
 **cashmargin** | **string**| 取引区分&lt;br&gt; ※指定された取引区分と一致する注文のみレスポンスします。&lt;br&gt; ※フィルタには数字の入力のみ受け付けます。&lt;br&gt; ※複数の取引区分を指定することができません。 &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;説明&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;2&lt;/td&gt;           &lt;td&gt;新規&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;3&lt;/td&gt;           &lt;td&gt;返済&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | [optional] 

### Return type

[**List&lt;OrdersSuccess&gt;**](OrdersSuccess.md)

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
> List&lt;PositionsSuccess&gt; PositionsGet (string X_API_KEY, string product = null, string symbol = null, string side = null, string addinfo = null)

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
            config.BasePath = "http://localhost:18080/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var product = product_example;  // string | 取得する商品 <table>   <thead>       <tr>           <th>定義値</th>           <th>説明</th>       </tr>   </thead>   <tbody>       <tr>           <td>0</td>           <td>すべて</td>       </tr>       <tr>           <td>1</td>           <td>現物</td>       </tr>       <tr>           <td>2</td>           <td>信用</td>       </tr>       <tr>           <td>3</td>           <td>先物</td>       </tr>       <tr>           <td>4</td>           <td>OP</td>       </tr>   </tbody> </table> (optional) 
            var symbol = symbol_example;  // string | 銘柄コード<br>※指定された銘柄コードと一致するポジションのみレスポンスします。<br>※複数の銘柄コードを指定することはできません。 (optional) 
            var side = side_example;  // string | 売買区分フィルタ<br> 指定された売買区分と一致する注文を返す <table>   <thead>       <tr>           <th>定義値</th>           <th>説明</th>       </tr>   </thead>   <tbody>       <tr>           <td>1</td>           <td>売</td>       </tr>       <tr>           <td>2</td>           <td>買</td>       </tr>   </tbody> </table> (optional) 
            var addinfo = addinfo_example;  // string | 追加情報出力フラグ（未指定時：true）<br> ※追加情報は、「現在値」、「評価金額」、「評価損益額」、「評価損益率」を意味します。 <table>   <thead>       <tr>           <th>定義値</th>           <th>説明</th>       </tr>   </thead>   <tbody>       <tr>           <td>true</td>           <td>追加情報を出力する</td>       </tr>       <tr>           <td>false</td>           <td>追加情報を出力しない</td>       </tr>   </tbody> </table> (optional) 

            try
            {
                // 残高照会
                List<PositionsSuccess> result = apiInstance.PositionsGet(X_API_KEY, product, symbol, side, addinfo);
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
 **product** | **string**| 取得する商品 &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;説明&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;0&lt;/td&gt;           &lt;td&gt;すべて&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;1&lt;/td&gt;           &lt;td&gt;現物&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;2&lt;/td&gt;           &lt;td&gt;信用&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;3&lt;/td&gt;           &lt;td&gt;先物&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;4&lt;/td&gt;           &lt;td&gt;OP&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | [optional] 
 **symbol** | **string**| 銘柄コード&lt;br&gt;※指定された銘柄コードと一致するポジションのみレスポンスします。&lt;br&gt;※複数の銘柄コードを指定することはできません。 | [optional] 
 **side** | **string**| 売買区分フィルタ&lt;br&gt; 指定された売買区分と一致する注文を返す &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;説明&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;1&lt;/td&gt;           &lt;td&gt;売&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;2&lt;/td&gt;           &lt;td&gt;買&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | [optional] 
 **addinfo** | **string**| 追加情報出力フラグ（未指定時：true）&lt;br&gt; ※追加情報は、「現在値」、「評価金額」、「評価損益額」、「評価損益率」を意味します。 &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;説明&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;true&lt;/td&gt;           &lt;td&gt;追加情報を出力する&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;false&lt;/td&gt;           &lt;td&gt;追加情報を出力しない&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | [optional] 

### Return type

[**List&lt;PositionsSuccess&gt;**](PositionsSuccess.md)

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

<a name="primaryexchangeget"></a>
# **PrimaryExchangeGet**
> PrimaryExchangeResponse PrimaryExchangeGet (string X_API_KEY, string symbol)

優先市場

株式の優先市場を取得する

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PrimaryExchangeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:18080/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var symbol = symbol_example;  // string | 銘柄コード

            try
            {
                // 優先市場
                PrimaryExchangeResponse result = apiInstance.PrimaryExchangeGet(X_API_KEY, symbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.PrimaryExchangeGet: " + e.Message );
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

### Return type

[**PrimaryExchangeResponse**](PrimaryExchangeResponse.md)

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

<a name="rankingget"></a>
# **RankingGet**
> OneOfRankingDefaultResponseRankingByTickCountResponseRankingByTradeVolumeResponseRankingByTradeValueResponseRankingByMarginResponseRankingByCategoryResponse RankingGet (string X_API_KEY, string type, string exchangeDivision)

詳細ランキング

詳細ランキング画面と同様の各種ランキングを返します。 <br>ランキングの対象日はkabuステーションが保持している当日のデータとなります。 <br>※株価情報ランキング、業種別指数ランキングは、下記の時間帯でデータがクリアされるため、 <br>その間の詳細ランキングAPIは空レスポンスとなります。 <br>データクリア：平日7:53頃-9:00過ぎ頃 <br>※信用情報ランキングは毎週第３営業日の7:55頃にデータが更新されます。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RankingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:18080/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var type = type_example;  // string | 種別<br> ※信用情報ランキングに「福証」「札証」を指定した場合は、空レスポンスになります <table>   <thead>       <tr>           <th>定義値</th>           <th>説明</th>       </tr>   </thead>   <tbody>       <tr>           <td>1</td>           <td>値上がり率（デフォルト）</td>       </tr>       <tr>           <td>2</td>           <td>値下がり率</td>       </tr>       <tr>           <td>3</td>           <td>売買高上位</td>       </tr>       <tr>           <td>4</td>           <td>売買代金</td>       </tr>       <tr>           <td>5</td>           <td>TICK回数</td>       </tr>       <tr>           <td>6</td>           <td>売買高急増</td>       </tr>       <tr>           <td>7</td>           <td>売買代金急増</td>       </tr>       <tr>           <td>8</td>           <td>信用売残増</td>       </tr>       <tr>           <td>9</td>           <td>信用売残減</td>       </tr>       <tr>           <td>10</td>           <td>信用買残増</td>       </tr>       <tr>           <td>11</td>           <td>信用買残減</td>       </tr>       <tr>           <td>12</td>           <td>信用高倍率</td>       </tr>       <tr>           <td>13</td>           <td>信用低倍率</td>       </tr>       <tr>           <td>14</td>           <td>業種別値上がり率</td>       </tr>       <tr>           <td>15</td>           <td>業種別値下がり率</td>       </tr>   </tbody> </table>
            var exchangeDivision = exchangeDivision_example;  // string | 市場<br> ※業種別値上がり率・値下がり率に市場を指定しても無視されます <table>   <thead>       <tr>           <th>定義値</th>           <th>説明</th>       </tr>   </thead>   <tbody>       <tr>           <td>ALL</td>           <td>全市場（デフォルト）</td>       </tr>       <tr>           <td>T</td>           <td>東証全体</td>       </tr>       <tr>           <td>T1</td>           <td>東証一部</td>       </tr>       <tr>           <td>T2</td>           <td>東証二部</td>       </tr>       <tr>           <td>TM</td>           <td>マザーズ</td>       </tr>       <tr>           <td>JQ</td>           <td>JASDAQ</td>       </tr>       <tr>           <td>M</td>           <td>名証</td>       </tr>       <tr>           <td>FK</td>           <td>福証</td>       </tr>       <tr>           <td>S</td>           <td>札証</td>       </tr>   </tbody> </table>

            try
            {
                // 詳細ランキング
                OneOfRankingDefaultResponseRankingByTickCountResponseRankingByTradeVolumeResponseRankingByTradeValueResponseRankingByMarginResponseRankingByCategoryResponse result = apiInstance.RankingGet(X_API_KEY, type, exchangeDivision);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.RankingGet: " + e.Message );
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
 **type** | **string**| 種別&lt;br&gt; ※信用情報ランキングに「福証」「札証」を指定した場合は、空レスポンスになります &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;説明&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;1&lt;/td&gt;           &lt;td&gt;値上がり率（デフォルト）&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;2&lt;/td&gt;           &lt;td&gt;値下がり率&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;3&lt;/td&gt;           &lt;td&gt;売買高上位&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;4&lt;/td&gt;           &lt;td&gt;売買代金&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;5&lt;/td&gt;           &lt;td&gt;TICK回数&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;6&lt;/td&gt;           &lt;td&gt;売買高急増&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;7&lt;/td&gt;           &lt;td&gt;売買代金急増&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;8&lt;/td&gt;           &lt;td&gt;信用売残増&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;9&lt;/td&gt;           &lt;td&gt;信用売残減&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;10&lt;/td&gt;           &lt;td&gt;信用買残増&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;11&lt;/td&gt;           &lt;td&gt;信用買残減&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;12&lt;/td&gt;           &lt;td&gt;信用高倍率&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;13&lt;/td&gt;           &lt;td&gt;信用低倍率&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;14&lt;/td&gt;           &lt;td&gt;業種別値上がり率&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;15&lt;/td&gt;           &lt;td&gt;業種別値下がり率&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | 
 **exchangeDivision** | **string**| 市場&lt;br&gt; ※業種別値上がり率・値下がり率に市場を指定しても無視されます &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;説明&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;ALL&lt;/td&gt;           &lt;td&gt;全市場（デフォルト）&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;T&lt;/td&gt;           &lt;td&gt;東証全体&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;T1&lt;/td&gt;           &lt;td&gt;東証一部&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;T2&lt;/td&gt;           &lt;td&gt;東証二部&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;TM&lt;/td&gt;           &lt;td&gt;マザーズ&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;JQ&lt;/td&gt;           &lt;td&gt;JASDAQ&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;M&lt;/td&gt;           &lt;td&gt;名証&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;FK&lt;/td&gt;           &lt;td&gt;福証&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;S&lt;/td&gt;           &lt;td&gt;札証&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | 

### Return type

[**OneOfRankingDefaultResponseRankingByTickCountResponseRankingByTradeVolumeResponseRankingByTradeValueResponseRankingByMarginResponseRankingByCategoryResponse**](OneOfRankingDefaultResponseRankingByTickCountResponseRankingByTradeVolumeResponseRankingByTradeValueResponseRankingByMarginResponseRankingByCategoryResponse.md)

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

<a name="regulationsget"></a>
# **RegulationsGet**
> RegulationsResponse RegulationsGet (string X_API_KEY, string symbol)

規制情報

規制情報＋空売り規制情報を取得する

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RegulationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:18080/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var symbol = symbol_example;  // string | 銘柄コード <br> ※次の形式で入力してください。<br> [銘柄コード]@[市場コード]<br> ※市場コードは下記の定義値から選択してください。 <b>市場コード</b> <table>   <thead>       <tr>           <th>定義値</th>           <th>説明</th>       </tr>   </thead>   <tbody>       <tr>           <td>1</td>           <td>東証</td>       </tr>       <tr>           <td>3</td>           <td>名証</td>       </tr>       <tr>           <td>5</td>           <td>福証</td>       </tr>       <tr>           <td>6</td>           <td>札証</td>       </tr>   </tbody> </table>

            try
            {
                // 規制情報
                RegulationsResponse result = apiInstance.RegulationsGet(X_API_KEY, symbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.RegulationsGet: " + e.Message );
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
 **symbol** | **string**| 銘柄コード &lt;br&gt; ※次の形式で入力してください。&lt;br&gt; [銘柄コード]@[市場コード]&lt;br&gt; ※市場コードは下記の定義値から選択してください。 &lt;b&gt;市場コード&lt;/b&gt; &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;説明&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;1&lt;/td&gt;           &lt;td&gt;東証&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;3&lt;/td&gt;           &lt;td&gt;名証&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;5&lt;/td&gt;           &lt;td&gt;福証&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;6&lt;/td&gt;           &lt;td&gt;札証&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | 

### Return type

[**RegulationsResponse**](RegulationsResponse.md)

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

<a name="symbolget"></a>
# **SymbolGet**
> SymbolSuccess SymbolGet (string X_API_KEY, string symbol, string addinfo = null)

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
    public class SymbolGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:18080/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var symbol = symbol_example;  // string | 銘柄コード <br> ※次の形式で入力してください。<br> [銘柄コード]@[市場コード]<br> ※市場コードは下記の定義値から選択してください。 <b>市場コード</b> <table>   <thead>       <tr>           <th>定義値</th>           <th>説明</th>       </tr>   </thead>   <tbody>       <tr>           <td>1</td>           <td>東証</td>       </tr>       <tr>           <td>3</td>           <td>名証</td>       </tr>       <tr>           <td>5</td>           <td>福証</td>       </tr>       <tr>           <td>6</td>           <td>札証</td>       </tr>       <tr>           <td>2</td>           <td>日通し</td>       </tr>       <tr>           <td>23</td>           <td>日中</td>       </tr>       <tr>           <td>24</td>           <td>夜間</td>       </tr>   </tbody> </table>
            var addinfo = addinfo_example;  // string | 追加情報出力フラグ（未指定時：true）<br> ※追加情報は、「時価総額」、「発行済み株式数」、「決算期日」、「清算値」を意味します。 <table>   <thead>       <tr>           <th>定義値</th>           <th>説明</th>       </tr>   </thead>   <tbody>       <tr>           <td>true</td>           <td>追加情報を出力する</td>       </tr>       <tr>           <td>false</td>           <td>追加情報を出力しない</td>       </tr>   </tbody> </table> (optional) 

            try
            {
                // 銘柄情報
                SymbolSuccess result = apiInstance.SymbolGet(X_API_KEY, symbol, addinfo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.SymbolGet: " + e.Message );
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
 **symbol** | **string**| 銘柄コード &lt;br&gt; ※次の形式で入力してください。&lt;br&gt; [銘柄コード]@[市場コード]&lt;br&gt; ※市場コードは下記の定義値から選択してください。 &lt;b&gt;市場コード&lt;/b&gt; &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;説明&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;1&lt;/td&gt;           &lt;td&gt;東証&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;3&lt;/td&gt;           &lt;td&gt;名証&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;5&lt;/td&gt;           &lt;td&gt;福証&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;6&lt;/td&gt;           &lt;td&gt;札証&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;2&lt;/td&gt;           &lt;td&gt;日通し&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;23&lt;/td&gt;           &lt;td&gt;日中&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;24&lt;/td&gt;           &lt;td&gt;夜間&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | 
 **addinfo** | **string**| 追加情報出力フラグ（未指定時：true）&lt;br&gt; ※追加情報は、「時価総額」、「発行済み株式数」、「決算期日」、「清算値」を意味します。 &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;説明&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;true&lt;/td&gt;           &lt;td&gt;追加情報を出力する&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;false&lt;/td&gt;           &lt;td&gt;追加情報を出力しない&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | [optional] 

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
> SymbolNameSuccess SymbolnameFutureGet (string X_API_KEY, int derivMonth, string futureCode = null)

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
            config.BasePath = "http://localhost:18080/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var derivMonth = 56;  // int | 限月<br> ※限月はyyyyMM形式で指定します。0を指定した場合、直近限月となります。<br> ※取引最終日に「0」（直近限月）を指定した場合、日中・夜間の時間帯に関わらず、 取引最終日を迎える限月の銘柄コードを返します。取引最終日を迎える銘柄の取引は日中取引をもって終了となりますので、ご注意ください。
            var futureCode = futureCode_example;  // string | 先物コード<br> ※大文字小文字は区別しません。 <table>   <thead>       <tr>           <th>定義値</th>           <th>説明</th>       </tr>   </thead>   <tbody>       <tr>           <td>NK225</td>           <td>日経平均先物</td>       </tr>       <tr>           <td>NK225mini</td>           <td>日経225mini先物</td>       </tr>       <tr>           <td>TOPIX</td>           <td>TOPIX先物</td>       </tr>       <tr>           <td>TOPIXmini</td>           <td>ミニTOPIX先物</td>       </tr>       <tr>           <td>MOTHERS</td>           <td>東証マザーズ先物</td>       </tr>       <tr>           <td>JPX400</td>           <td>JPX日経400先物</td>       </tr>       <tr>           <td>DOW</td>           <td>NYダウ先物</td>       </tr>       <tr>           <td>VI</td>           <td>日経平均VI先物</td>       </tr>       <tr>           <td>Core30</td>           <td>TOPIX Core30先物</td>       </tr>       <tr>           <td>REIT</td>           <td>東証REIT指数先物</td>       </tr>   </tbody> </table> (optional) 

            try
            {
                // 先物銘柄コード取得
                SymbolNameSuccess result = apiInstance.SymbolnameFutureGet(X_API_KEY, derivMonth, futureCode);
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
 **derivMonth** | **int**| 限月&lt;br&gt; ※限月はyyyyMM形式で指定します。0を指定した場合、直近限月となります。&lt;br&gt; ※取引最終日に「0」（直近限月）を指定した場合、日中・夜間の時間帯に関わらず、 取引最終日を迎える限月の銘柄コードを返します。取引最終日を迎える銘柄の取引は日中取引をもって終了となりますので、ご注意ください。 | 
 **futureCode** | **string**| 先物コード&lt;br&gt; ※大文字小文字は区別しません。 &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;説明&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;NK225&lt;/td&gt;           &lt;td&gt;日経平均先物&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;NK225mini&lt;/td&gt;           &lt;td&gt;日経225mini先物&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;TOPIX&lt;/td&gt;           &lt;td&gt;TOPIX先物&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;TOPIXmini&lt;/td&gt;           &lt;td&gt;ミニTOPIX先物&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;MOTHERS&lt;/td&gt;           &lt;td&gt;東証マザーズ先物&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;JPX400&lt;/td&gt;           &lt;td&gt;JPX日経400先物&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;DOW&lt;/td&gt;           &lt;td&gt;NYダウ先物&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;VI&lt;/td&gt;           &lt;td&gt;日経平均VI先物&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;Core30&lt;/td&gt;           &lt;td&gt;TOPIX Core30先物&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;REIT&lt;/td&gt;           &lt;td&gt;東証REIT指数先物&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | [optional] 

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
            config.BasePath = "http://localhost:18080/kabusapi";
            var apiInstance = new InfoApi(config);
            var X_API_KEY = X_API_KEY_example;  // string | トークン発行メソッドで取得した文字列
            var derivMonth = 56;  // int | 限月<br>※限月はyyyyMM形式で指定します。0を指定した場合、直近限月となります。<br>※取引最終日に「0」（直近限月）を指定した場合、日中・夜間の時間帯に関わらず、取引最終日を迎える限月の銘柄コードを返します。取引最終日を迎える銘柄の取引は日中取引をもって終了となりますので、ご注意ください。
            var putOrCall = putOrCall_example;  // string | コール or プット<br> ※大文字小文字は区別しません。 <table>   <thead>       <tr>           <th>定義値</th>           <th>説明</th>       </tr>   </thead>   <tbody>       <tr>           <td>P</td>           <td>PUT</td>       </tr>       <tr>           <td>C</td>           <td>CALL</td>       </tr>   </tbody> </table>
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
 **putOrCall** | **string**| コール or プット&lt;br&gt; ※大文字小文字は区別しません。 &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;説明&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;P&lt;/td&gt;           &lt;td&gt;PUT&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;C&lt;/td&gt;           &lt;td&gt;CALL&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | 
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

