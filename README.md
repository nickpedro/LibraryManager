# 📚 LibraryManager.API

Sistema de gerenciamento de biblioteca desenvolvido em **C# .NET 10**, utilizando **ASP.NET Core Web API**, **Entity Framework Core**, **SQL Server**, **Docker** e integração com a **Open Library API**.

O projeto permite o gerenciamento completo de livros, além do cadastro automático através do **ISBN**, consumindo dados diretamente da Open Library.

A aplicação foi construída utilizando **arquitetura em camadas**, separando responsabilidades entre **Controllers, Services, Repositories e Data**, seguindo boas práticas de desenvolvimento backend com .NET.

---

# 🚀 Funcionalidades

🔹 Cadastro manual de livros

🔹 Cadastro automático por ISBN (Open Library)

🔹 Consulta de livros cadastrados

🔹 Atualização de livros

🔹 Exclusão de livros

🔹 Persistência utilizando SQL Server

🔹 Entity Framework Core

🔹 Injeção de Dependência (Dependency Injection)

🔹 Documentação automática com Swagger

🔹 Docker para banco de dados

🔹 Arquitetura em camadas (Controller → Service → Repository)

---

# 🏛 Arquitetura

O projeto foi estruturado seguindo uma arquitetura em camadas para facilitar manutenção, escalabilidade e organização do código.

```text
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
```

---

# 📂 Estrutura do Projeto

```text
LibraryManager.API
│
├── Controllers
├── Data
├── DTOs
├── Entities
├── Interfaces
├── Repositories
├── Services
├── Validators
│
├── Program.cs
├── appsettings.json
└── Dockerfile
```

---

# 🔍 Fluxo de Cadastro por ISBN

```text
Usuário
    │
    ▼
Informa ISBN
    │
    ▼
Controller
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
Repository
    │
    ▼
SQL Server
```

---

# 🛠 Tecnologias

- C#
- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Docker
- Swagger / OpenAPI
- Open Library API
- Dependency Injection

---

# 📖 Endpoints

| Método | Endpoint | Descrição |
|---------|----------|-----------|
| GET | `/api/livros` | Lista todos os livros |
| GET | `/api/livros/{id}` | Busca livro por ID |
| POST | `/api/livros` | Cadastra um livro manualmente |
| POST | `/api/livros/isbn` | Cadastra livro através do ISBN |
| PUT | `/api/livros/{id}` | Atualiza um livro |
| DELETE | `/api/livros/{id}` | Remove um livro |

---

# ⚙️ Como executar

## Clonar o projeto

```bash
git clone https://github.com/SEU-USUARIO/LibraryManager.API.git
```

## Entrar na pasta

```bash
cd LibraryManager.API
```

## Restaurar pacotes

```bash
dotnet restore
```

## Executar

```bash
dotnet run
```

A documentação estará disponível em:

```
https://localhost:xxxx/swagger
```

---

# 📌 Próximas Implementações

- ✅ CRUD de Livros
- 🔄 CRUD de Autores
- 🔄 CRUD de Categorias
- 🔄 Sistema de Empréstimos
- 🔄 JWT Authentication
- 🔄 Filtros
- 🔄 RabbitMQ
- 🔄 Testes Unitários

---

# 👨‍💻 Autor

**Pedro Henrique**

Desenvolvido para estudos de arquitetura backend com ASP.NET Core e boas práticas de desenvolvimento.
