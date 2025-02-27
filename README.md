# Prato Do Dia

<img src="https://github.com/user-attachments/assets/3ca57226-4557-4f47-90db-7febd548b84e">

O projeto **PratodoDia** é um sistema interativo de receitas desenvolvido para ajudar os usuários a descobrir e compartilhar receitas culinárias com base nos ingredientes que têm em casa. A plataforma é projetada para ser colaborativa e prática, permitindo que qualquer pessoa encontre inspiração para suas refeições diárias, mesmo com restrições alimentares ou preferências específicas. Além de sugerir receitas, o PratodoDia oferece funcionalidades como gestão de ingredientes, cadastro, salvamento e compartilhamento de receitas. O objetivo é criar uma experiência intuitiva e acessível para todos, desde cozinheiros iniciantes até chefs experientes.

## Tutorial de Configuração do Projeto ASP.NET Core com MySQL

### **Requisitos:**

Antes de começar, certifique-se de ter os seguintes pré-requisitos instalados:

1. **Microsoft Visual Studio** (2019 ou superior)
    - [Download do Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/)
    - Durante a instalação, selecione a carga de trabalho **"Desenvolvimento para .NET"**.
2. **MySQL Server**
    - [Download do MySQL Community Server](https://dev.mysql.com/downloads/installer/)
    - Durante a instalação, crie um usuário com privilégios (por padrão, o usuário **root** é criado) e lembre-se da **senha** que será utilizada para configurar a conexão no aplicativo.
    - Certifique-se de manter a porta **3306** padrão.

---

### **Passo a Passo para Configuração do Projeto:**

1. **Baixe o código-fonte do projeto:**
    - Obtenha o código do projeto **pratododia** do repositório fornecido (GitHub, repositório interno, etc.).
    - Após o download, você encontrará duas pastas: **docs** e **src**.
        - A pasta **docs** contém a documentação.
        - A pasta **src** contém o código-fonte. Dentro dela, você encontrará a pasta **pratododia-project**, que é onde está o arquivo de solução (`pratododia-projetct.sln`).
2. **Abra o Projeto no Visual Studio:**
    - No Visual Studio, vá até **Arquivo > Abrir > Projeto/Solução** e abra a solução `pratododia-project.sln` localizada dentro da pasta **src/pratododia-project**.
3. **Configuração da Conexão com o Banco de Dados:**
    - Abra o arquivo **`appsettings.json`** no Visual Studio.
    - Localize a chave **`DefaultConnection`** na seção **ConnectionStrings** e edite-a com os dados do seu banco de dados, conforme abaixo:
    
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "server=localhost;database=pratododia;user=root;password=SUA_SENHA_AQUI;port=3306;SslMode=none"
    }
    ```
    
    - **Substitua** `SUA_SENHA_AQUI` pela senha criada na instalação do MySQL.
4. **Abrir o Console do Gerenciador de Pacotes NuGet no Visual Studio:**
    - No Visual Studio, vá para **Ferramentas > Gerenciador de Pacotes do NuGet > Console do Gerenciador de Pacotes**.
5. **Executar as Migrations:**
    - No console do Gerenciador de Pacotes, digite o seguinte comando para aplicar as migrações ao banco de dados:
    
    ```bash
    update-database
    ```
    
    - Esse comando aplicará as migrações e criará as tabelas no banco de dados MySQL, conforme o modelo definido no projeto.
6. **Rodar o Projeto com IIS Express:**
- No Visual Studio, no menu superior, localize a **caixa de seleção** onde você pode escolher o ambiente de execução (geralmente está configurado para usar **IIS Express** por padrão).
- Clique no botão **Iniciar** ou pressione **F5** no teclado.
- O Visual Studio irá compilar o projeto e iniciar o servidor **IIS Express**. Ele abrirá uma nova janela do navegador apontando para a URL do seu aplicativo (geralmente algo como `http://localhost:5000` ou `https://localhost:5001`).
- **Nota**: Caso seja necessário, o IIS Express será configurado automaticamente pelo Visual Studio. Se for o primeiro vez que você está rodando o projeto, o Visual Studio pode demorar alguns minutos para configurar e compilar tudo corretamente.

# Documentação

<ol>
<li><a href="docs/01-Documentação de Contexto.md"> Documentação de Contexto</a></li>
<li><a href="docs/02-Especificação do Projeto.md"> Especificação do Projeto</a></li>
<li><a href="docs/03-Metodologia.md"> Metodologia</a></li>
<li><a href="docs/04-Projeto de Interface.md"> Projeto de Interface</a></li>
<li><a href="docs/05-Arquitetura da Solução.md"> Arquitetura da Solução</a></li>
<li><a href="docs/06-Template Padrão da Aplicação.md"> Template Padrão da Aplicação</a></li>
<li><a href="docs/07-Programação de Funcionalidades.md"> Programação de Funcionalidades</a></li>
<li><a href="docs/08-Plano de Testes de Software.md"> Plano de Testes de Software</a></li>
<li><a href="docs/09-Registro de Testes de Software.md"> Registro de Testes de Software</a></li>
<li><a href="docs/10-Plano de Testes de Usabilidade.md"> Plano de Testes de Usabilidade</a></li>
<li><a href="docs/11-Registro de Testes de Usabilidade.md"> Registro de Testes de Usabilidade</a></li>
<li><a href="docs/12-Apresentação do Projeto.md"> Apresentação do Projeto</a></li>
<li><a href="docs/13-Referências.md"> Referências</a></li>
</ol>
