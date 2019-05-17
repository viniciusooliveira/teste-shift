import { OrdemServicoExame } from './../../_models/ordem-servico';
import { Component, OnInit } from '@angular/core';
import { OrdemServico } from 'src/app/_models/ordem-servico';
import { OrdemServicoService } from 'src/app/_services/ordem-service.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ImprimirConfirmacaoClienteComponent } from '../imprimir-confirmacao-cliente/imprimir-confirmacao-cliente.component';

@Component({
  selector: 'app-list-ordem-servico',
  templateUrl: './list-ordem-servico.component.html',
  styleUrls: ['./list-ordem-servico.component.scss']
})
export class ListOrdemServicoComponent implements OnInit {

  page = 1;
  pageSize = 10;
  oss: OrdemServico[] = [];
  loading = true;

  constructor(
    private service: OrdemServicoService,
    private modalService: NgbModal
    ) {}

  ngOnInit() {
    this.service.getAll().subscribe(x => {
      this.oss = x;
      this.loading = false;
    });
  }

  detalhesOS = (id) => {
    const modalRef = this.modalService.open(ImprimirConfirmacaoClienteComponent, { size: 'lg' });
    modalRef.componentInstance.exibir(id);
  }

}
