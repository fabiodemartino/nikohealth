import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from "@angular/common/http";
import { Observable, catchError, tap, throwError, map } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { Patient } from './patient';

@Injectable({
  providedIn: 'root'
})
export class PatientService {
  private patientUrl = environment.apiUrl + 'patient';
  constructor(private http: HttpClient) { }

  getPatients(): Observable<Patient[]> {
    return this.http.get<Patient[]>(this.patientUrl)
      .pipe(tap(data => console.log('All:', JSON.stringify(data))),
        catchError(this.handleError));
  }
  getPatient(id: string): Observable<Patient | undefined>{
    return this.getPatients().pipe(map((patient: Patient[]
      ) => patient.find(e=>e.Id == id)));
  }
  addPatient(patientData: Patient, id: string): Observable<any>{
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    const body=JSON.stringify(patientData);
    return this.http.post(this.patientUrl + `?patientId=${id}` , body,{ headers })
  }
  private handleError(err: HttpErrorResponse): Observable<never> {
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
      errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }
    console.error(errorMessage);
    return throwError(() => errorMessage);
  }
}