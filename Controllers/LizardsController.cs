namespace lizardRoundUp.Controllers;


[ApiController]
[Route("api/lizards")]
public class LizardsController : ControllerBase
{
  private readonly LizardsService _lizardsService;
  public LizardsController(LizardsService lizardsService)
  {
    _lizardsService = lizardsService;
  }

  [HttpGet("test")]

  public ActionResult<string> Test()
  {
    try
    {
      return Ok("Testing 123");
    }
    catch (System.Exception e)
    {
      return BadRequest("I cant do that" + e.Message);
    }
  }

  [HttpGet]
  public ActionResult<List<Lizard>> GetAllLizards()
  {
    try
    {
      List<Lizard> lizards = _lizardsService.GetAllLizards();
      return Ok(lizards);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<Lizard> CreateLizard([FromBody] Lizard newLizard)
  {
    try
    {
      Lizard lizard = _lizardsService.CreateLizard(newLizard);
      return Ok(lizard);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{lizardId}")]
  public ActionResult<string> RemoveLizard(int lizardId)
  {
    try
    {
      string message = _lizardsService.RemoveLizard(lizardId);
      return Ok(message);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  [HttpPut("{lizardId}")]
  public ActionResult<Lizard> UpdateLizard(int lizardId, [FromBody] Lizard updateData)
  {
    try
    {
      updateData.Id = lizardId;
      Lizard lizard = _lizardsService.UpdateLizard(updateData);
      return Ok(lizard);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}