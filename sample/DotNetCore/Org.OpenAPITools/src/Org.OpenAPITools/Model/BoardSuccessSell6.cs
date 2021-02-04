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
    /// 売気配数量6本目
    /// </summary>
    [DataContract(Name = "BoardSuccess_Sell6")]
    public partial class BoardSuccessSell6 : IEquatable<BoardSuccessSell6>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoardSuccessSell6" /> class.
        /// </summary>
        /// <param name="price">値段&lt;br&gt;※株式・先物・オプション銘柄の場合のみ.</param>
        /// <param name="qty">数量&lt;br&gt;※株式・先物・オプション銘柄の場合のみ.</param>
        public BoardSuccessSell6(double price = default(double), double qty = default(double))
        {
            this.Price = price;
            this.Qty = qty;
        }

        /// <summary>
        /// 値段&lt;br&gt;※株式・先物・オプション銘柄の場合のみ
        /// </summary>
        /// <value>値段&lt;br&gt;※株式・先物・オプション銘柄の場合のみ</value>
        [DataMember(Name = "Price", EmitDefaultValue = true)]
        public double Price { get; set; }

        /// <summary>
        /// 数量&lt;br&gt;※株式・先物・オプション銘柄の場合のみ
        /// </summary>
        /// <value>数量&lt;br&gt;※株式・先物・オプション銘柄の場合のみ</value>
        [DataMember(Name = "Qty", EmitDefaultValue = true)]
        public double Qty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoardSuccessSell6 {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
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
            return this.Equals(input as BoardSuccessSell6);
        }

        /// <summary>
        /// Returns true if BoardSuccessSell6 instances are equal
        /// </summary>
        /// <param name="input">Instance of BoardSuccessSell6 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoardSuccessSell6 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Qty == input.Qty ||
                    this.Qty.Equals(input.Qty)
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
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                hashCode = hashCode * 59 + this.Qty.GetHashCode();
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
