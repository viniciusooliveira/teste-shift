import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AppConfig } from 'src/app/app.config';
import { Convenio } from '../_models/convenio';
import { OrdemServico } from '../_models/ordem-servico';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class OrdemServicoService {

  constructor(private http: HttpClient) { }


  post(os: OrdemServico) {
    return this.http.post(`${AppConfig.settings.apiUrl}/ordemservico`, os);
  }

  get(id: number): Observable<OrdemServico> {
    return this.http.get<OrdemServico>(`${AppConfig.settings.apiUrl}/ordemservico/${id}`);
  }

  getAll(): Observable<OrdemServico[]> {
    return this.http.get<OrdemServico[]>(`${AppConfig.settings.apiUrl}/ordemservico`);
  }
}
