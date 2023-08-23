using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using nikoHealth.Api.Models;
using System.Reflection;

namespace nikohealth.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:ApiVersion}/patient")]
public class PatientController : ControllerBase
{
    [HttpGet]
    public Task<ActionResult<IEnumerable<PatientDto>>> GetPatients()
    {
        return Task.FromResult<ActionResult<IEnumerable<PatientDto>>>(LoadPatient());
    }


    /// <summary>
    /// Load Patient data
    /// </summary>
    /// <returns>a Json result</returns>
    private static JsonResult LoadPatient()
    {
        try
        {
            var jsonArray = ReadFile("nikohealth.Api.Assets.patientData.json");
            var patientDto = JsonSerializer.Deserialize<List<PatientDto>>(jsonArray);
            return new JsonResult(patientDto);
        }
        catch (Exception e)
        {
            // to do add logging here
            Console.WriteLine(e);
            
        }

        return new JsonResult(null);
    }

    /// <summary>
    /// Read an embedded resource file and return its content as string
    /// </summary>
    /// <param name="fileToRead"></param>
    /// <returns>a string containing the file content</returns>
    private static string ReadFile(string fileToRead)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var result = string.Empty;
        using var stream = assembly.GetManifestResourceStream(fileToRead);
        if (stream == null) return result;
        using var reader = new StreamReader(stream);
        result = reader.ReadToEnd();

        return result;
    }

}
