// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The LanguageBatchInput. </summary>
    internal partial class LanguageBatchInput
    {
        /// <summary> Initializes a new instance of LanguageBatchInput. </summary>
        /// <param name="documents"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="documents"/> is null. </exception>
        public LanguageBatchInput(IEnumerable<LanguageInput> documents)
        {
            if (documents == null)
            {
                throw new ArgumentNullException(nameof(documents));
            }

            Documents = documents.ToList();
        }

        public IList<LanguageInput> Documents { get; }
    }
}