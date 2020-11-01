# Org.OpenAPITools.Model.SymbolSuccess
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Symbol** | **string** | 銘柄コード | [optional] 
**SymbolName** | **string** | 銘柄名 | [optional] 
**DisplayName** | **string** | 銘柄略称&lt;br&gt;※株式・先物・オプション銘柄の場合のみ | [optional] 
**Exchange** | **int** | 市場コード&lt;br&gt;※株式・先物・オプション銘柄の場合のみ |定義値|説明| |-|-| |1|東証| |3|名証| |5|福証| |6|札証| |2|日通し| |23|日中| |24|夜間| | [optional] 
**ExchangeName** | **string** | 市場名称&lt;br&gt;※株式・先物・オプション銘柄の場合のみ | [optional] 
**BisCategory** | **string** | 業種コード名&lt;br&gt;※株式銘柄の場合のみ |定義値|説明| |-|-| |0050      |水産・農林業| |1050      |鉱業| |2050      |建設業| |3050      |食料品| |3100      |繊維製品| |3150      |パルプ・紙| |3200      |化学| |3250      |医薬品| |3300      |石油・石炭製品| |3350      |ゴム製品| |3400      |ガラス・土石製品| |3450      |鉄鋼| |3500      |非鉄金属| |3550      |金属製品| |3600      |機械| |3650      |電気機器| |3700      |輸送用機器| |3750      |精密機器| |3800      |その他製品| |4050      |電気・ガス業| |5050      |陸運業| |5100      |海運業| |5150      |空運業| |5200      |倉庫・運輸関連業| |5250      |情報・通信業| |6050      |卸売業| |6100      |小売業| |7050      |銀行業| |7100      |証券、商品先物取引業| |7150      |保険業| |7200      |その他金融業| |8050      |不動産業| |9050      |サービス業| |9999      |その他| | [optional] 
**TotalMarketValue** | **double** | 時価総額&lt;br&gt;※株式銘柄の場合のみ | [optional] 
**TotalStocks** | **double** | 発行済み株式数（千株）&lt;br&gt;※株式銘柄の場合のみ | [optional] 
**TradingUnit** | **double** | 売買単位&lt;br&gt;※株式・先物・オプション銘柄の場合のみ | [optional] 
**FiscalYearEndBasic** | **int** | 決算期日&lt;br&gt;※株式銘柄の場合のみ | [optional] 
**PriceRangeGroup** | **string** | 呼値グループ&lt;br&gt;※株式・先物・オプション銘柄の場合のみ |呼値コード|値段の水準|呼値単位| |-|-|-| |10000|3000円以下|1 |10000|5000円以下|5 |10000|30000円以下|10 |10000|50000円以下|50 |10000|300000円以下|100 |10000|500000円以下|500 |10000|3000000円以下|1000 |10000|5000000円以下|5000 |10000|30000000円以下|10000 |10000|50000000円以下|50000 |10000|50000000円超|100000 |10003|1000円以下|0.1 |10003|3000円以下|0.5 |10003|10000円以下|1 |10003|30000円以下|5 |10003|100000円以下|10 |10003|300000円以下|50 |10003|1000000円以下|100 |10003|3000000円以下|500 |10003|10000000円以下|1000 |10003|30000000円以下|5000 |10003|50000000円以下|10000 |10003|50000000円超|10000 |10118|-|10 |10119|-|5 |10318|100円以下|1 |10318|1000円以下|5 |10318|1000円超|10 |10706|-|0.25 |10718|-|0.5 |12122|-|5 |14473|-|1 |14515|-|0.05 |15411|-|1 |15569|-|0.5 |17163|-|0.5 | [optional] 
**KCMarginBuy** | **bool** | 一般信用買建フラグ&lt;br&gt;※trueのとき一般信用買建可能&lt;br&gt;※株式銘柄の場合のみ | [optional] 
**KCMarginSell** | **bool** | 一般信用売建フラグ&lt;br&gt;※trueのとき一般信用売建可能&lt;br&gt;※株式銘柄の場合のみ | [optional] 
**MarginBuy** | **bool** | 制度信用買建フラグ&lt;br&gt;※trueのとき制度信用買建可能&lt;br&gt;※株式銘柄の場合のみ | [optional] 
**MarginSell** | **bool** | 制度信用売建フラグ&lt;br&gt;※trueのとき制度信用売建可能&lt;br&gt;※株式銘柄の場合のみ | [optional] 
**UpperLimit** | **double** | 値幅上限&lt;br&gt;※株式・先物・オプション銘柄の場合のみ | [optional] 
**LowerLimit** | **double** | 値幅下限&lt;br&gt;※株式・先物・オプション銘柄の場合のみ | [optional] 
**Underlyer** | **string** | 原資産コード&lt;br&gt;※先物・オプション銘柄の場合のみ |定義値|説明| |-|-| |NK225|日経225| |NK300|日経300| |MOTHERS|東証マザーズ| |JPX400|JPX日経400| |TOPIX|TOPIX| |NKVI|日経平均VI| |DJIA|NYダウ| |TSEREITINDEX|東証REIT指数| |TOPIXCORE30|TOPIX Core30| | [optional] 
**DerivMonth** | **string** | 限月-年月&lt;br&gt;※「限月-年月」は「年(yyyy)/月(MM)」で表示します。&lt;br&gt;※先物・オプション銘柄の場合のみ | [optional] 
**TradeStart** | **int** | 取引開始日&lt;br&gt;※先物・オプション銘柄の場合のみ | [optional] 
**TradeEnd** | **int** | 取引終了日&lt;br&gt;※先物・オプション銘柄の場合のみ | [optional] 
**StrikePrice** | **double** | 権利行使価格&lt;br&gt;※オプション銘柄の場合のみ | [optional] 
**PutOrCall** | **int** | プット/コール区分&lt;br&gt;※オプション銘柄の場合のみ |定義値|説明| |-|-| |1|プット| |2|コール| | [optional] 
**ClearingPrice** | **double** | 清算値&lt;br&gt;※先物銘柄の場合のみ | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

