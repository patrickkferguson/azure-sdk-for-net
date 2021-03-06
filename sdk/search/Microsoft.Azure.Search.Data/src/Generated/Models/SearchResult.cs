// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains a document found by a search query, plus associated metadata.
    /// </summary>
    public partial class SearchResult<T>
    {
        /// <summary>
        /// Initializes a new instance of the SearchResult class.
        /// </summary>
        public SearchResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SearchResult class.
        /// </summary>
        /// <param name="document">The document found by the search query.</param>
        /// <param name="score">The relevance score of the document compared to
        /// other documents returned by the query.</param>
        /// <param name="highlights">Text fragments from the document that
        /// indicate the matching search terms, organized by each applicable
        /// field; null if hit highlighting was not enabled for the
        /// query.</param>
        public SearchResult(T document = default(T), double score = default(double), IDictionary<string, IList<string>> highlights = default(IDictionary<string, IList<string>>))
        {
            Document = document;
            Score = score;
            Highlights = highlights;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the document found by the search query. 
        /// </summary>
        public T Document { get; private set; }

        /// <summary>
        /// Gets the relevance score of the document compared to other
        /// documents returned by the query.
        /// </summary>
        [JsonProperty(PropertyName = "@search.score")]
        public double Score { get; private set; }

        /// <summary>
        /// Gets text fragments from the document that indicate the matching
        /// search terms, organized by each applicable field; null if hit
        /// highlighting was not enabled for the query.
        /// </summary>
        [JsonProperty(PropertyName = "@search.highlights")]
        public IDictionary<string, IList<string>> Highlights { get; private set; }

    }
}
