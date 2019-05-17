import {Setor} from './setor';

export interface Exame {
    id: number;
    idSetor: number;
    setor: Setor;
    materialBiologico: string;
    prazo: number;
}
