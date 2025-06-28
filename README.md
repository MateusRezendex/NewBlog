# ?? Blog API - M�dulo 6 (Balta.io)

Este projeto � uma API RESTful para gerenciamento de um blog, desenvolvida com **ASP.NET Core 6**, utilizando **Entity Framework Core**. Ele faz parte do curso de forma��o em .NET da plataforma [Balta.io](https://balta.io), no qual s�o aplicadas boas pr�ticas de desenvolvimento backend, autentica��o JWT e arquitetura limpa.

---

## ?? Objetivo do Projeto

O principal objetivo deste projeto � ensinar, na pr�tica, como criar uma API moderna e segura com .NET, organizando o c�digo de forma modular e utilizando as principais bibliotecas e recursos do ecossistema .NET. Nele, voc� aprender�:

- Como construir endpoints RESTful com ASP.NET Core.
- Como realizar **CRUD completo** para entidades como `Category`, `Tag` e `Post`.
- Como proteger rotas com **autentica��o JWT**.
- Como aplicar **valida��es com FluentValidation**.
- Como usar **EF Core para persist�ncia**.


---

## ?? Tecnologias e Ferramentas

- [ASP.NET Core 6](https://learn.microsoft.com/en-us/aspnet/core/)
- [Entity Framework Core](https://docs.microsoft.com/ef/core/)
- [FluentValidation](https://docs.fluentvalidation.net/)
- [JWT Authentication](https://jwt.io/)
- [SQL Server](https://www.microsoft.com/sql-server)

---

## ?? Funcionalidades

### Autentica��o e Controle de Acesso
- Login via email e senha.
- Gera��o de **JWT Token**.
- Acesso controlado com `[Authorize]`.

### CRUD Completo
- **Categorias**:
  - Criar, listar, editar e excluir categorias.
- **Tags**:
  - CRUD completo para marca��o de posts.
- **Posts**:
  - Criar artigos com t�tulo, slug, corpo, autor, tags e categoria.
  - Publicar e recuperar posts com filtros.

### Outros recursos
- Valida��es autom�ticas com `FluentValidation`.
- Tratamento de erros e mensagens customizadas.
- Organiza��o do projeto em camadas claras (Controllers, Repositories, Models, Services).
- Inje��o de depend�ncia com o `builder.Services`.

---



