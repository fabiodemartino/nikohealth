using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using nikoHealth.Api.Models;

namespace nikohealth.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:ApiVersion}/patient")]
public class PatientController : ControllerBase
{
    [HttpGet]
    public JsonResult GetPatient()
    {
        return LoadPatient();
    }

    private JsonResult LoadPatient()
    {
        const string jsonArray = @"
                    [
                    {
                        ""Id"": ""1"",
                        ""DisplayId"": ""1"",
                        ""General"": {
                          ""Name"": {
                            ""FirstName"": ""Fabio"",
                            ""LastName"": ""De Martino"",
                            ""MiddleName"": ""string""
                          },
                          ""DateOfBirth"": ""2023-08-22"",
                          ""Gender"": ""Unknown"",
                          ""Prefix"": ""Mr"",
                          ""Weight"": 0,
                          ""Height"": 0,
                          ""Ssn"": ""Something"",
                          ""NickName"": ""string"",
                          ""MaritalStatus"": ""Single""
                        },
                        ""Status"": {
                          ""Status"": ""Active"",
                          ""DcDate"": ""2023-08-22"",
                          ""InactiveStatus"": ""InsuranceExpired"",
                          ""InactiveStatusText"": ""string""
                        },
                        ""Addresses"": {
                          ""Patient"": {
                            ""AddressLine"": ""Some where"",
                            ""AddressLine2"": ""string"",
                            ""City"": ""string"",
                            ""State"": ""st"",
                            ""Zip"": ""string""
                          },
                          ""Delivery"": {
                            ""AddressLine"": ""string"",
                            ""AddressLine2"": ""string"",
                            ""City"": ""string"",
                            ""State"": ""st"",
                            ""Zip"": ""strin""
                          },
                          ""SkipPatientAddressVerification"": true,
                          ""SkipDeliveryAddressVerification"": true
                        },
                        ""Contacts"": {
                          ""Contacts"": [
                            {
                              ""Type"": ""Home"",
                              ""Value"": ""string"",
                              ""Ext"": ""string""
                            }
                          ],
                          ""PreferredContactType"": ""Home"",
                          ""PreferredCallTime"": ""Morning""
                        },
                        ""SignatureOnFile"": {
                          ""IsSigned"": true,
                          ""SignedDate"": ""2023-08-22""
                        },
                        ""EmergencyContact"": {
                          ""Person"": {
                            ""FirstName"": ""string"",
                            ""LastName"": ""string"",
                            ""MiddleName"": ""string""
                          },
                          ""Relationship"": ""Child"",
                          ""RelationshipOther"": ""string"",
                          ""Address"": {
                            ""AddressLine"": ""string"",
                            ""AddressLine2"": ""string"",
                            ""City"": ""string"",
                            ""State"": ""st"",
                            ""Zip"": ""strin""
                          },
                          ""Contacts"": [
                            {
                              ""Type"": ""Home"",
                              ""Value"": ""string"",
                              ""Ext"": ""string""
                            }
                          ]
                        },
                        ""EmployerContact"": {
                          ""Employer"": ""string"",
                          ""Address"": {
                            ""AddressLine"": ""string"",
                            ""AddressLine2"": ""string"",
                            ""City"": ""string"",
                            ""State"": ""st"",
                            ""Zip"": ""strin""
                          },
                          ""Contacts"": [
                            {
                              ""Type"": ""Home"",
                              ""Value"": ""string"",
                              ""Ext"": ""string""
                            }
                          ]
                        },
                        ""ResponsibleContact"": {
                          ""Person"": {
                            ""FirstName"": ""string"",
                            ""LastName"": ""string"",
                            ""MiddleName"": ""string""
                          },
                          ""Type"": ""Spouse"",
                          ""Address"": {
                            ""AddressLine"": ""string"",
                            ""AddressLine2"": ""string"",
                            ""City"": ""string"",
                            ""State"": ""st"",
                            ""Zip"": ""strin""
                          },
                          ""Contacts"": [
                            {
                              ""Type"": ""Home"",
                              ""Value"": ""string"",
                              ""Ext"": ""string""
                            }
                          ]
                        },
                        ""MedicalReleaseInfo"": [
                          {
                            ""Name"": {
                              ""FirstName"": ""string"",
                              ""LastName"": ""string"",
                              ""MiddleName"": ""string""
                            },
                            ""RelationType"": ""Spouse"",
                            ""Email"": ""string"",
                            ""Phone"": ""string""
                          }
                        ],
                        ""Location"": {
                          ""Id"": ""string"",
                          ""Name"": ""string"",
                          ""Npi"": ""string""
                        },
                        ""FacilityLocation"": {
                          ""Id"": ""string"",
                          ""Address"": {
                            ""AddressLine"": ""string"",
                            ""AddressLine2"": ""string"",
                            ""City"": ""string"",
                            ""State"": ""st"",
                            ""Zip"": ""strin""
                          }
                        },
                        ""Tags"": [
                          {
                            ""Id"": ""string"",
                            ""Name"": ""string""
                          }
                        ],
                        ""TaxExemption"": {
                          ""Enabled"": true,
                          ""Note"": ""string""
                        }
                      }
                    ]
                 ";

        var patientDto = JsonSerializer.Deserialize<List<PatientDto>>(jsonArray);

        return new JsonResult(patientDto);


    }

}
