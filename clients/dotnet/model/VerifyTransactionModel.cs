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
    /// Verify this transaction by matching it to values in your accounting system.
    /// </summary>
    [DataContract]
    public partial class VerifyTransactionModel :  IEquatable<VerifyTransactionModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyTransactionModel" /> class.
        /// </summary>
        /// <param name="VerifyTransactionDate">Transaction Date - The date on the invoice, purchase order, etc..</param>
        /// <param name="VerifyTotalAmount">Total Amount - The total amount (not including tax) for the document..</param>
        /// <param name="VerifyTotalTax">Total Tax - The total tax for the document..</param>
        public VerifyTransactionModel(DateTime? VerifyTransactionDate = null, double? VerifyTotalAmount = null, double? VerifyTotalTax = null)
        {
            this.VerifyTransactionDate = VerifyTransactionDate;
            this.VerifyTotalAmount = VerifyTotalAmount;
            this.VerifyTotalTax = VerifyTotalTax;
        }
        
        /// <summary>
        /// Transaction Date - The date on the invoice, purchase order, etc.
        /// </summary>
        /// <value>Transaction Date - The date on the invoice, purchase order, etc.</value>
        [DataMember(Name="verifyTransactionDate", EmitDefaultValue=false)]
        public DateTime? VerifyTransactionDate { get; set; }
        /// <summary>
        /// Total Amount - The total amount (not including tax) for the document.
        /// </summary>
        /// <value>Total Amount - The total amount (not including tax) for the document.</value>
        [DataMember(Name="verifyTotalAmount", EmitDefaultValue=false)]
        public double? VerifyTotalAmount { get; set; }
        /// <summary>
        /// Total Tax - The total tax for the document.
        /// </summary>
        /// <value>Total Tax - The total tax for the document.</value>
        [DataMember(Name="verifyTotalTax", EmitDefaultValue=false)]
        public double? VerifyTotalTax { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyTransactionModel {\n");
            sb.Append("  VerifyTransactionDate: ").Append(VerifyTransactionDate).Append("\n");
            sb.Append("  VerifyTotalAmount: ").Append(VerifyTotalAmount).Append("\n");
            sb.Append("  VerifyTotalTax: ").Append(VerifyTotalTax).Append("\n");
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
            return this.Equals(obj as VerifyTransactionModel);
        }

        /// <summary>
        /// Returns true if VerifyTransactionModel instances are equal
        /// </summary>
        /// <param name="other">Instance of VerifyTransactionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyTransactionModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.VerifyTransactionDate == other.VerifyTransactionDate ||
                    this.VerifyTransactionDate != null &&
                    this.VerifyTransactionDate.Equals(other.VerifyTransactionDate)
                ) && 
                (
                    this.VerifyTotalAmount == other.VerifyTotalAmount ||
                    this.VerifyTotalAmount != null &&
                    this.VerifyTotalAmount.Equals(other.VerifyTotalAmount)
                ) && 
                (
                    this.VerifyTotalTax == other.VerifyTotalTax ||
                    this.VerifyTotalTax != null &&
                    this.VerifyTotalTax.Equals(other.VerifyTotalTax)
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
                if (this.VerifyTransactionDate != null)
                    hash = hash * 59 + this.VerifyTransactionDate.GetHashCode();
                if (this.VerifyTotalAmount != null)
                    hash = hash * 59 + this.VerifyTotalAmount.GetHashCode();
                if (this.VerifyTotalTax != null)
                    hash = hash * 59 + this.VerifyTotalTax.GetHashCode();
                return hash;
            }
        }
    }

}