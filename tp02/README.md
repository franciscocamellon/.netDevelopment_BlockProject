
<style>
* {
  box-sizing: border-box;
}
.column {
  float: left;
  padding: 10px;
}

.left {
  width: 50%;
}

.right {
  width: 50%;
}

/* Clear floats after the columns */
.row:after {
  content: "";
  display: table;
  clear: both;
}
</style>
<div class="row">
  <div class="column left" style="align:left;">
    <a href="https://github.com/franciscocamellon/.netDevelopment_BlockProject/wiki">1 - Home</a>
  </div>
  <div class="column right" style="align:right;">
    <a href="https://github.com/franciscocamellon/.netDevelopment_BlockProject/tree/master/tp01#13--requisitos-de-usu%C3%A1rio">3 - Requisitos de usuário</a>
  </div>
</div>


---



## 4	- Requisitos de sistema.  
 
### R01 - Criar perfil na rede social - Dev/Empresa

| Requisito RS1 | Criar perfil na rede social|
|---------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Atores | DEV - Empresa|
| Pré-condição              | Não possuir um perfil na rede|
| Fluxo Básico              | Um DEV ou uma empresa acessa a interface para criar um perfil na rede social  <br>O DEV ou a Empresa informa seu nome<br>O DEV ou a Empresa informa seu e-mail<br>O DEV ou a Empresa informa uma senha<br>O DEV informa sua data de nascimento<br>O DEV ou a Empresa informa seu endereço<br>O DEV preenche se está ou não procurando emprego<br>O DEV ou a Empresa executa a criação do perfil |
| Pós   condição            | Um perfil é criado com os dados   informados pelo DEV ou pela Empresa|
| Fluxo alternativo         | O DEV ou a Empresa não informa um dos   dados solicitados na interface de criação de perfil e então executa a criação   do perfil. Quando isso ocorrer, a mensagem “{nomeDoCampo} é obrigatório(a)”.   Onde {nomeDoCampo} deve ser substituído pelo nome do campo não preenchido.<br>     Exemplos:<br>     “Nome é obrigatório(a)”<br>     “Data de nascimento é obrigatório(a)”<br>O DEV ou a Empresa informa um e-mail que já está associado a algum perfil. Quando a   pessoa executar a criação do perfil, a mensagem “Esse e-mail já está associado   a um perfil” deve ser exibida.  |
| Dados                     | Nome: Texto, máximo de 100   caracteres, não pode conter números.<br>Senha: Mais de 8 caracteres.<br>Data de nascimento: Data válida. Permite no mínimo 18 anos.<br>Endereço: Logradouro, número, complemento, bairro, cidade e estado. Todos   os dados do tipo texto.<br>Em busca de emprego: checkbox para o DEV marcar sim ou não|
| Requisitos   relacionados | RF2, RF3 (são exemplos aqui)|

### R02 - Organizar e gerenciar seu portifólio - Dev

| Requisito RS1 | Criar perfil na rede social|
|---------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Atores | DEV - Empresa|
| Pré-condição              | Não possuir um perfil na rede|
| Fluxo Básico              | Um DEV ou uma empresa acessa a interface para criar um perfil na rede social  <br>O DEV ou a Empresa informa seu nome<br>O DEV ou a Empresa informa seu e-mail<br>O DEV ou a Empresa informa uma senha<br>O DEV informa sua data de nascimento<br>O DEV ou a Empresa informa seu endereço<br>O DEV preenche se está ou não procurando emprego<br>O DEV ou a Empresa executa a criação do perfil |
| Pós   condição            | Um perfil é criado com os dados   informados pelo DEV ou pela Empresa|
| Fluxo alternativo         | O DEV ou a Empresa não informa um dos   dados solicitados na interface de criação de perfil e então executa a criação   do perfil. Quando isso ocorrer, a mensagem “{nomeDoCampo} é obrigatório(a)”.   Onde {nomeDoCampo} deve ser substituído pelo nome do campo não preenchido.<br>     Exemplos:<br>     “Nome é obrigatório(a)”<br>     “Data de nascimento é obrigatório(a)”<br>O DEV ou a Empresa informa um e-mail que já está associado a algum perfil. Quando a   pessoa executar a criação do perfil, a mensagem “Esse e-mail já está associado   a um perfil” deve ser exibida.  |
| Dados                     | Nome: Texto, máximo de 100   caracteres, não pode conter números.<br>Senha: Mais de 8 caracteres.<br>Data de nascimento: Data válida. Permite no mínimo 18 anos.<br>Endereço: Logradouro, número, complemento, bairro, cidade e estado. Todos   os dados do tipo texto.<br>Em busca de emprego: checkbox para o DEV marcar sim ou não|
| Requisitos   relacionados | RF2, RF3 (são exemplos aqui)|

### R04 - Ser visto por empresas - Dev

