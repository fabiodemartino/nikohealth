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

   

  onSave(formPatient:any) {
   let patientId = uuid()
  

   /* newPatient.General.DateOfBirth = originalPatient.dob;
   newPatient.General.Name.FirstName = originalPatient.firstName;
   newPatient.General.Name.FirstName = originalPatient.LastName;
   newPatient.Id = patientId; */
   
  /*  this.patientservice.addPatient(newPatient)
        .subscribe((response: any) => {
        console.log(response)
      })  */
    
     this.router.navigate(['patientList']);
  }


}

