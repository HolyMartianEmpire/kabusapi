# Org.OpenAPITools.Model.BoardSuccessBuy1
買気配数量1本目
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Time** | **DateTime** | 時刻&lt;br&gt;※株式銘柄の場合のみ | [optional] 
**Sign** | **string** | 気配フラグ&lt;br&gt;※株式・先物・オプション銘柄の場合のみ |定義値|説明| |-|-| |0000|事象なし| |0101|一般気配| |0102|特別気配| |0103|注意気配| |0107|寄前気配| |0108|停止前特別気配| |0109|引け後気配| |0116|寄前気配約定成立ポイントなし| |0117|寄前気配約定成立ポイントあり| |0118|連続約定気配| |0119|停止前の連続約定気配| |0120|買い上がり売り下がり中| | [optional] 
**Price** | **double** | 値段&lt;br&gt;※株式・先物・オプション銘柄の場合のみ | [optional] 
**Qty** | **double** | 数量&lt;br&gt;※株式・先物・オプション銘柄の場合のみ | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

