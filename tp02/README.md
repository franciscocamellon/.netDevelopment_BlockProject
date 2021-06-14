

<div class="row">
  <div class="column left" style="align:left;">
    <a href="https://github.com/franciscocamellon/.netDevelopment_BlockProject/wiki">1 - Home</a>
  </div>
  <div class="column right" style="align:right;">
    <a href="https://github.com/franciscocamellon/.netDevelopment_BlockProject/tree/master/tp01#13--requisitos-de-usu%C3%A1rio">3 - Requisitos de usuário</a>
  </div>
</div>


---



## 4	- Requisitos de sistema   
 
### RS1 - Criar perfil na rede social - Dev/Empresa

| Requisito RS1 | Criar perfil na rede social|
|---------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Atores | DEV - Empresa|
| Pré-condição              | Não possuir um perfil na rede|
| Fluxo Básico              | Os Atores acessa a interface para criar um perfil na rede social  <br>Os Atores informam seu nome<br>Os Atores informam seu e-mail<br>Os Atores informam uma senha<br>O DEV informa sua data de nascimento<br>Os Atores informam seu endereço<br>O DEV preenche se está ou não procurando emprego<br>Os Atores executam a criação do perfil |
| Pós   condição            | Um perfil é criado com os dados   informados pelo DEV ou pela Empresa|
| Fluxo alternativo         | Os Atores não informam um dos   dados solicitados na interface de criação de perfil e então executa a criação   do perfil. Quando isso ocorrer, a mensagem “{firstName} é obrigatório(a)”.<br>     Exemplos:<br>     “Nome é obrigatório(a)”<br>     “Data de nascimento é obrigatório(a)”<br>Os Atores informam um e-mail que já está associado a algum perfil. Quando executarem a criação do perfil, a mensagem “Esse e-mail já está associado   a um perfil” deverá ser exibida.  |
| Dados                     | Nome: Texto, máximo de 100   caracteres, não pode conter números.<br>Senha: Mais de 8 caracteres.<br>Data de nascimento: Data válida. Permite no mínimo 18 anos.<br>Endereço: Logradouro, número, complemento, bairro, cidade e estado. Todos   os dados do tipo texto.<br>Em busca de emprego: checkbox para o DEV marcar sim ou não|
| Requisitos   relacionados | - // - - // -|

### RS2 - Organizar e gerenciar seu portifólio - Dev

| Requisito RS2 | Organizar e gerenciar seu portifólio|
|---------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Ator | DEV |
| Pré-condição              | Possuir um perfil tipo DEV na rede|
| Fluxo Básico              | O Ator acessa a interface através de seu perfil<br>O Ator faz uma requisição de edição de seu perfil<br>O Ator adiciona os projetos em que já trabalhou<br>O Ator inclui links para seu perfil em sites como Github, Fiverr, Upwork, etc<br>O Ator faz uma requisição de salvamento das informações|
| Pós   condição            | Uma página com um portifólio é criada com os dados   informados pelo ator|
| Fluxo alternativo         | O Ator não informa nenhum projeto e então executa o salvamento do portifolio. Quando isso ocorrer, a mensagem “Erro ao criar portifólio, você não adicionou nenhum projeto!” deverá ser exibida.<br>     Exemplos:<br>     O Ator informa um projeto já existente. Quando o Ator executar salvamento do portifólio, a mensagem “O projeto {projectName} já existe!” deverá ser exibida.  |
| Dados                     | Nome do projeto: Texto, máximo de 100   caracteres.<br>Contratante: texto, máximo de 100 caracteres.<br>Tecnologia utilizada: lista das tecnologias envolvidas.<br>Data de início: Data válida. <br>Data de fim: Data válida. <br>Links: links válidos para os projetos.|
| Requisitos   relacionados | RS1 |

### RS4 - Ser visto por empresas

| Requisito RS4 | Ser visto por empresas|
|---------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Ator | Empresa|
| Pré-condição              | Possuir um perfil do tipo EMPRESA na rede|
| Fluxo Básico              | Um DEV ou uma empresa acessa a interface para criar um perfil na rede social  <br>O DEV ou a Empresa informa seu nome<br>O DEV ou a Empresa informa seu e-mail<br>O DEV ou a Empresa informa uma senha<br>O DEV informa sua data de nascimento<br>O DEV ou a Empresa informa seu endereço<br>O DEV preenche se está ou não procurando emprego<br>O DEV ou a Empresa executa a criação do perfil |
| Pós   condição            | Um perfil é criado com os dados   informados pelo DEV ou pela Empresa|
| Fluxo alternativo         | O DEV ou a Empresa não informa um dos   dados solicitados na interface de criação de perfil e então executa a criação   do perfil. Quando isso ocorrer, a mensagem “{nomeDoCampo} é obrigatório(a)”.   Onde {nomeDoCampo} deve ser substituído pelo nome do campo não preenchido.<br>     Exemplos:<br>     “Nome é obrigatório(a)”<br>     “Data de nascimento é obrigatório(a)”<br>O DEV ou a Empresa informa um e-mail que já está associado a algum perfil. Quando a   pessoa executar a criação do perfil, a mensagem “Esse e-mail já está associado   a um perfil” deve ser exibida.  |
| Dados                     | Nome: Texto, máximo de 100   caracteres, não pode conter números.<br>Senha: Mais de 8 caracteres.<br>Data de nascimento: Data válida. Permite no mínimo 18 anos.<br>Endereço: Logradouro, número, complemento, bairro, cidade e estado. Todos   os dados do tipo texto.<br>Em busca de emprego: checkbox para o DEV marcar sim ou não|
| Requisitos   relacionados | RF2, RF3 (são exemplos aqui)|

