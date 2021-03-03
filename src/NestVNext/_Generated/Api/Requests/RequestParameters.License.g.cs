// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗ 
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝ 
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗   
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝   
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗ 
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝ 
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System;
using System.Threading;
using System.Threading.Tasks;
using Elastic.Transport;

#nullable enable
namespace Nest
{
    public class DeleteLicenseRequestParameters : RequestParameters<DeleteLicenseRequestParameters>
    {
    }

    public class GetBasicLicenseStatusRequestParameters : RequestParameters<GetBasicLicenseStatusRequestParameters>
    {
    }

    public class GetLicenseRequestParameters : RequestParameters<GetLicenseRequestParameters>
    {
        public bool? AcceptEnterprise
        {
            get => Q<bool?>("accept_enterprise");
            set => Q("accept_enterprise", value);
        }

        public bool? Local
        {
            get => Q<bool?>("local");
            set => Q("local", value);
        }
    }

    public class GetTrialLicenseStatusRequestParameters : RequestParameters<GetTrialLicenseStatusRequestParameters>
    {
    }

    public class PostLicenseRequestParameters : RequestParameters<PostLicenseRequestParameters>
    {
        public bool? Acknowledge
        {
            get => Q<bool?>("acknowledge");
            set => Q("acknowledge", value);
        }
    }

    public class StartBasicLicenseRequestParameters : RequestParameters<StartBasicLicenseRequestParameters>
    {
        public bool? Acknowledge
        {
            get => Q<bool?>("acknowledge");
            set => Q("acknowledge", value);
        }
    }

    public class StartTrialLicenseRequestParameters : RequestParameters<StartTrialLicenseRequestParameters>
    {
        public bool? Acknowledge
        {
            get => Q<bool?>("acknowledge");
            set => Q("acknowledge", value);
        }

        public string? TypeQueryString
        {
            get => Q<string?>("type_query_string");
            set => Q("type_query_string", value);
        }
    }
}