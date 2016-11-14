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
    /// Tax Authority Model
    /// </summary>
    [DataContract]
    public partial class TaxAuthorityModel :  IEquatable<TaxAuthorityModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxAuthorityModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaxAuthorityModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxAuthorityModel" /> class.
        /// </summary>
        /// <param name="Name">The friendly name of this tax authority. (required).</param>
        /// <param name="TaxAuthorityTypeId">The type of this tax authority..</param>
        /// <param name="JurisdictionId">The unique ID number of the jurisdiction for this tax authority..</param>
        public TaxAuthorityModel(string Name = null, int? TaxAuthorityTypeId = null, int? JurisdictionId = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for TaxAuthorityModel and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.TaxAuthorityTypeId = TaxAuthorityTypeId;
            this.JurisdictionId = JurisdictionId;
        }
        
        /// <summary>
        /// The unique ID number of this tax authority.
        /// </summary>
        /// <value>The unique ID number of this tax authority.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// The friendly name of this tax authority.
        /// </summary>
        /// <value>The friendly name of this tax authority.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The type of this tax authority.
        /// </summary>
        /// <value>The type of this tax authority.</value>
        [DataMember(Name="taxAuthorityTypeId", EmitDefaultValue=false)]
        public int? TaxAuthorityTypeId { get; set; }
        /// <summary>
        /// The unique ID number of the jurisdiction for this tax authority.
        /// </summary>
        /// <value>The unique ID number of the jurisdiction for this tax authority.</value>
        [DataMember(Name="jurisdictionId", EmitDefaultValue=false)]
        public int? JurisdictionId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxAuthorityModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TaxAuthorityTypeId: ").Append(TaxAuthorityTypeId).Append("\n");
            sb.Append("  JurisdictionId: ").Append(JurisdictionId).Append("\n");
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
            return this.Equals(obj as TaxAuthorityModel);
        }

        /// <summary>
        /// Returns true if TaxAuthorityModel instances are equal
        /// </summary>
        /// <param name="other">Instance of TaxAuthorityModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxAuthorityModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.TaxAuthorityTypeId == other.TaxAuthorityTypeId ||
                    this.TaxAuthorityTypeId != null &&
                    this.TaxAuthorityTypeId.Equals(other.TaxAuthorityTypeId)
                ) && 
                (
                    this.JurisdictionId == other.JurisdictionId ||
                    this.JurisdictionId != null &&
                    this.JurisdictionId.Equals(other.JurisdictionId)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.TaxAuthorityTypeId != null)
                    hash = hash * 59 + this.TaxAuthorityTypeId.GetHashCode();
                if (this.JurisdictionId != null)
                    hash = hash * 59 + this.JurisdictionId.GetHashCode();
                return hash;
            }
        }
    }

}