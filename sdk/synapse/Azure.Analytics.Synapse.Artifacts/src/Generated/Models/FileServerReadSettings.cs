// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> File server read settings. </summary>
    public partial class FileServerReadSettings : StoreReadSettings
    {
        /// <summary> Initializes a new instance of FileServerReadSettings. </summary>
        public FileServerReadSettings()
        {
            Type = "FileServerReadSettings";
        }

        /// <summary> Initializes a new instance of FileServerReadSettings. </summary>
        /// <param name="type"> The read setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="recursive"> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="wildcardFolderPath"> FileServer wildcardFolderPath. Type: string (or Expression with resultType string). </param>
        /// <param name="wildcardFileName"> FileServer wildcardFileName. Type: string (or Expression with resultType string). </param>
        /// <param name="enablePartitionDiscovery"> Indicates whether to enable partition discovery. </param>
        /// <param name="modifiedDatetimeStart"> The start of file&apos;s modified datetime. Type: string (or Expression with resultType string). </param>
        /// <param name="modifiedDatetimeEnd"> The end of file&apos;s modified datetime. Type: string (or Expression with resultType string). </param>
        internal FileServerReadSettings(string type, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object recursive, object wildcardFolderPath, object wildcardFileName, bool? enablePartitionDiscovery, object modifiedDatetimeStart, object modifiedDatetimeEnd) : base(type, maxConcurrentConnections, additionalProperties)
        {
            Recursive = recursive;
            WildcardFolderPath = wildcardFolderPath;
            WildcardFileName = wildcardFileName;
            EnablePartitionDiscovery = enablePartitionDiscovery;
            ModifiedDatetimeStart = modifiedDatetimeStart;
            ModifiedDatetimeEnd = modifiedDatetimeEnd;
            Type = type ?? "FileServerReadSettings";
        }

        /// <summary> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </summary>
        public object Recursive { get; set; }
        /// <summary> FileServer wildcardFolderPath. Type: string (or Expression with resultType string). </summary>
        public object WildcardFolderPath { get; set; }
        /// <summary> FileServer wildcardFileName. Type: string (or Expression with resultType string). </summary>
        public object WildcardFileName { get; set; }
        /// <summary> Indicates whether to enable partition discovery. </summary>
        public bool? EnablePartitionDiscovery { get; set; }
        /// <summary> The start of file&apos;s modified datetime. Type: string (or Expression with resultType string). </summary>
        public object ModifiedDatetimeStart { get; set; }
        /// <summary> The end of file&apos;s modified datetime. Type: string (or Expression with resultType string). </summary>
        public object ModifiedDatetimeEnd { get; set; }
    }
}