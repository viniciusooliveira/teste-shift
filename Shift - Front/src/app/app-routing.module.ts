import { ImprimirConfirmacaoClienteComponent } from './paginas/imprimir-confirmacao-cliente/imprimir-confirmacao-cliente.component';
import { ListOrdemServicoComponent } from './paginas/list-ordem-servico/list-ordem-servico.component';
import { FormOrdemServicoComponent } from './paginas/form-ordem-servico/form-ordem-servico.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {AutocompleteLibModule} from 'angular-ng-autocomplete';

const routes: Routes = [
  {path: '', component: ListOrdemServicoComponent},
  {path: 'nova-ordem-servico', component: FormOrdemServicoComponent},
  {path: 'imprimir-os/:id', component: ImprimirConfirmacaoClienteComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes), AutocompleteLibModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
