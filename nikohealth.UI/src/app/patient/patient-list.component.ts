import { Component, OnDestroy, OnInit } from '@angular/core';
import { PatientService } from './patient.service';
import { Subscription } from 'rxjs';
import { IPatient } from './ipatient';

@Component({
  selector: 'niko-patient-list',
  templateUrl: './patient-list.component.html',
  styleUrls: ['./patient-list.component.css']
})
export class PatientListComponent implements OnInit, OnDestroy   {
  constructor(private patientservice: PatientService) { }

  pageTitle = 'Patients';
  errorMessage = '';
  sub!: Subscription;
  patients: IPatient[] =[];

   ngOnInit(): void {
     this.sub = this.patientservice.getPatients().subscribe({
      next: patients => {
        this.patients = patients;
      },
      error: err => this.errorMessage = err
    });
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  } 
  onAdd(): void {
    console.log('Not yet implemented');
  }
}
