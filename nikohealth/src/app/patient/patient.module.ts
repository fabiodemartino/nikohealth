import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { PatientComponent } from './patient.component';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [
    PatientComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([
      { path: 'patients', component:PatientComponent},
    
      { path: 'patient/:id',
             component:PatientComponent
      }
    ]),
    SharedModule
  ]
})
export class PatientModule { }
