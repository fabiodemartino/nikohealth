using System.Text.Json.Serialization;

namespace nikoHealth.Api.Models
{
    public partial class PatientDto
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("DisplayId")]
        public string DisplayId { get; set; }

        [JsonPropertyName("General")] public General General { get; set; }

        [JsonPropertyName("Status")] public Status Status { get; set; }

        [JsonPropertyName("Addresses")] public Addresses Addresses { get; set; }

        [JsonPropertyName("Contacts")] public Contacts Contacts { get; set; }

        [JsonPropertyName("SignatureOnFile")] public SignatureOnFile SignatureOnFile { get; set; }

        [JsonPropertyName("EmergencyContact")] public EmergencyContact EmergencyContact { get; set; }

        [JsonPropertyName("EmployerContact")] public EmployerContact EmployerContact { get; set; }

        [JsonPropertyName("ResponsibleContact")] public ResponsibleContact ResponsibleContact { get; set; }

        [JsonPropertyName("MedicalReleaseInfo")] public MedicalReleaseInfo[] MedicalReleaseInfo { get; set; }

        [JsonPropertyName("Location")] public Location Location { get; set; }

        [JsonPropertyName("FacilityLocation")] public FacilityLocation FacilityLocation { get; set; }

        [JsonPropertyName("Tags")] public Tag[] Tags { get; set; }

        [JsonPropertyName("TaxExemption")] public TaxExemption TaxExemption { get; set; }
    }

    public partial class Addresses
    {
        [JsonPropertyName("Patient")] public Delivery Patient { get; set; }

        [JsonPropertyName("Delivery")] public Delivery Delivery { get; set; }

        [JsonPropertyName("SkipPatientAddressVerification")]
        public bool SkipPatientAddressVerification { get; set; }

        [JsonPropertyName("SkipDeliveryAddressVerification")]
        public bool SkipDeliveryAddressVerification { get; set; }
    }

    public partial class Delivery
    {
        [JsonPropertyName("AddressLine")] public string AddressLine { get; set; }

        [JsonPropertyName("AddressLine2")] public string AddressLine2 { get; set; }

        [JsonPropertyName("City")] public string City { get; set; }

        [JsonPropertyName("State")] public string State { get; set; }

        [JsonPropertyName("Zip")] public string Zip { get; set; }
    }

    public partial class Contacts
    {
        [JsonPropertyName("Contacts")] public Contact[] ContactsContacts { get; set; }

        [JsonPropertyName("PreferredContactType")] public string PreferredContactType { get; set; }

        [JsonPropertyName("PreferredCallTime")] public string PreferredCallTime { get; set; }
    }

    public partial class Contact
    {
        [JsonPropertyName("Type")] public string Type { get; set; }

        [JsonPropertyName("Value")] public string Value { get; set; }

        [JsonPropertyName("Ext")] public string Ext { get; set; }
    }

    public partial class EmergencyContact
    {
        [JsonPropertyName("Person")] public Person Person { get; set; }

        [JsonPropertyName("Relationship")] public string Relationship { get; set; }

        [JsonPropertyName("RelationshipOther")] public string RelationshipOther { get; set; }

        [JsonPropertyName("Address")] public Delivery Address { get; set; }

        [JsonPropertyName("Contacts")] public Contact[] Contacts { get; set; }
    }

    public partial class Person
    {
        [JsonPropertyName("FirstName")] public string FirstName { get; set; }

        [JsonPropertyName("LastName")] public string LastName { get; set; }

        [JsonPropertyName("MiddleName")] public string MiddleName { get; set; }
    }

    public partial class EmployerContact
    {
        [JsonPropertyName("Employer")] public string Employer { get; set; }

        [JsonPropertyName("Address")] public Delivery Address { get; set; }

        [JsonPropertyName("Contacts")] public Contact[] Contacts { get; set; }
    }

    public partial class FacilityLocation
    {
        [JsonPropertyName("Id")] public string Id { get; set; }

        [JsonPropertyName("Address")] public Delivery Address { get; set; }
    }

    public partial class General
    {
        [JsonPropertyName("Name")] public Person Name { get; set; }

        [JsonPropertyName("DateOfBirth")] public DateTimeOffset DateOfBirth { get; set; }

        [JsonPropertyName("Gender")] public string Gender { get; set; }

        [JsonPropertyName("Prefix")] public string Prefix { get; set; }

        [JsonPropertyName("Weight")] public long Weight { get; set; }

        [JsonPropertyName("Height")] public long Height { get; set; }

        [JsonPropertyName("Ssn")] public string Ssn { get; set; }

        [JsonPropertyName("NickName")] public string NickName { get; set; }

        [JsonPropertyName("MaritalStatus")] public string MaritalStatus { get; set; }
    }

    public partial class Location
    {
        [JsonPropertyName("Id")] public string Id { get; set; }

        [JsonPropertyName("Name")] public string Name { get; set; }

        [JsonPropertyName("Npi")] public string Npi { get; set; }
    }

    public partial class MedicalReleaseInfo
    {
        [JsonPropertyName("Name")] public Person Name { get; set; }

        [JsonPropertyName("RelationType")] public string RelationType { get; set; }

        [JsonPropertyName("Email")] public string Email { get; set; }

        [JsonPropertyName("Phone")] public string Phone { get; set; }
    }

    public partial class ResponsibleContact
    {
        [JsonPropertyName("Person")] public Person Person { get; set; }

        [JsonPropertyName("Type")] public string Type { get; set; }

        [JsonPropertyName("Address")] public Delivery Address { get; set; }

        [JsonPropertyName("Contacts")] public Contact[] Contacts { get; set; }
    }

    public partial class SignatureOnFile
    {
        [JsonPropertyName("IsSigned")] public bool IsSigned { get; set; }

        [JsonPropertyName("SignedDate")] public DateTimeOffset SignedDate { get; set; }
    }

    public partial class Status
    {
        [JsonPropertyName("Status")] public string StatusStatus { get; set; }

        [JsonPropertyName("DcDate")] public DateTimeOffset DcDate { get; set; }

        [JsonPropertyName("InactiveStatus")] public string InactiveStatus { get; set; }

        [JsonPropertyName("InactiveStatusText")] public string InactiveStatusText { get; set; }
    }

    public partial class Tag
    {
        [JsonPropertyName("Id")] public string Id { get; set; }

        [JsonPropertyName("Name")] public string Name { get; set; }
    }

    public partial class TaxExemption
    {
        [JsonPropertyName("Enabled")] public bool Enabled { get; set; }

        [JsonPropertyName("Note")] public string Note { get; set; }
    }
     
}
 
