import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { PatientComponent } from './patient.component';
import { SharedModule } from '../shared/shared.module';
import { PatientListComponent } from './patient-list.component';
import { PatientEditComponent } from './patient-edit.component';

@NgModule({
  declarations: [
    PatientComponent,
    PatientListComponent,
    PatientEditComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([
      { path: 'patientList', component:PatientListComponent},
      { path: 'patient/:id',
             component:PatientComponent
      },
      { path: 'patientEdit',
             component:PatientEditComponent
      }
    ]),
    SharedModule
  ]
})
export class PatientModule { }
