📚 LibraryManager.API

Sistema de gerenciamento de biblioteca desenvolvido em C# .NET 10, utilizando ASP.NET Core Web API, Entity Framework Core, SQL Server, Docker e integração com a Open Library API.

O projeto permite o gerenciamento de livros e autores, incluindo cadastro automático de livros através do ISBN, consumindo dados diretamente da Open Library.

A aplicação foi construída utilizando arquitetura em camadas, separando responsabilidades entre Controllers, Services, Repositories e Data, seguindo boas práticas de desenvolvimento backend com .NET.

🚀 Funcionalidades
📖 Livros

✅ Cadastro manual de livros

✅ Cadastro automático por ISBN (Open Library)

✅ Consulta de livros cadastrados

✅ Atualização de livros

✅ Exclusão de livros

✍️ Autores

✅ Cadastro de autores

✅ Consulta de autores

✅ Atualização de autores

✅ Exclusão de autores

⚙️ Infraestrutura

✅ SQL Server

✅ Entity Framework Core

✅ Injeção de Dependência (Dependency Injection)

✅ Swagger / OpenAPI

✅ Docker

✅ Arquitetura em Camadas

🏛 Arquitetura
                HTTP Request
                      │
                      ▼
              Controllers
                      │
                      ▼
                Services
                      │
                      ▼
             Repositories
                      │
                      ▼
             Entity Framework
                      │
                      ▼
                 SQL Server
📂 Estrutura do Projeto
LibraryManager.API
│
├── Controllers
│   ├── LivroController.cs
│   └── AutorController.cs
│
├── Data
│   └── LibraryDbContext.cs
│
├── DTOs
│   ├── LivroRequest.cs
│   ├── LivroResponse.cs
│   ├── LivroIsbnRequest.cs
│   ├── AutorRequest.cs
│   └── AutorResponse.cs
│
├── Entities
│   ├── Livro.cs
│   ├── Autor.cs
│   ├── Categoria.cs
│   ├── Usuario.cs
│   └── Emprestimo.cs
│
├── Interfaces
├── Repositories
├── Services
├── Validators
│
├── Program.cs
├── appsettings.json
└── Dockerfile
🔍 Fluxo de Cadastro por ISBN
Usuário
    │
    ▼
Informa ISBN
    │
    ▼
LivroController
    │
    ▼
LivroService
    │
    ▼
OpenLibraryService
    │
    ▼
Open Library API
    │
    ▼
Retorna informações do livro
    │
    ▼
LivroRepository
    │
    ▼
SQL Server
🔍 Fluxo de Cadastro de Autor
Usuário
    │
    ▼
AutorController
    │
    ▼
AutorService
    │
    ▼
AutorRepository
    │
    ▼
Entity Framework
    │
    ▼
SQL Server
🛠 Tecnologias
C#
.NET 10
ASP.NET Core Web API
Entity Framework Core
SQL Server
Docker
Swagger / OpenAPI
Open Library API
Dependency Injection
REST API
📖 Endpoints
📚 Livros
Método	Endpoint	Descrição
GET	/api/livro	Lista todos os livros
GET	/api/livro/{id}	Busca livro por ID
POST	/api/livro	Cadastra livro manualmente
POST	/api/livro/isbn	Cadastra livro por ISBN
PUT	/api/livro/{id}	Atualiza livro
DELETE	/api/livro/{id}	Remove livro
✍️ Autores
Método	Endpoint	Descrição
GET	/api/autor	Lista todos os autores
GET	/api/autor/{id}	Busca autor por ID
POST	/api/autor	Cadastra autor
PUT	/api/autor/{id}	Atualiza autor
DELETE	/api/autor/{id}	Remove autor
⚙️ Como executar
Clonar o projeto
git clone https://github.com/nickpedro/LibraryManager.git
Entrar na pasta
cd LibraryManagerAPI
Restaurar dependências
dotnet restore
Executar aplicação
dotnet run

Acesse:

http://localhost:5251/swagger
📌 Roadmap
Concluído
✅ CRUD de Livros
✅ Integração Open Library por ISBN
✅ CRUD de Autores
✅ SQL Server
✅ Entity Framework Core
✅ Repository Pattern
✅ Services
✅ DTOs
✅ Swagger
✅ Docker
Próximas Implementações
🔄 CRUD de Categorias
🔄 CRUD de Usuários
🔄 Sistema de Empréstimos
🔄 Relacionamento Livro ↔ Categoria
🔄 JWT Authentication
🔄 Filtros e Paginação
🔄 RabbitMQ
🔄 Testes Unitários
👨‍💻 Autor

Pedro Henrique

Projeto desenvolvido para estudos de:

Arquitetura em Camadas
ASP.NET Core Web API
Entity Framework Core
SQL Server
Integração com APIs externas
Boas práticas de desenvolvimento backend
Padrões Repository e Service
📊 Status Atual
Livros       ✅ Concluído
Autores      ✅ Concluído
Categorias   ⏳ Em desenvolvimento
Usuários     ⏳ Planejado
Empréstimos  ⏳ Planejado
