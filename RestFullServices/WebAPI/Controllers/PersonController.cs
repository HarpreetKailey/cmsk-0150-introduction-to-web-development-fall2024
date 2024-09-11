using Domain;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService personService;

        public PersonController(ILogger<PersonController> logger,
            IPersonService personService)
        {
            _logger = logger;
            this.personService = personService;
        }

        // Extended Methods
        //

        [HttpGet("person/personType/{personTypeId}")]
        public async Task<ActionResult<ICollection<Person>>> GetPersonsByPersonType(int personTypeId)
        {
            try
            {
                if (personTypeId <= 0)
                    return BadRequest("Invalid person type");

                var result = await personService.GetPersonsByPersonType(personTypeId);
                if (result == null)
                    return BadRequest($"No People available with person type of {personTypeId}");

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // Common Methods
        //

        [HttpGet("person")]
        public async Task<ActionResult<IEnumerable<Person>>> GetPeople()
        {
            try
            {
                var result = await personService.GetAllAsync();
                if (result == null)
                    return BadRequest("No People available");

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("person/{id}")]
        public async Task<ActionResult<Person>> GetPerson(int id)
        {
            try
            {
                var result = await personService.GetAsync(id);
                if (result == null)
                    return BadRequest("Person not found");

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("person")]
        public virtual async Task<ActionResult<Person>> AddAsync([FromBody] Person person)
        {
            try
            {
                if (person == null)
                    return BadRequest("Invalid person entity");

                var result = await personService.AddAsync(person);
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("people")]
        public virtual async Task<ActionResult<IEnumerable<Person>>> AddAllAsync([FromBody] IEnumerable<Person> people)
        {
            try
            {
                if (people == null || people.Count() == 0)
                    return BadRequest("Invalid person entity list");

                var result = await personService.AddAllAsync(people);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("person/{id}")]
        public virtual async Task<ActionResult<Person>> UpdateAsync([FromBody] Person person, int id)
        {
            try
            {
                if (person == null)
                    return BadRequest("Invalid person entity");

                var result = await personService.UpdateAsync(person, id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("person/{id}")]
        public virtual async Task<ActionResult<Person>> RemoveAsync(int id)
        {
            try
            {
                var result = await personService.RemoveAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }   
        }
    }
}