import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AppConfig } from 'src/app/app.config';
import { Medico } from '../_models/medico';

@Injectable({
  providedIn: 'root'
})
export class MedicoService {

  constructor(private http: HttpClient) { }


  get() {
    return this.http.get<Medico[]>(`${AppConfig.settings.apiUrl}/medico`);
  }
}
