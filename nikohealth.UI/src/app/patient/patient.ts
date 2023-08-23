export interface Patient {
      Id:                 string;
      DisplayId:          string;
      SYN_PATID:          string;
      General:            General;
      Status:             Status;
      Addresses:          Addresses;
      Contacts:           Contacts;
      SignatureOnFile:    SignatureOnFile;
      EmergencyContact:   EmergencyContact;
      EmployerContact:    EmployerContact;
      ResponsibleContact: ResponsibleContact;
      MedicalReleaseInfo: MedicalReleaseInfo[];
      Location:           Location;
      FacilityLocation:   FacilityLocation;
      Tags:               Tag[];
      TaxExemption:       TaxExemption;
    }
    
    export interface Addresses {
      Patient:                         Delivery;
      Delivery:                        Delivery;
      SkipPatientAddressVerification:  boolean;
      SkipDeliveryAddressVerification: boolean;
    }
    
    export interface Delivery {
      AddressLine:  string;
      AddressLine2: string;
      City:         string;
      State:        string;
      Zip:          string;
    }
    
    export interface Contacts {
      Contacts:             Contact[];
      PreferredContactType: string;
      PreferredCallTime:    string;
    }
    
    export interface Contact {
      Type:  string;
      Value: string;
      Ext:   string;
    }
    
    export interface EmergencyContact {
      Person:            Person;
      Relationship:      string;
      RelationshipOther: string;
      Address:           Delivery;
      Contacts:          Contact[];
    }
    
    export interface Person {
      FirstName:  string;
      LastName:   string;
      MiddleName: string;
    }
    
    export interface EmployerContact {
      Employer: string;
      Address:  Delivery;
      Contacts: Contact[];
    }
    
    export interface FacilityLocation {
      Id:      string;
      Address: Delivery;
    }
    
    export interface General {
      Name:          Person;
      DateOfBirth:   string;
      Gender:        string;
      Prefix:        string;
      Weight:        number;
      Height:        number;
      Ssn:           string;
      NickName:      string;
      MaritalStatus: string;
    }
    
    export interface Location {
      Id:   string;
      Name: string;
      Npi:  string;
    }
    
    export interface MedicalReleaseInfo {
      Name:         Person;
      RelationType: string;
      Email:        string;
      Phone:        string;
    }
    
    export interface ResponsibleContact {
      Person:   Person;
      Type:     string;
      Address:  Delivery;
      Contacts: Contact[];
    }
    
    export interface SignatureOnFile {
      IsSigned:   boolean;
      SignedDate: string;
    }
    
    export interface Status {
      Status:             string;
      DcDate:             string;
      InactiveStatus:     string;
      InactiveStatusText: string;
    }
    
    export interface Tag {
      Id:   string;
      Name: string;
    }
    
    export interface TaxExemption {
      Enabled: boolean;
      Note:    string;
    }