### RS5 - Receber e enviar mensagens para as empresas - Dev

| Requisito RS5 | Receber e enviar mensagens para as empresas|
|---------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Atores | DEV - Empresa|
| Pré-condição              | Não possuir um perfil na rede|
| Fluxo Básico              | Um DEV ou uma empresa acessa a interface para criar um perfil na rede social  <br>O DEV ou a Empresa informa seu nome<br>O DEV ou a Empresa informa seu e-mail<br>O DEV ou a Empresa informa uma senha<br>O DEV informa sua data de nascimento<br>O DEV ou a Empresa informa seu endereço<br>O DEV preenche se está ou não procurando emprego<br>O DEV ou a Empresa executa a criação do perfil |
| Pós   condição            | Um perfil é criado com os dados   informados pelo DEV ou pela Empresa|
| Fluxo alternativo         | O DEV ou a Empresa não informa um dos   dados solicitados na interface de criação de perfil e então executa a criação   do perfil. Quando isso ocorrer, a mensagem “{nomeDoCampo} é obrigatório(a)”.   Onde {nomeDoCampo} deve ser substituído pelo nome do campo não preenchido.<br>     Exemplos:<br>     “Nome é obrigatório(a)”<br>     “Data de nascimento é obrigatório(a)”<br>O DEV ou a Empresa informa um e-mail que já está associado a algum perfil. Quando a   pessoa executar a criação do perfil, a mensagem “Esse e-mail já está associado   a um perfil” deve ser exibida.  |
| Dados                     | Nome: Texto, máximo de 100   caracteres, não pode conter números.<br>Senha: Mais de 8 caracteres.<br>Data de nascimento: Data válida. Permite no mínimo 18 anos.<br>Endereço: Logradouro, número, complemento, bairro, cidade e estado. Todos   os dados do tipo texto.<br>Em busca de emprego: checkbox para o DEV marcar sim ou não|
| Requisitos   relacionados | RF2, RF3 (são exemplos aqui)|


### RS8 - Criar e deletar demanda por profissional - Empresa
| Requisito RS8 | Criar e deletar demanda por profissional|
|---------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Ator | Empresa|
| Pré-condição              | Não possuir um perfil na rede|
| Fluxo Básico              | Um DEV ou uma empresa acessa a interface para criar um perfil na rede social  <br>O DEV ou a Empresa informa seu nome<br>O DEV ou a Empresa informa seu e-mail<br>O DEV ou a Empresa informa uma senha<br>O DEV informa sua data de nascimento<br>O DEV ou a Empresa informa seu endereço<br>O DEV preenche se está ou não procurando emprego<br>O DEV ou a Empresa executa a criação do perfil |
| Pós   condição            | Um perfil é criado com os dados   informados pelo DEV ou pela Empresa|
| Fluxo alternativo         | O DEV ou a Empresa não informa um dos   dados solicitados na interface de criação de perfil e então executa a criação   do perfil. Quando isso ocorrer, a mensagem “{nomeDoCampo} é obrigatório(a)”.   Onde {nomeDoCampo} deve ser substituído pelo nome do campo não preenchido.<br>     Exemplos:<br>     “Nome é obrigatório(a)”<br>     “Data de nascimento é obrigatório(a)”<br>O DEV ou a Empresa informa um e-mail que já está associado a algum perfil. Quando a   pessoa executar a criação do perfil, a mensagem “Esse e-mail já está associado   a um perfil” deve ser exibida.  |
| Dados                     | Nome: Texto, máximo de 100   caracteres, não pode conter números.<br>Senha: Mais de 8 caracteres.<br>Data de nascimento: Data válida. Permite no mínimo 18 anos.<br>Endereço: Logradouro, número, complemento, bairro, cidade e estado. Todos   os dados do tipo texto.<br>Em busca de emprego: checkbox para o DEV marcar sim ou não|
| Requisitos   relacionados | RF2, RF3 (são exemplos aqui)


<table>
  <tr style="text-align:left;width:50%;">
   <td>
      <a href="https://github.com/franciscocamellon/.netDevelopment_BlockProject/wiki">1 - Home</a>
   </td>
   <td style="text-align:right;width:50%;">
      <a href="https://github.com/franciscocamellon/.netDevelopment_BlockProject/tree/master/tp01#13--requisitos-de-usu%C3%A1rio">3 - Requisitos de usuário</a>
   </td>
  </tr>
</table>