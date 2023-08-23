import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { PatientComponent } from './patient.component';
import { SharedModule } from '../shared/shared.module';
import { PatientListComponent } from './patient-list.component';
import { PatientAddComponent } from './patient-add.component';

@NgModule({
  declarations: [
    PatientComponent,
    PatientListComponent,
    PatientAddComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([
      { path: 'patientList', component:PatientListComponent},
      { path: 'patient/:id',
             component:PatientComponent
      },
      { path: 'patientAdd',
             component:PatientAddComponent
      }
    ]),
    SharedModule
  ]
})
export class PatientModule { }