| Requisito RS1 | Criar perfil na rede social|
|---------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Atores | DEV - Empresa|
| Pré-condição              | Não possuir um perfil na rede|
| Fluxo Básico              | Um DEV ou uma empresa acessa a interface para criar um perfil na rede social  <br>O DEV ou a Empresa informa seu nome<br>O DEV ou a Empresa informa seu e-mail<br>O DEV ou a Empresa informa uma senha<br>O DEV informa sua data de nascimento<br>O DEV ou a Empresa informa seu endereço<br>O DEV preenche se está ou não procurando emprego<br>O DEV ou a Empresa executa a criação do perfil |
| Pós   condição            | Um perfil é criado com os dados   informados pelo DEV ou pela Empresa|
| Fluxo alternativo         | O DEV ou a Empresa não informa um dos   dados solicitados na interface de criação de perfil e então executa a criação   do perfil. Quando isso ocorrer, a mensagem “{nomeDoCampo} é obrigatório(a)”.   Onde {nomeDoCampo} deve ser substituído pelo nome do campo não preenchido.<br>     Exemplos:<br>     “Nome é obrigatório(a)”<br>     “Data de nascimento é obrigatório(a)”<br>O DEV ou a Empresa informa um e-mail que já está associado a algum perfil. Quando a   pessoa executar a criação do perfil, a mensagem “Esse e-mail já está associado   a um perfil” deve ser exibida.  |
| Dados                     | Nome: Texto, máximo de 100   caracteres, não pode conter números.<br>Senha: Mais de 8 caracteres.<br>Data de nascimento: Data válida. Permite no mínimo 18 anos.<br>Endereço: Logradouro, número, complemento, bairro, cidade e estado. Todos   os dados do tipo texto.<br>Em busca de emprego: checkbox para o DEV marcar sim ou não|
| Requisitos   relacionados | RF2, RF3 (são exemplos aqui)|

### R05 - Receber e enviar mensagens para as empresas - Dev

| Requisito RS1 | Criar perfil na rede social|
|---------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Atores | DEV - Empresa|
| Pré-condição              | Não possuir um perfil na rede|
| Fluxo Básico              | Um DEV ou uma empresa acessa a interface para criar um perfil na rede social  <br>O DEV ou a Empresa informa seu nome<br>O DEV ou a Empresa informa seu e-mail<br>O DEV ou a Empresa informa uma senha<br>O DEV informa sua data de nascimento<br>O DEV ou a Empresa informa seu endereço<br>O DEV preenche se está ou não procurando emprego<br>O DEV ou a Empresa executa a criação do perfil |
| Pós   condição            | Um perfil é criado com os dados   informados pelo DEV ou pela Empresa|
| Fluxo alternativo         | O DEV ou a Empresa não informa um dos   dados solicitados na interface de criação de perfil e então executa a criação   do perfil. Quando isso ocorrer, a mensagem “{nomeDoCampo} é obrigatório(a)”.   Onde {nomeDoCampo} deve ser substituído pelo nome do campo não preenchido.<br>     Exemplos:<br>     “Nome é obrigatório(a)”<br>     “Data de nascimento é obrigatório(a)”<br>O DEV ou a Empresa informa um e-mail que já está associado a algum perfil. Quando a   pessoa executar a criação do perfil, a mensagem “Esse e-mail já está associado   a um perfil” deve ser exibida.  |
| Dados                     | Nome: Texto, máximo de 100   caracteres, não pode conter números.<br>Senha: Mais de 8 caracteres.<br>Data de nascimento: Data válida. Permite no mínimo 18 anos.<br>Endereço: Logradouro, número, complemento, bairro, cidade e estado. Todos   os dados do tipo texto.<br>Em busca de emprego: checkbox para o DEV marcar sim ou não|
| Requisitos   relacionados | RF2, RF3 (são exemplos aqui)|


### R08 - Criar e deletar demanda por profissional - Empresa
| Requisito RS1 | Criar perfil na rede social|
|---------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Atores | DEV - Empresa|
| Pré-condição              | Não possuir um perfil na rede|
| Fluxo Básico              | Um DEV ou uma empresa acessa a interface para criar um perfil na rede social  <br>O DEV ou a Empresa informa seu nome<br>O DEV ou a Empresa informa seu e-mail<br>O DEV ou a Empresa informa uma senha<br>O DEV informa sua data de nascimento<br>O DEV ou a Empresa informa seu endereço<br>O DEV preenche se está ou não procurando emprego<br>O DEV ou a Empresa executa a criação do perfil |
| Pós   condição            | Um perfil é criado com os dados   informados pelo DEV ou pela Empresa|
| Fluxo alternativo         | O DEV ou a Empresa não informa um dos   dados solicitados na interface de criação de perfil e então executa a criação   do perfil. Quando isso ocorrer, a mensagem “{nomeDoCampo} é obrigatório(a)”.   Onde {nomeDoCampo} deve ser substituído pelo nome do campo não preenchido.<br>     Exemplos:<br>     “Nome é obrigatório(a)”<br>     “Data de nascimento é obrigatório(a)”<br>O DEV ou a Empresa informa um e-mail que já está associado a algum perfil. Quando a   pessoa executar a criação do perfil, a mensagem “Esse e-mail já está associado   a um perfil” deve ser exibida.  |
| Dados                     | Nome: Texto, máximo de 100   caracteres, não pode conter números.<br>Senha: Mais de 8 caracteres.<br>Data de nascimento: Data válida. Permite no mínimo 18 anos.<br>Endereço: Logradouro, número, complemento, bairro, cidade e estado. Todos   os dados do tipo texto.<br>Em busca de emprego: checkbox para o DEV marcar sim ou não|
| Requisitos   relacionados | RF2, RF3 (são exemplos aqui)


</style>
<div class="row">
  <div class="column left" style="align:left;">
    <a href="https://github.com/franciscocamellon/.netDevelopment_BlockProject/wiki">1 - Home</a>
  </div>
  <div class="column right" style="align:right;">
    <a href="https://github.com/franciscocamellon/.netDevelopment_BlockProject/tree/master/tp01#13--requisitos-de-usu%C3%A1rio">3 - Requisitos de usuário</a>
  </div>
</div>