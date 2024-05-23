import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { LoaderComponent } from './loader/loader.component';
import { NgSelectModule } from '@ng-select/ng-select';
import { PaginationComponent } from './pagination/pagination.component';

@NgModule({
  declarations: [
    LoaderComponent,
    PaginationComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    RouterModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgbModule,
    NgSelectModule
  ],
  exports: [
    CommonModule,
    FormsModule,
    RouterModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgbModule,
    LoaderComponent,
    NgSelectModule,
    PaginationComponent
  ]
})
export class SharedModule { }
