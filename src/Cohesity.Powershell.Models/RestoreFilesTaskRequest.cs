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
    /// Specifies information about a Restore Task that recovers files and folders.
    /// </summary>
    [DataContract]
    public partial class RestoreFilesTaskRequest :  IEquatable<RestoreFilesTaskRequest>
    {
        /// <summary>
        /// Specifies the target host types to be restored. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system.
        /// </summary>
        /// <value>Specifies the target host types to be restored. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TargetHostTypeEnum
        {
            /// <summary>
            /// Enum KLinux for value: kLinux
            /// </summary>
            [EnumMember(Value = "kLinux")]
            KLinux = 1,

            /// <summary>
            /// Enum KWindows for value: kWindows
            /// </summary>
            [EnumMember(Value = "kWindows")]
            KWindows = 2,

            /// <summary>
            /// Enum KAix for value: kAix
            /// </summary>
            [EnumMember(Value = "kAix")]
            KAix = 3,

            /// <summary>
            /// Enum KSolaris for value: kSolaris
            /// </summary>
            [EnumMember(Value = "kSolaris")]
            KSolaris = 4

        }

        /// <summary>
        /// Specifies the target host types to be restored. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system.
        /// </summary>
        /// <value>Specifies the target host types to be restored. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system.</value>
        [DataMember(Name="targetHostType", EmitDefaultValue=true)]
        public TargetHostTypeEnum? TargetHostType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreFilesTaskRequest" /> class.
        /// </summary>
        /// <param name="continueOnError">Specifies if the Restore Task should continue even if the copy operation of some files and folders fails. If true, the Cohesity Cluster ignores intermittent errors and recovers as many files and folders as possible. If false, the Restore Task stops recovering when a copy operation fails..</param>
        /// <param name="filenames">Array of Files or Folders.  Specifies the files and folders to recover from the snapshot..</param>
        /// <param name="isFileBasedVolumeRestore">Specifies whether this is a file based volume restore..</param>
        /// <param name="name">Specifies the name of the Restore Task. This field must be set and must be a unique name..</param>
        /// <param name="newBaseDirectory">Specifies an optional root folder where to recover the selected files and folders. By default, files and folders are restored to their original path..</param>
        /// <param name="overwrite">If true, any existing files and folders on the operating system are overwritten by the recovered files or folders. This is the default. If false, existing files and folders are not overwritten..</param>
        /// <param name="password">Specifies password of the username to access the target source..</param>
        /// <param name="preserveAttributes">If true, the Restore Tasks preserves the original file and folder attributes. This is the default..</param>
        /// <param name="sourceObjectInfo">Specifies information about the source object (such as a VM) that contains the files and folders to recover. In addition, it contains information about the Protection Job and Job Run that captured the snapshot to recover from. To specify a particular snapshot, you must specify a jobRunId and a startTimeUsecs. If jobRunId and startTimeUsecs are not specified, the last Job Run of the specified Job is used..</param>
        /// <param name="targetHostType">Specifies the target host types to be restored. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system..</param>
        /// <param name="targetParentSourceId">Specifies the registered source (such as a vCenter Server) that contains the target protection source (such as a VM) where the files and folders are recovered to. This field is not required for a Physical Server..</param>
        /// <param name="targetSourceId">Specifies the id of the target protection source (such as a VM) where the files and folders are recovered to..</param>
        /// <param name="username">Specifies username to access the target source..</param>
        public RestoreFilesTaskRequest(bool? continueOnError = default(bool?), List<string> filenames = default(List<string>), bool? isFileBasedVolumeRestore = default(bool?), string name = default(string), string newBaseDirectory = default(string), bool? overwrite = default(bool?), string password = default(string), bool? preserveAttributes = default(bool?), RestoreObjectDetails sourceObjectInfo = default(RestoreObjectDetails), TargetHostTypeEnum? targetHostType = default(TargetHostTypeEnum?), long? targetParentSourceId = default(long?), long? targetSourceId = default(long?), string username = default(string))
        {
            this.ContinueOnError = continueOnError;
            this.Filenames = filenames;
            this.IsFileBasedVolumeRestore = isFileBasedVolumeRestore;
            this.Name = name;
            this.NewBaseDirectory = newBaseDirectory;
            this.Overwrite = overwrite;
            this.Password = password;
            this.PreserveAttributes = preserveAttributes;
            this.SourceObjectInfo = sourceObjectInfo;
            this.TargetHostType = targetHostType;
            this.TargetParentSourceId = targetParentSourceId;
            this.TargetSourceId = targetSourceId;
            this.Username = username;
            this.ContinueOnError = continueOnError;
            this.Filenames = filenames;
            this.IsFileBasedVolumeRestore = isFileBasedVolumeRestore;
            this.Name = name;
            this.NewBaseDirectory = newBaseDirectory;
            this.Overwrite = overwrite;
            this.Password = password;
            this.PreserveAttributes = preserveAttributes;
            this.SourceObjectInfo = sourceObjectInfo;
            this.TargetHostType = targetHostType;
            this.TargetParentSourceId = targetParentSourceId;
            this.TargetSourceId = targetSourceId;
            this.Username = username;
        }
        
        /// <summary>
        /// Specifies if the Restore Task should continue even if the copy operation of some files and folders fails. If true, the Cohesity Cluster ignores intermittent errors and recovers as many files and folders as possible. If false, the Restore Task stops recovering when a copy operation fails.
        /// </summary>
        /// <value>Specifies if the Restore Task should continue even if the copy operation of some files and folders fails. If true, the Cohesity Cluster ignores intermittent errors and recovers as many files and folders as possible. If false, the Restore Task stops recovering when a copy operation fails.</value>
        [DataMember(Name="continueOnError", EmitDefaultValue=true)]
        public bool? ContinueOnError { get; set; }

        /// <summary>
        /// Array of Files or Folders.  Specifies the files and folders to recover from the snapshot.
        /// </summary>
        /// <value>Array of Files or Folders.  Specifies the files and folders to recover from the snapshot.</value>
        [DataMember(Name="filenames", EmitDefaultValue=true)]
        public List<string> Filenames { get; set; }

        /// <summary>
        /// Specifies whether this is a file based volume restore.
        /// </summary>
        /// <value>Specifies whether this is a file based volume restore.</value>
        [DataMember(Name="isFileBasedVolumeRestore", EmitDefaultValue=true)]
        public bool? IsFileBasedVolumeRestore { get; set; }

        /// <summary>
        /// Specifies the name of the Restore Task. This field must be set and must be a unique name.
        /// </summary>
        /// <value>Specifies the name of the Restore Task. This field must be set and must be a unique name.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies an optional root folder where to recover the selected files and folders. By default, files and folders are restored to their original path.
        /// </summary>
        /// <value>Specifies an optional root folder where to recover the selected files and folders. By default, files and folders are restored to their original path.</value>
        [DataMember(Name="newBaseDirectory", EmitDefaultValue=true)]
        public string NewBaseDirectory { get; set; }

        /// <summary>
        /// If true, any existing files and folders on the operating system are overwritten by the recovered files or folders. This is the default. If false, existing files and folders are not overwritten.
        /// </summary>
        /// <value>If true, any existing files and folders on the operating system are overwritten by the recovered files or folders. This is the default. If false, existing files and folders are not overwritten.</value>
        [DataMember(Name="overwrite", EmitDefaultValue=true)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// Specifies password of the username to access the target source.
        /// </summary>
        /// <value>Specifies password of the username to access the target source.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// If true, the Restore Tasks preserves the original file and folder attributes. This is the default.
        /// </summary>
        /// <value>If true, the Restore Tasks preserves the original file and folder attributes. This is the default.</value>
        [DataMember(Name="preserveAttributes", EmitDefaultValue=true)]
        public bool? PreserveAttributes { get; set; }

        /// <summary>
        /// Specifies information about the source object (such as a VM) that contains the files and folders to recover. In addition, it contains information about the Protection Job and Job Run that captured the snapshot to recover from. To specify a particular snapshot, you must specify a jobRunId and a startTimeUsecs. If jobRunId and startTimeUsecs are not specified, the last Job Run of the specified Job is used.
        /// </summary>
        /// <value>Specifies information about the source object (such as a VM) that contains the files and folders to recover. In addition, it contains information about the Protection Job and Job Run that captured the snapshot to recover from. To specify a particular snapshot, you must specify a jobRunId and a startTimeUsecs. If jobRunId and startTimeUsecs are not specified, the last Job Run of the specified Job is used.</value>
        [DataMember(Name="sourceObjectInfo", EmitDefaultValue=true)]
        public RestoreObjectDetails SourceObjectInfo { get; set; }

        /// <summary>
        /// Specifies the registered source (such as a vCenter Server) that contains the target protection source (such as a VM) where the files and folders are recovered to. This field is not required for a Physical Server.
        /// </summary>
        /// <value>Specifies the registered source (such as a vCenter Server) that contains the target protection source (such as a VM) where the files and folders are recovered to. This field is not required for a Physical Server.</value>
        [DataMember(Name="targetParentSourceId", EmitDefaultValue=true)]
        public long? TargetParentSourceId { get; set; }

        /// <summary>
        /// Specifies the id of the target protection source (such as a VM) where the files and folders are recovered to.
        /// </summary>
        /// <value>Specifies the id of the target protection source (such as a VM) where the files and folders are recovered to.</value>
        [DataMember(Name="targetSourceId", EmitDefaultValue=true)]
        public long? TargetSourceId { get; set; }

        /// <summary>
        /// Specifies username to access the target source.
        /// </summary>
        /// <value>Specifies username to access the target source.</value>
        [DataMember(Name="username", EmitDefaultValue=true)]
        public string Username { get; set; }

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
            return this.Equals(input as RestoreFilesTaskRequest);
        }

        /// <summary>
        /// Returns true if RestoreFilesTaskRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreFilesTaskRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreFilesTaskRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContinueOnError == input.ContinueOnError ||
                    (this.ContinueOnError != null &&
                    this.ContinueOnError.Equals(input.ContinueOnError))
                ) && 
                (
                    this.Filenames == input.Filenames ||
                    this.Filenames != null &&
                    input.Filenames != null &&
                    this.Filenames.SequenceEqual(input.Filenames)
                ) && 
                (
                    this.IsFileBasedVolumeRestore == input.IsFileBasedVolumeRestore ||
                    (this.IsFileBasedVolumeRestore != null &&
                    this.IsFileBasedVolumeRestore.Equals(input.IsFileBasedVolumeRestore))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NewBaseDirectory == input.NewBaseDirectory ||
                    (this.NewBaseDirectory != null &&
                    this.NewBaseDirectory.Equals(input.NewBaseDirectory))
                ) && 
                (
                    this.Overwrite == input.Overwrite ||
                    (this.Overwrite != null &&
                    this.Overwrite.Equals(input.Overwrite))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.PreserveAttributes == input.PreserveAttributes ||
                    (this.PreserveAttributes != null &&
                    this.PreserveAttributes.Equals(input.PreserveAttributes))
                ) && 
                (
                    this.SourceObjectInfo == input.SourceObjectInfo ||
                    (this.SourceObjectInfo != null &&
                    this.SourceObjectInfo.Equals(input.SourceObjectInfo))
                ) && 
                (
                    this.TargetHostType == input.TargetHostType ||
                    this.TargetHostType.Equals(input.TargetHostType)
                ) && 
                (
                    this.TargetParentSourceId == input.TargetParentSourceId ||
                    (this.TargetParentSourceId != null &&
                    this.TargetParentSourceId.Equals(input.TargetParentSourceId))
                ) && 
                (
                    this.TargetSourceId == input.TargetSourceId ||
                    (this.TargetSourceId != null &&
                    this.TargetSourceId.Equals(input.TargetSourceId))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.ContinueOnError != null)
                    hashCode = hashCode * 59 + this.ContinueOnError.GetHashCode();
                if (this.Filenames != null)
                    hashCode = hashCode * 59 + this.Filenames.GetHashCode();
                if (this.IsFileBasedVolumeRestore != null)
                    hashCode = hashCode * 59 + this.IsFileBasedVolumeRestore.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NewBaseDirectory != null)
                    hashCode = hashCode * 59 + this.NewBaseDirectory.GetHashCode();
                if (this.Overwrite != null)
                    hashCode = hashCode * 59 + this.Overwrite.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PreserveAttributes != null)
                    hashCode = hashCode * 59 + this.PreserveAttributes.GetHashCode();
                if (this.SourceObjectInfo != null)
                    hashCode = hashCode * 59 + this.SourceObjectInfo.GetHashCode();
                hashCode = hashCode * 59 + this.TargetHostType.GetHashCode();
                if (this.TargetParentSourceId != null)
                    hashCode = hashCode * 59 + this.TargetParentSourceId.GetHashCode();
                if (this.TargetSourceId != null)
                    hashCode = hashCode * 59 + this.TargetSourceId.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

    }

}

