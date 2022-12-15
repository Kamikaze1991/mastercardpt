/*
 * Pay with Rewards APIs
 *
 * Pay with Rewards allows cardholders to redeem points for purchases made with an enrolled Mastercard card. The following APIs create the Pay with Rewards user experience, and can be used inside a banking app or other mobile apps.
 *
 * The version of the OpenAPI document: 1.1
 * Contact: paywithrewards@mastercard.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Pbo.App.MastercardApi.Client.Client;
using Pbo.App.MastercardApi.Client.Api;
// uncomment below to import models
//using Pbo.App.MastercardApi.Client.Model;

namespace Pbo.App.MastercardApi.Client.Test.Api
{
    /// <summary>
    ///  Class for testing ReprocessAuthorizationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReprocessAuthorizationApiTests : IDisposable
    {
        private ReprocessAuthorizationApi instance;

        public ReprocessAuthorizationApiTests()
        {
            instance = new ReprocessAuthorizationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReprocessAuthorizationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ReprocessAuthorizationApi
            //Assert.IsType<ReprocessAuthorizationApi>(instance);
        }

        /// <summary>
        /// Test ReprocessAuthorizationsUsingPOST
        /// </summary>
        [Fact]
        public void ReprocessAuthorizationsUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ReprocessRequest reprocessRequest = null;
            //var response = instance.ReprocessAuthorizationsUsingPOST(id, reprocessRequest);
            //Assert.IsType<ReprocessResponse>(response);
        }
    }
}
