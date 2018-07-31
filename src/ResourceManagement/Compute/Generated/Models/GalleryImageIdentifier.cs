// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This is the gallery image identifier.
    /// </summary>
    public partial class GalleryImageIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the GalleryImageIdentifier class.
        /// </summary>
        public GalleryImageIdentifier()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GalleryImageIdentifier class.
        /// </summary>
        /// <param name="publisher">The gallery image publisher name.</param>
        /// <param name="offer">The gallery image offer name.</param>
        /// <param name="sku">The gallery image sku name.</param>
        public GalleryImageIdentifier(string publisher = default(string), string offer = default(string), string sku = default(string))
        {
            Publisher = publisher;
            Offer = offer;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the gallery image publisher name.
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the gallery image offer name.
        /// </summary>
        [JsonProperty(PropertyName = "offer")]
        public string Offer { get; set; }

        /// <summary>
        /// Gets or sets the gallery image sku name.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

    }
}