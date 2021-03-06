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
    /// RequestToken
    /// </summary>
    [DataContract(Name = "RequestToken")]
    public partial class RequestToken : IEquatable<RequestToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestToken" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestToken() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestToken" /> class.
        /// </summary>
        /// <param name="aPIPassword">APIパスワード (required).</param>
        public RequestToken(string aPIPassword = default(string))
        {
            // to ensure "aPIPassword" is required (not null)
            this.APIPassword = aPIPassword ?? throw new ArgumentNullException("aPIPassword is a required property for RequestToken and cannot be null");
        }

        /// <summary>
        /// APIパスワード
        /// </summary>
        /// <value>APIパスワード</value>
        [DataMember(Name = "APIPassword", IsRequired = true, EmitDefaultValue = true)]
        public string APIPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestToken {\n");
            sb.Append("  APIPassword: ").Append(APIPassword).Append("\n");
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
            return this.Equals(input as RequestToken);
        }

        /// <summary>
        /// Returns true if RequestToken instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.APIPassword == input.APIPassword ||
                    (this.APIPassword != null &&
                    this.APIPassword.Equals(input.APIPassword))
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
                if (this.APIPassword != null)
                    hashCode = hashCode * 59 + this.APIPassword.GetHashCode();
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
