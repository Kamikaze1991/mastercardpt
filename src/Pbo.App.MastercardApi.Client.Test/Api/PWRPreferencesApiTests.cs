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
    ///  Class for testing PWRPreferencesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PWRPreferencesApiTests : IDisposable
    {
        private PWRPreferencesApi instance;

        public PWRPreferencesApiTests()
        {
            instance = new PWRPreferencesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PWRPreferencesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PWRPreferencesApi
            //Assert.IsType<PWRPreferencesApi>(instance);
        }

        /// <summary>
        /// Test GetPreferencesUsingGET
        /// </summary>
        [Fact]
        public void GetPreferencesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string redemptionType = null;
            //string userIdType = null;
            //var response = instance.GetPreferencesUsingGET(id, redemptionType, userIdType);
            //Assert.IsType<Preferences>(response);
        }

        /// <summary>
        /// Test SetPreferencesUsingPUT
        /// </summary>
        [Fact]
        public void SetPreferencesUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string redemptionType = null;
            //SetPreferencesRequest setPreferencesRequest = null;
            //instance.SetPreferencesUsingPUT(id, redemptionType, setPreferencesRequest);
        }
    }
}
