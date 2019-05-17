import { OrdemServicoService } from './../../_services/ordem-service.service';
import { PrecoExameService } from './../../_services/preco-exame.service';
import { ConvenioService } from './../../_services/convenio.service';
import { PostoColetaService } from './../../_services/posto-coleta.service';
import { MedicoService } from './../../_services/medico.service';
import { PacienteService } from './../../_services/paciente.service';
import { Paciente } from './../../_models/paciente';
import { Component, OnInit } from '@angular/core';
import { OrdemServico, OrdemServicoExame } from 'src/app/_models/ordem-servico';
import { Medico } from 'src/app/_models/medico';
import { PostoColeta } from 'src/app/_models/posto-coleta';
import { Convenio } from 'src/app/_models/convenio';
import { ExameService } from 'src/app/_services/exame.service';
import { Exame } from 'src/app/_models/exame';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';

@Component({
  selector: 'app-form-ordem-servico',
  templateUrl: './form-ordem-servico.component.html',
  styleUrls: ['./form-ordem-servico.component.scss']
})
export class FormOrdemServicoComponent implements OnInit {

  titulo = 'Nova Ordem de Serviço';
  mensagem: string;


  listaPacientes: Paciente[];
  listaMedicos: Medico[];
  listaPostos: PostoColeta[];
  listaConvenios: Convenio[];
  listaExames: Exame[];

  os = new OrdemServico();

  constructor(
    private pacienteService: PacienteService,
    private medicoService: MedicoService,
    private postoColetaService: PostoColetaService,
    private convenioService: ConvenioService,
    private exameService: ExameService,
    private precoExameService: PrecoExameService,
    private ordemServicoService: OrdemServicoService,
    private toastr: ToastrService,
    private router: Router,
    ) {
    }

  ngOnInit() {
    this.pacienteService.get().subscribe(x => {this.listaPacientes = x; });
    this.medicoService.get().subscribe(x => {this.listaMedicos = x; });
    this.postoColetaService.get().subscribe(x => {this.listaPostos = x; });
    this.convenioService.get().subscribe(x => {this.listaConvenios = x; });
    this.exameService.get().subscribe(x => {this.listaExames = x; });
  }

  selecionarPaciente = (valor: Paciente) => {
    if (valor) {
      this.os.idPaciente = valor.id;
    }
  }

  selecionarMedico = (valor: Medico) => {
    if (valor) {
      this.os.idMedico = valor.id;
    }
  }

  selecionarPostoColeta = (valor: PostoColeta) => {
    if (valor) {
      this.os.idPostoColeta = valor.id;
    }
  }

  selecionarConvenio = (valor: Convenio) => {
    if (valor) {
      this.os.idConvenio = valor.id;
      if (this.os.exames.length > 0) {
        for (let exame of this.os.exames) {
          this.precoExameService.get(this.os.idConvenio, exame.idExame).subscribe(x => {
            if (x && x.id > 0) {
              exame.preco = x.preco;
            }
          });
        }
      }
    }
  }

  selecionarExame = (valor: OrdemServicoExame, index: number) => {
    if (valor && this.os.exames) {
      this.os.exames[index].idExame = valor.id;
      this.precoExameService.get(this.os.idConvenio, valor.id).subscribe(x => {
        if (x && x.id > 0) {
          this.os.exames[index].preco = x.preco;
        }
      });
    }
  }

  alterarHorario = (valor: any, index: number) => {
    if (valor && this.os.exames) {
      this.os.exames[index].entregaResultado = `${valor.hour}:${valor.minute}`;
      this.precoExameService.get(this.os.idConvenio, valor.id).subscribe(x => {
        if (x && x.id > 0) {
          this.os.exames[index].preco = x.preco;
        }
      });
    }
  }

  adicionarExame = () => {
    this.os.exames.push(new OrdemServicoExame());
  }

  removerExame = (index) => {
    this.os.exames.splice(index, 1);
  }

  enviar = () => {
    this.os.exames = this.os.exames.map(e => {
      e.preco = e.preco.replace(',', '.');
      return e;
    });
    this.ordemServicoService.post(this.os).subscribe(x => {
      this.toastr.success(`Ordem de Serviço #${x} criada com sucesso!`).onHidden.subscribe(e => {
        window.open(`/imprimir-os/${x}`);
        this.router.navigate(['/']);
      });
    },
    error => {
      console.log(error.error.errors);
      if (error && error.error && error.error.errors && error.error.errors.length > 0) {
        for (const erro of error.error.errors) {
          this.toastr.error(erro.errorMessage);
        }
      } else {
        this.toastr.error('Erro ao salvar Ordem de Serviço.');
      }
    });
  }

}
