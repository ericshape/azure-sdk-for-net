// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// User update parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class UserUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the UserUpdateParameters class.
        /// </summary>
        public UserUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserUpdateParameters class.
        /// </summary>
        /// <param name="state">Account state. Specifies whether the user is
        /// active or not. Blocked users are unable to sign into the developer
        /// portal or call any APIs of subscribed products. Default state is
        /// Active. Possible values include: 'active', 'blocked', 'pending',
        /// 'deleted'</param>
        /// <param name="note">Optional note about a user set by the
        /// administrator.</param>
        /// <param name="identities">Collection of user identities.</param>
        /// <param name="email">Email address. Must not be empty and must be
        /// unique within the service instance.</param>
        /// <param name="password">User Password.</param>
        /// <param name="firstName">First name.</param>
        /// <param name="lastName">Last name.</param>
        public UserUpdateParameters(string state = default(string), string note = default(string), IList<UserIdentityContract> identities = default(IList<UserIdentityContract>), string email = default(string), string password = default(string), string firstName = default(string), string lastName = default(string))
        {
            State = state;
            Note = note;
            Identities = identities;
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets account state. Specifies whether the user is active or
        /// not. Blocked users are unable to sign into the developer portal or
        /// call any APIs of subscribed products. Default state is Active.
        /// Possible values include: 'active', 'blocked', 'pending', 'deleted'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets optional note about a user set by the administrator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets collection of user identities.
        /// </summary>
        [JsonProperty(PropertyName = "properties.identities")]
        public IList<UserIdentityContract> Identities { get; set; }

        /// <summary>
        /// Gets or sets email address. Must not be empty and must be unique
        /// within the service instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets user Password.
        /// </summary>
        [JsonProperty(PropertyName = "properties.password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets first name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets last name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastName")]
        public string LastName { get; set; }

    }
}
