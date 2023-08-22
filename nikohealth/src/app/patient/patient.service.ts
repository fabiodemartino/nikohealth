import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { Observable, catchError, tap, throwError, map } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { IPatient } from './ipatient';

@Injectable({
  providedIn: 'root'
})
export class PatientService {
  private nikoUrl = environment.apiUrl;
  constructor(private http: HttpClient) { }

  getPatients(): Observable<IPatient[]> {
    return this.http.get<IPatient[]>(this.nikoUrl)
      .pipe(tap(data => console.log('All:', JSON.stringify(data))),
        catchError(this.handleError));
  }
  getPatient(id: string): Observable<IPatient | undefined>{
    return this.getPatients().pipe(map((patient: IPatient[]
      ) => patient.find(e=>e.Id == id)));
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