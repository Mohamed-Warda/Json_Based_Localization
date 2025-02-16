using JsonBasedLocalization.Web.Dtos;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace JsonBasedLocalization.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestApiController : ControllerBase
{
    private readonly IStringLocalizer<TestApiController> _localizer;

    public TestApiController(IStringLocalizer<TestApiController> localizer)
    {
        _localizer = localizer;
    }
    [HttpGet("{name}")]
    public IActionResult Welcome(string name)
    {
        return Ok(_localizer["userName", name].Value);
    }
    
    
    [HttpPost]
    public IActionResult Create(CreateTestDto dto)
    {
        if (ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok();
    }

    
}