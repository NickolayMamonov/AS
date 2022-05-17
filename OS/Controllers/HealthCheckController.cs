using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace OS.Controllers;

[Controller]
[Route("/health")]
public class HealthCheckController : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context,
        CancellationToken cancellationToken = default(CancellationToken))
    {
        HttpClient client = new HttpClient();
        try
        {
            HttpResponseMessage responseAnimals = client.GetAsync("http://localhost:5000/api/countries").Result;
            HttpResponseMessage responseAreals = client.GetAsync("http://localhost:5000/api/mainlands").Result;
            if (responseAnimals.IsSuccessStatusCode && responseAreals.IsSuccessStatusCode)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("Service is alive"));
            }
        }
        catch (Exception e)
        {
        }
        return Task.FromResult(
            HealthCheckResult.Unhealthy("Service is dead"));
    }
}