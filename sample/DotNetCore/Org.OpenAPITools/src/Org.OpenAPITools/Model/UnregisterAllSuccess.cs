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
    /// UnregisterAllSuccess
    /// </summary>
    [DataContract(Name = "UnregisterAllSuccess")]
    public partial class UnregisterAllSuccess : IEquatable<UnregisterAllSuccess>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnregisterAllSuccess" /> class.
        /// </summary>
        /// <param name="registList">現在登録されている銘柄のリスト&lt;br&gt;※銘柄登録解除が正常に行われれば、空リストを返します。&lt;br&gt;　登録解除でエラー等が発生した場合、現在登録されている銘柄のリストを返します.</param>
        public UnregisterAllSuccess(Object registList = default(Object))
        {
            this.RegistList = registList;
        }

        /// <summary>
        /// 現在登録されている銘柄のリスト&lt;br&gt;※銘柄登録解除が正常に行われれば、空リストを返します。&lt;br&gt;　登録解除でエラー等が発生した場合、現在登録されている銘柄のリストを返します
        /// </summary>
        /// <value>現在登録されている銘柄のリスト&lt;br&gt;※銘柄登録解除が正常に行われれば、空リストを返します。&lt;br&gt;　登録解除でエラー等が発生した場合、現在登録されている銘柄のリストを返します</value>
        [DataMember(Name = "RegistList", EmitDefaultValue = true)]
        public Object RegistList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnregisterAllSuccess {\n");
            sb.Append("  RegistList: ").Append(RegistList).Append("\n");
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
            return this.Equals(input as UnregisterAllSuccess);
        }

        /// <summary>
        /// Returns true if UnregisterAllSuccess instances are equal
        /// </summary>
        /// <param name="input">Instance of UnregisterAllSuccess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnregisterAllSuccess input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RegistList == input.RegistList ||
                    (this.RegistList != null &&
                    this.RegistList.Equals(input.RegistList))
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
                if (this.RegistList != null)
                    hashCode = hashCode * 59 + this.RegistList.GetHashCode();
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
