using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using nikoHealth.Api.Models;
using System.Reflection;
using nikohealth.Api.Models;

namespace nikohealth.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:ApiVersion}/patient")]
public class PatientController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PatientDto>>> GetPatients()
    {
        return Ok(PatientsDataStore.Current.Patients);

    }

    [HttpGet("{patientId}", Name = "GetPatient")]
    public async Task<ActionResult<PatientDto>> GetPatient(
        string patientId )
    {
        if (PatientsDataStore.Current.Patients != null)
        {
            var patientToReturn = PatientsDataStore.Current.Patients.FirstOrDefault(
                p => p.Id == patientId);
            if (patientToReturn == null)
            {
                return NotFound();
            }
            return Ok(patientToReturn);
        }
        return BadRequest();
    }

    [HttpPost]

    public Task<ActionResult<PatientDto>> CreatePatient(string patientId,
        PatientForCreationDto patient)
    {

        var createdPatient = new PatientDto()
        {
            Id = patientId,
            General = patient.General
        };
        
        return Task.FromResult<ActionResult<PatientDto>>(CreatedAtRoute("GetPatient", new
        {
            patientId
        }, createdPatient));


    }


    

    

}
