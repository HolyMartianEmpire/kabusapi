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
    /// RankingDefaultResponseAllOf
    /// </summary>
    [DataContract(Name = "RankingDefaultResponse_allOf")]
    public partial class RankingDefaultResponseAllOf : IEquatable<RankingDefaultResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RankingDefaultResponseAllOf" /> class.
        /// </summary>
        /// <param name="ranking">ランキング.</param>
        public RankingDefaultResponseAllOf(List<CommonRankingItems> ranking = default(List<CommonRankingItems>))
        {
            this.Ranking = ranking;
        }

        /// <summary>
        /// ランキング
        /// </summary>
        /// <value>ランキング</value>
        [DataMember(Name = "Ranking", EmitDefaultValue = true)]
        public List<CommonRankingItems> Ranking { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RankingDefaultResponseAllOf {\n");
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
            return this.Equals(input as RankingDefaultResponseAllOf);
        }

        /// <summary>
        /// Returns true if RankingDefaultResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of RankingDefaultResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RankingDefaultResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
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