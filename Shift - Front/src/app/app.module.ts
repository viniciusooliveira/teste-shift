import { BrowserModule } from '@angular/platform-browser';
import { NgModule, APP_INITIALIZER } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormOrdemServicoComponent } from './paginas/form-ordem-servico/form-ordem-servico.component';
import { ListOrdemServicoComponent } from './paginas/list-ordem-servico/list-ordem-servico.component';
import { AppConfig } from './app.config';
import { AutocompleteLibModule } from 'angular-ng-autocomplete';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ToastrModule } from 'ngx-toastr';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ImprimirConfirmacaoClienteComponent } from './paginas/imprimir-confirmacao-cliente/imprimir-confirmacao-cliente.component';

export function initializeApp(appConfig: AppConfig) {
  return () => appConfig.load();
}

@NgModule({
  declarations: [
    AppComponent,
    FormOrdemServicoComponent,
    ListOrdemServicoComponent,
    ImprimirConfirmacaoClienteComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    AutocompleteLibModule,
    HttpClientModule,
    NgbModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      timeOut: 5000
    })
  ],
  providers: [
    AppConfig,
    AppConfig,
    {
      provide: APP_INITIALIZER,
      useFactory: initializeApp,
      deps: [AppConfig], multi: true
    },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
