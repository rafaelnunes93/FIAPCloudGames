🎮 FIAP Cloud Games - Tech Challenge Fase 1
Bem-vindo ao repositório do projeto FIAP Cloud Games! Este é o MVP da fase 1 do Tech Challenge, cujo objetivo é desenvolver uma API REST em .NET 8 para cadastro de usuários e biblioteca de jogos adquiridos.

Projeto desenvolvido como parte da Fase 1 do curso na FIAP.

🚀 Objetivo
Criar um sistema de base para a plataforma FIAP Cloud Games (FCG), focado no cadastro e autenticação de usuários, e no gerenciamento de biblioteca de jogos adquiridos. Esta API servirá de fundação para futuras funcionalidades como matchmaking e gestão de servidores de jogos.

🔧 Tecnologias Utilizadas
.NET 8

Entity Framework Core

PostgreSQL

Swagger (OpenAPI)

JWT para autenticação

xUnit para testes unitários

⚙️ Funcionalidades
Cadastro de usuários

Nome, email e senha com validação

Senha segura (mínimo 8 caracteres, números, letras e caracteres especiais)

Autenticação e autorização

Login com token JWT

Perfis: Usuário e Administrador

Gestão de jogos

CRUD de jogos (somente para administradores)

Middleware

Tratamento de erros e logs estruturados

Documentação

Endpoints documentados via Swagger

📦 Estrutura do Projeto
Domain – Entidades e regras de negócio (DDD)

Application – Casos de uso e interfaces

Infrastructure – Configurações de persistência e repositórios

API – Endpoints REST com controllers

🧪 Testes
Testes unitários com xUnit

Aplicação de TDD em módulos principais

📄 Entregáveis
✅ Código-fonte com arquitetura DDD

✅ API REST funcional com autenticação

✅ Testes unitários implementados

✅ Swagger configurado

✅ Documentação DDD (Event Storming, diagramas)

✅ Vídeo demonstrativo do projeto
