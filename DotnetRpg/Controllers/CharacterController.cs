using DotnetRpg.Dtos.Character;
using DotnetRpg.Services.CharacterService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotnetRpg.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class CharacterController : ControllerBase
{
    private readonly ICharacterService _characterService;

    public CharacterController(ICharacterService characterService)
    {
        _characterService = characterService;
    }

    [HttpGet("all")]
    public async Task<ActionResult<ServiceResponse<List<GetCharacterListingDto>>>> GetAll()
    {
        var response = await _characterService.GetAllCharacters();
        return Ok(response);
    }

    [HttpGet("{characterId}/enemies")]
    public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> GetEnemies(
        int characterId
    )
    {
        var response = await _characterService.GetEnemies(characterId);
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
    {
        var response = await _characterService.GetCharacterById(id);
        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Add(
        AddCharacterDto newCharacter
    )
    {
        var response = await _characterService.AddCharacter(newCharacter);
        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Delete(int id)
    {
        var response = await _characterService.DeleteCharacter(id);
        return Ok(response);
    }
}
