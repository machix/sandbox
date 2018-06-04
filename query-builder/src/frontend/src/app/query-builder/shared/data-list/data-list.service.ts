import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';

/**
 * This class provides the DataListService service with methods to read names and add names.
 */
@Injectable()
export class DataListService {

  /**
   * Creates a new DataListService with the injected HttpClient.
   * @param {HttpClient} httpClient - The injected HttpClient.
   * @constructor
   */
  constructor(protected httpClient: HttpClient) {}

  /**
   * Returns an Observable for the HTTP GET request for the JSON resource.
   * @return {string[]} The Observable for the HTTP request.
   */
  get(urlAddress: string): Observable<string[]> {
    return this.httpClient.get<string[]>(urlAddress);
  }
}

