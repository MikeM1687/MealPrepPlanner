using Moq;
using Moq.Protected;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MealPrepPlanner.Tests.RestClientTests
{
    public class MockMessageHandler
    {
        public HttpClient GetMockClient()
        {
            var mockHttpMessageHandler = new Mock<HttpMessageHandler>();
            mockHttpMessageHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpResponseMessage>(), ItExpr.IsAny<CancellationToken>())
                .Returns((HttpResponseMessage request, CancellationToken CancellationToken) => GetMockResponseSuccess(request, CancellationToken));

            return new HttpClient(mockHttpMessageHandler.Object);
        }

        private Task<HttpResponseMessage> GetMockResponseSuccess(HttpResponseMessage request, CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            return Task.FromResult(response);
        }
    }
}
