import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { error } from 'protractor';

@Component({
  selector: 'app-persons',
  templateUrl: './persons.component.html',
  styleUrls: ['./persons.component.css']
})
export class PersonsComponent implements OnInit {
  persons: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getPersons();
  }
  getPersons(){
    this.http.get('http://localhost:5000/api/values').subscribe(Response => {
      this.persons = Response;

    },error =>{
      console.log(error);
    });
  }

}
