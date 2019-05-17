import {Paciente} from './paciente';
import {Medico} from './medico';
import {PostoColeta} from './posto-coleta';
import {Convenio} from './convenio';
import {Exame} from './exame';

export class OrdemServico {
    id = 0;
    data = '';
    idPaciente = 0;
    paciente: Paciente = null;
    idConvenio = 0;
    convenio: Convenio = null;
    idPostoColeta = 0;
    postoColeta: PostoColeta = null;
    idMedico = 0;
    medico: Medico = null;
    exames: OrdemServicoExame[] = [];
}

export class OrdemServicoExame {
    id = 0;
    idOrdemServico = 0;
    ordemServico: OrdemServico = null;
    idExame = 0;
    exame: Exame = null;
    entregaResultado = '';
    preco = '';
    dataEntrega = '';
    precoString = '';


    horario = { // Propriedade não existente na API, utilizada apenas para facilitar a troca de informações
        hour: '12',
        minute: '00'
    };
}
