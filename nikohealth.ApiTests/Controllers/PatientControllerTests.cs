using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using nikohealth.Api;
using nikohealth.Api.Controllers;
using nikoHealth.Api.Models;
using NUnit.Framework;

namespace nikohealth.ApiTests.Controllers
{
    [TestFixture()]
    public class PatientControllerTests
    {
        private Mock<ILogger<PatientController>> _logger;
        private PatientsDataStore? _patientsDataStore;

        [SetUp]
        protected void Setup()
        {
            _logger = new Mock<ILogger<PatientController>>();
            _patientsDataStore = new PatientsDataStore();
        }

        [Test()]
        public async Task GivenPatientsAreRequest_WhenThereAreNoPatients_ThenAPatientIsReturned()
        {
            //Arrange
            const string expectedFirstName = "FirstName";
            const string expectedLastName = "LastName";
            var patientList = new List<PatientDto>();
            var patientPerson = new Person()
            {
                FirstName = expectedFirstName,
                LastName = expectedLastName
            };
            var patientGeneral = new General
            {
                DateOfBirth = DateTime.Now,
                Name = patientPerson
            };
            var patient = new PatientDto()
            {
                General = patientGeneral
            };
            patientList.Add(patient);

            _patientsDataStore = new PatientsDataStore
            {
                Patients = patientList
                };
            PatientsDataStore.Current = _patientsDataStore;


            var sut = GetSut();

            //Act
            var result = await sut.GetPatients();

            //Assert
            var actualResult = result.Result as OkObjectResult;

            var actualReturnedList = (List<PatientDto>)actualResult?.Value!;

            Assert.AreEqual( expectedFirstName, actualReturnedList[0].General.Name.FirstName);
            Assert.AreEqual(expectedLastName, actualReturnedList[0].General.Name.LastName);

        }

        [Test()]
        public async Task GivenPatientsAreRequest_WhenThereAreNoPatients_ThenANullIsReturned()
        {
            //Arrange
            var sut = GetSut();
            PatientsDataStore.Current = null;

            //Act
            var result = await sut.GetPatients();

            //Assert
            var actualResult = result.Result as OkObjectResult;
            var actualReturnedList = (List<PatientDto>)actualResult?.Value!;

            Assert.That(actualReturnedList, Is.Null);
          
        }

        private PatientController GetSut()
        {
            return new PatientController(_logger.Object, _patientsDataStore);
        }

    }
}