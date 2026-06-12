# Agenda de Contatos

![Java Version](https://img.shields.io/badge/Java-17%2B-orange?style=flat-square&logo=java)
![Spring Boot Version](https://img.shields.io/badge/Spring%20Boot-3.x-brightgreen?style=flat-square&logo=spring)
![License](https://img.shields.io/badge/License-MIT-blue?style=flat-square)

Uma API RESTful robusta e escalável desenvolvida para a gestão e organização de contactos. O sistema foi concebido seguindo os padrões mais modernos de arquitetura de software, priorizando a manutenibilidade, a separação de responsabilidades e a eficiência no armazenamento e consulta de dados.

---

## Índice
- [Visão Geral](#-visão-geral)
- [Funcionalidades Principais](#-funcionalidades-principais)
- [Tecnologias Utilizadas](#-tecnologias-utilizadas)
- [Arquitetura e Boas Práticas](#-arquitetura-e-boas-práticas)
- [Como Executar o Projeto](#-como-executar-o-projeto)
  - [Pré-requisitos](#pré-requisitos)
  - [Instalação e Configuração](#instalação-e-configuração)
  - [Execução com Docker](#execução-com-docker)
- [Documentação da API (End-points)](#-documentação-da-api-end-points)
- [Licença](#-licença)

---

## 🔍 Visão Geral

A **Agenda de Contatos** é uma solução de backend estruturada para atuar como o núcleo de aplicações de comunicação ou gestão de relacionamento. O projeto expõe uma API que permite o armazenamento seguro e a manipulação ágil de informações cadastrais, estruturada de forma a suportar integrações com aplicações Web, Mobile ou serviços externos de sincronização.

## ⚙️ Funcionalidades Principais

- **Operações CRUD Completas:** Criação, leitura, atualização e eliminação de contactos de forma isolada e segura.
- **Validação de Dados Estrita:** Garantia de integridade para campos obrigatórios, formatos de e-mail e máscaras de telefone.
- **Pesquisa Dinâmica e Filtragem:** Capacidade de localizar registos por critérios específicos (nome, sobrenome, empresa ou etiquetas).
- **Persistência de Dados Relacional:** Mapeamento eficiente das entidades para garantir consistência e performance em consultas complexas.

## 🛠️ Tecnologias Utilizadas

O ecossistema técnico do projeto foi selecionado para garantir alta performance e alinhamento com os padrões da indústria:

- **Linguagem Principal:** [Java 17+](https://www.oracle.com/java/)
- **Framework Base:** [Spring Boot 3.x](https://spring.io/projects/spring-boot)
  - *Spring Web:* Para a construção dos controladores REST e manipulação de requisições HTTP.
  - *Spring Data JPA:* Para a abstração da camada de persistência e integração ORM.
  - *Spring Validation:* Para validação de dados via anotações na camada de DTOs.
- **Mapeamento de Objetos:** [Hibernate](https://hibernate.org/) (Implementação JPA)
- **Contentorização:** [Docker](https://www.docker.com/) & [Docker Compose](https://docs.docker.com/compose/)
- **Gestor de Dependências:** Maven / Gradle

---

## Arquitetura e Boas Práticas

O projeto foi edificado com foco em qualidade de código, adotando:
- **Princípios SOLID:** Divisão clara de responsabilidades, facilitando a extensão e os testes unitários.
- **Clean Code:** Métodos coesos, nomes autoexplicativos e refatoração contínua para evitar débitos técnicos.
- **Camadas Bem Definidas:**
  - `Controller`: Gestão de rotas, requisições e respostas HTTP.
  - `Service`: Centralização das regras de negócio e validações lógicas.
  - `Repository`: Interface de comunicação direta com a base de dados.
  - `DTO (Data Transfer Object)`: Isolamento das entidades de domínio contra exposição desnecessária na rede.

---

## Como Executar o Projeto

### Pré-requisitos
Antes de iniciar, certifique-se de que possui instalado na sua máquina:
- Java JDK 17 ou superior
- Docker e Docker Compose (Opcional, mas recomendado)
- Gestor de base de dados à escolha ou ambiente configurado

### Instalação e Configuração

1. Clone o repositório para o seu ambiente local:
   ```bash
   git clone https://github.com/Medeiroshenrique/AgendaContatos.git
2. Entre na pasta:
   ```bash
   cd AgendaContatos
