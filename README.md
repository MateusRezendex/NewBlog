# ?? Blog API - Módulo 6 (Balta.io)

Este projeto é uma API RESTful para gerenciamento de um blog, desenvolvida com **ASP.NET Core 6**, utilizando **Entity Framework Core**. Ele faz parte do curso de formação em .NET da plataforma [Balta.io](https://balta.io), no qual são aplicadas boas práticas de desenvolvimento backend, autenticação JWT e arquitetura limpa.

---

## ?? Objetivo do Projeto

O principal objetivo deste projeto é ensinar, na prática, como criar uma API moderna e segura com .NET, organizando o código de forma modular e utilizando as principais bibliotecas e recursos do ecossistema .NET. Nele, você aprenderá:

- Como construir endpoints RESTful com ASP.NET Core.
- Como realizar **CRUD completo** para entidades como `Category`, `Tag` e `Post`.
- Como proteger rotas com **autenticação JWT**.
- Como aplicar **validações com FluentValidation**.
- Como usar **EF Core para persistência**.


---

## ?? Tecnologias e Ferramentas

- [ASP.NET Core 6](https://learn.microsoft.com/en-us/aspnet/core/)
- [Entity Framework Core](https://docs.microsoft.com/ef/core/)
- [FluentValidation](https://docs.fluentvalidation.net/)
- [JWT Authentication](https://jwt.io/)
- [SQL Server](https://www.microsoft.com/sql-server)

---

## ?? Funcionalidades

### Autenticação e Controle de Acesso
- Login via email e senha.
- Geração de **JWT Token**.
- Acesso controlado com `[Authorize]`.

### CRUD Completo
- **Categorias**:
  - Criar, listar, editar e excluir categorias.
- **Tags**:
  - CRUD completo para marcação de posts.
- **Posts**:
  - Criar artigos com título, slug, corpo, autor, tags e categoria.
  - Publicar e recuperar posts com filtros.

### Outros recursos
- Validações automáticas com `FluentValidation`.
- Tratamento de erros e mensagens customizadas.
- Organização do projeto em camadas claras (Controllers, Repositories, Models, Services).
- Injeção de dependência com o `builder.Services`.

---



