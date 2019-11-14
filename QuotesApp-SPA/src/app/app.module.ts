import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatSelectModule} from '@angular/material/select';
import {MatAutocompleteModule} from '@angular/material/autocomplete';
import { MatInputModule } from '@angular/material';
import { CommonModule } from '@angular/common';
import {MatRadioModule} from '@angular/material/radio';
import { BsDropdownModule, BsDatepickerModule } from 'ngx-bootstrap';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './routes';
import { JwtModule } from '@auth0/angular-jwt';

import { AppComponent } from './app.component';
import { CustomerComponent } from './customer/customer.component';
import { QuotesComponent } from './quotes/quotes.component';
import { QuoteComponent } from './quote/quote.component';
import { NavComponent } from './nav/nav.component';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';

import { AuthService } from './services/auth.service';
import { ErrorInterceptorProvider } from './services/error.interceptor';
import { QuoteService } from './services/quote.service';

export function tokenGetter() {
  return localStorage.getItem('token');
}

@NgModule({
   declarations: [
      AppComponent,
      CustomerComponent,
      QuotesComponent,
      QuoteComponent,
      NavComponent,
      HomeComponent,
      RegisterComponent,
   ],
   imports: [
      AppRoutingModule,
      BrowserModule,
      HttpClientModule,
      BrowserAnimationsModule,
      FormsModule,
      ReactiveFormsModule,
      BsDropdownModule.forRoot(),
      BsDatepickerModule.forRoot(),
      MatSelectModule,
      MatFormFieldModule,
      MatAutocompleteModule,
      MatInputModule,
      CommonModule,
      MatRadioModule,
      JwtModule.forRoot({
        config: {
          tokenGetter: tokenGetter,
          whitelistedDomains: ['localhost:5000'],
          blacklistedRoutes: ['localhost:5000/api/auth']
        }
      })
   ],
   providers: [
      AuthService,
      QuoteService,
      ErrorInterceptorProvider
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
