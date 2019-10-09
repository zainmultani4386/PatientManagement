
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms'

import { PatientService } from '../patient.service'
import { ToastrService } from 'ngx-toastr'
@Component({
  selector: 'app-patient',
  templateUrl: './patient-add-update.component.html',
  styleUrls: ['./patient-add-update.component.css']
})
export class PatientAddUpdateComponent implements OnInit {

  constructor(private patientService: PatientService, private toastr: ToastrService) { }

  ngOnInit() {
    this.resetForm();
  }
  //reset form
  resetForm(form?: NgForm) {
    if (form != null)
      form.reset();
    this.patientService.selectedPatient = {
      ID:null ,
      pasNumber: null,
      foreName: '',
      surName: '',
      dateOfBirth: '',
      sexCode: '',
      homeTelePhoneNumber: '',
      nokName: '',
      nokRelationshipCode: '',
      nokAddressLine1: '',
      nokAddressLine2: '',
      nokAddressLine3: '',
      nokAddressLine4: '',
      nokPostCode: '',
      GPCode: '',
      GPSurname: '',
      GPInitials: '',
      GPPhone: ''
    }
  }
  //form submit for add update
  onSubmit(form: NgForm) {
    if (form.value.ID == null) {
           
      this.patientService.postPatient(form.value)
        .subscribe(data => {
          this.resetForm(form);
          this.patientService.getPatientList();
          this.toastr.success('New Record Added Succcessfully', 'Patient Register');
        })
    }
    else {
      this.patientService.putPatient(form.value.ID, form.value)
        .subscribe(data => {
         this.resetForm(form);
          this.patientService.getPatientList();
          this.toastr.info('Record Updated Successfully!', 'Patient Register');
        });
    }
  }
}

