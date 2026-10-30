# 🍽️ Prato Do Dia

<img src="https://github.com/user-attachments/assets/3ca57226-4557-4f47-90db-7febd548b84e" alt="Banner Prato do Dia">

`Jul/24 - Dez/24`

`ASP.NET Core MVC, .NET 8, MySQL, Azure, CSS, Bootstrap, HTML, JS`

O projeto **Prato do Dia** é um sistema interativo de receitas desenvolvido para ajudar os usuários a descobrir e compartilhar receitas culinárias com base nos ingredientes que têm em casa. A plataforma é projetada para ser colaborativa e prática, permitindo que qualquer pessoa encontre inspiração para suas refeições diárias, mesmo com restrições alimentares ou preferências específicas. Além de sugerir receitas, o Prato do Dia oferece funcionalidades como gestão de ingredientes, cadastro, salvamento e compartilhamento de receitas. O objetivo é criar uma experiência intuitiva e acessível para todos, desde cozinheiros iniciantes até chefs experientes.

🔗 **[Acesse a aplicação](https://pratododia.lucastoti.com/)**

📋 **[Tutorial de configuração para uso local](#como-executar-localmente)**

## 🖼️ Galeria

![Captura de tela 2025-02-27 074103](https://github.com/user-attachments/assets/a62775a9-fd28-4dd5-b2d0-1819d25a25cc)
![Captura de tela 2025-02-27 074122](https://github.com/user-attachments/assets/4fbcffda-5629-4818-8710-3e45ef1d8f0c)
![Captura de tela 2025-02-27 074136](https://github.com/user-attachments/assets/cb946e63-59c6-41b8-aebe-63888637249d)
![Captura de tela 2025-02-27 074200](https://github.com/user-attachments/assets/bb3b2fda-5976-4bbc-bbdd-0911ead50463)
![Captura de tela 2025-02-27 074211](https://github.com/user-attachments/assets/18fb0edf-b8df-4738-9abf-5ec084256612)

## Como executar localmente

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- **MySQL 8.0** em execução
- **Git**
- **EF Core CLI** (`dotnet-ef`) para aplicar as migrations
- Opcional: **Visual Studio 2022** (versão 17.8 ou superior), com a carga de trabalho de desenvolvimento web e ASP.NET

### 1. Clonar o repositório

```bash
git clone https://github.com/LcsToti/PratoDoDia.git
cd PratoDoDia
```

O arquivo `pratododia-project.sln` e o projeto `pratododia-project.csproj` estão na **raiz** do repositório.

### 2. Configurar o MySQL

Copie `.env.example` para `.env` na raiz do projeto.

**PowerShell (Windows):**

```powershell
Copy-Item .env.example .env
```

**Linux/macOS:**

```bash
cp .env.example .env
```

Edite o arquivo `.env` com os dados do seu MySQL local:

```dotenv
Db__Server=localhost
Db__Port=3306
Db__Database=pratododia
Db__User=root
Db__Password=SUA_SENHA
Db__SslMode=none
```

> O aplicativo lê essas configurações por meio de variáveis `Db__*`, carregadas do arquivo `.env`. A chave `ConnectionStrings:DefaultConnection` **não é usada** nesta versão. O arquivo `.env` está no `.gitignore`; não publique senhas reais.

### 3. Restaurar dependências e aplicar as migrations

Na raiz do repositório:

```bash
dotnet restore
dotnet tool install --global dotnet-ef --version 8.0.3
dotnet ef database update
```

Caso `dotnet-ef` já esteja instalado, basta verificar se sua versão é compatível com o EF Core 8. Antes de aplicar as migrations, o MySQL deve estar em execução e as credenciais do `.env` precisam estar corretas.

### 4. Executar a aplicação

**Pelo terminal:**

```bash
dotnet run --launch-profile http
```

Acesse **http://localhost:5166**.

Para usar o perfil HTTPS:

```bash
dotnet run --launch-profile https
```

Acesse **https://localhost:7094** (pode ser necessário confiar no certificado de desenvolvimento do .NET).

**Pelo Visual Studio 2022:** abra `pratododia-project.sln`, escolha um perfil de execução (`http`, `https` ou `IIS Express`) e inicie a aplicação. Os endereços variam conforme o perfil; os acima correspondem aos perfis `http` e `https` em `Properties/launchSettings.json`.

### Estrutura principal

```text
PratoDoDia/
├── Controllers/                 # Controllers MVC
├── Migrations/                  # Migrations do Entity Framework Core
├── Models/                      # Modelos e contexto de dados
├── Properties/                  # Configurações de execução
├── ViewModels/                  # Modelos utilizados nas views
├── Views/                       # Views Razor
├── wwwroot/                     # Arquivos estáticos
├── Program.cs                   # Inicialização e configuração da aplicação
├── pratododia-project.csproj    # Projeto .NET 8
├── pratododia-project.sln       # Solução do Visual Studio
├── appsettings.json             # Configurações gerais da aplicação
├── .env.example                 # Modelo de configuração do banco
├── Dockerfile                   # Imagem Docker da aplicação
└── docker-compose.yml           # Orquestração dos serviços
```

### Observação sobre Docker

O repositório possui `Dockerfile` e `docker-compose.yml` com serviços para o aplicativo, o MySQL e a execução de migrations. O Compose atual depende da rede externa `npm-data_default`, usada na infraestrutura de implantação. Para executá-lo isoladamente em outra máquina, é necessário adaptar essa configuração de rede.
