using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// Represents an ISO 3166 recognized country
    /// </summary>
    public class IsoCountryModel
    {
        /// <summary>
        /// The two character ISO 3166 country code
        /// </summary>
        public String code { get; set; }

        /// <summary>
        /// The full name of this country as it is known in US English
        /// </summary>
        public String name { get; set; }

        /// <summary>
        /// True if this country is a member of the European Union
        /// </summary>
        public Boolean? isEuropeanUnion { get; set; }


        /// <summary>
        /// Convert this object to a JSON string of itself
        /// </summary>
        /// <returns>A JSON string of this object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings() { Formatting = Formatting.Indented });
        }
    }
}
