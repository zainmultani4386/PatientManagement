
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms'
import { HttpModule } from '@angular/http'
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { PatientListComponent } from './patient-list/patient-list.component';
import { PatientAddUpdateComponent } from './patient-add-update/patient-add-update.component';
//import { PatientService } from './patient.service';
import { ToastrModule } from 'ngx-toastr';
import { HttpClientModule } from '@angular/common/http';

const appRoutes: Routes = [
  { path: '', component: HomeComponent }

];
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    PatientAddUpdateComponent,
    PatientListComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    FormsModule,
    ToastrModule.forRoot(),
    RouterModule.forRoot(appRoutes),
 
  ],
 
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {

}
