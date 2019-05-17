import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AppConfig } from 'src/app/app.config';
import { Convenio } from '../_models/convenio';

@Injectable({
  providedIn: 'root'
})
export class ConvenioService {

  constructor(private http: HttpClient) { }


  get() {
    return this.http.get<Convenio[]>(`${AppConfig.settings.apiUrl}/convenio`);
  }
}
