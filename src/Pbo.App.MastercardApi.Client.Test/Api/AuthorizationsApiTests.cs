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
    ///  Class for testing AuthorizationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuthorizationsApiTests : IDisposable
    {
        private AuthorizationsApi instance;

        public AuthorizationsApiTests()
        {
            instance = new AuthorizationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthorizationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AuthorizationsApi
            //Assert.IsType<AuthorizationsApi>(instance);
        }

        /// <summary>
        /// Test GetAuthorizationsUsingGET
        /// </summary>
        [Fact]
        public void GetAuthorizationsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //DateTime fromDate = null;
            //DateTime toDate = null;
            //bool includeReprocessed = null;
            //string userIdType = null;
            //string externalId = null;
            //List<string> pwrFilterCategories = null;
            //var response = instance.GetAuthorizationsUsingGET(userId, fromDate, toDate, includeReprocessed, userIdType, externalId, pwrFilterCategories);
            //Assert.IsType<List<Authorization>>(response);
        }

        /// <summary>
        /// Test PostAuthorizationsUsingPOST
        /// </summary>
        [Fact]
        public void PostAuthorizationsUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AuthorizationRequest authorizationRequest = null;
            //var response = instance.PostAuthorizationsUsingPOST(authorizationRequest);
            //Assert.IsType<List<AuthorizationPostResponse>>(response);
        }
    }
}
