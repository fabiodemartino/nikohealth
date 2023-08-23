import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { PatientService } from './patient.service';
import { IPatient } from './ipatient';
import { v4 as uuid } from 'uuid';

@Component({
  selector: 'niko-patient-edit',
  templateUrl: './patient-edit.component.html',
  styleUrls: ['./patient-edit.component.css']
})
export class PatientEditComponent {
  constructor(private router: Router, private patientservice: PatientService) { }
  pageTitle = 'Add Patient';
  errorMessage = '';
  patient: IPatient | undefined;

  onSave(originalPatient: IPatient) {
    let patientId = uuid()


    let patient = {
      Id: patientId,
      FirstName: originalPatient.General.Name.FirstName,
      LastName: originalPatient.General.Name.LastName,

    }

  /*   this.patientservice.addPatient(patient)
      .subscribe((response: any) => {
        console.log(response)
      }) */
    this.router.navigate(['patientList']);
  }


}

