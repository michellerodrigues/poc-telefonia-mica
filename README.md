# poc-telefonia-mica
poc-telefonia-mica


API para cadastro
API para atualização, 
API para remoção 
API para para listagem de planos de telefonia. 
  Api de buscas por tipo e DDD
  Api de buscas por operadora e DDD
  Api de buscas por plano específico (sempre utilizando também o DDD)

Características dos planos: Código do plano, Minutos, Franquia de internet, Valor, Tipo (Controle, Pós, Pré) e Operadora
Obs.: Cada plano pode estar ou não disponível para um ou mais DDDs.

========
Para utilizar o projeto: faça o download, em seguida, ajuste o arquivo appSettings para o servidor correto de banco de dados. O banco será criado e populado automaticamente.

Os testes unitários foram desenvolvidos com Moq, NUnit e AutoFixture;
Banco de Dados SqlServer com EntityFramework (FluetApi), CodeFirst.
No Projeto consta também captura e tratamento global de Exceção com Middleware, Injeção de dependência nativa do dotnet core.
Versão dotnet core 3.1.

