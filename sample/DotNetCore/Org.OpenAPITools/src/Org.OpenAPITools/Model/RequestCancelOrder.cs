/*
 * kabuステーションAPI
 *
 * # 定義情報   REST APIのコード一覧、エンドポイントは下記リンク参照     - [REST APIコード一覧](../ptal/error.html)
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
    /// RequestCancelOrder
    /// </summary>
    [DataContract(Name = "RequestCancelOrder")]
    public partial class RequestCancelOrder : IEquatable<RequestCancelOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCancelOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestCancelOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCancelOrder" /> class.
        /// </summary>
        /// <param name="orderId">注文番号&lt;br&gt;sendorderのレスポンスで受け取るOrderID。 (required).</param>
        /// <param name="password">注文パスワード (required).</param>
        public RequestCancelOrder(string orderId = default(string), string password = default(string))
        {
            // to ensure "orderId" is required (not null)
            this.OrderId = orderId ?? throw new ArgumentNullException("orderId is a required property for RequestCancelOrder and cannot be null");
            // to ensure "password" is required (not null)
            this.Password = password ?? throw new ArgumentNullException("password is a required property for RequestCancelOrder and cannot be null");
        }

        /// <summary>
        /// 注文番号&lt;br&gt;sendorderのレスポンスで受け取るOrderID。
        /// </summary>
        /// <value>注文番号&lt;br&gt;sendorderのレスポンスで受け取るOrderID。</value>
        [DataMember(Name = "OrderId", IsRequired = true, EmitDefaultValue = true)]
        public string OrderId { get; set; }

        /// <summary>
        /// 注文パスワード
        /// </summary>
        /// <value>注文パスワード</value>
        [DataMember(Name = "Password", IsRequired = true, EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestCancelOrder {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as RequestCancelOrder);
        }

        /// <summary>
        /// Returns true if RequestCancelOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestCancelOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestCancelOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
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
