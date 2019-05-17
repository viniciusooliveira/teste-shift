import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AppConfig } from 'src/app/app.config';
import { Exame } from '../_models/exame';

@Injectable({
  providedIn: 'root'
})
export class ExameService {

  constructor(private http: HttpClient) { }


  get() {
    return this.http.get<Exame[]>(`${AppConfig.settings.apiUrl}/exame`);
  }
}
