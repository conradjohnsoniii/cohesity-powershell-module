// Copyright 2019 Cohesity Inc.

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cohesity.Model
{
    /// <summary>
    /// Specifies details about a privilege such as the category, description, name, etc.
    /// </summary>
    [DataContract]
    public partial class PrivilegeInfo :  IEquatable<PrivilegeInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivilegeInfo" /> class.
        /// </summary>
        /// <param name="privilegeId">Specifies unique id for a privilege. This number must be unique when creating a new privilege..</param>
        /// <param name="category">Specifies a category for the privilege such as &#39;Access Management&#39;..</param>
        /// <param name="description">Specifies a description defining what the privilege provides..</param>
        /// <param name="isAvailableOnHelios">Specifies that this privilege is available for Helios operations..</param>
        /// <param name="isCustomRoleDefault">Specifies if this privilege is automatically assigned to custom roles..</param>
        /// <param name="isSpecial">Specifies if this privilege is automatically assigned to the default System Admin user called &#39;admin&#39;. If true, the privilege is NOT assigned to the default System Admin user called &#39;admin&#39;. By default, privileges are automatically assigned to the default System Admin user called &#39;admin&#39;..</param>
        /// <param name="isViewOnly">Specifies if privilege is view-only privilege that cannot make changes..</param>
        /// <param name="label">Specifies the label for the privilege as displayed on the Cohesity Dashboard such as &#39;Access Management View&#39;..</param>
        /// <param name="name">Specifies the Cluster name for the privilege such as PRINCIPAL_VIEW..</param>
        public PrivilegeInfo(string privilegeId = default(string), string category = default(string), string description = default(string), bool? isAvailableOnHelios = default(bool?), bool? isCustomRoleDefault = default(bool?), bool? isSpecial = default(bool?), bool? isViewOnly = default(bool?), string label = default(string), string name = default(string))
        {
            this.PrivilegeId = privilegeId;
            this.Category = category;
            this.Description = description;
            this.IsAvailableOnHelios = isAvailableOnHelios;
            this.IsCustomRoleDefault = isCustomRoleDefault;
            this.IsSpecial = isSpecial;
            this.IsViewOnly = isViewOnly;
            this.Label = label;
            this.Name = name;
            this.PrivilegeId = privilegeId;
            this.Category = category;
            this.Description = description;
            this.IsAvailableOnHelios = isAvailableOnHelios;
            this.IsCustomRoleDefault = isCustomRoleDefault;
            this.IsSpecial = isSpecial;
            this.IsViewOnly = isViewOnly;
            this.Label = label;
            this.Name = name;
        }
        
        /// <summary>
        /// Specifies unique id for a privilege. This number must be unique when creating a new privilege.
        /// </summary>
        /// <value>Specifies unique id for a privilege. This number must be unique when creating a new privilege.</value>
        [DataMember(Name="PrivilegeId", EmitDefaultValue=true)]
        public string PrivilegeId { get; set; }

        /// <summary>
        /// Specifies a category for the privilege such as &#39;Access Management&#39;.
        /// </summary>
        /// <value>Specifies a category for the privilege such as &#39;Access Management&#39;.</value>
        [DataMember(Name="category", EmitDefaultValue=true)]
        public string Category { get; set; }

        /// <summary>
        /// Specifies a description defining what the privilege provides.
        /// </summary>
        /// <value>Specifies a description defining what the privilege provides.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies that this privilege is available for Helios operations.
        /// </summary>
        /// <value>Specifies that this privilege is available for Helios operations.</value>
        [DataMember(Name="isAvailableOnHelios", EmitDefaultValue=true)]
        public bool? IsAvailableOnHelios { get; set; }

        /// <summary>
        /// Specifies if this privilege is automatically assigned to custom roles.
        /// </summary>
        /// <value>Specifies if this privilege is automatically assigned to custom roles.</value>
        [DataMember(Name="isCustomRoleDefault", EmitDefaultValue=true)]
        public bool? IsCustomRoleDefault { get; set; }

        /// <summary>
        /// Specifies if this privilege is automatically assigned to the default System Admin user called &#39;admin&#39;. If true, the privilege is NOT assigned to the default System Admin user called &#39;admin&#39;. By default, privileges are automatically assigned to the default System Admin user called &#39;admin&#39;.
        /// </summary>
        /// <value>Specifies if this privilege is automatically assigned to the default System Admin user called &#39;admin&#39;. If true, the privilege is NOT assigned to the default System Admin user called &#39;admin&#39;. By default, privileges are automatically assigned to the default System Admin user called &#39;admin&#39;.</value>
        [DataMember(Name="isSpecial", EmitDefaultValue=true)]
        public bool? IsSpecial { get; set; }

        /// <summary>
        /// Specifies if privilege is view-only privilege that cannot make changes.
        /// </summary>
        /// <value>Specifies if privilege is view-only privilege that cannot make changes.</value>
        [DataMember(Name="isViewOnly", EmitDefaultValue=true)]
        public bool? IsViewOnly { get; set; }

        /// <summary>
        /// Specifies the label for the privilege as displayed on the Cohesity Dashboard such as &#39;Access Management View&#39;.
        /// </summary>
        /// <value>Specifies the label for the privilege as displayed on the Cohesity Dashboard such as &#39;Access Management View&#39;.</value>
        [DataMember(Name="label", EmitDefaultValue=true)]
        public string Label { get; set; }

        /// <summary>
        /// Specifies the Cluster name for the privilege such as PRINCIPAL_VIEW.
        /// </summary>
        /// <value>Specifies the Cluster name for the privilege such as PRINCIPAL_VIEW.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() { return ToJson(); }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivilegeInfo);
        }

        /// <summary>
        /// Returns true if PrivilegeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PrivilegeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrivilegeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrivilegeId == input.PrivilegeId ||
                    (this.PrivilegeId != null &&
                    this.PrivilegeId.Equals(input.PrivilegeId))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsAvailableOnHelios == input.IsAvailableOnHelios ||
                    (this.IsAvailableOnHelios != null &&
                    this.IsAvailableOnHelios.Equals(input.IsAvailableOnHelios))
                ) && 
                (
                    this.IsCustomRoleDefault == input.IsCustomRoleDefault ||
                    (this.IsCustomRoleDefault != null &&
                    this.IsCustomRoleDefault.Equals(input.IsCustomRoleDefault))
                ) && 
                (
                    this.IsSpecial == input.IsSpecial ||
                    (this.IsSpecial != null &&
                    this.IsSpecial.Equals(input.IsSpecial))
                ) && 
                (
                    this.IsViewOnly == input.IsViewOnly ||
                    (this.IsViewOnly != null &&
                    this.IsViewOnly.Equals(input.IsViewOnly))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PrivilegeId != null)
                    hashCode = hashCode * 59 + this.PrivilegeId.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsAvailableOnHelios != null)
                    hashCode = hashCode * 59 + this.IsAvailableOnHelios.GetHashCode();
                if (this.IsCustomRoleDefault != null)
                    hashCode = hashCode * 59 + this.IsCustomRoleDefault.GetHashCode();
                if (this.IsSpecial != null)
                    hashCode = hashCode * 59 + this.IsSpecial.GetHashCode();
                if (this.IsViewOnly != null)
                    hashCode = hashCode * 59 + this.IsViewOnly.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

