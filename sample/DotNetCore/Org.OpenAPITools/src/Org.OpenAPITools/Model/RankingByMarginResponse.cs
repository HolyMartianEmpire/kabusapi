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
    /// RankingByMarginResponse
    /// </summary>
    [DataContract(Name = "RankingByMarginResponse")]
    public partial class RankingByMarginResponse : IEquatable<RankingByMarginResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RankingByMarginResponse" /> class.
        /// </summary>
        /// <param name="type">種別.</param>
        /// <param name="exchangeDivision">市場.</param>
        /// <param name="ranking">ランキング.</param>
        public RankingByMarginResponse(string type = default(string), string exchangeDivision = default(string), List<RankingByMarginResponseRanking> ranking = default(List<RankingByMarginResponseRanking>))
        {
            this.Type = type;
            this.ExchangeDivision = exchangeDivision;
            this.Ranking = ranking;
        }

        /// <summary>
        /// 種別
        /// </summary>
        /// <value>種別</value>
        [DataMember(Name = "Type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// 市場
        /// </summary>
        /// <value>市場</value>
        [DataMember(Name = "ExchangeDivision", EmitDefaultValue = true)]
        public string ExchangeDivision { get; set; }

        /// <summary>
        /// ランキング
        /// </summary>
        /// <value>ランキング</value>
        [DataMember(Name = "Ranking", EmitDefaultValue = true)]
        public List<RankingByMarginResponseRanking> Ranking { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RankingByMarginResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ExchangeDivision: ").Append(ExchangeDivision).Append("\n");
            sb.Append("  Ranking: ").Append(Ranking).Append("\n");
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
            return this.Equals(input as RankingByMarginResponse);
        }

        /// <summary>
        /// Returns true if RankingByMarginResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RankingByMarginResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RankingByMarginResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ExchangeDivision == input.ExchangeDivision ||
                    (this.ExchangeDivision != null &&
                    this.ExchangeDivision.Equals(input.ExchangeDivision))
                ) && 
                (
                    this.Ranking == input.Ranking ||
                    this.Ranking != null &&
                    input.Ranking != null &&
                    this.Ranking.SequenceEqual(input.Ranking)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ExchangeDivision != null)
                    hashCode = hashCode * 59 + this.ExchangeDivision.GetHashCode();
                if (this.Ranking != null)
                    hashCode = hashCode * 59 + this.Ranking.GetHashCode();
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
