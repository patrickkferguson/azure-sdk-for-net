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
    /// The Edifact envelope override settings.
    /// </summary>
    public partial class EdifactEnvelopeOverride
    {
        /// <summary>
        /// Initializes a new instance of the EdifactEnvelopeOverride class.
        /// </summary>
        public EdifactEnvelopeOverride()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EdifactEnvelopeOverride class.
        /// </summary>
        /// <param name="messageId">The message id on which this envelope
        /// settings has to be applied.</param>
        /// <param name="messageVersion">The message version on which this
        /// envelope settings has to be applied.</param>
        /// <param name="messageRelease">The message release version on which
        /// this envelope settings has to be applied.</param>
        /// <param name="messageAssociationAssignedCode">The message
        /// association assigned code.</param>
        /// <param name="targetNamespace">The target namespace on which this
        /// envelope settings has to be applied.</param>
        /// <param name="functionalGroupId">The functional group id.</param>
        /// <param name="senderApplicationQualifier">The sender application
        /// qualifier.</param>
        /// <param name="senderApplicationId">The sender application
        /// id.</param>
        /// <param name="receiverApplicationQualifier">The receiver application
        /// qualifier.</param>
        /// <param name="receiverApplicationId">The receiver application
        /// id.</param>
        /// <param name="controllingAgencyCode">The controlling agency
        /// code.</param>
        /// <param name="groupHeaderMessageVersion">The group header message
        /// version.</param>
        /// <param name="groupHeaderMessageRelease">The group header message
        /// release.</param>
        /// <param name="associationAssignedCode">The association assigned
        /// code.</param>
        /// <param name="applicationPassword">The application password.</param>
        public EdifactEnvelopeOverride(string messageId = default(string), string messageVersion = default(string), string messageRelease = default(string), string messageAssociationAssignedCode = default(string), string targetNamespace = default(string), string functionalGroupId = default(string), string senderApplicationQualifier = default(string), string senderApplicationId = default(string), string receiverApplicationQualifier = default(string), string receiverApplicationId = default(string), string controllingAgencyCode = default(string), string groupHeaderMessageVersion = default(string), string groupHeaderMessageRelease = default(string), string associationAssignedCode = default(string), string applicationPassword = default(string))
        {
            MessageId = messageId;
            MessageVersion = messageVersion;
            MessageRelease = messageRelease;
            MessageAssociationAssignedCode = messageAssociationAssignedCode;
            TargetNamespace = targetNamespace;
            FunctionalGroupId = functionalGroupId;
            SenderApplicationQualifier = senderApplicationQualifier;
            SenderApplicationId = senderApplicationId;
            ReceiverApplicationQualifier = receiverApplicationQualifier;
            ReceiverApplicationId = receiverApplicationId;
            ControllingAgencyCode = controllingAgencyCode;
            GroupHeaderMessageVersion = groupHeaderMessageVersion;
            GroupHeaderMessageRelease = groupHeaderMessageRelease;
            AssociationAssignedCode = associationAssignedCode;
            ApplicationPassword = applicationPassword;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the message id on which this envelope settings has to
        /// be applied.
        /// </summary>
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets the message version on which this envelope settings
        /// has to be applied.
        /// </summary>
        [JsonProperty(PropertyName = "messageVersion")]
        public string MessageVersion { get; set; }

        /// <summary>
        /// Gets or sets the message release version on which this envelope
        /// settings has to be applied.
        /// </summary>
        [JsonProperty(PropertyName = "messageRelease")]
        public string MessageRelease { get; set; }

        /// <summary>
        /// Gets or sets the message association assigned code.
        /// </summary>
        [JsonProperty(PropertyName = "messageAssociationAssignedCode")]
        public string MessageAssociationAssignedCode { get; set; }

        /// <summary>
        /// Gets or sets the target namespace on which this envelope settings
        /// has to be applied.
        /// </summary>
        [JsonProperty(PropertyName = "targetNamespace")]
        public string TargetNamespace { get; set; }

        /// <summary>
        /// Gets or sets the functional group id.
        /// </summary>
        [JsonProperty(PropertyName = "functionalGroupId")]
        public string FunctionalGroupId { get; set; }

        /// <summary>
        /// Gets or sets the sender application qualifier.
        /// </summary>
        [JsonProperty(PropertyName = "senderApplicationQualifier")]
        public string SenderApplicationQualifier { get; set; }

        /// <summary>
        /// Gets or sets the sender application id.
        /// </summary>
        [JsonProperty(PropertyName = "senderApplicationId")]
        public string SenderApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the receiver application qualifier.
        /// </summary>
        [JsonProperty(PropertyName = "receiverApplicationQualifier")]
        public string ReceiverApplicationQualifier { get; set; }

        /// <summary>
        /// Gets or sets the receiver application id.
        /// </summary>
        [JsonProperty(PropertyName = "receiverApplicationId")]
        public string ReceiverApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the controlling agency code.
        /// </summary>
        [JsonProperty(PropertyName = "controllingAgencyCode")]
        public string ControllingAgencyCode { get; set; }

        /// <summary>
        /// Gets or sets the group header message version.
        /// </summary>
        [JsonProperty(PropertyName = "groupHeaderMessageVersion")]
        public string GroupHeaderMessageVersion { get; set; }

        /// <summary>
        /// Gets or sets the group header message release.
        /// </summary>
        [JsonProperty(PropertyName = "groupHeaderMessageRelease")]
        public string GroupHeaderMessageRelease { get; set; }

        /// <summary>
        /// Gets or sets the association assigned code.
        /// </summary>
        [JsonProperty(PropertyName = "associationAssignedCode")]
        public string AssociationAssignedCode { get; set; }

        /// <summary>
        /// Gets or sets the application password.
        /// </summary>
        [JsonProperty(PropertyName = "applicationPassword")]
        public string ApplicationPassword { get; set; }

    }
}
