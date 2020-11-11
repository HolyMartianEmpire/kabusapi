# Org.OpenAPITools.Model.RequestSendOrder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Password** | **string** | 注文パスワード | 
**Symbol** | **string** | 銘柄コード | 
**Exchange** | **int** | 市場コード |定義値|説明| |-|-| |1|東証| |3|名証| |5|福証| |6|札証| | 
**SecurityType** | **int** | 商品種別 |定義値|説明| |-|-| |1|株式| | 
**Side** | **string** | 売買区分 |定義値|説明| |-|-| |1|売| |2|買| | 
**CashMargin** | **int** | 現物信用区分 |定義値|説明| |-|-| |1|現物| |2|信用新規| |3|信用返済| | 
**MarginTradeType** | **int** | 信用取引区分&lt;br&gt;※現物取引の場合は省略可。&lt;br&gt;※信用取引の場合、必須。 |定義値|説明| |-|-| |1|制度信用| |2|一般信用| |3|一般信用（売短）| | 
**DelivType** | **int** | 受渡区分&lt;br&gt;※現物買は指定必須。&lt;br&gt;※現物売は「0(指定なし)」を設定&lt;br&gt;※信用新規は「0(指定なし)」を設定&lt;br&gt;※信用返済は指定必須 |定義値|説明| |-|-| |0|指定なし| |1|自動振替| |2|お預り金| | 
**FundType** | **string** | 資産区分 (預り区分)&lt;br&gt;※現物買は、指定必須。&lt;br&gt;※現物売は、「&#39;  &#39;」 半角スペース2つを指定必須。&lt;br&gt;※信用新規と信用返済は、指定不要。 |定義値|説明| |-|-| |(半角スペース2つ)|現物売の場合| |02|保護| |AA|信用代用| |BB|証拠金代用| |11|信用取引| | 
**AccountType** | **int** | 口座種別 |定義値|説明| |-|-| |2|一般| |4|特定| |12|法人| | 
**Qty** | **int** | 注文数量&lt;br&gt;※信用一括返済の場合、返済したい合計数量を入力してください。 | 
**ClosePositionOrder** | **int** | 決済順序&lt;br&gt;※信用返済の場合、必須。&lt;br&gt;※ClosePositionOrderとClosePositionsはどちらか一方のみ指定可能。&lt;br&gt;※ClosePositionOrderとClosePositionsを両方指定した場合、エラー。 |定義値|説明| |-|-| |0|日付（古い順）、損益（高い順）| |1|日付（古い順）、損益（低い順）| |2|日付（新しい順）、損益（高い順）| |3|日付（新しい順）、損益（低い順）| |4|損益（高い順）、日付（古い順）| |5|損益（高い順）、日付（新しい順）| |6|損益（低い順）、日付（古い順）| |7|損益（低い順）、日付（新しい順）| | 
**ClosePositions** | [**List&lt;Positions&gt;**](Positions.md) | 返済建玉指定&lt;br&gt;※信用返済の場合、必須。&lt;br&gt;※ClosePositionOrderとClosePositionsはどちらか一方のみ指定可能。&lt;br&gt;※ClosePositionOrderとClosePositionsを両方指定した場合、エラー。&lt;br&gt;※信用一括返済の場合、各建玉IDと返済したい数量を入力してください。&lt;br&gt;※建玉IDは「E」から始まる番号です。 | 
**Price** | **int** | 注文価格&lt;br&gt;※FrontOrderTypeで成行を指定した場合、0を指定する。 | 
**ExpireDay** | **int** | 注文有効期限&lt;br&gt; yyyyMMdd形式。&lt;br&gt; 「0」を指定すると、kabuステーション上の発注画面の「本日」に対応する日付として扱います。&lt;br&gt; 「本日」は直近の注文可能日となり、以下のように設定されます。&lt;br&gt; 引けまでの間 : 当日&lt;br&gt; 引け後       : 翌取引所営業日&lt;br&gt; 休前日       : 休日明けの取引所営業日&lt;br&gt; ※ 日替わりはkabuステーションが日付変更通知を受信したタイミングです。 | 
**FrontOrderType** | **int** | 執行条件 |定義値|説明| |-|-| |10|成行| |13|寄成（前場）| |14|寄成（後場）| |15|引成（前場）| |16|引成（後場）| |17|IOC成行| |20|指値| |21|寄指（前場）| |22|寄指（後場）| |23|引指（前場）| |24|引指（後場）| |25|不成（前場）| |26|不成（後場）| |27|IOC指値| | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

