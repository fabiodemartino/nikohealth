import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { PatientComponent } from './patient.component';
import { SharedModule } from '../shared/shared.module';
import { PatientListComponent } from './patient-list.component';

@NgModule({
  declarations: [
    PatientComponent,
    PatientListComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([
      { path: 'patientList', component:PatientListComponent},
      { path: 'patient/:id',
             component:PatientComponent
      }
    ]),
    SharedModule
  ]
})
export class PatientModule { }
