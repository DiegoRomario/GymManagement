using Microsoft.AspNetCore.Mvc;
using GymManagement.Contracts.Subscriptions;

namespace GymManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriptionsController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateSubscription(CreateSubscriptionRequest request)
    {
        return Ok(request);
    }
}