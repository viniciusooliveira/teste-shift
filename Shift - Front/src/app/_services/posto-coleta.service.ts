import { PostoColeta } from 'src/app/_models/posto-coleta';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AppConfig } from 'src/app/app.config';

@Injectable({
  providedIn: 'root'
})
export class PostoColetaService {

  constructor(private http: HttpClient) { }


  get() {
    return this.http.get<PostoColeta[]>(`${AppConfig.settings.apiUrl}/postocoleta`);
  }
}
