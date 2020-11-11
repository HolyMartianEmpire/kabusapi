/*
 * kabuステーションAPI
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
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
    /// RequestSendOrder
    /// </summary>
    [DataContract(Name = "RequestSendOrder")]
    public partial class RequestSendOrder : IEquatable<RequestSendOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestSendOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestSendOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestSendOrder" /> class.
        /// </summary>
        /// <param name="password">注文パスワード (required).</param>
        /// <param name="symbol">銘柄コード (required).</param>
        /// <param name="exchange">市場コード |定義値|説明| |-|-| |1|東証| |3|名証| |5|福証| |6|札証| (required).</param>
        /// <param name="securityType">商品種別 |定義値|説明| |-|-| |1|株式| (required).</param>
        /// <param name="side">売買区分 |定義値|説明| |-|-| |1|売| |2|買| (required).</param>
        /// <param name="cashMargin">現物信用区分 |定義値|説明| |-|-| |1|現物| |2|信用新規| |3|信用返済| (required).</param>
        /// <param name="marginTradeType">信用取引区分&lt;br&gt;※現物取引の場合は省略可。&lt;br&gt;※信用取引の場合、必須。 |定義値|説明| |-|-| |1|制度信用| |2|一般信用| |3|一般信用（売短）| (required).</param>
        /// <param name="delivType">受渡区分&lt;br&gt;※現物買は指定必須。&lt;br&gt;※現物売は「0(指定なし)」を設定&lt;br&gt;※信用新規は「0(指定なし)」を設定&lt;br&gt;※信用返済は指定必須 |定義値|説明| |-|-| |0|指定なし| |1|自動振替| |2|お預り金| (required).</param>
        /// <param name="fundType">資産区分 (預り区分)&lt;br&gt;※現物買は、指定必須。&lt;br&gt;※現物売は、「&#39;  &#39;」 半角スペース2つを指定必須。&lt;br&gt;※信用新規と信用返済は、指定不要。 |定義値|説明| |-|-| |(半角スペース2つ)|現物売の場合| |02|保護| |AA|信用代用| |BB|証拠金代用| |11|信用取引| (required).</param>
        /// <param name="accountType">口座種別 |定義値|説明| |-|-| |2|一般| |4|特定| |12|法人| (required).</param>
        /// <param name="qty">注文数量&lt;br&gt;※信用一括返済の場合、返済したい合計数量を入力してください。 (required).</param>
        /// <param name="closePositionOrder">決済順序&lt;br&gt;※信用返済の場合、必須。&lt;br&gt;※ClosePositionOrderとClosePositionsはどちらか一方のみ指定可能。&lt;br&gt;※ClosePositionOrderとClosePositionsを両方指定した場合、エラー。 |定義値|説明| |-|-| |0|日付（古い順）、損益（高い順）| |1|日付（古い順）、損益（低い順）| |2|日付（新しい順）、損益（高い順）| |3|日付（新しい順）、損益（低い順）| |4|損益（高い順）、日付（古い順）| |5|損益（高い順）、日付（新しい順）| |6|損益（低い順）、日付（古い順）| |7|損益（低い順）、日付（新しい順）| (required).</param>
        /// <param name="closePositions">返済建玉指定&lt;br&gt;※信用返済の場合、必須。&lt;br&gt;※ClosePositionOrderとClosePositionsはどちらか一方のみ指定可能。&lt;br&gt;※ClosePositionOrderとClosePositionsを両方指定した場合、エラー。&lt;br&gt;※信用一括返済の場合、各建玉IDと返済したい数量を入力してください。&lt;br&gt;※建玉IDは「E」から始まる番号です。 (required).</param>
        /// <param name="price">注文価格&lt;br&gt;※FrontOrderTypeで成行を指定した場合、0を指定する。 (required).</param>
        /// <param name="expireDay">注文有効期限&lt;br&gt; yyyyMMdd形式。&lt;br&gt; 「0」を指定すると、kabuステーション上の発注画面の「本日」に対応する日付として扱います。&lt;br&gt; 「本日」は直近の注文可能日となり、以下のように設定されます。&lt;br&gt; 引けまでの間 : 当日&lt;br&gt; 引け後       : 翌取引所営業日&lt;br&gt; 休前日       : 休日明けの取引所営業日&lt;br&gt; ※ 日替わりはkabuステーションが日付変更通知を受信したタイミングです。 (required).</param>
        /// <param name="frontOrderType">執行条件 |定義値|説明| |-|-| |10|成行| |13|寄成（前場）| |14|寄成（後場）| |15|引成（前場）| |16|引成（後場）| |17|IOC成行| |20|指値| |21|寄指（前場）| |22|寄指（後場）| |23|引指（前場）| |24|引指（後場）| |25|不成（前場）| |26|不成（後場）| |27|IOC指値| (required).</param>
        public RequestSendOrder(string password = default(string), string symbol = default(string), int exchange = default(int), int securityType = default(int), string side = default(string), int cashMargin = default(int), int marginTradeType = default(int), int delivType = default(int), string fundType = default(string), int accountType = default(int), int qty = default(int), int closePositionOrder = default(int), List<Positions> closePositions = default(List<Positions>), int price = default(int), int expireDay = default(int), int frontOrderType = default(int))
        {
            // to ensure "password" is required (not null)
            this.Password = password ?? throw new ArgumentNullException("password is a required property for RequestSendOrder and cannot be null");
            // to ensure "symbol" is required (not null)
            this.Symbol = symbol ?? throw new ArgumentNullException("symbol is a required property for RequestSendOrder and cannot be null");
            this.Exchange = exchange;
            this.SecurityType = securityType;
            // to ensure "side" is required (not null)
            this.Side = side ?? throw new ArgumentNullException("side is a required property for RequestSendOrder and cannot be null");
            this.CashMargin = cashMargin;
            this.MarginTradeType = marginTradeType;
            this.DelivType = delivType;
            // to ensure "fundType" is required (not null)
            this.FundType = fundType ?? throw new ArgumentNullException("fundType is a required property for RequestSendOrder and cannot be null");
            this.AccountType = accountType;
            this.Qty = qty;
            this.ClosePositionOrder = closePositionOrder;
            // to ensure "closePositions" is required (not null)
            this.ClosePositions = closePositions ?? throw new ArgumentNullException("closePositions is a required property for RequestSendOrder and cannot be null");
            this.Price = price;
            this.ExpireDay = expireDay;
            this.FrontOrderType = frontOrderType;
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
        /// 市場コード |定義値|説明| |-|-| |1|東証| |3|名証| |5|福証| |6|札証|
        /// </summary>
        /// <value>市場コード |定義値|説明| |-|-| |1|東証| |3|名証| |5|福証| |6|札証|</value>
        [DataMember(Name = "Exchange", IsRequired = true, EmitDefaultValue = true)]
        public int Exchange { get; set; }

        /// <summary>
        /// 商品種別 |定義値|説明| |-|-| |1|株式|
        /// </summary>
        /// <value>商品種別 |定義値|説明| |-|-| |1|株式|</value>
        [DataMember(Name = "SecurityType", IsRequired = true, EmitDefaultValue = true)]
        public int SecurityType { get; set; }

        /// <summary>
        /// 売買区分 |定義値|説明| |-|-| |1|売| |2|買|
        /// </summary>
        /// <value>売買区分 |定義値|説明| |-|-| |1|売| |2|買|</value>
        [DataMember(Name = "Side", IsRequired = true, EmitDefaultValue = true)]
        public string Side { get; set; }

        /// <summary>
        /// 現物信用区分 |定義値|説明| |-|-| |1|現物| |2|信用新規| |3|信用返済|
        /// </summary>
        /// <value>現物信用区分 |定義値|説明| |-|-| |1|現物| |2|信用新規| |3|信用返済|</value>
        [DataMember(Name = "CashMargin", IsRequired = true, EmitDefaultValue = true)]
        public int CashMargin { get; set; }

        /// <summary>
        /// 信用取引区分&lt;br&gt;※現物取引の場合は省略可。&lt;br&gt;※信用取引の場合、必須。 |定義値|説明| |-|-| |1|制度信用| |2|一般信用| |3|一般信用（売短）|
        /// </summary>
        /// <value>信用取引区分&lt;br&gt;※現物取引の場合は省略可。&lt;br&gt;※信用取引の場合、必須。 |定義値|説明| |-|-| |1|制度信用| |2|一般信用| |3|一般信用（売短）|</value>
        [DataMember(Name = "MarginTradeType", IsRequired = true, EmitDefaultValue = true)]
        public int MarginTradeType { get; set; }

        /// <summary>
        /// 受渡区分&lt;br&gt;※現物買は指定必須。&lt;br&gt;※現物売は「0(指定なし)」を設定&lt;br&gt;※信用新規は「0(指定なし)」を設定&lt;br&gt;※信用返済は指定必須 |定義値|説明| |-|-| |0|指定なし| |1|自動振替| |2|お預り金|
        /// </summary>
        /// <value>受渡区分&lt;br&gt;※現物買は指定必須。&lt;br&gt;※現物売は「0(指定なし)」を設定&lt;br&gt;※信用新規は「0(指定なし)」を設定&lt;br&gt;※信用返済は指定必須 |定義値|説明| |-|-| |0|指定なし| |1|自動振替| |2|お預り金|</value>
        [DataMember(Name = "DelivType", IsRequired = true, EmitDefaultValue = true)]
        public int DelivType { get; set; }

        /// <summary>
        /// 資産区分 (預り区分)&lt;br&gt;※現物買は、指定必須。&lt;br&gt;※現物売は、「&#39;  &#39;」 半角スペース2つを指定必須。&lt;br&gt;※信用新規と信用返済は、指定不要。 |定義値|説明| |-|-| |(半角スペース2つ)|現物売の場合| |02|保護| |AA|信用代用| |BB|証拠金代用| |11|信用取引|
        /// </summary>
        /// <value>資産区分 (預り区分)&lt;br&gt;※現物買は、指定必須。&lt;br&gt;※現物売は、「&#39;  &#39;」 半角スペース2つを指定必須。&lt;br&gt;※信用新規と信用返済は、指定不要。 |定義値|説明| |-|-| |(半角スペース2つ)|現物売の場合| |02|保護| |AA|信用代用| |BB|証拠金代用| |11|信用取引|</value>
        [DataMember(Name = "FundType", IsRequired = true, EmitDefaultValue = true)]
        public string FundType { get; set; }

        /// <summary>
        /// 口座種別 |定義値|説明| |-|-| |2|一般| |4|特定| |12|法人|
        /// </summary>
        /// <value>口座種別 |定義値|説明| |-|-| |2|一般| |4|特定| |12|法人|</value>
        [DataMember(Name = "AccountType", IsRequired = true, EmitDefaultValue = true)]
        public int AccountType { get; set; }

        /// <summary>
        /// 注文数量&lt;br&gt;※信用一括返済の場合、返済したい合計数量を入力してください。
        /// </summary>
        /// <value>注文数量&lt;br&gt;※信用一括返済の場合、返済したい合計数量を入力してください。</value>
        [DataMember(Name = "Qty", IsRequired = true, EmitDefaultValue = true)]
        public int Qty { get; set; }

        /// <summary>
        /// 決済順序&lt;br&gt;※信用返済の場合、必須。&lt;br&gt;※ClosePositionOrderとClosePositionsはどちらか一方のみ指定可能。&lt;br&gt;※ClosePositionOrderとClosePositionsを両方指定した場合、エラー。 |定義値|説明| |-|-| |0|日付（古い順）、損益（高い順）| |1|日付（古い順）、損益（低い順）| |2|日付（新しい順）、損益（高い順）| |3|日付（新しい順）、損益（低い順）| |4|損益（高い順）、日付（古い順）| |5|損益（高い順）、日付（新しい順）| |6|損益（低い順）、日付（古い順）| |7|損益（低い順）、日付（新しい順）|
        /// </summary>
        /// <value>決済順序&lt;br&gt;※信用返済の場合、必須。&lt;br&gt;※ClosePositionOrderとClosePositionsはどちらか一方のみ指定可能。&lt;br&gt;※ClosePositionOrderとClosePositionsを両方指定した場合、エラー。 |定義値|説明| |-|-| |0|日付（古い順）、損益（高い順）| |1|日付（古い順）、損益（低い順）| |2|日付（新しい順）、損益（高い順）| |3|日付（新しい順）、損益（低い順）| |4|損益（高い順）、日付（古い順）| |5|損益（高い順）、日付（新しい順）| |6|損益（低い順）、日付（古い順）| |7|損益（低い順）、日付（新しい順）|</value>
        [DataMember(Name = "ClosePositionOrder", IsRequired = true, EmitDefaultValue = true)]
        public int ClosePositionOrder { get; set; }

        /// <summary>
        /// 返済建玉指定&lt;br&gt;※信用返済の場合、必須。&lt;br&gt;※ClosePositionOrderとClosePositionsはどちらか一方のみ指定可能。&lt;br&gt;※ClosePositionOrderとClosePositionsを両方指定した場合、エラー。&lt;br&gt;※信用一括返済の場合、各建玉IDと返済したい数量を入力してください。&lt;br&gt;※建玉IDは「E」から始まる番号です。
        /// </summary>
        /// <value>返済建玉指定&lt;br&gt;※信用返済の場合、必須。&lt;br&gt;※ClosePositionOrderとClosePositionsはどちらか一方のみ指定可能。&lt;br&gt;※ClosePositionOrderとClosePositionsを両方指定した場合、エラー。&lt;br&gt;※信用一括返済の場合、各建玉IDと返済したい数量を入力してください。&lt;br&gt;※建玉IDは「E」から始まる番号です。</value>
        [DataMember(Name = "ClosePositions", IsRequired = true, EmitDefaultValue = true)]
        public List<Positions> ClosePositions { get; set; }

        /// <summary>
        /// 注文価格&lt;br&gt;※FrontOrderTypeで成行を指定した場合、0を指定する。
        /// </summary>
        /// <value>注文価格&lt;br&gt;※FrontOrderTypeで成行を指定した場合、0を指定する。</value>
        [DataMember(Name = "Price", IsRequired = true, EmitDefaultValue = true)]
        public int Price { get; set; }

        /// <summary>
        /// 注文有効期限&lt;br&gt; yyyyMMdd形式。&lt;br&gt; 「0」を指定すると、kabuステーション上の発注画面の「本日」に対応する日付として扱います。&lt;br&gt; 「本日」は直近の注文可能日となり、以下のように設定されます。&lt;br&gt; 引けまでの間 : 当日&lt;br&gt; 引け後       : 翌取引所営業日&lt;br&gt; 休前日       : 休日明けの取引所営業日&lt;br&gt; ※ 日替わりはkabuステーションが日付変更通知を受信したタイミングです。
        /// </summary>
        /// <value>注文有効期限&lt;br&gt; yyyyMMdd形式。&lt;br&gt; 「0」を指定すると、kabuステーション上の発注画面の「本日」に対応する日付として扱います。&lt;br&gt; 「本日」は直近の注文可能日となり、以下のように設定されます。&lt;br&gt; 引けまでの間 : 当日&lt;br&gt; 引け後       : 翌取引所営業日&lt;br&gt; 休前日       : 休日明けの取引所営業日&lt;br&gt; ※ 日替わりはkabuステーションが日付変更通知を受信したタイミングです。</value>
        [DataMember(Name = "ExpireDay", IsRequired = true, EmitDefaultValue = true)]
        public int ExpireDay { get; set; }

        /// <summary>
        /// 執行条件 |定義値|説明| |-|-| |10|成行| |13|寄成（前場）| |14|寄成（後場）| |15|引成（前場）| |16|引成（後場）| |17|IOC成行| |20|指値| |21|寄指（前場）| |22|寄指（後場）| |23|引指（前場）| |24|引指（後場）| |25|不成（前場）| |26|不成（後場）| |27|IOC指値|
        /// </summary>
        /// <value>執行条件 |定義値|説明| |-|-| |10|成行| |13|寄成（前場）| |14|寄成（後場）| |15|引成（前場）| |16|引成（後場）| |17|IOC成行| |20|指値| |21|寄指（前場）| |22|寄指（後場）| |23|引指（前場）| |24|引指（後場）| |25|不成（前場）| |26|不成（後場）| |27|IOC指値|</value>
        [DataMember(Name = "FrontOrderType", IsRequired = true, EmitDefaultValue = true)]
        public int FrontOrderType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestSendOrder {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  SecurityType: ").Append(SecurityType).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  CashMargin: ").Append(CashMargin).Append("\n");
            sb.Append("  MarginTradeType: ").Append(MarginTradeType).Append("\n");
            sb.Append("  DelivType: ").Append(DelivType).Append("\n");
            sb.Append("  FundType: ").Append(FundType).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  ClosePositionOrder: ").Append(ClosePositionOrder).Append("\n");
            sb.Append("  ClosePositions: ").Append(ClosePositions).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  ExpireDay: ").Append(ExpireDay).Append("\n");
            sb.Append("  FrontOrderType: ").Append(FrontOrderType).Append("\n");
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
            return this.Equals(input as RequestSendOrder);
        }

        /// <summary>
        /// Returns true if RequestSendOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestSendOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestSendOrder input)
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
                    this.SecurityType == input.SecurityType ||
                    this.SecurityType.Equals(input.SecurityType)
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.CashMargin == input.CashMargin ||
                    this.CashMargin.Equals(input.CashMargin)
                ) && 
                (
                    this.MarginTradeType == input.MarginTradeType ||
                    this.MarginTradeType.Equals(input.MarginTradeType)
                ) && 
                (
                    this.DelivType == input.DelivType ||
                    this.DelivType.Equals(input.DelivType)
                ) && 
                (
                    this.FundType == input.FundType ||
                    (this.FundType != null &&
                    this.FundType.Equals(input.FundType))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    this.AccountType.Equals(input.AccountType)
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
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.ExpireDay == input.ExpireDay ||
                    this.ExpireDay.Equals(input.ExpireDay)
                ) && 
                (
                    this.FrontOrderType == input.FrontOrderType ||
                    this.FrontOrderType.Equals(input.FrontOrderType)
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
                hashCode = hashCode * 59 + this.SecurityType.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                hashCode = hashCode * 59 + this.CashMargin.GetHashCode();
                hashCode = hashCode * 59 + this.MarginTradeType.GetHashCode();
                hashCode = hashCode * 59 + this.DelivType.GetHashCode();
                if (this.FundType != null)
                    hashCode = hashCode * 59 + this.FundType.GetHashCode();
                hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                hashCode = hashCode * 59 + this.Qty.GetHashCode();
                hashCode = hashCode * 59 + this.ClosePositionOrder.GetHashCode();
                if (this.ClosePositions != null)
                    hashCode = hashCode * 59 + this.ClosePositions.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                hashCode = hashCode * 59 + this.ExpireDay.GetHashCode();
                hashCode = hashCode * 59 + this.FrontOrderType.GetHashCode();
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
