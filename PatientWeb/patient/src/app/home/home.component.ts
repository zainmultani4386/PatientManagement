
import { Component, OnInit } from '@angular/core';

import { PatientService } from '../patient.service'
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  providers: [PatientService]
})
export class HomeComponent implements OnInit {

  constructor(private patientService: PatientService) { }

  ngOnInit() {
  }

}
