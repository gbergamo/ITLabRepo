import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Person } from '../model/person';
import { Observable } from 'rxjs/Observable';

@Injectable()

export class PersonConsumer {
  apiURL: string = 'http://localhost:59714/api';

  constructor(private httpClient: HttpClient) { }

  getPerson(): Observable<Person[]> {
    return this.httpClient.get<Person[]>(`${this.apiURL}/person`);
  }

}
