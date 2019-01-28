import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

export class HttpService {
  apiURL: string = 'http://www.localhost.com/api/';

  constructor(private httpClient: HttpClient) { }

}
