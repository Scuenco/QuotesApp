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

import { AppComponent } from './app.component';
import { CustomerComponent } from './customer/customer.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { QuoteComponent } from './quote/quote.component';


@NgModule({
   declarations: [
      AppComponent,
      CustomerComponent,
      QuoteComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      BrowserAnimationsModule,
      MatSelectModule,
      MatFormFieldModule,
      FormsModule,
      ReactiveFormsModule,
      MatAutocompleteModule,
      MatInputModule,
      CommonModule,
      MatRadioModule
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
