import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions,  RequestMethod } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';
//import { Observable } from 'rxjs/Rx';
import { Patient } from './shared/patient.model'


@Injectable()
export class PatientService {

 
  selectedPatient: Patient;
  patientList: Patient[];
  constructor(private http: Http) { }

  postPatient(ptn: Patient) {
   
    console.log(ptn);
    var body = JSON.stringify(ptn);
    var headerOptions = new Headers({ 'Content-Type': 'application/json' });
    var requestOptions = new RequestOptions({ method: RequestMethod.Post, headers: headerOptions });
    return this.http.post('http://localhost:55206/api/PatientDetails/',

      body, requestOptions).map(x => x.json());
  }

  putPatient(id, ptn) {
    var body = JSON.stringify(ptn);
    var headerOptions = new Headers({ 'Content-Type': 'application/json' });
    var requestOptions = new RequestOptions({ method: RequestMethod.Put, headers: headerOptions });
    return this.http.put('http://localhost:55206/api/PatientDetails/' + id,
      body,
      requestOptions).map(res => res.json());
  }
  getPatientList() {
    this.http.get('http://localhost:55206/api/PatientDetails')
      .map((data: Response) => {
        return data.json() as Patient[];
      }).toPromise().then(x => {
        this.patientList = x;
      })
  }
  deletePatient(id: number) {
    return this.http.delete('http://localhost:55206/api/patientdetails/' + id).map(res => res.json());
  }

 
}
