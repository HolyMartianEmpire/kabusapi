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
    /// WalletMarginSuccess
    /// </summary>
    [DataContract(Name = "WalletMarginSuccess")]
    public partial class WalletMarginSuccess : IEquatable<WalletMarginSuccess>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletMarginSuccess" /> class.
        /// </summary>
        /// <param name="marginAccountWallet">信用新規可能額.</param>
        /// <param name="depositkeepRate">保証金維持率&lt;br&gt;※銘柄指定の場合のみ&lt;br&gt;※銘柄が指定されなかった場合、0.0を返す。.</param>
        /// <param name="consignmentDepositRate">委託保証金率&lt;br&gt;※銘柄指定の場合のみ。&lt;br&gt;※銘柄が指定されなかった場合、Noneを返す。.</param>
        /// <param name="cashOfConsignmentDepositRate">現金委託保証金率&lt;br&gt;※銘柄指定の場合のみ。&lt;br&gt;※銘柄が指定されなかった場合、Noneを返す。.</param>
        public WalletMarginSuccess(double marginAccountWallet = default(double), double depositkeepRate = default(double), double consignmentDepositRate = default(double), double cashOfConsignmentDepositRate = default(double))
        {
            this.MarginAccountWallet = marginAccountWallet;
            this.DepositkeepRate = depositkeepRate;
            this.ConsignmentDepositRate = consignmentDepositRate;
            this.CashOfConsignmentDepositRate = cashOfConsignmentDepositRate;
        }

        /// <summary>
        /// 信用新規可能額
        /// </summary>
        /// <value>信用新規可能額</value>
        [DataMember(Name = "MarginAccountWallet", EmitDefaultValue = true)]
        public double MarginAccountWallet { get; set; }

        /// <summary>
        /// 保証金維持率&lt;br&gt;※銘柄指定の場合のみ&lt;br&gt;※銘柄が指定されなかった場合、0.0を返す。
        /// </summary>
        /// <value>保証金維持率&lt;br&gt;※銘柄指定の場合のみ&lt;br&gt;※銘柄が指定されなかった場合、0.0を返す。</value>
        [DataMember(Name = "DepositkeepRate", EmitDefaultValue = true)]
        public double DepositkeepRate { get; set; }

        /// <summary>
        /// 委託保証金率&lt;br&gt;※銘柄指定の場合のみ。&lt;br&gt;※銘柄が指定されなかった場合、Noneを返す。
        /// </summary>
        /// <value>委託保証金率&lt;br&gt;※銘柄指定の場合のみ。&lt;br&gt;※銘柄が指定されなかった場合、Noneを返す。</value>
        [DataMember(Name = "ConsignmentDepositRate", EmitDefaultValue = true)]
        public double ConsignmentDepositRate { get; set; }

        /// <summary>
        /// 現金委託保証金率&lt;br&gt;※銘柄指定の場合のみ。&lt;br&gt;※銘柄が指定されなかった場合、Noneを返す。
        /// </summary>
        /// <value>現金委託保証金率&lt;br&gt;※銘柄指定の場合のみ。&lt;br&gt;※銘柄が指定されなかった場合、Noneを返す。</value>
        [DataMember(Name = "CashOfConsignmentDepositRate", EmitDefaultValue = true)]
        public double CashOfConsignmentDepositRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WalletMarginSuccess {\n");
            sb.Append("  MarginAccountWallet: ").Append(MarginAccountWallet).Append("\n");
            sb.Append("  DepositkeepRate: ").Append(DepositkeepRate).Append("\n");
            sb.Append("  ConsignmentDepositRate: ").Append(ConsignmentDepositRate).Append("\n");
            sb.Append("  CashOfConsignmentDepositRate: ").Append(CashOfConsignmentDepositRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WalletMarginSuccess);
        }

        /// <summary>
        /// Returns true if WalletMarginSuccess instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletMarginSuccess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletMarginSuccess input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MarginAccountWallet == input.MarginAccountWallet ||
                    this.MarginAccountWallet.Equals(input.MarginAccountWallet)
                ) && 
                (
                    this.DepositkeepRate == input.DepositkeepRate ||
                    this.DepositkeepRate.Equals(input.DepositkeepRate)
                ) && 
                (
                    this.ConsignmentDepositRate == input.ConsignmentDepositRate ||
                    this.ConsignmentDepositRate.Equals(input.ConsignmentDepositRate)
                ) && 
                (
                    this.CashOfConsignmentDepositRate == input.CashOfConsignmentDepositRate ||
                    this.CashOfConsignmentDepositRate.Equals(input.CashOfConsignmentDepositRate)
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
                hashCode = hashCode * 59 + this.MarginAccountWallet.GetHashCode();
                hashCode = hashCode * 59 + this.DepositkeepRate.GetHashCode();
                hashCode = hashCode * 59 + this.ConsignmentDepositRate.GetHashCode();
                hashCode = hashCode * 59 + this.CashOfConsignmentDepositRate.GetHashCode();
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
