import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Paciente } from '../_models/paciente';
import { AppConfig } from 'src/app/app.config';

@Injectable({
  providedIn: 'root'
})
export class PacienteService {

  constructor(private http: HttpClient) { }


  get() {
    return this.http.get<Paciente[]>(`${AppConfig.settings.apiUrl}/paciente`);
  }
}
