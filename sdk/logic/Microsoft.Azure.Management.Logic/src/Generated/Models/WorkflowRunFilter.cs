// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The workflow run filter.
    /// </summary>
    public partial class WorkflowRunFilter
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowRunFilter class.
        /// </summary>
        public WorkflowRunFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkflowRunFilter class.
        /// </summary>
        /// <param name="status">The status of workflow run. Possible values
        /// include: 'NotSpecified', 'Paused', 'Running', 'Waiting',
        /// 'Succeeded', 'Skipped', 'Suspended', 'Cancelled', 'Failed',
        /// 'Faulted', 'TimedOut', 'Aborted', 'Ignored'</param>
        public WorkflowRunFilter(string status = default(string))
        {
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the status of workflow run. Possible values include:
        /// 'NotSpecified', 'Paused', 'Running', 'Waiting', 'Succeeded',
        /// 'Skipped', 'Suspended', 'Cancelled', 'Failed', 'Faulted',
        /// 'TimedOut', 'Aborted', 'Ignored'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}
