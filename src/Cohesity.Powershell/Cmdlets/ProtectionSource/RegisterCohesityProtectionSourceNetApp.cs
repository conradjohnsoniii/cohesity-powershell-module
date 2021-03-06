﻿// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Model;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionSource
{
    /// <summary>
    /// <para type="synopsis">
    /// Registers a new NetApp protection source with the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Registers a new NetApp protection source with the Cohesity Cluster.
    /// </para>
    /// </summary>
    /// <example>
    /// <para>PS&gt;</para>
    /// <code>
    /// Register-CohesityProtectionSourceNetApp -Server netapp-cluster.example.com -Type KCluster -Credential (Get-Credential)
    /// </code>
    /// <para>
    /// Registers a new NetApp cluster with hostname "netapp-cluster.example.com" with the Cohesity Cluster.
    /// </para>
    /// </example>
    [Cmdlet(VerbsLifecycle.Register, "CohesityProtectionSourceNetApp")]
    [OutputType(typeof(Model.ProtectionSource))]
    public class RegisterCohesityProtectionSourceNetApp : PSCmdlet
    {
        private Session Session
        {
            get
            {
                if (!(SessionState.PSVariable.GetValue("Session") is Session result))
                {
                    result = new Session();
                    SessionState.PSVariable.Set("Session", result);
                }
                return result;
            }
        }

        #region Params

        /// <summary>
        /// <para type="description">
        /// Hostname or IP Address for the NetApp cluster or Vserver.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string Server { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// User credentials for the NetApp cluster or Vserver.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public PSCredential Credential { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Type of NetApp server. Must be set to KCluster or KVserver.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public RegisterProtectionSourceParameters.NetappTypeEnum? Type { get; set; } = null;

        #endregion

        #region Processing

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var param = new RegisterProtectionSourceParameters
            {
                Environment = RegisterProtectionSourceParameters.EnvironmentEnum.KNetapp,
                NetappType = Type,
                Endpoint = Server,
                Username = Credential.UserName,
                Password = Credential.GetNetworkCredential().Password
            };

            // POST /public/protectionSources/register
            var preparedUrl = $"/public/protectionSources/register";
            var result = Session.ApiClient.Post<Model.ProtectionSource>(preparedUrl, param);
            WriteObject(result);
        }

        #endregion
    }
}