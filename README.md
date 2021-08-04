# Projeto Final Aceleração C#

## Objetivo
Em projetos modernos é cada vez mais comum o uso de arquiteturas baseadas em serviços ou microsserviços. Nestes ambientes complexos, erros podem surgir em diferentes camadas da aplicação (backend, frontend, mobile, desktop) e mesmo em serviços distintos. Desta forma, é muito importante que os desenvolvedores possam centralizar todos os registros de erros em um local, de onde podem monitorar e tomar decisões mais acertadas. Neste projeto vamos implementar um sistema para centralizar registros de erros de aplicações.


## API
A API possui um endpoint que será usado para gravar os logs de erro em um banco de dados relacional
O acesso à API só é permitido mediante um token de autenticação válido.

## Tecnologias Utilizadas:

* .NetCore 5.0
* Entity Framework Core
* AutoMapper
* JWT
* SwashBuckle

## Utilização

Para utilizar a API, basta fazer o clone do projeto localmente e fazer o build da aplicação com o Visual Studio. Ou com
o Visual Studio Code utilizar o comando via CLI dotnet run.
O Projeto estará disponível em localhost:5000

## Banco de Dados

Atentar para a conexão com o Banco que deverá ser alterada. Além de que devem ser feitas as migrations.
