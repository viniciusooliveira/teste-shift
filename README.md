# Teste de aptidão Shift

## Getting Started

Essas instruções vão lhe mostrar como copiar o projeto e executá-lo em seu ambiente de desenvolvimento local.

### Web Service

Para executar o Web Service, será necessário verificar a string de conexão com o banco (MySQL) e executar o comando para criação automática do banco, incluíndo dados fictícios para testes.

Após abrir o projeto utilizando o Visual Studio, navegue até o arquivo /Infra/Data/Teste.Infra.Data/Context/TesteContext.cs e edite o conteúdo da linha 26.

Configurada a string de conexão, deve-se abrir o Console do Gerenciador de Pacotes e executar o seguinte comando para criar a extrutura do banco de dados:
`Update-Database`

### Front End

Para executar o Front End, devemos restaurar os pacotes do NPM e configurar o Proxy para a API.

Edite a linha 4 do arquivo /proxy.config.json com a ulr/porta em que o Web Service está sendo executado.

Pelo terminal, execute os seguintes comandos:

`npm install`
`npm start`

Após concluir o download de todos os pacotes e compilar o projeto, seu navegador deve abrir automaticamente.
