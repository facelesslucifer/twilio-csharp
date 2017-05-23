using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Preview.HostedNumbers;

namespace Twilio.Tests.Rest.Preview.HostedNumbers 
{

    [TestFixture]
    public class HostedNumberOrderTest : TwilioTest 
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Preview,
                "/HostedNumbers/HostedNumberOrders/HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                HostedNumberOrderResource.Fetch("HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"address_sid\": \"AD11111111111111111111111111111111\",\"capabilities\": {\"sms\": true,\"voice\": false},\"cc_emails\": [\"aaa@twilio.com\",\"bbb@twilio.com\"],\"date_created\": \"2017-03-28T20:06:39Z\",\"date_updated\": \"2017-03-28T20:06:39Z\",\"email\": \"test@twilio.com\",\"friendly_name\": \"friendly_name\",\"incoming_phone_number_sid\": \"PN11111111111111111111111111111111\",\"phone_number\": \"+14153608311\",\"sid\": \"HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"signing_document_sid\": \"PX11111111111111111111111111111111\",\"status\": \"received\",\"unique_name\": \"foobar\",\"url\": \"https://preview.twilio.com/HostedNumbers/HostedNumberOrders/HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = HostedNumberOrderResource.Fetch("HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Preview,
                "/HostedNumbers/HostedNumberOrders/HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                HostedNumberOrderResource.Delete("HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = HostedNumberOrderResource.Delete("HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Preview,
                "/HostedNumbers/HostedNumberOrders/HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                HostedNumberOrderResource.Update("HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"address_sid\": \"AD11111111111111111111111111111111\",\"capabilities\": {\"sms\": true,\"voice\": false},\"cc_emails\": [\"test1@twilio.com\",\"test2@twilio.com\"],\"date_created\": \"2017-03-28T20:06:39Z\",\"date_updated\": \"2017-03-28T20:06:39Z\",\"email\": \"test+hosted@twilio.com\",\"friendly_name\": \"new friendly name\",\"incoming_phone_number_sid\": \"PN11111111111111111111111111111111\",\"phone_number\": \"+14153608311\",\"sid\": \"HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"signing_document_sid\": \"PX11111111111111111111111111111111\",\"status\": \"pending-loa\",\"unique_name\": \"new unique name\",\"url\": \"https://preview.twilio.com/HostedNumbers/HostedNumberOrders/HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = HostedNumberOrderResource.Update("HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Preview,
                "/HostedNumbers/HostedNumberOrders",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                HostedNumberOrderResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"first_page_url\": \"https://preview.twilio.com/HostedNumbers/HostedNumberOrders?PageSize=50&Page=0\",\"key\": \"items\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://preview.twilio.com/HostedNumbers/HostedNumberOrders?PageSize=50&Page=0\"},\"items\": []}"
                                     ));

            var response = HostedNumberOrderResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"first_page_url\": \"https://preview.twilio.com/HostedNumbers/HostedNumberOrders?PageSize=50&Page=0\",\"key\": \"items\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://preview.twilio.com/HostedNumbers/HostedNumberOrders?PageSize=50&Page=0\"},\"items\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"address_sid\": \"AD11111111111111111111111111111111\",\"capabilities\": {\"sms\": true,\"voice\": false},\"cc_emails\": [\"aaa@twilio.com\",\"bbb@twilio.com\"],\"date_created\": \"2017-03-28T20:06:39Z\",\"date_updated\": \"2017-03-28T20:06:39Z\",\"email\": \"test@twilio.com\",\"friendly_name\": \"friendly_name\",\"incoming_phone_number_sid\": \"PN11111111111111111111111111111111\",\"phone_number\": \"+14153608311\",\"sid\": \"HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"signing_document_sid\": \"PX11111111111111111111111111111111\",\"status\": \"received\",\"unique_name\": \"foobar\",\"url\": \"https://preview.twilio.com/HostedNumbers/HostedNumberOrders/HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}]}"
                                     ));

            var response = HostedNumberOrderResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Preview,
                "/HostedNumbers/HostedNumberOrders",
                ""
            );
            request.AddPostParam("AddressSid", Serialize("ADaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
            request.AddPostParam("PhoneNumber", Serialize(new Twilio.Types.PhoneNumber("+987654321")));
            request.AddPostParam("Type", Serialize(HostedNumberOrderResource.TypeEnum.Local));
            request.AddPostParam("IsoCountry", Serialize("IsoCountry"));
            request.AddPostParam("SmsCapability", Serialize(true));
            request.AddPostParam("Email", Serialize("Email"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                HostedNumberOrderResource.Create("ADaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", new Twilio.Types.PhoneNumber("+987654321"), HostedNumberOrderResource.TypeEnum.Local, "IsoCountry", true, "Email", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"address_sid\": \"AD11111111111111111111111111111111\",\"capabilities\": {\"sms\": true,\"voice\": false},\"cc_emails\": [],\"date_created\": \"2017-03-28T20:06:39Z\",\"date_updated\": \"2017-03-28T20:06:39Z\",\"email\": \"test@twilio.com\",\"friendly_name\": null,\"incoming_phone_number_sid\": \"PN11111111111111111111111111111111\",\"phone_number\": \"+14153608311\",\"sid\": \"HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"signing_document_sid\": null,\"status\": \"received\",\"unique_name\": null,\"url\": \"https://preview.twilio.com/HostedNumbers/HostedNumberOrders/HRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = HostedNumberOrderResource.Create("ADaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", new Twilio.Types.PhoneNumber("+987654321"), HostedNumberOrderResource.TypeEnum.Local, "IsoCountry", true, "Email", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}