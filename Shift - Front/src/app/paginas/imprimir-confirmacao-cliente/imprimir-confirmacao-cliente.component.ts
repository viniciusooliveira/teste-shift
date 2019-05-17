import { OrdemServicoService } from './../../_services/ordem-service.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { routerNgProbeToken } from '@angular/router/src/router_module';
import { OrdemServico } from 'src/app/_models/ordem-servico';

@Component({
  selector: 'app-imprimir-confirmacao-cliente',
  templateUrl: './imprimir-confirmacao-cliente.component.html',
  styleUrls: ['./imprimir-confirmacao-cliente.component.scss']
})
export class ImprimirConfirmacaoClienteComponent  implements OnInit {

  os = new OrdemServico();
  imprimir = true;

  constructor(
    private service: OrdemServicoService,
    private route: ActivatedRoute
  ) {
   }

  ngOnInit() {
    this.route.params.subscribe(parametros => {
      if (parametros.id && parametros.id > 0) {
        this.service.get(parametros.id).subscribe(x => {
          this.os = x;
          window.setTimeout(() => {
            window.print();
          }, 500);
        });
      } else {
        this.imprimir = false;
      }
    });
  }

  public exibir(id){
    this.service.get(id).subscribe(x => {
      this.os = x;
    });
  }

}
