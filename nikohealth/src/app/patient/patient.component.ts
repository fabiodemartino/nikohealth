import { Component, OnDestroy, OnInit } from '@angular/core';
import { PatientService } from './patient.service';
import { IPatient } from './ipatient';
import { Subscription } from 'rxjs';

@Component({
  selector: 'niko-patient',
  templateUrl: './patient.component.html',
  styleUrls: ['./patient.component.css']
})
export class PatientComponent implements OnInit, OnDestroy   {
  constructor(private patientservice: PatientService) { }

  pageTitle = 'Patient';
  errorMessage = '';
  sub!: Subscription;
  patient: IPatient[] =[];

   ngOnInit(): void {
    /* this.sub = this.patientservice.getPatient().subscribe({
      next: patient => {
        this.patient = patient;
      },
      error: err => this.errorMessage = err
    }); */
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  } 
}
