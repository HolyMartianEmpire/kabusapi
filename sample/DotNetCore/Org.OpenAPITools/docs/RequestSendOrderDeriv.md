# Org.OpenAPITools.Model.RequestSendOrderDeriv
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Password** | **string** | 注文パスワード | 
**Symbol** | **string** | 銘柄コード | 
**Exchange** | **int** | 市場コード |定義値|説明| |-|-| |2|日通し| |23|日中| |24|夜間| | 
**TradeType** | **int** | 取引区分 |定義値|説明| |-|-| |1|新規| |2|返済| | 
**TimeInForce** | **int** | 有効期間条件 |定義値|説明| |-|-| |1|FAS&lt;br&gt;※FASを指定した場合、FrontOrderTypeは指値(20)のみ指定可能。| |2|FAK&lt;br&gt;※FAKを指定した場合、Exchangeは日中(23)、夜間(24)のみ指定可能。| |3|FOK&lt;br&gt;※FOKを指定した場合、Exchangeは日中(23)、夜間(24)のみ指定可能。| | 
**Side** | **string** | 売買区分 |定義値|説明| |-|-| |1|売| |2|買| | 
**Qty** | **int** | 注文数量 | 
**ClosePositionOrder** | **int** | 決済順序&lt;br&gt;※ClosePositionOrderとClosePositionsはどちらか一方のみ指定可能。&lt;br&gt;※ClosePositionOrderとClosePositionsを両方指定した場合、エラー。 |定義値|説明| |-|-| |0|日付（古い順）、損益（高い順）| |1|日付（古い順）、損益（低い順）| |2|日付（新しい順）、損益（高い順）| |3|日付（新しい順）、損益（低い順）| |4|損益（高い順）、日付（古い順）| |5|損益（高い順）、日付（新しい順）| |6|損益（低い順）、日付（古い順）| |7|損益（低い順）、日付（新しい順）| | [optional] 
**ClosePositions** | [**List&lt;PositionsDeriv&gt;**](PositionsDeriv.md) | 返済建玉指定&lt;br&gt;※ClosePositionOrderとClosePositionsはどちらか一方のみ指定可能。&lt;br&gt;※ClosePositionOrderとClosePositionsを両方指定した場合、エラー。 | [optional] 
**FrontOrderType** | **int** | 執行条件 |定義値|説明|”Price”の指定| |-|-|-| |18|引成（派生）&lt;br&gt;※TimeInForceは、「FAK」のみ有効|0| |20|指値|発注したい金額| |28|引指（派生）&lt;br&gt;※TimeInForceは、「FAS」のみ有効|発注したい金額| |120|成行（マーケットオーダー）|0| | 
**Price** | **int** | 注文価格&lt;br&gt;※FrontOrderTypeで成行を指定した場合、0を指定する。&lt;br&gt;※詳細について、”FrontOrderType”をご確認ください。 | 
**ExpireDay** | **int** | 注文有効期限&lt;br&gt; yyyyMMdd形式。&lt;br&gt; 「0」を指定すると、kabuステーション上の発注画面の「本日」に対応する日付として扱います。&lt;br&gt; 「本日」は直近の注文可能日となり、以下のように設定されます。&lt;br&gt; その市場の引けまでの間 : 当日&lt;br&gt; その市場の引け後       : 翌取引所営業日&lt;br&gt; その市場の休前日       : 休日明けの取引所営業日&lt;br&gt; ※ 日替わりはkabuステーションが日付変更通知を受信したタイミングです。&lt;br&gt; ※ 日通しの場合、夜間取引の引け後に日付が更新されます。 | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

