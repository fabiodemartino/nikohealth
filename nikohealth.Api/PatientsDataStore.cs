using nikoHealth.Api.Models;
using System.Reflection;
using System.Text.Json;

namespace nikohealth.Api
{
    public class PatientsDataStore
    {
        private const string PatientDataFile = "nikohealth.Api.Assets.patientData.json";
        public List<PatientDto>? Patients { get; set; }
        
        public PatientsDataStore()
        {
            Patients = new List<PatientDto> { };
            Patients = JsonSerializer.Deserialize<List<PatientDto>>(LoadPatientData());
        }


        /// <summary>
        /// Load Patient data
        /// </summary>
        /// <returns>a Json result</returns>
        private static string LoadPatientData()
        {
            try
            {
                var jsonArray = ReadFile(PatientDataFile);
                return jsonArray;
            }
            catch (Exception e)
            {
                // to do add logging here
                Console.WriteLine(e);

            }
            return string.Empty;
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
}
