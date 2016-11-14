/* 
 * AvaTax API
 *
 * REST interface to Avalara's enterprise tax service, AvaTax.
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Avalara.AvaTax.RestClient.Model
{
    /// <summary>
    /// A request to void a previously created transaction
    /// </summary>
    [DataContract]
    public partial class VoidTransactionModel :  IEquatable<VoidTransactionModel>
    {
        /// <summary>
        /// Please specify the reason for voiding or cancelling this transaction
        /// </summary>
        /// <value>Please specify the reason for voiding or cancelling this transaction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            
            /// <summary>
            /// Enum Unspecified for "Unspecified"
            /// </summary>
            [EnumMember(Value = "Unspecified")]
            Unspecified,
            
            /// <summary>
            /// Enum PostFailed for "PostFailed"
            /// </summary>
            [EnumMember(Value = "PostFailed")]
            PostFailed,
            
            /// <summary>
            /// Enum DocDeleted for "DocDeleted"
            /// </summary>
            [EnumMember(Value = "DocDeleted")]
            DocDeleted,
            
            /// <summary>
            /// Enum DocVoided for "DocVoided"
            /// </summary>
            [EnumMember(Value = "DocVoided")]
            DocVoided,
            
            /// <summary>
            /// Enum AdjustmentCancelled for "AdjustmentCancelled"
            /// </summary>
            [EnumMember(Value = "AdjustmentCancelled")]
            AdjustmentCancelled
        }

        /// <summary>
        /// Please specify the reason for voiding or cancelling this transaction
        /// </summary>
        /// <value>Please specify the reason for voiding or cancelling this transaction</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public CodeEnum? Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoidTransactionModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VoidTransactionModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoidTransactionModel" /> class.
        /// </summary>
        /// <param name="Code">Please specify the reason for voiding or cancelling this transaction (required).</param>
        public VoidTransactionModel(CodeEnum? Code = null)
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for VoidTransactionModel and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoidTransactionModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as VoidTransactionModel);
        }

        /// <summary>
        /// Returns true if VoidTransactionModel instances are equal
        /// </summary>
        /// <param name="other">Instance of VoidTransactionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoidTransactionModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                return hash;
            }
        }
    }

}