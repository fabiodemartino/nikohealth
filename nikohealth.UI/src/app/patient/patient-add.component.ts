import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { PatientService } from './patient.service';
import { Patient } from './patient';
import { v4 as uuid } from 'uuid';

@Component({
  selector: 'niko-patient-add',
  templateUrl: './patient-add.component.html',
  styleUrls: ['./patient-add.component.css']
})
export class PatientAddComponent {
  constructor(private router: Router, private patientservice: PatientService) { }
  pageTitle = 'Add Patient';
  errorMessage = '';
  patient: Patient | undefined;

  onSave(patientForm:any) {

  // generate a random patient id
   let patientId = uuid()
   const newPatient = <Patient>{
     Id:patientId,
     SYN_PATID: '',
     General:{
      Name:{
        FirstName: patientForm.firstName,
        LastName: patientForm.lastName,
        MiddleName: ""
      },
      DateOfBirth: patientForm.dob,
      // default model required fields
      Gender: '',
      Prefix: '',
      Weight: 0,
      Height: 0,
      Ssn: "",
      NickName: '',
      MaritalStatus: ''
      }
   };
   
    this.patientservice.addPatient(newPatient,patientId )
        .subscribe({
          error: err => this.errorMessage = err
        });
    
     this.router.navigate(['patientList']);
  }


}

