using Microsoft.AspNetCore.Mvc;
using nikoHealth.Api.Models;
using nikohealth.Api.Models;

namespace nikohealth.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:ApiVersion}/patient")]
public class PatientController : ControllerBase
{

    private readonly ILogger<PatientController> _logger;
    private readonly PatientsDataStore _patientsDataStore;
    public PatientController(ILogger<PatientController> logger,
       PatientsDataStore patientsDataStore)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _patientsDataStore = patientsDataStore ?? throw new ArgumentNullException(nameof(patientsDataStore));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PatientDto>>> GetPatients()
    {
        return Ok(PatientsDataStore.Current.Patients);

    }

    [HttpGet("{patientId}", Name = "GetPatient")]
    public async Task<ActionResult<PatientDto>> GetPatient(
        string patientId )
    {
        try
        {
            if (_patientsDataStore.Patients != null)
            {
                var patientToReturn = _patientsDataStore.Patients.FirstOrDefault(
                    p => p.Id == patientId);
                if (patientToReturn == null)
                {
                    return NotFound();
                }

                return Ok(patientToReturn);
            }
            return StatusCode(500, "A problem happened while handling your request.");
        }
        catch (Exception ex)
        {
            _logger.LogCritical(
                $"Exception while getting patient data for patient with id {patientId}.",
                ex);
            return StatusCode(500, "A problem happened while handling your request.");
        }
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
