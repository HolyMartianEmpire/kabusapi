/*
 * kabuステーションAPI
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.5
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// RequestSendOrderDeriv
    /// </summary>
    [DataContract(Name = "RequestSendOrderDeriv")]
    public partial class RequestSendOrderDeriv : IEquatable<RequestSendOrderDeriv>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestSendOrderDeriv" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestSendOrderDeriv() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestSendOrderDeriv" /> class.
        /// </summary>
        /// <param name="password">注文パスワード (required).</param>
        /// <param name="symbol">銘柄コード (required).</param>
        /// <param name="exchange">市場コード |定義値|説明| |-|-| |2|日通し| |23|日中| |24|夜間| (required).</param>
        /// <param name="tradeType">取引区分 |定義値|説明| |-|-| |1|新規| |2|返済| (required).</param>
        /// <param name="timeInForce">有効期間条件 |定義値|説明| |-|-| |1|FAS&lt;br&gt;※FASを指定した場合、FrontOrderTypeは指値(20)のみ指定可能。| |2|FAK&lt;br&gt;※FAKを指定した場合、Exchangeは日中(23)、夜間(24)のみ指定可能。| |3|FOK&lt;br&gt;※FOKを指定した場合、Exchangeは日中(23)、夜間(24)のみ指定可能。| (required).</param>
        /// <param name="side">売買区分 |定義値|説明| |-|-| |1|売| |2|買| (required).</param>
        /// <param name="qty">注文数量 (required).</param>
        /// <param name="closePositionOrder">決済順序&lt;br&gt;※ClosePositionOrderとClosePositionsはどちらか一方のみ指定可能。&lt;br&gt;※ClosePositionOrderとClosePositionsを両方指定した場合、エラー。 |定義値|説明| |-|-| |0|日付（古い順）、損益（高い順）| |1|日付（古い順）、損益（低い順）| |2|日付（新しい順）、損益（高い順）| |3|日付（新しい順）、損益（低い順）| |4|損益（高い順）、日付（古い順）| |5|損益（高い順）、日付（新しい順）| |6|損益（低い順）、日付（古い順）| |7|損益（低い順）、日付（新しい順）|.</param>
        /// <param name="closePositions">返済建玉指定&lt;br&gt;※ClosePositionOrderとClosePositionsはどちらか一方のみ指定可能。&lt;br&gt;※ClosePositionOrderとClosePositionsを両方指定した場合、エラー。.</param>
        /// <param name="frontOrderType">執行条件 |定義値|説明|”Price”の指定| |-|-|-| |18|引成（派生）&lt;br&gt;※TimeInForceは、「FAK」のみ有効|0| |20|指値|発注したい金額| |28|引指（派生）&lt;br&gt;※TimeInForceは、「FAS」のみ有効|発注したい金額| |120|成行（マーケットオーダー）|0| (required).</param>
        /// <param name="price">注文価格&lt;br&gt;※FrontOrderTypeで成行を指定した場合、0を指定する。&lt;br&gt;※詳細について、”FrontOrderType”をご確認ください。 (required).</param>
        /// <param name="expireDay">注文有効期限&lt;br&gt; yyyyMMdd形式。&lt;br&gt; 「0」を指定すると、kabuステーション上の発注画面の「本日」に対応する日付として扱います。&lt;br&gt; 「本日」は直近の注文可能日となり、以下のように設定されます。&lt;br&gt; その市場の引けまでの間 : 当日&lt;br&gt; その市場の引け後       : 翌取引所営業日&lt;br&gt; その市場の休前日       : 休日明けの取引所営業日&lt;br&gt; ※ 日替わりはkabuステーションが日付変更通知を受信したタイミングです。&lt;br&gt; ※ 日通しの場合、夜間取引の引け後に日付が更新されます。 (required).</param>
        public RequestSendOrderDeriv(string password = default(string), string symbol = default(string), int exchange = default(int), int tradeType = default(int), int timeInForce = default(int), string side = default(string), int qty = default(int), int closePositionOrder = default(int), List<PositionsDeriv> closePositions = default(List<PositionsDeriv>), int frontOrderType = default(int), int price = default(int), int expireDay = default(int))
        {
            // to ensure "password" is required (not null)
            this.Password = password ?? throw new ArgumentNullException("password is a required property for RequestSendOrderDeriv and cannot be null");
            // to ensure "symbol" is required (not null)
            this.Symbol = symbol ?? throw new ArgumentNullException("symbol is a required property for RequestSendOrderDeriv and cannot be null");
            this.Exchange = exchange;
            this.TradeType = tradeType;
            this.TimeInForce = timeInForce;
            // to ensure "side" is required (not null)
            this.Side = side ?? throw new ArgumentNullException("side is a required property for RequestSendOrderDeriv and cannot be null");
            this.Qty = qty;
            this.FrontOrderType = frontOrderType;
            this.Price = price;
            this.ExpireDay = expireDay;
            this.ClosePositionOrder = closePositionOrder;
            this.ClosePositions = closePositions;
        }

        /// <summary>
        /// 注文パスワード
        /// </summary>
        /// <value>注文パスワード</value>
        [DataMember(Name = "Password", IsRequired = true, EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// 銘柄コード
        /// </summary>
        /// <value>銘柄コード</value>
        [DataMember(Name = "Symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// 市場コード |定義値|説明| |-|-| |2|日通し| |23|日中| |24|夜間|
        /// </summary>
        /// <value>市場コード |定義値|説明| |-|-| |2|日通し| |23|日中| |24|夜間|</value>
        [DataMember(Name = "Exchange", IsRequired = true, EmitDefaultValue = true)]
        public int Exchange { get; set; }

        /// <summary>
        /// 取引区分 |定義値|説明| |-|-| |1|新規| |2|返済|
        /// </summary>
        /// <value>取引区分 |定義値|説明| |-|-| |1|新規| |2|返済|</value>
        [DataMember(Name = "TradeType", IsRequired = true, EmitDefaultValue = true)]
        public int TradeType { get; set; }

        /// <summary>
        /// 有効期間条件 |定義値|説明| |-|-| |1|FAS&lt;br&gt;※FASを指定した場合、FrontOrderTypeは指値(20)のみ指定可能。| |2|FAK&lt;br&gt;※FAKを指定した場合、Exchangeは日中(23)、夜間(24)のみ指定可能。| |3|FOK&lt;br&gt;※FOKを指定した場合、Exchangeは日中(23)、夜間(24)のみ指定可能。|
        /// </summary>
        /// <value>有効期間条件 |定義値|説明| |-|-| |1|FAS&lt;br&gt;※FASを指定した場合、FrontOrderTypeは指値(20)のみ指定可能。| |2|FAK&lt;br&gt;※FAKを指定した場合、Exchangeは日中(23)、夜間(24)のみ指定可能。| |3|FOK&lt;br&gt;※FOKを指定した場合、Exchangeは日中(23)、夜間(24)のみ指定可能。|</value>
        [DataMember(Name = "TimeInForce", IsRequired = true, EmitDefaultValue = true)]
        public int TimeInForce { get; set; }

        /// <summary>
        /// 売買区分 |定義値|説明| |-|-| |1|売| |2|買|
        /// </summary>
        /// <value>売買区分 |定義値|説明| |-|-| |1|売| |2|買|</value>
        [DataMember(Name = "Side", IsRequired = true, EmitDefaultValue = true)]
        public string Side { get; set; }

        /// <summary>
        /// 注文数量
        /// </summary>
        /// <value>注文数量</value>
        [DataMember(Name = "Qty", IsRequired = true, EmitDefaultValue = true)]
        public int Qty { get; set; }

        /// <summary>
        /// 決済順序&lt;br&gt;※ClosePositionOrderとClosePositionsはどちらか一方のみ指定可能。&lt;br&gt;※ClosePositionOrderとClosePositionsを両方指定した場合、エラー。 |定義値|説明| |-|-| |0|日付（古い順）、損益（高い順）| |1|日付（古い順）、損益（低い順）| |2|日付（新しい順）、損益（高い順）| |3|日付（新しい順）、損益（低い順）| |4|損益（高い順）、日付（古い順）| |5|損益（高い順）、日付（新しい順）| |6|損益（低い順）、日付（古い順）| |7|損益（低い順）、日付（新しい順）|
        /// </summary>
        /// <value>決済順序&lt;br&gt;※ClosePositionOrderとClosePositionsはどちらか一方のみ指定可能。&lt;br&gt;※ClosePositionOrderとClosePositionsを両方指定した場合、エラー。 |定義値|説明| |-|-| |0|日付（古い順）、損益（高い順）| |1|日付（古い順）、損益（低い順）| |2|日付（新しい順）、損益（高い順）| |3|日付（新しい順）、損益（低い順）| |4|損益（高い順）、日付（古い順）| |5|損益（高い順）、日付（新しい順）| |6|損益（低い順）、日付（古い順）| |7|損益（低い順）、日付（新しい順）|</value>
        [DataMember(Name = "ClosePositionOrder", EmitDefaultValue = true)]
        public int ClosePositionOrder { get; set; }

        /// <summary>
        /// 返済建玉指定&lt;br&gt;※ClosePositionOrderとClosePositionsはどちらか一方のみ指定可能。&lt;br&gt;※ClosePositionOrderとClosePositionsを両方指定した場合、エラー。
        /// </summary>
        /// <value>返済建玉指定&lt;br&gt;※ClosePositionOrderとClosePositionsはどちらか一方のみ指定可能。&lt;br&gt;※ClosePositionOrderとClosePositionsを両方指定した場合、エラー。</value>
        [DataMember(Name = "ClosePositions", EmitDefaultValue = true)]
        public List<PositionsDeriv> ClosePositions { get; set; }

        /// <summary>
        /// 執行条件 |定義値|説明|”Price”の指定| |-|-|-| |18|引成（派生）&lt;br&gt;※TimeInForceは、「FAK」のみ有効|0| |20|指値|発注したい金額| |28|引指（派生）&lt;br&gt;※TimeInForceは、「FAS」のみ有効|発注したい金額| |120|成行（マーケットオーダー）|0|
        /// </summary>
        /// <value>執行条件 |定義値|説明|”Price”の指定| |-|-|-| |18|引成（派生）&lt;br&gt;※TimeInForceは、「FAK」のみ有効|0| |20|指値|発注したい金額| |28|引指（派生）&lt;br&gt;※TimeInForceは、「FAS」のみ有効|発注したい金額| |120|成行（マーケットオーダー）|0|</value>
        [DataMember(Name = "FrontOrderType", IsRequired = true, EmitDefaultValue = true)]
        public int FrontOrderType { get; set; }

        /// <summary>
        /// 注文価格&lt;br&gt;※FrontOrderTypeで成行を指定した場合、0を指定する。&lt;br&gt;※詳細について、”FrontOrderType”をご確認ください。
        /// </summary>
        /// <value>注文価格&lt;br&gt;※FrontOrderTypeで成行を指定した場合、0を指定する。&lt;br&gt;※詳細について、”FrontOrderType”をご確認ください。</value>
        [DataMember(Name = "Price", IsRequired = true, EmitDefaultValue = true)]
        public int Price { get; set; }

        /// <summary>
        /// 注文有効期限&lt;br&gt; yyyyMMdd形式。&lt;br&gt; 「0」を指定すると、kabuステーション上の発注画面の「本日」に対応する日付として扱います。&lt;br&gt; 「本日」は直近の注文可能日となり、以下のように設定されます。&lt;br&gt; その市場の引けまでの間 : 当日&lt;br&gt; その市場の引け後       : 翌取引所営業日&lt;br&gt; その市場の休前日       : 休日明けの取引所営業日&lt;br&gt; ※ 日替わりはkabuステーションが日付変更通知を受信したタイミングです。&lt;br&gt; ※ 日通しの場合、夜間取引の引け後に日付が更新されます。
        /// </summary>
        /// <value>注文有効期限&lt;br&gt; yyyyMMdd形式。&lt;br&gt; 「0」を指定すると、kabuステーション上の発注画面の「本日」に対応する日付として扱います。&lt;br&gt; 「本日」は直近の注文可能日となり、以下のように設定されます。&lt;br&gt; その市場の引けまでの間 : 当日&lt;br&gt; その市場の引け後       : 翌取引所営業日&lt;br&gt; その市場の休前日       : 休日明けの取引所営業日&lt;br&gt; ※ 日替わりはkabuステーションが日付変更通知を受信したタイミングです。&lt;br&gt; ※ 日通しの場合、夜間取引の引け後に日付が更新されます。</value>
        [DataMember(Name = "ExpireDay", IsRequired = true, EmitDefaultValue = true)]
        public int ExpireDay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestSendOrderDeriv {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  TradeType: ").Append(TradeType).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  ClosePositionOrder: ").Append(ClosePositionOrder).Append("\n");
            sb.Append("  ClosePositions: ").Append(ClosePositions).Append("\n");
            sb.Append("  FrontOrderType: ").Append(FrontOrderType).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  ExpireDay: ").Append(ExpireDay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RequestSendOrderDeriv);
        }

        /// <summary>
        /// Returns true if RequestSendOrderDeriv instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestSendOrderDeriv to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestSendOrderDeriv input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Exchange == input.Exchange ||
                    this.Exchange.Equals(input.Exchange)
                ) && 
                (
                    this.TradeType == input.TradeType ||
                    this.TradeType.Equals(input.TradeType)
                ) && 
                (
                    this.TimeInForce == input.TimeInForce ||
                    this.TimeInForce.Equals(input.TimeInForce)
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.Qty == input.Qty ||
                    this.Qty.Equals(input.Qty)
                ) && 
                (
                    this.ClosePositionOrder == input.ClosePositionOrder ||
                    this.ClosePositionOrder.Equals(input.ClosePositionOrder)
                ) && 
                (
                    this.ClosePositions == input.ClosePositions ||
                    this.ClosePositions != null &&
                    input.ClosePositions != null &&
                    this.ClosePositions.SequenceEqual(input.ClosePositions)
                ) && 
                (
                    this.FrontOrderType == input.FrontOrderType ||
                    this.FrontOrderType.Equals(input.FrontOrderType)
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.ExpireDay == input.ExpireDay ||
                    this.ExpireDay.Equals(input.ExpireDay)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                hashCode = hashCode * 59 + this.Exchange.GetHashCode();
                hashCode = hashCode * 59 + this.TradeType.GetHashCode();
                hashCode = hashCode * 59 + this.TimeInForce.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                hashCode = hashCode * 59 + this.Qty.GetHashCode();
                hashCode = hashCode * 59 + this.ClosePositionOrder.GetHashCode();
                if (this.ClosePositions != null)
                    hashCode = hashCode * 59 + this.ClosePositions.GetHashCode();
                hashCode = hashCode * 59 + this.FrontOrderType.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                hashCode = hashCode * 59 + this.ExpireDay.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
