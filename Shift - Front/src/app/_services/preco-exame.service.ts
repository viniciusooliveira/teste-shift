import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AppConfig } from 'src/app/app.config';
import { Convenio } from '../_models/convenio';
import { PrecoExame } from '../_models/preco-exame';

@Injectable({
  providedIn: 'root'
})
export class PrecoExameService {

  constructor(private http: HttpClient) { }


  get(idConvenio, idExame) {
    return this.http.get<PrecoExame>(`${AppConfig.settings.apiUrl}/precoexame`, {
        params: {
            idConvenio,
            idExame
        }
    });
  }
}
