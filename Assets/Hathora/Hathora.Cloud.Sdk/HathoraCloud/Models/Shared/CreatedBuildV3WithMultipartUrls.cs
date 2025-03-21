
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace HathoraCloud.Models.Shared
{
    using HathoraCloud.Models.Shared;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    using UnityEngine;
    
    /// <summary>
    /// A build represents a game server artifact and its associated metadata.
    /// </summary>
    [Serializable]
    public class CreatedBuildV3WithMultipartUrls
    {

        /// <summary>
        /// System generated id for a build. Can also be user defined when creating a build.
        /// </summary>
        [SerializeField]
        [JsonProperty("buildId")]
        public string BuildId { get; set; } = default!;

        /// <summary>
        /// Tag to associate an external version with a build. It is accessible via <a href="">`GetBuildInfo()`</a>.
        /// </summary>
        [SerializeField]
        [JsonProperty("buildTag")]
        public string? BuildTag { get; set; }

        [SerializeField]
        [JsonProperty("completeUploadPostRequestUrl")]
        public string CompleteUploadPostRequestUrl { get; set; } = default!;

        [SerializeField]
        [JsonProperty("contentHash")]
        public string? ContentHash { get; set; }

        /// <summary>
        /// When <a href="">`CreateBuild()`</a> is called.
        /// </summary>
        [SerializeField]
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; } = default!;

        [SerializeField]
        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// When the build was deleted.
        /// </summary>
        [SerializeField]
        [JsonProperty("deletedAt", NullValueHandling = NullValueHandling.Include)]
        public DateTime? DeletedAt { get; set; } = default!;

        /// <summary>
        /// When <a href="">`RunBuild()`</a> finished executing.
        /// </summary>
        [SerializeField]
        [JsonProperty("finishedAt", NullValueHandling = NullValueHandling.Include)]
        public DateTime? FinishedAt { get; set; } = default!;

        /// <summary>
        /// The size (in bytes) of the Docker image built by Hathora.
        /// </summary>
        [SerializeField]
        [JsonProperty("imageSize")]
        public long ImageSize { get; set; } = default!;

        [SerializeField]
        [JsonProperty("maxChunkSize")]
        public double MaxChunkSize { get; set; } = default!;

        /// <summary>
        /// System generated unique identifier for an organization. Not guaranteed to have a specific format.
        /// </summary>
        [SerializeField]
        [JsonProperty("orgId")]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// Url to view details, like build logs, of the build.
        /// </summary>
        [SerializeField]
        [JsonProperty("shareUrl")]
        public string? ShareUrl { get; set; }

        /// <summary>
        /// When <a href="">`RunBuild()`</a> is called.
        /// </summary>
        [SerializeField]
        [JsonProperty("startedAt", NullValueHandling = NullValueHandling.Include)]
        public DateTime? StartedAt { get; set; } = default!;

        [SerializeField]
        [JsonProperty("status")]
        public BuildStatus Status { get; set; } = default!;

        [SerializeField]
        [JsonProperty("uploadParts")]
        public List<BuildPart> UploadParts { get; set; } = default!;
    }
}