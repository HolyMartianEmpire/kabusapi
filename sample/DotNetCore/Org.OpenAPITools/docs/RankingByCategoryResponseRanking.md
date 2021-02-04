# Org.OpenAPITools.Model.RankingByCategoryResponseRanking
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**No** | **int** | 順位&lt;br&gt;※ランキング内で同じ順位が返却される場合があります（10位が2件など） | [optional] 
**Trend** | **string** | トレンド &lt;table&gt;   &lt;thead&gt;       &lt;tr&gt;           &lt;th&gt;定義値&lt;/th&gt;           &lt;th&gt;内容&lt;/th&gt;       &lt;/tr&gt;   &lt;/thead&gt;   &lt;tbody&gt;       &lt;tr&gt;           &lt;td&gt;0&lt;/td&gt;           &lt;td&gt;対象データ無し&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;1&lt;/td&gt;           &lt;td&gt;過去10営業日より20位以上上昇&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;2&lt;/td&gt;           &lt;td&gt;過去10営業日より1～19位上昇&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;3&lt;/td&gt;           &lt;td&gt;過去10営業日と変わらず&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;4&lt;/td&gt;           &lt;td&gt;過去10営業日より1～19位下落&lt;/td&gt;       &lt;/tr&gt;       &lt;tr&gt;           &lt;td&gt;5&lt;/td&gt;           &lt;td&gt;過去10営業日より20位以上下落&lt;/td&gt;       &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; | [optional] 
**AverageRanking** | **double** | 平均順位&lt;br&gt;※100位以下は「999」となります | [optional] 
**Category** | **string** | 業種コード | [optional] 
**CategoryName** | **string** | 業種名 | [optional] 
**CurrentPrice** | **double** | 現在値 | [optional] 
**ChangeRatio** | **double** | 前日比 | [optional] 
**CurrentPriceTime** | **string** | 時刻&lt;br&gt;HH:mm&lt;br&gt;※日付は返しません | [optional] 
**ChangePercentage** | **double** | 騰落率（%） | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

