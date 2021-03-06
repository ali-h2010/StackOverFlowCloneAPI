/*
 * StackOverflow Core Features
 *
 * This is the documentation of the StackOverflow's core features assignment.  You can find out more about Swagger at [http://swagger.io](http://swagger.io)
 *
 * OpenAPI spec version: 1.0.0
 * Contact: ali.h2030@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Tags : IEquatable<Tags>
    { 
        /// <summary>
        /// Gets or Sets TagID
        /// </summary>

        [DataMember(Name="TagID")]
        public long? TagID { get; set; }

        /// <summary>
        /// Gets or Sets QuestionID
        /// </summary>

        [DataMember(Name="questionID")]
        public int? QuestionID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tags {\n");
            sb.Append("  TagID: ").Append(TagID).Append("\n");
            sb.Append("  QuestionID: ").Append(QuestionID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Tags)obj);
        }

        /// <summary>
        /// Returns true if Tags instances are equal
        /// </summary>
        /// <param name="other">Instance of Tags to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tags other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TagID == other.TagID ||
                    TagID != null &&
                    TagID.Equals(other.TagID)
                ) && 
                (
                    QuestionID == other.QuestionID ||
                    QuestionID != null &&
                    QuestionID.Equals(other.QuestionID)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (TagID != null)
                    hashCode = hashCode * 59 + TagID.GetHashCode();
                    if (QuestionID != null)
                    hashCode = hashCode * 59 + QuestionID.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Tags left, Tags right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Tags left, Tags right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
